using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVT {

    public class Inbound {

        public string Description { get; set; }
        public string NumeroNF { get; set; }
        public DateTime DataEntrega { get; set; }
        public string TipoCompra { get; set; }
        public string CNPJFornecedor { get; set; }
        public string ValorNF { get; set; }
        public string IDUsuario { get; set; }
        public string ArquivoNF { get; set; }

        public List<InboundItem> Itens { get; set; }

        public Inbound() {
            Description = string.Empty;
            NumeroNF = string.Empty;
            DataEntrega = DateTime.MinValue;
            TipoCompra = string.Empty;
            CNPJFornecedor = string.Empty;
            ValorNF = string.Empty;
            IDUsuario = string.Empty;
            ArquivoNF = string.Empty;
            Itens = new List<InboundItem>();
        }

        public Inbound(string description, string numeroNF, DateTime dataEntrega, string tipoCompra, string cnpjFornecedor, string valorNF, string idUsuario, string arquivoNF) {
            Description = description;
            NumeroNF = numeroNF;
            DataEntrega = dataEntrega;
            TipoCompra = tipoCompra;
            CNPJFornecedor = cnpjFornecedor;
            ValorNF = valorNF;
            IDUsuario = idUsuario;
            ArquivoNF = arquivoNF;
            Itens = new List<InboundItem>();
        }

        public void AddItem(InboundItem item) {
            Itens.Add(item);
        }

        public void LoadToDatabase() {
            SQLConn.AddItem(this);
        }

    }
}
