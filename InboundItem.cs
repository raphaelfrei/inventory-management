using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVT {
    public class InboundItem {

        public string NumeroNF { get; set; }
        public int CodigoProduto { get; set; }
        public int QuantidadeProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public string PrecoVenda { get; set; }

        public InboundItem() {
            NumeroNF = string.Empty;
            CodigoProduto = 0;
            QuantidadeProduto = 0;
            DescricaoProduto = string.Empty;
            PrecoVenda = string.Empty;
        }

        public InboundItem(string numeroNF, int codigoProduto, int quantidadeProduto, string descricaoProduto) {
            NumeroNF = numeroNF;
            CodigoProduto = codigoProduto;
            QuantidadeProduto = quantidadeProduto;
            DescricaoProduto = descricaoProduto;
            PrecoVenda = string.Empty;
        }

        public InboundItem(string numeroNF, int codigoProduto, int quantidadeProduto, string descricaoProduto, string precoVenda) {
            NumeroNF = numeroNF;
            CodigoProduto = codigoProduto;
            QuantidadeProduto = quantidadeProduto;
            DescricaoProduto = descricaoProduto;
            PrecoVenda = precoVenda;
        }

    }
}
