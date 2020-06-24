namespace IEEE_Tool
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_SetTopic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_Input = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Check = new System.Windows.Forms.Button();
            this.Label_AnswerAmount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Combox_SelectQuestionnaire = new System.Windows.Forms.ComboBox();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.ListView_TopicList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Btn_Export = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_SetTopic
            // 
            this.Btn_SetTopic.Location = new System.Drawing.Point(14, 12);
            this.Btn_SetTopic.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_SetTopic.Name = "Btn_SetTopic";
            this.Btn_SetTopic.Size = new System.Drawing.Size(112, 31);
            this.Btn_SetTopic.TabIndex = 0;
            this.Btn_SetTopic.Text = "設定題號";
            this.Btn_SetTopic.UseVisualStyleBackColor = true;
            this.Btn_SetTopic.Click += new System.EventHandler(this.Btn_SetTopic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "輸入：";
            // 
            // TextBox_Input
            // 
            this.TextBox_Input.Location = new System.Drawing.Point(328, 12);
            this.TextBox_Input.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_Input.Name = "TextBox_Input";
            this.TextBox_Input.Size = new System.Drawing.Size(264, 27);
            this.TextBox_Input.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ListView_TopicList, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1096, 652);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Export);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Btn_Check);
            this.panel1.Controls.Add(this.Label_AnswerAmount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Combox_SelectQuestionnaire);
            this.panel1.Controls.Add(this.Btn_Reset);
            this.panel1.Controls.Add(this.TextBox_Input);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Btn_SetTopic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 59);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 9F);
            this.label3.Location = new System.Drawing.Point(326, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "使用說明:共有5題的話，33112這樣的格式做輸入";
            // 
            // Btn_Check
            // 
            this.Btn_Check.Location = new System.Drawing.Point(600, 12);
            this.Btn_Check.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Check.Name = "Btn_Check";
            this.Btn_Check.Size = new System.Drawing.Size(93, 31);
            this.Btn_Check.TabIndex = 8;
            this.Btn_Check.Text = "輸入";
            this.Btn_Check.UseVisualStyleBackColor = true;
            this.Btn_Check.Click += new System.EventHandler(this.Btn_Check_Click);
            // 
            // Label_AnswerAmount
            // 
            this.Label_AnswerAmount.AutoSize = true;
            this.Label_AnswerAmount.Location = new System.Drawing.Point(845, 19);
            this.Label_AnswerAmount.Name = "Label_AnswerAmount";
            this.Label_AnswerAmount.Size = new System.Drawing.Size(24, 16);
            this.Label_AnswerAmount.TabIndex = 7;
            this.Label_AnswerAmount.Text = "/ 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(711, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "問卷數量";
            // 
            // Combox_SelectQuestionnaire
            // 
            this.Combox_SelectQuestionnaire.FormattingEnabled = true;
            this.Combox_SelectQuestionnaire.Location = new System.Drawing.Point(789, 16);
            this.Combox_SelectQuestionnaire.Name = "Combox_SelectQuestionnaire";
            this.Combox_SelectQuestionnaire.Size = new System.Drawing.Size(50, 24);
            this.Combox_SelectQuestionnaire.TabIndex = 5;
            this.Combox_SelectQuestionnaire.Text = "0";
            this.Combox_SelectQuestionnaire.SelectedIndexChanged += new System.EventHandler(this.Combox_SelectQuestionnaire_SelectedIndexChanged);
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Location = new System.Drawing.Point(134, 12);
            this.Btn_Reset.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(93, 31);
            this.Btn_Reset.TabIndex = 4;
            this.Btn_Reset.Text = "重置";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // ListView_TopicList
            // 
            this.ListView_TopicList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.ListView_TopicList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView_TopicList.GridLines = true;
            this.ListView_TopicList.HideSelection = false;
            this.ListView_TopicList.Location = new System.Drawing.Point(4, 71);
            this.ListView_TopicList.Margin = new System.Windows.Forms.Padding(4);
            this.ListView_TopicList.MultiSelect = false;
            this.ListView_TopicList.Name = "ListView_TopicList";
            this.ListView_TopicList.Size = new System.Drawing.Size(1088, 577);
            this.ListView_TopicList.TabIndex = 1;
            this.ListView_TopicList.UseCompatibleStateImageBehavior = false;
            this.ListView_TopicList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "題目";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "非常同意";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 30;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "同意";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 30;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "普通";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 30;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "不同意";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 30;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "非常不同意";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 30;
            // 
            // Btn_Export
            // 
            this.Btn_Export.Location = new System.Drawing.Point(986, 12);
            this.Btn_Export.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Export.Name = "Btn_Export";
            this.Btn_Export.Size = new System.Drawing.Size(93, 31);
            this.Btn_Export.TabIndex = 10;
            this.Btn_Export.Text = "匯出.Csv";
            this.Btn_Export.UseVisualStyleBackColor = true;
            this.Btn_Export.Click += new System.EventHandler(this.Btn_Export_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 652);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("新細明體", 12F);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "IEEE Tool By:Xi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_SetTopic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_Input;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.ListView ListView_TopicList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ComboBox Combox_SelectQuestionnaire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_AnswerAmount;
        private System.Windows.Forms.Button Btn_Check;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Export;
    }
}

