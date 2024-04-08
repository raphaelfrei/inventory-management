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
    public partial class ManageOutbound : Form {

        private int CurrentID = 0;

        public ManageOutbound() {
            InitializeComponent();

            FillData();
        }

        void FillData() {

            DgItens.Rows.Clear();

            string filter = "WHERE 1=1";

            if (CbData.Checked)
                filter += $" AND (EventoSaida.DataEvento >= '{DtDe.Value.ToShortDateString()}' AND EventoSaida.DataEvento <= '{DtAte.Value.ToShortDateString()}')";

            if (CbUsuario.Checked)
                filter += $" AND (EventoSaida.RE LIKE '%{TbCodigo.Text}%' OR Funcionario.Nome LIKE '%{TbCodigo.Text}%')";

            DataTable table = SQLConn.GetTable($"SELECT EventoSaida.*, Funcionario.* FROM (EventoSaida INNER JOIN Funcionario ON EventoSaida.RE = Funcionario.RE) {filter}");

            foreach (DataRow dr in table.Rows) {
                DgItens.Rows.Add(dr[0], dr[1], dr[8], dr[7]);
            }

        }

        private void BtnCriar_Click(object sender, EventArgs e) {

            CreateOutbound create = new CreateOutbound();
            create.ShowDialog();

            FillData();

        }

        private void ManageOutbound_Shown(object sender, EventArgs e) {
            FillData();
        }

        private void CbUsuario_CheckedChanged(object sender, EventArgs e) {
            if (CbUsuario.Checked)
                TbCodigo.ReadOnly = false;
            else {
                TbCodigo.ReadOnly = true;
                TbCodigo.Text = "";
                FillData();
            }
        }

        private void CbProduto_CheckedChanged(object sender, EventArgs e) {
            if (CbProduto.Checked)
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

        private void BtnEditar_Click(object sender, EventArgs e) {

        }

        private void BtnExcluir_Click(object sender, EventArgs e) {
            return;

            DialogResult dr = MessageBox.Show("Você tem certeza que deseja excluir esse evento? Não é possível recuperar os dados.", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Cancel)
                return;

            SQLConn.RunSQLCommand($"DELETE * FROM EventoSaida WHERE CodigoEvento = {TbNota.Text}");

            BtnExcluir.Enabled = false;
            TbNota.Text = "";
            FillData();
        }

        private void DgItens_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1)
                return;

            DataGridViewRow row = DgItens.Rows[e.RowIndex];

            CurrentID = Convert.ToInt32(row.Cells[0].Value.ToString());

            TbNota.Text = CurrentID.ToString();

            if (TbNota.Text != "") {
                //BtnEditar.Enabled = true;
                //BtnExcluir.Enabled = true;
            }
        }
    }
}
