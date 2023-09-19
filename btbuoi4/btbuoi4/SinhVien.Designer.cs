namespace btbuoi4
{
    partial class SinhVien
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
            this.lblMSSV = new System.Windows.Forms.Label();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lnlDTB = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.txtDiemTB = new System.Windows.Forms.TextBox();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Location = new System.Drawing.Point(70, 61);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(55, 13);
            this.lblMSSV.TabIndex = 0;
            this.lblMSSV.Text = "Ma So SV";
            // 
            // lblTenSV
            // 
            this.lblTenSV.AutoSize = true;
            this.lblTenSV.Location = new System.Drawing.Point(70, 111);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(43, 13);
            this.lblTenSV.TabIndex = 0;
            this.lblTenSV.Text = "Ten SV";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(70, 157);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(32, 13);
            this.lblKhoa.TabIndex = 0;
            this.lblKhoa.Text = "Khoa";
            // 
            // lnlDTB
            // 
            this.lnlDTB.AutoSize = true;
            this.lnlDTB.Location = new System.Drawing.Point(70, 211);
            this.lnlDTB.Name = "lnlDTB";
            this.lnlDTB.Size = new System.Drawing.Size(48, 13);
            this.lnlDTB.TabIndex = 0;
            this.lnlDTB.Text = "Diem TB";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(193, 61);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(100, 20);
            this.txtMSSV.TabIndex = 1;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(193, 104);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(100, 20);
            this.txtTenSV.TabIndex = 1;
            // 
            // txtDiemTB
            // 
            this.txtDiemTB.Location = new System.Drawing.Point(193, 204);
            this.txtDiemTB.Name = "txtDiemTB";
            this.txtDiemTB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDiemTB.Size = new System.Drawing.Size(100, 20);
            this.txtDiemTB.TabIndex = 1;
            // 
            // cbKhoa
            // 
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Items.AddRange(new object[] {
            "CNTT",
            "QTKD",
            "NNA"});
            this.cbKhoa.Location = new System.Drawing.Point(193, 154);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(121, 21);
            this.cbKhoa.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(309, 277);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Them moi";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(441, 277);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbKhoa);
            this.Controls.Add(this.txtDiemTB);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.lnlDTB);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.lblTenSV);
            this.Controls.Add(this.lblMSSV);
            this.Name = "SinhVien";
            this.Text = "SinhVien";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lnlDTB;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        public System.Windows.Forms.TextBox txtMSSV;
        public System.Windows.Forms.TextBox txtTenSV;
        public System.Windows.Forms.TextBox txtDiemTB;
        public System.Windows.Forms.ComboBox cbKhoa;
    }
}