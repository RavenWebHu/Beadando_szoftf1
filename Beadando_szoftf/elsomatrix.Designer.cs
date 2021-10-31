
namespace Beadando_szoftf
{
    partial class Elsomatrix
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
            this.elsobox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // elsobox
            // 
            this.elsobox.Location = new System.Drawing.Point(12, 12);
            this.elsobox.Name = "elsobox";
            this.elsobox.Size = new System.Drawing.Size(410, 237);
            this.elsobox.TabIndex = 0;
            this.elsobox.Text = "";
            // 
            // Elsomatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.elsobox);
            this.Name = "Elsomatrix";
            this.Text = "elsomatrix";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox elsobox;
    }
}