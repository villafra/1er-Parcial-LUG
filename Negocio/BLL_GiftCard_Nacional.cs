using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Abstract;
using Mapper;

namespace Negocio
{
    public class BLL_GiftCard_Nacional : BLL_Gift_Card, IGestionable<BE_GiftCard_Nacional>
    {
        MPP_GiftCard_Nacional oMPP_GiftCard;

        public BLL_GiftCard_Nacional()
        {
            oMPP_GiftCard = new MPP_GiftCard_Nacional();
        }
        public bool Baja(BE_GiftCard_Nacional oGiftCard)
        {
            return oMPP_GiftCard.Baja(oGiftCard);
        }


        public bool Guardar(BE_GiftCard_Nacional oGiftCard)
        {
            return oMPP_GiftCard.Guardar(oGiftCard);
        }
        
        public List<BE_Gift_Card> ListarTodo()
        {
            return oMPP_GiftCard.ListarTodo();
        }
        public List<BE_Gift_Card> ListarLibres()
        {
            return oMPP_GiftCard.ListarLibres();
        }
        public List<BE_GiftCard_Nacional> Listar()
        {
            return oMPP_GiftCard.Listar();
        }

        public BE_GiftCard_Nacional ListarObjeto(BE_GiftCard_Nacional oGiftCard)
        {
            return oMPP_GiftCard.ListarObjeto(oGiftCard);
        }

        public override decimal CalcularDescuento(BE_Gift_Card oBE_GiftCard)
        {
            return (decimal)0.25;
        }

        public override void CalcularMontodeCompra(BE_Gift_Card oBE_GiftCard, BE_Compra oBE_Compra)
        {
            oBE_GiftCard.Saldo -= oBE_Compra.Total;
            if (oBE_GiftCard.Saldo == 0)
            {
                oBE_GiftCard.Estado = BE_Gift_Card.Status.Sin_Saldo.ToString();
            }
        }
        public override void ModificarMontodeCompra(BE_Gift_Card oBE_GiftCard, BE_Compra oBE_Compramod, decimal TotalAnterior)
        {
            oBE_GiftCard.Saldo += TotalAnterior - oBE_Compramod.Total;
            if (oBE_GiftCard.Saldo != 0)
            {
                oBE_GiftCard.Estado = BE_Gift_Card.Status.Activa.ToString();
            }
        }
        public override void EliminarMontodeCompra(BE_Gift_Card oBE_GiftCard, BE_Compra oBE_Compra)
        {
            oBE_GiftCard.Saldo += oBE_Compra.Total;
            if (oBE_GiftCard.Saldo != 0)
            {
                oBE_GiftCard.Estado = BE_Gift_Card.Status.Activa.ToString();
            }
        }
    }
}
