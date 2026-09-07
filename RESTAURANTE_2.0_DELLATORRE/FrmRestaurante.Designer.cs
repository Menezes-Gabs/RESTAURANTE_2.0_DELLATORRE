namespace RESTAURANTE_2._0_DELLATORRE
{
    partial class FrmRestaurante
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
            this.txtNomeClient = new System.Windows.Forms.TextBox();
            this.lblNomeClient = new System.Windows.Forms.Label();
            this.lblNascClient = new System.Windows.Forms.Label();
            this.DtpClient = new System.Windows.Forms.DateTimePicker();
            this.lblAniversario = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSaida = new System.Windows.Forms.Label();
            this.CboAlmoco = new System.Windows.Forms.CheckBox();
            this.CboBebidas = new System.Windows.Forms.CheckBox();
            this.GpbAlmoco = new System.Windows.Forms.GroupBox();
            this.txtOnde = new System.Windows.Forms.TextBox();
            this.lblOnde = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GpbBebidas = new System.Windows.Forms.GroupBox();
            this.CboSuco = new System.Windows.Forms.CheckBox();
            this.CboCerveja = new System.Windows.Forms.CheckBox();
            this.CboRefrig = new System.Windows.Forms.CheckBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.GpbAlmoco.SuspendLayout();
            this.GpbBebidas.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAGINA DO RESTAURANTE";
            // 
            // txtNomeClient
            // 
            this.txtNomeClient.Location = new System.Drawing.Point(53, 30);
            this.txtNomeClient.Name = "txtNomeClient";
            this.txtNomeClient.Size = new System.Drawing.Size(100, 20);
            this.txtNomeClient.TabIndex = 1;
            // 
            // lblNomeClient
            // 
            this.lblNomeClient.AutoSize = true;
            this.lblNomeClient.Location = new System.Drawing.Point(12, 33);
            this.lblNomeClient.Name = "lblNomeClient";
            this.lblNomeClient.Size = new System.Drawing.Size(35, 13);
            this.lblNomeClient.TabIndex = 2;
            this.lblNomeClient.Text = "Nome";
            // 
            // lblNascClient
            // 
            this.lblNascClient.AutoSize = true;
            this.lblNascClient.Location = new System.Drawing.Point(12, 65);
            this.lblNascClient.Name = "lblNascClient";
            this.lblNascClient.Size = new System.Drawing.Size(32, 13);
            this.lblNascClient.TabIndex = 3;
            this.lblNascClient.Text = "Nasc";
            // 
            // DtpClient
            // 
            this.DtpClient.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpClient.Location = new System.Drawing.Point(50, 59);
            this.DtpClient.Name = "DtpClient";
            this.DtpClient.Size = new System.Drawing.Size(112, 20);
            this.DtpClient.TabIndex = 4;
            this.DtpClient.ValueChanged += new System.EventHandler(this.DtpClient_ValueChanged);
            // 
            // lblAniversario
            // 
            this.lblAniversario.AutoSize = true;
            this.lblAniversario.Location = new System.Drawing.Point(179, 65);
            this.lblAniversario.Name = "lblAniversario";
            this.lblAniversario.Size = new System.Drawing.Size(182, 13);
            this.lblAniversario.TabIndex = 5;
            this.lblAniversario.Text = "DESCONTO DE ANIVERSARIANTE";
            this.lblAniversario.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 101);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total: ";
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.Location = new System.Drawing.Point(50, 101);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(25, 13);
            this.lblSaida.TabIndex = 7;
            this.lblSaida.Text = "$ ...";
            // 
            // CboAlmoco
            // 
            this.CboAlmoco.AutoSize = true;
            this.CboAlmoco.Location = new System.Drawing.Point(15, 133);
            this.CboAlmoco.Name = "CboAlmoco";
            this.CboAlmoco.Size = new System.Drawing.Size(61, 17);
            this.CboAlmoco.TabIndex = 8;
            this.CboAlmoco.Text = "Almoço";
            this.CboAlmoco.UseVisualStyleBackColor = true;
            this.CboAlmoco.CheckedChanged += new System.EventHandler(this.CboAlmoco_CheckedChanged);
            // 
            // CboBebidas
            // 
            this.CboBebidas.AutoSize = true;
            this.CboBebidas.Location = new System.Drawing.Point(243, 133);
            this.CboBebidas.Name = "CboBebidas";
            this.CboBebidas.Size = new System.Drawing.Size(64, 17);
            this.CboBebidas.TabIndex = 9;
            this.CboBebidas.Text = "Bebidas";
            this.CboBebidas.UseVisualStyleBackColor = true;
            this.CboBebidas.CheckedChanged += new System.EventHandler(this.CboBebidas_CheckedChanged);
            // 
            // GpbAlmoco
            // 
            this.GpbAlmoco.Controls.Add(this.txtOnde);
            this.GpbAlmoco.Controls.Add(this.lblOnde);
            this.GpbAlmoco.Controls.Add(this.label2);
            this.GpbAlmoco.Location = new System.Drawing.Point(15, 156);
            this.GpbAlmoco.Name = "GpbAlmoco";
            this.GpbAlmoco.Size = new System.Drawing.Size(200, 100);
            this.GpbAlmoco.TabIndex = 10;
            this.GpbAlmoco.TabStop = false;
            this.GpbAlmoco.Text = "ALMOÇO";
            this.GpbAlmoco.Visible = false;
            // 
            // txtOnde
            // 
            this.txtOnde.Location = new System.Drawing.Point(46, 42);
            this.txtOnde.Name = "txtOnde";
            this.txtOnde.Size = new System.Drawing.Size(100, 20);
            this.txtOnde.TabIndex = 12;
            // 
            // lblOnde
            // 
            this.lblOnde.AutoSize = true;
            this.lblOnde.Location = new System.Drawing.Point(7, 45);
            this.lblOnde.Name = "lblOnde";
            this.lblOnde.Size = new System.Drawing.Size(33, 13);
            this.lblOnde.TabIndex = 1;
            this.lblOnde.Text = "Onde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "+  R$ 35,00";
            // 
            // GpbBebidas
            // 
            this.GpbBebidas.Controls.Add(this.CboSuco);
            this.GpbBebidas.Controls.Add(this.CboCerveja);
            this.GpbBebidas.Controls.Add(this.CboRefrig);
            this.GpbBebidas.Location = new System.Drawing.Point(243, 156);
            this.GpbBebidas.Name = "GpbBebidas";
            this.GpbBebidas.Size = new System.Drawing.Size(200, 100);
            this.GpbBebidas.TabIndex = 11;
            this.GpbBebidas.TabStop = false;
            this.GpbBebidas.Text = "BEBIDAS";
            this.GpbBebidas.Visible = false;
            // 
            // CboSuco
            // 
            this.CboSuco.AutoSize = true;
            this.CboSuco.Location = new System.Drawing.Point(8, 69);
            this.CboSuco.Name = "CboSuco";
            this.CboSuco.Size = new System.Drawing.Size(95, 17);
            this.CboSuco.TabIndex = 2;
            this.CboSuco.Text = "SUCO $ 11,50";
            this.CboSuco.UseVisualStyleBackColor = true;
            this.CboSuco.CheckedChanged += new System.EventHandler(this.CboSuco_CheckedChanged);
            // 
            // CboCerveja
            // 
            this.CboCerveja.AutoSize = true;
            this.CboCerveja.Location = new System.Drawing.Point(8, 45);
            this.CboCerveja.Name = "CboCerveja";
            this.CboCerveja.Size = new System.Drawing.Size(110, 17);
            this.CboCerveja.TabIndex = 1;
            this.CboCerveja.Text = "CERVEJA $15,00";
            this.CboCerveja.UseVisualStyleBackColor = true;
            this.CboCerveja.CheckedChanged += new System.EventHandler(this.CboCerveja_CheckedChanged);
            // 
            // CboRefrig
            // 
            this.CboRefrig.AutoSize = true;
            this.CboRefrig.Location = new System.Drawing.Point(8, 22);
            this.CboRefrig.Name = "CboRefrig";
            this.CboRefrig.Size = new System.Drawing.Size(149, 17);
            this.CboRefrig.TabIndex = 0;
            this.CboRefrig.Text = "REFRIGERANTE $ 12,00";
            this.CboRefrig.UseVisualStyleBackColor = true;
            this.CboRefrig.CheckedChanged += new System.EventHandler(this.CboRefrig_CheckedChanged);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(15, 291);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(256, 52);
            this.btnFechar.TabIndex = 12;
            this.btnFechar.Text = "Fechar conta";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FrmRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.GpbBebidas);
            this.Controls.Add(this.GpbAlmoco);
            this.Controls.Add(this.CboBebidas);
            this.Controls.Add(this.CboAlmoco);
            this.Controls.Add(this.lblSaida);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblAniversario);
            this.Controls.Add(this.DtpClient);
            this.Controls.Add(this.lblNascClient);
            this.Controls.Add(this.lblNomeClient);
            this.Controls.Add(this.txtNomeClient);
            this.Controls.Add(this.label1);
            this.Name = "FrmRestaurante";
            this.Text = "FrmRestaurante";
            this.Load += new System.EventHandler(this.FrmRestaurante_Load);
            this.GpbAlmoco.ResumeLayout(false);
            this.GpbAlmoco.PerformLayout();
            this.GpbBebidas.ResumeLayout(false);
            this.GpbBebidas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeClient;
        private System.Windows.Forms.Label lblNomeClient;
        private System.Windows.Forms.Label lblNascClient;
        private System.Windows.Forms.DateTimePicker DtpClient;
        private System.Windows.Forms.Label lblAniversario;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSaida;
        private System.Windows.Forms.CheckBox CboAlmoco;
        private System.Windows.Forms.CheckBox CboBebidas;
        private System.Windows.Forms.GroupBox GpbAlmoco;
        private System.Windows.Forms.Label lblOnde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GpbBebidas;
        private System.Windows.Forms.TextBox txtOnde;
        private System.Windows.Forms.CheckBox CboSuco;
        private System.Windows.Forms.CheckBox CboCerveja;
        private System.Windows.Forms.CheckBox CboRefrig;
        private System.Windows.Forms.Button btnFechar;
    }
}