using FormMain.EF_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMain
{
	public partial class FormRecipeSearch : Form,INotify
	{
		public FormRecipeSearch()
		{
			InitializeComponent();
			this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(230)))));
            dataGridView1.BackgroundColor = Color.FromArgb(255, 255, 253); //背景色
			dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(237, 243, 255); //雙行色

			//調整dataGridView樣式
			dataGridView1.RowsAdded += DataGridView1_RowsAdded;
			dataGridView1.RowsAdded += DataGridView1_RowsAdded;
			dataGridView1.BackgroundColor = Color.FromArgb(255, 255, 253); //背景色
			dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(237, 243, 255); //雙行色
			dataGridView1.RowsAdded += DataGridView1_RowsAdded;
			dataGridView1.RowsAdded += DataGridView1_RowsAdded;
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

			//dateTimePicker空值
			dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.CustomFormat = " ";
			dateTimePickerStart.ValueChanged += EnableDateTimePickerStart;
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.CustomFormat = " ";
			dateTimePickerEnd.ValueChanged += EnableDateTimePickerEnd;


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

		private void EnableDateTimePickerEnd(object sender, EventArgs e)
        {
            dateTimePickerEnd.CustomFormat = "yyyy-MM-dd";
        }

        private void EnableDateTimePickerStart(object sender, EventArgs e)
        {
            dateTimePickerStart.CustomFormat = "yyyy-MM-dd";
        }

        public void Display()
        {
			//拿搜尋條件
			string authorName = textBoxAuthorName.Text;
			string authorPk = textBoxAuthorPk.Text;
			string recipeName = textBoxRecipeName.Text;
			string recipePk = textBoxRecipePk.Text;


			DateTime start = dateTimePickerStart.Value;
			DateTime end = dateTimePickerEnd.Value;

			//拿取資料
			var db = new AppDbContext();
            var result = (from r in db.RECIPE_食譜
                          join m in db.MEMBER_會員 on r.AUTHOR_作者 equals m.MEMBER_ID會員_PK
                          join c2 in db.CATEGORY_食譜分類_LEVEL_TWO on r.FEATURED_CATEGORY精選分類LEVEL_TWO equals c2.FEATURED_CATEGORY精選分類LEVEL_TWO_PK
						  select new
						  {
                              RecipePk= r.RECIPE食譜_PK,
							  RecipeName = r.RECIPE_NAME食譜名稱,
							  AuthorPK = r.AUTHOR_作者,
							  NickName = m.NICK_NAME暱稱,
							  Category = c2.FEATURED_CATEGORY精選分類LEVEL_TWO_NAME名稱,
							  PublishedTime = r.PUBLISHED_TIME發表時間
                          });


			if (!string.IsNullOrEmpty(authorName))
			{
				result = result.Where(x => x.NickName.Contains(authorName));
            }

			if (!string.IsNullOrEmpty(authorPk))
			{
				result = result.Where(x => x.AuthorPK.Contains(authorPk));
			}

			if (!string.IsNullOrEmpty(recipeName))
			{
                result = result.Where(x => x.RecipeName.Contains(recipeName));
				
			}

			if (!string.IsNullOrEmpty(recipePk))
			{
                result = result.Where(x => x.RecipePk.Contains(recipePk));
            }
			if (dateTimePickerStart.CustomFormat != " ")
			{
				result = result.Where(x => x.PublishedTime > start);
			}
			if (dateTimePickerEnd.CustomFormat != " ")
			{
				result = result.Where(x => x.PublishedTime < end);
			}

			//最後整理

			dataGridView1.DataSource = result.ToList();

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

        private void buttonClear_Click(object sender, EventArgs e)
        {
			textBoxAuthorName.Text = String.Empty;
			textBoxAuthorPk.Text= String.Empty;
			textBoxRecipeName.Text= String.Empty;
			textBoxRecipePk.Text = String.Empty;
            //dateTimePicker空值
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.CustomFormat = " ";
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.CustomFormat = " ";

            Display();
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
			Display();
        }

        private void FormRecipeSearch_Load(object sender, EventArgs e)
        {
			Display();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Operation" && e.RowIndex > 0) //只有對資料點擊修改時會發動
            {
                string recipePK = dataGridView1.Rows[e.RowIndex].Cells["col_recipePk"].Value.ToString();

				FormRecipeEdit frm = new FormRecipeEdit(recipePK);
                frm.Owner = this;
                frm.Show();
            }
        }

		public void Success(string message)
		{
			toast.AMessage = message;
			toast.ShowUp();
			Display();
		}
	}
}
