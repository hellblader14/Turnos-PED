using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gestion_de_Turnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnpantalla_Click(object sender, EventArgs e)
        {
            pantallaTurnos turnos = new pantallaTurnos();
            turnos.Show();
        }

        private void btnlista_Click(object sender, EventArgs e)
        {
            numDesk nd = new numDesk();
            nd.ShowDialog();
            this.WindowState = FormWindowState.Minimized;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            tickets t = new tickets();
            t.Show();
        }

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			usuarios u = new usuarios();
			u.Show();
		}

		private void btnCli_Click(object sender, EventArgs e)
		{
			Clientes u = new Clientes();
			u.Show();
		}
	}
}
