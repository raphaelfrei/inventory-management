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
    public partial class ManageCreateSector : Form {

        private int CurrentID = 0;

        public ManageCreateSector() {
            InitializeComponent();

            FillData();
        }

        public void FillData() {

            DgItens.Rows.Clear();
            string where = "WHERE 1=1";

            if (CbCodigo.Checked)
                where += $" AND CodigoSetor LIKE '%{TbCodigo.Text}%'";

            if (CbDescricao.Checked)
                where += $" AND DescricaoSetor LIKE '%{TbDescricao.Text}%'";

            DataTable table = SQLConn.GetTable($"SELECT * FROM Setor {where}");

            foreach (DataRow dr in table.Rows) {
                DgItens.Rows.Add(dr[0], dr[1]);
            }

        }

        private void BtnEditar_Click(object sender, EventArgs e) {
            CreateSector create = new CreateSector(CurrentID);
            create.ShowDialog();
            FillData();
        }

        private void BtnCriar_Click(object sender, EventArgs e) {
            CreateSector create = new CreateSector(0);
            create.ShowDialog();
            FillData();
        }

        private void DgItens_CellClick(object sender, DataGridViewCellEventArgs e) {

            if (e.RowIndex == -1)
                return;

            DataGridViewRow row = DgItens.Rows[e.RowIndex];

            CurrentID = Convert.ToInt32(row.Cells[0].Value.ToString());

            TbSelecionado.Text = CurrentID.ToString();

            if (TbSelecionado.Text != "") {
                BtnEditar.Enabled = true;
            }
        }

        private void CbCodigo_CheckedChanged(object sender, EventArgs e) {
            if (CbCodigo.Checked) {
                TbCodigo.ReadOnly = false;
            } else {
                TbCodigo.ReadOnly = true;
                TbCodigo.Text = "";
            }

            FillData();
        }

        private void CbDescricao_CheckedChanged(object sender, EventArgs e) {
            if (CbDescricao.Checked) {
                TbDescricao.ReadOnly = false;
            } else {
                TbDescricao.ReadOnly = true;
                TbDescricao.Text = "";
            }

            FillData();
        }

        private void TbCodigo_TextChanged(object sender, EventArgs e) {
            FillData();
        }

        private void TbDescricao_TextChanged(object sender, EventArgs e) {
            FillData();
        }
    }
}
