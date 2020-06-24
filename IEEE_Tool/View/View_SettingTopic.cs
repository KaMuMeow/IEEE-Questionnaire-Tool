using System;
using System.Windows.Forms;

namespace IEEE_Tool.View
{
    public interface View_SettingTopic
    {
        Button View_Btn_Done { get; }
        Button View_Btn_Cancel { get; }
        Button View_Btn_Join { get; }
        Button View_Btn_Remove { get; }

        Label View_Label_Title { get; }

        ListBox View_ListBox_SelectTopic { get; }
        ListBox View_ListBox_JoinTopic { get; }
    }
}
