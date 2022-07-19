
namespace ExecuteJavaScriptFuncion
{
    partial class DoTerra
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
            this.pan_webControl.SuspendLayout();
            this.pan_completo.SuspendLayout();
            this.SuspendLayout();
            // 
            // webPrincipal
            // 
            this.webPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webPrincipal.Location = new System.Drawing.Point(0, 0);
            this.webPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.webPrincipal.MinimumSize = new System.Drawing.Size(27, 25);
            this.webPrincipal.Name = "webPrincipal";
            this.webPrincipal.Size = new System.Drawing.Size(800, 450);
            this.webPrincipal.TabIndex = 0;
            // 
            // pan_webControl
            // 
            this.pan_webControl.Controls.Add(this.webPrincipal);
            this.pan_webControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_webControl.Location = new System.Drawing.Point(0, 0);
            this.pan_webControl.Margin = new System.Windows.Forms.Padding(4);
            this.pan_webControl.Name = "pan_webControl";
            this.pan_webControl.Size = new System.Drawing.Size(800, 450);
            this.pan_webControl.TabIndex = 1;
            this.pan_webControl.Visible = false;
            // 
            // pan_completo
            // 
            this.pan_completo.Controls.Add(this.pan_webControl);
            this.pan_completo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_completo.Location = new System.Drawing.Point(0, 0);
            this.pan_completo.Margin = new System.Windows.Forms.Padding(4);
            this.pan_completo.Name = "pan_completo";
            this.pan_completo.Size = new System.Drawing.Size(800, 450);
            this.pan_completo.TabIndex = 3;
            // 
            // DoTerra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pan_completo);
            this.Name = "DoTerra";
            this.Text = "DoTerra";
            this.pan_webControl.ResumeLayout(false);
            this.pan_completo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.WebBrowser webPrincipal;
        private System.Windows.Forms.Panel pan_webControl;
        private System.Windows.Forms.Panel pan_completo;
    }
}