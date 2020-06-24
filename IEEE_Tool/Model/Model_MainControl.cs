using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using IEEE_Tool.Parmeter;
namespace IEEE_Tool.Model
{
    /*-----------------------------------------------*/
    /* 偷懶的關係，所有的控制跟運算都共用這一個Model */
    /*-----------------------------------------------*/
    static class Model_MainControl
    {
        //紀錄需要回答的題目
        static public List<Par_NewListViewItem> TopicList { get; private set; } = new List<Par_NewListViewItem>();
        //記錄每一張問卷的回答結果
        static public List<string> SaveAnswer { get; private set; } = new List<string>();


        #region 與SettingTopicForm有連動的函數都塞在這
        static public void JoinTopic(string[] TopicName)
        {
            //每次加入題目時，都要將之前加入的題目清除乾淨
            //不然會有CheckBox殘留
            foreach (Par_NewListViewItem GetTopic in TopicList)
            {
                GetTopic.Dispose();
            }
            TopicList.Clear();
            SaveAnswer.Clear();
            
            foreach (string GetName in TopicName)
            {
                Par_NewListViewItem TmpList = new Par_NewListViewItem(GetName);
                TopicList.Add(TmpList); //加入需要回答的題目
            }
        }
        #endregion

        #region 與MainForm有連動的函數都塞在這
        /// <summary>
        /// 修改特定問卷的答案
        /// </summary>
        /// <param name="SelectIdx">要修改的問卷</param>
        /// <param name="input">要修改的答案</param>
        static public void ModifyAnswer(int SelectIdx,string input)
        {
            string OldAns = SaveAnswer[SelectIdx]; //取出舊的答案
            SaveAnswer[SelectIdx] = input; //將舊的答案換成新的
            //將答案從string轉換成int的格式
            List<int> NewInputList = new List<int>();
            List<int> OldInputList = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                NewInputList.Add(int.Parse(input.Substring(i, 1)));
                OldInputList.Add(int.Parse(OldAns.Substring(i, 1)));
            }
            //開始替換每一題的答案
            for (int i = 0; i < TopicList.Count; i++)
            {
                TopicList[i].ModifyCheck(OldInputList[i], NewInputList[i]);
            }
        }

        /// <summary>
        /// 使用TextBox勾選題目
        /// </summary>
        /// <param name="Input"></param>
        static public bool InputCheck(string Input)
        {
            try
            {
                List<int> GetInputList = new List<int>();
                for (int i = 0; i < Input.Length; i++)
                    GetInputList.Add(int.Parse(Input.Substring(i, 1)));
                for (int i = 0; i < TopicList.Count; i++)
                {
                    if(!TopicList[i].SetClieked(GetInputList[i]))
                    {
                        MessageBox.Show(string.Format("{0} 已經超出可選擇的答案範圍了!",TopicList[i].Text),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return false;
                    }
                }
                return true;
            }catch
            {
                MessageBox.Show("請輸入正常的數字!，只有1~5阿幹", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// 重新統計問卷
        /// </summary>
        static public void Reset()
        {
            foreach (Par_NewListViewItem Get in TopicList)
            {
                Get.Reset();
                SaveAnswer.Clear();
            }
        }


        /// <summary>
        /// 記錄問卷的答案
        /// </summary>
        /// <param name="input"></param>
        static public void AddAnswer(string input)
        {
            SaveAnswer.Add(input);
        }


        /// <summary>
        /// 輸出IEEE問卷格式的.csv
        /// </summary>
        static public void ExportCsv()
        {
            if(TopicList.Count<=0)
            {
                MessageBox.Show("請先設定好題目!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string Output = "題號,非常同意,同意,普通,不同意,非常不同意"+Environment.NewLine;
            int GetMaxTopicNo = GetTopicNo(TopicList.Last().Text);

            //開始依序輸出題目跟統計
            for(int i=1;i<=GetMaxTopicNo;i++)
            {
                bool Flag = false;
                int[] AnsAmount = { 0, 0, 0, 0, 0 };
                foreach(Par_NewListViewItem GetTopic in TopicList)
                {
                    if(GetTopicNo(GetTopic.Text)==i)
                    {
                        AnsAmount = GetTopic.CheckCount;
                        break;
                    }
                }
                //用偷懶的方式來做輸出，很懶的寫
                Output += string.Format("No.{0},{1},{2},{3},{4},{5}", i, AnsAmount[0], AnsAmount[1],
                    AnsAmount[2], AnsAmount[3], AnsAmount[4])+Environment.NewLine;
            }
            //取得程式目前的啟動路徑
            string OutputPath = Directory.GetCurrentDirectory();
            StreamWriter WriteCsv = new StreamWriter(OutputPath + "\\Output.Csv",false,Encoding.UTF8);
            WriteCsv.WriteLine(Output);
            WriteCsv.Close();

            //開啟儲存的路徑
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = OutputPath;
            prc.Start();

            MessageBox.Show(string.Format("輸出完成 路徑={0}",OutputPath),"Info",MessageBoxButtons.OK,MessageBoxIcon.Information);


        }
        static private int GetTopicNo(string TopicName)
        {
            try
            {
                return int.Parse(TopicName.Substring(3, TopicName.Length - 3)); //透過題目名稱取出序號
            }catch
            {
                return -1;
            }
        }
        #endregion

    }
}
