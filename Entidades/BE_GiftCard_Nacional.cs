using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BE_GiftCard_Nacional : BE_Gift_Card
    {
        public string Provincia { get; set; }

        public override void CalcularFechaVencimiento()
        {
            throw new NotImplementedException();
        }
    }
}
