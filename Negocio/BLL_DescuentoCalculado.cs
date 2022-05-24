using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract;
using Mapper;
using Entidades;

namespace Negocio
{
    public class BLL_DescuentoCalculado : IGestionable<BE_DescuentoCalculado>
    {
        MPP_DescuentoCalculado oMPP_DescuentoCalculado;

        public BLL_DescuentoCalculado()
        {
            oMPP_DescuentoCalculado = new MPP_DescuentoCalculado();
        }
        public bool Baja(BE_DescuentoCalculado Descuento)
        {
            return oMPP_DescuentoCalculado.Baja(Descuento);
        }

        public bool Guardar(BE_DescuentoCalculado Descuento)
        {
            return oMPP_DescuentoCalculado.Guardar(Descuento);
        }

        public List<BE_DescuentoCalculado> Listar()
        {
            return oMPP_DescuentoCalculado.Listar();
        }
        public List<BE_DescuentoCalculado> Listar(BE_Gift_Card GiftCard)
        {
            return oMPP_DescuentoCalculado.Listar(GiftCard);
        }
        public BE_DescuentoCalculado DevolverMAX()
        {
            return oMPP_DescuentoCalculado.DevolverMAX();
        }
        public BE_DescuentoCalculado DevolverMIN()
        {
            return oMPP_DescuentoCalculado.DevolverMIN();
        }
        public BE_DescuentoCalculado ListarObjeto(BE_DescuentoCalculado Descuento)
        {
            throw new NotImplementedException();
        }
    }
}
