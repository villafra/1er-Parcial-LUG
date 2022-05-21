using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract;

namespace Entidades
{
    public class BE_Compra : IEntidable
    {
        public int Codigo { get; set; }
        public BE_Cliente CodigoCliente { get; set; }
        public BE_Gift_Card CodigoGiftCard { get; set; }
        public decimal Monto { get; set; }
        public decimal Total { get; set; }

        public BE_Compra()
        {
            CalcularDescuento();
        }

        public void CalcularDescuento()
        {
            Total = Monto * CodigoGiftCard.Descuento;
        }
    }

    
}
