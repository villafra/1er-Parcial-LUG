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
            Viejo();
            ActualizarListado();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Viejo();
            oBLL_GiftCard_Nacional.Guardar(oBE_GiftCard_Nacional);
            ActualizarListado();
        }

        private void Nuevo()
        {
            try
            {
                if (comboAlcance.Text == "Nacional")
                {
                    oBE_GiftCard_Nacional.Codigo = 0;
                    oBE_GiftCard_Nacional.FechaVencimiento = oBE_GiftCard_Nacional.CalcularFechaVencimiento();
                    oBE_GiftCard_Nacional.Saldo = numSaldo.Value;
                    oBE_GiftCard_Nacional.Descuento = oBLL_GiftCard_Nacional.CalcularDescuento(oBE_GiftCard_Nacional);
                    oBE_GiftCard_Nacional.Estado = "Libre";
                    oBE_GiftCard_Nacional.Rubro = ComboRubro.Text;
                    oBE_GiftCard_Nacional.Provincia = txtPaisProv.Text;
                }
                else
                {
                    oBE_GiftCard_Internacional.Codigo = 0;
                    oBE_GiftCard_Internacional.FechaVencimiento = oBE_GiftCard_Internacional.CalcularFechaVencimiento();
                    oBE_GiftCard_Internacional.Saldo = numSaldo.Value;
                    oBE_GiftCard_Internacional.Descuento = oBLL_GiftCard_Internacional.CalcularDescuento(oBE_GiftCard_Internacional);
                    oBE_GiftCard_Internacional.Estado = "Libre";
                    oBE_GiftCard_Internacional.Rubro = ComboRubro.Text;
                    oBE_GiftCard_Internacional.Pais = txtPaisProv.Text;
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void Viejo()
        {
            try
            {
                //oBE_Cliente.Codigo = Convert.ToInt32(txtLegajo.Text);
                //oBE_Cliente.DNI = long.Parse(txtDNI.Text);
                //oBE_Cliente.Nombre = txtNombre.Text;
                //oBE_Cliente.Apellido = txtApellido.Text;
                //oBE_Cliente.FechadeNacimiento = dtpFechaNac.Value;
                //oBE_Cliente.CodigoGiftCard = null;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //oBE_Cliente = (BE_Cliente)dgvGiftCards.CurrentRow.DataBoundItem;
                //txtLegajo.Text = oBE_Cliente.Codigo.ToString();
                //txtDNI.Text = oBE_Cliente.DNI.ToString();
                //txtNombre.Text = oBE_Cliente.Nombre;
                //txtApellido.Text = oBE_Cliente.Apellido;
                //dtpFechaNac.Value = oBE_Cliente.FechadeNacimiento;
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
    }
}

