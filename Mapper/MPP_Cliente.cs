using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Acces_Layer;
using Abstract;
using Entidades;

namespace Mapper
{
    public class MPP_Cliente : IGestionable<BE_Cliente>
    {
        public bool Baja(BE_Cliente Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BE_Cliente Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BE_Cliente> Listar()
        {
            throw new NotImplementedException();
        }

        public BE_Cliente ListarObjeto(BE_Cliente Objeto)
        {
            throw new NotImplementedException();
        }
    }
}
