namespace AutoFiler
{
    partial class InvalidDirectory
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
            this.Okay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(44, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "The starting directory does not exist.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Okay
            // 
            this.Okay.Location = new System.Drawing.Point(100, 95);
            this.Okay.Name = "Okay";
            this.Okay.Size = new System.Drawing.Size(189, 24);
            this.Okay.TabIndex = 1;
            this.Okay.Text = "ok";
            this.Okay.UseVisualStyleBackColor = true;
            this.Okay.Click += new System.EventHandler(this.Okay_Click);
            // 
            // InvalidDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 158);
            this.Controls.Add(this.Okay);
            this.Controls.Add(this.label1);
            this.Name = "InvalidDirectory";
            this.Text = "Invalid Directory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Okay;
    }
}