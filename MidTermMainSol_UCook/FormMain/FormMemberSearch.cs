using ISpan2023.UCook.BackEnd;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FormMain
{
    public partial class FormMemberSearch : Form, INotify//加入IDto實作
    {
        
        public FormMemberSearch()
        {
            InitializeComponent();
            this.AutoScroll = true;
            dataGridView1.BackgroundColor = Color.FromArgb(255, 255, 253); //背景色
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(237, 243, 255); //雙行色
        }
        private void FormMember_Load(object sender, EventArgs e)
        {
            Display();
        }
        
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxNickname.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxPK.Text = string.Empty;
            textBoxPhone.Text = string.Empty;
            dateTimePickerStart.Value = DateTime.Now;
        }
        private DataGridViewColumn setCols(string HeaderText, string name) 
        {
            DataGridViewColumn btn = new DataGridViewColumn();
            btn.HeaderText = HeaderText;
            btn.Name = name;
            return btn;
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Display();
        }
        public void Display() //實作Display()
        {
            if (dataGridView1.Columns.Contains("btnUpdate")) 
            {
                dataGridView1.Columns.Remove("btnUpdate");
            }
            string nickname = textBoxNickname.Text;
            string email = textBoxEmail.Text;
            string member_pk = textBoxPK.Text;
            string phone = textBoxPhone.Text;
            string reg_timeStart = dateTimePickerStart.Value.ToString("yyyy-MM-dd");//日期轉換成與資料庫一致
            string orderbyInfo = comboBoxOrderby.Text;

            var repo = new MemberRepository();
            var data = repo.Search(nickname, email, member_pk, phone, reg_timeStart, orderbyInfo);

            string total_rows_count = data.Count.ToString();
            totalrows.Text = $"總共: {total_rows_count}筆資料";
            DataGridViewButtonColumn btn_add = ButtonColumn();

            dataGridView1.Columns.Add(btn_add);
            dataGridView1.DataSource = data;
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 16F, GraphicsUnit.Pixel);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }//按到Header
            if (e.ColumnIndex == 1) //User對該筆資料要進行修改
            {   //拿e.RowIndex列的會員PK
                string member_id = dataGridView1.Rows[e.RowIndex].Cells["col_member_pk"].Value.ToString();//傳給Get() Method
                FormMemberEdit frm = new FormMemberEdit(member_id);
                frm.Owner = this;//方可呼叫Display()
                frm.Show();//此頁面關閉之前不得show
            }
        }
        private DataGridViewButtonColumn ButtonColumn()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "操作";
            btn.Text = "修改";
            btn.Name = "btnUpdate";
            btn.UseColumnTextForButtonValue = true;
            return btn;
        }


		public void Success(string message)
		{
			toast1.AMessage = message;
			toast1.ShowUp();
            Display();
		}
	}
}
