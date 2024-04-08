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

    public partial class CreateInboundSubItem : Form {

        public List<InboundItem> Items = new List<InboundItem>();
        public List<InboundItem> OriginalList = new List<InboundItem>();

        private string CodigoSelecionado = string.Empty;
        private string DescricaoSelecionado = string.Empty;
        private string PrecoSelecionado = string.Empty;

        public CreateInboundSubItem() {
            InitializeComponent();

            FillData();
            BtnSalvar.Enabled = false;
        }

        private void FillData() {

            DgItens.Rows.Clear();

            DataTable table = SQLConn.GetTable($"SELECT CodigoProduto, Produto, ValorProduto FROM Produto WHERE CodigoProduto LIKE '%{TbFiltro.Text}%' OR Produto LIKE '%{TbFiltro.Text}%'");

            foreach (DataRow row in table.Rows)
                DgItens.Rows.Add(row[0], row[1], row[2]);

        }

        private void BtnSalvar_Click(object sender, EventArgs e) {

            this.Close();

        }

        private void TbCodigo_TextChanged(object sender, EventArgs e) {
            BtnSalvar.Enabled = true;
        }

        private void TbDescricao_TextChanged(object sender, EventArgs e) {
            BtnSalvar.Enabled = true;
        }

        private void DgItens_CellClick(object sender, DataGridViewCellEventArgs e) {

            if (e.RowIndex == -1)
                return;

            CodigoSelecionado = DgItens.Rows[e.RowIndex].Cells[0].Value.ToString();
            DescricaoSelecionado = DgItens.Rows[e.RowIndex].Cells[1].Value.ToString();
            PrecoSelecionado = DgItens.Rows[e.RowIndex].Cells[2].Value.ToString();

        }

        private void BtnItem_Click(object sender, EventArgs e) {

            if (CodigoSelecionado == "") {
                MessageBox.Show("Selecione um item antes de adicionar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool codigoEstaNaLista = Items.Any(item => item.CodigoProduto.ToString() == CodigoSelecionado);

            if (codigoEstaNaLista)
                return;

            BtnSalvar.Enabled = true;

            Items.Add(new InboundItem("", Convert.ToInt32(CodigoSelecionado), 1, DescricaoSelecionado, PrecoSelecionado));
            DgvSubItem.Rows.Add(CodigoSelecionado, DescricaoSelecionado, 1, PrecoSelecionado);

        }

        private void CreateInboundSubItem_Shown(object sender, EventArgs e) {

            if (Items.Count > 0) {

                foreach (InboundItem item in Items)
                    DgvSubItem.Rows.Add(item.CodigoProduto, item.DescricaoProduto, item.QuantidadeProduto, item.PrecoVenda);

            }

        }

        private void DgvSubItem_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) {
            Items.Clear();

            if (DgvSubItem.Rows.Count == 0)
                return;

            foreach (DataGridViewRow row in DgvSubItem.Rows) {
                Items.Add(new InboundItem("", Convert.ToInt32(row.Cells[0].Value), Convert.ToInt32(row.Cells[1].Value), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString()));
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e) {
            Items = OriginalList;
            this.Close();
        }

        private void TbFiltro_TextChanged(object sender, EventArgs e) {
            FillData();
        }
    }
}
