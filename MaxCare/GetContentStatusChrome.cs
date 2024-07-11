public class GetContentStatusChrome
{
	public static string D6001D3E(StatusChromeAccount genum1_0)
	{
		string result = "";
		switch (genum1_0)
		{
		case StatusChromeAccount.ChromeClosed:
			result = Language.GetValue("Không ti\u0300m thâ\u0301y chrome!");
			break;
		case StatusChromeAccount.Checkpoint:
			result = "Checkpoint!";
			break;
		case StatusChromeAccount.NoInternet:
			result = Language.GetValue("Không có kết nối Internet!");
			break;
		case StatusChromeAccount.Blocked:
			result = Language.GetValue("Facebook Blocked!");
			break;
		}
		return result;
	}
}
