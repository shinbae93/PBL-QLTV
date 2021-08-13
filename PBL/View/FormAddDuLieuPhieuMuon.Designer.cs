
namespace PBL.View
{
    partial class FormAddDuLieuPhieuMuon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddDuLieuPhieuMuon));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbMSSV = new System.Windows.Forms.Label();
            this.lbNgayMuon = new System.Windows.Forms.Label();
            this.lbHanTra = new System.Windows.Forms.Label();
            this.txtSoThe = new System.Windows.Forms.TextBox();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.dtpHanTra = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numSLTL = new System.Windows.Forms.NumericUpDown();
            this.dgvTL = new System.Windows.Forms.DataGridView();
            this.cbbTL = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddTL = new System.Windows.Forms.Button();
            this.lbTaiLieu = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSLTL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTL)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Gainsboro;
            this.btnOK.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(359, 426);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 32);
            this.btnOK.TabIndex = 22;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(667, 426);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 32);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbMSSV
            // 
            this.lbMSSV.AutoSize = true;
            this.lbMSSV.BackColor = System.Drawing.Color.Transparent;
            this.lbMSSV.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMSSV.Location = new System.Drawing.Point(84, 112);
            this.lbMSSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMSSV.Name = "lbMSSV";
            this.lbMSSV.Size = new System.Drawing.Size(71, 28);
            this.lbMSSV.TabIndex = 1;
            this.lbMSSV.Text = "MSSV";
            // 
            // lbNgayMuon
            // 
            this.lbNgayMuon.AutoSize = true;
            this.lbNgayMuon.BackColor = System.Drawing.Color.Transparent;
            this.lbNgayMuon.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayMuon.Location = new System.Drawing.Point(578, 105);
            this.lbNgayMuon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgayMuon.Name = "lbNgayMuon";
            this.lbNgayMuon.Size = new System.Drawing.Size(137, 28);
            this.lbNgayMuon.TabIndex = 1;
            this.lbNgayMuon.Text = "Ngày Mượn";
            // 
            // lbHanTra
            // 
            this.lbHanTra.AutoSize = true;
            this.lbHanTra.BackColor = System.Drawing.Color.Transparent;
            this.lbHanTra.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHanTra.Location = new System.Drawing.Point(616, 163);
            this.lbHanTra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHanTra.Name = "lbHanTra";
            this.lbHanTra.Size = new System.Drawing.Size(99, 28);
            this.lbHanTra.TabIndex = 1;
            this.lbHanTra.Text = "Hạn Trả";
            // 
            // txtSoThe
            // 
            this.txtSoThe.Location = new System.Drawing.Point(163, 114);
            this.txtSoThe.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoThe.Name = "txtSoThe";
            this.txtSoThe.Size = new System.Drawing.Size(188, 22);
            this.txtSoThe.TabIndex = 24;
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Location = new System.Drawing.Point(744, 111);
            this.dtpNgayMuon.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(265, 22);
            this.dtpNgayMuon.TabIndex = 25;
            // 
            // dtpHanTra
            // 
            this.dtpHanTra.Location = new System.Drawing.Point(744, 168);
            this.dtpHanTra.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHanTra.Name = "dtpHanTra";
            this.dtpHanTra.Size = new System.Drawing.Size(265, 22);
            this.dtpHanTra.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.numSLTL);
            this.panel1.Controls.Add(this.dgvTL);
            this.panel1.Controls.Add(this.cbbTL);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAddTL);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.dtpHanTra);
            this.panel1.Controls.Add(this.dtpNgayMuon);
            this.panel1.Controls.Add(this.txtSoThe);
            this.panel1.Controls.Add(this.lbHanTra);
            this.panel1.Controls.Add(this.lbNgayMuon);
            this.panel1.Controls.Add(this.lbTaiLieu);
            this.panel1.Controls.Add(this.lbMSSV);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 474);
            this.panel1.TabIndex = 26;
            // 
            // numSLTL
            // 
            this.numSLTL.Location = new System.Drawing.Point(372, 165);
            this.numSLTL.Name = "numSLTL";
            this.numSLTL.Size = new System.Drawing.Size(73, 22);
            this.numSLTL.TabIndex = 37;
            // 
            // dgvTL
            // 
            this.dgvTL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTL.Location = new System.Drawing.Point(89, 209);
            this.dgvTL.Name = "dgvTL";
            this.dgvTL.ReadOnly = true;
            this.dgvTL.RowHeadersWidth = 51;
            this.dgvTL.RowTemplate.Height = 24;
            this.dgvTL.Size = new System.Drawing.Size(920, 192);
            this.dgvTL.TabIndex = 36;
            // 
            // cbbTL
            // 
            this.cbbTL.FormattingEnabled = true;
            this.cbbTL.Location = new System.Drawing.Point(166, 163);
            this.cbbTL.Name = "cbbTL";
            this.cbbTL.Size = new System.Drawing.Size(188, 24);
            this.cbbTL.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Cambria", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(110, 25);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(282, 55);
            this.label10.TabIndex = 34;
            this.label10.Text = "Phiếu Mượn";
            // 
            // btnAddTL
            // 
            this.btnAddTL.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddTL.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTL.Location = new System.Drawing.Point(462, 156);
            this.btnAddTL.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTL.Name = "btnAddTL";
            this.btnAddTL.Size = new System.Drawing.Size(100, 32);
            this.btnAddTL.TabIndex = 22;
            this.btnAddTL.Text = "Add";
            this.btnAddTL.UseVisualStyleBackColor = false;
            this.btnAddTL.Click += new System.EventHandler(this.btnAddTL_Click);
            // 
            // lbTaiLieu
            // 
            this.lbTaiLieu.AutoSize = true;
            this.lbTaiLieu.BackColor = System.Drawing.Color.Transparent;
            this.lbTaiLieu.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaiLieu.Location = new System.Drawing.Point(59, 162);
            this.lbTaiLieu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTaiLieu.Name = "lbTaiLieu";
            this.lbTaiLieu.Size = new System.Drawing.Size(100, 28);
            this.lbTaiLieu.TabIndex = 1;
            this.lbTaiLieu.Text = "Tài Liệu";
            // 
            // FormAddDuLieuPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1105, 471);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAddDuLieuPhieuMuon";
            this.Text = "DuLieuPhieuMuon";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAddDuLieuPhieuMuon_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSLTL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbMSSV;
        private System.Windows.Forms.Label lbNgayMuon;
        private System.Windows.Forms.Label lbHanTra;
        private System.Windows.Forms.TextBox txtSoThe;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.DateTimePicker dtpHanTra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbTaiLieu;
        private System.Windows.Forms.DataGridView dgvTL;
        private System.Windows.Forms.ComboBox cbbTL;
        private System.Windows.Forms.Button btnAddTL;
        private System.Windows.Forms.NumericUpDown numSLTL;
    }
}