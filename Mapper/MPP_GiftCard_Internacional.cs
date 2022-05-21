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
                query = @"Update [Gift Card] set [Fecha de Vencimiento]= '" + GiftCard.FechaVencimiento.ToString("yyyy-MM-dd") + "', Saldo= " + GiftCard.Saldo + ", Descuento= " + GiftCard.Descuento + ", Estado= '" + GiftCard.Estado + "', Rubro= '" + GiftCard.Rubro + "', Pais= '" + GiftCard.Pais + "' where Codigo = " + GiftCard.Codigo;
            }
            else
            {
                query = @"Insert into [Gift Card] ([Fecha de Creacion], [Fecha de Vencimiento], Saldo, Descuento, Estado, Rubro, Pais) values ('" + GiftCard.FechadeCreacion.ToString("yyyy-MM-dd") + "','" + GiftCard.FechaVencimiento.ToString("yyyy-MM-dd") + "'," + GiftCard.Saldo + "," + GiftCard.Descuento + ",'" + GiftCard.Estado +"','" + GiftCard.Rubro + "','" + GiftCard.Pais + "')";
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
