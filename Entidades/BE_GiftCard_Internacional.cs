using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BE_GiftCard_Internacional : BE_Gift_Card
    {
        public string Pais { get; set; }

        public override void CalcularFechaVencimiento()
        {
            throw new NotImplementedException();
        }
    }
}
