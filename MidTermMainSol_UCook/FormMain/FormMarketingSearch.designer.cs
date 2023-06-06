namespace FormMain
{
	partial class FormMarketingSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMarketingSearch));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CAMPAIGN活動_PK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpacePK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Impression = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Click = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operation = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LabelRowCount = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textboxSearch = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPageA1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPageA2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPageA3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPageB1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPageB2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPageB3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPageC = new System.Windows.Forms.ToolStripButton();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.toast = new FormItem.Toast();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Checkbox,
            this.CAMPAIGN活動_PK,
            this.SpacePK,
            this.startDate,
            this.endDate,
            this.Title,
            this.URL,
            this.Impression,
            this.Click,
            this.CTR,
            this.Operation});
            this.dataGridView1.Location = new System.Drawing.Point(49, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 589);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // Checkbox
            // 
            this.Checkbox.HeaderText = "請選取";
            this.Checkbox.Name = "Checkbox";
            this.Checkbox.Width = 50;
            // 
            // CAMPAIGN活動_PK
            // 
            this.CAMPAIGN活動_PK.DataPropertyName = "CAMPAIGN活動_PK";
            this.CAMPAIGN活動_PK.HeaderText = "Id";
            this.CAMPAIGN活動_PK.Name = "CAMPAIGN活動_PK";
            this.CAMPAIGN活動_PK.Visible = false;
            // 
            // SpacePK
            // 
            this.SpacePK.DataPropertyName = "AD_SPACE廣告版面_PK";
            this.SpacePK.HeaderText = "版面編號";
            this.SpacePK.Name = "SpacePK";
            this.SpacePK.Visible = false;
            // 
            // startDate
            // 
            this.startDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.startDate.DataPropertyName = "START_TIME開始時間";
            this.startDate.HeaderText = "開始日期";
            this.startDate.Name = "startDate";
            this.startDate.ReadOnly = true;
            // 
            // endDate
            // 
            this.endDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.endDate.DataPropertyName = "END_TIME結束時間";
            this.endDate.HeaderText = "結束日期";
            this.endDate.Name = "endDate";
            this.endDate.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.DataPropertyName = "CAMPAIGN_NAME活動名稱";
            this.Title.HeaderText = "標題";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // URL
            // 
            this.URL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.URL.DataPropertyName = "URL連結";
            this.URL.HeaderText = "連結";
            this.URL.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.URL.Name = "URL";
            this.URL.ReadOnly = true;
            this.URL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.URL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.URL.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            // 
            // Impression
            // 
            this.Impression.DataPropertyName = "Impression曝光數";
            this.Impression.HeaderText = "曝光數";
            this.Impression.Name = "Impression";
            this.Impression.ReadOnly = true;
            this.Impression.Width = 150;
            // 
            // Click
            // 
            this.Click.DataPropertyName = "Click點擊數";
            this.Click.HeaderText = "點擊數";
            this.Click.Name = "Click";
            this.Click.ReadOnly = true;
            this.Click.Width = 150;
            // 
            // CTR
            // 
            this.CTR.DataPropertyName = "CTR點擊率";
            dataGridViewCellStyle2.NullValue = null;
            this.CTR.DefaultCellStyle = dataGridViewCellStyle2;
            this.CTR.HeaderText = "點擊率";
            this.CTR.Name = "CTR";
            this.CTR.ReadOnly = true;
            this.CTR.Width = 150;
            // 
            // Operation
            // 
            this.Operation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Operation.HeaderText = "操作";
            this.Operation.Name = "Operation";
            this.Operation.Text = "修改";
            this.Operation.ToolTipText = "修改";
            this.Operation.UseColumnTextForButtonValue = true;
            // 
            // LabelRowCount
            // 
            this.LabelRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelRowCount.AutoSize = true;
            this.LabelRowCount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabelRowCount.Location = new System.Drawing.Point(957, 102);
            this.LabelRowCount.Name = "LabelRowCount";
            this.LabelRowCount.Size = new System.Drawing.Size(83, 20);
            this.LabelRowCount.TabIndex = 5;
            this.LabelRowCount.Text = "總共OO筆";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.buttonCancel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.Location = new System.Drawing.Point(825, 91);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(105, 31);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "清除";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(116)))), ((int)(((byte)(198)))));
            this.buttonSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.buttonSearch.Location = new System.Drawing.Point(714, 91);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(105, 31);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "查詢";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textboxSearch
            // 
            this.textboxSearch.Font = new System.Drawing.Font("微軟正黑體 Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textboxSearch.ForeColor = System.Drawing.Color.Black;
            this.textboxSearch.Location = new System.Drawing.Point(232, 91);
            this.textboxSearch.Multiline = true;
            this.textboxSearch.Name = "textboxSearch";
            this.textboxSearch.Size = new System.Drawing.Size(467, 31);
            this.textboxSearch.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(8);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPageA1,
            this.toolStripButtonPageA2,
            this.toolStripButtonPageA3,
            this.toolStripButtonPageB1,
            this.toolStripButtonPageB2,
            this.toolStripButtonPageB3,
            this.toolStripButtonPageC});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(49, 45);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(737, 27);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonPageA1
            // 
            this.toolStripButtonPageA1.CheckOnClick = true;
            this.toolStripButtonPageA1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStripButtonPageA1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPageA1.Image")));
            this.toolStripButtonPageA1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPageA1.Name = "toolStripButtonPageA1";
            this.toolStripButtonPageA1.Size = new System.Drawing.Size(88, 24);
            this.toolStripButtonPageA1.Text = "首頁A-1";
            this.toolStripButtonPageA1.Click += new System.EventHandler(this.toolStripButtonPageA1_Click);
            // 
            // toolStripButtonPageA2
            // 
            this.toolStripButtonPageA2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStripButtonPageA2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPageA2.Image")));
            this.toolStripButtonPageA2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPageA2.Name = "toolStripButtonPageA2";
            this.toolStripButtonPageA2.Size = new System.Drawing.Size(88, 24);
            this.toolStripButtonPageA2.Text = "首頁A-2";
            this.toolStripButtonPageA2.Click += new System.EventHandler(this.toolStripButtonPageA2_Click);
            // 
            // toolStripButtonPageA3
            // 
            this.toolStripButtonPageA3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStripButtonPageA3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPageA3.Image")));
            this.toolStripButtonPageA3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPageA3.Name = "toolStripButtonPageA3";
            this.toolStripButtonPageA3.Size = new System.Drawing.Size(88, 24);
            this.toolStripButtonPageA3.Text = "首頁A-3";
            this.toolStripButtonPageA3.Click += new System.EventHandler(this.toolStripButtonPageA3_Click);
            // 
            // toolStripButtonPageB1
            // 
            this.toolStripButtonPageB1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStripButtonPageB1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPageB1.Image")));
            this.toolStripButtonPageB1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPageB1.Name = "toolStripButtonPageB1";
            this.toolStripButtonPageB1.Size = new System.Drawing.Size(128, 24);
            this.toolStripButtonPageB1.Text = "搜尋結果頁B1";
            this.toolStripButtonPageB1.Click += new System.EventHandler(this.toolStripButtonPageB1_Click);
            // 
            // toolStripButtonPageB2
            // 
            this.toolStripButtonPageB2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStripButtonPageB2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPageB2.Image")));
            this.toolStripButtonPageB2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPageB2.Name = "toolStripButtonPageB2";
            this.toolStripButtonPageB2.Size = new System.Drawing.Size(128, 24);
            this.toolStripButtonPageB2.Text = "搜尋結果頁B2";
            this.toolStripButtonPageB2.Click += new System.EventHandler(this.toolStripButtonPageB2_Click);
            // 
            // toolStripButtonPageB3
            // 
            this.toolStripButtonPageB3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStripButtonPageB3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPageB3.Image")));
            this.toolStripButtonPageB3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPageB3.Name = "toolStripButtonPageB3";
            this.toolStripButtonPageB3.Size = new System.Drawing.Size(128, 24);
            this.toolStripButtonPageB3.Text = "搜尋結果頁B3";
            this.toolStripButtonPageB3.Click += new System.EventHandler(this.toolStripButtonPageB3_Click);
            // 
            // toolStripButtonPageC
            // 
            this.toolStripButtonPageC.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStripButtonPageC.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPageC.Image")));
            this.toolStripButtonPageC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPageC.Name = "toolStripButtonPageC";
            this.toolStripButtonPageC.Size = new System.Drawing.Size(88, 24);
            this.toolStripButtonPageC.Text = "個人頁C";
            this.toolStripButtonPageC.Click += new System.EventHandler(this.toolStripButtonPageC_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonAdd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.buttonAdd.Location = new System.Drawing.Point(946, 35);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(116, 43);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "新增活動";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(49, 91);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(177, 28);
            this.comboBoxType.TabIndex = 6;
            // 
            // toast
            // 
            this.toast.AMessage = "儲存成功";
            this.toast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toast.Location = new System.Drawing.Point(12, 678);
            this.toast.Name = "toast";
            this.toast.Size = new System.Drawing.Size(203, 55);
            this.toast.TabIndex = 1;
            this.toast.Visible = false;
            // 
            // FormSearch
            // 
            this.AcceptButton = this.buttonSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 745);
            this.Controls.Add(this.toast);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textboxSearch);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.LabelRowCount);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormSearch";
            this.Text = "廣告版面搜尋";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private FormItem.Toast toast;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label LabelRowCount;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textboxSearch;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonPageC;
        private System.Windows.Forms.ToolStripButton toolStripButtonPageA1;
        private System.Windows.Forms.ToolStripButton toolStripButtonPageA2;
        private System.Windows.Forms.ToolStripButton toolStripButtonPageA3;
        private System.Windows.Forms.ToolStripButton toolStripButtonPageB1;
        private System.Windows.Forms.ToolStripButton toolStripButtonPageB2;
        private System.Windows.Forms.ToolStripButton toolStripButtonPageB3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Checkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAMPAIGN活動_PK;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpacePK;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewLinkColumn URL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impression;
        private System.Windows.Forms.DataGridViewTextBoxColumn Click;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTR;
        private System.Windows.Forms.DataGridViewButtonColumn Operation;
        private System.Windows.Forms.ComboBox comboBoxType;
    }
}