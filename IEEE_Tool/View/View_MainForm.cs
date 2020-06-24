using System.Windows.Forms;
namespace IEEE_Tool.View
{
    public interface View_MainForm
    {
        Button View_Btn_SetTopic { get; }
        Button View_Btn_Reset { get; }
        Button View_Btn_Check { get; }
        Button View_Btn_Export { get; }
        ListView View_ListView_TopicList { get; }

        TextBox View_TextBox_Input { get; }

        ComboBox View_Combox_SelectQuestionnaire { get; }

        Label View_Label_AnswerAmount { get; }
    }
}
