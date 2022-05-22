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
    public class BLL_Cliente : IGestionable<BE_Cliente>
    {
        MPP_Cliente oMPP_Cliente;
        public BLL_Cliente()
        {
            oMPP_Cliente = new MPP_Cliente();
        }

        public bool Baja(BE_Cliente oBE_Cliente)
        {
            return oMPP_Cliente.Baja(oBE_Cliente);
        }

        public bool Guardar(BE_Cliente oBE_Cliente)
        {
            return oMPP_Cliente.Guardar(oBE_Cliente);
        }

        public List<BE_Cliente> Listar()
        {
            return oMPP_Cliente.Listar();
        }

        public BE_Cliente ListarObjeto(BE_Cliente oBE_Cliente)
        {
            return oMPP_Cliente.ListarObjeto(oBE_Cliente);
        }

        public bool AsociarGiftCard(BE_Cliente oBE_Cliente, BE_Gift_Card oBE_Gift_Card)
        {
            return oMPP_Cliente.Asociaciones(oBE_Cliente, oBE_Gift_Card, BE_Gift_Card.Status.Activa);
            
        }

        public bool DesasociarGiftCard(BE_Cliente oBE_Cliente)
        {
            return oMPP_Cliente.Asociaciones(oBE_Cliente, oBE_Cliente.CodigoGiftCard, BE_Gift_Card.Status.Libre);
        }
        public bool BajaGiftCard(BE_Cliente oBE_Cliente)
        {
            return oMPP_Cliente.Asociaciones(oBE_Cliente, oBE_Cliente.CodigoGiftCard, BE_Gift_Card.Status.Baja);
        }
        public bool GiftCardAsociada(BE_Cliente oBE_Cliente)
        {
            return oMPP_Cliente.GiftCardAsociada(oBE_Cliente);
        }

    }
}
