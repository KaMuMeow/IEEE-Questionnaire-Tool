using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IEEE_Tool.View;
using IEEE_Tool.Parmeter;
using IEEE_Tool.Model;
namespace IEEE_Tool.Presenter
{
    public class Pst_SettingTopic
    {
        private View_SettingTopic My_View;
        public Pst_SettingTopic(View_SettingTopic TmpView)
        {
            My_View = TmpView;
            init();
        }

        //初始化表單的顯示狀況
        private void init()
        {
            //初始化30個題目在未加入的題目當中
            for (int i = 1; i <= 30;i++)
            {
                My_View.View_ListBox_SelectTopic.Items.Add(string.Format("No.{0}", i));
            }

            //將已加入的題目剔除掉
            foreach(Par_NewListViewItem GetTopic in Model_MainControl.TopicList)
            {
                int GetIndex = My_View.View_ListBox_SelectTopic.Items.IndexOf(GetTopic.Text);
                if(GetIndex !=-1)
                {
                    My_View.View_ListBox_SelectTopic.Items.RemoveAt(GetIndex);
                    My_View.View_ListBox_JoinTopic.Items.Add(GetTopic.Text);
                }
            }
        }

        /// <summary>
        /// 加入要記錄的題目
        /// </summary>
        public void JoinTopic()
        {
            //防呆，避免選擇的索引值找不到
            if(My_View.View_ListBox_SelectTopic.SelectedIndex==-1)
                return;
            //取得ListBox內的題號
            string GetTopic = My_View.View_ListBox_SelectTopic.SelectedItem.ToString();
            My_View.View_ListBox_SelectTopic.Items.Remove(GetTopic); //從未加入題目中移除
            My_View.View_ListBox_JoinTopic.Items.Add(GetTopic); //將題目移動到已加入的題號表單
        }

        /// <summary>
        /// 移除題目
        /// </summary>
        public void RemoveTopic()
        {
            if (My_View.View_ListBox_JoinTopic.SelectedIndex == -1)
                return;
            //取得ListBox內的題號
            int GetTopicIdx = My_View.View_ListBox_JoinTopic.SelectedIndex;
            string GetTopic = My_View.View_ListBox_JoinTopic.SelectedItem.ToString();
            My_View.View_ListBox_JoinTopic.Items.RemoveAt(GetTopicIdx); //從已加入題目中移除

            My_View.View_ListBox_SelectTopic.Items.Add(GetTopic); //將題目移動到位加入的表單內
        }

        /// <summary>
        /// 確定要新增的題目
        /// </summary>
        public void Done()
        {
            List<string> TopicNameList = new List<string>(); //紀錄題目名稱
            List<int> SortIdx = new List<int>(); //紀錄題目的序號，等等排序時要使用
            for (int i = 0; i < My_View.View_ListBox_JoinTopic.Items.Count;i++)
            {
                string GetName = My_View.View_ListBox_JoinTopic.Items[i].ToString(); //取得題目名稱
                int GetIdx = int.Parse(GetName.Substring(3, GetName.Length - 3)); //透過名稱取出題目序號
                TopicNameList.Add(GetName); //加入題目名稱
                SortIdx.Add(GetIdx); //加入題目的序號
            }
            string[] NameArray = TopicNameList.ToArray();
            Array.Sort(SortIdx.ToArray(), NameArray); //透過題目的序號來排序題目
            Model_MainControl.JoinTopic(NameArray); //將題目加入至控制內

        }

    }
}
