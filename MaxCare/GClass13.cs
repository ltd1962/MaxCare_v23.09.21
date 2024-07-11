using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

public class GClass13
{
	private string string_0;

	private SQLiteConnection E422A894 = null;

	public GClass13(string string_1)
	{
		string_0 = string_1;
	}

	private void DF885DA4()
	{
		try
		{
			if (E422A894 == null)
			{
				E422A894 = new SQLiteConnection("Data Source=" + string_0 + ";Version=3;");
			}
			if (E422A894.State == ConnectionState.Closed)
			{
				E422A894.Open();
			}
		}
		catch (Exception exception_)
		{
			Common.ExportError2(exception_, "CheckConnectServer");
		}
	}

	public DataTable method_0(string string_1)
	{
		DataTable dataTable = new DataTable();
		try
		{
			DF885DA4();
			SQLiteCommand cmd = new SQLiteCommand(string_1, E422A894);
			SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter(cmd);
			sQLiteDataAdapter.Fill(dataTable);
		}
		catch
		{
		}
		return dataTable;
	}

	public int method_1(string string_1)
	{
		int result = 0;
		try
		{
			DF885DA4();
			SQLiteCommand sQLiteCommand = new SQLiteCommand(string_1, E422A894);
			result = sQLiteCommand.ExecuteNonQuery();
		}
		catch (Exception)
		{
		}
		return result;
	}

	public int C0815BAB(string string_1)
	{
		int result = -1;
		try
		{
			DF885DA4();
			SQLiteCommand sQLiteCommand = new SQLiteCommand(string_1, E422A894);
			long num = (long)sQLiteCommand.ExecuteScalar();
			result = (int)num;
		}
		catch
		{
		}
		return result;
	}

	public List<string> method_2()
	{
		List<string> list = new List<string>();
		DataTable dataTable = method_0("select name from sqlite_master;");
		for (int i = 0; i < dataTable.Rows.Count; i++)
		{
			list.Add(dataTable.Rows[i]["name"].ToString());
		}
		return list;
	}
}
