namespace GUI
{
    partial class EditSanPham
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
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSanPham));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTen = new Guna.UI.WinForms.GunaTextBox();
            this.tbSoLuong = new Guna.UI.WinForms.GunaTextBox();
            this.tbGia = new Guna.UI.WinForms.GunaTextBox();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.tranShowKho = new Guna.UI2.WinForms.Guna2Transition();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2CircleButton5 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.openFileImage = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tranShowKho.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tranShowKho.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(33, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tranShowKho.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(33, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Lượng";
            // 
            // tbTen
            // 
            this.tbTen.BackColor = System.Drawing.Color.Transparent;
            this.tbTen.BaseColor = System.Drawing.Color.White;
            this.tbTen.BorderColor = System.Drawing.Color.LightGray;
            this.tbTen.BorderSize = 1;
            this.tbTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tranShowKho.SetDecoration(this.tbTen, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tbTen.FocusedBaseColor = System.Drawing.Color.White;
            this.tbTen.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(226)))), ((int)(((byte)(175)))));
            this.tbTen.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbTen.Location = new System.Drawing.Point(116, 30);
            this.tbTen.Margin = new System.Windows.Forms.Padding(2);
            this.tbTen.Name = "tbTen";
            this.tbTen.PasswordChar = '\0';
            this.tbTen.Radius = 10;
            this.tbTen.SelectedText = "";
            this.tbTen.Size = new System.Drawing.Size(151, 26);
            this.tbTen.TabIndex = 4;
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.tbSoLuong.BaseColor = System.Drawing.Color.White;
            this.tbSoLuong.BorderColor = System.Drawing.Color.LightGray;
            this.tbSoLuong.BorderSize = 1;
            this.tbSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tranShowKho.SetDecoration(this.tbSoLuong, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tbSoLuong.FocusedBaseColor = System.Drawing.Color.White;
            this.tbSoLuong.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(226)))), ((int)(((byte)(175)))));
            this.tbSoLuong.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSoLuong.Location = new System.Drawing.Point(116, 156);
            this.tbSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.PasswordChar = '\0';
            this.tbSoLuong.Radius = 10;
            this.tbSoLuong.SelectedText = "";
            this.tbSoLuong.Size = new System.Drawing.Size(94, 26);
            this.tbSoLuong.TabIndex = 6;
            // 
            // tbGia
            // 
            this.tbGia.BackColor = System.Drawing.Color.Transparent;
            this.tbGia.BaseColor = System.Drawing.Color.White;
            this.tbGia.BorderColor = System.Drawing.Color.LightGray;
            this.tbGia.BorderSize = 1;
            this.tbGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tranShowKho.SetDecoration(this.tbGia, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tbGia.FocusedBaseColor = System.Drawing.Color.White;
            this.tbGia.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(226)))), ((int)(((byte)(175)))));
            this.tbGia.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbGia.Location = new System.Drawing.Point(115, 93);
            this.tbGia.Margin = new System.Windows.Forms.Padding(2);
            this.tbGia.Name = "tbGia";
            this.tbGia.PasswordChar = '\0';
            this.tbGia.Radius = 10;
            this.tbGia.SelectedText = "";
            this.tbGia.Size = new System.Drawing.Size(151, 26);
            this.tbGia.TabIndex = 7;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 10;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.tranShowKho.SetDecoration(this.guna2GradientButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(75)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(75)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(254, 272);
            this.guna2GradientButton1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(49, 29);
            this.guna2GradientButton1.TabIndex = 11;
            this.guna2GradientButton1.Text = "Delete";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 10;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.tranShowKho.SetDecoration(this.btnUpdate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(189)))), ((int)(((byte)(50)))));
            this.btnUpdate.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(209)))), ((int)(((byte)(55)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(172, 272);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(66, 29);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.guna2GradientButton3_Click);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.White;
            this.tranShowKho.SetDecoration(this.guna2ControlBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(303, -2);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(27, 27);
            this.guna2ControlBox2.TabIndex = 15;
            // 
            // tranShowKho
            // 
            this.tranShowKho.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.tranShowKho.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.tranShowKho.DefaultAnimation = animation2;
            this.tranShowKho.Interval = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.tranShowKho.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(33, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Image";
            // 
            // guna2CircleButton5
            // 
            this.guna2CircleButton5.CheckedState.Parent = this.guna2CircleButton5;
            this.guna2CircleButton5.CustomImages.Parent = this.guna2CircleButton5;
            this.tranShowKho.SetDecoration(this.guna2CircleButton5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2CircleButton5.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton5.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton5.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.guna2CircleButton5.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton5.HoverState.Image")));
            this.guna2CircleButton5.HoverState.Parent = this.guna2CircleButton5;
            this.guna2CircleButton5.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton5.Image")));
            this.guna2CircleButton5.Location = new System.Drawing.Point(84, 198);
            this.guna2CircleButton5.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CircleButton5.Name = "guna2CircleButton5";
            this.guna2CircleButton5.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton5.ShadowDecoration.Parent = this.guna2CircleButton5;
            this.guna2CircleButton5.Size = new System.Drawing.Size(26, 26);
            this.guna2CircleButton5.TabIndex = 37;
            this.guna2CircleButton5.Click += new System.EventHandler(this.guna2CircleButton5_Click);
            // 
            // openFileImage
            // 
            this.openFileImage.FileName = "openFileDialog1";
            // 
            // EditSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(330, 335);
            this.Controls.Add(this.guna2CircleButton5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.tbGia);
            this.Controls.Add(this.tbSoLuong);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.tranShowKho.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditSanPham";
            this.Load += new System.EventHandler(this.EditSanPham_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox tbTen;
        private Guna.UI.WinForms.GunaTextBox tbSoLuong;
        private Guna.UI.WinForms.GunaTextBox tbGia;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton btnUpdate;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2Transition tranShowKho;
        private System.Windows.Forms.OpenFileDialog openFileImage;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}