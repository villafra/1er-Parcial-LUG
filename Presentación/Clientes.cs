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

namespace Presentación
{
    public partial class frmClientes : Form
    {
        BLL_Cliente OBLL_Cliente;
        BE_Cliente oBE_Cliente;
        public frmClientes()
        {
            InitializeComponent();
            OBLL_Cliente = new BLL_Cliente();
            oBE_Cliente = new BE_Cliente();
            Aspecto.FormatearDGV(dgvClientes);
        }

        private void ActualizarListado()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = OBLL_Cliente.Listar();
            Aspecto.DGVClientes(dgvClientes);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
            OBLL_Cliente.Guardar(oBE_Cliente);
            ActualizarListado();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Viejo();
            OBLL_Cliente.Guardar(oBE_Cliente);
            ActualizarListado();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            oBE_Cliente = (BE_Cliente)dgvClientes.CurrentRow.DataBoundItem;
            OBLL_Cliente.Baja(oBE_Cliente);
            ActualizarListado();
        }

        private void Nuevo()
        {
            try
            {
                oBE_Cliente.Codigo = 0;
                oBE_Cliente.DNI = long.Parse(txtDNI.Text);
                oBE_Cliente.Nombre = txtNombre.Text;
                oBE_Cliente.Apellido = txtApellido.Text;
                oBE_Cliente.FechadeNacimiento = dtpFechaNac.Value;
                oBE_Cliente.CodigoGiftCard = null;


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
                oBE_Cliente.Codigo = Convert.ToInt32(txtLegajo.Text);
                oBE_Cliente.DNI = long.Parse(txtDNI.Text);
                oBE_Cliente.Nombre = txtNombre.Text;
                oBE_Cliente.Apellido = txtApellido.Text;
                oBE_Cliente.FechadeNacimiento = dtpFechaNac.Value;

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
                oBE_Cliente = (BE_Cliente)dgvClientes.CurrentRow.DataBoundItem;
                txtLegajo.Text = oBE_Cliente.Codigo.ToString();
                txtDNI.Text = oBE_Cliente.DNI.ToString();
                txtNombre.Text = oBE_Cliente.Nombre;
                txtApellido.Text = oBE_Cliente.Apellido;
                dtpFechaNac.Value = oBE_Cliente.FechadeNacimiento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            ActualizarListado();
        }

        private void frmClientes_Activated(object sender, EventArgs e)
        {
            ActualizarListado();
        }
    }
}
