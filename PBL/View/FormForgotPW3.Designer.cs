
namespace PBL.View
{
    partial class FormForgotPW3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForgotPW3));
            this.lbMatKhauMoi = new System.Windows.Forms.Label();
            this.lbXacNhanLaiMatKhau = new System.Windows.Forms.Label();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.txtXacNhanLaiMatKhau = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMatKhauMoi
            // 
            this.lbMatKhauMoi.AutoSize = true;
            this.lbMatKhauMoi.BackColor = System.Drawing.Color.Transparent;
            this.lbMatKhauMoi.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatKhauMoi.Location = new System.Drawing.Point(69, 64);
            this.lbMatKhauMoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMatKhauMoi.Name = "lbMatKhauMoi";
            this.lbMatKhauMoi.Size = new System.Drawing.Size(164, 28);
            this.lbMatKhauMoi.TabIndex = 0;
            this.lbMatKhauMoi.Text = "Mật khẩu mới";
            // 
            // lbXacNhanLaiMatKhau
            // 
            this.lbXacNhanLaiMatKhau.AutoSize = true;
            this.lbXacNhanLaiMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.lbXacNhanLaiMatKhau.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXacNhanLaiMatKhau.Location = new System.Drawing.Point(69, 108);
            this.lbXacNhanLaiMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbXacNhanLaiMatKhau.Name = "lbXacNhanLaiMatKhau";
            this.lbXacNhanLaiMatKhau.Size = new System.Drawing.Size(252, 28);
            this.lbXacNhanLaiMatKhau.TabIndex = 1;
            this.lbXacNhanLaiMatKhau.Text = "Xác nhận lại mật khẩu";
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(383, 64);
            this.txtMatKhauMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(255, 22);
            this.txtMatKhauMoi.TabIndex = 1;
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // txtXacNhanLaiMatKhau
            // 
            this.txtXacNhanLaiMatKhau.Location = new System.Drawing.Point(383, 108);
            this.txtXacNhanLaiMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtXacNhanLaiMatKhau.Name = "txtXacNhanLaiMatKhau";
            this.txtXacNhanLaiMatKhau.Size = new System.Drawing.Size(255, 22);
            this.txtXacNhanLaiMatKhau.TabIndex = 2;
            this.txtXacNhanLaiMatKhau.UseSystemPasswordChar = true;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.White;
            this.btnOK.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(192, 169);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 37);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(434, 169);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 37);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormForgotPW3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(731, 233);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtXacNhanLaiMatKhau);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.lbXacNhanLaiMatKhau);
            this.Controls.Add(this.lbMatKhauMoi);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormForgotPW3";
            this.Text = "FormForgotPW3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMatKhauMoi;
        private System.Windows.Forms.Label lbXacNhanLaiMatKhau;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.TextBox txtXacNhanLaiMatKhau;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}