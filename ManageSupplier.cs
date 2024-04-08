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

    public partial class ManageSupplier : Form {

        public ManageSupplier() {
            InitializeComponent();

            FillData();
        }

        void FillData() {

            DgItens.Rows.Clear();

            DataTable table = SQLConn.GetTable("SELECT * FROM Fornecedor");

            foreach (DataRow dr in table.Rows) {
                DgItens.Rows.Add(dr[5], dr[1], dr[2]);
            }

        }

        private void BtnCriar_Click(object sender, EventArgs e) {
            CreateSupplier crs = new CreateSupplier();
            crs.ShowDialog();

            FillData();
        }

        private void BtnEditar_Click(object sender, EventArgs e) {

        }

        private void CbCodigo_CheckedChanged(object sender, EventArgs e) {

        }

        private void TbCodigo_TextChanged(object sender, EventArgs e) {

        }

        private void CbDescricao_CheckedChanged(object sender, EventArgs e) {

        }

        private void TbDescricao_TextChanged(object sender, EventArgs e) {

        }

        private void DgItens_CellClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
