using FormMain.ViewModels;
using ISpan2023.UCook.BackEnd.Dtos;
using ISpan2023.UCook.BackEnd.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace FormMain
{
    public partial class FormMarketingCreate : Form
    {
        private const int MaxCharacterCount = 20;
        public FormMarketingCreate()
        {
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
            //combobox選項
            string[] options =
                { "首頁A-1", "首頁A-2", "首頁A-3", "搜尋結果頁B-1", "搜尋結果頁B-2", "搜尋結果頁B-3", "個人頁C" };
            comboBox1.Items.AddRange(options);
            //預設選項'首頁A-1'
            comboBox1.SelectedIndex = 0;

            //商品圖片放預設
            this.pictureBoxImage.Image = System.Drawing.Image.FromStream(System.Net.WebRequest.Create("https://i.imgur.com/CVST7tT.png").GetResponse().GetResponseStream());

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        { //標題長度
            if (textBoxTitle.Text.Length >= MaxCharacterCount)
            {
                textBoxTitle.Text = textBoxTitle.Text.Substring(0, MaxCharacterCount);
                textBoxTitle.SelectionStart = MaxCharacterCount;
                panel2.BackColor = Color.Red;
                label6.ForeColor = Color.Red;
            }
            else
            {
                panel2.BackColor = Color.Black;
                label6.ForeColor = Color.Black;
            }
            StringLength();
        }

        public void StringLength()
        {
            int currentCharacterCount = textBoxTitle.Text.Length;
            label6.Text = $"{currentCharacterCount}/{MaxCharacterCount}";
        }

        private void textBoxTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTitle.Text))
            {
                panel2.BackColor = Color.Red;
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

       
        private string CoverFilePath { get; set; }
        private void buttonUpload_Click(object sender, EventArgs e)
        {
            var imgUpload = new ImageUpload();
            string path = imgUpload.UploadIMG();
            if (path == string.Empty) return; //使用者沒有選擇圖片的狀況
            CoverFilePath = path;
            var MyImage = new Bitmap(path);
            pictureBoxImage.Image = (System.Drawing.Image)MyImage;
            textBoxUpload.Text = path;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        { //當沒有點擊任何textbox，直接點擊add button時，最後的驗證
            //標題空字串
            if (string.IsNullOrEmpty(textBoxTitle.Text))
            {
                panel2.BackColor = Color.Red;
                labelTitle.Visible = true;
            }
            else
            {
                labelTitle.Visible = false;
            }

            // 使用正規表達式驗證網址格式
            string pattern = @"^(http|https)://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?$";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(textBoxURL.Text))
            {
                panel1.BackColor = Color.Red;
                labelURL.Visible = true;
            }
            else
            {
                panel1.BackColor = Color.Black;
                labelURL.Visible = false;
            }

            //圖檔空字串
            if (string.IsNullOrEmpty(textBoxUpload.Text))
            {
                panel4.BackColor = Color.Red;
                labelImg.Visible = true;
            }
            else
            {
                panel4.BackColor = Color.Black;
                labelImg.Visible = false;
            }


            try
            {
                //precondition checks, 檢查各欄位值是否有填寫正確
                //panel有紅框就不給過
                if (panel1.BackColor == Color.Red)
                { return; }
                if (panel4.BackColor == Color.Red)
                { return; }
                if (panel2.BackColor == Color.Red)
                { return; }


                //蒐集表單欄位值到dto
                MarketingDetailDto dto = new MarketingDetailDto()
                {
                    CAMPAIGN活動_PK = labelPK.Text,
                    AD_SPACE廣告版面_PK = comboBox1.SelectedIndex,
                    CAMPAIGN_NAME活動名稱 = textBoxTitle.Text,
                    URL連結 = textBoxURL.Text,
                    START_TIME開始時間 = dateTimePickerStart.Value,
                    END_TIME結束時間 = dateTimePickerEnd.Value,
                    AD_IMG廣告圖 = textBoxUpload.Text,
                };


                if (comboBox1.SelectedItem != null)
                {
                    string selectedValue = comboBox1.SelectedItem.ToString();
                    //int selectedIndex = comboBox1.SelectedIndex;
                    //if (selectedIndex >= 0 && selectedIndex < comboBox1.Items.Count)
                    //{
                    //    // Map the selected index to the corresponding value
                    //    int selectedValue = selectedIndex + 1; // Add 1 to match your expected values

                    //    // Assign the selected value to the dto.AD_SPACE廣告版面_PK property
                    //    dto.AD_SPACE廣告版面_PK = selectedValue;
                    //}

                    //if (int.TryParse(selectedValue, out int parsedValue))
                    //{
                    //    dto.AD_SPACE廣告版面_PK = parsedValue;
                    //}
                    if (!string.IsNullOrEmpty(selectedValue))
                    {
                        dto.AD_SPACE廣告版面_PK = int.Parse(selectedValue);
                    }
                    //                    Dictionary<string, int> options = new Dictionary<string, int>()
                    //{
                    //    { "首頁A-1", 1 },
                    //    { "首頁A-2", 2 },
                    //    { "首頁A-3", 3 },
                    //    { "搜尋結果頁B-1", 4 },
                    //    { "搜尋結果頁B-2", 5 },
                    //    { "搜尋結果頁B-3", 6 },
                    //    { "個人頁C", 7 },
                    //    // Add other options to the dictionary
                    //};

                    //                    if (options.ContainsKey(selectedValue))
                    //                    {
                    //                        dto.AD_SPACE廣告版面_PK = options[selectedValue];
                    //                    }
                    //                    else
                    //                    {
                    //                        // Handle the case when the selected value doesn't match any known options
                    //                    }
                    //                }

                    //switch (selectedValue)
                    //{

                    //    case "首頁A-1":
                    //        dto.AD_SPACE廣告版面_PK = 1;
                    //        break;

                    //    case "首頁A-2":
                    //        dto.AD_SPACE廣告版面_PK = 2;
                    //        break;

                    //    case "首頁A-3":
                    //        dto.AD_SPACE廣告版面_PK = 3;
                    //        break;

                    //    case "搜尋結果頁B-1":
                    //        dto.AD_SPACE廣告版面_PK = 4;
                    //        break;

                    //    case "搜尋結果頁B-2":
                    //        dto.AD_SPACE廣告版面_PK = 5;
                    //        break;

                    //    case "搜尋結果頁B-3":
                    //        dto.AD_SPACE廣告版面_PK = 6;
                    //        break;

                    //    case "個人頁C":
                    //        dto.AD_SPACE廣告版面_PK = 7;
                    //        break;
                    //    default:
                    //        // 非预期的选定项文本值
                    //        dto.AD_SPACE廣告版面_PK = 0; // 默认值或错误处理
                    //        break;

                    //}

                    var imgSave = new ImageUpload();
                    CoverFilePath = string.IsNullOrEmpty(CoverFilePath) ?
                                        CoverFilePath : imgSave.SaveImage(CoverFilePath);



                    //呼叫新增的方法
                    var repo = new MarketingRepository();
                    int newId = repo.Create(dto);
                    MessageBox.Show($"新增成功! 新的活動編號是:{newId}");
                }
            }

            catch (Exception ex)
            {  //儲存失敗的狀況
                MessageBox.Show("儲存失敗，失敗原因是: " + ex.Message);
                return;
            }

            //通知(儲存成功的狀況)
            INotify frm = this.Owner as INotify;
            frm.Success("儲存成功");

            //關閉本視窗
            this.Close();
        }
    }
}
 
