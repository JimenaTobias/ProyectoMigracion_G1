﻿
namespace CapaVista_SisB
{
    partial class Mantenimiento_Cuenta
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
            this.navegador1 = new Navegador2._0.Navegador();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_tipo_cuenta = new System.Windows.Forms.ComboBox();
            this.cmb_tipo_moneda = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.cmb_auto = new System.Windows.Forms.ComboBox();
            this.cmb_auto1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(27, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(751, 78);
            this.navegador1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(206, 172);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(16, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Tag = "cue_cliente";
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(318, 257);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(24, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Tag = "cue_moneda";
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(80, 257);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(24, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Tag = "cue_tipo";
            this.textBox3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(246, 173);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(173, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.Tag = "cue_saldo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(748, 155);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Tag = "tbl_cuenta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cuenta Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tipo de Cuenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Saldo de Cuenta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Moneda de Cuenta";
            // 
            // cmb_tipo_cuenta
            // 
            this.cmb_tipo_cuenta.FormattingEnabled = true;
            this.cmb_tipo_cuenta.Items.AddRange(new object[] {
            "Cuenta Monetaria",
            "Cuenta de Ahorro"});
            this.cmb_tipo_cuenta.Location = new System.Drawing.Point(27, 230);
            this.cmb_tipo_cuenta.Name = "cmb_tipo_cuenta";
            this.cmb_tipo_cuenta.Size = new System.Drawing.Size(173, 21);
            this.cmb_tipo_cuenta.TabIndex = 10;
            this.cmb_tipo_cuenta.SelectedIndexChanged += new System.EventHandler(this.cmb_tipo_cuenta_SelectedIndexChanged);
            // 
            // cmb_tipo_moneda
            // 
            this.cmb_tipo_moneda.FormattingEnabled = true;
            this.cmb_tipo_moneda.Items.AddRange(new object[] {
            "Dolar Estadounidense",
            "Euro",
            "Quetzal"});
            this.cmb_tipo_moneda.Location = new System.Drawing.Point(246, 230);
            this.cmb_tipo_moneda.Name = "cmb_tipo_moneda";
            this.cmb_tipo_moneda.Size = new System.Drawing.Size(173, 21);
            this.cmb_tipo_moneda.TabIndex = 11;
            this.cmb_tipo_moneda.SelectedIndexChanged += new System.EventHandler(this.cmb_tipo_moneda_SelectedIndexChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(472, 173);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(173, 20);
            this.textBox5.TabIndex = 12;
            this.textBox5.Tag = "cue_numero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Numero de Cuenta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(469, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cuenta Usuario";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(661, 230);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(22, 20);
            this.textBox6.TabIndex = 15;
            this.textBox6.Tag = "cue_usuario";
            this.textBox6.Visible = false;
            // 
            // cmb_auto
            // 
            this.cmb_auto.FormattingEnabled = true;
            this.cmb_auto.Location = new System.Drawing.Point(29, 172);
            this.cmb_auto.Name = "cmb_auto";
            this.cmb_auto.Size = new System.Drawing.Size(171, 21);
            this.cmb_auto.TabIndex = 16;
            this.cmb_auto.SelectedIndexChanged += new System.EventHandler(this.cmb_auto_SelectedIndexChanged);
            // 
            // cmb_auto1
            // 
            this.cmb_auto1.FormattingEnabled = true;
            this.cmb_auto1.Location = new System.Drawing.Point(472, 230);
            this.cmb_auto1.Name = "cmb_auto1";
            this.cmb_auto1.Size = new System.Drawing.Size(171, 21);
            this.cmb_auto1.TabIndex = 17;
            this.cmb_auto1.SelectedIndexChanged += new System.EventHandler(this.cmb_auto1_SelectedIndexChanged);
            // 
            // Mantenimiento_Cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(this.cmb_auto1);
            this.Controls.Add(this.cmb_auto);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.cmb_tipo_moneda);
            this.Controls.Add(this.cmb_tipo_cuenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.navegador1);
            this.Name = "Mantenimiento_Cuenta";
            this.Text = "Mantenimiento_Cuenta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador2._0.Navegador navegador1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_tipo_cuenta;
        private System.Windows.Forms.ComboBox cmb_tipo_moneda;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox cmb_auto;
        private System.Windows.Forms.ComboBox cmb_auto1;
    }
}