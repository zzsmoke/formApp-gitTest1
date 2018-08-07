namespace winforapp1_github
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
            this.B_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_btn
            // 
            this.B_btn.Location = new System.Drawing.Point(326, 166);
            this.B_btn.Name = "B_btn";
            this.B_btn.Size = new System.Drawing.Size(75, 23);
            this.B_btn.TabIndex = 0;
            this.B_btn.Text = "Boton";
            this.B_btn.UseVisualStyleBackColor = true;
            this.B_btn.Click += new System.EventHandler(this.B_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 368);
            this.Controls.Add(this.B_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_btn;
    }
}

