
namespace Gestion_de_Turnos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.btnpantalla = new System.Windows.Forms.Button();
			this.btnlista = new System.Windows.Forms.Button();
			this.btncrear = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnUsu = new System.Windows.Forms.Button();
			this.btnCli = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnpantalla
			// 
			this.btnpantalla.BackColor = System.Drawing.Color.Wheat;
			this.btnpantalla.FlatAppearance.BorderSize = 0;
			this.btnpantalla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
			this.btnpantalla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
			this.btnpantalla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnpantalla.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnpantalla.ForeColor = System.Drawing.Color.DarkCyan;
			this.btnpantalla.Location = new System.Drawing.Point(559, 177);
			this.btnpantalla.Name = "btnpantalla";
			this.btnpantalla.Size = new System.Drawing.Size(158, 120);
			this.btnpantalla.TabIndex = 3;
			this.btnpantalla.Text = "Mostrar turnos";
			this.btnpantalla.UseVisualStyleBackColor = false;
			this.btnpantalla.Click += new System.EventHandler(this.btnpantalla_Click);
			// 
			// btnlista
			// 
			this.btnlista.BackColor = System.Drawing.Color.Moccasin;
			this.btnlista.FlatAppearance.BorderSize = 0;
			this.btnlista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
			this.btnlista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnlista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnlista.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnlista.ForeColor = System.Drawing.Color.DarkCyan;
			this.btnlista.Location = new System.Drawing.Point(324, 177);
			this.btnlista.Name = "btnlista";
			this.btnlista.Size = new System.Drawing.Size(158, 120);
			this.btnlista.TabIndex = 4;
			this.btnlista.Text = "Gestionar Tickets";
			this.btnlista.UseVisualStyleBackColor = false;
			this.btnlista.Click += new System.EventHandler(this.btnlista_Click);
			// 
			// btncrear
			// 
			this.btncrear.BackColor = System.Drawing.Color.Moccasin;
			this.btncrear.FlatAppearance.BorderSize = 0;
			this.btncrear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btncrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btncrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btncrear.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btncrear.ForeColor = System.Drawing.Color.DarkCyan;
			this.btncrear.Location = new System.Drawing.Point(89, 177);
			this.btncrear.Name = "btncrear";
			this.btncrear.Size = new System.Drawing.Size(158, 120);
			this.btncrear.TabIndex = 4;
			this.btncrear.Text = "Crear Tickets";
			this.btncrear.UseVisualStyleBackColor = false;
			this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkCyan;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(2, 10);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(791, 109);
			this.panel1.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(148, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(530, 47);
			this.label1.TabIndex = 0;
			this.label1.Text = "Sistema Gestion De Turnos";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DarkCyan;
			this.panel2.Location = new System.Drawing.Point(2, 501);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(791, 15);
			this.panel2.TabIndex = 6;
			// 
			// btnUsu
			// 
			this.btnUsu.BackColor = System.Drawing.Color.Moccasin;
			this.btnUsu.FlatAppearance.BorderSize = 0;
			this.btnUsu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnUsu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUsu.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUsu.ForeColor = System.Drawing.Color.DarkCyan;
			this.btnUsu.Location = new System.Drawing.Point(209, 341);
			this.btnUsu.Name = "btnUsu";
			this.btnUsu.Size = new System.Drawing.Size(158, 120);
			this.btnUsu.TabIndex = 7;
			this.btnUsu.Text = "Control de Usuarios";
			this.btnUsu.UseVisualStyleBackColor = false;
			this.btnUsu.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnCli
			// 
			this.btnCli.BackColor = System.Drawing.Color.Moccasin;
			this.btnCli.FlatAppearance.BorderSize = 0;
			this.btnCli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
			this.btnCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCli.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCli.ForeColor = System.Drawing.Color.DarkCyan;
			this.btnCli.Location = new System.Drawing.Point(444, 341);
			this.btnCli.Name = "btnCli";
			this.btnCli.Size = new System.Drawing.Size(158, 120);
			this.btnCli.TabIndex = 8;
			this.btnCli.Text = "Control de Clientes";
			this.btnCli.UseVisualStyleBackColor = false;
			this.btnCli.Click += new System.EventHandler(this.btnCli_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightBlue;
			this.ClientSize = new System.Drawing.Size(794, 529);
			this.Controls.Add(this.btnUsu);
			this.Controls.Add(this.btnCli);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btncrear);
			this.Controls.Add(this.btnlista);
			this.Controls.Add(this.btnpantalla);
			this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sistema de Gestión de Turnos";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnpantalla;
        private System.Windows.Forms.Button btnlista;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnUsu;
		private System.Windows.Forms.Button btnCli;
	}
}

