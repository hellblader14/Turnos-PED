using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Turnos
{
    public partial class numDesk : Form
    {
        public numDesk()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Gestion ges = new Gestion(int.Parse(txtNum.Text));
                ges.Show();
                this.Close();
            }
            catch
            {
                errorProvider1.SetError(txtNum, "Ingrese un dato válido");
            }
        }
    }
}
