﻿namespace lion_finance_app

{
    partial class TelaCadastroFinanceiro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblControl = new Label();
            lblFixos = new Label();
            lblVari = new Label();
            lblRec = new Label();
            lblFinan = new Label();
            lblContas = new Label();
            lblParcela = new Label();
            lblAluguel = new Label();
            txtFinanc = new TextBox();
            lblCompras = new Label();
            lblLazer = new Label();
            txtConta = new TextBox();
            txtParc = new TextBox();
            txtAluguel = new TextBox();
            txtCompra = new TextBox();
            txtLazer = new TextBox();
            lblTransp = new Label();
            txtTransp = new TextBox();
            lblRecebimentoFixo = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            lblRecebimentoVariavel = new Label();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblControl
            // 
            lblControl.AutoSize = true;
            lblControl.Font = new Font("Broadway", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblControl.ForeColor = Color.White;
            lblControl.Location = new Point(21, 25);
            lblControl.Name = "lblControl";
            lblControl.Size = new Size(469, 43);
            lblControl.TabIndex = 0;
            lblControl.Text = "Controle de Despesas";
            lblControl.Click += label1_Click;
            // 
            // lblFixos
            // 
            lblFixos.AutoSize = true;
            lblFixos.Font = new Font("Arial Black", 13F, FontStyle.Bold);
            lblFixos.ForeColor = Color.White;
            lblFixos.Location = new Point(38, 95);
            lblFixos.Name = "lblFixos";
            lblFixos.Size = new Size(160, 26);
            lblFixos.TabIndex = 2;
            lblFixos.Text = "GASTOS FIXOS";
            lblFixos.Click += lblFixos_Click;
            // 
            // lblVari
            // 
            lblVari.AutoSize = true;
            lblVari.Font = new Font("Arial Black", 13F, FontStyle.Bold);
            lblVari.ForeColor = Color.White;
            lblVari.Location = new Point(38, 280);
            lblVari.Name = "lblVari";
            lblVari.Size = new Size(209, 26);
            lblVari.TabIndex = 3;
            lblVari.Text = "GASTOS VARIÁVEIS";
            // 
            // lblRec
            // 
            lblRec.AutoSize = true;
            lblRec.Font = new Font("Arial Black", 13F, FontStyle.Bold);
            lblRec.ForeColor = Color.White;
            lblRec.Location = new Point(480, 280);
            lblRec.Name = "lblRec";
            lblRec.Size = new Size(172, 26);
            lblRec.TabIndex = 4;
            lblRec.Text = "RECEBIMENTOS";
            lblRec.Click += label4_Click;
            // 
            // lblFinan
            // 
            lblFinan.AutoSize = true;
            lblFinan.Font = new Font("Arial Black", 9.75F, FontStyle.Bold);
            lblFinan.ForeColor = Color.White;
            lblFinan.Location = new Point(38, 148);
            lblFinan.Name = "lblFinan";
            lblFinan.Size = new Size(128, 18);
            lblFinan.TabIndex = 5;
            lblFinan.Text = "Financiamentos:";
            // 
            // lblContas
            // 
            lblContas.AutoSize = true;
            lblContas.Font = new Font("Arial Black", 9.75F, FontStyle.Bold);
            lblContas.ForeColor = Color.White;
            lblContas.Location = new Point(38, 177);
            lblContas.Name = "lblContas";
            lblContas.Size = new Size(170, 18);
            lblContas.TabIndex = 6;
            lblContas.Text = "Contas (Luz, Internet):";
            lblContas.Click += lblContas_Click;
            // 
            // lblParcela
            // 
            lblParcela.AutoSize = true;
            lblParcela.Font = new Font("Arial Black", 9.75F, FontStyle.Bold);
            lblParcela.ForeColor = Color.White;
            lblParcela.Location = new Point(38, 206);
            lblParcela.Name = "lblParcela";
            lblParcela.Size = new Size(121, 18);
            lblParcela.TabIndex = 7;
            lblParcela.Text = "Parcelamentos:";
            // 
            // lblAluguel
            // 
            lblAluguel.AutoSize = true;
            lblAluguel.Font = new Font("Arial Black", 9.75F, FontStyle.Bold);
            lblAluguel.ForeColor = Color.White;
            lblAluguel.Location = new Point(38, 235);
            lblAluguel.Name = "lblAluguel";
            lblAluguel.Size = new Size(121, 18);
            lblAluguel.TabIndex = 8;
            lblAluguel.Text = "Aluguel Mensal:";
            // 
            // txtFinanc
            // 
            txtFinanc.Location = new Point(254, 143);
            txtFinanc.Name = "txtFinanc";
            txtFinanc.Size = new Size(153, 23);
            txtFinanc.TabIndex = 9;
            txtFinanc.TextChanged += txtFinanc_TextChanged;
            // 
            // lblCompras
            // 
            lblCompras.AutoSize = true;
            lblCompras.Font = new Font("Arial Black", 9.75F, FontStyle.Bold);
            lblCompras.ForeColor = Color.White;
            lblCompras.Location = new Point(39, 319);
            lblCompras.Name = "lblCompras";
            lblCompras.Size = new Size(131, 18);
            lblCompras.TabIndex = 10;
            lblCompras.Text = "Compras do Mês:";
            // 
            // lblLazer
            // 
            lblLazer.AutoSize = true;
            lblLazer.Font = new Font("Arial Black", 9.75F, FontStyle.Bold);
            lblLazer.ForeColor = Color.White;
            lblLazer.Location = new Point(39, 350);
            lblLazer.Name = "lblLazer";
            lblLazer.Size = new Size(53, 18);
            lblLazer.TabIndex = 11;
            lblLazer.Text = "Lazer:";
            // 
            // txtConta
            // 
            txtConta.Location = new Point(254, 172);
            txtConta.Name = "txtConta";
            txtConta.Size = new Size(153, 23);
            txtConta.TabIndex = 12;
            txtConta.TextChanged += txtConta_TextChanged;
            // 
            // txtParc
            // 
            txtParc.Location = new Point(254, 201);
            txtParc.Name = "txtParc";
            txtParc.Size = new Size(153, 23);
            txtParc.TabIndex = 13;
            // 
            // txtAluguel
            // 
            txtAluguel.Location = new Point(254, 230);
            txtAluguel.Name = "txtAluguel";
            txtAluguel.Size = new Size(153, 23);
            txtAluguel.TabIndex = 14;
            // 
            // txtCompra
            // 
            txtCompra.Location = new Point(254, 314);
            txtCompra.Name = "txtCompra";
            txtCompra.Size = new Size(153, 23);
            txtCompra.TabIndex = 15;
            // 
            // txtLazer
            // 
            txtLazer.Location = new Point(254, 343);
            txtLazer.Name = "txtLazer";
            txtLazer.Size = new Size(153, 23);
            txtLazer.TabIndex = 16;
            // 
            // lblTransp
            // 
            lblTransp.AutoSize = true;
            lblTransp.Font = new Font("Arial Black", 9.75F, FontStyle.Bold);
            lblTransp.ForeColor = Color.White;
            lblTransp.Location = new Point(39, 377);
            lblTransp.Name = "lblTransp";
            lblTransp.Size = new Size(92, 18);
            lblTransp.TabIndex = 17;
            lblTransp.Text = "Transporte:";
            // 
            // txtTransp
            // 
            txtTransp.Location = new Point(254, 372);
            txtTransp.Name = "txtTransp";
            txtTransp.Size = new Size(153, 23);
            txtTransp.TabIndex = 18;
            // 
            // lblRecebimentoFixo
            // 
            lblRecebimentoFixo.AutoSize = true;
            lblRecebimentoFixo.Font = new Font("Arial Black", 9.75F, FontStyle.Bold);
            lblRecebimentoFixo.ForeColor = Color.White;
            lblRecebimentoFixo.Location = new Point(480, 321);
            lblRecebimentoFixo.Name = "lblRecebimentoFixo";
            lblRecebimentoFixo.Size = new Size(130, 18);
            lblRecebimentoFixo.TabIndex = 19;
            lblRecebimentoFixo.Text = "Rendimento fixo:";
            lblRecebimentoFixo.Click += lblSalario_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(663, 316);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(126, 23);
            textBox1.TabIndex = 20;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(554, 446);
            button1.Name = "button1";
            button1.Size = new Size(106, 25);
            button1.TabIndex = 21;
            button1.Text = "Inserir";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(683, 446);
            button2.Name = "button2";
            button2.Size = new Size(106, 25);
            button2.TabIndex = 22;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblRecebimentoVariavel
            // 
            lblRecebimentoVariavel.AutoSize = true;
            lblRecebimentoVariavel.Font = new Font("Arial Black", 9.75F, FontStyle.Bold);
            lblRecebimentoVariavel.ForeColor = Color.White;
            lblRecebimentoVariavel.Location = new Point(480, 354);
            lblRecebimentoVariavel.Name = "lblRecebimentoVariavel";
            lblRecebimentoVariavel.Size = new Size(160, 18);
            lblRecebimentoVariavel.TabIndex = 23;
            lblRecebimentoVariavel.Text = "Rendimento variavel:";
            lblRecebimentoVariavel.Click += label1_Click_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(663, 349);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(126, 23);
            textBox2.TabIndex = 24;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LionIcon__700_x_400_px_;
            pictureBox1.Location = new Point(480, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 177);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // TelaCadastroFinanceiro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 28, 28);
            ClientSize = new Size(844, 494);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(lblRecebimentoVariavel);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(lblRecebimentoFixo);
            Controls.Add(txtTransp);
            Controls.Add(lblTransp);
            Controls.Add(txtLazer);
            Controls.Add(txtCompra);
            Controls.Add(txtAluguel);
            Controls.Add(txtParc);
            Controls.Add(txtConta);
            Controls.Add(lblLazer);
            Controls.Add(lblCompras);
            Controls.Add(txtFinanc);
            Controls.Add(lblAluguel);
            Controls.Add(lblParcela);
            Controls.Add(lblContas);
            Controls.Add(lblFinan);
            Controls.Add(lblRec);
            Controls.Add(lblVari);
            Controls.Add(lblFixos);
            Controls.Add(lblControl);
            Name = "TelaCadastroFinanceiro";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblControl;
        private Label lblFixos;
        private Label lblVari;
        private Label lblRec;
        private Label lblFinan;
        private Label lblContas;
        private Label lblParcela;
        private Label lblAluguel;
        private TextBox txtFinanc;
        private Label lblCompras;
        private Label lblLazer;
        private TextBox txtConta;
        private TextBox txtParc;
        private TextBox txtAluguel;
        private TextBox txtCompra;
        private TextBox txtLazer;
        private Label lblTransp;
        private TextBox txtTransp;
        private Label lblRecebimentoFixo;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label lblRecebimentoVariavel;
        private TextBox textBox2;
        private PictureBox pictureBox1;
    }
}
