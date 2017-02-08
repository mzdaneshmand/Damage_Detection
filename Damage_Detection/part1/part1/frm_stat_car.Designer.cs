namespace part1
{
    partial class frm_stat_car
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
            this.lbl_stat_in = new System.Windows.Forms.Label();
            this.btn_report = new System.Windows.Forms.Button();
            this.lbl_damage = new System.Windows.Forms.Label();
            this.txtbox_damage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_stat_in
            // 
            this.lbl_stat_in.AutoSize = true;
            this.lbl_stat_in.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stat_in.Location = new System.Drawing.Point(48, 22);
            this.lbl_stat_in.Name = "lbl_stat_in";
            this.lbl_stat_in.Size = new System.Drawing.Size(252, 23);
            this.lbl_stat_in.TabIndex = 0;
            this.lbl_stat_in.Text = "The Car is returned from rent";
            // 
            // btn_report
            // 
            this.btn_report.BackColor = System.Drawing.Color.Black;
            this.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_report.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.ForeColor = System.Drawing.Color.White;
            this.btn_report.Location = new System.Drawing.Point(88, 102);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(168, 30);
            this.btn_report.TabIndex = 1;
            this.btn_report.Text = "Generate Report";
            this.btn_report.UseVisualStyleBackColor = false;
            this.btn_report.Click += new System.EventHandler(this.btn_ok_stat_Click);
            // 
            // lbl_damage
            // 
            this.lbl_damage.AutoSize = true;
            this.lbl_damage.Location = new System.Drawing.Point(52, 63);
            this.lbl_damage.Name = "lbl_damage";
            this.lbl_damage.Size = new System.Drawing.Size(111, 13);
            this.lbl_damage.TabIndex = 2;
            this.lbl_damage.Text = "Damage Percentage :";
            // 
            // txtbox_damage
            // 
            this.txtbox_damage.Location = new System.Drawing.Point(200, 56);
            this.txtbox_damage.Name = "txtbox_damage";
            this.txtbox_damage.Size = new System.Drawing.Size(100, 20);
            this.txtbox_damage.TabIndex = 3;
            this.txtbox_damage.Text = "1";
            this.txtbox_damage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frm_stat_car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(347, 165);
            this.Controls.Add(this.txtbox_damage);
            this.Controls.Add(this.lbl_damage);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.lbl_stat_in);
            this.Name = "frm_stat_car";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_stat_car";
            this.Load += new System.EventHandler(this.frm_stat_car_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_stat_in;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Label lbl_damage;
        private System.Windows.Forms.TextBox txtbox_damage;
    }
}