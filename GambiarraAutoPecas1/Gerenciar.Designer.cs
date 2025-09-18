namespace GambiarraAutoPecas1
{
    partial class Gerenciar
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
            this.grpAltera = new System.Windows.Forms.GroupBox();
            this.txbAlteraBuscarPeca = new System.Windows.Forms.TextBox();
            this.btnBuscarPeca = new System.Windows.Forms.Button();
            this.dtgAlteraBuscaPecas = new System.Windows.Forms.DataGridView();
            this.grbAlteraCliente = new System.Windows.Forms.GroupBox();
            this.txbAlteraBuscarCLi = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.dtgAlteraBuscaCli = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAlteraCliente = new System.Windows.Forms.Button();
            this.btnAlteraPecas = new System.Windows.Forms.Button();
            this.grpAltera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlteraBuscaPecas)).BeginInit();
            this.grbAlteraCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlteraBuscaCli)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAltera
            // 
            this.grpAltera.Controls.Add(this.txbAlteraBuscarPeca);
            this.grpAltera.Controls.Add(this.btnBuscarPeca);
            this.grpAltera.Controls.Add(this.dtgAlteraBuscaPecas);
            this.grpAltera.Location = new System.Drawing.Point(575, 45);
            this.grpAltera.Name = "grpAltera";
            this.grpAltera.Size = new System.Drawing.Size(516, 392);
            this.grpAltera.TabIndex = 10;
            this.grpAltera.TabStop = false;
            this.grpAltera.Text = "Peças do Estoque";
            // 
            // txbAlteraBuscarPeca
            // 
            this.txbAlteraBuscarPeca.Location = new System.Drawing.Point(214, 23);
            this.txbAlteraBuscarPeca.Name = "txbAlteraBuscarPeca";
            this.txbAlteraBuscarPeca.Size = new System.Drawing.Size(206, 20);
            this.txbAlteraBuscarPeca.TabIndex = 4;
            // 
            // btnBuscarPeca
            // 
            this.btnBuscarPeca.Location = new System.Drawing.Point(426, 21);
            this.btnBuscarPeca.Name = "btnBuscarPeca";
            this.btnBuscarPeca.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPeca.TabIndex = 3;
            this.btnBuscarPeca.Text = "Buscar";
            this.btnBuscarPeca.UseVisualStyleBackColor = true;
            this.btnBuscarPeca.Click += new System.EventHandler(this.btnBuscarPeca_Click);
            // 
            // dtgAlteraBuscaPecas
            // 
            this.dtgAlteraBuscaPecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAlteraBuscaPecas.Location = new System.Drawing.Point(17, 60);
            this.dtgAlteraBuscaPecas.Name = "dtgAlteraBuscaPecas";
            this.dtgAlteraBuscaPecas.ReadOnly = true;
            this.dtgAlteraBuscaPecas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAlteraBuscaPecas.Size = new System.Drawing.Size(480, 317);
            this.dtgAlteraBuscaPecas.TabIndex = 0;
            // 
            // grbAlteraCliente
            // 
            this.grbAlteraCliente.Controls.Add(this.txbAlteraBuscarCLi);
            this.grbAlteraCliente.Controls.Add(this.btnBuscarCliente);
            this.grbAlteraCliente.Controls.Add(this.dtgAlteraBuscaCli);
            this.grbAlteraCliente.Location = new System.Drawing.Point(12, 45);
            this.grbAlteraCliente.Name = "grbAlteraCliente";
            this.grbAlteraCliente.Size = new System.Drawing.Size(516, 392);
            this.grbAlteraCliente.TabIndex = 9;
            this.grbAlteraCliente.TabStop = false;
            this.grbAlteraCliente.Text = "Clientes";
            // 
            // txbAlteraBuscarCLi
            // 
            this.txbAlteraBuscarCLi.Location = new System.Drawing.Point(205, 22);
            this.txbAlteraBuscarCLi.Name = "txbAlteraBuscarCLi";
            this.txbAlteraBuscarCLi.Size = new System.Drawing.Size(206, 20);
            this.txbAlteraBuscarCLi.TabIndex = 2;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(417, 20);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCliente.TabIndex = 1;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // dtgAlteraBuscaCli
            // 
            this.dtgAlteraBuscaCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAlteraBuscaCli.Location = new System.Drawing.Point(17, 60);
            this.dtgAlteraBuscaCli.Name = "dtgAlteraBuscaCli";
            this.dtgAlteraBuscaCli.ReadOnly = true;
            this.dtgAlteraBuscaCli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAlteraBuscaCli.Size = new System.Drawing.Size(480, 317);
            this.dtgAlteraBuscaCli.TabIndex = 0;
            this.dtgAlteraBuscaCli.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAlteraBuscaCli_CellContentClick);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(1016, 443);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAlteraCliente
            // 
            this.btnAlteraCliente.Location = new System.Drawing.Point(29, 444);
            this.btnAlteraCliente.Name = "btnAlteraCliente";
            this.btnAlteraCliente.Size = new System.Drawing.Size(75, 23);
            this.btnAlteraCliente.TabIndex = 12;
            this.btnAlteraCliente.Text = "Altera";
            this.btnAlteraCliente.UseVisualStyleBackColor = true;
            this.btnAlteraCliente.Click += new System.EventHandler(this.btnAlteraCliente_Click);
            // 
            // btnAlteraPecas
            // 
            this.btnAlteraPecas.Location = new System.Drawing.Point(575, 443);
            this.btnAlteraPecas.Name = "btnAlteraPecas";
            this.btnAlteraPecas.Size = new System.Drawing.Size(75, 23);
            this.btnAlteraPecas.TabIndex = 13;
            this.btnAlteraPecas.Text = "Altera";
            this.btnAlteraPecas.UseVisualStyleBackColor = true;
            this.btnAlteraPecas.Click += new System.EventHandler(this.btnAlteraPecas_Click);
            // 
            // Gerenciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 495);
            this.Controls.Add(this.btnAlteraPecas);
            this.Controls.Add(this.btnAlteraCliente);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.grpAltera);
            this.Controls.Add(this.grbAlteraCliente);
            this.Name = "Gerenciar";
            this.Text = "Gerenciar";
            this.grpAltera.ResumeLayout(false);
            this.grpAltera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlteraBuscaPecas)).EndInit();
            this.grbAlteraCliente.ResumeLayout(false);
            this.grbAlteraCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlteraBuscaCli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAltera;
        private System.Windows.Forms.TextBox txbAlteraBuscarPeca;
        private System.Windows.Forms.Button btnBuscarPeca;
        private System.Windows.Forms.DataGridView dtgAlteraBuscaPecas;
        private System.Windows.Forms.GroupBox grbAlteraCliente;
        private System.Windows.Forms.TextBox txbAlteraBuscarCLi;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.DataGridView dtgAlteraBuscaCli;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAlteraCliente;
        private System.Windows.Forms.Button btnAlteraPecas;
    }
}