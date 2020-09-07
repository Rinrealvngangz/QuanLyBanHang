namespace GUI
{
    partial class Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            this.gvAcc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CircleButton7 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2ShadowPanel3 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tbRole = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.tbMa = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.tbPass = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.tbTen = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gvAcc)).BeginInit();
            this.guna2ShadowPanel3.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvAcc
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gvAcc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvAcc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvAcc.BackgroundColor = System.Drawing.Color.White;
            this.gvAcc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvAcc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvAcc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvAcc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvAcc.ColumnHeadersHeight = 21;
            this.gvAcc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaUser,
            this.UserName,
            this.role,
            this.PassWord});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvAcc.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvAcc.EnableHeadersVisualStyles = false;
            this.gvAcc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvAcc.Location = new System.Drawing.Point(16, 13);
            this.gvAcc.Name = "gvAcc";
            this.gvAcc.RowHeadersVisible = false;
            this.gvAcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvAcc.Size = new System.Drawing.Size(477, 440);
            this.gvAcc.TabIndex = 0;
            this.gvAcc.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gvAcc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gvAcc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gvAcc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gvAcc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gvAcc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gvAcc.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gvAcc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvAcc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gvAcc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvAcc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gvAcc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gvAcc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvAcc.ThemeStyle.HeaderStyle.Height = 21;
            this.gvAcc.ThemeStyle.ReadOnly = false;
            this.gvAcc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gvAcc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvAcc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gvAcc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvAcc.ThemeStyle.RowsStyle.Height = 22;
            this.gvAcc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvAcc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MaUser
            // 
            this.MaUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaUser.DataPropertyName = "MaUser";
            this.MaUser.HeaderText = "Mã Nhân Viên";
            this.MaUser.Name = "MaUser";
            this.MaUser.Width = 90;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "UserName";
            this.UserName.Name = "UserName";
            this.UserName.Width = 150;
            // 
            // role
            // 
            this.role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.role.DataPropertyName = "role";
            this.role.HeaderText = "Role";
            this.role.Name = "role";
            this.role.Width = 90;
            // 
            // PassWord
            // 
            this.PassWord.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PassWord.DataPropertyName = "PassWord";
            this.PassWord.HeaderText = "Pass";
            this.PassWord.Name = "PassWord";
            this.PassWord.Width = 150;
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.BorderRadius = 10;
            this.tbTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
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
            this.tbTimKiem.Location = new System.Drawing.Point(769, 15);
            this.tbTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.PasswordChar = '\0';
            this.tbTimKiem.PlaceholderText = "Tìm Kiếm";
            this.tbTimKiem.SelectedText = "";
            this.tbTimKiem.ShadowDecoration.Parent = this.tbTimKiem;
            this.tbTimKiem.Size = new System.Drawing.Size(169, 29);
            this.tbTimKiem.TabIndex = 46;
            // 
            // guna2CircleButton7
            // 
            this.guna2CircleButton7.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton7.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton7.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton7.CheckedState.ForeColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton7.CheckedState.Parent = this.guna2CircleButton7;
            this.guna2CircleButton7.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton7.CustomImages.Parent = this.guna2CircleButton7;
            this.guna2CircleButton7.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton7.ForeColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton7.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.guna2CircleButton7.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton7.HoverState.Parent = this.guna2CircleButton7;
            this.guna2CircleButton7.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton7.Image")));
            this.guna2CircleButton7.Location = new System.Drawing.Point(712, 11);
            this.guna2CircleButton7.Name = "guna2CircleButton7";
            this.guna2CircleButton7.PressedColor = System.Drawing.Color.Lime;
            this.guna2CircleButton7.PressedDepth = 10;
            this.guna2CircleButton7.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton7.ShadowDecoration.Parent = this.guna2CircleButton7;
            this.guna2CircleButton7.Size = new System.Drawing.Size(35, 33);
            this.guna2CircleButton7.TabIndex = 45;
            this.guna2CircleButton7.Click += new System.EventHandler(this.guna2CircleButton7_Click);
            // 
            // guna2ShadowPanel3
            // 
            this.guna2ShadowPanel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel3.Controls.Add(this.guna2GradientButton3);
            this.guna2ShadowPanel3.Controls.Add(this.guna2GradientButton1);
            this.guna2ShadowPanel3.Controls.Add(this.guna2GradientButton2);
            this.guna2ShadowPanel3.Controls.Add(this.tbRole);
            this.guna2ShadowPanel3.Controls.Add(this.gunaLabel4);
            this.guna2ShadowPanel3.Controls.Add(this.tbMa);
            this.guna2ShadowPanel3.Controls.Add(this.gunaLabel2);
            this.guna2ShadowPanel3.Controls.Add(this.tbPass);
            this.guna2ShadowPanel3.Controls.Add(this.gunaLabel1);
            this.guna2ShadowPanel3.Controls.Add(this.tbTen);
            this.guna2ShadowPanel3.Controls.Add(this.gunaLabel3);
            this.guna2ShadowPanel3.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel3.Location = new System.Drawing.Point(604, 77);
            this.guna2ShadowPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ShadowPanel3.Name = "guna2ShadowPanel3";
            this.guna2ShadowPanel3.Radius = 5;
            this.guna2ShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel3.ShadowShift = 4;
            this.guna2ShadowPanel3.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel3.Size = new System.Drawing.Size(334, 378);
            this.guna2ShadowPanel3.TabIndex = 47;
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.BorderRadius = 10;
            this.guna2GradientButton3.CheckedState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.CustomImages.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.HoverState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Location = new System.Drawing.Point(43, 313);
            this.guna2GradientButton3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.ShadowDecoration.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Size = new System.Drawing.Size(73, 30);
            this.guna2GradientButton3.TabIndex = 55;
            this.guna2GradientButton3.Text = "Update";
            this.guna2GradientButton3.Click += new System.EventHandler(this.guna2GradientButton3_Click_1);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 10;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(147, 314);
            this.guna2GradientButton1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(73, 29);
            this.guna2GradientButton1.TabIndex = 54;
            this.guna2GradientButton1.Text = "Add";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click_1);
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.BorderRadius = 10;
            this.guna2GradientButton2.CheckedState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.CustomImages.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(75)))));
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(75)))));
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.HoverState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Location = new System.Drawing.Point(240, 315);
            this.guna2GradientButton2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.ShadowDecoration.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Size = new System.Drawing.Size(73, 29);
            this.guna2GradientButton2.TabIndex = 53;
            this.guna2GradientButton2.Text = "Delete";
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click_1);
            // 
            // tbRole
            // 
            this.tbRole.BackColor = System.Drawing.Color.Transparent;
            this.tbRole.BaseColor = System.Drawing.Color.White;
            this.tbRole.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(85)))), ((int)(((byte)(170)))));
            this.tbRole.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbRole.FocusedBaseColor = System.Drawing.Color.White;
            this.tbRole.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(27)))), ((int)(((byte)(240)))));
            this.tbRole.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbRole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbRole.Location = new System.Drawing.Point(108, 213);
            this.tbRole.Name = "tbRole";
            this.tbRole.PasswordChar = '\0';
            this.tbRole.Radius = 10;
            this.tbRole.SelectedText = "";
            this.tbRole.Size = new System.Drawing.Size(205, 30);
            this.tbRole.TabIndex = 52;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.gunaLabel4.Location = new System.Drawing.Point(21, 224);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(45, 19);
            this.gunaLabel4.TabIndex = 51;
            this.gunaLabel4.Text = "Role";
            // 
            // tbMa
            // 
            this.tbMa.BackColor = System.Drawing.Color.Transparent;
            this.tbMa.BaseColor = System.Drawing.Color.White;
            this.tbMa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(85)))), ((int)(((byte)(170)))));
            this.tbMa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMa.FocusedBaseColor = System.Drawing.Color.White;
            this.tbMa.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(27)))), ((int)(((byte)(240)))));
            this.tbMa.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbMa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbMa.Location = new System.Drawing.Point(108, 27);
            this.tbMa.Name = "tbMa";
            this.tbMa.PasswordChar = '\0';
            this.tbMa.Radius = 10;
            this.tbMa.SelectedText = "";
            this.tbMa.Size = new System.Drawing.Size(82, 30);
            this.tbMa.TabIndex = 50;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.gunaLabel2.Location = new System.Drawing.Point(21, 38);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(45, 19);
            this.gunaLabel2.TabIndex = 49;
            this.gunaLabel2.Text = "MaNV";
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.Color.Transparent;
            this.tbPass.BaseColor = System.Drawing.Color.White;
            this.tbPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(85)))), ((int)(((byte)(170)))));
            this.tbPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPass.FocusedBaseColor = System.Drawing.Color.White;
            this.tbPass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(27)))), ((int)(((byte)(240)))));
            this.tbPass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPass.Location = new System.Drawing.Point(108, 141);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '\0';
            this.tbPass.Radius = 10;
            this.tbPass.SelectedText = "";
            this.tbPass.Size = new System.Drawing.Size(205, 30);
            this.tbPass.TabIndex = 48;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.gunaLabel1.Location = new System.Drawing.Point(21, 152);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(81, 19);
            this.gunaLabel1.TabIndex = 47;
            this.gunaLabel1.Text = "PassWord";
            // 
            // tbTen
            // 
            this.tbTen.BackColor = System.Drawing.Color.Transparent;
            this.tbTen.BaseColor = System.Drawing.Color.White;
            this.tbTen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(85)))), ((int)(((byte)(170)))));
            this.tbTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTen.FocusedBaseColor = System.Drawing.Color.White;
            this.tbTen.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(27)))), ((int)(((byte)(240)))));
            this.tbTen.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbTen.Location = new System.Drawing.Point(108, 79);
            this.tbTen.Name = "tbTen";
            this.tbTen.PasswordChar = '\0';
            this.tbTen.Radius = 10;
            this.tbTen.SelectedText = "";
            this.tbTen.Size = new System.Drawing.Size(205, 30);
            this.tbTen.TabIndex = 46;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.gunaLabel3.Location = new System.Drawing.Point(21, 79);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(81, 19);
            this.gunaLabel3.TabIndex = 45;
            this.gunaLabel3.Text = "UserName";
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.gvAcc);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(21, 15);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 5;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowShift = 4;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(509, 468);
            this.guna2ShadowPanel1.TabIndex = 48;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(951, 494);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.guna2ShadowPanel3);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.guna2CircleButton7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Account";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvAcc)).EndInit();
            this.guna2ShadowPanel3.ResumeLayout(false);
            this.guna2ShadowPanel3.PerformLayout();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView gvAcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassWord;
        private Guna.UI2.WinForms.Guna2TextBox tbTimKiem;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton7;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel3;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI.WinForms.GunaTextBox tbRole;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox tbMa;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox tbPass;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox tbTen;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
    }
}