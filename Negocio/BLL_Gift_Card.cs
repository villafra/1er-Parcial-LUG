using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract;
using Entidades;

namespace Negocio
{
    public abstract class BLL_Gift_Card
    {
        public abstract decimal CalcularDescuento(BE_Gift_Card oBE_GiftCard);

        public enum Estado
        {
            Libre,
            Activa,
            Baja,
            Vencida,
            Sin_Saldo
        }

        public enum Rubro
        {
            Libre,
            Calzado,
            Indumentaria
        }
    }
}
