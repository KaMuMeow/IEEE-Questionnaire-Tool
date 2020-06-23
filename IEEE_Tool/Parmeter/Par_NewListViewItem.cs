using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace IEEE_Tool.Parmeter
{
    public class Par_NewListViewItem:ListViewItem
    {

        //-----自定義的控制項-----
        /*
         * 繼承了ListViewItem的功能
         * 手動增加了會依照ListView的位置加入CheckBox
         * 會記錄每一題目所勾選的意見數量
         */

        private ListView MyListView;

        //0:非常同意,1:同意,2:普通,3:不同意,4:非常不同意
        private CheckBox[] Check_List; //對應的勾選框
        private int[] CheckCount; //統計對應的數量

        public Par_NewListViewItem(string NewName)
        {
            Check_List = new CheckBox[5];
            CheckCount = new int[5];
            this.Text = NewName;
            for (int i = 0; i < 10; i++)
                this.SubItems.Add("--");
            Reset();
        }


        /// <summary>
        /// 創建出題目時，要將其依附在要顯示的ListView上面，才可正常顯示與動作
        /// </summary>
        /// <param name="NewListView">要依附的ListView</param>
        public void AttachListView(ListView NewListView)
        {
            //紀錄依附的ListView
            MyListView = NewListView;
            int GetIndex = MyListView.Items.IndexOf(this); //取出該ListViewItem的索引值
            //將勾選框自動生成在對應的ListView上面
            for (int i=0; i<Check_List.Count();i++)
            {
                //勾選框的大小
                Size NewSize = new Size(13, MyListView.Items[GetIndex].SubItems[2+i*2].Bounds.Height);
                //勾選框的位置
                Point NewLoc = new Point(MyListView.Items[GetIndex].SubItems[2+i*2].Bounds.Left + 9,
                MyListView.Items[GetIndex].SubItems[2+i*2].Bounds.Top);
                //實作出CheckBox
                Check_List[i] = new CheckBox();
                Check_List[i].Tag = i;
                Check_List[i].Click += CheckBoxChanged; //自定義對應的事件
                MyListView.Controls.Add(Check_List[i]); //將CheckBox放置在ListView內
                Check_List[i].Size = NewSize;
                Check_List[i].Location = NewLoc;
            }
        }

        public void Dispose()
        {
            foreach(CheckBox GetCheckBox in Check_List)
                MyListView.Controls.Remove(GetCheckBox);
        }

        /// <summary>
        /// 確定並且記錄該題勾選的選擇
        /// </summary>
        /// <returns>回傳該題的選擇結果</returns>
        public int Done(bool SaveFlag = true)
        {
            int Result=-1;
            for(int i=0;i<Check_List.Count();i++)
            {
                if (Check_List[i].Checked)
                {
                    Result=i+1;
                    if(SaveFlag)
                        CheckCount[i]++;
                }
                Check_List[i].Checked = false;
            }
            Refresh();
            return Result;
        }

        /// <summary>
        /// 防呆用，檢查題目是否都有被勾選
        /// </summary>
        /// <returns>回傳該題的選擇情況</returns>
        public bool Check()
        {
            bool Flag = false;
            for (int i = 0; i < Check_List.Count(); i++)
            {
                if (Check_List[i].Checked)
                    Flag = true;
            }
            return Flag;
        }

        /// <summary>
        /// 重置該題號統計的數量
        /// </summary>
        public void Reset()
        {
            for (int i = 0; i < 5; i++)
            {
                Check_List[i].Checked = false;
                CheckCount[i] = 0;
                this.SubItems[1 + i * 2].Text = CheckCount[i].ToString();
            }
        }
        /// <summary>
        /// 重新刷新題號的統計結果
        /// </summary>
        private void Refresh()
        {
            for (int i = 0; i < 5; i++)
            {
                this.SubItems[1 + i * 2].Text = CheckCount[i].ToString();
            }
        }

        /// <summary>
        /// 當點選CheckBox時的事件，每一個控制項都自行處理對應的CheckBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBoxChanged(object sender,EventArgs e)
        {
            CheckBox AimObj = (CheckBox)sender;
            AimObj.Checked = true;
            foreach(CheckBox Get in Check_List)
            {
                if (Get.Tag != AimObj.Tag)
                    Get.Checked = false;
            }
        }

        /// <summary>
        /// 修改該題的答案跟計分
        /// </summary>
        /// <param name="OrgAnswer">舊的答案</param>
        /// <param name="NewAnswer">新的答案</param>
        public void ModifyCheck(int OrgAnswer, int NewAnswer)
        {
            CheckCount[OrgAnswer - 1] -= 1;
            CheckCount[NewAnswer - 1] += 1;
            Refresh();
        }

        /// <summary>
        /// 用輸入的方式選擇要勾選的回答
        /// </summary>
        /// <param name="SelectIdx">回答的題號，輸入1~5</param>
        /// <returns></returns>
        public bool SetClieked(int SelectIdx)
        {
            if (SelectIdx < 0 || SelectIdx > Check_List.Count())
                return false;

            foreach (CheckBox Get in Check_List)
                Get.Checked = false;

            Check_List[SelectIdx - 1].Checked = true;
            return true;
        }
    }
}
