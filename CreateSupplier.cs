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

    public partial class CreateSupplier : Form {

        string CurrentSupplier = "";

        public CreateSupplier(string currentSupplier = "") {
            InitializeComponent();
            CurrentSupplier = currentSupplier;
        }

        void SaveChanges() {

            if (TbCNPJ.Text.Length != 19) {
                MessageBox.Show("O CNPJ informado está incorreto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(TbNome.Text)) {
                MessageBox.Show("A razão social informada está em branco.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(TbEmail.Text)) {
                MessageBox.Show("O email informado está em branco.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (CurrentSupplier == "") {

                SQLConn.RunSQLCommand($"INSERT INTO Fornecedor (CNPJFornecedor, EmailFornecedor, TelefoneFornecedor, TipoServico, NomeFornecedor) VALUES ('{TbCNPJ.Text}', '{TbEmail.Text}', '{TbTelefone.Text}', '', '{TbNome.Text}')");
                CurrentSupplier = TbCNPJ.Text;
                TbCNPJ.ReadOnly = true;
                BtnSalvar.Enabled = false;

            } else {

            }
        }

        private void CreateSupplier_FormClosing(object sender, FormClosingEventArgs e) {
            if (BtnSalvar.Enabled == false)
                return;

            DialogResult dr = MessageBox.Show("Você deseja salvar as alterações antes de sair?", "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);


            if (dr == DialogResult.Yes) {
                SaveChanges();

            } else if (dr == DialogResult.Cancel) {
                e.Cancel = true;
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e) {
            SaveChanges();
        }
    }
}

