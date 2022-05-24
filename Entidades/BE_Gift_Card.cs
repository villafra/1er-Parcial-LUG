using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract;

namespace Entidades
{
    public abstract class BE_Gift_Card : IEntidable
    {
        public int Codigo { get; set; }
        public DateTime FechadeCreacion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal Saldo { get; set; }
        public decimal Descuento { get; set; }
        public Status Estado { get; set; }
        public Rubros Rubro { get; set; }

        public abstract override string ToString();
        public abstract DateTime CalcularFechaVencimiento();
        public abstract bool Vencimiento();
        public string DevolverTipo(BE_Gift_Card GiftCard)
        {
            if (GiftCard is BE_GiftCard_Nacional)
            {
                return "Nacional";
            }
            else
            {
                return "Internacional";
            }
        }
        public enum Status
        {
            Libre,
            Activa,
            Baja,
            Vencida,
            Sin_Saldo
        }

        public enum Rubros
        {
            Libre,
            Calzado,
            Electrodoméstico
        }
    }
}
