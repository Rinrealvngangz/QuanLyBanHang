namespace GUI
{
    partial class HienThiKho
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tbSoLuong = new Guna.UI.WinForms.GunaTextBox();
            this.tbTen = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.gvKhoSpNhap = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGia = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMa = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSoluongKho = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhoSpNhap)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BorderColor = System.Drawing.Color.White;
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnAdd.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(739, 399);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(54, 28);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.tbSoLuong.BaseColor = System.Drawing.Color.White;
            this.tbSoLuong.BorderColor = System.Drawing.Color.LightGray;
            this.tbSoLuong.BorderSize = 1;
            this.tbSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSoLuong.FocusedBaseColor = System.Drawing.Color.White;
            this.tbSoLuong.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.tbSoLuong.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSoLuong.Location = new System.Drawing.Point(459, 352);
            this.tbSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.PasswordChar = '\0';
            this.tbSoLuong.Radius = 10;
            this.tbSoLuong.SelectedText = "";
            this.tbSoLuong.Size = new System.Drawing.Size(85, 26);
            this.tbSoLuong.TabIndex = 5;
            // 
            // tbTen
            // 
            this.tbTen.BackColor = System.Drawing.Color.Transparent;
            this.tbTen.BaseColor = System.Drawing.Color.White;
            this.tbTen.BorderColor = System.Drawing.Color.LightGray;
            this.tbTen.BorderSize = 1;
            this.tbTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTen.FocusedBaseColor = System.Drawing.Color.White;
            this.tbTen.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.tbTen.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbTen.Location = new System.Drawing.Point(86, 401);
            this.tbTen.Margin = new System.Windows.Forms.Padding(2);
            this.tbTen.Name = "tbTen";
            this.tbTen.PasswordChar = '\0';
            this.tbTen.Radius = 10;
            this.tbTen.SelectedText = "";
            this.tbTen.Size = new System.Drawing.Size(184, 26);
            this.tbTen.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(354, 361);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số Lượng Bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(27, 410);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên";
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(794, -2);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(27, 27);
            this.guna2ControlBox2.TabIndex = 16;
            // 
            // gvKhoSpNhap
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gvKhoSpNhap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvKhoSpNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvKhoSpNhap.BackgroundColor = System.Drawing.Color.White;
            this.gvKhoSpNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvKhoSpNhap.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvKhoSpNhap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvKhoSpNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvKhoSpNhap.ColumnHeadersHeight = 27;
            this.gvKhoSpNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.SoLuong,
            this.DonGia,
            this.MaNCC,
            this.NgayNhap});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvKhoSpNhap.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvKhoSpNhap.EnableHeadersVisualStyles = false;
            this.gvKhoSpNhap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.gvKhoSpNhap.Location = new System.Drawing.Point(24, 20);
            this.gvKhoSpNhap.Margin = new System.Windows.Forms.Padding(2);
            this.gvKhoSpNhap.Name = "gvKhoSpNhap";
            this.gvKhoSpNhap.RowHeadersVisible = false;
            this.gvKhoSpNhap.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.gvKhoSpNhap.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gvKhoSpNhap.RowTemplate.DividerHeight = 1;
            this.gvKhoSpNhap.RowTemplate.Height = 50;
            this.gvKhoSpNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvKhoSpNhap.Size = new System.Drawing.Size(719, 265);
            this.gvKhoSpNhap.TabIndex = 0;
            this.gvKhoSpNhap.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gvKhoSpNhap.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gvKhoSpNhap.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gvKhoSpNhap.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gvKhoSpNhap.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gvKhoSpNhap.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gvKhoSpNhap.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gvKhoSpNhap.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.gvKhoSpNhap.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.gvKhoSpNhap.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvKhoSpNhap.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gvKhoSpNhap.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.gvKhoSpNhap.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvKhoSpNhap.ThemeStyle.HeaderStyle.Height = 27;
            this.gvKhoSpNhap.ThemeStyle.ReadOnly = false;
            this.gvKhoSpNhap.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gvKhoSpNhap.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvKhoSpNhap.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gvKhoSpNhap.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvKhoSpNhap.ThemeStyle.RowsStyle.Height = 50;
            this.gvKhoSpNhap.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvKhoSpNhap.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MaSP
            // 
            this.MaSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 96;
            // 
            // TenSP
            // 
            this.TenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SoLuong.DataPropertyName = "Soluong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 98;
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Giá Nhập";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 150;
            // 
            // MaNCC
            // 
            this.MaNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã NCC";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            // 
            // NgayNhap
            // 
            this.NgayNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày Nhập";
            this.NgayNhap.MinimumWidth = 6;
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.Width = 200;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.gvKhoSpNhap);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(22, 29);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 15;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowShift = 1;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(771, 303);
            this.guna2ShadowPanel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(357, 410);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Giá Bán";
            // 
            // tbGia
            // 
            this.tbGia.BackColor = System.Drawing.Color.Transparent;
            this.tbGia.BaseColor = System.Drawing.Color.White;
            this.tbGia.BorderColor = System.Drawing.Color.LightGray;
            this.tbGia.BorderSize = 1;
            this.tbGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbGia.FocusedBaseColor = System.Drawing.Color.White;
            this.tbGia.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.tbGia.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbGia.Location = new System.Drawing.Point(459, 401);
            this.tbGia.Margin = new System.Windows.Forms.Padding(2);
            this.tbGia.Name = "tbGia";
            this.tbGia.PasswordChar = '\0';
            this.tbGia.Radius = 10;
            this.tbGia.SelectedText = "";
            this.tbGia.Size = new System.Drawing.Size(162, 26);
            this.tbGia.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(27, 361);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Mã";
            // 
            // tbMa
            // 
            this.tbMa.BackColor = System.Drawing.Color.Transparent;
            this.tbMa.BaseColor = System.Drawing.Color.White;
            this.tbMa.BorderColor = System.Drawing.Color.LightGray;
            this.tbMa.BorderSize = 1;
            this.tbMa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMa.FocusedBaseColor = System.Drawing.Color.White;
            this.tbMa.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.tbMa.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbMa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbMa.Location = new System.Drawing.Point(86, 352);
            this.tbMa.Margin = new System.Windows.Forms.Padding(2);
            this.tbMa.Name = "tbMa";
            this.tbMa.PasswordChar = '\0';
            this.tbMa.Radius = 10;
            this.tbMa.SelectedText = "";
            this.tbMa.Size = new System.Drawing.Size(85, 26);
            this.tbMa.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(608, 361);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Số Lượng Hiện có:";
            // 
            // lbSoluongKho
            // 
            this.lbSoluongKho.AutoSize = true;
            this.lbSoluongKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoluongKho.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbSoluongKho.Location = new System.Drawing.Point(738, 361);
            this.lbSoluongKho.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSoluongKho.Name = "lbSoluongKho";
            this.lbSoluongKho.Size = new System.Drawing.Size(16, 17);
            this.lbSoluongKho.TabIndex = 24;
            this.lbSoluongKho.Text = "5";
            // 
            // HienThiKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(820, 438);
            this.Controls.Add(this.lbSoluongKho);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbGia);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.tbSoLuong);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HienThiKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HienThiKho";
            this.Load += new System.EventHandler(this.HienThiKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvKhoSpNhap)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientButton btnAdd;
        private Guna.UI.WinForms.GunaTextBox tbSoLuong;
        private Guna.UI.WinForms.GunaTextBox tbTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2DataGridView gvKhoSpNhap;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox tbGia;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox tbMa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbSoluongKho;
    }
}