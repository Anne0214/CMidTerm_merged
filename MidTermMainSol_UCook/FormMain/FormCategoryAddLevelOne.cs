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
    public partial class FormCategoryAddLevelOne : Form
    {
        public FormCategoryAddLevelOne()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;

            // 新增記錄
            var db = new AppDbContext();

            var category = new CATEGORY_食譜分類_LEVEL_ONE()
            {
                FEATURED_CATEGORY精選分類LEVEL_ONE_NAME名稱 = name,

            };

            db.CATEGORY_食譜分類_LEVEL_ONE.Add(category);

            db.SaveChanges();

            this.Close();

            //var db = new iSpanDataBaseICookEntities();
            //var c1 = db.CATEGORY_食譜分類_LEVEL_ONE;
            //var newC = CATEGORY_食譜分類_LEVEL_ONE;
            //{ FEATURED_CATEGORY精選分類LEVEL_ONE_NAME名稱 = "ASD"};
            //c1.Add(newC);
            //db.SaveChanges();
        }
    }
    }
