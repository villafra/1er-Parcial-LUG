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
using System.ComponentModel.DataAnnotations;
using Conversiones;

namespace Presentación
{
    public partial class frmGiftCards : Form
    {
        BLL_GiftCard_Internacional oBLL_GiftCard_Internacional;
        BLL_GiftCard_Nacional oBLL_GiftCard_Nacional;
        BE_GiftCard_Internacional oBE_GiftCard_Internacional;
        BE_GiftCard_Nacional oBE_GiftCard_Nacional;
        public frmGiftCards()
        {
            InitializeComponent();
            oBLL_GiftCard_Nacional = new BLL_GiftCard_Nacional();
            oBLL_GiftCard_Internacional = new BLL_GiftCard_Internacional();
            oBE_GiftCard_Nacional = new BE_GiftCard_Nacional();
            oBE_GiftCard_Internacional = new BE_GiftCard_Internacional();
            Aspecto.FormatearDGV(dgvGiftCards);
            
        }

        private void ActualizarListado()
        {
            Cálculos.RefreshGrilla(dgvGiftCards, oBLL_GiftCard_Nacional.ListarTodo());
            Cálculos.RefreshComboBox(ComboRubro, Enum.GetNames(typeof(BE_Gift_Card.Rubros)));
            Cálculos.RefreshComboBox(comboAlcance, Enum.GetNames(typeof(Tipo)));
            Aspecto.DGVGiftCards(dgvGiftCards);
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cálculos.Txtvacío(txtPaisProv) && Cálculos.Numvacío(numSaldo))
                {
                    Nuevo();
                    ActualizarListado();
                    Cálculos.BorrarCampos(grpGiftCards);
                }
                else
                {
                    Cálculos.MsgBox("Por favor, complete los campos obligatorios");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cálculos.EstaSeguro(btnModificar))
                {
                    if (lblProvPais.Text == "Nacional")
                    {
                        ViejoNac();
                        oBLL_GiftCard_Nacional.Guardar(oBE_GiftCard_Nacional);
                    }
                    else
                    {
                        ViejoInt();
                        oBLL_GiftCard_Internacional.Guardar(oBE_GiftCard_Internacional);
                    }
                    ActualizarListado();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cálculos.BorrarCampos(grpGiftCards);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cálculos.EstaSeguro(btnEliminar))
                {
                    if (lblProvPais.Text == "Nacional")
                    {
                        ViejoNac();
                        if (oBLL_GiftCard_Nacional.GiftCardAsociada(oBE_GiftCard_Nacional))
                        {
                            Cálculos.MsgBox("No se puede eliminar la Gift Card. Ya se encuentra asociada a un cliente");
                        }
                        else
                        {
                            oBLL_GiftCard_Nacional.Baja(oBE_GiftCard_Nacional);
                        }
                    }
                    else
                    {
                        ViejoInt();
                        if (oBLL_GiftCard_Internacional.GiftCardAsociada(oBE_GiftCard_Internacional))
                        {
                            Cálculos.MsgBox("No se puede elimnar la Gift Card. Ya se encuentra asociada a un cliente");
                        }
                        else
                        {
                            oBLL_GiftCard_Internacional.Baja(oBE_GiftCard_Internacional);
                        }

                    }
                    ActualizarListado();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cálculos.BorrarCampos(grpGiftCards);
            }
        }

