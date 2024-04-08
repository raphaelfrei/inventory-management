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
    public partial class CreateSector : Form {

        private int CurrentID = 0;

        public CreateSector(int currentID) {
            InitializeComponent();
            CurrentID = currentID;

            FillData();
        }

        void FillData() {

            if (CurrentID == 0) {

                TbCodigo.Text = (SQLConn.GetIntValue("SELECT MAX(CodigoSetor) FROM Setor") + 1).ToString();

            } else {

                DataTable dt = SQLConn.GetTable($"SELECT * FROM Setor WHERE CodigoSetor = {CurrentID}");

                if (dt.Rows.Count == 0) {
                    return;
                }

                TbCodigo.Text = dt.Rows[0]["CodigoSetor"].ToString();
                TbDescricao.Text = dt.Rows[0]["DescricaoSetor"].ToString();

                BtnSalvar.Enabled = false;
            }

        }

        void SaveChanges() {

            TbDescricao.Text = TbDescricao.Text.Replace("'", "").Replace("\"", "");

            if (CurrentID == 0) {
                SQLConn.RunSQLCommand($"INSERT INTO Setor (DescricaoSetor) VALUES ('{TbDescricao.Text}')");
                CurrentID = Convert.ToInt32(TbCodigo.Text);
            } else {
                SQLConn.RunSQLCommand($"UPDATE Setor SET DescricaoSetor = '{TbDescricao.Text}' WHERE CodigoSetor = '{CurrentID}'");
            }

            BtnSalvar.Enabled = false;

        }

        private void BtnSalvar_Click(object sender, EventArgs e) {
            SaveChanges();
            this.Close();
        }

        private void TbDescricao_TextChanged(object sender, EventArgs e) {
            BtnSalvar.Enabled = true;
        }

        private void CreateSector_FormClosing(object sender, FormClosingEventArgs e) {

            if (BtnSalvar.Enabled == false)
                return;

            DialogResult dr = MessageBox.Show("Você deseja salvar as alterações antes de sair?", "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);


            if (dr == DialogResult.Yes) {
                SaveChanges();

            } else if (dr == DialogResult.Cancel) {
                e.Cancel = true;
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
