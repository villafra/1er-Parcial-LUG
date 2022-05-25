using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversiones
{
    public static class Cálculos
    {
        public static void ValidarEnteros(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }
        public static void ValidarLetras(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }
        public static void BorrarCampos(Control grp)
        {
            foreach (Control c in grp.Controls)
            {
                if (c is TextBox)
                {
                    TextBox text = c as TextBox;
                    text.Text = null;
                }
                else if (c is NumericUpDown)
                {
                    NumericUpDown num = c as NumericUpDown;
                    num.Value = 0;
                }
                else if (c is ComboBox)
                {
                    ComboBox combo = c as ComboBox;
                    combo.Text = null;
                }
                else if (c is CheckBox)
                {
                    CheckBox check = c as CheckBox;
                    check.Checked = false;
                }
            }
        }
        public static bool Txtvacío(TextBox txt)
        {
            int sino = 0;
            if(txt.Text == "")
            {
                sino = 1;
            }
            return sino == 0;
        }
        public static bool Numvacío(NumericUpDown num)
        {
            int sino = 0;
            if (num.Value == 0)
            {
                sino = 1;
            }
            return sino == 0;
        }
        public static void RefreshGrilla(DataGridView dgv, object refObject)
        {
            dgv.DataSource = null;
            dgv.DataSource = refObject;
        }
        public static void RefreshComboBox(ComboBox combo, object refObject)
        {
            combo.DataSource = null;
            combo.DataSource = refObject;
        }
        public static void MsgBox(string mensaje)
        {
            MessageBox.Show(mensaje, "Gift Cards", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public static bool EstaSeguro(Button btn)
        {
            DialogResult resultado;
            resultado = MessageBox.Show(@"Esta seguro que desea " + btn.Text + " ?" , "Gift Cards", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
