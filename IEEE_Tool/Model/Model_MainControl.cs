using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        /// <summary>
        /// 記錄問卷的答案
        /// </summary>
        /// <param name="input"></param>
        static public void AddAnswer(string input)
        {
            SaveAnswer.Add(input);
        }

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
        static public void Reset()
        {
            foreach(Par_NewListViewItem Get in TopicList)
            {
                Get.Reset();
                SaveAnswer.Clear();
            }
        }
    }
}
