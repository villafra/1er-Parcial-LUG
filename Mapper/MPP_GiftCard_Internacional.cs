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
    public class MPP_GiftCard_Internacional : MPP_Gift_Card, IGestionable<BE_GiftCard_Internacional>
    {
        Conexión conexión;
        public bool Baja(BE_GiftCard_Internacional GiftCard)
        {
            string query = @"Delete from [Gift Card] where Codigo= " + GiftCard.Codigo;
            conexión = new Conexión();
            return conexión.EscribirTransaction(query);
        }

        public bool Guardar(BE_GiftCard_Internacional GiftCard)
        {
            string query;
            conexión = new Conexión();
            if (GiftCard.Codigo != 0)
            {
                query = @"Update [Gift Card] set [Fecha de Vencimiento]= '" + GiftCard.FechaVencimiento.ToString("yyyy-MM-dd") + "', Saldo= " + GiftCard.Saldo + ", Descuento= " + GiftCard.Descuento + ", Estado= '" + GiftCard.Estado.ToString() + "', Rubro= '" + GiftCard.Rubro.ToString() + "', Pais= '" + GiftCard.Pais + "' where Codigo = " + GiftCard.Codigo;
            }
            else
            {
                query = @"Insert into [Gift Card] ([Fecha de Creacion], [Fecha de Vencimiento], Saldo, Descuento, Estado, Rubro, Pais) values ('" + GiftCard.FechadeCreacion.ToString("yyyy-MM-dd") + "','" + GiftCard.FechaVencimiento.ToString("yyyy-MM-dd") + "'," + GiftCard.Saldo + "," + GiftCard.Descuento + ",'" + GiftCard.Estado.ToString() +"','" + GiftCard.Rubro.ToString() + "','" + GiftCard.Pais + "')";
            }
            return conexión.EscribirTransaction(query);
        }

        public List<BE_GiftCard_Internacional> Listar()
        {
            throw new NotImplementedException();
        }
        public BE_GiftCard_Internacional ListarObjeto(BE_GiftCard_Internacional GiftCard)
        {
            throw new NotImplementedException();
        }
        public bool GiftCardAsociada(BE_GiftCard_Internacional GiftCard)
        {
            string query = @"select count(Codigo_GiftCard) from Cliente where Codigo_GiftCard= " + GiftCard.Codigo;
            conexión = new Conexión();
            return conexión.LeerScalar(query);
        }
    }
}
