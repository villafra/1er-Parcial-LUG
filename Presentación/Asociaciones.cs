using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;
using Conversiones;

namespace Presentación
{
    public partial class frmAsociaciones : Form
    {
        BLL_Cliente oBLL_Ciente;
        BLL_GiftCard_Internacional oBLL_GiftCard_Internacional;
        BLL_GiftCard_Nacional oBLL_GiftCard_Nacional;
        BLL_Compra oBLL_Compra;
        BE_Compra oBE_Compra;
        BE_Cliente oBE_Cliente;
        BE_Gift_Card oBE_Gift_Card;
        public frmAsociaciones()
        {
            InitializeComponent();
            oBLL_Ciente = new BLL_Cliente();
            oBLL_GiftCard_Internacional = new BLL_GiftCard_Internacional();
            oBLL_GiftCard_Nacional = new BLL_GiftCard_Nacional();
            oBLL_Compra = new BLL_Compra();
            Aspecto.FormatearDGV(dgvClientes);
            Aspecto.FormatearDGV(dgvCompras);
            Aspecto.FormatearDGV(dgvGiftCards);
          }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BE_Cliente oBE_Cliente = (BE_Cliente)dgvClientes.CurrentRow.DataBoundItem;
                if (oBE_Cliente.CodigoGiftCard != null)
                {
                    dgvCompras.DataSource = oBLL_Compra.Listar(oBE_Cliente);
                    if (dgvCompras.Columns.Count > 0)
                    {
                        Aspecto.DGVComprasAsociaciones(dgvCompras);
                    }
                    lblSaldo.Text = "$ " + oBE_Cliente.CodigoGiftCard.Saldo.ToString();
                    lblEstado.Text = oBE_Cliente.CodigoGiftCard.Estado.ToString();
                    lblFechaVencimiento.Text = oBE_Cliente.CodigoGiftCard.FechaVencimiento.ToString("dd/MM/yyy");
                }
                else
                {
                    lblSaldo.Text = "";
                    lblEstado.Text = "";
                    lblFechaVencimiento.Text = "";
                    dgvCompras.DataSource = null;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAsociarGiftCard_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cálculos.EstaSeguro(btnAsociarGiftCard))
                {
                    oBE_Cliente = (BE_Cliente)dgvClientes.CurrentRow.DataBoundItem;
                    oBE_Gift_Card = (BE_Gift_Card)dgvGiftCards.CurrentRow.DataBoundItem;
                    if (!oBLL_Ciente.GiftCardAsociada(oBE_Cliente))
                    {
                        oBLL_Ciente.AsociarGiftCard(oBE_Cliente, oBE_Gift_Card);
                        ActualizarListado();
                    }
                    else
                    {
                        Cálculos.MsgBox("El cliente ya tiene una Gift Card asociada.\n Antes debe solicitar la baja de la actual");
                    }
                }
 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDesasociarGiftCard_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cálculos.EstaSeguro(btnDesasociarGiftCard))
                {
                    oBE_Cliente = (BE_Cliente)dgvClientes.CurrentRow.DataBoundItem;
                    oBLL_Ciente.DesasociarGiftCard(oBE_Cliente);
                    ActualizarListado();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCargarCompraCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cálculos.EstaSeguro(btnCargarCompraCliente))
                {
                    oBE_Cliente = (BE_Cliente)dgvClientes.CurrentRow.DataBoundItem;
                    if (oBE_Cliente.CodigoGiftCard != null)
                    {
                        if (oBE_Cliente.CodigoGiftCard.Estado != BE_Gift_Card.Status.Vencida)
                        {
                            BE_Compra oBE_Compra = new BE_Compra();
                            oBE_Compra.CodigoCliente = oBE_Cliente;
                            oBE_Compra.CodigoGiftCard = oBE_Cliente.CodigoGiftCard;
                            oBE_Compra.Descuento = oBE_Cliente.CodigoGiftCard.Descuento;
                            oBE_Compra.Monto = numMonto.Value;
                            oBE_Compra.CalcularDescuento();
                            if (oBLL_Compra.ValidarSaldo(oBE_Cliente.CodigoGiftCard, oBE_Compra))
                            {
                                if (oBE_Compra.CodigoGiftCard is BE_GiftCard_Internacional)
                                {
                                    oBLL_GiftCard_Internacional.CalcularMontodeCompra(oBE_Compra.CodigoGiftCard, oBE_Compra);
                                    oBLL_Compra.Guardar(oBE_Compra);
                                }
                                else
                                {
                                    oBLL_GiftCard_Nacional.CalcularMontodeCompra(oBE_Compra.CodigoGiftCard, oBE_Compra);
                                    oBLL_Compra.Guardar(oBE_Compra);
                                }
                                Cálculos.RefreshGrilla(dgvCompras,oBLL_Compra.Listar(oBE_Cliente));
                                Aspecto.DGVComprasAsociaciones(dgvCompras);
                                VerGiftCard();
                            }
                            else
                            {
                                Cálculos.MsgBox("El saldo de la Gift Card es insuficiente para esta compra");
                            }
                        }
                        else
                        {
                            Cálculos.MsgBox("La gift Card se encuentra vencida y no puede ser utilizada");
                        }
                    }
                    else
                    {
                        Cálculos.MsgBox("El cliente no tiene una Gift Card asociada. No se puede cargar la compra");
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEditCompra_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cálculos.EstaSeguro(btnEditCompra))
                {
                    oBE_Compra = (BE_Compra)dgvCompras.CurrentRow.DataBoundItem;
                    decimal TotalAnterior = oBE_Compra.Total;
                    oBE_Compra.Monto = numMonto.Value;
                    oBE_Compra.CalcularDescuento();
                    if (oBE_Compra.CodigoGiftCard is BE_GiftCard_Internacional)
                    {
                        oBLL_GiftCard_Internacional.ModificarMontodeCompra(oBE_Compra.CodigoGiftCard, oBE_Compra, TotalAnterior);
                        oBLL_Compra.Guardar(oBE_Compra);
                    }
                    else
                    {
                        oBLL_GiftCard_Nacional.ModificarMontodeCompra(oBE_Compra.CodigoGiftCard, oBE_Compra, TotalAnterior);
                        oBLL_Compra.Guardar(oBE_Compra);
                    }
                    Cálculos.RefreshGrilla(dgvCompras,oBLL_Compra.Listar(oBE_Cliente));
                    Aspecto.DGVComprasAsociaciones(dgvCompras);
                    VerGiftCard();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cálculos.BorrarCampos(grpCompras);
            }
        }

