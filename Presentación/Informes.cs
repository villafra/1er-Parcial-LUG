using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;
using Conversiones;


namespace Presentación
{
    public partial class frmInformes : Form
    {
        BLL_DescuentoCalculado Descuento;
        BLL_Gift_Card GiftCard;
        BLL_GiftCard_Nacional GiftNac;
        BLL_GiftCard_Internacional GifInt;
        BLL_Cliente Cliente;
        public frmInformes()
        {
            InitializeComponent();
            Descuento = new BLL_DescuentoCalculado();
            GifInt = new BLL_GiftCard_Internacional();
            Cliente = new BLL_Cliente();
            Aspecto.FormatearDGV(dgvClientes);
            Aspecto.FormatearDGV(dgvGiftCards);
            Aspecto.FormatearDGV(dgvDescuentos);
            
        }

        private void dgvGiftCards_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BE_Gift_Card gift_Card = (BE_Gift_Card)dgvGiftCards.CurrentRow.DataBoundItem;
            try
            {
                dgvDescuentos.DataSource = Descuento.Listar(gift_Card);
                Aspecto.DGVDescuentos(dgvDescuentos);
            }
            catch { }
        }

        private void BuscarMaximo()
        {
            try
            {
            BE_DescuentoCalculado oBE_Descuento = Descuento.DevolverMAX();
            lblCodigoGiftMax.Text = oBE_Descuento.CodigoGiftCard.ToString();
            lblMaximo.Text = @"$" + oBE_Descuento.SumaDescuentos.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la Gift Card Con descuento Máximo.\n" + ex.Message);
            }
        }

        private void BuscarMinimo()
        {
            try
            {
            BE_DescuentoCalculado oBE_Descuento = Descuento.DevolverMIN();
            lblCodigoGiftMin.Text = oBE_Descuento.CodigoGiftCard.ToString();
            lblMinimo.Text = @"$" + oBE_Descuento.SumaDescuentos.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la Gift Card con el menor saldo" + ex.Message);
            }
        }

        private void frmInformes_Load(object sender, EventArgs e)
        {
            dgvGiftCards.DataSource = GifInt.ListarTodo();
            dgvClientes.DataSource = Cliente.Listar();
            Aspecto.DGVGiftCards(dgvGiftCards);
            Aspecto.DGVClientes(dgvClientes);
            BuscarMaximo();
            BuscarMinimo();
        }
    }
}
