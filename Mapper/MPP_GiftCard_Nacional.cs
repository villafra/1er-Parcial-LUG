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

            if (GiftCard.Codigo != 0)
            {
                query = @"Update Cliente set Codigo= '" + GiftCard.Codigo + "', [Fecha de Otorgamiento]= '" + GiftCard.FechaOtorgamiento + "', [Fecha de Vencimiento]= '" + GiftCard.FechaVencimiento + "', Saldo= " + GiftCard.Saldo + ", Descuento= " + GiftCard.Descuento + ", Estado= '" + GiftCard.Estado + "', Rubro= '" + GiftCard.Rubro + "', Provincia= '" + GiftCard.Provincia + "' where Codigo = " + GiftCard.Codigo;
            }
            else
            {
                query = @"Insert into [Gift Card] ([Fecha de Otorgamiento], [Fecha de Vencimiento], Saldo, Descuento, Estado, Rubro, Pais) values ('" + GiftCard.FechaOtorgamiento + "', '" + GiftCard.FechaVencimiento + "'," + GiftCard.Saldo + "," + GiftCard.Descuento + ",'" + GiftCard.Estado + "','" + GiftCard.Rubro + "','" + GiftCard.Provincia + "')";
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
    }
}
