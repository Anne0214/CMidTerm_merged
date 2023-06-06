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
    public partial class FormCategoryUpdateLevelThree : Form
    {
        public string TextBoxValue { get; private set; }
        public bool IsUpdated { get; private set; }
        public FormCategoryUpdateLevelThree(CATEGORY_食譜分類_LEVEL_THREE selectedCategory)
        {
            InitializeComponent();
            // 將選取的資料匯入 TEXTBOX1
            textBox1.Text = selectedCategory.FEATURED_CATEGORY精選分類LEVEL_THREE_NAME名稱;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 將 TEXTBOX1 的值存儲到 TextBoxValue 屬性
            TextBoxValue = textBox1.Text;
            IsUpdated = true;
            this.Close();
        }
    }
}
