namespace RentCar_Project
{
    partial class frm_CadastrarVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CadastrarVeiculo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.comboAr = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMotor = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboDirecao = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboRadio = new System.Windows.Forms.ComboBox();
            this.comboVidro = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboPortas = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboAtividade = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(12, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 242);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preencha as informações solicitadas para efetuar o cadastro do veículo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboAtividade);
            this.groupBox2.Controls.Add(this.comboPortas);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.comboVidro);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.comboRadio);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboDirecao);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtCambio);
            this.groupBox2.Controls.Add(this.comboAr);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtCor);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtAno);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtMotor);
            this.groupBox2.Controls.Add(this.txtModelo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMarca);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtPlaca);
            this.groupBox2.Location = new System.Drawing.Point(6, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(626, 195);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Veículo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Câmbio:";
            // 
            // txtCambio
            // 
            this.txtCambio.Location = new System.Drawing.Point(13, 102);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(136, 20);
            this.txtCambio.TabIndex = 71;
            // 
            // comboAr
            // 
            this.comboAr.FormattingEnabled = true;
            this.comboAr.Items.AddRange(new object[] {
            "SIM",
            "NÃO"});
            this.comboAr.Location = new System.Drawing.Point(367, 101);
            this.comboAr.Name = "comboAr";
            this.comboAr.Size = new System.Drawing.Size(67, 21);
            this.comboAr.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(367, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "Ar Condicionado:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(493, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Atividade:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Cor:";
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(13, 150);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(119, 20);
            this.txtCor.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(492, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Ano:";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(492, 52);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(62, 20);
            this.txtAno.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Motor:";
            // 
            // txtMotor
            // 
            this.txtMotor.Location = new System.Drawing.Point(173, 101);
            this.txtMotor.Name = "txtMotor";
            this.txtMotor.Size = new System.Drawing.Size(162, 20);
            this.txtMotor.TabIndex = 6;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(330, 52);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(133, 20);
            this.txtModelo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Modelo:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(173, 52);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(133, 20);
            this.txtMarca.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Marca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Placa:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(13, 52);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(138, 20);
            this.txtPlaca.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RentCar_Project.Properties.Resources.topo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(648, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // comboDirecao
            // 
            this.comboDirecao.FormattingEnabled = true;
            this.comboDirecao.Items.AddRange(new object[] {
            "SIM",
            "NÃO"});
            this.comboDirecao.Location = new System.Drawing.Point(492, 101);
            this.comboDirecao.Name = "comboDirecao";
            this.comboDirecao.Size = new System.Drawing.Size(62, 21);
            this.comboDirecao.TabIndex = 73;
            this.comboDirecao.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "Direção Hidráulica:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 76;
            this.label6.Text = "Rádio Embutido:";
            // 
            // comboRadio
            // 
            this.comboRadio.FormattingEnabled = true;
            this.comboRadio.Items.AddRange(new object[] {
            "SIM",
            "NÃO"});
            this.comboRadio.Location = new System.Drawing.Point(173, 151);
            this.comboRadio.Name = "comboRadio";
            this.comboRadio.Size = new System.Drawing.Size(67, 21);
            this.comboRadio.TabIndex = 75;
            // 
            // comboVidro
            // 
            this.comboVidro.FormattingEnabled = true;
            this.comboVidro.Items.AddRange(new object[] {
            "SIM",
            "NÃO"});
            this.comboVidro.Location = new System.Drawing.Point(288, 151);
            this.comboVidro.Name = "comboVidro";
            this.comboVidro.Size = new System.Drawing.Size(67, 21);
            this.comboVidro.TabIndex = 77;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(288, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 78;
            this.label13.Text = "Vidros Elétricos:";
            // 
            // comboPortas
            // 
            this.comboPortas.FormattingEnabled = true;
            this.comboPortas.Items.AddRange(new object[] {
            "2 Portas",
            "4 Portas"});
            this.comboPortas.Location = new System.Drawing.Point(396, 151);
            this.comboPortas.Name = "comboPortas";
            this.comboPortas.Size = new System.Drawing.Size(67, 21);
            this.comboPortas.TabIndex = 79;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(395, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 80;
            this.label14.Text = "Nº de Portas:";
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Image = global::RentCar_Project.Properties.Resources.test_copy_141299972284ngk;
            this.button4.Location = new System.Drawing.Point(211, 431);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 47);
            this.button4.TabIndex = 29;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Image = global::RentCar_Project.Properties.Resources.clear_icon_9211;
            this.button3.Location = new System.Drawing.Point(122, 431);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 47);
            this.button3.TabIndex = 28;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Image = global::RentCar_Project.Properties.Resources.salvar;
            this.button2.Location = new System.Drawing.Point(31, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 47);
            this.button2.TabIndex = 27;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboAtividade
            // 
            this.comboAtividade.FormattingEnabled = true;
            this.comboAtividade.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboAtividade.Location = new System.Drawing.Point(492, 151);
            this.comboAtividade.Name = "comboAtividade";
            this.comboAtividade.Size = new System.Drawing.Size(67, 21);
            this.comboAtividade.TabIndex = 81;
            this.comboAtividade.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // frm_CadastrarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RentCar_Project.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(675, 492);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_CadastrarVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Veículo";
            this.Load += new System.EventHandler(this.frm_CadastrarVeiculo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtCambio;
        public System.Windows.Forms.ComboBox comboAr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtMotor;
        public System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtPlaca;
        public System.Windows.Forms.ComboBox comboDirecao;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox comboAtividade;
        public System.Windows.Forms.ComboBox comboPortas;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.ComboBox comboVidro;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.ComboBox comboRadio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}