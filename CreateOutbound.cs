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

    public partial class CreateOutbound : Form {

        private long CurrentID = 0;
        private string EmployeeRE = "";
        private List<InboundItem> Items = new List<InboundItem>();

        public CreateOutbound() {
            InitializeComponent();

            DtCompra.MaxDate = DateTime.Today;
            DtCompra.MinDate = DateTime.Today.AddMonths(-1);

        }

        private void FillData() {
            DgItens.Rows.Clear();

            foreach (InboundItem item in Items) {

                DgItens.Rows.Add(item.CodigoProduto, item.DescricaoProduto, item.QuantidadeProduto);

            }
        }

        void AddItemBySearch() {

            DataTable dt = SQLConn.GetTable($"SELECT * FROM Produto WHERE CodigoDeBarras = '{TbCodigoBarras.Text}'");

            TbCodigoBarras.Text = "";

            if (dt.Rows.Count == 0)
                return;

            string codigoProduto = ((int)dt.Rows[0]["CodigoProduto"]).ToString();

            bool codigoEstaNaLista = Items.Any(item => item.CodigoProduto.ToString() == codigoProduto);

            if (codigoEstaNaLista)
                return;

            Items.Add(new InboundItem("", Convert.ToInt32(codigoProduto), 1, (string)dt.Rows[0]["Produto"], (string)dt.Rows[0]["ValorProduto"]));
            DgItens.Rows.Add(Convert.ToInt32(codigoProduto), (string)dt.Rows[0]["Produto"], 1, (string)dt.Rows[0]["ValorProduto"]);

        }

        void SaveChanges() {

            if (string.IsNullOrWhiteSpace(EmployeeRE)) {
                MessageBox.Show("Selecione um funcionário antes de salvar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DgItens.Rows.Count == 0) {
                MessageBox.Show("Você precisa adicionar pelo menos 1 item para salvar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SQLConn.RunSQLCommand($"INSERT INTO EventoSaida (DataEvento, RE) VALUES ('{DtCompra.Value.ToShortDateString()}', '{EmployeeRE}')");
            CurrentID = SQLConn.GetIntValue("SELECT MAX(CodigoEvento) FROM EventoSaida") + 1;


            foreach (DataGridViewRow row in DgItens.Rows) {
                SQLConn.RunSQLCommand($"INSERT INTO SaidaXProduto (CodigoSaida, CodigoProduto, ValorProduto) VALUES ({CurrentID}, {row.Cells["dataGridViewTextBoxColumn1"].Value}, '{row.Cells["Quantidade"].Value}')");

                SQLConn.RunSQLCommand($"UPDATE Produto SET Estoque = Estoque - {row.Cells["Quantidade"].Value} WHERE CodigoProduto={row.Cells["dataGridViewTextBoxColumn1"].Value}");
            }

            BtnSalvar.Enabled = false;
            this.Close();

        }

        private void BtnProduto_Click(object sender, EventArgs e) {
            CreateInboundSubItem subitem = new CreateInboundSubItem();

            subitem.Items = Items;
            subitem.OriginalList = Items;

            subitem.ShowDialog();

            Items = subitem.Items;

            FillData();

        }

        private void BtnFunc_Click(object sender, EventArgs e) {
            SelectEmployee select = new SelectEmployee();
            select.ShowDialog();

            EmployeeRE = select.REEmp;
            TbNome.Text = select.NameEmp;
            TbDepto.Text = select.SectorEmp;
        }

        private void TbCodigoBarras_TextChanged(object sender, EventArgs e) {

        }

        private void TbCodigoBarras_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Return) {
                AddItemBySearch();
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e) {
            SaveChanges();
        }

        private void DgItens_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) {

            Items.Clear();

            foreach (DataGridViewRow row in DgItens.Rows) {
                Items.Add(new InboundItem("", Convert.ToInt32(row.Cells[0].Value), Convert.ToInt32(row.Cells[1].Value), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString()));
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
