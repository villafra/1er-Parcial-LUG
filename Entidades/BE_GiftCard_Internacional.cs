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

        public override DateTime CalcularFechaVencimiento()
        {
            DateTime Vencimiento;

            if (this.Rubro == "Libre")
            {
                Vencimiento = DateTime.Now.AddDays(60);
            }
            else if (this.Rubro == "Calzado")
            {
                Vencimiento = DateTime.Now.AddDays(150);
            }
            else
            {
                Vencimiento = DateTime.Now.AddDays(120);
            }
            return Vencimiento;
        }
    }
}
