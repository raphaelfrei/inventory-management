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

    public partial class ManageEmployee : Form {

        private int SelectedRE = 0;

        public ManageEmployee() {
            InitializeComponent();

            FillData();
        }

        void FillData() {

            DgItens.Rows.Clear();

            DataTable table = SQLConn.GetTable($"SELECT * FROM Funcionario INNER JOIN Setor ON Setor.CodigoSetor = Funcionario.CodigoSetor WHERE RE LIKE '%{TbCodigo.Text}%' OR Nome LIKE '%{TbCodigo.Text}%'");

            foreach (DataRow row in table.Rows) {
                DgItens.Rows.Add(row[1], row[2], row[5]);
            }
        }

        private void BtnCriar_Click(object sender, EventArgs e) {
            CreateEmployee create = new CreateEmployee();
            create.ShowDialog();

            FillData();
        }

        private void TbCodigo_TextChanged(object sender, EventArgs e) {
            FillData();
        }

        private void CbUsuario_CheckedChanged(object sender, EventArgs e) {
            if (CbUsuario.Checked)
                TbCodigo.ReadOnly = false;
            else {
                TbCodigo.ReadOnly = true;
                TbCodigo.Text = $"";
            }
        }

        private void DgItens_CellClick(object sender, DataGridViewCellEventArgs e) {

            if (e.RowIndex == -1)
                return;

            DataGridViewRow row = DgItens.Rows[e.RowIndex];

            SelectedRE = Convert.ToInt32(row.Cells[0].Value.ToString());

            TbRE.Text = SelectedRE.ToString();

            if (TbRE.Text != "") {
                BtnEditar.Enabled = true;
                //BtnDeletar.Enabled = true;
            }

        }

        private void BtnEditar_Click(object sender, EventArgs e) {
            CreateEmployee create = new CreateEmployee(SelectedRE);
            create.ShowDialog();

            FillData();
        }
    }
}
