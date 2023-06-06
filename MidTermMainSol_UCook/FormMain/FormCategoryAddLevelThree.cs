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
    public partial class FormCategoryAddLevelThree : Form
    {
        public int LevelTwoPk { get; set; }
        public string AddedLevelThreeName { get; set; }
        public FormCategoryAddLevelThree()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;

            // 新增記錄
            var db = new AppDbContext();

            var category = new CATEGORY_食譜分類_LEVEL_THREE()
            {
                FEATURED_CATEGORY精選分類LEVEL_THREE_NAME名稱 = name,
                LEVEL_TWO_FK = LevelTwoPk

            };

            db.CATEGORY_食譜分類_LEVEL_THREE.Add(category);

            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("新增成功");
                AddedLevelThreeName = name; // 设置新增的名稱
            }
            else
            {
                MessageBox.Show("新增失敗");
            }
            this.Close();
        }

      
    }
    }

