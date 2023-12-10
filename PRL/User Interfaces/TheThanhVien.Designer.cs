namespace PRL
{
    partial class TheThanhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheThanhVien));
            Panel_TheTv = new Panel();
            label2 = new Label();
            Txt_Points = new TextBox();
            pictureBox2 = new PictureBox();
            Combo_Tier = new ComboBox();
            BTN_Reset = new Button();
            Txt_DieDate = new TextBox();
            pictureBox3 = new PictureBox();
            Txt_Available = new TextBox();
            pictureBox4 = new PictureBox();
            Txt_Phone = new TextBox();
            pictureBox1 = new PictureBox();
            BTN_CreateNew = new Button();
            BTN_Delete = new Button();
            BTN_Update = new Button();
            label1 = new Label();
            label14 = new Label();
            label13 = new Label();
            label7 = new Label();
            label3 = new Label();
            Screen_MemberCard = new DataGridView();
            Panel_TheTv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Screen_MemberCard).BeginInit();
            SuspendLayout();
            // 
            // Panel_TheTv
            // 
            Panel_TheTv.Controls.Add(label2);
            Panel_TheTv.Controls.Add(Txt_Points);
            Panel_TheTv.Controls.Add(pictureBox2);
            Panel_TheTv.Controls.Add(Combo_Tier);
            Panel_TheTv.Controls.Add(BTN_Reset);
            Panel_TheTv.Controls.Add(Txt_DieDate);
            Panel_TheTv.Controls.Add(pictureBox3);
            Panel_TheTv.Controls.Add(Txt_Available);
            Panel_TheTv.Controls.Add(pictureBox4);
            Panel_TheTv.Controls.Add(Txt_Phone);
            Panel_TheTv.Controls.Add(pictureBox1);
            Panel_TheTv.Controls.Add(BTN_CreateNew);
            Panel_TheTv.Controls.Add(BTN_Delete);
            Panel_TheTv.Controls.Add(BTN_Update);
            Panel_TheTv.Controls.Add(label1);
            Panel_TheTv.Controls.Add(label14);
            Panel_TheTv.Controls.Add(label13);
            Panel_TheTv.Controls.Add(label7);
            Panel_TheTv.Controls.Add(label3);
            Panel_TheTv.Controls.Add(Screen_MemberCard);
            Panel_TheTv.Location = new Point(0, 0);
            Panel_TheTv.Name = "Panel_TheTv";
            Panel_TheTv.Size = new Size(820, 571);
            Panel_TheTv.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(220, 535);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 102;
            label2.Text = "Điểm:";
            // 
            // Txt_Points
            // 
            Txt_Points.BackColor = Color.FromArgb(255, 138, 0);
            Txt_Points.BorderStyle = BorderStyle.None;
            Txt_Points.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Points.ForeColor = Color.Black;
            Txt_Points.Location = new Point(290, 538);
            Txt_Points.Name = "Txt_Points";
            Txt_Points.Size = new Size(239, 22);
            Txt_Points.TabIndex = 5;
            Txt_Points.KeyPress += Txt_Points_KeyPress;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(286, 536);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(247, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 100;
            pictureBox2.TabStop = false;
            // 
            // Combo_Tier
            // 
            Combo_Tier.BackColor = Color.FromArgb(255, 138, 0);
            Combo_Tier.DropDownStyle = ComboBoxStyle.DropDownList;
            Combo_Tier.FlatStyle = FlatStyle.Flat;
            Combo_Tier.ForeColor = SystemColors.Control;
            Combo_Tier.FormattingEnabled = true;
            Combo_Tier.Items.AddRange(new object[] { "Tiềm năng", "Đồng", "Bạc", "Vàng", "Kim cương", "Bạch kim" });
            Combo_Tier.Location = new Point(286, 449);
            Combo_Tier.Name = "Combo_Tier";
            Combo_Tier.Size = new Size(247, 24);
            Combo_Tier.TabIndex = 2;
            // 
            // BTN_Reset
            // 
            BTN_Reset.BackColor = Color.FromArgb(112, 88, 61);
            BTN_Reset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_Reset.ForeColor = Color.White;
            BTN_Reset.Location = new Point(539, 533);
            BTN_Reset.Name = "BTN_Reset";
            BTN_Reset.Size = new Size(153, 33);
            BTN_Reset.TabIndex = 9;
            BTN_Reset.Text = "Đặt lại";
            BTN_Reset.UseVisualStyleBackColor = false;
            BTN_Reset.Click += BTN_Reset_Click;
            // 
            // Txt_DieDate
            // 
            Txt_DieDate.BackColor = Color.FromArgb(255, 138, 0);
            Txt_DieDate.BorderStyle = BorderStyle.None;
            Txt_DieDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_DieDate.ForeColor = Color.Black;
            Txt_DieDate.Location = new Point(290, 509);
            Txt_DieDate.Name = "Txt_DieDate";
            Txt_DieDate.Size = new Size(239, 22);
            Txt_DieDate.TabIndex = 4;
            Txt_DieDate.KeyPress += Txt_DieDate_KeyPress;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(286, 507);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(247, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 95;
            pictureBox3.TabStop = false;
            // 
            // Txt_Available
            // 
            Txt_Available.BackColor = Color.FromArgb(255, 138, 0);
            Txt_Available.BorderStyle = BorderStyle.None;
            Txt_Available.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Available.ForeColor = Color.Black;
            Txt_Available.Location = new Point(290, 479);
            Txt_Available.Name = "Txt_Available";
            Txt_Available.Size = new Size(239, 22);
            Txt_Available.TabIndex = 3;
            Txt_Available.KeyPress += Txt_Available_KeyPress;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(286, 477);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(247, 26);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 92;
            pictureBox4.TabStop = false;
            // 
            // Txt_Phone
            // 
            Txt_Phone.BackColor = Color.FromArgb(255, 138, 0);
            Txt_Phone.BorderStyle = BorderStyle.None;
            Txt_Phone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Phone.ForeColor = Color.Black;
            Txt_Phone.Location = new Point(290, 420);
            Txt_Phone.Name = "Txt_Phone";
            Txt_Phone.Size = new Size(239, 22);
            Txt_Phone.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(286, 418);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // BTN_CreateNew
            // 
            BTN_CreateNew.BackColor = Color.FromArgb(112, 88, 61);
            BTN_CreateNew.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_CreateNew.ForeColor = Color.White;
            BTN_CreateNew.Location = new Point(539, 416);
            BTN_CreateNew.Name = "BTN_CreateNew";
            BTN_CreateNew.Size = new Size(153, 33);
            BTN_CreateNew.TabIndex = 6;
            BTN_CreateNew.Text = "Tạo thẻ";
            BTN_CreateNew.UseVisualStyleBackColor = false;
            BTN_CreateNew.Click += BTN_CreateNew_Click;
            // 
            // BTN_Delete
            // 
            BTN_Delete.BackColor = Color.FromArgb(112, 88, 61);
            BTN_Delete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_Delete.ForeColor = Color.White;
            BTN_Delete.Location = new Point(539, 494);
            BTN_Delete.Name = "BTN_Delete";
            BTN_Delete.Size = new Size(153, 33);
            BTN_Delete.TabIndex = 8;
            BTN_Delete.Text = "Xóa";
            BTN_Delete.UseVisualStyleBackColor = false;
            BTN_Delete.Click += BTN_Delete_Click;
            // 
            // BTN_Update
            // 
            BTN_Update.BackColor = Color.FromArgb(112, 88, 61);
            BTN_Update.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_Update.ForeColor = Color.White;
            BTN_Update.Location = new Point(539, 455);
            BTN_Update.Name = "BTN_Update";
            BTN_Update.Size = new Size(153, 33);
            BTN_Update.TabIndex = 7;
            BTN_Update.Text = "Cập nhật";
            BTN_Update.UseVisualStyleBackColor = false;
            BTN_Update.Click += BTN_Update_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(149, 508);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 81;
            label1.Text = "Ngày Hết hạn:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(146, 476);
            label14.Name = "label14";
            label14.Size = new Size(134, 25);
            label14.TabIndex = 82;
            label14.Text = "Ngày Hiệu lực:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(131, 448);
            label13.Name = "label13";
            label13.Size = new Size(149, 25);
            label13.TabIndex = 83;
            label13.Text = "Loại Thành viên:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(128, 419);
            label7.Name = "label7";
            label7.Size = new Size(156, 25);
            label7.TabIndex = 84;
            label7.Text = "SĐT Khách Hàng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(8, 7);
            label3.Name = "label3";
            label3.Size = new Size(224, 37);
            label3.TabIndex = 50;
            label3.Text = "Thẻ Thành Viên";
            // 
            // Screen_MemberCard
            // 
            Screen_MemberCard.AllowUserToAddRows = false;
            Screen_MemberCard.AllowUserToDeleteRows = false;
            Screen_MemberCard.AllowUserToResizeColumns = false;
            Screen_MemberCard.AllowUserToResizeRows = false;
            Screen_MemberCard.BackgroundColor = SystemColors.ButtonHighlight;
            Screen_MemberCard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Screen_MemberCard.EditMode = DataGridViewEditMode.EditProgrammatically;
            Screen_MemberCard.Location = new Point(3, 51);
            Screen_MemberCard.MultiSelect = false;
            Screen_MemberCard.Name = "Screen_MemberCard";
            Screen_MemberCard.RowHeadersWidth = 51;
            Screen_MemberCard.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            Screen_MemberCard.RowTemplate.Height = 29;
            Screen_MemberCard.Size = new Size(814, 354);
            Screen_MemberCard.TabIndex = 0;
            Screen_MemberCard.CellClick += Screen_MemberCard_CellClick;
            // 
            // TheThanhVien
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(190, 0, 0);
            ClientSize = new Size(820, 571);
            Controls.Add(Panel_TheTv);
            Name = "TheThanhVien";
            Text = "TheThanhVien";
            Panel_TheTv.ResumeLayout(false);
            Panel_TheTv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Screen_MemberCard).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel_TheTv;
        private DataGridView Screen_MemberCard;
        private Label label3;
        private Label label1;
        private Label label14;
        private Label label13;
        private Label label7;
        private TextBox Txt_Phone;
        private PictureBox pictureBox1;
        private Button BTN_Delete;
        private Button BTN_Update;
        private TextBox Txt_DieDate;
        private PictureBox pictureBox3;
        private TextBox Txt_Available;
        private PictureBox pictureBox4;
        private Button BTN_Reset;
        private ComboBox Combo_Tier;
        private TextBox Txt_Points;
        private PictureBox pictureBox2;
        private Label label2;
        private Button BTN_CreateNew;
    }
}