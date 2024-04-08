using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INVT {

    public partial class CreateInbound : Form {

        string CurrentNF;
        List<InboundItem> InboundItems = new List<InboundItem>();

        public CreateInbound(string currentNF) {
            InitializeComponent();
            CurrentNF = currentNF;

            FillData();

            if (CurrentNF != "") {

                TbNumeroNF.Text = CurrentNF;
                TbNumeroNF.ReadOnly = true;

            }
        }

        void FillData() {

            CbFornecedor.Items.Clear();

            DataTable table = SQLConn.GetTable("SELECT CNPJFornecedor, NomeFornecedor FROM Fornecedor");

            foreach (DataRow row in table.Rows) {

                CbFornecedor.Items.Add($"{row[0]} - {row[1]}");

            }

        }

        void SaveChanges() {

            if (TbNumeroNF.Text == "") {
                MessageBox.Show("O Número da NF não pode ficar em branco.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TbNumeroNF.Focus();
                return;
            }

            if (!int.TryParse(TbNumeroNF.Text, out _)) {
                MessageBox.Show("O Número da NF não pode conter caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TbNumeroNF.Focus();
                return;
            }

            if (CbFornecedor.SelectedIndex == -1) {
                MessageBox.Show("Você precisa selecionar um fornecedor antes de continuar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TbValorNF.Text.Trim() == "") {
                MessageBox.Show("O Valor da NF não pode ser nulo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TbValorNF.Focus();
                return;
            }

            if (DgItens.RowCount == 0) {
                MessageBox.Show("Você precisa adicionar pelo menos um item antes de continuar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Inbound item = new Inbound();

            item.Description = TbDescricao.Text;
            item.NumeroNF = TbNumeroNF.Text;
            item.DataEntrega = DtCompra.Value;
            item.TipoCompra = "";
            item.CNPJFornecedor = CbFornecedor.SelectedIndex.ToString().Split('-').First().Trim();
            item.ValorNF = TbValorNF.Text;
            item.IDUsuario = SQLConn.IDUsuario;
            item.ArquivoNF = TbArqNF.Text;

            foreach (DataGridViewRow row in DgItens.Rows) {
                item.AddItem(new InboundItem(item.NumeroNF, Convert.ToInt32(row.Cells[0].Value), Convert.ToInt32(row.Cells[2].Value), row.Cells[1].Value.ToString()));
            }

            var (status, message) = SQLConn.AddItem(item);

            if (status) {

                MessageBox.Show(message, "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnSalvar.Enabled = false;
                TbNumeroNF.ReadOnly = true;

            } else {
                MessageBox.Show(message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnSalvar_Click(object sender, EventArgs e) {

            SaveChanges();

        }

        private void TbValorNF_Leave(object sender, EventArgs e) {

            if (TbValorNF.Text.Trim() == "")
                TbValorNF.Text = "0";

            TbValorNF.Text = TbValorNF.Text.Replace("R$", "").Trim();

            if (Double.TryParse(TbValorNF.Text, out Double value))
                TbValorNF.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
            else
                TbValorNF.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", 0); ;

        }

        private void BtnAdicionar_Click(object sender, EventArgs e) {
            CreateInboundSubItem subitem = new CreateInboundSubItem();

            subitem.Items = InboundItems;
            subitem.OriginalList = InboundItems;

            subitem.ShowDialog();
            //subitem.Item.NumeroNF = TbNumeroNF.Text;

            //if (subitem.Item.CodigoProduto != 0)

            InboundItems = subitem.Items;

            foreach (InboundItem item in subitem.Items) {
                DgItens.Rows.Add(item.CodigoProduto, item.DescricaoProduto, item.QuantidadeProduto);
            }


        }

        private void DgItens_CellValidating(object sender, DataGridViewCellValidatingEventArgs e) {

            if (e.ColumnIndex == 2) {
                if (!int.TryParse(Convert.ToString(e.FormattedValue), out int _)) {
                    MessageBox.Show("A quantidade deve ser um valor numérico inteiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        private void TbNumeroNF_TextChanged(object sender, EventArgs e) {

        }

        private void BtnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void TbValorNF_TextChanged(object sender, EventArgs e) {

        }
    }
}
