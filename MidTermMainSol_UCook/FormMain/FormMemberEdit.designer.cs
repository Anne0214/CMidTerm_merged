namespace FormMain
{
    partial class FormMemberEdit
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textBoxProfile_Photo = new System.Windows.Forms.TextBox();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.textBoxEditableReceived_Person_Phone = new TextBoxAndTable.TextBoxEditable();
            this.textBoxEditableReceived_Person_Address = new TextBoxAndTable.TextBoxEditable();
            this.textBoxEditableReceived_Person_Name = new TextBoxAndTable.TextBoxEditable();
            this.textBoxEditablePhone = new TextBoxAndTable.TextBoxEditable();
            this.textBoxWordLimitNickname = new TextBoxAndTable.TextBoxWordLimit();
            this.textBoxCannotBeChangedEmail = new TextBoxAndTable.TextBoxCannotBeChanged();
            this.textBoxCannotBeChangedMember_ID = new TextBoxAndTable.TextBoxCannotBeChanged();
            this.textBoxMultilineSelfIntro = new TextBoxAndTable.TextBoxMultiline();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(12, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(93, 560);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "儲存";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(702, 211);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(200, 200);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // textBoxProfile_Photo
            // 
            this.textBoxProfile_Photo.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxProfile_Photo.Location = new System.Drawing.Point(702, 417);
            this.textBoxProfile_Photo.Name = "textBoxProfile_Photo";
            this.textBoxProfile_Photo.Size = new System.Drawing.Size(200, 27);
            this.textBoxProfile_Photo.TabIndex = 7;
            // 
            // buttonUpload
            // 
            this.buttonUpload.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonUpload.Location = new System.Drawing.Point(908, 417);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(78, 27);
            this.buttonUpload.TabIndex = 8;
            this.buttonUpload.Text = "上傳";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // textBoxEditableReceived_Person_Phone
            // 
            this.textBoxEditableReceived_Person_Phone.afiledName = "收件人電話";
            this.textBoxEditableReceived_Person_Phone.afiledValue = "";
            this.textBoxEditableReceived_Person_Phone.Location = new System.Drawing.Point(12, 509);
            this.textBoxEditableReceived_Person_Phone.Name = "textBoxEditableReceived_Person_Phone";
            this.textBoxEditableReceived_Person_Phone.Size = new System.Drawing.Size(650, 40);
            this.textBoxEditableReceived_Person_Phone.TabIndex = 2;
            // 
            // textBoxEditableReceived_Person_Address
            // 
            this.textBoxEditableReceived_Person_Address.afiledName = "收件人地址";
            this.textBoxEditableReceived_Person_Address.afiledValue = "";
            this.textBoxEditableReceived_Person_Address.Location = new System.Drawing.Point(12, 463);
            this.textBoxEditableReceived_Person_Address.Name = "textBoxEditableReceived_Person_Address";
            this.textBoxEditableReceived_Person_Address.Size = new System.Drawing.Size(650, 40);
            this.textBoxEditableReceived_Person_Address.TabIndex = 2;
            // 
            // textBoxEditableReceived_Person_Name
            // 
            this.textBoxEditableReceived_Person_Name.afiledName = "收件人姓名";
            this.textBoxEditableReceived_Person_Name.afiledValue = "";
            this.textBoxEditableReceived_Person_Name.Location = new System.Drawing.Point(12, 417);
            this.textBoxEditableReceived_Person_Name.Name = "textBoxEditableReceived_Person_Name";
            this.textBoxEditableReceived_Person_Name.Size = new System.Drawing.Size(650, 40);
            this.textBoxEditableReceived_Person_Name.TabIndex = 2;
            // 
            // textBoxEditablePhone
            // 
            this.textBoxEditablePhone.afiledName = "會員電話";
            this.textBoxEditablePhone.afiledValue = "";
            this.textBoxEditablePhone.Location = new System.Drawing.Point(12, 150);
            this.textBoxEditablePhone.Name = "textBoxEditablePhone";
            this.textBoxEditablePhone.Size = new System.Drawing.Size(650, 40);
            this.textBoxEditablePhone.TabIndex = 2;
            // 
            // textBoxWordLimitNickname
            // 
            this.textBoxWordLimitNickname.afiledMaxCount = 20;
            this.textBoxWordLimitNickname.afiledName = "會員暱稱";
            this.textBoxWordLimitNickname.afiledValue = "";
            this.textBoxWordLimitNickname.Location = new System.Drawing.Point(12, 104);
            this.textBoxWordLimitNickname.Name = "textBoxWordLimitNickname";
            this.textBoxWordLimitNickname.Size = new System.Drawing.Size(650, 40);
            this.textBoxWordLimitNickname.TabIndex = 1;
            // 
            // textBoxCannotBeChangedEmail
            // 
            this.textBoxCannotBeChangedEmail.afiledName = "會員信箱";
            this.textBoxCannotBeChangedEmail.afiledValue = "";
            this.textBoxCannotBeChangedEmail.Location = new System.Drawing.Point(12, 58);
            this.textBoxCannotBeChangedEmail.Name = "textBoxCannotBeChangedEmail";
            this.textBoxCannotBeChangedEmail.Size = new System.Drawing.Size(650, 40);
            this.textBoxCannotBeChangedEmail.TabIndex = 0;
            // 
            // textBoxCannotBeChangedMember_ID
            // 
            this.textBoxCannotBeChangedMember_ID.afiledName = "會員PK";
            this.textBoxCannotBeChangedMember_ID.afiledValue = "";
            this.textBoxCannotBeChangedMember_ID.Location = new System.Drawing.Point(12, 12);
            this.textBoxCannotBeChangedMember_ID.Name = "textBoxCannotBeChangedMember_ID";
            this.textBoxCannotBeChangedMember_ID.Size = new System.Drawing.Size(650, 40);
            this.textBoxCannotBeChangedMember_ID.TabIndex = 0;
            // 
            // textBoxMultilineSelfIntro
            // 
            this.textBoxMultilineSelfIntro.afiledMaxCount = 200;
            this.textBoxMultilineSelfIntro.afiledName = "自我介紹";
            this.textBoxMultilineSelfIntro.afiledValue = "";
            this.textBoxMultilineSelfIntro.Location = new System.Drawing.Point(12, 196);
            this.textBoxMultilineSelfIntro.Name = "textBoxMultilineSelfIntro";
            this.textBoxMultilineSelfIntro.Size = new System.Drawing.Size(890, 215);
            this.textBoxMultilineSelfIntro.TabIndex = 9;
            // 
            // FormEditMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 594);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.textBoxProfile_Photo);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxEditableReceived_Person_Phone);
            this.Controls.Add(this.textBoxEditableReceived_Person_Address);
            this.Controls.Add(this.textBoxEditableReceived_Person_Name);
            this.Controls.Add(this.textBoxEditablePhone);
            this.Controls.Add(this.textBoxWordLimitNickname);
            this.Controls.Add(this.textBoxCannotBeChangedEmail);
            this.Controls.Add(this.textBoxCannotBeChangedMember_ID);
            this.Controls.Add(this.textBoxMultilineSelfIntro);
            this.Name = "FormEditMember";
            this.Text = "FormEditMember";
            this.Load += new System.EventHandler(this.FormEditMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBoxAndTable.TextBoxCannotBeChanged textBoxCannotBeChangedMember_ID;
        private TextBoxAndTable.TextBoxCannotBeChanged textBoxCannotBeChangedEmail;
        private TextBoxAndTable.TextBoxWordLimit textBoxWordLimitNickname;
        private TextBoxAndTable.TextBoxEditable textBoxEditablePhone;
        private TextBoxAndTable.TextBoxEditable textBoxEditableReceived_Person_Name;
        private TextBoxAndTable.TextBoxEditable textBoxEditableReceived_Person_Address;
        private TextBoxAndTable.TextBoxEditable textBoxEditableReceived_Person_Phone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox textBoxProfile_Photo;
        private System.Windows.Forms.Button buttonUpload;
        private TextBoxAndTable.TextBoxMultiline textBoxMultilineSelfIntro;
    }
}