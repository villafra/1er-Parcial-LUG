using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract;
using Mapper;

namespace Negocio
{
    public class BLL_GiftCard_Internacional : BLL_Gift_Card, IGestionable<BE_GiftCard_Internacional>
    {
        MPP_GiftCard_Internacional oMPP_GiftCard;

        public BLL_GiftCard_Internacional()
        {
            oMPP_GiftCard = new MPP_GiftCard_Internacional();
        }

        public bool Baja(BE_GiftCard_Internacional oGiftCard)
        {
            return oMPP_GiftCard.Baja(oGiftCard);
        }

        public override void CalcularDescuento(BE_Gift_Card oBE_GiftCard)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BE_GiftCard_Internacional oGiftCard)
        {
            return oMPP_GiftCard.Guardar(oGiftCard);
        }

        public List<BE_GiftCard_Internacional> Listar()
        {
            return oMPP_GiftCard.Listar();
        }

        public BE_GiftCard_Internacional ListarObjeto(BE_GiftCard_Internacional oGiftCard)
        {
           return oMPP_GiftCard.ListarObjeto(oGiftCard);
        }
    }
}
