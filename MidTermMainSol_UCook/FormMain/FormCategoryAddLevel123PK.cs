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
    public partial class FormCategoryAddLevel123PK : Form
    {
        private AppDbContext db; // 建立資料庫上下文物件
        private readonly int? levelOneId;
        private readonly int? levelTwoId;
        private readonly int? levelThreeId;
        public string Labe2Text
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }
        public FormCategoryAddLevel123PK()
        {
            InitializeComponent();
            db = new AppDbContext(); // 初始化資料庫上下文物件
        }
        public FormCategoryAddLevel123PK(int? levelOneId, int? levelTwoId, int? levelThreeId)
        {
            InitializeComponent();
            this.levelOneId = levelOneId;
            this.levelTwoId = levelTwoId;
            this.levelThreeId = levelThreeId;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddLevel123PK_Load(object sender, EventArgs e)
        {
            var db = new AppDbContext();

            var query = db.RECIPE_食譜.Select(x => new
            {
                x.RECIPE_NAME食譜名稱,
                x.FEATURED_CATEGORY精選分類LEVEL_ONE,
                x.FEATURED_CATEGORY精選分類LEVEL_TWO,
                x.FEATURED_CATEGORY精選分類LEVEL_THREE
            });

            if (levelThreeId != null)
            {
                query = query.Where(x => x.FEATURED_CATEGORY精選分類LEVEL_THREE == levelThreeId);
            }
            else if (levelTwoId != null)
            {
                query = query.Where(x => x.FEATURED_CATEGORY精選分類LEVEL_TWO == levelTwoId);
            }
            else if (levelOneId != null)
            {
                query = query.Where(x => x.FEATURED_CATEGORY精選分類LEVEL_ONE == levelOneId);
            }

            var recipeData = query.ToList();

            dataGridView1.DataSource = ConvertToDataTable(recipeData);
        }
        private DataTable ConvertToDataTable<T>(IEnumerable<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }

            return table;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
                
            
        
   


