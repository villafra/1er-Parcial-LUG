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
        public abstract void CalcularDescuento(BE_Gift_Card oBE_GiftCard);
    }
}
