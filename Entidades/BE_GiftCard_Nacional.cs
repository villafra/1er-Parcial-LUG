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


        public override DateTime CalcularFechaVencimiento()
        {
            DateTime Vencimiento;

            if (this.Rubro == "Libre")
            {
                Vencimiento = DateTime.Now.AddDays(30);
            }
            else if (this.Rubro == "Calzado")
            {
                Vencimiento = DateTime.Now.AddDays(120);
            }
            else
            {
                Vencimiento = DateTime.Now.AddDays(90);
            }
            return Vencimiento;
        }
    }
}
