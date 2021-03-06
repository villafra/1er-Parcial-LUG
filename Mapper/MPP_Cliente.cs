using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Acces_Layer;
using Abstract;
using Entidades;
using System.Data;
using System.Data.SqlTypes;

namespace Mapper
{
    public class MPP_Cliente : IGestionable<BE_Cliente>
    {
        Conexión conexión;
        public bool Baja(BE_Cliente Cliente)
        {
            if (Cliente.CodigoGiftCard == null)
            {
                string query = @"Delete from Cliente where Legajo= " + Cliente.Codigo;
                conexión = new Conexión();
                return conexión.EscribirTransaction(query);
            }
            else
            {
                string[] query = new string[2];
                query[0] = @"Delete from Cliente where Legajo= " + Cliente.Codigo;
                query[1] = @"Update[Gift Card] set Estado = '" + BE_Gift_Card.Status.Libre.ToString() + "' where Codigo = " + Cliente.CodigoGiftCard.Codigo;
                conexión = new Conexión();
                return conexión.EscribirTransaction(query);
            }
            
        }

        public bool Guardar(BE_Cliente Cliente)
        {
            string query;

            if (Cliente.Codigo != 0)
            {
                query = @"Update Cliente set Nombre= '" + Cliente.Nombre + "', Apellido= '" + Cliente.Apellido + "', DNI= " + Cliente.DNI + ", [Fecha de Nacimiento]= '" + Cliente.FechadeNacimiento.ToString("yyyy-MM-dd") + "' where Legajo = " + Cliente.Codigo;
            }
            else
            {
                query = @"Insert into Cliente (Nombre, Apellido, DNI, [Fecha de Nacimiento]) values ('" + Cliente.Nombre + "', '" + Cliente.Apellido + "'," + Cliente.DNI + ",'" + Cliente.FechadeNacimiento.ToString("yyyy-MM-dd") + "')";
            }
            return conexión.EscribirTransaction(query);
        }

        public bool Asociaciones(BE_Cliente Cliente, BE_Gift_Card oBE_Gift_Card, BE_Gift_Card.Status estado)
        {
            string[] query = new string[2];
            if (estado.ToString() == "Activa")
            {
                query[0] = @"Update Cliente set Nombre= '" + Cliente.Nombre + "', Apellido= '" + Cliente.Apellido + "', DNI= " + Cliente.DNI + ", [Fecha de Nacimiento]= '" + Cliente.FechadeNacimiento.ToString("yyyy-MM-dd") + "', Codigo_GiftCard= " + oBE_Gift_Card.Codigo + " where Legajo = " + Cliente.Codigo;
            }
            else
            {
                query[0] = @"Update Cliente set Nombre= '" + Cliente.Nombre + "', Apellido= '" + Cliente.Apellido + "', DNI= " + Cliente.DNI + ", [Fecha de Nacimiento]= '" + Cliente.FechadeNacimiento.ToString("yyyy-MM-dd") + "', Codigo_GiftCard= " + SqlInt32.Null + " where Legajo = " + Cliente.Codigo;
            }
            query[1] = @"Update [Gift Card] set Estado= '" + estado.ToString() + "' where Codigo = " + oBE_Gift_Card.Codigo;
            return conexión.EscribirTransaction(query);
        }
        public List<BE_Cliente> Listar()
        {
            conexión = new Conexión();
            DataSet Ds;
            string query = @"Select * from Cliente";
            Ds = conexión.DevolverListado(query);
            List<BE_Cliente> ListadeClientes = new List<BE_Cliente>();

            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in Ds.Tables[0].Rows)
                {
                    BE_Cliente Cliente = new BE_Cliente();
                    Cliente.Codigo = Convert.ToInt32(row[0].ToString());
                    Cliente.Nombre = row[1].ToString();
                    Cliente.Apellido = row[2].ToString();
                    Cliente.DNI = long.Parse(row[3].ToString());
                    Cliente.FechadeNacimiento = Convert.ToDateTime(row[4].ToString());
                    if (!(row[5] is DBNull))
                    {
                        DataSet Ds1;
                        string query1 = @"Select * from [Gift Card] where Codigo= " + Convert.ToInt32(row[5].ToString());
                        Ds1 = conexión.DevolverListado(query1);
                        if (Ds1.Tables[0].Rows.Count > 0)
                        {
                            foreach(DataRow row1 in Ds1.Tables[0].Rows)
                            {
                                if (row1[7] is DBNull)
                                {
                                    BE_GiftCard_Internacional GiftInt = new BE_GiftCard_Internacional();
                                    GiftInt.Codigo = Convert.ToInt32(row1[0].ToString());
                                    GiftInt.FechadeCreacion = Convert.ToDateTime(row1[1].ToString());
                                    GiftInt.FechaVencimiento = Convert.ToDateTime(row1[2].ToString());
                                    GiftInt.Saldo = Convert.ToDecimal(row1[3].ToString());
                                    GiftInt.Descuento = Convert.ToDecimal(row1[4].ToString());
                                    GiftInt.Estado = (BE_Gift_Card.Status)Enum.Parse(typeof(BE_Gift_Card.Status), row1[5].ToString());
                                    GiftInt.Rubro = (BE_Gift_Card.Rubros)Enum.Parse(typeof(BE_Gift_Card.Rubros), row1[6].ToString());
                                    GiftInt.Pais = row1[8].ToString();
                                    if (GiftInt.Vencimiento() && GiftInt.Estado != BE_Gift_Card.Status.Vencida)
                                    {
                                        GiftInt.Estado = BE_Gift_Card.Status.Vencida;
                                        MPP_GiftCard_Internacional oMPP_GiftInt = new MPP_GiftCard_Internacional();
                                        oMPP_GiftInt.Guardar(GiftInt);
                                    }
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
                                    GiftNac.Estado = (BE_Gift_Card.Status)Enum.Parse(typeof(BE_Gift_Card.Status), row1[5].ToString());
                                    GiftNac.Rubro = (BE_Gift_Card.Rubros)Enum.Parse(typeof(BE_Gift_Card.Rubros), row1[6].ToString());
                                    GiftNac.Provincia = row1[7].ToString();
                                    if (GiftNac.Vencimiento() && GiftNac.Estado != BE_Gift_Card.Status.Vencida)
                                    {
                                        GiftNac.Estado = BE_Gift_Card.Status.Vencida;
                                        MPP_GiftCard_Nacional oMPP_GifNac = new MPP_GiftCard_Nacional();
                                        oMPP_GifNac.Guardar(GiftNac);
                                    }
                                    Cliente.CodigoGiftCard = GiftNac;
                                }
                            }
                        }
                    }
                    ListadeClientes.Add(Cliente);
                }
            }
            else
            {
                ListadeClientes = null;
            }
            return ListadeClientes;
        }

        public bool GiftCardAsociada(BE_Cliente oBE_Cliente)
        {
            string query = @"Select count(Codigo_GiftCard) from Cliente where Legajo= " + oBE_Cliente.Codigo;
            conexión = new Conexión();
            return conexión.LeerScalar(query);
        }
        public BE_Cliente ListarObjeto(BE_Cliente Cliente)
        {
            throw new NotImplementedException();
        }
    }
}
