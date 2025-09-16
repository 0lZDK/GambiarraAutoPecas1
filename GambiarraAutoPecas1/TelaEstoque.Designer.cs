namespace GambiarraAutoPecas1
{
    partial class TelaEstoque
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.cbFabricante = new System.Windows.Forms.ComboBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.cbMontadora = new System.Windows.Forms.ComboBox();
            this.txbModelo = new System.Windows.Forms.TextBox();
            this.txbMarca = new System.Windows.Forms.TextBox();
            this.txbPeca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtgEstoque = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.txbBuscarPeca = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-4, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(765, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txbQuantidade);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.cbFabricante);
            this.tabPage1.Controls.Add(this.btnGravar);
            this.tabPage1.Controls.Add(this.cbMontadora);
            this.tabPage1.Controls.Add(this.txbModelo);
            this.tabPage1.Controls.Add(this.txbMarca);
            this.tabPage1.Controls.Add(this.txbPeca);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(757, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro de Peças";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(491, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbFabricante
            // 
            this.cbFabricante.FormattingEnabled = true;
            this.cbFabricante.Items.AddRange(new object[] {
            "Genuina/Original",
            "Paralela"});
            this.cbFabricante.Location = new System.Drawing.Point(107, 215);
            this.cbFabricante.Name = "cbFabricante";
            this.cbFabricante.Size = new System.Drawing.Size(423, 21);
            this.cbFabricante.TabIndex = 13;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(24, 298);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(60, 23);
            this.btnGravar.TabIndex = 12;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // cbMontadora
            // 
            this.cbMontadora.FormattingEnabled = true;
            this.cbMontadora.Items.AddRange(new object[] {
            "Agrale",
            "Puma",
            "Mascarello",
            "Marcopolo",
            "Neobus",
            "TAC",
            "Chamonix",
            "Volkswagen",
            "Mercedes-Benz",
            "Toyota",
            "Fiat",
            "Jeep",
            "Peugeot",
            "Citroën",
            "Honda",
            "General Motors (Chevrolet)",
            "Hyundai",
            "Ford",
            "Renault",
            "Nissan",
            "Mitsubishi",
            "Audi",
            "BMW",
            "CAOA Chery",
            "Great Wall",
            "Suzuki",
            "Volvo",
            "Scania",
            "Iveco",
            "DAF",
            "MAN",
            "BYD",
            "GWM",
            "Chery",
            "JAC Motors",
            "Kia",
            "Land Rover",
            "Lexus",
            "Lifan",
            "Mercedes-AMG",
            "Mini",
            "Porsche",
            "Ram",
            "Subaru",
            "SsangYong",
            "Troller"});
            this.cbMontadora.Location = new System.Drawing.Point(107, 175);
            this.cbMontadora.Name = "cbMontadora";
            this.cbMontadora.Size = new System.Drawing.Size(423, 21);
            this.cbMontadora.TabIndex = 11;
            this.cbMontadora.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txbModelo
            // 
            this.txbModelo.BackColor = System.Drawing.Color.White;
            this.txbModelo.Location = new System.Drawing.Point(107, 133);
            this.txbModelo.Name = "txbModelo";
            this.txbModelo.Size = new System.Drawing.Size(423, 20);
            this.txbModelo.TabIndex = 10;
            // 
            // txbMarca
            // 
            this.txbMarca.BackColor = System.Drawing.Color.White;
            this.txbMarca.Location = new System.Drawing.Point(107, 89);
            this.txbMarca.Name = "txbMarca";
            this.txbMarca.Size = new System.Drawing.Size(423, 20);
            this.txbMarca.TabIndex = 9;
            // 
            // txbPeca
            // 
            this.txbPeca.BackColor = System.Drawing.Color.White;
            this.txbPeca.Location = new System.Drawing.Point(107, 53);
            this.txbPeca.Name = "txbPeca";
            this.txbPeca.Size = new System.Drawing.Size(423, 20);
            this.txbPeca.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(24, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Modelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(24, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fabricante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(24, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Montadora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(24, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Peça";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = " Cadastro de Peças Entrada";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSair);
            this.tabPage2.Controls.Add(this.txbBuscarPeca);
            this.tabPage2.Controls.Add(this.btnBusca);
            this.tabPage2.Controls.Add(this.dtgEstoque);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(757, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Estoque";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtgEstoque
            // 
            this.dtgEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEstoque.Location = new System.Drawing.Point(6, 6);
            this.dtgEstoque.Name = "dtgEstoque";
            this.dtgEstoque.ReadOnly = true;
            this.dtgEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEstoque.Size = new System.Drawing.Size(745, 279);
            this.dtgEstoque.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(24, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Quantidade";
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.BackColor = System.Drawing.Color.White;
            this.txbQuantidade.Location = new System.Drawing.Point(107, 256);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(63, 20);
            this.txbQuantidade.TabIndex = 16;
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(12, 302);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(75, 23);
            this.btnBusca.TabIndex = 1;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // txbBuscarPeca
            // 
            this.txbBuscarPeca.Location = new System.Drawing.Point(94, 304);
            this.txbBuscarPeca.Name = "txbBuscarPeca";
            this.txbBuscarPeca.Size = new System.Drawing.Size(192, 20);
            this.txbBuscarPeca.TabIndex = 2;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(676, 304);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // TelaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(758, 460);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaEstoque";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbModelo;
        private System.Windows.Forms.TextBox txbMarca;
        private System.Windows.Forms.TextBox txbPeca;
        private System.Windows.Forms.ComboBox cbMontadora;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.ComboBox cbFabricante;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgEstoque;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbBuscarPeca;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Button btnSair;
    }
}