namespace part1
{
    partial class frm_page2_plt
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
            this.tb_license_up = new System.Windows.Forms.TextBox();
            this.btn_license_up = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_license_up
            // 
            this.tb_license_up.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_license_up.Location = new System.Drawing.Point(21, 32);
            this.tb_license_up.Name = "tb_license_up";
            this.tb_license_up.Size = new System.Drawing.Size(140, 32);
            this.tb_license_up.TabIndex = 0;
            this.tb_license_up.Text = "001 SHB";
            this.tb_license_up.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_license_up.TextChanged += new System.EventHandler(this.tb_license_up_TextChanged);
            // 
            // btn_license_up
            // 
            this.btn_license_up.BackColor = System.Drawing.Color.Black;
            this.btn_license_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_license_up.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_license_up.ForeColor = System.Drawing.Color.White;
            this.btn_license_up.Location = new System.Drawing.Point(192, 32);
            this.btn_license_up.Name = "btn_license_up";
            this.btn_license_up.Size = new System.Drawing.Size(141, 32);
            this.btn_license_up.TabIndex = 1;
            this.btn_license_up.Text = "Update";
            this.btn_license_up.UseVisualStyleBackColor = false;
            this.btn_license_up.Click += new System.EventHandler(this.btn_license_up_Click);
            // 
            // frm_page2_plt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(362, 118);
            this.Controls.Add(this.btn_license_up);
            this.Controls.Add(this.tb_license_up);
            this.Name = "frm_page2_plt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Number Plate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_license_up;
        private System.Windows.Forms.Button btn_license_up;
    }
}