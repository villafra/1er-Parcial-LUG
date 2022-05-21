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

        public BE_DescuentoCalculado ListarObjeto(BE_DescuentoCalculado Descuento)
        {
            throw new NotImplementedException();
        }
    }
}
