using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract;
using Entidades;
using Data_Acces_Layer;
using System.Data;

namespace Mapper
{
    public class MPP_Compra : IGestionable<BE_Compra>
    {
        Conexión conexión;

        public bool Baja(BE_Compra Compra)
        {
            string[] query = new string[2];
            query[0] = @"Delete from Compra where Codigo= " + Compra.Codigo;
            query[1] = @"Update [Gift Card] set Saldo = " + Compra.CodigoGiftCard.Saldo + ", Estado = '" + Compra.CodigoGiftCard.Estado + "' where Codigo= " + Compra.CodigoGiftCard.Codigo;
            conexión = new Conexión();
            return conexión.EscribirTransaction(query);
        }

        public bool Guardar(BE_Compra Compra)
        {
            string[] query = new string[2];

            if (Compra.Codigo != 0)
            {
                query[0] = @"Update Compra set Codigo_Cliente= " + Compra.CodigoCliente.Codigo + ", Codigo_GiftCard= " + Compra.CodigoGiftCard.Codigo + ", Monto= " + Compra.Monto + ", Descuento= " + Compra.Descuento + ", Total = " + Compra.Total + "where Codigo = " + Compra.Codigo;
            }
            else
            {
                query[0] = @"Insert into Compra (Codigo_Cliente, Codigo_GiftCard, Monto, Descuento, Total) values (" + Compra.CodigoCliente.Codigo + "," + Compra.CodigoGiftCard.Codigo + "," + Compra.Monto + "," + Compra.Descuento + "," + Compra.Total + ")"; 
            }
            query[1] = @"Update [Gift Card] set Saldo = " + Compra.CodigoGiftCard.Saldo + ", Estado = '" + Compra.CodigoGiftCard.Estado + "' where Codigo= " + Compra.CodigoGiftCard.Codigo;
            return conexión.EscribirTransaction(query);
        }

        public List<BE_Compra> Listar(BE_Cliente oBE_Cliente)
        {
            conexión = new Conexión();
            DataSet Ds;
            string query = @"Select * from Compra where Codigo_Cliente= " + oBE_Cliente.Codigo;
            Ds = conexión.DevolverListado(query);
            List<BE_Compra> ListadeCompras = new List<BE_Compra>();
            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in Ds.Tables[0].Rows)
                {
                    BE_Compra Compra = new BE_Compra();
                    Compra.Codigo = Convert.ToInt32(row[0].ToString());
                    Compra.Monto = Convert.ToDecimal(row[3].ToString());
                    Compra.Descuento = Convert.ToDecimal(row[4].ToString());
                    Compra.Total = Convert.ToDecimal(row[5].ToString());
                    
                    DataSet Ds0;
                    string query0 = @"Select * from Cliente where Legajo= " + oBE_Cliente.Codigo;
                    Ds0 = conexión.DevolverListado(query0);
                    if (Ds0.Tables[0].Rows.Count > 0)
                    {
                        foreach(DataRow row0 in Ds0.Tables[0].Rows)
                        {
                            BE_Cliente Cliente = new BE_Cliente();
                            Cliente.Codigo = Convert.ToInt32(row0[0].ToString());
                            Cliente.Nombre = row0[1].ToString();
                            Cliente.Apellido = row0[2].ToString();
                            Cliente.DNI = long.Parse(row0[3].ToString());
                            Cliente.FechadeNacimiento = Convert.ToDateTime(row0[4].ToString());
                            if (!(row0[5] is DBNull))
                            {
                                DataSet Ds1;
                                string query1 = @"Select * from [Gift Card] where Codigo= " + Convert.ToInt32(row0[5].ToString());
                                Ds1 = conexión.DevolverListado(query1);
                                if (Ds1.Tables[0].Rows.Count > 0)
                                {
                                    foreach (DataRow row1 in Ds1.Tables[0].Rows)
                                    {
                                        if (row1[7] is DBNull)
                                        {
                                            BE_GiftCard_Internacional GiftInt = new BE_GiftCard_Internacional();
                                            GiftInt.Codigo = Convert.ToInt32(row1[0].ToString());
                                            GiftInt.FechadeCreacion = Convert.ToDateTime(row1[1].ToString());
                                            GiftInt.FechaVencimiento = Convert.ToDateTime(row1[2].ToString());
                                            GiftInt.Saldo = Convert.ToDecimal(row1[3].ToString());
                                            GiftInt.Descuento = Convert.ToDecimal(row1[4].ToString());
                                            GiftInt.Estado = row1[5].ToString();
                                            GiftInt.Rubro = row1[6].ToString();
                                            GiftInt.Pais = row1[8].ToString();
                                            Cliente.CodigoGiftCard = GiftInt;
                                        }
                                        else
                                        {
                                            BE_GiftCard_Nacional GiftNac = new BE_GiftCard_Nacional();
                                            GiftNac.Codigo = Convert.ToInt32(row1[0].ToString());
                                            GiftNac.FechadeCreacion = Convert.ToDateTime(row1[1].ToString());
                                            GiftNac.FechaVencimiento = Convert.ToDateTime(row1[2].ToString());
                                            GiftNac.Saldo = Convert.ToDecimal(row1[3].ToString());
                                            GiftNac.Descuento = Convert.ToDecimal(row1[4].ToString());
                                            GiftNac.Estado = row1[5].ToString();
                                            GiftNac.Rubro = row1[6].ToString();
                                            GiftNac.Provincia = row1[7].ToString();
                                            Cliente.CodigoGiftCard = GiftNac;
                                        }
                                    }
                                }
                                Compra.CodigoCliente = Cliente;
                                Compra.CodigoGiftCard = Cliente.CodigoGiftCard;
                            }
                           
                            
                        }
                        ListadeCompras.Add(Compra); 
                    }
                   
                }
            }
            else
            {
                ListadeCompras = null;
            }
            return ListadeCompras;
        }

        public List<BE_Compra> Listar()
        {
            throw new NotImplementedException();
        }

        public BE_Compra ListarObjeto(BE_Compra Objeto)
        {
            throw new NotImplementedException();
        }
    }
}
