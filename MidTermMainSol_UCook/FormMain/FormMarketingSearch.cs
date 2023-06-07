
using ISpan2023.UCook.BackEnd;
using ISpan2023.UCook.BackEnd.Dtos;
using ISpan2023.UCook.BackEnd.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormMain
{
    public partial class FormMarketingSearch : Form, INotify
    {
        List<MarketingDto> data;
        List<MarketingDetailDto> datas;


        public FormMarketingSearch()
        {
            InitializeComponent();
            //滾軸
            this.AutoScroll = true;
            //背景色
            dataGridView1.BackgroundColor = Color.FromArgb(255, 255, 253); //背景色
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(237, 243, 255); //雙行色
            //點擊率欄位 xx%
            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
            //行數計算
            dataGridView1.RowsAdded += DataGridView1_RowsAdded;
            dataGridView1.RowsAdded += DataGridView1_RowsAdded;
            //分頁
            toolStripButtonPageA1.Click += toolStripButtonPageA1_Click;
            toolStripButtonPageA2.Click += toolStripButtonPageA2_Click;
            toolStripButtonPageA3.Click += toolStripButtonPageA3_Click;
            toolStripButtonPageB1.Click += toolStripButtonPageB1_Click;
            toolStripButtonPageB2.Click += toolStripButtonPageB2_Click;
            toolStripButtonPageB3.Click += toolStripButtonPageB3_Click;
            toolStripButtonPageC.Click += toolStripButtonPageC_Click;
            //comboBox
            string[] options = { "活動名稱", "活動編號" };
            comboBoxType.Items.AddRange(options);
            comboBoxType.SelectedIndex = 0;

			//調整dataGridView
			dataGridView1.AutoGenerateColumns = false;
			dataGridView1.DefaultCellStyle.Font = new Font("微軟正黑體", 12F);
			dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("微軟正黑體", 12F);
			dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
			dataGridView1.GridColor = Color.FromArgb(255, 255, 253);
			dataGridView1.BorderStyle = BorderStyle.None;
			dataGridView1.Columns[0].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 253);
			Operation.FlatStyle = FlatStyle.Flat;

            //加上複製事件
            dataGridView1.ColumnHeaderMouseClick += dataGridView1_ColumnHeaderMouseClick;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;

		}

		private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left) // 只處理滑鼠左键點擊事件
			{
				if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // 確認不是點擊標題行
				{
					DataGridViewCell clickedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

					//如果value!=null,用ToString();如為null,用string.Empty
					string cellValue = clickedCell.Value?.ToString() ?? string.Empty;

					if (!string.IsNullOrEmpty(cellValue)) //不是null或空字串才複製
					{
						// 將值複製到剪貼版
						Clipboard.SetText(cellValue);
						Success("複製成功");

					}
					return;

				}
			}
		}

		private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left) // 只處理滑鼠左键點擊事件
			{
				if (e.RowIndex == -1) // 確保點擊標題
				{
					DataGridViewColumn clickedColumn = dataGridView1.Columns[e.ColumnIndex];

					StringBuilder rowValues = new StringBuilder();

					// 獲取每格的值
					foreach (DataGridViewRow row in dataGridView1.Rows)
					{
						DataGridViewCell cell = row.Cells[e.ColumnIndex];

						//如果value!=null,用ToString();如為null,用string.Empty
						string cellValue = cell.Value?.ToString() ?? string.Empty;
						rowValues.AppendLine(cellValue);
					}

					// 將值複製到剪貼版
					Clipboard.SetText(rowValues.ToString());
					Success("複製成功");
				}
			}
		}

		private void DataGridView1_RowsAdded(object sender, EventArgs e)
        {
            UpdateRowCount();
        }

        private void DataGridView1_RowsRemoved(object sender, EventArgs e)
        {
            UpdateRowCount();
        }
        private void UpdateRowCount()
        {
            LabelRowCount.Text = "總共 " + dataGridView1.Rows.Count.ToString() + " 筆";
        }


        private void Display(int pageId = 1)
        {
            //取得篩選的值
            string marketingName = this.textboxSearch.Text;
            string marketingId = this.textboxSearch.Text;


            //叫用Search(),取得符合的紀錄
            var repo = new MarketingRepository();
            List<MarketingDto> data = new List<MarketingDto>();

            switch (comboBoxType.SelectedItem)
            {
                case "活動名稱":
                    data = repo.Search(pageId, marketingName, "");
                    break;
                case "活動編號":
                    data = repo.Search(pageId, "", marketingId);
                    break;
            }

            //繫結到datagridview
            this.dataGridView1.DataSource = data;


        }



        private void FormSearch_Load(object sender, EventArgs e)
        {
            Display();
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textboxSearch.Text = string.Empty;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormMarketingCreate frm = new FormMarketingCreate();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        { //按修改button 跳出FormEdit視窗
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Operation" && e.RowIndex >= 0)
            {
                string marketingId = dataGridView1.Rows[e.RowIndex].Cells["CAMPAIGN活動_PK"].Value.ToString();
                int selectedPageIndex = 0; // 假設這裡是首頁A-1

                switch (marketingId)
                {
                    case "首頁A-1":
                        selectedPageIndex = 0; 
                        break;
                    case "首頁A-2":
                        selectedPageIndex = 1; 
                        break;
                    case "首頁A-3":
                        selectedPageIndex = 2; 
                        break;
                    case "搜尋結果頁B-1":
                        selectedPageIndex = 3; 
                        break;
                    case "搜尋結果頁B-2":
                        selectedPageIndex = 4; 
                        break;
                    case "搜尋結果頁B-3":
                        selectedPageIndex = 5; 
                        break;
                    case "個人頁C":
                        selectedPageIndex = 6; 
                        break;
                }

                FormMarketingEdit frm = new FormMarketingEdit(marketingId, selectedPageIndex);
                frm.PageIndexChanged += (FormSearch, index) =>
                {
                    // 更新分頁索引
                    selectedPageIndex = index;
                };

                frm.Owner = this;
                frm.ShowDialog();


            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {//點擊率欄位 xx%

            dataGridView1.Columns["CTR"].DefaultCellStyle.Format = "0 ' %'";
        }

        private void toolStripButtonPageA1_Click(object sender, EventArgs e)
        {
            Display(pageId: 1);
        }
        private void toolStripButtonPageA2_Click(object sender, EventArgs e)
        {
            Display(pageId: 2);
        }

        private void toolStripButtonPageA3_Click(object sender, EventArgs e)
        {
            Display(pageId: 3);
        }

        private void toolStripButtonPageB1_Click(object sender, EventArgs e)
        {
            Display(pageId: 4);
        }

        private void toolStripButtonPageB2_Click(object sender, EventArgs e)
        {
            Display(pageId: 5);
        }

        private void toolStripButtonPageB3_Click(object sender, EventArgs e)
        {
            Display(pageId: 6);
        }

        private void toolStripButtonPageC_Click(object sender, EventArgs e)
        {
            Display(pageId: 7);
        }

		public void Success(string message)
		{
            toast.AMessage = message;
			toast.ShowUp();
			Display(); //用來刷新表格資料
		}


    }
    
}
