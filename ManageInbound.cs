using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INVT {
    public partial class ManageInbound : Form {

        private string CurrentNF = "";

        public ManageInbound() {
            InitializeComponent();

            BtnExcluir.Enabled = false;
            BtnEditar.Enabled = false;
        }

        void FillData() {

            DgItens.Rows.Clear();
            DgSubItem.Rows.Clear();

            string selectCommand = $"SELECT NumeroNF, Descricao, ValorNF, DataEntrega FROM EventoEntrada";
            string filter = "WHERE 1=1";

            if (CbCodigo.Checked)
                filter += $" AND NumeroNF LIKE '%{TbCodigo.Text}%'";

            if (CbDescricao.Checked)
                filter += $" AND Descricao LIKE '%{TbDescricao.Text}%'";

            if (CbData.Checked)
                filter += $" AND (DataEntrega >= '{DtDe.Text}' AND DataEntrega <= '{DtAte.Text}')";

            DataTable table = SQLConn.GetTable($"{selectCommand} {filter}");

            foreach (DataRow dr in table.Rows) {

                long quantidadeItem = SQLConn.GetIntValue($"SELECT COUNT(QUANTIDADE) FROM ItemNF WHERE NumeroNF = '{dr[0]}'");

                DgItens.Rows.Add(dr[0], dr[1], quantidadeItem.ToString(), dr[2], dr[3]);

            }

        }

        void FillSubItem() {

            DgSubItem.Rows.Clear();

            DataTable table = SQLConn.GetTable($"SELECT CodigoProduto, Quantidade FROM ItemNF WHERE NumeroNF = '{CurrentNF}'");

            foreach (DataRow dr in table.Rows) {

                DataTable nomeProduto = SQLConn.GetTable($"SELECT Produto FROM Produto WHERE CodigoProduto = {dr[0]}");

                foreach (DataRow sub in nomeProduto.Rows) {
                    DgSubItem.Rows.Add(sub[0], dr[1]);
                }

            }

        }

        private void ManageInbound_Shown(object sender, EventArgs e) {
            FillData();
        }

        private void DgItens_CellClick(object sender, DataGridViewCellEventArgs e) {

            if (e.RowIndex == -1)
                return;

            DataGridViewRow dgvRow = DgItens.Rows[e.RowIndex];

            CurrentNF = dgvRow.Cells[0].Value.ToString();

            if (CurrentNF == "" || CurrentNF == null)
                return;

            FillSubItem();
            BtnExcluir.Enabled = true;
            //BtnEditar.Enabled = true;

            TbNota.Text = CurrentNF;

        }

        private void BtnCriar_Click(object sender, EventArgs e) {
            CreateInbound createInbound = new CreateInbound("");
            createInbound.ShowDialog();
            FillData();
        }

        private void BtnExcluir_Click(object sender, EventArgs e) {

            DialogResult dr = MessageBox.Show($"Tem certeza que deseja deletar a Nota Fiscal {CurrentNF}? Ao fazer isso, todos os produtos da nota serão removidos do estoque.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.No)
                return;

            DataTable subitem = SQLConn.GetTable($"SELECT * FROM ItemNF WHERE NumeroNF = '{CurrentNF}'");

            foreach (DataRow row in subitem.Rows) {
                SQLConn.RunSQLCommand($"UPDATE Produto SET Estoque = Estoque - {row[3]} WHERE CodigoProduto = {row[2]}");
            }

            SQLConn.RunSQLCommand($"DELETE FROM ItemNF WHERE NumeroNF = '{CurrentNF}'");
            SQLConn.RunSQLCommand($"DELETE FROM EventoEntrada WHERE NumeroNF = '{CurrentNF}'");

            FillData();

        }

        private void CbCodigo_CheckedChanged(object sender, EventArgs e) {
            if (CbCodigo.Checked)
                TbCodigo.ReadOnly = false;
            else {
                TbCodigo.ReadOnly = true;
                TbCodigo.Text = "";
                FillData();
            }
        }

        private void CbDescricao_CheckedChanged(object sender, EventArgs e) {
            if (CbDescricao.Checked)
                TbDescricao.ReadOnly = false;
            else {
                TbDescricao.ReadOnly = true;
                TbDescricao.Text = "";
                FillData();
            }
        }

        private void CbData_CheckedChanged(object sender, EventArgs e) {
            if (CbData.Checked) {
                DtDe.Enabled = true;
                DtAte.Enabled = true;
            } else {
                DtDe.Enabled = false;
                DtAte.Enabled = false;
            }
            FillData();
        }

        private void TbCodigo_TextChanged(object sender, EventArgs e) {
            FillData();
        }

        private void TbDescricao_TextChanged(object sender, EventArgs e) {
            FillData();
        }

        private void DtDe_ValueChanged(object sender, EventArgs e) {
            FillData();
        }

        private void DtAte_ValueChanged(object sender, EventArgs e) {
            FillData();
        }
    }
}
