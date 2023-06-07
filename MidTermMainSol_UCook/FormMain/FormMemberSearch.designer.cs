namespace FormMain
{
    partial class FormMemberSearch
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxPK = new System.Windows.Forms.TextBox();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxPhone = new System.Windows.Forms.TextBox();
			this.textBoxNickname = new System.Windows.Forms.TextBox();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.buttonClear = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.totalrows = new System.Windows.Forms.Label();
			this.comboBoxOrderby = new System.Windows.Forms.ComboBox();
			this.toast1 = new FormItem.Toast();
			this.Checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.col_member_pk = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_registertime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_Nickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_profilephoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_Self_Intro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_received_person_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_received_person_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col_received_person_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dateTimePickerStart
			// 
			this.dateTimePickerStart.CustomFormat = "";
			this.dateTimePickerStart.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerStart.Location = new System.Drawing.Point(1102, 68);
			this.dateTimePickerStart.Name = "dateTimePickerStart";
			this.dateTimePickerStart.Size = new System.Drawing.Size(126, 27);
			this.dateTimePickerStart.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label7.Location = new System.Drawing.Point(1008, 71);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(73, 20);
			this.label7.TabIndex = 43;
			this.label7.Text = "註冊時間";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.Location = new System.Drawing.Point(498, 68);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 20);
			this.label5.TabIndex = 41;
			this.label5.Text = "會員PK";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(255, 68);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 20);
			this.label4.TabIndex = 42;
			this.label4.Text = "會員信箱";
			// 
			// textBoxPK
			// 
			this.textBoxPK.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxPK.Location = new System.Drawing.Point(592, 65);
			this.textBoxPK.Name = "textBoxPK";
			this.textBoxPK.Size = new System.Drawing.Size(126, 27);
			this.textBoxPK.TabIndex = 2;
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxEmail.Location = new System.Drawing.Point(349, 65);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(126, 27);
			this.textBoxEmail.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label6.Location = new System.Drawing.Point(744, 71);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(73, 20);
			this.label6.TabIndex = 36;
			this.label6.Text = "會員電話";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(12, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "會員暱稱";
			// 
			// textBoxPhone
			// 
			this.textBoxPhone.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxPhone.Location = new System.Drawing.Point(838, 68);
			this.textBoxPhone.Name = "textBoxPhone";
			this.textBoxPhone.Size = new System.Drawing.Size(126, 27);
			this.textBoxPhone.TabIndex = 3;
			// 
			// textBoxNickname
			// 
			this.textBoxNickname.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxNickname.Location = new System.Drawing.Point(106, 65);
			this.textBoxNickname.Name = "textBoxNickname";
			this.textBoxNickname.Size = new System.Drawing.Size(126, 27);
			this.textBoxNickname.TabIndex = 0;
			// 
			// buttonSearch
			// 
			this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(116)))), ((int)(((byte)(198)))));
			this.buttonSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonSearch.ForeColor = System.Drawing.Color.White;
			this.buttonSearch.Location = new System.Drawing.Point(1222, 170);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(105, 31);
			this.buttonSearch.TabIndex = 5;
			this.buttonSearch.Text = "查詢";
			this.buttonSearch.UseVisualStyleBackColor = false;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// buttonClear
			// 
			this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
			this.buttonClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonClear.Location = new System.Drawing.Point(1111, 170);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(105, 31);
			this.buttonClear.TabIndex = 47;
			this.buttonClear.Text = "清除";
			this.buttonClear.UseVisualStyleBackColor = false;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Checkbox,
            this.col_member_pk,
            this.col_email,
            this.col_password,
            this.col_registertime,
            this.col_Nickname,
            this.col_profilephoto,
            this.col_Self_Intro,
            this.col_received_person_name,
            this.col_received_person_phone,
            this.col_received_person_address});
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridView1.Location = new System.Drawing.Point(15, 245);
			this.dataGridView1.Name = "dataGridView1";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1363, 221);
			this.dataGridView1.TabIndex = 49;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// totalrows
			// 
			this.totalrows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.totalrows.AutoSize = true;
			this.totalrows.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.totalrows.Location = new System.Drawing.Point(1222, 215);
			this.totalrows.Name = "totalrows";
			this.totalrows.Size = new System.Drawing.Size(45, 20);
			this.totalrows.TabIndex = 50;
			this.totalrows.Text = "總共:";
			// 
			// comboBoxOrderby
			// 
			this.comboBoxOrderby.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxOrderby.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxOrderby.FormattingEnabled = true;
			this.comboBoxOrderby.Items.AddRange(new object[] {
            "註冊時間由遠至近",
            "註冊時間由近至遠"});
			this.comboBoxOrderby.Location = new System.Drawing.Point(1060, 211);
			this.comboBoxOrderby.Name = "comboBoxOrderby";
			this.comboBoxOrderby.Size = new System.Drawing.Size(156, 28);
			this.comboBoxOrderby.TabIndex = 6;
			this.comboBoxOrderby.Text = "排序";
			// 
			// toast1
			// 
			this.toast1.AMessage = "label1";
			this.toast1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.toast1.Location = new System.Drawing.Point(12, 430);
			this.toast1.Name = "toast1";
			this.toast1.Size = new System.Drawing.Size(203, 55);
			this.toast1.TabIndex = 52;
			this.toast1.Visible = false;
			// 
			// Checkbox
			// 
			this.Checkbox.HeaderText = "請選擇";
			this.Checkbox.Name = "Checkbox";
			// 
			// col_member_pk
			// 
			this.col_member_pk.DataPropertyName = "Member_ID";
			this.col_member_pk.HeaderText = "會員PK";
			this.col_member_pk.Name = "col_member_pk";
			// 
			// col_email
			// 
			this.col_email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.col_email.DataPropertyName = "Email";
			this.col_email.HeaderText = "會員郵件";
			this.col_email.Name = "col_email";
			// 
			// col_password
			// 
			this.col_password.DataPropertyName = "Password";
			this.col_password.HeaderText = "密碼";
			this.col_password.Name = "col_password";
			this.col_password.Visible = false;
			// 
			// col_registertime
			// 
			this.col_registertime.DataPropertyName = "Register_Time";
			this.col_registertime.HeaderText = "註冊時間";
			this.col_registertime.Name = "col_registertime";
			// 
			// col_Nickname
			// 
			this.col_Nickname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.col_Nickname.DataPropertyName = "Nickname";
			this.col_Nickname.HeaderText = "會員暱稱";
			this.col_Nickname.Name = "col_Nickname";
			// 
			// col_profilephoto
			// 
			this.col_profilephoto.DataPropertyName = "Profile_Photo";
			this.col_profilephoto.HeaderText = "頭貼";
			this.col_profilephoto.Name = "col_profilephoto";
			this.col_profilephoto.Visible = false;
			// 
			// col_Self_Intro
			// 
			this.col_Self_Intro.DataPropertyName = "Self_Intro";
			this.col_Self_Intro.HeaderText = "自我介紹";
			this.col_Self_Intro.Name = "col_Self_Intro";
			this.col_Self_Intro.Visible = false;
			// 
			// col_received_person_name
			// 
			this.col_received_person_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.col_received_person_name.DataPropertyName = "Received_Person_Name";
			this.col_received_person_name.HeaderText = "收件人姓名";
			this.col_received_person_name.Name = "col_received_person_name";
			// 
			// col_received_person_phone
			// 
			this.col_received_person_phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.col_received_person_phone.DataPropertyName = "Received_Person_Phone";
			this.col_received_person_phone.HeaderText = "收件人電話";
			this.col_received_person_phone.Name = "col_received_person_phone";
			// 
			// col_received_person_address
			// 
			this.col_received_person_address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.col_received_person_address.DataPropertyName = "Received_Person_Address";
			this.col_received_person_address.HeaderText = "收件人地址";
			this.col_received_person_address.Name = "col_received_person_address";
			// 
			// FormMemberSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(230)))));
			this.ClientSize = new System.Drawing.Size(1387, 497);
			this.Controls.Add(this.toast1);
			this.Controls.Add(this.comboBoxOrderby);
			this.Controls.Add(this.totalrows);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.dateTimePickerStart);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxPK);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxPhone);
			this.Controls.Add(this.textBoxNickname);
			this.Name = "FormMemberSearch";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "會員管理";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FormMember_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPK;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxNickname;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label totalrows;
        private System.Windows.Forms.ComboBox comboBoxOrderby;
		private FormItem.Toast toast1;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Checkbox;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_member_pk;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_email;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_password;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_registertime;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_Nickname;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_profilephoto;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_Self_Intro;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_received_person_name;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_received_person_phone;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_received_person_address;
	}
}