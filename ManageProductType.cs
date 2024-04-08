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
    public partial class ManageProductType : Form {

        private int CurrentID = 0;

        public ManageProductType() {
            InitializeComponent();
            UpdateData();
        }

        private void UpdateData() {

            DgItens.Rows.Clear();

            string filter = $" WHERE 1=1";

            if (CbCodigo.Checked)
                filter += $" AND TipoProduto LIKE '%{TbCodigo.Text}%'";

            if (CbDescricao.Checked)
                filter += $" AND DescricaoProduto LIKE '%{TbDescricao.Text}%'";

            DataTable dt = SQLConn.GetTable($"SELECT TipoProduto, DescricaoProduto FROM TipoProduto{filter}");

            foreach (DataRow dr in dt.Rows) {
                DgItens.Rows.Add(dr[0], dr[1]);
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

        private void BtnCriar_Click(object sender, EventArgs e) {
            CreateProductType cpt = new CreateProductType();
            cpt.ShowDialog();
            UpdateData();
        }

        private void BtnEditar_Click(object sender, EventArgs e) {
            CreateProductType cpt = new CreateProductType(TbSelecionado.Text);
            cpt.ShowDialog();
            UpdateData();
        }
    }
}
