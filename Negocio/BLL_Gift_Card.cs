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
        public abstract void CalcularMontodeCompra(BE_Gift_Card oBE_GiftCard, BE_Compra oBE_Compra);
        public abstract void ModificarMontodeCompra(BE_Gift_Card oBE_GiftCard, BE_Compra oBE_Compramod, decimal TotalAnterior);
        public abstract void EliminarMontodeCompra(BE_Gift_Card oBE_GiftCard, BE_Compra oBE_Compra);
    }
}
