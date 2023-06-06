﻿namespace FormMain
{
	partial class FormRecipeEdit
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
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCategory1 = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory2 = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory3 = new System.Windows.Forms.ComboBox();
            this.comboBoxCostMinutes = new System.Windows.Forms.ComboBox();
            this.comboBoxAmount = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonPrevious1 = new System.Windows.Forms.Button();
            this.buttonNext1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonPrevious2 = new System.Windows.Forms.Button();
            this.buttonNext2 = new System.Windows.Forms.Button();
            this.tableIngredient = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxFood1 = new System.Windows.Forms.TextBox();
            this.textBoxFoodAmount1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonIngredientAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPrevious3 = new System.Windows.Forms.Button();
            this.buttonNext3 = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonStepAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tableSteps = new System.Windows.Forms.TableLayoutPanel();
            this.labelStep1 = new System.Windows.Forms.Label();
            this.pictureStep1 = new System.Windows.Forms.PictureBox();
            this.textBoxStep1 = new System.Windows.Forms.TextBox();
            this.buttonStepDelete = new System.Windows.Forms.Button();
            this.buttonStepInsert = new System.Windows.Forms.Button();
            this.textBoxPublishedTime = new TextBoxAndTable.TextBoxCannotBeChanged();
            this.textBoxShortDescription = new TextBoxAndTable.TextBoxMultiline();
            this.textBoxAuthor = new TextBoxAndTable.TextBoxCannotBeChanged();
            this.textBoxRecipeName = new TextBoxAndTable.TextBoxWordLimit();
            this.textBoxRecipePk = new TextBoxAndTable.TextBoxCannotBeChanged();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableIngredient.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStep1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.Location = new System.Drawing.Point(151, 34);
            this.pictureBoxCover.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(486, 310);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCover.TabIndex = 0;
            this.pictureBoxCover.TabStop = false;
            // 
            // buttonUpload
            // 
            this.buttonUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(116)))), ((int)(((byte)(198)))));
            this.buttonUpload.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonUpload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.buttonUpload.Location = new System.Drawing.Point(674, 298);
            this.buttonUpload.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(158, 46);
            this.buttonUpload.TabIndex = 11;
            this.buttonUpload.Text = "上傳";
            this.buttonUpload.UseVisualStyleBackColor = false;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(21, 465);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "精選分類";
            // 
            // comboBoxCategory1
            // 
            this.comboBoxCategory1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxCategory1.FormattingEnabled = true;
            this.comboBoxCategory1.Location = new System.Drawing.Point(224, 461);
            this.comboBoxCategory1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCategory1.Name = "comboBoxCategory1";
            this.comboBoxCategory1.Size = new System.Drawing.Size(180, 38);
            this.comboBoxCategory1.TabIndex = 13;
            this.comboBoxCategory1.SelectedValueChanged += new System.EventHandler(this.comboBoxCategory1_SelectedValueChanged);
            // 
            // comboBoxCategory2
            // 
            this.comboBoxCategory2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxCategory2.FormattingEnabled = true;
            this.comboBoxCategory2.Location = new System.Drawing.Point(430, 461);
            this.comboBoxCategory2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCategory2.Name = "comboBoxCategory2";
            this.comboBoxCategory2.Size = new System.Drawing.Size(180, 38);
            this.comboBoxCategory2.TabIndex = 13;
            this.comboBoxCategory2.SelectedValueChanged += new System.EventHandler(this.comboBoxCategory2_SelectedValueChanged);
            // 
            // comboBoxCategory3
            // 
            this.comboBoxCategory3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxCategory3.FormattingEnabled = true;
            this.comboBoxCategory3.Location = new System.Drawing.Point(634, 461);
            this.comboBoxCategory3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCategory3.Name = "comboBoxCategory3";
            this.comboBoxCategory3.Size = new System.Drawing.Size(180, 38);
            this.comboBoxCategory3.TabIndex = 13;
            // 
            // comboBoxCostMinutes
            // 
            this.comboBoxCostMinutes.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxCostMinutes.FormattingEnabled = true;
            this.comboBoxCostMinutes.Location = new System.Drawing.Point(237, 877);
            this.comboBoxCostMinutes.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCostMinutes.Name = "comboBoxCostMinutes";
            this.comboBoxCostMinutes.Size = new System.Drawing.Size(180, 38);
            this.comboBoxCostMinutes.TabIndex = 13;
            // 
            // comboBoxAmount
            // 
            this.comboBoxAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(213)))), ((int)(((byte)(230)))));
            this.comboBoxAmount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxAmount.FormattingEnabled = true;
            this.comboBoxAmount.Location = new System.Drawing.Point(237, 954);
            this.comboBoxAmount.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAmount.Name = "comboBoxAmount";
            this.comboBoxAmount.Size = new System.Drawing.Size(180, 38);
            this.comboBoxAmount.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(21, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "封面圖";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(21, 882);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "花費時間(分鐘)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(21, 958);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "份量(人份)";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1501, 1463);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(230)))));
            this.tabPage1.Controls.Add(this.comboBoxAmount);
            this.tabPage1.Controls.Add(this.buttonPrevious1);
            this.tabPage1.Controls.Add(this.buttonNext1);
            this.tabPage1.Controls.Add(this.comboBoxCostMinutes);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.comboBoxCategory2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBoxCategory1);
            this.tabPage1.Controls.Add(this.comboBoxCategory3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.pictureBoxCover);
            this.tabPage1.Controls.Add(this.buttonUpload);
            this.tabPage1.Controls.Add(this.textBoxPublishedTime);
            this.tabPage1.Controls.Add(this.textBoxShortDescription);
            this.tabPage1.Controls.Add(this.textBoxAuthor);
            this.tabPage1.Controls.Add(this.textBoxRecipeName);
            this.tabPage1.Controls.Add(this.textBoxRecipePk);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1493, 1431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本資料";
            // 
            // buttonPrevious1
            // 
            this.buttonPrevious1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.buttonPrevious1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonPrevious1.ForeColor = System.Drawing.Color.Black;
            this.buttonPrevious1.Location = new System.Drawing.Point(48, 1351);
            this.buttonPrevious1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrevious1.Name = "buttonPrevious1";
            this.buttonPrevious1.Size = new System.Drawing.Size(158, 46);
            this.buttonPrevious1.TabIndex = 18;
            this.buttonPrevious1.Text = "上一步";
            this.buttonPrevious1.UseVisualStyleBackColor = false;
            this.buttonPrevious1.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext1
            // 
            this.buttonNext1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.buttonNext1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonNext1.ForeColor = System.Drawing.Color.Black;
            this.buttonNext1.Location = new System.Drawing.Point(246, 1351);
            this.buttonNext1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNext1.Name = "buttonNext1";
            this.buttonNext1.Size = new System.Drawing.Size(158, 46);
            this.buttonNext1.TabIndex = 18;
            this.buttonNext1.Text = "下一步";
            this.buttonNext1.UseVisualStyleBackColor = false;
            this.buttonNext1.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(230)))));
            this.tabPage2.Controls.Add(this.buttonPrevious2);
            this.tabPage2.Controls.Add(this.buttonNext2);
            this.tabPage2.Controls.Add(this.tableIngredient);
            this.tabPage2.Controls.Add(this.buttonIngredientAdd);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1493, 1431);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "食材";
            // 
            // buttonPrevious2
            // 
            this.buttonPrevious2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonPrevious2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.buttonPrevious2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonPrevious2.ForeColor = System.Drawing.Color.Black;
            this.buttonPrevious2.Location = new System.Drawing.Point(136, 1357);
            this.buttonPrevious2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrevious2.Name = "buttonPrevious2";
            this.buttonPrevious2.Size = new System.Drawing.Size(158, 46);
            this.buttonPrevious2.TabIndex = 19;
            this.buttonPrevious2.Text = "上一步";
            this.buttonPrevious2.UseVisualStyleBackColor = false;
            this.buttonPrevious2.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext2
            // 
            this.buttonNext2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNext2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.buttonNext2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonNext2.ForeColor = System.Drawing.Color.Black;
            this.buttonNext2.Location = new System.Drawing.Point(334, 1357);
            this.buttonNext2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNext2.Name = "buttonNext2";
            this.buttonNext2.Size = new System.Drawing.Size(158, 46);
            this.buttonNext2.TabIndex = 20;
            this.buttonNext2.Text = "下一步";
            this.buttonNext2.UseVisualStyleBackColor = false;
            this.buttonNext2.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // tableIngredient
            // 
            this.tableIngredient.ColumnCount = 4;
            this.tableIngredient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableIngredient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableIngredient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableIngredient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableIngredient.Controls.Add(this.textBoxFood1, 0, 0);
            this.tableIngredient.Controls.Add(this.textBoxFoodAmount1, 1, 0);
            this.tableIngredient.Controls.Add(this.button3, 2, 0);
            this.tableIngredient.Controls.Add(this.button4, 3, 0);
            this.tableIngredient.Location = new System.Drawing.Point(111, 48);
            this.tableIngredient.Name = "tableIngredient";
            this.tableIngredient.RowCount = 1;
            this.tableIngredient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableIngredient.Size = new System.Drawing.Size(784, 55);
            this.tableIngredient.TabIndex = 4;
            // 
            // textBoxFood1
            // 
            this.textBoxFood1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxFood1.Location = new System.Drawing.Point(3, 3);
            this.textBoxFood1.Name = "textBoxFood1";
            this.textBoxFood1.Size = new System.Drawing.Size(260, 39);
            this.textBoxFood1.TabIndex = 0;
            // 
            // textBoxFoodAmount1
            // 
            this.textBoxFoodAmount1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxFoodAmount1.Location = new System.Drawing.Point(277, 3);
            this.textBoxFoodAmount1.Name = "textBoxFoodAmount1";
            this.textBoxFoodAmount1.Size = new System.Drawing.Size(260, 39);
            this.textBoxFoodAmount1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(551, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "刪除";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(668, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 39);
            this.button4.TabIndex = 3;
            this.button4.Text = "插入";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // buttonIngredientAdd
            // 
            this.buttonIngredientAdd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonIngredientAdd.Location = new System.Drawing.Point(111, 124);
            this.buttonIngredientAdd.Name = "buttonIngredientAdd";
            this.buttonIngredientAdd.Size = new System.Drawing.Size(529, 48);
            this.buttonIngredientAdd.TabIndex = 2;
            this.buttonIngredientAdd.Text = "新增";
            this.buttonIngredientAdd.UseVisualStyleBackColor = true;
            this.buttonIngredientAdd.Click += new System.EventHandler(this.buttonIngredientAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(29, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "材料";
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(230)))));
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.buttonPrevious3);
            this.tabPage3.Controls.Add(this.buttonNext3);
            this.tabPage3.Controls.Add(this.buttonClear);
            this.tabPage3.Controls.Add(this.buttonSave);
            this.tabPage3.Controls.Add(this.buttonStepAdd);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.tableSteps);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1493, 1431);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "步驟";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(570, 335);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 161);
            this.panel1.TabIndex = 23;
            // 
            // buttonPrevious3
            // 
            this.buttonPrevious3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonPrevious3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.buttonPrevious3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonPrevious3.ForeColor = System.Drawing.Color.Black;
            this.buttonPrevious3.Location = new System.Drawing.Point(36, 1376);
            this.buttonPrevious3.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrevious3.Name = "buttonPrevious3";
            this.buttonPrevious3.Size = new System.Drawing.Size(158, 46);
            this.buttonPrevious3.TabIndex = 21;
            this.buttonPrevious3.Text = "上一步";
            this.buttonPrevious3.UseVisualStyleBackColor = false;
            this.buttonPrevious3.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext3
            // 
            this.buttonNext3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNext3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.buttonNext3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonNext3.ForeColor = System.Drawing.Color.Black;
            this.buttonNext3.Location = new System.Drawing.Point(234, 1376);
            this.buttonNext3.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNext3.Name = "buttonNext3";
            this.buttonNext3.Size = new System.Drawing.Size(158, 46);
            this.buttonNext3.TabIndex = 22;
            this.buttonNext3.Text = "下一步";
            this.buttonNext3.UseVisualStyleBackColor = false;
            this.buttonNext3.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.buttonClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonClear.ForeColor = System.Drawing.Color.Black;
            this.buttonClear.Location = new System.Drawing.Point(1118, 1363);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(158, 46);
            this.buttonClear.TabIndex = 20;
            this.buttonClear.Text = "取消";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(116)))), ((int)(((byte)(198)))));
            this.buttonSave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.buttonSave.Location = new System.Drawing.Point(1294, 1362);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(158, 46);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "儲存";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonStepAdd
            // 
            this.buttonStepAdd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonStepAdd.Location = new System.Drawing.Point(332, 285);
            this.buttonStepAdd.Name = "buttonStepAdd";
            this.buttonStepAdd.Size = new System.Drawing.Size(687, 44);
            this.buttonStepAdd.TabIndex = 2;
            this.buttonStepAdd.Text = "新增";
            this.buttonStepAdd.UseVisualStyleBackColor = true;
            this.buttonStepAdd.Click += new System.EventHandler(this.buttonStepAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(130, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 30);
            this.label6.TabIndex = 1;
            this.label6.Text = "步驟";
            // 
            // tableSteps
            // 
            this.tableSteps.ColumnCount = 5;
            this.tableSteps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableSteps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableSteps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableSteps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableSteps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableSteps.Controls.Add(this.labelStep1, 0, 0);
            this.tableSteps.Controls.Add(this.pictureStep1, 1, 0);
            this.tableSteps.Controls.Add(this.textBoxStep1, 2, 0);
            this.tableSteps.Controls.Add(this.buttonStepDelete, 3, 0);
            this.tableSteps.Controls.Add(this.buttonStepInsert, 4, 0);
            this.tableSteps.Location = new System.Drawing.Point(230, 40);
            this.tableSteps.Name = "tableSteps";
            this.tableSteps.RowCount = 1;
            this.tableSteps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 221F));
            this.tableSteps.Size = new System.Drawing.Size(992, 214);
            this.tableSteps.TabIndex = 0;
            // 
            // labelStep1
            // 
            this.labelStep1.AutoSize = true;
            this.labelStep1.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelStep1.Location = new System.Drawing.Point(3, 0);
            this.labelStep1.Name = "labelStep1";
            this.labelStep1.Size = new System.Drawing.Size(36, 40);
            this.labelStep1.TabIndex = 0;
            this.labelStep1.Text = "1";
            // 
            // pictureStep1
            // 
            this.pictureStep1.Location = new System.Drawing.Point(102, 3);
            this.pictureStep1.Name = "pictureStep1";
            this.pictureStep1.Size = new System.Drawing.Size(258, 194);
            this.pictureStep1.TabIndex = 1;
            this.pictureStep1.TabStop = false;
            // 
            // textBoxStep1
            // 
            this.textBoxStep1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxStep1.Location = new System.Drawing.Point(399, 3);
            this.textBoxStep1.Multiline = true;
            this.textBoxStep1.Name = "textBoxStep1";
            this.textBoxStep1.Size = new System.Drawing.Size(388, 194);
            this.textBoxStep1.TabIndex = 2;
            // 
            // buttonStepDelete
            // 
            this.buttonStepDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonStepDelete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonStepDelete.Location = new System.Drawing.Point(795, 181);
            this.buttonStepDelete.Name = "buttonStepDelete";
            this.buttonStepDelete.Size = new System.Drawing.Size(93, 37);
            this.buttonStepDelete.TabIndex = 3;
            this.buttonStepDelete.Text = "刪除";
            this.buttonStepDelete.UseVisualStyleBackColor = true;
            // 
            // buttonStepInsert
            // 
            this.buttonStepInsert.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonStepInsert.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonStepInsert.Location = new System.Drawing.Point(894, 181);
            this.buttonStepInsert.Name = "buttonStepInsert";
            this.buttonStepInsert.Size = new System.Drawing.Size(95, 37);
            this.buttonStepInsert.TabIndex = 4;
            this.buttonStepInsert.Text = "插入";
            this.buttonStepInsert.UseVisualStyleBackColor = true;
            // 
            // textBoxPublishedTime
            // 
            this.textBoxPublishedTime.afiledName = "發表時間";
            this.textBoxPublishedTime.afiledValue = "";
            this.textBoxPublishedTime.Location = new System.Drawing.Point(17, 780);
            this.textBoxPublishedTime.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxPublishedTime.Name = "textBoxPublishedTime";
            this.textBoxPublishedTime.Size = new System.Drawing.Size(975, 60);
            this.textBoxPublishedTime.TabIndex = 16;
            // 
            // textBoxShortDescription
            // 
            this.textBoxShortDescription.afiledMaxCount = 150;
            this.textBoxShortDescription.afiledName = "簡短說明";
            this.textBoxShortDescription.afiledValue = "";
            this.textBoxShortDescription.Location = new System.Drawing.Point(15, 1019);
            this.textBoxShortDescription.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxShortDescription.Name = "textBoxShortDescription";
            this.textBoxShortDescription.Size = new System.Drawing.Size(1335, 322);
            this.textBoxShortDescription.TabIndex = 17;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.afiledName = "作者PK";
            this.textBoxAuthor.afiledValue = "";
            this.textBoxAuthor.Location = new System.Drawing.Point(17, 695);
            this.textBoxAuthor.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(975, 60);
            this.textBoxAuthor.TabIndex = 16;
            // 
            // textBoxRecipeName
            // 
            this.textBoxRecipeName.afiledMaxCount = 20;
            this.textBoxRecipeName.afiledName = "食譜名稱";
            this.textBoxRecipeName.afiledValue = "";
            this.textBoxRecipeName.Location = new System.Drawing.Point(17, 610);
            this.textBoxRecipeName.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxRecipeName.Name = "textBoxRecipeName";
            this.textBoxRecipeName.Size = new System.Drawing.Size(1080, 60);
            this.textBoxRecipeName.TabIndex = 15;
            // 
            // textBoxRecipePk
            // 
            this.textBoxRecipePk.afiledName = "食譜PK";
            this.textBoxRecipePk.afiledValue = "";
            this.textBoxRecipePk.Location = new System.Drawing.Point(17, 530);
            this.textBoxRecipePk.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxRecipePk.Name = "textBoxRecipePk";
            this.textBoxRecipePk.Size = new System.Drawing.Size(975, 60);
            this.textBoxRecipePk.TabIndex = 14;
            // 
            // FormRecipeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRecipeEdit";
            this.Text = "FormRecipeEdit";
            this.Load += new System.EventHandler(this.FormRecipeEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tableIngredient.ResumeLayout(false);
            this.tableIngredient.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tableSteps.ResumeLayout(false);
            this.tableSteps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStep1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxCover;
		private System.Windows.Forms.Button buttonUpload;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxCategory1;
		private System.Windows.Forms.ComboBox comboBoxCategory2;
		private System.Windows.Forms.ComboBox comboBoxCategory3;
		private TextBoxAndTable.TextBoxCannotBeChanged textBoxRecipePk;
		private TextBoxAndTable.TextBoxWordLimit textBoxRecipeName;
		private TextBoxAndTable.TextBoxCannotBeChanged textBoxAuthor;
		private TextBoxAndTable.TextBoxCannotBeChanged textBoxPublishedTime;
		private TextBoxAndTable.TextBoxMultiline textBoxShortDescription;
		private System.Windows.Forms.ComboBox comboBoxCostMinutes;
		private System.Windows.Forms.ComboBox comboBoxAmount;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableSteps;
        private System.Windows.Forms.Label labelStep1;
        private System.Windows.Forms.PictureBox pictureStep1;
        private System.Windows.Forms.TextBox textBoxStep1;
        private System.Windows.Forms.Button buttonStepDelete;
        private System.Windows.Forms.Button buttonStepInsert;
        private System.Windows.Forms.Button buttonIngredientAdd;
        private System.Windows.Forms.TableLayoutPanel tableIngredient;
        private System.Windows.Forms.TextBox textBoxFood1;
        private System.Windows.Forms.TextBox textBoxFoodAmount1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonStepAdd;
        private System.Windows.Forms.Button buttonPrevious1;
        private System.Windows.Forms.Button buttonNext1;
        private System.Windows.Forms.Button buttonPrevious2;
        private System.Windows.Forms.Button buttonNext2;
        private System.Windows.Forms.Button buttonPrevious3;
        private System.Windows.Forms.Button buttonNext3;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panel1;
    }
}