using System.Windows.Forms;

public class MessageBoxHelper
{
	public static void Show(object object_0, int E8AAB98A = 1)
	{
		MessageBoxIcon icon = MessageBoxIcon.None;
		switch (E8AAB98A)
		{
		case 1:
			icon = MessageBoxIcon.Asterisk;
			break;
		case 2:
			icon = MessageBoxIcon.Hand;
			break;
		case 3:
			icon = MessageBoxIcon.Exclamation;
			break;
		case 4:
			icon = MessageBoxIcon.Exclamation;
			break;
		}
		MessageBox.Show(Language.GetValue(object_0.ToString()), "LTDSoftware", MessageBoxButtons.OK, icon);
	}

	public static DialogResult ShowMessages(string string_0)
	{
		return MessageBox.Show(Language.GetValue(string_0), "LTDSoftware", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
	}
}
