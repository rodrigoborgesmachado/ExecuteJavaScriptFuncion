namespace ExecuteJavaScriptFuncion
{
    partial class NavegaVerbos
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
            this.btn_capturarConjugacao = new System.Windows.Forms.Button();
            this.gerarPessoa = new System.Windows.Forms.Button();
            this.btn_traducao = new System.Windows.Forms.Button();
            this.pan_webControl.SuspendLayout();
            this.pan_completo.SuspendLayout();
            this.panTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // webPrincipal
            // 
            this.webPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webPrincipal.Location = new System.Drawing.Point(0, 0);
            this.webPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.webPrincipal.MinimumSize = new System.Drawing.Size(27, 25);
            this.webPrincipal.Name = "webPrincipal";
            this.webPrincipal.Size = new System.Drawing.Size(708, 88);
            this.webPrincipal.TabIndex = 0;
            // 
            // pan_webControl
            // 
            this.pan_webControl.Controls.Add(this.webPrincipal);
            this.pan_webControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_webControl.Location = new System.Drawing.Point(0, 0);
            this.pan_webControl.Margin = new System.Windows.Forms.Padding(4);
            this.pan_webControl.Name = "pan_webControl";
            this.pan_webControl.Size = new System.Drawing.Size(708, 88);
            this.pan_webControl.TabIndex = 1;
            this.pan_webControl.Visible = false;
            // 
            // pan_completo
            // 
            this.pan_completo.Controls.Add(this.panTotal);
            this.pan_completo.Controls.Add(this.pan_webControl);
            this.pan_completo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_completo.Location = new System.Drawing.Point(0, 0);
            this.pan_completo.Margin = new System.Windows.Forms.Padding(4);
            this.pan_completo.Name = "pan_completo";
            this.pan_completo.Size = new System.Drawing.Size(708, 378);
            this.pan_completo.TabIndex = 2;
            // 
            // panTotal
            // 
            this.panTotal.Controls.Add(this.btn_traducao);
            this.panTotal.Controls.Add(this.btn_capturarConjugacao);
            this.panTotal.Controls.Add(this.gerarPessoa);
            this.panTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panTotal.Location = new System.Drawing.Point(0, 88);
            this.panTotal.Margin = new System.Windows.Forms.Padding(4);
            this.panTotal.Name = "panTotal";
            this.panTotal.Size = new System.Drawing.Size(708, 290);
            this.panTotal.TabIndex = 2;
            // 
            // btn_capturarConjugacao
            // 
            this.btn_capturarConjugacao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_capturarConjugacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_capturarConjugacao.Location = new System.Drawing.Point(17, 61);
            this.btn_capturarConjugacao.Margin = new System.Windows.Forms.Padding(4);
            this.btn_capturarConjugacao.Name = "btn_capturarConjugacao";
            this.btn_capturarConjugacao.Size = new System.Drawing.Size(156, 44);
            this.btn_capturarConjugacao.TabIndex = 1;
            this.btn_capturarConjugacao.Text = "Capturar Conjugacao";
            this.btn_capturarConjugacao.UseVisualStyleBackColor = false;
            this.btn_capturarConjugacao.Click += new System.EventHandler(this.btn_capturarConjugacao_Click);
            // 
            // gerarPessoa
            // 
            this.gerarPessoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gerarPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gerarPessoa.Location = new System.Drawing.Point(17, 9);
            this.gerarPessoa.Margin = new System.Windows.Forms.Padding(4);
            this.gerarPessoa.Name = "gerarPessoa";
            this.gerarPessoa.Size = new System.Drawing.Size(156, 44);
            this.gerarPessoa.TabIndex = 0;
            this.gerarPessoa.Text = "Capturar verbos";
            this.gerarPessoa.UseVisualStyleBackColor = false;
            this.gerarPessoa.Click += new System.EventHandler(this.buttonGerarPessoa_Click);
            // 
            // btn_traducao
            // 
            this.btn_traducao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_traducao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_traducao.Location = new System.Drawing.Point(17, 113);
            this.btn_traducao.Margin = new System.Windows.Forms.Padding(4);
            this.btn_traducao.Name = "btn_traducao";
            this.btn_traducao.Size = new System.Drawing.Size(156, 44);
            this.btn_traducao.TabIndex = 2;
            this.btn_traducao.Text = "Capturar Traducao";
            this.btn_traducao.UseVisualStyleBackColor = false;
            this.btn_traducao.Click += new System.EventHandler(this.btn_traducao_Click);
            // 
            // NavegaVerbos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(708, 378);
            this.Controls.Add(this.pan_completo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NavegaVerbos";
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
        private System.Windows.Forms.Button btn_capturarConjugacao;
        private System.Windows.Forms.Button btn_traducao;
    }
}

