namespace FormMain
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonMember = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonRecipe = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonCategory = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonProduct = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonOrder = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonAd = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonLeave = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonMember,
            this.toolStripButtonRecipe,
            this.toolStripButtonCategory,
            this.toolStripButtonProduct,
            this.toolStripButtonOrder,
            this.toolStripButtonAd,
            this.toolStripButtonLeave});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1265, 39);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButtonMember
			// 
			this.toolStripButtonMember.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.toolStripButtonMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(251)))));
			this.toolStripButtonMember.Image = global::FormMain.Properties.Resources.group;
			this.toolStripButtonMember.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonMember.Name = "toolStripButtonMember";
			this.toolStripButtonMember.Size = new System.Drawing.Size(109, 36);
			this.toolStripButtonMember.Text = "會員管理";
			this.toolStripButtonMember.Click += new System.EventHandler(this.toolStripButtonMember_Click);
			// 
			// toolStripButtonRecipe
			// 
			this.toolStripButtonRecipe.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.toolStripButtonRecipe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(251)))));
			this.toolStripButtonRecipe.Image = global::FormMain.Properties.Resources.recipe_book;
			this.toolStripButtonRecipe.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonRecipe.Name = "toolStripButtonRecipe";
			this.toolStripButtonRecipe.Size = new System.Drawing.Size(109, 36);
			this.toolStripButtonRecipe.Text = "食譜管理";
			this.toolStripButtonRecipe.Click += new System.EventHandler(this.toolStripButtonRecipe_Click);
			// 
			// toolStripButtonCategory
			// 
			this.toolStripButtonCategory.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.toolStripButtonCategory.ForeColor = System.Drawing.Color.White;
			this.toolStripButtonCategory.Image = global::FormMain.Properties.Resources.drawer;
			this.toolStripButtonCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonCategory.Name = "toolStripButtonCategory";
			this.toolStripButtonCategory.Size = new System.Drawing.Size(141, 36);
			this.toolStripButtonCategory.Text = "精選分類管理";
			this.toolStripButtonCategory.Click += new System.EventHandler(this.toolStripButtonCategory_Click);
			// 
			// toolStripButtonProduct
			// 
			this.toolStripButtonProduct.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.toolStripButtonProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(251)))));
			this.toolStripButtonProduct.Image = global::FormMain.Properties.Resources.merchandising;
			this.toolStripButtonProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonProduct.Name = "toolStripButtonProduct";
			this.toolStripButtonProduct.Size = new System.Drawing.Size(109, 36);
			this.toolStripButtonProduct.Text = "商品管理";
			this.toolStripButtonProduct.Click += new System.EventHandler(this.toolStripButtonProduct_Click);
			// 
			// toolStripButtonOrder
			// 
			this.toolStripButtonOrder.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.toolStripButtonOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(251)))));
			this.toolStripButtonOrder.Image = global::FormMain.Properties.Resources.checklist;
			this.toolStripButtonOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonOrder.Name = "toolStripButtonOrder";
			this.toolStripButtonOrder.Size = new System.Drawing.Size(109, 36);
			this.toolStripButtonOrder.Text = "訂單管理";
			this.toolStripButtonOrder.Click += new System.EventHandler(this.toolStripButtonOrder_Click);
			// 
			// toolStripButtonAd
			// 
			this.toolStripButtonAd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.toolStripButtonAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(251)))));
			this.toolStripButtonAd.Image = global::FormMain.Properties.Resources.online_advertising;
			this.toolStripButtonAd.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonAd.Name = "toolStripButtonAd";
			this.toolStripButtonAd.Size = new System.Drawing.Size(141, 36);
			this.toolStripButtonAd.Text = "廣告板位設定";
			this.toolStripButtonAd.Click += new System.EventHandler(this.toolStripButtonAd_Click);
			// 
			// toolStripButtonLeave
			// 
			this.toolStripButtonLeave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.toolStripButtonLeave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(251)))));
			this.toolStripButtonLeave.Image = global::FormMain.Properties.Resources.exit_full_screen;
			this.toolStripButtonLeave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonLeave.Name = "toolStripButtonLeave";
			this.toolStripButtonLeave.Size = new System.Drawing.Size(77, 36);
			this.toolStripButtonLeave.Text = "離開";
			this.toolStripButtonLeave.Click += new System.EventHandler(this.toolStripButtonLeave_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(230)))));
			this.ClientSize = new System.Drawing.Size(1265, 683);
			this.Controls.Add(this.toolStrip1);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.IsMdiContainer = true;
			this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.Name = "FormMain";
			this.Text = "UCook後台系統";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton toolStripButtonMember;
        private System.Windows.Forms.ToolStripButton toolStripButtonRecipe;
        private System.Windows.Forms.ToolStripButton toolStripButtonProduct;
        private System.Windows.Forms.ToolStripButton toolStripButtonOrder;
        private System.Windows.Forms.ToolStripButton toolStripButtonAd;
        private System.Windows.Forms.ToolStripButton toolStripButtonLeave;
        private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButtonCategory;
	}
}