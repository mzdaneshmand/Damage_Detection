namespace part1
{
    partial class frm_pic_max11
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
            this.pb_max_11 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_max_11)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_max_11
            // 
            this.pb_max_11.Location = new System.Drawing.Point(0, 2);
            this.pb_max_11.Name = "pb_max_11";
            this.pb_max_11.Size = new System.Drawing.Size(868, 691);
            this.pb_max_11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_max_11.TabIndex = 0;
            this.pb_max_11.TabStop = false;
            this.pb_max_11.Click += new System.EventHandler(this.pb_max_11_Click);
            // 
            // frm_pic_max11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 692);
            this.Controls.Add(this.pb_max_11);
            this.Name = "frm_pic_max11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image maximised";
            ((System.ComponentModel.ISupportInitialize)(this.pb_max_11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_max_11;
    }
}