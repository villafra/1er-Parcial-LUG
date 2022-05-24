using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract;

namespace Entidades
{
    public class BE_DescuentoCalculado :IEntidable
    {
        public int Codigo { get; set; }
        public BE_Gift_Card CodigoGiftCard { get; set; }
        public string TipoGiftCard { get; set; }
        public decimal SumaDescuentos { get; set; }
    }
}
