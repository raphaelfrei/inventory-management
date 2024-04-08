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
    public partial class CreateProductType : Form {

        private string ProductTypeID;

        public CreateProductType(string productTypeID = "") {
            InitializeComponent();
            ProductTypeID = productTypeID;

            FillData();
        }

        private void FillData() {

            if (ProductTypeID == "") {

                TbCodigo.Text = (SQLConn.GetIntValue("SELECT MAX(TipoProduto) FROM TipoProduto") + 1).ToString();

            } else {

                DataTable dt = SQLConn.GetTable($"SELECT * FROM TipoProduto WHERE CodigoProduto = {ProductTypeID}");

                if (dt.Rows.Count == 0) {
                    return;
                }

                TbCodigo.Text = ((int)dt.Rows[0]["TipoProduto"]).ToString();

                TbDescricao.Text = (string)dt.Rows[0]["DescricaoProduto"];

                BtnSalvar.Enabled = false;

            }

        }

        private void SaveChanges() {

            if (TbDescricao.Text == "") {
                MessageBox.Show("A descrição é obrigatória.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            long count = SQLConn.RunSQLCount($"SELECT COUNT(*) FROM TipoProduto WHERE TipoProduto = {TbCodigo.Text}");

            if (count == 0) {
                SQLConn.RunSQLCommand($"INSERT INTO TipoProduto (DescricaoProduto) VALUES ('{TbDescricao.Text}')");
            } else {
                SQLConn.RunSQLCommand($"UPDATE TipoProduto SET DescricaoProduto='{TbDescricao.Text}' WHERE TipoProduto = '{TbCodigo.Text}'");
            }

            BtnSalvar.Enabled = false;
        }

        private void BtnSalvar_Click(object sender, EventArgs e) {
            SaveChanges();
        }

        private void BtnCancelar_Click(object sender, EventArgs e) {

        }

        private void TbDescricao_TextChanged(object sender, EventArgs e) {
            BtnSalvar.Enabled = true;
        }

        private void CreateProductType_FormClosing(object sender, FormClosingEventArgs e) {
            if (BtnSalvar.Enabled == false)
                return;

            DialogResult dr = MessageBox.Show("Você deseja salvar as alterações antes de sair?", "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);


            if (dr == DialogResult.Yes) {
                SaveChanges();

            } else if (dr == DialogResult.Cancel) {
                e.Cancel = true;
            }
        }
    }
}
