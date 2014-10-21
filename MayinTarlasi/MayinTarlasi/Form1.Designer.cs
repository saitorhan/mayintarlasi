namespace MayinTarlasi
{
    partial class FormMayinTarlasi
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
            this.panelTarla = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelTarla
            // 
            this.panelTarla.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTarla.Location = new System.Drawing.Point(0, 57);
            this.panelTarla.Name = "panelTarla";
            this.panelTarla.Size = new System.Drawing.Size(584, 504);
            this.panelTarla.TabIndex = 0;
            // 
            // FormMayinTarlasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.panelTarla);
            this.Name = "FormMayinTarlasi";
            this.Text = "Mayın Tarlası";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTarla;
    }
}

