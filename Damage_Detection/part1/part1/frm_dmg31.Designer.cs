namespace part1
{
    partial class frm_dmg31
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_dmg31));
            this.pb_dmg_31 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dmg_31)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_dmg_31
            // 
            this.pb_dmg_31.Image = ((System.Drawing.Image)(resources.GetObject("pb_dmg_31.Image")));
            this.pb_dmg_31.Location = new System.Drawing.Point(0, -1);
            this.pb_dmg_31.Name = "pb_dmg_31";
            this.pb_dmg_31.Size = new System.Drawing.Size(831, 600);
            this.pb_dmg_31.TabIndex = 0;
            this.pb_dmg_31.TabStop = false;
            // 
            // frm_dmg31
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 604);
            this.Controls.Add(this.pb_dmg_31);
            this.Name = "frm_dmg31";
            this.Text = "Damage Information";
            this.Load += new System.EventHandler(this.frm_dmg31_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_dmg_31)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_dmg_31;
    }
}