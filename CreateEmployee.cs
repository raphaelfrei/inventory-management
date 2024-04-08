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

    public partial class CreateEmployee : Form {

        int CurrentID = 0;

        public CreateEmployee(int id = 0) {
            InitializeComponent();
            CurrentID = id;
            FillData();
        }

        void FillData() {

            SelectSectors();

            if (CurrentID != 0) {

                DataTable dt = SQLConn.GetTable($"SELECT * FROM Funcionario WHERE RE = '{CurrentID}'");

                if (dt.Rows.Count == 0) {
                    return;
                }

                TbNome.Text = dt.Rows[0]["Nome"].ToString();

                CbSetor.SelectedIndex = Convert.ToInt32((long)dt.Rows[0]["CodigoSetor"] - 1);
                NumRE.Value = CurrentID;
                NumRE.Enabled = false;

            }

        }

        void SelectSectors() {

            int index = CbSetor.SelectedIndex;

            DataTable table = SQLConn.GetTable($"SELECT * FROM Setor");

            CbSetor.Items.Clear();

            foreach (DataRow dr in table.Rows)
                CbSetor.Items.Add(dr[1]);

            CbSetor.SelectedIndex = index;

        }

        private void SaveChanges() {

            TbNome.Text = TbNome.Text.Replace("'", "").Replace("\"", "");

            if (string.IsNullOrWhiteSpace(TbNome.Text)) {
                MessageBox.Show("Insira o nome do funcionário antes de continuar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (NumRE.Value == 0) {
                MessageBox.Show("O RE não pode ser 0.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (NumRE.Enabled && SQLConn.RunSQLCount($"SELECT COUNT(*) FROM Funcionario WHERE RE = '{NumRE.Value}'") > 0) {
                MessageBox.Show("Já existe um funcionário cadastrado com esse RE.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CbSetor.SelectedIndex == -1) {
                MessageBox.Show("Selecione o setor do funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (NumRE.Enabled) {
                SQLConn.RunSQLCommand($"INSERT INTO Funcionario (RE, Nome, CodigoSetor) VALUES ('{NumRE.Value}', '{TbNome.Text}', {CbSetor.SelectedIndex + 1})");
                NumRE.Enabled = false;
            } else {
                SQLConn.RunSQLCommand($"UPDATE Funcionario SET Nome = '{TbNome.Text}', CodigoSetor = {CbSetor.SelectedIndex + 1} WHERE RE = '{NumRE.Value}'");
            }

            BtnSalvar.Enabled = false;
        }

        private void BtnSalvar_Click(object sender, EventArgs e) {
            SaveChanges();
        }

        private void TbNome_TextChanged(object sender, EventArgs e) {
            BtnSalvar.Enabled = true;
        }

        private void NumRE_ValueChanged(object sender, EventArgs e) {
            BtnSalvar.Enabled = true;
        }

        private void CbSetor_SelectedIndexChanged(object sender, EventArgs e) {
            BtnSalvar.Enabled = true;
        }

        private void BtnCriarSetor_Click(object sender, EventArgs e) {
            ManageCreateSector man = new ManageCreateSector();
            man.ShowDialog();

            SelectSectors();
        }

        private void BtnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void CreateEmployee_FormClosing(object sender, FormClosingEventArgs e) {
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
