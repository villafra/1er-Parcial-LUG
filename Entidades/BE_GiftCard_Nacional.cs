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

            if (this.Rubro == Rubros.Libre)
            {
                Vencimiento = this.FechadeCreacion.AddDays(30);
            }
            else if (this.Rubro == Rubros.Calzado)
            {
                Vencimiento = this.FechadeCreacion.AddDays(120);
            }
            else
            {
                Vencimiento = this.FechadeCreacion.AddDays(90);
            }
            return Vencimiento;
        }

        public override string ToString()
        {
            return this.Codigo.ToString();
        }

        public override bool Vencimiento()
        {
            if (this.FechaVencimiento > DateTime.Today) { return false; }
            else { return true; }
        }
    }
}
