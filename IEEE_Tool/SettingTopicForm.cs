using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEEE_Tool.View;
using IEEE_Tool.Presenter;
namespace IEEE_Tool
{
    public partial class SettingTopicForm : Form,View_SettingTopic
    {
        //增加一個自定義的事件，當完成設定時呼叫主視窗刷新題目
        public EventHandler Event_DoneSetting;

        #region 實作介面都放在這
        public Button View_Btn_Done => Btn_Done;
        public Button View_Btn_Cancel => Btn_Cancel;
        public Button View_Btn_Join => Btn_Join;
        public Button View_Btn_Remove => Btn_Remove;

        public ListBox View_ListBox_SelectTopic => ListBox_SelectTopic;
        public ListBox View_ListBox_JoinTopic => ListBox_JoinTopic;
        #endregion

        Pst_SettingTopic My_Pst;
        public SettingTopicForm()
        {
            InitializeComponent();
        }

        private void SettingTopicForm_Load(object sender, EventArgs e)
        {
            My_Pst = new Pst_SettingTopic(this);
        }

        private void Btn_Join_Click(object sender, EventArgs e)
        {
            My_Pst.JoinTopic();
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            My_Pst.RemoveTopic();
        }

        private void Btn_Done_Click(object sender, EventArgs e)
        {
            My_Pst.Done();
            //傳送事件完成的通知
            Event_DoneSetting?.Invoke(null, null);
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
