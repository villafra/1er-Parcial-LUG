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
            ActualizarListado();
        }

        private void ActualizarListado()
        {
            dgvGiftCards.DataSource = null;
            dgvGiftCards.DataSource = oBLL_GiftCard_Nacional.ListarTodo();
            ComboRubro.DataSource = null;
            ComboRubro.DataSource = Enum.GetNames(typeof(Rubro));
            comboAlcance.DataSource = Enum.GetNames(typeof(Tipo));
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
            ActualizarListado();
        }

        private void btnModificar_Click(object sender, EventArgs e)
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lblProvPais.Text == "Nacional")
            {
                ViejoNac();
                oBLL_GiftCard_Nacional.Baja(oBE_GiftCard_Nacional);
            }
            else
            {
                ViejoInt();
                oBLL_GiftCard_Internacional.Baja(oBE_GiftCard_Internacional);
            }
            ActualizarListado();
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
                    oBE_GiftCard_Nacional.Estado = "Libre";
                    oBE_GiftCard_Nacional.Rubro = ComboRubro.Text;
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
                    oBE_GiftCard_Internacional.Estado = "Libre";
                    oBE_GiftCard_Internacional.Rubro = ComboRubro.Text;
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
                oBE_GiftCard_Nacional.Estado = txtEstado.Text;
                oBE_GiftCard_Nacional.Rubro = ComboRubro.Text;
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
                oBE_GiftCard_Internacional.Estado = txtEstado.Text;
                oBE_GiftCard_Internacional.Rubro = ComboRubro.Text;
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
                    txtEstado.Text = (gift_Card as BE_GiftCard_Nacional).Estado;
                    ComboRubro.Text = (gift_Card as BE_GiftCard_Nacional).Rubro;
                    comboAlcance.Text = "Nacional";
                    txtPaisProv.Text = (gift_Card as BE_GiftCard_Nacional).Provincia;
                }
                else
                {
                    txtCodigo.Text = (gift_Card as BE_GiftCard_Internacional).Codigo.ToString();
                    dtpFechaCreación.Value = (gift_Card as BE_GiftCard_Internacional).FechaVencimiento;
                    numSaldo.Value = (gift_Card as BE_GiftCard_Internacional).Saldo;
                    txtEstado.Text = (gift_Card as BE_GiftCard_Internacional).Estado;
                    ComboRubro.Text = (gift_Card as BE_GiftCard_Internacional).Rubro;
                    comboAlcance.Text = "Internacional";
                    txtPaisProv.Text = (gift_Card as BE_GiftCard_Internacional).Pais;
                }
     

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
             public enum Estado 
        {
            [Display(Name = "Libre")]
            Libre = 1,
            [Display(Name = "Activa")]
            Activa = 2,
            [Display(Name = "Baja")]
            Baja = 3,
            [Display(Name = "Vencida")]
            Vencida = 4,
            [Display(Name = "Sin Saldo")]
            Sin_Saldo = 5
        }

        public enum Rubro
        {
            [Display(Name = "Libre")]
            Libre = 1,
            [Display(Name = "Calzado")]
            Calzado = 2,
            [Display(Name = "Electrodoméstivos")]
            Electrodomésticos = 3
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
    }
}

