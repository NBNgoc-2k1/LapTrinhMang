
namespace LAB4
{
    partial class BAI3
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
            this.Urltext = new System.Windows.Forms.TextBox();
            this.Pathtext = new System.Windows.Forms.TextBox();
            this.Downloadbutton = new System.Windows.Forms.Button();
            this.Browsebutton = new System.Windows.Forms.Button();
            this.Showtext = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Urltext
            // 
            this.Urltext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Urltext.Location = new System.Drawing.Point(12, 22);
            this.Urltext.Name = "Urltext";
            this.Urltext.Size = new System.Drawing.Size(633, 30);
            this.Urltext.TabIndex = 0;
            // 
            // Pathtext
            // 
            this.Pathtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pathtext.Location = new System.Drawing.Point(12, 69);
            this.Pathtext.Name = "Pathtext";
            this.Pathtext.Size = new System.Drawing.Size(633, 30);
            this.Pathtext.TabIndex = 1;
            // 
            // Downloadbutton
            // 
            this.Downloadbutton.Location = new System.Drawing.Point(661, 22);
            this.Downloadbutton.Name = "Downloadbutton";
            this.Downloadbutton.Size = new System.Drawing.Size(118, 30);
            this.Downloadbutton.TabIndex = 2;
            this.Downloadbutton.Text = "Download";
            this.Downloadbutton.UseVisualStyleBackColor = true;
            this.Downloadbutton.Click += new System.EventHandler(this.Downloadbutton_Click);
            // 
            // Browsebutton
            // 
            this.Browsebutton.Location = new System.Drawing.Point(661, 69);
            this.Browsebutton.Name = "Browsebutton";
            this.Browsebutton.Size = new System.Drawing.Size(118, 30);
            this.Browsebutton.TabIndex = 3;
            this.Browsebutton.Text = "Browse";
            this.Browsebutton.UseVisualStyleBackColor = true;
            this.Browsebutton.Click += new System.EventHandler(this.Browsebutton_Click);
            // 
            // Showtext
            // 
            this.Showtext.Location = new System.Drawing.Point(12, 116);
            this.Showtext.Name = "Showtext";
            this.Showtext.ReadOnly = true;
            this.Showtext.Size = new System.Drawing.Size(767, 325);
            this.Showtext.TabIndex = 4;
            this.Showtext.Text = "";
            // 
            // BAI3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Showtext);
            this.Controls.Add(this.Browsebutton);
            this.Controls.Add(this.Downloadbutton);
            this.Controls.Add(this.Pathtext);
            this.Controls.Add(this.Urltext);
            this.Name = "BAI3";
            this.Text = "BAI3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Urltext;
        private System.Windows.Forms.TextBox Pathtext;
        private System.Windows.Forms.Button Downloadbutton;
        private System.Windows.Forms.Button Browsebutton;
        private System.Windows.Forms.RichTextBox Showtext;
    }
}