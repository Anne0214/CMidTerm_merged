using FormMain.EF_Models;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMain
{
    public partial class FormCategorySearch : Form
    {
        public FormCategorySearch()
        {
            InitializeComponent();
        }

        private void CATEGORY_食譜分類_Load(object sender, EventArgs e)
        {

            var data = new AppDbContext().CATEGORY_食譜分類_LEVEL_ONE.ToList();
            this.listBoxLevelOne.DataSource = data;
            this.listBoxLevelOne.DisplayMember = "FEATURED_CATEGORY精選分類LEVEL_ONE_NAME名稱";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedLevelOneItem = listBoxLevelOne.SelectedItem as CATEGORY_食譜分類_LEVEL_ONE;
            if (selectedLevelOneItem != null)
            {
                var levelOneId = selectedLevelOneItem.FEATURED_CATEGORY精選分類LEVEL_ONE_PK;

                var data = new AppDbContext().CATEGORY_食譜分類_LEVEL_TWO
                    .Where(x => x.LEVEL_ONE_FK == levelOneId)
                    .ToList();

                this.listBoxLevelTwo.DataSource = data;
                this.listBoxLevelTwo.DisplayMember = "FEATURED_CATEGORY精選分類LEVEL_TWO_NAME名稱";
            }
            
        }
    

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedLevelTwoItem = listBoxLevelTwo.SelectedItem as CATEGORY_食譜分類_LEVEL_TWO;
            if (selectedLevelTwoItem != null)
            {
                var leveltwoId = selectedLevelTwoItem.FEATURED_CATEGORY精選分類LEVEL_TWO_PK;

                var data = new AppDbContext().CATEGORY_食譜分類_LEVEL_THREE
                    .Where(x => x.LEVEL_TWO_FK == leveltwoId)
                    .ToList();

                this.listBoxLevelThree.DataSource = data;
                this.listBoxLevelThree.DisplayMember = "FEATURED_CATEGORY精選分類LEVEL_THREE_NAME名稱";
            }
        }

        private void ButtonAddLevelOne_Click(object sender, EventArgs e)
        {
            FormCategoryAddLevelOne frm = new FormCategoryAddLevelOne();
            frm.Owner = this;
            frm.Show();
        }

        private void ButtonAddLevelTwo_Click(object sender, EventArgs e)
        {
            FormCategoryAddLevelTwo frm = new FormCategoryAddLevelTwo();
            frm.LevelOnePk = (listBoxLevelOne.SelectedItem as CATEGORY_食譜分類_LEVEL_ONE)?.FEATURED_CATEGORY精選分類LEVEL_ONE_PK ?? 0;

            frm.ShowDialog();             // 使用ShowDialog()以阻塞代码直到AddLevelTwo窗体关闭

            if (!string.IsNullOrEmpty(frm.AddedLevelTwoName))
            {
                // 更新SQL数据
                var db = new AppDbContext();
                var data = db.CATEGORY_食譜分類_LEVEL_TWO
                    .Where(x => x.LEVEL_ONE_FK == frm.LevelOnePk)
                    .ToList();

                this.listBoxLevelTwo.DataSource = data;
                this.listBoxLevelTwo.DisplayMember = "FEATURED_CATEGORY精選分類LEVEL_TWO_NAME名稱";
                this.listBoxLevelTwo.ClearSelected();
            }

        }

        private void ButtonAddLevelThree_Click(object sender, EventArgs e)
        {
            FormCategoryAddLevelThree frm = new FormCategoryAddLevelThree();
            frm.LevelTwoPk = (listBoxLevelTwo.SelectedItem as CATEGORY_食譜分類_LEVEL_TWO)?.FEATURED_CATEGORY精選分類LEVEL_TWO_PK ?? 0;
            frm.Owner = this;
            frm.ShowDialog();         // 使用ShowDialog()以阻塞代码直到AddLevelTwo窗体关闭

            if (!string.IsNullOrEmpty(frm.AddedLevelThreeName))
            {
                // 更新SQL数据
                var db = new AppDbContext();
                var data = db.CATEGORY_食譜分類_LEVEL_THREE
                    .Where(x => x.LEVEL_TWO_FK == frm.LevelTwoPk)
                    .ToList();

                this.listBoxLevelThree.DataSource = data;
                this.listBoxLevelThree.DisplayMember = "FEATURED_CATEGORY精選分類LEVEL_TWO_NAME名稱";
                this.listBoxLevelThree.ClearSelected();
            }
        }

        private void ButtonUpdataLevelOne_Click(object sender, EventArgs e)
        {
            // 檢查是否有選取項目
            if (listBoxLevelOne.SelectedItem == null)
            {
                MessageBox.Show("請選擇一個項目");
                return;
            }

            // 取得選取的資料
            var selectedCategory = (CATEGORY_食譜分類_LEVEL_ONE)listBoxLevelOne.SelectedItem;

            // 建立 UpdataLevelOne 畫面並傳遞選取的資料
            var updataLevelOne = new FormCategoryUpdateLevelOne(selectedCategory);
            updataLevelOne.ShowDialog();

            // 檢查是否有更新資料
            if (updataLevelOne.IsUpdated)
            {
                // 更新 SQL 資料
                var db = new AppDbContext();
                var category = db.CATEGORY_食譜分類_LEVEL_ONE.Find(selectedCategory.FEATURED_CATEGORY精選分類LEVEL_ONE_PK);
                category.FEATURED_CATEGORY精選分類LEVEL_ONE_NAME名稱 = updataLevelOne.TextBoxValue;
                db.SaveChanges();

                // 重新設定資料來源，更新顯示的項目
                var dataSource = new AppDbContext().CATEGORY_食譜分類_LEVEL_ONE.ToList();
                this.listBoxLevelOne.DataSource = dataSource;
                this.listBoxLevelOne.DisplayMember = "FEATURED_CATEGORY精選分類LEVEL_ONE_NAME名稱";




                MessageBox.Show("更新成功");
            }
            else
            {
                MessageBox.Show("更新失敗");
            }
        }

        private void ButtonUpdataLevelTwo_Click(object sender, EventArgs e)
        {
            // 檢查是否有選取項目
            if (listBoxLevelTwo.SelectedItem == null)
            {
                MessageBox.Show("請選擇一個項目");
                return;
            }

            // 取得選取的資料
            var selectedCategory = (CATEGORY_食譜分類_LEVEL_TWO)listBoxLevelTwo.SelectedItem;

            // 建立 updataLevelThree 畫面並傳遞選取的資料
            var updataLevelTwo = new FormCategoryUpdataLevelTwo(selectedCategory);
            updataLevelTwo.ShowDialog();

            // 檢查是否有更新資料
            if (updataLevelTwo.IsUpdated)
            {
                // 更新 SQL 資料
                var db = new AppDbContext();
                var category = db.CATEGORY_食譜分類_LEVEL_TWO.Find(selectedCategory.FEATURED_CATEGORY精選分類LEVEL_TWO_PK);
                category.FEATURED_CATEGORY精選分類LEVEL_TWO_NAME名稱 = updataLevelTwo.TextBoxValue;
                db.SaveChanges();

                // 重新設定資料來源，更新顯示的項目
                var dataSource = listBoxLevelOne.DataSource as List<CATEGORY_食譜分類_LEVEL_ONE>;
                listBoxLevelOne.DataSource = null;
                listBoxLevelOne.DataSource = dataSource;
                listBoxLevelOne.DisplayMember = "FEATURED_CATEGORY精選分類LEVEL_ONE_NAME名稱";

                MessageBox.Show("更新成功");
            }
            else
            {
                MessageBox.Show("更新失敗");
            }
        }

        private void ButtonUpdataLevelThree_Click(object sender, EventArgs e)
        {
            // 檢查是否有選取項目
            if (listBoxLevelTwo.SelectedItem == null)
            {
                MessageBox.Show("請選擇一個項目");
                return;
            }

            // 取得選取的資料
            var selectedCategory = (CATEGORY_食譜分類_LEVEL_THREE)listBoxLevelThree.SelectedItem;

            // 建立 updataLevelThree 畫面並傳遞選取的資料
            var updataLevelThree = new FormCategoryUpdateLevelThree(selectedCategory);
            updataLevelThree.ShowDialog();

            // 檢查是否有更新資料
            if (updataLevelThree.IsUpdated)
            {
                // 更新 SQL 資料
                var db = new AppDbContext();
                var category = db.CATEGORY_食譜分類_LEVEL_THREE.Find(selectedCategory.FEATURED_CATEGORY精選分類LEVEL_THREE_PK);
                category.FEATURED_CATEGORY精選分類LEVEL_THREE_NAME名稱 = updataLevelThree.TextBoxValue;
                db.SaveChanges();


                // 重新設定資料來源，更新顯示的項目
                var dataSource = listBoxLevelOne.DataSource as List<CATEGORY_食譜分類_LEVEL_ONE>;
                listBoxLevelOne.DataSource = null;
                listBoxLevelOne.DataSource = dataSource;
                listBoxLevelOne.DisplayMember = "FEATURED_CATEGORY精選分類LEVEL_ONE_NAME名稱";

                MessageBox.Show("更新成功");
            }
            else
            {
                MessageBox.Show("更新失敗");
            }


        }

        private void ButtonDeleteLevelOne_Click(object sender, EventArgs e)
        {
            // 檢查是否有選取項目
            if (listBoxLevelOne.SelectedItem == null)
            {
                MessageBox.Show("請選擇一個項目");
                return;
            }

            // 取得選取的資料
            var selectedCategory = (CATEGORY_食譜分類_LEVEL_ONE)listBoxLevelOne.SelectedItem;

            // 建立 DeleteLevelTwo 畫面並傳遞選取的資料
            var deleteLevelOne = new FormCategoryDeleteLevelOne(selectedCategory);
            deleteLevelOne.ShowDialog();

            // 檢查是否已刪除資料
            if (deleteLevelOne.IsDeleted)
            {
                // 更新 SQL 資料
                var db = new AppDbContext();
                var category = db.CATEGORY_食譜分類_LEVEL_ONE.Find(selectedCategory.FEATURED_CATEGORY精選分類LEVEL_ONE_PK);
                db.CATEGORY_食譜分類_LEVEL_ONE.Remove(category);
                db.SaveChanges();


                // 從資料來源中刪除項目
                var dataSource = listBoxLevelOne.DataSource as List<CATEGORY_食譜分類_LEVEL_ONE>;
                dataSource.Remove(selectedCategory);

                // 重新設定資料來源，更新顯示的項目
                listBoxLevelOne.DataSource = null;
                listBoxLevelOne.DataSource = dataSource;
                listBoxLevelOne.DisplayMember = "FEATURED_CATEGORY精選分類LEVEL_ONE_NAME名稱";

                MessageBox.Show("刪除成功");

            }
        }

        private void ButtonDeleteLevelTwo_Click(object sender, EventArgs e)
        {
            // 檢查是否有選取項目
            if (listBoxLevelTwo.SelectedItem == null)
            {
                MessageBox.Show("請選擇一個項目");
                return;
            }

            // 取得選取的資料
            var selectedCategory = (CATEGORY_食譜分類_LEVEL_TWO)listBoxLevelTwo.SelectedItem;

            // 建立 DeleteLevelTwo 畫面並傳遞選取的資料
            var deleteLevelTwo = new FormCategoryDeleteLevelTwo(selectedCategory);
            deleteLevelTwo.ShowDialog();

            // 檢查是否已刪除資料
            if (deleteLevelTwo.IsDeleted)
            {
                // 更新 SQL 資料
                var db = new AppDbContext();
                var category = db.CATEGORY_食譜分類_LEVEL_TWO.Find(selectedCategory.FEATURED_CATEGORY精選分類LEVEL_TWO_PK);
                db.CATEGORY_食譜分類_LEVEL_TWO.Remove(category);
                db.SaveChanges();


                // 從資料來源中刪除項目
                var dataSource = listBoxLevelTwo.DataSource as List<CATEGORY_食譜分類_LEVEL_TWO>;
                dataSource.Remove(selectedCategory);

                // 重新設定資料來源，更新顯示的項目
                listBoxLevelTwo.DataSource = null;
                listBoxLevelTwo.DataSource = dataSource;
                listBoxLevelTwo.DisplayMember = "FEATURED_CATEGORY精選分類LEVEL_TWO_NAME名稱";

                MessageBox.Show("刪除成功");

            }
        }

        private void ButtonDeleteLevelThree_Click(object sender, EventArgs e)
        {
            // 檢查是否有選取項目
            if (listBoxLevelThree.SelectedItem == null)
            {
                MessageBox.Show("請選擇一個項目");
                return;
            }

            // 取得選取的資料
            var selectedCategory = (CATEGORY_食譜分類_LEVEL_THREE)listBoxLevelThree.SelectedItem;

            // 建立 deleteLevelThree 畫面並傳遞選取的資料
            var deleteLevelThree = new FormCategoryDeleteLevelThree(selectedCategory);
            deleteLevelThree.ShowDialog();

            // 檢查是否已刪除資料
            if (deleteLevelThree.IsDeleted)
            {
                // 更新 SQL 資料
                var db = new AppDbContext();
                var category = db.CATEGORY_食譜分類_LEVEL_THREE.Find(selectedCategory.FEATURED_CATEGORY精選分類LEVEL_THREE_PK);
                db.CATEGORY_食譜分類_LEVEL_THREE.Remove(category);
                db.SaveChanges();


                // 從資料來源中刪除項目
                var dataSource = listBoxLevelThree.DataSource as List<CATEGORY_食譜分類_LEVEL_THREE>;
                dataSource.Remove(selectedCategory);

                // 重新設定資料來源，更新顯示的項目
                listBoxLevelThree.DataSource = null;
                listBoxLevelThree.DataSource = dataSource;
                listBoxLevelThree.DisplayMember = "FEATURED_CATEGORY精選分類LEVEL_THREE_NAME名稱";

                MessageBox.Show("刪除成功");

            }
        }


        private void listBoxLevelThree_SelectedIndexChanged(object sender, EventArgs e)
        {
            //只判斷listBoxLevelOne

            //var selectedLevelOneItem = listBoxLevelOne.SelectedItem as CATEGORY_食譜分類_LEVEL_ONE;

            //if (selectedLevelOneItem != null)
            //{
            //    var levelOneId = selectedLevelOneItem.FEATURED_CATEGORY精選分類LEVEL_ONE_PK;

            //    var db = new iSpanDataBaseICookEntities();

            //    var recipeData = db.RECIPE_食譜
            //        .Where(x => x.FEATURED_CATEGORY精選分類LEVEL_ONE == levelOneId)
            //        .Select(x => new
            //        {
            //            x.RECIPE_NAME食譜名稱,
            //            x.AUTHOR_作者,
            //            x.LIKES_讚數
            //        })
            //        .ToList();

            //    dataGridView1.DataSource = recipeData;
            //}


            //只判斷listBoxLevelTwo
            var selectedLevelOneItem = listBoxLevelOne.SelectedItem as CATEGORY_食譜分類_LEVEL_ONE;
            var selectedLevelTwoItem = listBoxLevelTwo.SelectedItem as CATEGORY_食譜分類_LEVEL_TWO;

            if (selectedLevelOneItem != null && selectedLevelTwoItem != null)
            {
                var levelTwoId = selectedLevelTwoItem.FEATURED_CATEGORY精選分類LEVEL_TWO_PK;

                var db = new AppDbContext();

                var recipeData = db.RECIPE_食譜
                    .Where(x => x.FEATURED_CATEGORY精選分類LEVEL_ONE == selectedLevelOneItem.FEATURED_CATEGORY精選分類LEVEL_ONE_PK &&
                                x.FEATURED_CATEGORY精選分類LEVEL_TWO == levelTwoId)
                    .Select(x => new
                    {
                        x.RECIPE_NAME食譜名稱,
                        x.AUTHOR_作者,
                        x.LIKES_讚數
                    })
                    .ToList();

                dataGridView1.DataSource = recipeData;
            }


            //listBoxLevelThree
            //var selectedLevelOneItem = listBoxLevelOne.SelectedItem as CATEGORY_食譜分類_LEVEL_ONE;
            //var selectedLevelTwoItem = listBoxLevelTwo.SelectedItem as CATEGORY_食譜分類_LEVEL_TWO;
            //var selectedLevelThreeItem = listBoxLevelThree.SelectedItem as CATEGORY_食譜分類_LEVEL_THREE;

            //if (selectedLevelThreeItem != null)
            //{
            //    var levelThreeId = selectedLevelThreeItem.FEATURED_CATEGORY精選分類LEVEL_THREE_PK;

            //    var db = new iSpanDataBaseICookEntities();

            //    var recipeData = db.RECIPE_食譜
            //        .Where(x => x.FEATURED_CATEGORY精選分類LEVEL_THREE == levelThreeId)
            //        .Select(x => new
            //        {
            //            x.RECIPE_NAME食譜名稱,
            //            x.AUTHOR_作者,
            //            x.LIKES_讚數
            //        })
            //        .ToList();

            //    dataGridView1.DataSource = recipeData;
            //}
            //else if (selectedLevelTwoItem != null)
            //{
            //    var levelTwoId = selectedLevelTwoItem.FEATURED_CATEGORY精選分類LEVEL_TWO_PK;

            //    var db = new iSpanDataBaseICookEntities();

            //    var recipeData = db.RECIPE_食譜
            //        .Where(x => x.FEATURED_CATEGORY精選分類LEVEL_TWO == levelTwoId)
            //        .Select(x => new
            //        {
            //            x.RECIPE_NAME食譜名稱,
            //            x.AUTHOR_作者,
            //            x.LIKES_讚數
            //        })
            //        .ToList();

            //    dataGridView1.DataSource = recipeData;
            //}
            //else if (selectedLevelOneItem != null)
            //{
            //    var levelOneId = selectedLevelOneItem.FEATURED_CATEGORY精選分類LEVEL_ONE_PK;

            //    var db = new iSpanDataBaseICookEntities();

            //    var recipeData = db.RECIPE_食譜
            //        .Where(x => x.FEATURED_CATEGORY精選分類LEVEL_ONE == levelOneId)
            //        .Select(x => new
            //        {
            //            x.RECIPE_NAME食譜名稱,
            //            x.AUTHOR_作者,
            //            x.LIKES_讚數
            //        })
            //        .ToList();

            //    dataGridView1.DataSource = recipeData;
            //}



        }

        //private void RefreshDataGridView()
        //{
        //    var selectedLevelThreeItem = listBoxLevelThree.SelectedItem as CATEGORY_食譜分類_LEVEL_THREE;
        //    var selectedLevelTwoItem = listBoxLevelTwo.SelectedItem as CATEGORY_食譜分類_LEVEL_TWO;
        //    var selectedLevelOneItem = listBoxLevelOne.SelectedItem as CATEGORY_食譜分類_LEVEL_ONE;

        //    int? levelThreeId = null;
        //    int? levelTwoId = null;
        //    int? levelOneId = null;

        //    if (selectedLevelThreeItem != null)
        //    {
        //        levelThreeId = selectedLevelThreeItem.FEATURED_CATEGORY精選分類LEVEL_THREE_PK;
        //    }
        //    else if (selectedLevelTwoItem != null)
        //    {
        //        levelTwoId = selectedLevelTwoItem.FEATURED_CATEGORY精選分類LEVEL_TWO_PK;
        //    }
        //    else if (selectedLevelOneItem != null)
        //    {
        //        levelOneId = selectedLevelOneItem.FEATURED_CATEGORY精選分類LEVEL_ONE_PK;
        //    }

        //    var db = new iSpanDataBaseICookEntities();

        //    var recipeData = db.RECIPE_食譜
        //        .Where(x =>
        //            (levelThreeId.HasValue && x.FEATURED_CATEGORY精選分類LEVEL_THREE == levelThreeId) ||
        //            (levelTwoId.HasValue && x.FEATURED_CATEGORY精選分類LEVEL_TWO == levelTwoId) ||
        //            (levelOneId.HasValue && x.FEATURED_CATEGORY精選分類LEVEL_ONE == levelOneId))
        //        .Select(x => new
        //        {
        //            x.RECIPE_NAME食譜名稱,
        //            x.AUTHOR_作者,
        //            x.LIKES_讚數
        //        })
        //        .ToList();

        //    dataGridView1.DataSource = recipeData;
        //}




        private void AddLevel123_Click(object sender, EventArgs e)
        {
            var selectedLevelOneItem = listBoxLevelOne.SelectedItem as CATEGORY_食譜分類_LEVEL_ONE;
            var selectedLevelTwoItem = listBoxLevelTwo.SelectedItem as CATEGORY_食譜分類_LEVEL_TWO;
            var selectedLevelThreeItem = listBoxLevelThree.SelectedItem as CATEGORY_食譜分類_LEVEL_THREE;

            string levelOneName = selectedLevelOneItem != null ? selectedLevelOneItem.FEATURED_CATEGORY精選分類LEVEL_ONE_NAME名稱 : "";
            string levelTwoName = selectedLevelTwoItem != null ? selectedLevelTwoItem.FEATURED_CATEGORY精選分類LEVEL_TWO_NAME名稱 : "";
            string levelThreeName = selectedLevelThreeItem != null ? selectedLevelThreeItem.FEATURED_CATEGORY精選分類LEVEL_THREE_NAME名稱 : "";

            string labelText = $"{levelOneName} > {levelTwoName} > {levelThreeName}";

            // 呼叫AddLevel123PK視窗
            var addLevel123PKForm = new FormCategoryAddLevel123PK();
            addLevel123PKForm.Labe2Text = labelText;
            addLevel123PKForm.ShowDialog();

            // 在AddLevel123PK視窗關閉後，更新dataGridView1中的資料
            //RefreshDataGridView();
        }
    }
}






