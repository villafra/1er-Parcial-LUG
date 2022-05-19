using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Abstract;
using Data_Acces_Layer;

namespace Mapper
{
    public class MPP_GiftCard_Internacional : IGestionable<BE_GiftCard_Internacional>
    {
        Conexión conexión;
        public bool Baja(BE_GiftCard_Internacional GiftCard)
        {
            string query = @"delete from [Gift Card] where Codigo= " + GiftCard.Codigo;
            conexión = new Conexión();
            return conexión.EscribirTransaction(query);
        }

        public bool Guardar(BE_GiftCard_Internacional GiftCard)
        {
            string query;

            if (GiftCard.Codigo != 0)
            {
                query = @"Update Cliente set Nombre= '" + GiftCard.Nombre + "', Apellido= '" + Cliente.Apellido + "', DNI= " + Cliente.DNI + ", [Fecha de Nacimiento]= '" + Cliente.FechadeNacimiento.ToString("yyyy-MM-dd") + "' where Legajo = " + Cliente.Codigo;
            }
            else
            {
                query = @"Insert into Cliente (Nombre, Apellido, DNI, [Fecha de Nacimiento]) values ('" + Cliente.Nombre + "', '" + Cliente.Apellido + "'," + Cliente.DNI + ",'" + Cliente.FechadeNacimiento.ToString("yyyy-MM-dd") + "')";
            }
            return conexión.EscribirTransaction(query);
        }

        public List<BE_GiftCard_Internacional> Listar()
        {
            throw new NotImplementedException();
        }

        public BE_GiftCard_Internacional ListarObjeto(BE_GiftCard_Internacional Objeto)
        {
            throw new NotImplementedException();
        }
    }
}
