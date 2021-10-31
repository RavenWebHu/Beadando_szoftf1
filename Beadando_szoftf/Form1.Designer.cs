
namespace Beadando_szoftf
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.szambevitel = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.skalarbox = new System.Windows.Forms.TextBox();
            this.atloooszeg = new System.Windows.Forms.Label();
            this.atlook = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adjon meg egy számot 5, és 15 között";
            // 
            // szambevitel
            // 
            this.szambevitel.Location = new System.Drawing.Point(79, 25);
            this.szambevitel.Name = "szambevitel";
            this.szambevitel.Size = new System.Drawing.Size(100, 20);
            this.szambevitel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Mehet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Bevitel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "A két mátrix skaláris sorazata:";
            // 
            // skalarbox
            // 
            this.skalarbox.Location = new System.Drawing.Point(79, 93);
            this.skalarbox.Name = "skalarbox";
            this.skalarbox.Size = new System.Drawing.Size(100, 20);
            this.skalarbox.TabIndex = 4;
            // 
            // atloooszeg
            // 
            this.atloooszeg.AutoSize = true;
            this.atloooszeg.Location = new System.Drawing.Point(36, 116);
            this.atloooszeg.Name = "atloooszeg";
            this.atloooszeg.Size = new System.Drawing.Size(200, 13);
            this.atloooszeg.TabIndex = 5;
            this.atloooszeg.Text = "A két mátrix átlóösszegének különbsége:";
            // 
            // atlook
            // 
            this.atlook.Location = new System.Drawing.Point(79, 132);
            this.atlook.Name = "atlook";
            this.atlook.Size = new System.Drawing.Size(100, 20);
            this.atlook.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Az első mátrix két átlója feletti számok összege";
            // 
            // kao
            // 
            this.kao.Location = new System.Drawing.Point(79, 172);
            this.kao.Name = "kao";
            this.kao.Size = new System.Drawing.Size(100, 20);
            this.kao.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 204);
            this.Controls.Add(this.kao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.atlook);
            this.Controls.Add(this.atloooszeg);
            this.Controls.Add(this.skalarbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.szambevitel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox szambevitel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox skalarbox;
        private System.Windows.Forms.Label atloooszeg;
        private System.Windows.Forms.TextBox atlook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kao;
    }

   

}

