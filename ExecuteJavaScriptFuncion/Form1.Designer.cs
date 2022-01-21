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
            this.btnGerarEmpresa = new System.Windows.Forms.Button();
            this.gerarPessoa = new System.Windows.Forms.Button();
            this.btn_gerarVeiculo = new System.Windows.Forms.Button();
            this.pan_webControl.SuspendLayout();
            this.pan_completo.SuspendLayout();
            this.panTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // webPrincipal
            // 
            this.webPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webPrincipal.Location = new System.Drawing.Point(0, 0);
            this.webPrincipal.MinimumSize = new System.Drawing.Size(20, 20);
            this.webPrincipal.Name = "webPrincipal";
            this.webPrincipal.Size = new System.Drawing.Size(531, 55);
            this.webPrincipal.TabIndex = 0;
            // 
            // pan_webControl
            // 
            this.pan_webControl.Controls.Add(this.webPrincipal);
            this.pan_webControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_webControl.Location = new System.Drawing.Point(0, 0);
            this.pan_webControl.Name = "pan_webControl";
            this.pan_webControl.Size = new System.Drawing.Size(531, 55);
            this.pan_webControl.TabIndex = 1;
            this.pan_webControl.Visible = false;
            // 
            // pan_completo
            // 
            this.pan_completo.Controls.Add(this.panTotal);
            this.pan_completo.Controls.Add(this.pan_webControl);
            this.pan_completo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_completo.Location = new System.Drawing.Point(0, 0);
            this.pan_completo.Name = "pan_completo";
            this.pan_completo.Size = new System.Drawing.Size(531, 307);
            this.pan_completo.TabIndex = 2;
            // 
            // panTotal
            // 
            this.panTotal.Controls.Add(this.btn_gerarVeiculo);
            this.panTotal.Controls.Add(this.btnGerarEmpresa);
            this.panTotal.Controls.Add(this.gerarPessoa);
            this.panTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panTotal.Location = new System.Drawing.Point(0, 55);
            this.panTotal.Name = "panTotal";
            this.panTotal.Size = new System.Drawing.Size(531, 252);
            this.panTotal.TabIndex = 2;
            // 
            // btnGerarEmpresa
            // 
            this.btnGerarEmpresa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGerarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerarEmpresa.Location = new System.Drawing.Point(13, 49);
            this.btnGerarEmpresa.Name = "btnGerarEmpresa";
            this.btnGerarEmpresa.Size = new System.Drawing.Size(117, 36);
            this.btnGerarEmpresa.TabIndex = 1;
            this.btnGerarEmpresa.Text = "Gerar Empresa";
            this.btnGerarEmpresa.UseVisualStyleBackColor = false;
            this.btnGerarEmpresa.Click += new System.EventHandler(this.btnGerarEmpresa_Click);
            // 
            // gerarPessoa
            // 
            this.gerarPessoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gerarPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gerarPessoa.Location = new System.Drawing.Point(13, 7);
            this.gerarPessoa.Name = "gerarPessoa";
            this.gerarPessoa.Size = new System.Drawing.Size(117, 36);
            this.gerarPessoa.TabIndex = 0;
            this.gerarPessoa.Text = "Gerar Pessoa";
            this.gerarPessoa.UseVisualStyleBackColor = false;
            this.gerarPessoa.Click += new System.EventHandler(this.buttonGerarPessoa_Click);
            // 
            // btn_gerarVeiculo
            // 
            this.btn_gerarVeiculo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_gerarVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_gerarVeiculo.Location = new System.Drawing.Point(12, 91);
            this.btn_gerarVeiculo.Name = "btn_gerarVeiculo";
            this.btn_gerarVeiculo.Size = new System.Drawing.Size(117, 36);
            this.btn_gerarVeiculo.TabIndex = 2;
            this.btn_gerarVeiculo.Text = "Gerar Veículo";
            this.btn_gerarVeiculo.UseVisualStyleBackColor = false;
            this.btn_gerarVeiculo.Click += new System.EventHandler(this.btn_gerarVeiculo_Click);
            // 
            // Prin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(531, 307);
            this.Controls.Add(this.pan_completo);
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
    }
}

