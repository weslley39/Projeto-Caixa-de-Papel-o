namespace Calculo
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtLargura2 = new System.Windows.Forms.TextBox();
            this.txtLargura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAreaTotal = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.lblLado = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Area";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Largura²";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Largura";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(67, 317);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(172, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(87, 87);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(213, 20);
            this.txtArea.TabIndex = 4;
            // 
            // txtLargura2
            // 
            this.txtLargura2.Enabled = false;
            this.txtLargura2.Location = new System.Drawing.Point(87, 116);
            this.txtLargura2.Name = "txtLargura2";
            this.txtLargura2.Size = new System.Drawing.Size(213, 20);
            this.txtLargura2.TabIndex = 5;
            // 
            // txtLargura
            // 
            this.txtLargura.Enabled = false;
            this.txtLargura.Location = new System.Drawing.Point(87, 144);
            this.txtLargura.Name = "txtLargura";
            this.txtLargura.Size = new System.Drawing.Size(213, 20);
            this.txtLargura.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Insira a area total";
            // 
            // txtAreaTotal
            // 
            this.txtAreaTotal.Location = new System.Drawing.Point(41, 25);
            this.txtAreaTotal.Name = "txtAreaTotal";
            this.txtAreaTotal.Size = new System.Drawing.Size(259, 20);
            this.txtAreaTotal.TabIndex = 8;
            this.txtAreaTotal.Text = "576";
            this.txtAreaTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAreaTotal_KeyPress);
            this.txtAreaTotal.Leave += new System.EventHandler(this.txtAreaTotal_Leave);
            // 
            // txtX1
            // 
            this.txtX1.Enabled = false;
            this.txtX1.Location = new System.Drawing.Point(87, 170);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(213, 20);
            this.txtX1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "X1";
            // 
            // txtX2
            // 
            this.txtX2.Enabled = false;
            this.txtX2.Location = new System.Drawing.Point(87, 196);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(213, 20);
            this.txtX2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "X2";
            // 
            // txtLado
            // 
            this.txtLado.Enabled = false;
            this.txtLado.Location = new System.Drawing.Point(87, 222);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(213, 20);
            this.txtLado.TabIndex = 14;
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(20, 226);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(31, 13);
            this.lblLado.TabIndex = 13;
            this.lblLado.Text = "Lado";
            // 
            // txtAltura
            // 
            this.txtAltura.Enabled = false;
            this.txtAltura.Location = new System.Drawing.Point(87, 248);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(213, 20);
            this.txtAltura.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Altura";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 352);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.lblLado);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAreaTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLargura);
            this.Controls.Add(this.txtLargura2);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Projeto Caixa de Papelao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtLargura2;
        private System.Windows.Forms.TextBox txtLargura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAreaTotal;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label7;
    }
}

