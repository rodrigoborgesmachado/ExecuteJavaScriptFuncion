namespace ExecuteJavaScriptFuncion
{
    partial class Prin
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
            this.webPrincipal = new System.Windows.Forms.WebBrowser();
            this.pan_webControl = new System.Windows.Forms.Panel();
            this.pan_completo = new System.Windows.Forms.Panel();
            this.panTotal = new System.Windows.Forms.Panel();
            this.btn_gerarVeiculo = new System.Windows.Forms.Button();
            this.btnGerarEmpresa = new System.Windows.Forms.Button();
            this.gerarPessoa = new System.Windows.Forms.Button();
            this.btn_gerar_conta_bancaria = new System.Windows.Forms.Button();
            this.btn_gerarCartaoCredito = new System.Windows.Forms.Button();
            this.pan_webControl.SuspendLayout();
            this.pan_completo.SuspendLayout();
            this.panTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // webPrincipal
            // 
            this.webPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webPrincipal.Location = new System.Drawing.Point(0, 0);
            this.webPrincipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.webPrincipal.MinimumSize = new System.Drawing.Size(27, 25);
            this.webPrincipal.Name = "webPrincipal";
            this.webPrincipal.Size = new System.Drawing.Size(708, 68);
            this.webPrincipal.TabIndex = 0;
            // 
            // pan_webControl
            // 
            this.pan_webControl.Controls.Add(this.webPrincipal);
            this.pan_webControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_webControl.Location = new System.Drawing.Point(0, 0);
            this.pan_webControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pan_webControl.Name = "pan_webControl";
            this.pan_webControl.Size = new System.Drawing.Size(708, 68);
            this.pan_webControl.TabIndex = 1;
            this.pan_webControl.Visible = false;
            // 
            // pan_completo
            // 
            this.pan_completo.Controls.Add(this.panTotal);
            this.pan_completo.Controls.Add(this.pan_webControl);
            this.pan_completo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_completo.Location = new System.Drawing.Point(0, 0);
            this.pan_completo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pan_completo.Name = "pan_completo";
            this.pan_completo.Size = new System.Drawing.Size(708, 378);
            this.pan_completo.TabIndex = 2;
            // 
            // panTotal
            // 
            this.panTotal.Controls.Add(this.btn_gerarCartaoCredito);
            this.panTotal.Controls.Add(this.btn_gerar_conta_bancaria);
            this.panTotal.Controls.Add(this.btn_gerarVeiculo);
            this.panTotal.Controls.Add(this.btnGerarEmpresa);
            this.panTotal.Controls.Add(this.gerarPessoa);
            this.panTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panTotal.Location = new System.Drawing.Point(0, 68);
            this.panTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panTotal.Name = "panTotal";
            this.panTotal.Size = new System.Drawing.Size(708, 310);
            this.panTotal.TabIndex = 2;
            // 
            // btn_gerarVeiculo
            // 
            this.btn_gerarVeiculo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_gerarVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_gerarVeiculo.Location = new System.Drawing.Point(16, 112);
            this.btn_gerarVeiculo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_gerarVeiculo.Name = "btn_gerarVeiculo";
            this.btn_gerarVeiculo.Size = new System.Drawing.Size(156, 44);
            this.btn_gerarVeiculo.TabIndex = 2;
            this.btn_gerarVeiculo.Text = "Gerar Veículo";
            this.btn_gerarVeiculo.UseVisualStyleBackColor = false;
            this.btn_gerarVeiculo.Click += new System.EventHandler(this.btn_gerarVeiculo_Click);
            // 
            // btnGerarEmpresa
            // 
            this.btnGerarEmpresa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGerarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerarEmpresa.Location = new System.Drawing.Point(17, 60);
            this.btnGerarEmpresa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGerarEmpresa.Name = "btnGerarEmpresa";
            this.btnGerarEmpresa.Size = new System.Drawing.Size(156, 44);
            this.btnGerarEmpresa.TabIndex = 1;
            this.btnGerarEmpresa.Text = "Gerar Empresa";
            this.btnGerarEmpresa.UseVisualStyleBackColor = false;
            this.btnGerarEmpresa.Click += new System.EventHandler(this.btnGerarEmpresa_Click);
            // 
            // gerarPessoa
            // 
            this.gerarPessoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gerarPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gerarPessoa.Location = new System.Drawing.Point(17, 9);
            this.gerarPessoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gerarPessoa.Name = "gerarPessoa";
            this.gerarPessoa.Size = new System.Drawing.Size(156, 44);
            this.gerarPessoa.TabIndex = 0;
            this.gerarPessoa.Text = "Gerar Pessoa";
            this.gerarPessoa.UseVisualStyleBackColor = false;
            this.gerarPessoa.Click += new System.EventHandler(this.buttonGerarPessoa_Click);
            // 
            // btn_gerar_conta_bancaria
            // 
            this.btn_gerar_conta_bancaria.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_gerar_conta_bancaria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_gerar_conta_bancaria.Location = new System.Drawing.Point(17, 164);
            this.btn_gerar_conta_bancaria.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gerar_conta_bancaria.Name = "btn_gerar_conta_bancaria";
            this.btn_gerar_conta_bancaria.Size = new System.Drawing.Size(156, 44);
            this.btn_gerar_conta_bancaria.TabIndex = 3;
            this.btn_gerar_conta_bancaria.Text = "Gerar Conta Bancária";
            this.btn_gerar_conta_bancaria.UseVisualStyleBackColor = false;
            this.btn_gerar_conta_bancaria.Click += new System.EventHandler(this.btn_gerar_conta_bancaria_Click);
            // 
            // btn_gerarCartaoCredito
            // 
            this.btn_gerarCartaoCredito.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_gerarCartaoCredito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_gerarCartaoCredito.Location = new System.Drawing.Point(17, 216);
            this.btn_gerarCartaoCredito.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gerarCartaoCredito.Name = "btn_gerarCartaoCredito";
            this.btn_gerarCartaoCredito.Size = new System.Drawing.Size(156, 44);
            this.btn_gerarCartaoCredito.TabIndex = 4;
            this.btn_gerarCartaoCredito.Text = "Gerar Cartão de Crédito";
            this.btn_gerarCartaoCredito.UseVisualStyleBackColor = false;
            this.btn_gerarCartaoCredito.Click += new System.EventHandler(this.btn_gerarCartaoCredito_Click);
            // 
            // Prin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(708, 378);
            this.Controls.Add(this.pan_completo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Prin";
            this.Text = "4Dev";
            this.pan_webControl.ResumeLayout(false);
            this.pan_completo.ResumeLayout(false);
            this.panTotal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webPrincipal;
        private System.Windows.Forms.Panel pan_webControl;
        private System.Windows.Forms.Panel pan_completo;
        private System.Windows.Forms.Panel panTotal;
        private System.Windows.Forms.Button gerarPessoa;
        private System.Windows.Forms.Button btnGerarEmpresa;
        private System.Windows.Forms.Button btn_gerarVeiculo;
        private System.Windows.Forms.Button btn_gerar_conta_bancaria;
        private System.Windows.Forms.Button btn_gerarCartaoCredito;
    }
}