        private void Nuevo()
        {
            try
            {
                if (comboAlcance.Text == "Nacional")
                {
                    oBE_GiftCard_Nacional.Codigo = 0;
                    oBE_GiftCard_Nacional.FechadeCreacion = DateTime.Today;
                    oBE_GiftCard_Nacional.FechaVencimiento = oBE_GiftCard_Nacional.CalcularFechaVencimiento();
                    oBE_GiftCard_Nacional.Saldo = numSaldo.Value;
                    oBE_GiftCard_Nacional.Descuento = oBLL_GiftCard_Nacional.CalcularDescuento(oBE_GiftCard_Nacional);
                    oBE_GiftCard_Nacional.Estado = BE_Gift_Card.Status.Libre;
                    oBE_GiftCard_Nacional.Rubro = (BE_Gift_Card.Rubros)Enum.Parse(typeof(BE_Gift_Card.Rubros), ComboRubro.Text);
                    oBE_GiftCard_Nacional.Provincia = txtPaisProv.Text;
                    oBLL_GiftCard_Nacional.Guardar(oBE_GiftCard_Nacional);
                }
                else
                {
                    oBE_GiftCard_Internacional.Codigo = 0;
                    oBE_GiftCard_Internacional.FechadeCreacion = DateTime.Today;
                    oBE_GiftCard_Internacional.FechaVencimiento = oBE_GiftCard_Internacional.CalcularFechaVencimiento();
                    oBE_GiftCard_Internacional.Saldo = numSaldo.Value;
                    oBE_GiftCard_Internacional.Descuento = oBLL_GiftCard_Internacional.CalcularDescuento(oBE_GiftCard_Internacional);
                    oBE_GiftCard_Internacional.Estado = BE_Gift_Card.Status.Libre;
                    oBE_GiftCard_Internacional.Rubro = (BE_Gift_Card.Rubros)Enum.Parse(typeof(BE_Gift_Card.Rubros), ComboRubro.Text);
                    oBE_GiftCard_Internacional.Pais = txtPaisProv.Text;
                    oBLL_GiftCard_Internacional.Guardar(oBE_GiftCard_Internacional);
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void ViejoNac()
        {
            try
            {
                oBE_GiftCard_Nacional.Codigo = Convert.ToInt32(txtCodigo.Text);
                oBE_GiftCard_Nacional.FechaVencimiento = dtpFechaCreación.Value;
                oBE_GiftCard_Nacional.Saldo = numSaldo.Value;
                oBE_GiftCard_Nacional.Estado = (BE_Gift_Card.Status)Enum.Parse(typeof(BE_Gift_Card.Status), txtEstado.Text);
                oBE_GiftCard_Nacional.Rubro = (BE_Gift_Card.Rubros)Enum.Parse(typeof(BE_Gift_Card.Rubros), ComboRubro.Text);
                oBE_GiftCard_Nacional.Provincia = txtPaisProv.Text;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void ViejoInt()
        {
            try
            {
                oBE_GiftCard_Internacional.Codigo = Convert.ToInt32(txtCodigo.Text);
                oBE_GiftCard_Internacional.FechaVencimiento = dtpFechaCreación.Value;
                oBE_GiftCard_Internacional.Saldo = numSaldo.Value;
                oBE_GiftCard_Internacional.Estado = (BE_Gift_Card.Status)Enum.Parse(typeof(BE_Gift_Card.Status), txtEstado.Text);
                oBE_GiftCard_Internacional.Rubro = (BE_Gift_Card.Rubros)Enum.Parse(typeof(BE_Gift_Card.Rubros), ComboRubro.Text);
                oBE_GiftCard_Internacional.Pais = txtPaisProv.Text;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void dgvGiftCards_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BE_Gift_Card gift_Card = (BE_Gift_Card)dgvGiftCards.CurrentRow.DataBoundItem;
                if (gift_Card is BE_GiftCard_Nacional)
                {
                    txtCodigo.Text = (gift_Card as BE_GiftCard_Nacional).Codigo.ToString();
                    dtpFechaCreación.Value = (gift_Card as BE_GiftCard_Nacional).FechaVencimiento;
                    numSaldo.Value = (gift_Card as BE_GiftCard_Nacional).Saldo;
                    txtEstado.Text = (gift_Card as BE_GiftCard_Nacional).Estado.ToString();
                    ComboRubro.Text = (gift_Card as BE_GiftCard_Nacional).Rubro.ToString();
                    comboAlcance.Text = "Nacional";
                    txtPaisProv.Text = (gift_Card as BE_GiftCard_Nacional).Provincia;
                }
                else
                {
                    txtCodigo.Text = (gift_Card as BE_GiftCard_Internacional).Codigo.ToString();
                    dtpFechaCreación.Value = (gift_Card as BE_GiftCard_Internacional).FechaVencimiento;
                    numSaldo.Value = (gift_Card as BE_GiftCard_Internacional).Saldo;
                    txtEstado.Text = (gift_Card as BE_GiftCard_Internacional).Estado.ToString();
                    ComboRubro.Text = (gift_Card as BE_GiftCard_Internacional).Rubro.ToString();
                    comboAlcance.Text = "Internacional";
                    txtPaisProv.Text = (gift_Card as BE_GiftCard_Internacional).Pais;
                }
     

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public enum Tipo
        {
            Nacional, 
            Internacional
        }

        private void comboAlcance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboAlcance.Text != "Internacional") { lblProvPais.Text = "Provincia"; }
            else { lblProvPais.Text = "Pais"; };
        }

        private void frmGiftCards_Activated(object sender, EventArgs e)
        {
            ActualizarListado();
        }

        private void frmGiftCards_Load(object sender, EventArgs e)
        {
            ActualizarListado();
        }

        private void txtPaisProv_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cálculos.ValidarLetras(e);
        }
    }
}

