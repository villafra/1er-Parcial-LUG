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
    public partial class frmAsociaciones : Form
    {
        BLL_Cliente oBLL_Ciente;
        BLL_GiftCard_Internacional oBLL_GiftCard_Internacional;
        BLL_GiftCard_Nacional oBLL_GiftCard_Nacional;
        BE_Cliente oBE_Cliente;
        BE_Gift_Card oBE_Gift_Card;
        public frmAsociaciones()
        {
            InitializeComponent();
            oBLL_Ciente = new BLL_Cliente();
            oBLL_GiftCard_Internacional = new BLL_GiftCard_Internacional();
            oBLL_GiftCard_Nacional = new BLL_GiftCard_Nacional();
            dgvGiftCards.DataSource = oBLL_GiftCard_Nacional.ListarLibres();
            dgvClientes.DataSource = oBLL_Ciente.Listar();
          }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BE_Cliente oBE_Cliente = (BE_Cliente)dgvClientes.CurrentRow.DataBoundItem;

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
                    
                }
                else
                {
                   
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAsociarGiftCard_Click(object sender, EventArgs e)
        {
            oBE_Cliente = (BE_Cliente)dgvClientes.CurrentRow.DataBoundItem;
            oBE_Gift_Card = (BE_Gift_Card)dgvGiftCards.CurrentRow.DataBoundItem;
            oBLL_Ciente.AsociarGiftCard(oBE_Cliente, oBE_Gift_Card);
            dgvGiftCards.DataSource = oBLL_GiftCard_Nacional.ListarLibres();
            dgvClientes.DataSource = oBLL_Ciente.Listar();
        }

        private void btnDesasociarGiftCard_Click(object sender, EventArgs e)
        {
            oBE_Cliente = (BE_Cliente)dgvClientes.CurrentRow.DataBoundItem;
            oBLL_Ciente.DesasociarGiftCard(oBE_Cliente);
            dgvGiftCards.DataSource = oBLL_GiftCard_Nacional.ListarLibres();
            dgvClientes.DataSource = oBLL_Ciente.Listar();
        }
    }
}
