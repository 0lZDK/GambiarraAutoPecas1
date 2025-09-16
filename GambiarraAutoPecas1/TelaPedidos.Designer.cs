namespace GambiarraAutoPecas1
{
    partial class TelaPedidos
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
            this.dtgBuscaCli = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbBuscarPeca = new System.Windows.Forms.TextBox();
            this.btnBuscarPeca = new System.Windows.Forms.Button();
            this.dtgBuscaPecas = new System.Windows.Forms.DataGridView();
            this.grbCliente = new System.Windows.Forms.GroupBox();
            this.txbBuscarCLi = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnPedir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.tbxQuantidadePed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.dtgPedidos = new System.Windows.Forms.DataGridView();
            this.btnAlterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscaCli)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscaPecas)).BeginInit();
            this.grbCliente.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgBuscaCli
            // 
            this.dtgBuscaCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBuscaCli.Location = new System.Drawing.Point(17, 60);
            this.dtgBuscaCli.Name = "dtgBuscaCli";
            this.dtgBuscaCli.ReadOnly = true;
            this.dtgBuscaCli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgBuscaCli.Size = new System.Drawing.Size(480, 317);
            this.dtgBuscaCli.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1176, 573);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.grbCliente);
            this.tabPage1.Controls.Add(this.btnPedir);
            this.tabPage1.Controls.Add(this.btnSair);
            this.tabPage1.Controls.Add(this.tbxQuantidadePed);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1168, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro Pedidos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbBuscarPeca);
            this.groupBox1.Controls.Add(this.btnBuscarPeca);
            this.groupBox1.Controls.Add(this.dtgBuscaPecas);
            this.groupBox1.Location = new System.Drawing.Point(592, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 392);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peças do Estoque";
            // 
            // txbBuscarPeca
            // 
            this.txbBuscarPeca.Location = new System.Drawing.Point(214, 23);
            this.txbBuscarPeca.Name = "txbBuscarPeca";
            this.txbBuscarPeca.Size = new System.Drawing.Size(206, 20);
            this.txbBuscarPeca.TabIndex = 4;
            // 
            // btnBuscarPeca
            // 
            this.btnBuscarPeca.Location = new System.Drawing.Point(426, 21);
            this.btnBuscarPeca.Name = "btnBuscarPeca";
            this.btnBuscarPeca.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPeca.TabIndex = 3;
            this.btnBuscarPeca.Text = "Buscar";
            this.btnBuscarPeca.UseVisualStyleBackColor = true;
            // 
            // dtgBuscaPecas
            // 
            this.dtgBuscaPecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBuscaPecas.Location = new System.Drawing.Point(17, 60);
            this.dtgBuscaPecas.Name = "dtgBuscaPecas";
            this.dtgBuscaPecas.ReadOnly = true;
            this.dtgBuscaPecas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgBuscaPecas.Size = new System.Drawing.Size(480, 317);
            this.dtgBuscaPecas.TabIndex = 0;
            // 
            // grbCliente
            // 
            this.grbCliente.Controls.Add(this.txbBuscarCLi);
            this.grbCliente.Controls.Add(this.btnBuscar);
            this.grbCliente.Controls.Add(this.dtgBuscaCli);
            this.grbCliente.Location = new System.Drawing.Point(29, 34);
            this.grbCliente.Name = "grbCliente";
            this.grbCliente.Size = new System.Drawing.Size(516, 392);
            this.grbCliente.TabIndex = 7;
            this.grbCliente.TabStop = false;
            this.grbCliente.Text = "Clientes";
            // 
            // txbBuscarCLi
            // 
            this.txbBuscarCLi.Location = new System.Drawing.Point(205, 22);
            this.txbBuscarCLi.Name = "txbBuscarCLi";
            this.txbBuscarCLi.Size = new System.Drawing.Size(206, 20);
            this.txbBuscarCLi.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(417, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnPedir
            // 
            this.btnPedir.Location = new System.Drawing.Point(492, 514);
            this.btnPedir.Name = "btnPedir";
            this.btnPedir.Size = new System.Drawing.Size(75, 23);
            this.btnPedir.TabIndex = 6;
            this.btnPedir.Text = "Pedir";
            this.btnPedir.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(1085, 518);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxQuantidadePed
            // 
            this.tbxQuantidadePed.Location = new System.Drawing.Point(95, 518);
            this.tbxQuantidadePed.Name = "tbxQuantidadePed";
            this.tbxQuantidadePed.Size = new System.Drawing.Size(391, 20);
            this.tbxQuantidadePed.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quantidade :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAlterar);
            this.tabPage2.Controls.Add(this.btnDeletar);
            this.tabPage2.Controls.Add(this.dtgPedidos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1168, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pedidos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(970, 344);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 1;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // dtgPedidos
            // 
            this.dtgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPedidos.Location = new System.Drawing.Point(7, 4);
            this.dtgPedidos.Name = "dtgPedidos";
            this.dtgPedidos.Size = new System.Drawing.Size(1043, 334);
            this.dtgPedidos.TabIndex = 0;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(7, 345);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // TelaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 578);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscaCli)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscaPecas)).EndInit();
            this.grbCliente.ResumeLayout(false);
            this.grbCliente.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgBuscaCli;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbxQuantidadePed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPedir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.DataGridView dtgPedidos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgBuscaPecas;
        private System.Windows.Forms.GroupBox grbCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txbBuscarPeca;
        private System.Windows.Forms.Button btnBuscarPeca;
        private System.Windows.Forms.TextBox txbBuscarCLi;
        private System.Windows.Forms.Button btnAlterar;
    }
}