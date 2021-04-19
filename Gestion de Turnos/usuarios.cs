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
	public partial class usuarios : Form
	{
		public usuarios()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection conexion = new SqlConnection("Data Source =.; Initial Catalog = Gestor_Turnos; Integrated Security = True");
				conexion.Open();
				MessageBox.Show("Se abrió la conexión con el servidor.");
				conexion.Close();
				MessageBox.Show("Se cerró la conexión.");
			}
			catch (SqlException ex)
			{
				MessageBox.Show("Conexión errónea.");
			}
		}
	}
}
