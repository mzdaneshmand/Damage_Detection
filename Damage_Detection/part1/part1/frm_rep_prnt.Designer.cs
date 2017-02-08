namespace part1
{
    partial class frm_rep_prnt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_rep_prnt));
            this.pb_rep_prnt = new System.Windows.Forms.PictureBox();
            this.btn_prnt = new System.Windows.Forms.Button();
            this.btn_prnt_dn = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rep_prnt)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_rep_prnt
            // 
            this.pb_rep_prnt.Image = ((System.Drawing.Image)(resources.GetObject("pb_rep_prnt.Image")));
            this.pb_rep_prnt.Location = new System.Drawing.Point(164, 73);
            this.pb_rep_prnt.Name = "pb_rep_prnt";
            this.pb_rep_prnt.Size = new System.Drawing.Size(515, 426);
            this.pb_rep_prnt.TabIndex = 0;
            this.pb_rep_prnt.TabStop = false;
            // 
            // btn_prnt
            // 
            this.btn_prnt.BackColor = System.Drawing.Color.Black;
            this.btn_prnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prnt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prnt.ForeColor = System.Drawing.Color.White;
            this.btn_prnt.Location = new System.Drawing.Point(910, 199);
            this.btn_prnt.Name = "btn_prnt";
            this.btn_prnt.Size = new System.Drawing.Size(92, 42);
            this.btn_prnt.TabIndex = 1;
            this.btn_prnt.Text = "Print";
            this.btn_prnt.UseVisualStyleBackColor = false;
            this.btn_prnt.Click += new System.EventHandler(this.btn_prnt_Click);
            // 
            // btn_prnt_dn
            // 
            this.btn_prnt_dn.BackColor = System.Drawing.Color.Black;
            this.btn_prnt_dn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prnt_dn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prnt_dn.ForeColor = System.Drawing.Color.White;
            this.btn_prnt_dn.Location = new System.Drawing.Point(910, 281);
            this.btn_prnt_dn.Name = "btn_prnt_dn";
            this.btn_prnt_dn.Size = new System.Drawing.Size(92, 35);
            this.btn_prnt_dn.TabIndex = 2;
            this.btn_prnt_dn.Text = "Done";
            this.btn_prnt_dn.UseVisualStyleBackColor = false;
            this.btn_prnt_dn.Click += new System.EventHandler(this.btn_prnt_dn_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // frm_rep_prnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1269, 586);
            this.Controls.Add(this.btn_prnt_dn);
            this.Controls.Add(this.btn_prnt);
            this.Controls.Add(this.pb_rep_prnt);
            this.Name = "frm_rep_prnt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Print";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_rep_prnt_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pb_rep_prnt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_rep_prnt;
        private System.Windows.Forms.Button btn_prnt;
        private System.Windows.Forms.Button btn_prnt_dn;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}