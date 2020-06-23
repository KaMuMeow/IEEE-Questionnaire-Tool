namespace IEEE_Tool
{
    partial class SettingTopicForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Remove = new System.Windows.Forms.Button();
            this.Btn_Join = new System.Windows.Forms.Button();
            this.ListBox_SelectTopic = new System.Windows.Forms.ListBox();
            this.ListBox_JoinTopic = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Done = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ListBox_SelectTopic, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ListBox_JoinTopic, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Done, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Cancel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(562, 513);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("標楷體", 15F);
            this.label4.Location = new System.Drawing.Point(4, 446);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 67);
            this.label4.TabIndex = 8;
            this.label4.Text = "_(:3 」∠ )_";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Remove);
            this.panel1.Controls.Add(this.Btn_Join);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(185, 71);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 371);
            this.panel1.TabIndex = 0;
            // 
            // Btn_Remove
            // 
            this.Btn_Remove.Location = new System.Drawing.Point(45, 204);
            this.Btn_Remove.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Remove.Name = "Btn_Remove";
            this.Btn_Remove.Size = new System.Drawing.Size(100, 50);
            this.Btn_Remove.TabIndex = 1;
            this.Btn_Remove.Text = "<<";
            this.Btn_Remove.UseVisualStyleBackColor = true;
            this.Btn_Remove.Click += new System.EventHandler(this.Btn_Remove_Click);
            // 
            // Btn_Join
            // 
            this.Btn_Join.Location = new System.Drawing.Point(45, 96);
            this.Btn_Join.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Join.Name = "Btn_Join";
            this.Btn_Join.Size = new System.Drawing.Size(100, 50);
            this.Btn_Join.TabIndex = 0;
            this.Btn_Join.Text = ">>";
            this.Btn_Join.UseVisualStyleBackColor = true;
            this.Btn_Join.Click += new System.EventHandler(this.Btn_Join_Click);
            // 
            // ListBox_SelectTopic
            // 
            this.ListBox_SelectTopic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBox_SelectTopic.FormattingEnabled = true;
            this.ListBox_SelectTopic.ItemHeight = 16;
            this.ListBox_SelectTopic.Location = new System.Drawing.Point(4, 71);
            this.ListBox_SelectTopic.Margin = new System.Windows.Forms.Padding(4);
            this.ListBox_SelectTopic.Name = "ListBox_SelectTopic";
            this.ListBox_SelectTopic.Size = new System.Drawing.Size(173, 371);
            this.ListBox_SelectTopic.TabIndex = 1;
            // 
            // ListBox_JoinTopic
            // 
            this.ListBox_JoinTopic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBox_JoinTopic.FormattingEnabled = true;
            this.ListBox_JoinTopic.ItemHeight = 16;
            this.ListBox_JoinTopic.Location = new System.Drawing.Point(385, 71);
            this.ListBox_JoinTopic.Margin = new System.Windows.Forms.Padding(4);
            this.ListBox_JoinTopic.Name = "ListBox_JoinTopic";
            this.ListBox_JoinTopic.Size = new System.Drawing.Size(173, 371);
            this.ListBox_JoinTopic.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 67);
            this.label1.TabIndex = 3;
            this.label1.Text = "未加入題目";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(385, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 67);
            this.label2.TabIndex = 4;
            this.label2.Text = "已加入題目";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Done
            // 
            this.Btn_Done.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Done.Location = new System.Drawing.Point(185, 450);
            this.Btn_Done.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Done.Name = "Btn_Done";
            this.Btn_Done.Size = new System.Drawing.Size(192, 59);
            this.Btn_Done.TabIndex = 5;
            this.Btn_Done.Text = "確認";
            this.Btn_Done.UseVisualStyleBackColor = true;
            this.Btn_Done.Click += new System.EventHandler(this.Btn_Done_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Cancel.Location = new System.Drawing.Point(385, 450);
            this.Btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(173, 59);
            this.Btn_Cancel.TabIndex = 6;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("標楷體", 50F);
            this.label3.Location = new System.Drawing.Point(185, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 67);
            this.label3.TabIndex = 7;
            this.label3.Text = "OuO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingTopicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 513);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("標楷體", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingTopicForm";
            this.Text = "SettingTopic";
            this.Load += new System.EventHandler(this.SettingTopicForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox ListBox_SelectTopic;
        private System.Windows.Forms.ListBox ListBox_JoinTopic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Remove;
        private System.Windows.Forms.Button Btn_Join;
        private System.Windows.Forms.Button Btn_Done;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}