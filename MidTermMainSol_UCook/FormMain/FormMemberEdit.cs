using FormItem;
using ISpan2023.UCook.BackEnd;
using ISpan2023.UCook.BackEnd.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMain
{
    public partial class FormMemberEdit : Form
    {
        private readonly string _member_id;
        public FormMemberEdit(string member_id)
        {
            InitializeComponent();
            _member_id = member_id;
        }

        private void FormEditMember_Load(object sender, EventArgs e)
        {
            //FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            var repo = new MemberRepository();
            var dto = repo.Get(_member_id);
            string picLocation = dto.Profile_Photo;
            //
            textBoxCannotBeChangedMember_ID.afiledValue = dto.Member_ID;
            textBoxCannotBeChangedEmail.afiledValue= dto.Email;
            textBoxWordLimitNickname.afiledValue = dto.Nickname;
            textBoxEditablePhone.afiledValue = dto.Received_Person_Phone;
            textBoxMultilineSelfIntro.afiledValue = dto.Self_Intro;
            textBoxEditableReceived_Person_Name.afiledValue = dto.Received_Person_Name;
            textBoxEditableReceived_Person_Address.afiledValue = dto.Received_Person_Address;
            textBoxEditableReceived_Person_Phone.afiledValue = dto.Received_Person_Phone;

            pictureBox.Image = Image.FromFile(picLocation);
        }

        private void button1_Click(object sender, EventArgs e)//取消不需要呼叫父頁面Display()
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string _pk = textBoxCannotBeChangedMember_ID.afiledValue;
            string _nickname = textBoxWordLimitNickname.afiledValue;
            //string _phone = textBoxEditablePhone.afiledValue;
            string _self_info = textBoxMultilineSelfIntro.afiledValue;
            string _rpn = textBoxEditableReceived_Person_Name.afiledValue;
            string _rpa = textBoxEditableReceived_Person_Address.afiledValue;
            string _rpp = textBoxEditablePhone.afiledValue;
            string _profile_photo = textBoxProfile_Photo.Text;

            //Check All Errors
            List<bool> errors = new List<bool>();
            bool hasError = false;

            //1. 檢查會員暱稱是否符合輸入條件?
            string nickname = string.Empty;
            hasError = CheckInput.CheckString(textBoxWordLimitNickname, out nickname);
            errors.Add(hasError);
            //2. phone
            string phone = string.Empty;
            hasError = CheckInput.CheckString(textBoxEditablePhone, out phone);
            errors.Add(hasError);
            hasError = CheckInput.CheckStringLength(textBoxEditablePhone, 10, out phone);//電話長度
            errors.Add(hasError);

            //3.self info
            string selfintro = string.Empty;
            hasError = CheckInput.CheckString(textBoxMultilineSelfIntro, out selfintro);
            errors.Add(hasError);

            //4.Received_Person_Name
            string rpn = string.Empty;
            hasError = CheckInput.CheckString(textBoxEditableReceived_Person_Name, out rpn);
            errors.Add(hasError);

            string rpa = string.Empty;
            hasError = CheckInput.CheckString(textBoxEditableReceived_Person_Address, out rpa);
            errors.Add(hasError);

            string rpp = string.Empty;
            hasError = CheckInput.CheckString(textBoxEditableReceived_Person_Phone, out rpp);
            errors.Add(hasError);
            hasError = CheckInput.CheckStringLength(textBoxEditableReceived_Person_Phone, 10, out rpp);//電話長度
            errors.Add(hasError);

            if (errors.Contains(true)) //*
            {
                MessageBox.Show("資料輸入有誤，請輸入正確資料");
                return; 
            } 
            //
            var repo = new MemberRepository();
            int rows = repo.Update(_pk, _nickname, _self_info, _rpn, _rpa, _rpp, _profile_photo);
            if (rows > 0)
            {
                INotify parent = this.Owner as INotify;
                parent.Success("更新成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("更新失敗!請連繫後台人員協助檢查");
            }
        }
        private void buttonUpload_Click(object sender, EventArgs e)
        {
            ImageUpload img = new ImageUpload();
            string picLocation =  img.UploadIMG();//Get picture
            //如果拿到的string不是空白(User可能取消匯入圖片)
            if (string.IsNullOrEmpty(picLocation) == false) 
            {
                pictureBox.Image = Image.FromFile(picLocation);
                string Profile_Photo = img.SaveImage(picLocation);
                textBoxProfile_Photo.Text = Profile_Photo;
            }
        }

    }
}
