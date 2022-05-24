using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Acces_Layer;
using Entidades;
using Abstract;
using System.Data;

namespace Mapper
{
    public class MPP_DescuentoCalculado : IGestionable<BE_DescuentoCalculado>
    {
        Conexión conexión;
        public bool Baja(BE_DescuentoCalculado Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BE_DescuentoCalculado Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BE_DescuentoCalculado> Listar(BE_Gift_Card oBE_GiftCard)
        {
            conexión = new Conexión();
            DataSet Ds;
            string query = @"[GiftCard-Descuentos]" + oBE_GiftCard.Codigo;
            Ds = conexión.DevolverListado(query);
            List<BE_DescuentoCalculado> ListadeDescuentos = new List<BE_DescuentoCalculado>();
            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach(DataRow row1 in Ds.Tables[0].Rows)
                {
                    BE_DescuentoCalculado Descuento = new BE_DescuentoCalculado();
                    Descuento.CodigoGiftCard = oBE_GiftCard;
                    Descuento.TipoGiftCard = Descuento.CodigoGiftCard.DevolverTipo(Descuento.CodigoGiftCard);
                    Descuento.SumaDescuentos = Convert.ToDecimal(row1[3].ToString());
                    ListadeDescuentos.Add(Descuento);
                }
            }
            else
            {
                ListadeDescuentos = null;
            }
            return ListadeDescuentos;
        }

        public BE_DescuentoCalculado DevolverMAX()
        {
            conexión = new Conexión();
            DataSet Ds;
            string query = @"[Traer Descuento Maximo]";
            Ds = conexión.ListarStoreProcedure(query);
            BE_DescuentoCalculado Descuento = new BE_DescuentoCalculado();
            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row1 in Ds.Tables[0].Rows)
                {
                    DataSet Ds0;
                    string query1 = @"Select * from [Gift Card] where Codigo = " + Convert.ToInt32(row1[0].ToString());
                    Ds0 = conexión.DevolverListado(query1);
                    if (Ds0.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow row in Ds0.Tables[0].Rows)
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
                                Descuento.CodigoGiftCard = GiftInt;
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
                                Descuento.CodigoGiftCard = GiftNac;
                            }
                        }
                    }
                    Descuento.TipoGiftCard = Descuento.CodigoGiftCard.DevolverTipo(Descuento.CodigoGiftCard);
                    Descuento.SumaDescuentos = Convert.ToDecimal(row1[1].ToString());
                }
                
            }
            else
            {
                Descuento = null;
            }
            return Descuento;
        }
        public BE_DescuentoCalculado DevolverMIN()
        {
            conexión = new Conexión();
            DataSet Ds;
            string query = @"[Traer Saldo Mínimo]";
            Ds = conexión.ListarStoreProcedure(query);
            BE_DescuentoCalculado Descuento = new BE_DescuentoCalculado();
            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row1 in Ds.Tables[0].Rows)
                {
                    DataSet Ds0;
                    string query1 = @"Select * from [Gift Card] where Codigo = " + Convert.ToInt32(row1[0].ToString());
                    Ds0 = conexión.DevolverListado(query1);
                    if (Ds0.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow row in Ds0.Tables[0].Rows)
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
                                Descuento.CodigoGiftCard = GiftInt;
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
                                Descuento.CodigoGiftCard = GiftNac;
                            }
                        }
                    }
                    Descuento.TipoGiftCard = Descuento.CodigoGiftCard.DevolverTipo(Descuento.CodigoGiftCard);
                    Descuento.SumaDescuentos = Convert.ToDecimal(row1[1].ToString());
                }

            }
            else
            {
                Descuento = null;
            }
            return Descuento;
        }

        public List<BE_DescuentoCalculado> Listar()
        {
            throw new NotImplementedException();
        }

        public BE_DescuentoCalculado ListarObjeto(BE_DescuentoCalculado Objeto)
        {
            throw new NotImplementedException();
        }
    }
}
