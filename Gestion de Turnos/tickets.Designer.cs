﻿
namespace Gestion_de_Turnos
{
    partial class tickets
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rbmiembro = new System.Windows.Forms.RadioButton();
            this.rbprioritario = new System.Windows.Forms.RadioButton();
            this.rbnomiembro = new System.Windows.Forms.RadioButton();
            this.btngenerar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(58, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agregue un turno nuevo";
            // 
            // rbmiembro
            // 
            this.rbmiembro.AutoSize = true;
            this.rbmiembro.Location = new System.Drawing.Point(33, 142);
            this.rbmiembro.Name = "rbmiembro";
            this.rbmiembro.Size = new System.Drawing.Size(167, 21);
            this.rbmiembro.TabIndex = 3;
            this.rbmiembro.TabStop = true;
            this.rbmiembro.Text = "Cliente Miembro - CM";
            this.rbmiembro.UseVisualStyleBackColor = true;
            // 
            // rbprioritario
            // 
            this.rbprioritario.AutoSize = true;
            this.rbprioritario.Location = new System.Drawing.Point(33, 80);
            this.rbprioritario.Name = "rbprioritario";
            this.rbprioritario.Size = new System.Drawing.Size(168, 21);
            this.rbprioritario.TabIndex = 4;
            this.rbprioritario.TabStop = true;
            this.rbprioritario.Text = "Cliente Prioritario - CP";
            this.rbprioritario.UseVisualStyleBackColor = true;
            // 
            // rbnomiembro
            // 
            this.rbnomiembro.AutoSize = true;
            this.rbnomiembro.Location = new System.Drawing.Point(33, 204);
            this.rbnomiembro.Name = "rbnomiembro";
            this.rbnomiembro.Size = new System.Drawing.Size(189, 21);
            this.rbnomiembro.TabIndex = 5;
            this.rbnomiembro.TabStop = true;
            this.rbnomiembro.Text = "Cliente no miembro - CN";
            this.rbnomiembro.UseVisualStyleBackColor = true;
            // 
            // btngenerar
            // 
            this.btngenerar.BackColor = System.Drawing.Color.Wheat;
            this.btngenerar.FlatAppearance.BorderSize = 0;
            this.btngenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngenerar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerar.ForeColor = System.Drawing.Color.DarkCyan;
            this.btngenerar.Location = new System.Drawing.Point(58, 258);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(164, 45);
            this.btngenerar.TabIndex = 6;
            this.btngenerar.Text = "Generar Ticket";
            this.btngenerar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(385, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(316, 248);
            this.dataGridView1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(28, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 44);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(-3, 369);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(748, 10);
            this.panel2.TabIndex = 9;
            // 
            // tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(742, 381);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.rbnomiembro);
            this.Controls.Add(this.rbprioritario);
            this.Controls.Add(this.rbmiembro);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "tickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Tickets";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbmiembro;
        private System.Windows.Forms.RadioButton rbprioritario;
        private System.Windows.Forms.RadioButton rbnomiembro;
        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}