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

    public partial class CreateProduct : Form {

        private bool IsCreating;
        private int CurrentID;

        public CreateProduct(bool isCreating, int currentID = 0) {
            InitializeComponent();
            IsCreating = isCreating;
            CurrentID = currentID;

            FillProductType();
            CheckElements();
        }

        private void CheckElements() {

            if (!IsCreating) {

                DataTable dt = SQLConn.GetTable($"SELECT * FROM Produto WHERE CodigoProduto = {CurrentID}");

                if (dt.Rows.Count == 0) {
                    return;
                }

                TbCodigo.Text = dt.Rows[0]["CodigoProduto"].ToString();

                NumEstoque.Value = Convert.ToInt32((long)dt.Rows[0]["Estoque"]);
                NumEstoque.ReadOnly = true;
                NumEstoque.Enabled = false;

                NumQuantidade.Value = Convert.ToInt32((long)dt.Rows[0]["EstoqueMinimo"]);
                TbCodigoBarras.Text = (string)dt.Rows[0]["CodigoDeBarras"];

                TbDescricao.Text = (string)dt.Rows[0]["Produto"];

                TbPreco.Text = (string)dt.Rows[0]["ValorProduto"];

                CbTipo.SelectedIndex = Convert.ToInt32((long)dt.Rows[0]["TipoProduto"] - 1);

                BtnSalvar.Enabled = false;

            } else {

                TbCodigo.Text = (SQLConn.GetIntValue("SELECT MAX(CodigoProduto) FROM Produto") + 1).ToString();

            }

        }

        private void FillProductType() {

            int oldIndex = CbTipo.SelectedIndex;

            CbTipo.SelectedIndex = -1;

            CbTipo.Items.Clear();

            DataTable dt = SQLConn.GetTable("SELECT * FROM TipoProduto");

            foreach (DataRow row in dt.Rows) {
                CbTipo.Items.Add(row["DescricaoProduto"]);
            }

            if (oldIndex != -1)
                CbTipo.SelectedIndex = oldIndex;

        }

        private void SaveChanges() {

            if (TbDescricao.Text == "") {
                MessageBox.Show("A descrição é obrigatória.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TbCodigoBarras.Text == "") {
                MessageBox.Show("O código de barras é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TbPreco.Text == "") {
                MessageBox.Show("O valor do produto é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CbTipo.SelectedIndex == -1) {
                MessageBox.Show("O tipo do produto é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (NumQuantidade.Value == 0) {
                MessageBox.Show("A quantidade mínima para alerta é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            long count = SQLConn.RunSQLCount($"SELECT COUNT(*) FROM Produto WHERE CodigoProduto = {TbCodigo.Text}");

            if (count == 0) {
                SQLConn.RunSQLCommand($"INSERT INTO Produto (Produto, Estoque, EstoqueMinimo, CodigoDeBarras, TipoProduto, ValorProduto) VALUES ('{TbDescricao.Text}', {NumEstoque.Value}, {NumQuantidade.Value}, '{TbCodigoBarras.Text}', {CbTipo.SelectedIndex + 1}, '{TbPreco.Text}')");
            } else {
                SQLConn.RunSQLCommand($"UPDATE PRODUTO SET Produto='{TbDescricao.Text}', EstoqueMinimo={NumQuantidade.Value}, CodigoDeBarras='{TbCodigoBarras.Text}', TipoProduto={CbTipo.SelectedIndex + 1}, ValorProduto='{TbPreco.Text}' WHERE CodigoProduto = {TbCodigo.Text}");
            }

            BtnSalvar.Enabled = false;

        }

        private void TbDescricao_TextChanged(object sender, EventArgs e) {
            BtnSalvar.Enabled = true;
        }

        private void TbCodigoBarras_TextChanged(object sender, EventArgs e) {
            BtnSalvar.Enabled = true;
        }

        private void NumEstoque_ValueChanged(object sender, EventArgs e) {
            BtnSalvar.Enabled = true;
        }

        private void NumQuantidade_ValueChanged(object sender, EventArgs e) {
            BtnSalvar.Enabled = true;
        }

        private void CbTipo_SelectedIndexChanged(object sender, EventArgs e) {
            BtnSalvar.Enabled = true;
        }

        private void BtnSalvar_Click(object sender, EventArgs e) {

            SaveChanges();

        }

        private void BtnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void CreateProduct_FormClosing(object sender, FormClosingEventArgs e) {

            if (BtnSalvar.Enabled == false)
                return;

            DialogResult dr = MessageBox.Show("Você deseja salvar as alterações antes de sair?", "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);


            if (dr == DialogResult.Yes) {
                SaveChanges();

            } else if (dr == DialogResult.Cancel) {
                e.Cancel = true;
            }

        }

        private void BtnTipoProd_Click(object sender, EventArgs e) {

            ManageProductType mgr = new ManageProductType();
            mgr.ShowDialog();

            FillProductType();
        }

        private void TbPreco_TextChanged(object sender, EventArgs e) {

        }

        private void TbPreco_Leave(object sender, EventArgs e) {
            if (TbPreco.Text.Trim() == "")
                TbPreco.Text = "0";

            TbPreco.Text = TbPreco.Text.Replace("R$", "").Trim();

            if (Double.TryParse(TbPreco.Text, out Double value))
                TbPreco.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
            else
                TbPreco.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", 0); ;
        }
    }
}
