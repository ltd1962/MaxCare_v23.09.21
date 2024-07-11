using System;

public static class StringHelper
{
	public static bool CheckStringIsNumber(string string_0)
	{
		try
		{
			Convert.ToInt32(string_0);
			return true;
		}
		catch
		{
		}
		return false;
	}

	public static string RandomChar(this string A319C18F, int int_0 = 0, char char_0 = '*')
	{
		try
		{
			string text = "";
			for (int i = 0; i < A319C18F.Length; i++)
			{
				if (A319C18F[i] != char_0)
				{
					text += A319C18F[i];
					continue;
				}
				switch (int_0)
				{
				case 0:
					text += Common.CreateRandomNumber(1);
					break;
				case 1:
					text += Common.CreateRandomString(1);
					break;
				case 2:
					text += Common.CreateRandomStringNumber(1);
					break;
				}
			}
			return text;
		}
		catch
		{
		}
		return "";
	}
}
