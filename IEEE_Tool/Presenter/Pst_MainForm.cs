using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IEEE_Tool.View;
using IEEE_Tool.Model;
using IEEE_Tool.Parmeter;
using System.Windows.Forms;

namespace IEEE_Tool.Presenter
{
    public class Pst_MainForm
    {
        View_MainForm My_View;

        public Pst_MainForm(View_MainForm TmpView)
        {
            My_View = TmpView;
        }


        /// <summary>
        /// 開啟設定題號的視窗
        /// </summary>
        public void OpenSettingTopicForm()
        {
            SettingTopicForm TopicForm = new SettingTopicForm();
            TopicForm.Event_DoneSetting += ShowTopic;
            TopicForm.ShowDialog();
        }


        /// <summary>
        /// 當設定題目完成時會呼叫的事件，重新整理並寫顯示題目在列表上
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ShowTopic(object sender,EventArgs e)
        {
            My_View.View_ListView_TopicList.Items.Clear();
            My_View.View_Combox_SelectQuestionnaire.Items.Clear();
            foreach (Par_NewListViewItem GetItem in Model_MainControl.TopicList)
            {
                My_View.View_ListView_TopicList.Items.Add(GetItem);
                GetItem.AttachListView(My_View.View_ListView_TopicList);
            }
            My_View.View_Label_AnswerAmount.Text = "/ " + Model_MainControl.SaveAnswer.Count();
        }

        /// <summary>
        /// 重置整份問卷
        /// </summary>
        public void Reset()
        {
            DialogResult Ans = MessageBox.Show("確定要重置問卷統計嗎?", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (Ans == DialogResult.OK)
            {
                Model_MainControl.Reset();
                My_View.View_Label_AnswerAmount.Text = "/ " + Model_MainControl.SaveAnswer.Count();
                My_View.View_Combox_SelectQuestionnaire.Text = "0";
                My_View.View_Combox_SelectQuestionnaire.Items.Clear();
            }
        }


        public void KeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Check();
        }

        /// <summary>
        /// 確定輸入該問卷的答案
        /// </summary>
        public void Check()
        {
            string GetInput = My_View.View_TextBox_Input.Text; //取得文字輸入的答案

            //透過輸入的方式勾選答案
            if(GetInput.Length!=Model_MainControl.TopicList.Count() && GetInput!="")
            {
                MessageBox.Show(string.Format("總共有 {0} 題要輸入，你輸入了 {1} 題目喔~", Model_MainControl.TopicList.Count(), GetInput.Length),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else if(GetInput.Length == Model_MainControl.TopicList.Count())
            {
                if (Model_MainControl.InputCheck(GetInput))
                    My_View.View_TextBox_Input.Text = "";
            }

            //檢查是否所有題目都有被選擇到
            foreach(Par_NewListViewItem GetItem in Model_MainControl.TopicList)
            {
                if (!GetItem.Check())
                {
                    MessageBox.Show(string.Format("{0}尚未勾選!", GetItem.Text), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string Answer = "";
            //開始記錄答案
            if (My_View.View_Combox_SelectQuestionnaire.Text == "0")
            {
                //確定沒問題就記錄下這份問卷
                foreach (Par_NewListViewItem GetItem in Model_MainControl.TopicList)
                {
                    Answer += GetItem.Done().ToString();
                }
                Model_MainControl.AddAnswer(Answer);
                My_View.View_Combox_SelectQuestionnaire.Items.Add(Model_MainControl.SaveAnswer.Count());
            }
            else
            {
                DialogResult Ans = MessageBox.Show("確定要修改這份問卷嗎?", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (Ans == DialogResult.OK)
                {
                    //重新取得這份問卷的答案
                    foreach (Par_NewListViewItem GetItem in Model_MainControl.TopicList)
                    {
                        //false不紀錄但是取得回傳的結果
                        Answer += GetItem.Done(false).ToString();
                    }
                    //修改該問卷的回答
                    Model_MainControl.ModifyAnswer(My_View.View_Combox_SelectQuestionnaire.SelectedIndex,Answer);
                }
            }
            My_View.View_Label_AnswerAmount.Text = "/ " + Model_MainControl.SaveAnswer.Count();
            My_View.View_Combox_SelectQuestionnaire.Text = "0";
        }

        //顯示之前的答案
        public void ShowAnswer()
        {
            int GetSelectIdx = My_View.View_Combox_SelectQuestionnaire.SelectedIndex;
            if (GetSelectIdx == -1 || GetSelectIdx >= Model_MainControl.SaveAnswer.Count)
                return;
            //顯示之前記錄下來的答案
            Model_MainControl.InputCheck(Model_MainControl.SaveAnswer[GetSelectIdx]);
        }

        public void ExportCsv()
        {
            DialogResult Ans = MessageBox.Show("確定輸出.Csv嗎?","Info",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if (Ans == DialogResult.OK)
            {
                Model_MainControl.ExportCsv();
            }
        }
    }
}
