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

    public partial class Main : Form {

        public Main() {
            InitializeComponent();

            RefreshData();
        }

        private void BtnEntrada_Click(object sender, EventArgs e) {
            ManageInbound notas = new ManageInbound();
            notas.ShowDialog();

            RefreshData();
        }

        private void RefreshData() {

            DgEstoqueBaixo.Rows.Clear();

            DataTable table = SQLConn.GetTable("SELECT Produto.*, TipoProduto.* FROM Produto INNER JOIN TipoProduto ON TipoProduto.TipoProduto = Produto.TipoProduto WHERE Produto.Estoque <= Produto.EstoqueMinimo;");
            foreach (DataRow row in table.Rows) {
                DgEstoqueBaixo.Rows.Add(row[0], row[1], row[2], row[3], row[7]);

            }

        }

        private void BtnProdutos_Click(object sender, EventArgs e) {
            ManageProduct manageProduct = new ManageProduct();
            manageProduct.ShowDialog();

            RefreshData();
        }

        private void BtnSaida_Click(object sender, EventArgs e) {
            ManageOutbound manageOutbound = new ManageOutbound();
            manageOutbound.ShowDialog();

            RefreshData();
        }

        private void BtnFuncionario_Click(object sender, EventArgs e) {
            ManageEmployee manageEmployee = new ManageEmployee();
            manageEmployee.ShowDialog();

            RefreshData();
        }

        private void BtnFornecedor_Click(object sender, EventArgs e) {
            ManageSupplier manageSupplier = new ManageSupplier();
            manageSupplier.ShowDialog();

            RefreshData();
        }
    }
}
