using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmClientes);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            else
            {
                frm = new frmClientes();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void giftCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmGiftCards);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            else
            {
                frm = new frmGiftCards();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
