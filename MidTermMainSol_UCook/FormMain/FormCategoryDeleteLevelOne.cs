using FormMain.EF_Models;
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
    public partial class FormCategoryDeleteLevelOne : Form
    {
        public string TextBoxValue { get; private set; }
        public bool IsDeleted { get; private set; }
        public FormCategoryDeleteLevelOne(CATEGORY_食譜分類_LEVEL_ONE selectedCategory)
        {
            InitializeComponent();
            // 將選取的資料匯入 TEXTBOX1
            textBox1.Text = selectedCategory.FEATURED_CATEGORY精選分類LEVEL_ONE_NAME名稱;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 執行刪除操作，這裡只模擬刪除，您需要根據需要進行實際的刪除操作
            // 在此例中，只將 IsDeleted 設置為 true，表示刪除成功
            IsDeleted = true;
            this.Close();
        }
    }
}
