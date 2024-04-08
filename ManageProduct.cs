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

    public partial class ManageProduct : Form {

        private int CurrentID = 0;

        public ManageProduct() {

            InitializeComponent();

            BtnDeletar.Enabled = false;
            BtnEditar.Enabled = false;
        }

        void UpdateData() {

            DgItens.Rows.Clear();

            string filter = $" WHERE 1=1";

            if (CbCodigo.Checked)
                filter += $" AND CodigoProduto LIKE '%{TbCodigo.Text}%'";

            if (CbDescricao.Checked)
                filter += $" AND Produto LIKE '%{TbDescricao.Text}%'";

            if (CbQuantidade.Checked)
                filter += $" AND (Estoque >= {NumQtdMin.Value} AND Estoque <= {NumQtdMax.Value})";

            DataTable dt = SQLConn.GetTable($"SELECT CodigoProduto, Produto, Estoque, EstoqueMinimo FROM Produto{filter}");

            foreach (DataRow dr in dt.Rows) {
                DgItens.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
            }

            Desselect();
        }

        private void Desselect() {

            TbSelecionado.Text = "";
            BtnEditar.Enabled = false;
            BtnDeletar.Enabled = false;

            if (DgItens.Rows.Count > 0)
                DgItens_CellClick(DgItens, new DataGridViewCellEventArgs(0, 0));

        }


        private void BtnCriar_Click(object sender, EventArgs e) {
            CreateProduct cr = new CreateProduct(true);
            cr.ShowDialog();
            UpdateData();
        }

        private void BtnDeletar_Click(object sender, EventArgs e) {

            if (CurrentID == 0)
                return;

            DialogResult dr = MessageBox.Show($"Você deseja deletar o ID '{CurrentID}'?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No)
                return;

            SQLConn.RunSQLCommand($"DELETE FROM Produto WHERE CodigoProduto = {CurrentID}");
            UpdateData();

        }

        private void BtnEditar_Click(object sender, EventArgs e) {
            CreateProduct cr = new CreateProduct(false, CurrentID);
            cr.ShowDialog();
            UpdateData();
        }

        private void CbCodigo_CheckedChanged(object sender, EventArgs e) {
            if (CbCodigo.Checked) {
                TbCodigo.ReadOnly = false;
            } else {
                TbCodigo.ReadOnly = true;
                TbCodigo.Text = "";
            }
        }


        private void CbDescricao_CheckedChanged(object sender, EventArgs e) {
            if (CbDescricao.Checked) {
                TbDescricao.ReadOnly = false;
            } else {
                TbDescricao.ReadOnly = true;
                TbDescricao.Text = "";
            }
        }

        private void CbQuantidade_CheckedChanged(object sender, EventArgs e) {
            if (CbQuantidade.Checked) {
                NumQtdMin.ReadOnly = false;
                NumQtdMax.ReadOnly = false;
            } else {
                NumQtdMin.ReadOnly = true;
                NumQtdMax.ReadOnly = true;
                NumQtdMin.Value = 0;
                NumQtdMax.Value = 0;
            }
        }

        private void TbCodigo_TextChanged(object sender, EventArgs e) {
            UpdateData();
        }

        private void TbDescricao_TextChanged(object sender, EventArgs e) {
            UpdateData();
        }

        private void NumQtdMin_ValueChanged(object sender, EventArgs e) {

            if (NumQtdMin.Value > NumQtdMax.Value)
                NumQtdMax.Value = NumQtdMin.Value;

            UpdateData();
        }

        private void NumQtdMax_ValueChanged(object sender, EventArgs e) {

            if (NumQtdMax.Value < NumQtdMin.Value)
                NumQtdMin.Value = NumQtdMax.Value;

            UpdateData();
        }

        private void DgItens_CellClick(object sender, DataGridViewCellEventArgs e) {

            if (e.RowIndex == -1)
                return;

            DataGridViewRow row = DgItens.Rows[e.RowIndex];

            CurrentID = Convert.ToInt32(row.Cells[0].Value.ToString());

            TbSelecionado.Text = CurrentID.ToString();

            if (TbSelecionado.Text != "") {
                BtnEditar.Enabled = true;
                BtnDeletar.Enabled = true;
            }

        }

        private void ManageProduct_Shown(object sender, EventArgs e) {
            UpdateData();
        }
    }
}
