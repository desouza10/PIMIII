namespace RentCar_Project
{
    partial class MotoristasPJ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MotoristasPJ));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNome_Aut = new System.Windows.Forms.TextBox();
            this.txtCNH_Aut = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCNPJ_Aut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listCNH = new System.Windows.Forms.ListBox();
            this.listNome = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RentCar_Project.Properties.Resources.topo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(722, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtNome_Aut
            // 
            this.txtNome_Aut.Location = new System.Drawing.Point(9, 40);
            this.txtNome_Aut.Name = "txtNome_Aut";
            this.txtNome_Aut.Size = new System.Drawing.Size(193, 20);
            this.txtNome_Aut.TabIndex = 5;
            // 
            // txtCNH_Aut
            // 
            this.txtCNH_Aut.Location = new System.Drawing.Point(230, 40);
            this.txtCNH_Aut.Name = "txtCNH_Aut";
            this.txtCNH_Aut.Size = new System.Drawing.Size(181, 20);
            this.txtCNH_Aut.TabIndex = 6;
            this.txtCNH_Aut.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCNPJ_Aut);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNome_Aut);
            this.groupBox1.Controls.Add(this.txtCNH_Aut);
            this.groupBox1.Location = new System.Drawing.Point(13, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 83);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insira as informações dos Motoristas Autorizados pela Empresa:";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(646, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 46);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "CNPJ:";
            // 
            // txtCNPJ_Aut
            // 
            this.txtCNPJ_Aut.Enabled = false;
            this.txtCNPJ_Aut.Location = new System.Drawing.Point(442, 40);
            this.txtCNPJ_Aut.Name = "txtCNPJ_Aut";
            this.txtCNPJ_Aut.Size = new System.Drawing.Size(181, 20);
            this.txtCNPJ_Aut.TabIndex = 9;
            this.txtCNPJ_Aut.TextChanged += new System.EventHandler(this.CNPJ_Aut_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "CNH:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome Completo:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.listCNH);
            this.groupBox2.Controls.Add(this.listNome);
            this.groupBox2.Location = new System.Drawing.Point(13, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 204);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Motoristas Autorizados Cadastrados:";
            // 
            // listCNH
            // 
            this.listCNH.FormattingEnabled = true;
            this.listCNH.Location = new System.Drawing.Point(345, 27);
            this.listCNH.Name = "listCNH";
            this.listCNH.Size = new System.Drawing.Size(181, 160);
            this.listCNH.TabIndex = 11;
            // 
            // listNome
            // 
            this.listNome.FormattingEnabled = true;
            this.listNome.Location = new System.Drawing.Point(9, 27);
            this.listNome.Name = "listNome";
            this.listNome.Size = new System.Drawing.Size(312, 160);
            this.listNome.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Image = global::RentCar_Project.Properties.Resources.test_copy_141299972284ngk;
            this.button4.Location = new System.Drawing.Point(125, 469);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 47);
            this.button4.TabIndex = 24;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Image = global::RentCar_Project.Properties.Resources.clear_icon_9211;
            this.button3.Location = new System.Drawing.Point(36, 469);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 47);
            this.button3.TabIndex = 23;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(618, 307);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(59, 46);
            this.button5.TabIndex = 25;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(562, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Pesquisar Condutores Cadastrados";
            // 
            // MotoristasPJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RentCar_Project.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(742, 538);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MotoristasPJ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motoristas Autorizados";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNome_Aut;
        private System.Windows.Forms.TextBox txtCNH_Aut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listCNH;
        private System.Windows.Forms.ListBox listNome;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox txtCNPJ_Aut;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
    }
}