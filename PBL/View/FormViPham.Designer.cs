
namespace PBL.View
{
    partial class FormViPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViPham));
            this.lbSoThe = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.txtSoThe = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridViewVP = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVP)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSoThe
            // 
            this.lbSoThe.AutoSize = true;
            this.lbSoThe.BackColor = System.Drawing.Color.Transparent;
            this.lbSoThe.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoThe.Location = new System.Drawing.Point(41, 107);
            this.lbSoThe.Name = "lbSoThe";
            this.lbSoThe.Size = new System.Drawing.Size(68, 22);
            this.lbSoThe.TabIndex = 1;
            this.lbSoThe.Text = "Số Thẻ";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.BackColor = System.Drawing.Color.Transparent;
            this.lbHoTen.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.ForeColor = System.Drawing.Color.Black;
            this.lbHoTen.Location = new System.Drawing.Point(350, 103);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(71, 22);
            this.lbHoTen.TabIndex = 2;
            this.lbHoTen.Text = "Họ Tên";
            // 
            // txtSoThe
            // 
            this.txtSoThe.Location = new System.Drawing.Point(115, 107);
            this.txtSoThe.Name = "txtSoThe";
            this.txtSoThe.Size = new System.Drawing.Size(139, 20);
            this.txtSoThe.TabIndex = 24;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(427, 103);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(139, 20);
            this.txtHoTen.TabIndex = 25;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(613, 99);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 26);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewVP
            // 
            this.dataGridViewVP.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewVP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVP.Location = new System.Drawing.Point(45, 163);
            this.dataGridViewVP.Name = "dataGridViewVP";
            this.dataGridViewVP.Size = new System.Drawing.Size(747, 235);
            this.dataGridViewVP.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(36, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 43);
            this.label5.TabIndex = 28;
            this.label5.Text = "Vi Phạm";
            // 
            // FormViPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(832, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewVP);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtSoThe);
            this.Controls.Add(this.lbHoTen);
            this.Controls.Add(this.lbSoThe);
            this.Name = "FormViPham";
            this.Text = "FormViPham";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSoThe;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.TextBox txtSoThe;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridViewVP;
        private System.Windows.Forms.Label label5;
    }
}