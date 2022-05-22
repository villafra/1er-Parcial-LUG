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
    public class BLL_Compra : IGestionable<BE_Compra>
    {
        MPP_Compra oMPP_Compra;

        public BLL_Compra()
        {
            oMPP_Compra = new MPP_Compra();
        }

        public bool Baja(BE_Compra Compra)
        {
            return oMPP_Compra.Baja(Compra);
        }

        public bool Guardar(BE_Compra Compra)
        {
            return oMPP_Compra.Guardar(Compra);
        }

        public List<BE_Compra> Listar()
        {
            return oMPP_Compra.Listar();
        }
        public bool ValidarSaldo(BE_Gift_Card oBE_GiftCard, BE_Compra oBE_Compra)
        {
            return oMPP_Compra.ValidarSaldo(oBE_GiftCard, oBE_Compra);
        }
            public List<BE_Compra> Listar(BE_Cliente Cliente)
        {
            return oMPP_Compra.Listar(Cliente);
        }

        public BE_Compra ListarObjeto(BE_Compra Comprar)
        {
            throw new NotImplementedException();
        }

    }
}
