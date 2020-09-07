namespace GUI
{
    partial class KhachHang
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHang));
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this._DateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnFill = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.tbTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.gvKhachHang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2ShadowPanel3 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2ShadowPanel4 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.tbMa = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDiachi = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tranShow = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2ShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhachHang)).BeginInit();
            this.guna2ShadowPanel3.SuspendLayout();
            this.guna2ShadowPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this._DateTimePicker);
            this.guna2ShadowPanel1.Controls.Add(this.btnFill);
            this.guna2ShadowPanel1.Controls.Add(this.guna2GradientButton4);
            this.guna2ShadowPanel1.Controls.Add(this.guna2CircleButton1);
            this.guna2ShadowPanel1.Controls.Add(this.tbTimKiem);
            this.guna2ShadowPanel1.Controls.Add(this.btnTimKiem);
            this.tranShow.SetDecoration(this.guna2ShadowPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowShift = 3;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(951, 89);
            this.guna2ShadowPanel1.TabIndex = 0;
            // 
            // _DateTimePicker
            // 
            this._DateTimePicker.CheckedState.Parent = this._DateTimePicker;
            this.tranShow.SetDecoration(this._DateTimePicker, Guna.UI2.AnimatorNS.DecorationType.None);
            this._DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this._DateTimePicker.HoverState.Parent = this._DateTimePicker;
            this._DateTimePicker.Location = new System.Drawing.Point(236, 25);
            this._DateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this._DateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this._DateTimePicker.Name = "_DateTimePicker";
            this._DateTimePicker.ShadowDecoration.Parent = this._DateTimePicker;
            this._DateTimePicker.Size = new System.Drawing.Size(200, 36);
            this._DateTimePicker.TabIndex = 51;
            this._DateTimePicker.Value = new System.DateTime(2020, 8, 24, 13, 32, 53, 919);
            this._DateTimePicker.ValueChanged += new System.EventHandler(this._DateTimePicker_ValueChanged_1);
            // 
            // btnFill
            // 
            this.btnFill.BackColor = System.Drawing.Color.Transparent;
            this.btnFill.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnFill.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnFill.CheckedState.ForeColor = System.Drawing.Color.Transparent;
            this.btnFill.CheckedState.Parent = this.btnFill;
            this.btnFill.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnFill.CustomImages.Parent = this.btnFill;
            this.tranShow.SetDecoration(this.btnFill, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnFill.FillColor = System.Drawing.Color.Transparent;
            this.btnFill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFill.ForeColor = System.Drawing.Color.Transparent;
            this.btnFill.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(210)))), ((int)(((byte)(239)))));
            this.btnFill.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.btnFill.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnFill.HoverState.Image")));
            this.btnFill.HoverState.Parent = this.btnFill;
            this.btnFill.Image = ((System.Drawing.Image)(resources.GetObject("btnFill.Image")));
            this.btnFill.Location = new System.Drawing.Point(505, 37);
            this.btnFill.Name = "btnFill";
            this.btnFill.PressedColor = System.Drawing.Color.Lime;
            this.btnFill.PressedDepth = 10;
            this.btnFill.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnFill.ShadowDecoration.Parent = this.btnFill;
            this.btnFill.Size = new System.Drawing.Size(35, 33);
            this.btnFill.TabIndex = 50;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // guna2GradientButton4
            // 
            this.guna2GradientButton4.BorderRadius = 15;
            this.guna2GradientButton4.CheckedState.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.CustomImages.Parent = this.guna2GradientButton4;
            this.tranShow.SetDecoration(this.guna2GradientButton4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2GradientButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.guna2GradientButton4.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.guna2GradientButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton4.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton4.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.guna2GradientButton4.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.guna2GradientButton4.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton4.HoverState.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.Location = new System.Drawing.Point(565, 33);
            this.guna2GradientButton4.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GradientButton4.Name = "guna2GradientButton4";
            this.guna2GradientButton4.ShadowDecoration.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.Size = new System.Drawing.Size(104, 37);
            this.guna2GradientButton4.TabIndex = 47;
            this.guna2GradientButton4.Text = "Show All";
            this.guna2GradientButton4.Click += new System.EventHandler(this.guna2GradientButton4_Click);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.guna2CircleButton1.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.CheckedState.ForeColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.tranShow.SetDecoration(this.guna2CircleButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2CircleButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.guna2CircleButton1.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton1.HoverState.Image")));
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton1.Image")));
            this.guna2CircleButton1.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2CircleButton1.Location = new System.Drawing.Point(878, 26);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.guna2CircleButton1.PressedDepth = 10;
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(45, 44);
            this.guna2CircleButton1.TabIndex = 41;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.BorderRadius = 10;
            this.tbTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tranShow.SetDecoration(this.tbTimKiem, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tbTimKiem.DefaultText = "";
            this.tbTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTimKiem.DisabledState.Parent = this.tbTimKiem;
            this.tbTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbTimKiem.FocusedState.Parent = this.tbTimKiem;
            this.tbTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTimKiem.HoverState.Parent = this.tbTimKiem;
            this.tbTimKiem.Location = new System.Drawing.Point(61, 32);
            this.tbTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.PasswordChar = '\0';
            this.tbTimKiem.PlaceholderText = "Tìm Kiếm";
            this.tbTimKiem.SelectedText = "";
            this.tbTimKiem.ShadowDecoration.Parent = this.tbTimKiem;
            this.tbTimKiem.Size = new System.Drawing.Size(138, 29);
            this.tbTimKiem.TabIndex = 40;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.CheckedState.ForeColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.CheckedState.Parent = this.btnTimKiem;
            this.btnTimKiem.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.CustomImages.Parent = this.btnTimKiem;
            this.tranShow.SetDecoration(this.btnTimKiem, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnTimKiem.FillColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimKiem.ForeColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnTimKiem.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.HoverState.Parent = this.btnTimKiem;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(21, 28);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.PressedColor = System.Drawing.Color.Lime;
            this.btnTimKiem.PressedDepth = 10;
            this.btnTimKiem.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnTimKiem.ShadowDecoration.Parent = this.btnTimKiem;
            this.btnTimKiem.Size = new System.Drawing.Size(35, 33);
            this.btnTimKiem.TabIndex = 39;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.BorderRadius = 15;
            this.guna2GradientButton2.CheckedState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.CustomImages.Parent = this.guna2GradientButton2;
            this.tranShow.SetDecoration(this.guna2GradientButton2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.guna2GradientButton2.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.guna2GradientButton2.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.HoverState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Location = new System.Drawing.Point(131, 310);
            this.guna2GradientButton2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.ShadowDecoration.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Size = new System.Drawing.Size(55, 32);
            this.guna2GradientButton2.TabIndex = 49;
            this.guna2GradientButton2.Text = "Update";
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 15;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.tranShow.SetDecoration(this.guna2GradientButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(67)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(67)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(67)))));
            this.guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(67)))));
            this.guna2GradientButton1.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(203, 311);
            this.guna2GradientButton1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(60, 31);
            this.guna2GradientButton1.TabIndex = 48;
            this.guna2GradientButton1.Text = "Delete";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.gvKhachHang);
            this.tranShow.SetDecoration(this.guna2ShadowPanel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ShadowPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(0, 89);
            this.guna2ShadowPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(642, 405);
            this.guna2ShadowPanel2.TabIndex = 1;
            // 
            // gvKhachHang
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gvKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvKhachHang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.gvKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvKhachHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvKhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvKhachHang.ColumnHeadersHeight = 27;
            this.gvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.SDT,
            this.DiaChi,
            this.NgayMua});
            this.tranShow.SetDecoration(this.gvKhachHang, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvKhachHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvKhachHang.EnableHeadersVisualStyles = false;
            this.gvKhachHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.gvKhachHang.Location = new System.Drawing.Point(21, 20);
            this.gvKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.gvKhachHang.Name = "gvKhachHang";
            this.gvKhachHang.RowHeadersVisible = false;
            this.gvKhachHang.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.gvKhachHang.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gvKhachHang.RowTemplate.DividerHeight = 5;
            this.gvKhachHang.RowTemplate.Height = 50;
            this.gvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvKhachHang.Size = new System.Drawing.Size(605, 375);
            this.gvKhachHang.TabIndex = 0;
            this.gvKhachHang.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gvKhachHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gvKhachHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gvKhachHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gvKhachHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gvKhachHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gvKhachHang.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.gvKhachHang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.gvKhachHang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.gvKhachHang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvKhachHang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gvKhachHang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.gvKhachHang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvKhachHang.ThemeStyle.HeaderStyle.Height = 27;
            this.gvKhachHang.ThemeStyle.ReadOnly = false;
            this.gvKhachHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gvKhachHang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvKhachHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gvKhachHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvKhachHang.ThemeStyle.RowsStyle.Height = 50;
            this.gvKhachHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvKhachHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MaKH
            // 
            this.MaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 70;
            // 
            // TenKH
            // 
            this.TenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            this.TenKH.Width = 150;
            // 
            // SDT
            // 
            this.SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 200;
            // 
            // NgayMua
            // 
            this.NgayMua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NgayMua.DataPropertyName = "NgayMua";
            this.NgayMua.HeaderText = "Ngày Mua";
            this.NgayMua.MinimumWidth = 6;
            this.NgayMua.Name = "NgayMua";
            this.NgayMua.Width = 151;
            // 
            // guna2ShadowPanel3
            // 
            this.guna2ShadowPanel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel3.Controls.Add(this.guna2ShadowPanel4);
            this.tranShow.SetDecoration(this.guna2ShadowPanel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ShadowPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ShadowPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.guna2ShadowPanel3.Location = new System.Drawing.Point(647, 89);
            this.guna2ShadowPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ShadowPanel3.Name = "guna2ShadowPanel3";
            this.guna2ShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel3.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.guna2ShadowPanel3.Size = new System.Drawing.Size(304, 405);
            this.guna2ShadowPanel3.TabIndex = 2;
            // 
            // guna2ShadowPanel4
            // 
            this.guna2ShadowPanel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel4.Controls.Add(this.tbMa);
            this.guna2ShadowPanel4.Controls.Add(this.label3);
            this.guna2ShadowPanel4.Controls.Add(this.tbDiachi);
            this.guna2ShadowPanel4.Controls.Add(this.tbSDT);
            this.guna2ShadowPanel4.Controls.Add(this.guna2GradientButton1);
            this.guna2ShadowPanel4.Controls.Add(this.guna2GradientButton2);
            this.guna2ShadowPanel4.Controls.Add(this.tbTen);
            this.guna2ShadowPanel4.Controls.Add(this.label4);
            this.guna2ShadowPanel4.Controls.Add(this.label2);
            this.guna2ShadowPanel4.Controls.Add(this.label1);
            this.tranShow.SetDecoration(this.guna2ShadowPanel4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ShadowPanel4.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel4.Location = new System.Drawing.Point(13, 20);
            this.guna2ShadowPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ShadowPanel4.Name = "guna2ShadowPanel4";
            this.guna2ShadowPanel4.Radius = 15;
            this.guna2ShadowPanel4.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel4.ShadowShift = 3;
            this.guna2ShadowPanel4.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel4.Size = new System.Drawing.Size(283, 374);
            this.guna2ShadowPanel4.TabIndex = 0;
            this.guna2ShadowPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2ShadowPanel4_Paint);
            // 
            // tbMa
            // 
            this.tbMa.BorderColor = System.Drawing.Color.White;
            this.tbMa.BorderRadius = 10;
            this.tbMa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tranShow.SetDecoration(this.tbMa, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tbMa.DefaultText = "";
            this.tbMa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbMa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbMa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMa.DisabledState.Parent = this.tbMa;
            this.tbMa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(239)))));
            this.tbMa.FocusedState.BorderColor = System.Drawing.Color.White;
            this.tbMa.FocusedState.Parent = this.tbMa;
            this.tbMa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbMa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.tbMa.HoverState.BorderColor = System.Drawing.Color.White;
            this.tbMa.HoverState.Parent = this.tbMa;
            this.tbMa.Location = new System.Drawing.Point(63, 16);
            this.tbMa.Margin = new System.Windows.Forms.Padding(2);
            this.tbMa.Name = "tbMa";
            this.tbMa.PasswordChar = '\0';
            this.tbMa.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.tbMa.PlaceholderText = "";
            this.tbMa.SelectedText = "";
            this.tbMa.ShadowDecoration.Parent = this.tbMa;
            this.tbMa.Size = new System.Drawing.Size(95, 44);
            this.tbMa.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tranShow.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "Mã";
            // 
            // tbDiachi
            // 
            this.tbDiachi.BorderColor = System.Drawing.Color.White;
            this.tbDiachi.BorderRadius = 10;
            this.tbDiachi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tranShow.SetDecoration(this.tbDiachi, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tbDiachi.DefaultText = "";
            this.tbDiachi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbDiachi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbDiachi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDiachi.DisabledState.Parent = this.tbDiachi;
            this.tbDiachi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDiachi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(239)))));
            this.tbDiachi.FocusedState.BorderColor = System.Drawing.Color.White;
            this.tbDiachi.FocusedState.Parent = this.tbDiachi;
            this.tbDiachi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbDiachi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.tbDiachi.HoverState.BorderColor = System.Drawing.Color.White;
            this.tbDiachi.HoverState.Parent = this.tbDiachi;
            this.tbDiachi.Location = new System.Drawing.Point(63, 220);
            this.tbDiachi.Margin = new System.Windows.Forms.Padding(2);
            this.tbDiachi.Name = "tbDiachi";
            this.tbDiachi.PasswordChar = '\0';
            this.tbDiachi.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.tbDiachi.PlaceholderText = "";
            this.tbDiachi.SelectedText = "";
            this.tbDiachi.ShadowDecoration.Parent = this.tbDiachi;
            this.tbDiachi.Size = new System.Drawing.Size(200, 44);
            this.tbDiachi.TabIndex = 19;
            // 
            // tbSDT
            // 
            this.tbSDT.BorderColor = System.Drawing.Color.White;
            this.tbSDT.BorderRadius = 10;
            this.tbSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tranShow.SetDecoration(this.tbSDT, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tbSDT.DefaultText = "";
            this.tbSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSDT.DisabledState.Parent = this.tbSDT;
            this.tbSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSDT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(239)))));
            this.tbSDT.FocusedState.BorderColor = System.Drawing.Color.White;
            this.tbSDT.FocusedState.Parent = this.tbSDT;
            this.tbSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.tbSDT.HoverState.BorderColor = System.Drawing.Color.White;
            this.tbSDT.HoverState.Parent = this.tbSDT;
            this.tbSDT.Location = new System.Drawing.Point(63, 154);
            this.tbSDT.Margin = new System.Windows.Forms.Padding(2);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.PasswordChar = '\0';
            this.tbSDT.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.tbSDT.PlaceholderText = "";
            this.tbSDT.SelectedText = "";
            this.tbSDT.ShadowDecoration.Parent = this.tbSDT;
            this.tbSDT.Size = new System.Drawing.Size(200, 44);
            this.tbSDT.TabIndex = 18;
            // 
            // tbTen
            // 
            this.tbTen.BorderColor = System.Drawing.Color.White;
            this.tbTen.BorderRadius = 10;
            this.tbTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tranShow.SetDecoration(this.tbTen, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tbTen.DefaultText = "";
            this.tbTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTen.DisabledState.Parent = this.tbTen;
            this.tbTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(239)))));
            this.tbTen.FocusedState.BorderColor = System.Drawing.Color.White;
            this.tbTen.FocusedState.Parent = this.tbTen;
            this.tbTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.tbTen.HoverState.BorderColor = System.Drawing.Color.White;
            this.tbTen.HoverState.Parent = this.tbTen;
            this.tbTen.Location = new System.Drawing.Point(63, 76);
            this.tbTen.Margin = new System.Windows.Forms.Padding(2);
            this.tbTen.Name = "tbTen";
            this.tbTen.PasswordChar = '\0';
            this.tbTen.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.tbTen.PlaceholderText = "";
            this.tbTen.SelectedText = "";
            this.tbTen.ShadowDecoration.Parent = this.tbTen;
            this.tbTen.Size = new System.Drawing.Size(200, 44);
            this.tbTen.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tranShow.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 236);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tranShow.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "SĐT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tranShow.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên";
            // 
            // tranShow
            // 
            this.tranShow.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.tranShow.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.tranShow.DefaultAnimation = animation1;
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 494);
            this.Controls.Add(this.guna2ShadowPanel3);
            this.Controls.Add(this.guna2ShadowPanel2);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.tranShow.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KhachHang";
            this.Text = "KhachHang";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvKhachHang)).EndInit();
            this.guna2ShadowPanel3.ResumeLayout(false);
            this.guna2ShadowPanel4.ResumeLayout(false);
            this.guna2ShadowPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2DataGridView gvKhachHang;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel3;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tbTimKiem;
        private Guna.UI2.WinForms.Guna2CircleButton btnTimKiem;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton4;
        private Guna.UI2.WinForms.Guna2Transition tranShow;
        private Guna.UI2.WinForms.Guna2DateTimePicker _DateTimePicker;
        private Guna.UI2.WinForms.Guna2CircleButton btnFill;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMua;
        private Guna.UI2.WinForms.Guna2TextBox tbDiachi;
        private Guna.UI2.WinForms.Guna2TextBox tbSDT;
        private Guna.UI2.WinForms.Guna2TextBox tbTen;
        private Guna.UI2.WinForms.Guna2TextBox tbMa;
        private System.Windows.Forms.Label label3;
    }
}