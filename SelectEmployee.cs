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
    public partial class SelectEmployee : Form {


        public string REEmp = "";
        public string NameEmp = "";
        public string SectorEmp = "";

        public SelectEmployee() {
            InitializeComponent();
        }

        void FillData() {

            DgItens.Rows.Clear();

            string filter = "WHERE 1=1";

            if (TbFiltro.Text != "")
                filter += $" AND (RE LIKE '%{TbFiltro.Text}%' OR Nome LIKE '%{TbFiltro.Text}%' OR Setor.DescricaoSetor LIKE '%{TbFiltro.Text}%')";

            DataTable table = SQLConn.GetTable($"SELECT Funcionario.*, Setor.* FROM Funcionario INNER JOIN Setor ON Funcionario.CodigoSetor = Setor.CodigoSetor {filter}");

            foreach (DataRow dr in table.Rows) {

                DgItens.Rows.Add(dr[1], dr[2], dr[5]);

            }

        }

        private void TbFiltro_TextChanged(object sender, EventArgs e) {
            FillData();
        }

        private void SelectEmployee_Shown(object sender, EventArgs e) {
            FillData();
        }

        private void DgItens_CellClick(object sender, DataGridViewCellEventArgs e) {

            if (e.RowIndex == -1)
                return;

            DataGridViewRow dgvRow = DgItens.Rows[e.RowIndex];

            REEmp = dgvRow.Cells[0].Value.ToString();
            NameEmp = dgvRow.Cells[1].Value.ToString();
            SectorEmp = dgvRow.Cells[2].Value.ToString();

            TbRE.Text = REEmp;
            TbNome.Text = NameEmp;
            TbSetor.Text = SectorEmp;

        }

        private void BtnSalvar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e) {
            REEmp = "";
            NameEmp = "";
            SectorEmp = "";

            this.Close();
        }

        private void DgItens_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1)
                return;

            DataGridViewRow dgvRow = DgItens.Rows[e.RowIndex];

            REEmp = dgvRow.Cells[0].Value.ToString();
            NameEmp = dgvRow.Cells[1].Value.ToString();
            SectorEmp = dgvRow.Cells[2].Value.ToString();

            TbRE.Text = REEmp;
            TbNome.Text = NameEmp;
            TbSetor.Text = SectorEmp;

            this.Close();

        }

        private void BtnCriarFunc_Click(object sender, EventArgs e) {
            CreateEmployee create = new CreateEmployee();
            create.ShowDialog();

            TbFiltro.Text = $"";
            FillData();
        }
    }
}
