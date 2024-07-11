using System;
using System.Collections.Generic;

public class GClass14
{
	private string string_0;

	public GClass14()
	{
		string_0 = "LogAddPhone";
		List<string> list = new List<string> { "timeCreated", "idOder", "phone", "otp", "status" };
		if (!Base.E5BBA695.method_2().Contains(string_0))
		{
			string text = "";
			for (int i = 0; i < list.Count; i++)
			{
				text = text + list[i] + " TEXT,";
			}
			string string_ = "\r\n                    CREATE TABLE " + string_0 + " (\r\n\t                id INTEGER,\r\n\t                " + text + "\r\n\t                PRIMARY KEY(id AUTOINCREMENT)\r\n                )\r\n                ";
			Base.E5BBA695.method_1(string_);
		}
	}

	public bool method_0(string F8089CBC, string string_1)
	{
		string string_2 = "INSERT INTO " + string_0 + " (timeCreated, idOder, phone) VALUES ('" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "', '" + F8089CBC + "', '" + string_1 + "')";
		return Base.E5BBA695.method_1(string_2) > 0;
	}

	public bool D0B5838C(string string_1, string CA209209)
	{
		string string_2 = "UPDATE " + string_0 + " SET otp = '" + CA209209 + "' WHERE idOder = '" + string_1 + "'";
		return Base.E5BBA695.method_1(string_2) > 0;
	}

	public bool method_1(string string_1, string C7899C2E)
	{
		string string_2 = "UPDATE " + string_0 + " SET status = '" + C7899C2E + "' WHERE idOder = '" + string_1 + "'";
		return Base.E5BBA695.method_1(string_2) > 0;
	}
}
