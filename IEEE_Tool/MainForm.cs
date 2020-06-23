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
using IEEE_Tool.Parmeter;
namespace IEEE_Tool
{
    public partial class MainForm : Form,View_MainForm
    {
        #region 介面的實作都放在這
        public Button View_Btn_SetTopic => Btn_SetTopic;
        public Button View_Btn_Reset => Btn_Reset;
        public Button View_Btn_Check => Btn_Check;

        public ComboBox View_Combox_SelectQuestionnaire => Combox_SelectQuestionnaire;

        public ListView View_ListView_TopicList => ListView_TopicList;

        public TextBox View_TextBox_Input => TextBox_Input;

        public Label View_Label_AnswerAmount => Label_AnswerAmount;
        #endregion

        Pst_MainForm My_Pst;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            My_Pst = new Pst_MainForm(this);
        }

        private void Btn_SetTopic_Click(object sender, EventArgs e)
        {
            My_Pst.OpenSettingTopicForm();
        }

        private void Btn_Check_Click(object sender, EventArgs e)
        {
            My_Pst.Check();
        }

        private void Combox_SelectQuestionnaire_SelectedIndexChanged(object sender, EventArgs e)
        {
            My_Pst.ShowAnswer();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            My_Pst.KeyDown(e);
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            My_Pst.Reset();
        }
    }
}
