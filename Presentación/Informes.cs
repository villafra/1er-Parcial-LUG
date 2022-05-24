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
            dgvGiftCards.DataSource = GifInt.ListarTodo();
            dgvClientes.DataSource = Cliente.Listar();
            BuscarMaximo();
            BuscarMinimo();
        }

        private void dgvGiftCards_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BE_Gift_Card gift_Card = (BE_Gift_Card)dgvGiftCards.CurrentRow.DataBoundItem;
            dgvDescuentos.DataSource = Descuento.Listar(gift_Card);
        }

        private void BuscarMaximo()
        {
            BE_DescuentoCalculado oBE_Descuento = Descuento.DevolverMAX();
            lblCodigoGiftMax.Text = oBE_Descuento.CodigoGiftCard.ToString();
            lblMaximo.Text = @"$" + oBE_Descuento.SumaDescuentos.ToString();
        }

        private void BuscarMinimo()
        {
            BE_DescuentoCalculado oBE_Descuento = Descuento.DevolverMIN();
            lblCodigoGiftMin.Text = oBE_Descuento.CodigoGiftCard.ToString();
            lblMinimo.Text = @"$" + oBE_Descuento.SumaDescuentos.ToString();
        }
    }
}
