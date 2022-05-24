using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Abstract;
using Data_Acces_Layer;
using System.Data;

namespace Mapper
{
    public abstract class MPP_Gift_Card
    {
        Conexión conexión;
        public List<BE_Gift_Card> ListarTodo()
        {
            conexión = new Conexión();
            DataSet Ds;
            string query = @"Select * from [Gift Card]";
            Ds = conexión.DevolverListado(query);
            List<BE_Gift_Card> ListadeGiftCards = new List<BE_Gift_Card>();
            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in Ds.Tables[0].Rows)
                {
                    if (row[7] is DBNull)
                    {
                        BE_GiftCard_Internacional GiftInt = new BE_GiftCard_Internacional();
                        GiftInt.Codigo = Convert.ToInt32(row[0].ToString());
                        GiftInt.FechadeCreacion = Convert.ToDateTime(row[1].ToString());
                        GiftInt.FechaVencimiento = Convert.ToDateTime(row[2].ToString());
                        GiftInt.Saldo = Convert.ToDecimal(row[3].ToString());
                        GiftInt.Descuento = Convert.ToDecimal(row[4].ToString());
                        GiftInt.Estado = (BE_Gift_Card.Status)Enum.Parse(typeof(BE_Gift_Card.Status), row[5].ToString());
                        GiftInt.Rubro = (BE_Gift_Card.Rubros)Enum.Parse(typeof(BE_Gift_Card.Rubros), row[6].ToString());
                        GiftInt.Pais = row[8].ToString();
                        if (GiftInt.Vencimiento() && GiftInt.Estado != BE_Gift_Card.Status.Vencida && GiftInt.Estado != BE_Gift_Card.Status.Baja)
                        {
                            GiftInt.Estado = BE_Gift_Card.Status.Vencida;
                            MPP_GiftCard_Internacional oMPP_GiftInt = new MPP_GiftCard_Internacional();
                            oMPP_GiftInt.Guardar(GiftInt);
                        }
                        ListadeGiftCards.Add(GiftInt);
                    }
                    else
                    {
                        BE_GiftCard_Nacional GiftNac = new BE_GiftCard_Nacional();
                        GiftNac.Codigo = Convert.ToInt32(row[0].ToString());
                        GiftNac.FechadeCreacion = Convert.ToDateTime(row[1].ToString());
                        GiftNac.FechaVencimiento = Convert.ToDateTime(row[2].ToString());
                        GiftNac.Saldo = Convert.ToDecimal(row[3].ToString());
                        GiftNac.Descuento = Convert.ToDecimal(row[4].ToString());
                        GiftNac.Estado = (BE_Gift_Card.Status)Enum.Parse(typeof(BE_Gift_Card.Status), row[5].ToString());
                        GiftNac.Rubro = (BE_Gift_Card.Rubros)Enum.Parse(typeof(BE_Gift_Card.Rubros), row[6].ToString());
                        GiftNac.Provincia = row[7].ToString();
                        if (GiftNac.Vencimiento() && GiftNac.Estado != BE_Gift_Card.Status.Vencida && GiftNac.Estado != BE_Gift_Card.Status.Baja)
                        {
                            GiftNac.Estado = BE_Gift_Card.Status.Vencida;
                            MPP_GiftCard_Nacional oMPP_GifNac = new MPP_GiftCard_Nacional();
                            oMPP_GifNac.Guardar(GiftNac);
                        }
                        ListadeGiftCards.Add(GiftNac);
                    }
                }
            }
            else
            {
                ListadeGiftCards = null;
            }
            return ListadeGiftCards;
        }
        public List<BE_Gift_Card> ListarLibres()
        {
            conexión = new Conexión();
            DataSet Ds;
            string query = @"Select * from [Gift Card] where Estado= 'Libre'";
            Ds = conexión.DevolverListado(query);
            List<BE_Gift_Card> ListadeGiftCards = new List<BE_Gift_Card>();
            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in Ds.Tables[0].Rows)
                {
                    if (row[7] is DBNull)
                    {
                        BE_GiftCard_Internacional GiftInt = new BE_GiftCard_Internacional();
                        GiftInt.Codigo = Convert.ToInt32(row[0].ToString());
                        GiftInt.FechadeCreacion = Convert.ToDateTime(row[1].ToString());
                        GiftInt.FechaVencimiento = Convert.ToDateTime(row[2].ToString());
                        GiftInt.Saldo = Convert.ToDecimal(row[3].ToString());
                        GiftInt.Descuento = Convert.ToDecimal(row[4].ToString());
                        GiftInt.Estado = (BE_Gift_Card.Status)Enum.Parse(typeof(BE_Gift_Card.Status), row[5].ToString());
                        GiftInt.Rubro = (BE_Gift_Card.Rubros)Enum.Parse(typeof(BE_Gift_Card.Rubros), row[6].ToString());
                        GiftInt.Pais = row[8].ToString();
                        if (GiftInt.Vencimiento() && GiftInt.Estado != BE_Gift_Card.Status.Vencida)
                        {
                            GiftInt.Estado = BE_Gift_Card.Status.Vencida;
                            MPP_GiftCard_Internacional oMPP_GiftInt = new MPP_GiftCard_Internacional();
                            oMPP_GiftInt.Guardar(GiftInt);
                        }
                        else
                        {
                            ListadeGiftCards.Add(GiftInt);
                        }

                    }
                    else
                    {
                        BE_GiftCard_Nacional GiftNac = new BE_GiftCard_Nacional();
                        GiftNac.Codigo = Convert.ToInt32(row[0].ToString());
                        GiftNac.FechadeCreacion = Convert.ToDateTime(row[1].ToString());
                        GiftNac.FechaVencimiento = Convert.ToDateTime(row[2].ToString());
                        GiftNac.Saldo = Convert.ToDecimal(row[3].ToString());
                        GiftNac.Descuento = Convert.ToDecimal(row[4].ToString());
                        GiftNac.Estado = (BE_Gift_Card.Status)Enum.Parse(typeof(BE_Gift_Card.Status), row[5].ToString());
                        GiftNac.Rubro = (BE_Gift_Card.Rubros)Enum.Parse(typeof(BE_Gift_Card.Rubros), row[6].ToString());
                        GiftNac.Provincia = row[7].ToString();
                        if (GiftNac.Vencimiento() && GiftNac.Estado != BE_Gift_Card.Status.Vencida)
                        {
                            GiftNac.Estado = BE_Gift_Card.Status.Vencida;
                            MPP_GiftCard_Nacional oMPP_GifNac = new MPP_GiftCard_Nacional();
                            oMPP_GifNac.Guardar(GiftNac);
                        }
                        else
                        {
                            ListadeGiftCards.Add(GiftNac);
                        }

                    }
                }
            }
            else
            {
                ListadeGiftCards = null;
            }
            return ListadeGiftCards;
        }



    }
}
