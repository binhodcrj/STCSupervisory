namespace AdvancedHMICS
{
    partial class MainForm
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
            this.QuickStartLabel = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // QuickStartLabel
            // 
            this.QuickStartLabel.AutoSize = true;
            this.QuickStartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.QuickStartLabel.ForeColor = System.Drawing.Color.White;
            this.QuickStartLabel.Location = new System.Drawing.Point(12, 8);
            this.QuickStartLabel.Name = "QuickStartLabel";
            this.QuickStartLabel.Size = new System.Drawing.Size(0, 13);
            this.QuickStartLabel.TabIndex = 44;
            this.QuickStartLabel.Visible = false;
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label1.Location = new System.Drawing.Point(12, 520);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(194, 32);
            this.Label1.TabIndex = 43;
            this.Label1.Text = "For Development Source Code Visit\r\nhttp://www.advancedhmi.com";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox1.BackgroundImage = global::AdvancedHMICS.Properties.Resources.AdvancedHMILogoBR;
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBox1.Location = new System.Drawing.Point(450, 11);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(322, 47);
            this.PictureBox1.TabIndex = 45;
            this.PictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.QuickStartLabel);
            this.Controls.Add(this.Label1);
            this.Name = "MainForm";
            this.Text = "AdvancedHMI V3.99w";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label QuickStartLabel;
        internal System.Windows.Forms.Label Label1;
    }
}

