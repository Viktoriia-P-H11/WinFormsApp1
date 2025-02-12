namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lnkContactAdmin = new Panel();
            picStudentPhoto = new PictureBox();
            btnCancel = new Button();
            btnSearch = new Button();
            txtPhoneNumber = new TextBox();
            txtStudentName = new TextBox();
            txtStudentID = new TextBox();
            lblPhoneNumber = new Label();
            lblStudentName = new Label();
            lblStudentInfo = new Label();
            linkLabel1 = new LinkLabel();
            pictureUniversity = new PictureBox();
            lblAdminInfo = new Label();
            lnkContactAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStudentPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureUniversity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // lnkContactAdmin
            // 
            lnkContactAdmin.BackColor = Color.FromArgb(219, 199, 166);
            lnkContactAdmin.Controls.Add(picStudentPhoto);
            lnkContactAdmin.Controls.Add(btnCancel);
            lnkContactAdmin.Controls.Add(btnSearch);
            lnkContactAdmin.Controls.Add(txtPhoneNumber);
            lnkContactAdmin.Controls.Add(txtStudentName);
            lnkContactAdmin.Controls.Add(txtStudentID);
            lnkContactAdmin.Controls.Add(lblPhoneNumber);
            lnkContactAdmin.Controls.Add(lblStudentName);
            lnkContactAdmin.Controls.Add(lblStudentInfo);
            lnkContactAdmin.Dock = DockStyle.Top;
            lnkContactAdmin.Location = new Point(0, 0);
            lnkContactAdmin.Name = "lnkContactAdmin";
            lnkContactAdmin.Size = new Size(1125, 248);
            lnkContactAdmin.TabIndex = 1;
            // 
            // picStudentPhoto
            // 
            picStudentPhoto.BackColor = Color.FromArgb(219, 199, 166);
            picStudentPhoto.ImageLocation = "C:\\\\Users\\\\torri\\\\source\\\\repos\\\\SQLapp\\\\SQLapp\\\\Resources\\\\img_placeholder.png";
            picStudentPhoto.Location = new Point(829, 23);
            picStudentPhoto.Name = "picStudentPhoto";
            picStudentPhoto.Size = new Size(188, 182);
            picStudentPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            picStudentPhoto.TabIndex = 8;
            picStudentPhoto.TabStop = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(63, 43, 36);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            btnCancel.ForeColor = SystemColors.Control;
            btnCancel.Location = new Point(599, 140);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(125, 41);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cansel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(63, 43, 36);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            btnSearch.ForeColor = SystemColors.ButtonFace;
            btnSearch.Location = new Point(599, 66);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(125, 41);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.ForeColor = SystemColors.ControlText;
            txtPhoneNumber.Location = new Point(261, 171);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Enter number";
            txtPhoneNumber.Size = new Size(255, 34);
            txtPhoneNumber.TabIndex = 5;
            // 
            // txtStudentName
            // 
            txtStudentName.Font = new Font("Nirmala UI", 12F);
            txtStudentName.ForeColor = SystemColors.ControlText;
            txtStudentName.Location = new Point(261, 103);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.PlaceholderText = "Enter student name";
            txtStudentName.Size = new Size(255, 34);
            txtStudentName.TabIndex = 4;
            // 
            // txtStudentID
            // 
            txtStudentID.Font = new Font("Nirmala UI", 12F);
            txtStudentID.ForeColor = SystemColors.Desktop;
            txtStudentID.Location = new Point(261, 44);
            txtStudentID.MaximumSize = new Size(255, 40);
            txtStudentID.MinimumSize = new Size(255, 0);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.PlaceholderText = "Enter student ID";
            txtStudentID.Size = new Size(255, 34);
            txtStudentID.TabIndex = 3;
            txtStudentID.TextChanged += textBox1_TextChanged;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Nirmala UI", 18F, FontStyle.Bold);
            lblPhoneNumber.ForeColor = Color.FromArgb(63, 43, 36);
            lblPhoneNumber.Location = new Point(12, 164);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(233, 41);
            lblPhoneNumber.TabIndex = 2;
            lblPhoneNumber.Text = "Phone number:";
            lblPhoneNumber.Click += label4_Click;
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Nirmala UI", 18F, FontStyle.Bold);
            lblStudentName.ForeColor = Color.FromArgb(63, 43, 36);
            lblStudentName.Location = new Point(12, 96);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(228, 41);
            lblStudentName.TabIndex = 1;
            lblStudentName.Text = "Student Name:";
            // 
            // lblStudentInfo
            // 
            lblStudentInfo.AutoSize = true;
            lblStudentInfo.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentInfo.ForeColor = Color.FromArgb(63, 43, 36);
            lblStudentInfo.Location = new Point(12, 37);
            lblStudentInfo.Name = "lblStudentInfo";
            lblStudentInfo.Size = new Size(177, 41);
            lblStudentInfo.TabIndex = 0;
            lblStudentInfo.Text = "Student ID:";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(211, 187, 177);
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.FromArgb(63, 43, 36);
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.DisabledLinkColor = Color.White;
            linkLabel1.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(789, 284);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Padding = new Padding(15);
            linkLabel1.Size = new Size(280, 61);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Contact information";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureUniversity
            // 
            pictureUniversity.Image = Properties.Resources.img_1;
            pictureUniversity.Location = new Point(12, 273);
            pictureUniversity.Name = "pictureUniversity";
            pictureUniversity.Size = new Size(712, 380);
            pictureUniversity.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureUniversity.TabIndex = 3;
            pictureUniversity.TabStop = false;
            // 
            // lblAdminInfo
            // 
            lblAdminInfo.AutoSize = true;
            lblAdminInfo.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdminInfo.ForeColor = Color.FromArgb(63, 43, 36);
            lblAdminInfo.Location = new Point(789, 379);
            lblAdminInfo.Name = "lblAdminInfo";
            lblAdminInfo.Size = new Size(312, 108);
            lblAdminInfo.TabIndex = 4;
            lblAdminInfo.Text = "Timing: MON - FRI\r\n08:00 AM - 04:00 PM\r\nPhone: + 475555555\r\nEmail: admin@university.com";
            lblAdminInfo.Visible = false;
            lblAdminInfo.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(195, 191, 179);
            ClientSize = new Size(1125, 673);
            Controls.Add(lblAdminInfo);
            Controls.Add(pictureUniversity);
            Controls.Add(linkLabel1);
            Controls.Add(lnkContactAdmin);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            lnkContactAdmin.ResumeLayout(false);
            lnkContactAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStudentPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureUniversity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel lnkContactAdmin;
        private PictureBox picStudentPhoto;
        private Button btnCancel;
        private Button btnSearch;
        private TextBox txtPhoneNumber;
        private TextBox txtStudentName;
        private TextBox txtStudentID;
        private Label lblPhoneNumber;
        private Label lblStudentName;
        private Label lblStudentInfo;
        private LinkLabel linkLabel1;
        private PictureBox pictureUniversity;
        private Label lblAdminInfo;
    }
}
