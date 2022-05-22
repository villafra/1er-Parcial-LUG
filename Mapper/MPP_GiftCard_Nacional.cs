using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Data_Acces_Layer;
using Abstract;

namespace Mapper
{
    public class MPP_GiftCard_Nacional : MPP_Gift_Card, IGestionable<BE_GiftCard_Nacional>
    {
        Conexión conexión;
        public bool Baja(BE_GiftCard_Nacional GiftCard)
        {
            string query = @"Delete from [Gift Card] where Codigo= " + GiftCard.Codigo;
            conexión = new Conexión();
            return conexión.EscribirTransaction(query);
        }

        public bool Guardar(BE_GiftCard_Nacional GiftCard)
        {
            string query;
            conexión = new Conexión();
            if (GiftCard.Codigo != 0)
            {
                query = @"Update [Gift Card] set [Fecha de Vencimiento]= '" + GiftCard.FechaVencimiento.ToString("yyyy-MM-dd") + "', Saldo= " + GiftCard.Saldo + ", Descuento= " + GiftCard.Descuento + ", Estado= '" + GiftCard.Estado.ToString() + "', Rubro= '" + GiftCard.Rubro.ToString() + "', Provincia= '" + GiftCard.Provincia + "' where Codigo = " + GiftCard.Codigo;
            }
            else
            {
                query = @"Insert into [Gift Card] ([Fecha de Creacion], [Fecha de Vencimiento], Saldo, Descuento, Estado, Rubro, Provincia) values ('" + GiftCard.FechadeCreacion.ToString("yyyy-MM-dd") + "','" + GiftCard.FechaVencimiento.ToString("yyyy-MM-dd") + "'," + GiftCard.Saldo + "," + GiftCard.Descuento + ",'" + GiftCard.Estado.ToString() + "','" + GiftCard.Rubro.ToString() + "','" + GiftCard.Provincia + "')";
            }
            return conexión.EscribirTransaction(query);
        }

        public List<BE_GiftCard_Nacional> Listar()
        {
            throw new NotImplementedException();
        }

        public BE_GiftCard_Nacional ListarObjeto(BE_GiftCard_Nacional Objeto)
        {
            throw new NotImplementedException();
        }
        public bool GiftCardAsociada(BE_GiftCard_Nacional GiftCard)
        {
            string query = @"select count(Codigo_GiftCard) from Cliente where Codigo_GiftCard= " + GiftCard.Codigo;
            conexión = new Conexión();
            return conexión.LeerScalar(query);
        }
    }
}
