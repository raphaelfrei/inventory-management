using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVT {
    public class OutboundItem {

        public int CodigoSaida { get; set; }
        public int CodigoProduto { get; set; }
        public string PrecoVenda { get; set; }


        public OutboundItem() {
            CodigoSaida = 0;
            CodigoProduto = 0;
            PrecoVenda = string.Empty;
        }

        public OutboundItem(int codigoSaida, int codigoProduto, string precoVenda) {

            CodigoSaida = codigoSaida;
            CodigoProduto = codigoProduto;
            PrecoVenda = precoVenda;

        }

    }
}