        private void btnEliminarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cálculos.EstaSeguro(btnEliminarCompra))
                {
                    oBE_Compra = (BE_Compra)dgvCompras.CurrentRow.DataBoundItem;
                    if (oBE_Compra.CodigoGiftCard is BE_GiftCard_Internacional)
                    {
                        oBLL_GiftCard_Internacional.EliminarMontodeCompra(oBE_Compra.CodigoGiftCard, oBE_Compra);
                        oBLL_Compra.Baja(oBE_Compra);
                    }
                    else
                    {
                        oBLL_GiftCard_Nacional.EliminarMontodeCompra(oBE_Compra.CodigoGiftCard, oBE_Compra);
                        oBLL_Compra.Baja(oBE_Compra);
                    }
                    Cálculos.RefreshGrilla(dgvCompras,oBLL_Compra.Listar(oBE_Cliente));
                    Aspecto.DGVComprasAsociaciones(dgvCompras);
                    VerGiftCard();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cálculos.BorrarCampos(grpCompras);
            }
        }

        private void btnBajaGiftCard_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cálculos.EstaSeguro(btnBajaGiftCard))
                {
                    oBE_Cliente = (BE_Cliente)dgvClientes.CurrentRow.DataBoundItem;
                    oBLL_Ciente.BajaGiftCard(oBE_Cliente);
                    ActualizarListado();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void ActualizarListado()
        {
            Cálculos.RefreshGrilla(dgvClientes, oBLL_Ciente.Listar());
            Cálculos.RefreshGrilla(dgvGiftCards, oBLL_GiftCard_Nacional.ListarLibres());
            Aspecto.DGVClientesAsociaciones(dgvClientes);
            Aspecto.DGVGiftCardsAsociaciones(dgvGiftCards);
        }
        private void frmAsociaciones_Load(object sender, EventArgs e)
        {
            ActualizarListado();
        }
        private void VerGiftCard()
        {
            try
            {
                BE_Cliente oBE_Cliente = (BE_Cliente)dgvClientes.CurrentRow.DataBoundItem;
                if (oBE_Cliente.CodigoGiftCard != null)
                {
                    lblSaldo.Text = "$ " + oBE_Cliente.CodigoGiftCard.Saldo.ToString();
                    lblEstado.Text = oBE_Cliente.CodigoGiftCard.Estado.ToString();
                    lblFechaVencimiento.Text = oBE_Cliente.CodigoGiftCard.FechaVencimiento.ToString("dd/MM/yyy");
                }
                else
                {
                    lblSaldo.Text = "";
                    lblEstado.Text = "";
                    lblFechaVencimiento.Text = "";
                    dgvCompras.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void frmAsociaciones_Activated(object sender, EventArgs e)
        {
            ActualizarListado();
        }
    }
}
