﻿using System;
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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            FormLogin frm= new FormLogin();
            frm.ShowDialog();

            RemoveMdiBackColor();

		}

		private void toolStripButtonLeave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonMember_Click(object sender, EventArgs e)
        {
            FormMemberSearch frm = new FormMemberSearch();
            frm.MdiParent = this;
            frm.Show();

        }

        private void toolStripButtonRecipe_Click(object sender, EventArgs e)
        {   
            FormRecipeSearch frm = new FormRecipeSearch();
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void toolStripButtonProduct_Click(object sender, EventArgs e)
        {
            FormProductSearch frm = new FormProductSearch();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButtonOrder_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonAd_Click(object sender, EventArgs e)
        {
            FormMarketingSearch frm = new FormMarketingSearch();
            frm.MdiParent = this;
            frm.Show();

        }

		private void toolStripButtonCategory_Click(object sender, EventArgs e)
		{
            FormCategorySearch frm = new FormCategorySearch(); 
            frm.MdiParent = this;
            frm.Show();
		}
		void RemoveMdiBackColor()
		{
			foreach (Control c in this.Controls)
			{
				if (c is MdiClient)
				{
					c.BackColor = this.BackColor;
					c.BackgroundImage = this.BackgroundImage;
				}
			}
		}

	}
}
