
using ISpan2023.UCook.BackEnd.Dtos;
using ISpan2023.UCook.BackEnd.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormMain
{
    public partial class FormMarketingEdit : Form
    {
        private readonly string _marketingId;
        private const int MaxCharacterCount = 20;
        public int SelectedPageIndex { get; private set; }

        public event EventHandler<int> PageIndexChanged; // 新增事件

        public FormMarketingEdit(string marketingId,int selectedPageIndex)
		{
            _marketingId = marketingId;
            SelectedPageIndex = selectedPageIndex;  


            InitializeComponent();
            //驗證標題長度
            textBoxTitle.TextChanged += textBoxTitle_TextChanged;
            //驗證標題空值
            textBoxTitle.Validating += textBoxTitle_Validating;
            //驗證網址格式
            textBoxURL.Validating += textBoxURL_Validating;
            //驗證圖片網址空值
            textBoxUpload.Validating += textBoxUpload_Validating;

            this.AutoScroll = true;
			
            
            comboBox1.Items.Add("首頁A-1");
            comboBox1.Items.Add("首頁A-2");
            comboBox1.Items.Add("首頁A-3");
            comboBox1.Items.Add("搜尋結果頁B-1");
            comboBox1.Items.Add("搜尋結果頁B-2");
            comboBox1.Items.Add("搜尋結果頁B-3");
            comboBox1.Items.Add("個人頁C");

            // 根據 SelectedPageIndex 設置預選項
            comboBox1.SelectedIndex = selectedPageIndex;



            //combobox選項
            //string[] options = 
            //    { "請選擇","首頁A-1", "首頁A-2", "首頁A-3", "搜尋結果頁B-1", "搜尋結果頁B-2", "搜尋結果頁B-3", "個人頁C" };
            //comboBox1.Items.AddRange(options);
            ////預設選項'首頁A-1'
            //comboBox1.SelectedIndex =1;


        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        { //標題長度
            if (textBoxTitle.Text.Length >= MaxCharacterCount)
            {
                textBoxTitle.Text = textBoxTitle.Text.Substring(0, MaxCharacterCount);
                textBoxTitle.SelectionStart = MaxCharacterCount;
                panel3.BackColor = Color.Red;
                label7.ForeColor = Color.Red;
            }
            else
            {
                panel3.BackColor = Color.Black;
                label7.ForeColor = Color.Black;
            }
            StringLength();
        }

        public void StringLength()
        {
            int currentCharacterCount = textBoxTitle.Text.Length;
            label7.Text = $"{currentCharacterCount}/{MaxCharacterCount}";
        }

        private void buttonSave_Click(object sender, EventArgs e)
		{
            try
            {   //precondition checks, 檢查各欄位值是否有填寫正確
                //panel有紅框就不給過
                if(panel1.BackColor==Color.Red)
                {return;}
                if (panel4.BackColor == Color.Red)
                { return; }
                if (panel3.BackColor == Color.Red)
                { return; }

                // 獲取選中的索引
                int selectedIndex = comboBox1.SelectedIndex;

                // 觸發 PageIndexChanged 事件，將選中的索引傳回給 FormSearch
                PageIndexChanged?.Invoke(this, selectedIndex);

                //蒐集表單欄位值到dto

                MarketingDetailDto dto = new MarketingDetailDto()
                {
                    AD_SPACE廣告版面_PK = comboBox1.SelectedIndex+1,
                    CAMPAIGN活動_PK = this._marketingId,
                    CAMPAIGN_NAME活動名稱 = textBoxTitle.Text,
                    URL連結 = textBoxURL.Text,
                    START_TIME開始時間 = dateTimePickerStart.Value,
                    END_TIME結束時間 = dateTimePickerEnd.Value,
                    AD_IMG廣告圖=textBoxUpload.Text,
                };
                

                //呼叫修改的方法
                var repo = new MarketingRepository();
                int rows=repo.Update(dto);

            }
			catch (Exception ex)
			{  //儲存失敗的狀況
				MessageBox.Show("儲存失敗，請稍後再試。失敗原因" + ex.Message);
				return;
			}

			//通知(儲存成功的狀況)
			INotify frm = this.Owner as INotify;
			frm.Success("儲存成功");

			//關閉本視窗
			this.Close();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private string GetSelectedPicture()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";// 設定檔案篩選器，只允許選擇圖片檔案（jpg、jpeg、png 格式）
            string picture = string.Empty;  // 初始化圖片路徑為空字串
            if (openFileDialog.ShowDialog() == DialogResult.OK) // 如果使用者選擇了檔案並按下「確定」按鈕
            {
                picture = openFileDialog.FileName;  // 取得選擇的圖片路徑
            }
            return picture;
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            string picture = GetSelectedPicture();
            pictureBoxImage.ImageLocation = picture;// 設定選擇的圖片給 ImageLocation 屬性
            textBoxUpload.Text = picture;             // 設定圖片路徑
        }


        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker startDateTimePicker = (DateTimePicker)sender;
            DateTime startDate = startDateTimePicker.Value;

            // 設置結束日期的最小值為開始日期的下一天
            dateTimePickerEnd.MinDate = startDate.AddDays(1);

            // 如果结束日期小於最小值，則將結束日期設置為最小值
            if (dateTimePickerEnd.Value < dateTimePickerEnd.MinDate)
            {
                dateTimePickerEnd.Value = dateTimePickerEnd.MinDate;
            }
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker endDateTimePicker = (DateTimePicker)sender;
            DateTime endDate = endDateTimePicker.Value;

        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            var repo = new MarketingRepository();
            MarketingDetailDto dto = repo.GetByPKId(_marketingId);
            if(dto == null)
            {
                MessageBox.Show("找不到符合的紀錄");
                return;
            }

            if (dto.AD_IMG廣告圖.Contains("http"))
            {
                this.pictureBoxImage.Image = Image.FromStream(System.Net.WebRequest.Create(dto.AD_IMG廣告圖).GetResponse().GetResponseStream());
            }
            else
            {
                string currentDir = Environment.CurrentDirectory;
                string absolutePath = Path.Combine(currentDir, dto.AD_IMG廣告圖);

                this.pictureBoxImage.Image = Image.FromFile(absolutePath);
            }

            switch (dto.AD_SPACE廣告版面_PK)
            {
                case 1: //"首頁A-1"
                    comboBox1.SelectedIndex = 0;
                    break;
                case 2: //"首頁A-2"
                    comboBox1.SelectedIndex = 1;
                    break;
                case 3: //"首頁A-3":
                    comboBox1.SelectedIndex = 2;
                    break;
                case 4: //"搜尋結果頁B-1":
                    comboBox1.SelectedIndex = 3;
                    break;
                case 5: //"搜尋結果頁B-2":
                    comboBox1.SelectedIndex = 4;
                    break;
                case 6: //"搜尋結果頁B-3":
                    comboBox1.SelectedIndex = 5;
                    break;
                case 7: //"個人頁C":
                    comboBox1.SelectedIndex = 6;
                    break;


            }
            textBoxId.Text = dto.CAMPAIGN活動_PK.ToString();
            textBoxTitle.Text = dto.CAMPAIGN_NAME活動名稱;
            textBoxURL.Text = dto.URL連結;
            dateTimePickerStart.Value = dto.START_TIME開始時間;
            dateTimePickerEnd.Value = dto.END_TIME結束時間;
            textBoxUpload.Text = dto.AD_IMG廣告圖;
        }

        private void textBoxTitle_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxTitle.Text))
            {
                panel3.BackColor = Color.Red;
                labelTitle.Visible = true;
                return;
            }
            else
            {
                labelTitle.Visible = false;
            }
        }

        private void textBoxURL_Validating(object sender, CancelEventArgs e)
        {
            // 使用正規表達式驗證網址格式
            string pattern = @"^(http|https)://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?$";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(textBoxURL.Text))
            {
                panel1.BackColor = Color.Red;
                labelURL.Visible = true;
                return;
            }
            else
            {
                panel1.BackColor = Color.Black;
                labelURL.Visible = false;
            }
        }

        private void textBoxUpload_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUpload.Text))
            {
                panel4.BackColor = Color.Red;
                labelImg.Visible = true;
                return;
            }
            else
            {
                panel4.BackColor = Color.Black;
                labelImg.Visible = false;
            }
        }
    }
}
