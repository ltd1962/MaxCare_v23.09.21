
using System;
using System.Collections.Generic;
using System.Data;

internal class InteractSQL
{
	private static bool ED104031(string string_0, string string_1)
	{
		bool result = false;
		try
		{
			int num = ConnectorKichBan.Instance.method_3("SELECT COUNT(*) AS count FROM pragma_table_info('" + string_0 + "') WHERE name='" + string_1 + "'");
			if (num > 0)
			{
				result = true;
			}
		}
		catch
		{
		}
		return result;
	}

	public static bool smethod_0(string string_0, string string_1, int int_0)
	{
		bool result = false;
		try
		{
			if (ED104031(string_0, string_1))
			{
				return true;
			}
			if (ConnectorKichBan.Instance.method_2("ALTER TABLE " + string_0 + " ADD COLUMN '" + string_1 + "' " + ((int_0 == 0) ? "INT" : "TEXT") + ";") > 0)
			{
				result = true;
			}
		}
		catch
		{
		}
		return result;
	}

	public static DataTable B6A0BD0E(string string_0)
	{
		DataTable result = new DataTable();
		try
		{
			string string_ = "SELECT * FROM Kich_Ban WHERE Id_KichBan = " + string_0;
			result = ConnectorKichBan.Instance.method_1(string_);
		}
		catch
		{
		}
		return result;
	}

	public static string smethod_1(string string_0)
	{
		string result = "";
		try
		{
			string string_ = "SELECT TenKichBan FROM Kich_Ban WHERE Id_KichBan = " + string_0;
			result = ConnectorKichBan.Instance.method_1(string_).Rows[0][0].ToString();
		}
		catch (Exception)
		{
		}
		return result;
	}

	public static DataTable GetAllKichBan()
	{
		DataTable result = new DataTable();
		try
		{
			string string_ = "DROP TABLE IF EXISTS tmp;CREATE TEMPORARY TABLE tmp(Stt INTEGER PRIMARY KEY AUTOINCREMENT, Id_KichBan INTEGER, TenKichBan TEXT);INSERT INTO tmp (Id_KichBan, TenKichBan) SELECT Id_KichBan, TenKichBan FROM Kich_Ban;SELECT Id_KichBan, TenKichBan, (Stt||'. '||TenKichBan) AS Ten FROM tmp;";
			result = ConnectorKichBan.Instance.method_1(string_);
		}
		catch
		{
		}
		return result;
	}

	public static DataTable smethod_3()
	{
		DataTable result = new DataTable();
		try
		{
			string string_ = "SELECT * FROM Kich_Ban ORDER BY Id_KichBan DESC LIMIT 1";
			result = ConnectorKichBan.Instance.method_1(string_);
		}
		catch
		{
		}
		return result;
	}

	public static string GetCauHinhFromKichBan(string string_0)
	{
		string result = "";
		try
		{
			string string_ = "SELECT CauHinh FROM Kich_Ban WHERE Id_KichBan = " + string_0;
			result = ConnectorKichBan.Instance.method_1(string_).Rows[0]["CauHinh"].ToString();
		}
		catch
		{
		}
		return result;
	}

	public static bool ED06C222(string string_0, string D8A6A00E)
	{
		try
		{
			string string_ = "UPDATE Kich_Ban SET CauHinh = '" + D8A6A00E.Replace("'", "''") + "' WHERE Id_KichBan = " + string_0;
			return ConnectorKichBan.Instance.method_2(string_) > 0;
		}
		catch
		{
		}
		return false;
	}

	public static bool smethod_5(string string_0)
	{
		try
		{
			string string_ = "SELECT Id_KichBan FROM Kich_Ban WHERE TenKichBan = '" + string_0.Replace("'", "''") + "'";
			if (ConnectorKichBan.Instance.method_1(string_).Rows.Count > 0)
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	public static bool DCB1CA24(string DDADD40F)
	{
		bool result = false;
		try
		{
			string string_ = "INSERT INTO Kich_Ban (TenKichBan) VALUES ('" + DDADD40F.Replace("'", "''") + "')";
			if (ConnectorKichBan.Instance.method_2(string_) > 0)
			{
				result = true;
			}
		}
		catch
		{
		}
		return result;
	}

	public static bool smethod_6(string string_0, string F424FD1B)
	{
		bool result = false;
		try
		{
			string string_ = "UPDATE Kich_Ban SET TenKichBan = '" + F424FD1B.Replace("'", "''") + "' WHERE Id_KichBan = " + string_0;
			if (ConnectorKichBan.Instance.method_2(string_) > 0)
			{
				result = true;
			}
		}
		catch
		{
		}
		return result;
	}

	public static bool smethod_7(string AC041E14)
	{
		bool result = false;
		try
		{
			string string_ = "DELETE FROM Kich_Ban WHERE Id_KichBan = " + AC041E14;
			if (ConnectorKichBan.Instance.method_2(string_) > 0)
			{
				B4B92301(AC041E14);
				result = true;
			}
		}
		catch
		{
		}
		return result;
	}

	public static bool smethod_8(string F4173624, string string_0)
	{
		bool result = false;
		try
		{
			if (DCB1CA24(string_0))
			{
				string text = smethod_3().Rows[0]["Id_KichBan"].ToString();
				DataTable dataTable = ConnectorKichBan.Instance.method_1("SELECT * FROM Hanh_Dong WHERE Id_KichBan = " + F4173624);
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					string string_ = "INSERT INTO Hanh_Dong (STT,Id_KichBan, TenHanhDong, Id_TuongTac, CauHinh) VALUES (" + dataTable.Rows[i]["STT"].ToString() + "," + text + ", '" + dataTable.Rows[i]["TenHanhDong"].ToString() + "', " + dataTable.Rows[i]["Id_TuongTac"].ToString() + ", '" + dataTable.Rows[i]["CauHinh"].ToString().Replace("'", "''") + "')";
					ConnectorKichBan.Instance.method_2(string_);
				}
				result = true;
			}
		}
		catch
		{
		}
		return result;
	}

	public static DataTable B484648C(string D6330E2E = "", string DCAD78A6 = "")
	{
		DataTable result = new DataTable();
		try
		{
			string text = "";
			if (D6330E2E != "")
			{
				text = text + "Id_TuongTac = " + D6330E2E + " AND ";
			}
			if (DCAD78A6 != "")
			{
				text = text + "TenTuongTac = '" + DCAD78A6.Replace("'", "''") + "'";
			}
			if (text != "")
			{
				if (text.EndsWith(" AND "))
				{
					text = text.Replace(" AND ", "");
				}
				string string_ = "SELECT * FROM Tuong_Tac WHERE " + text;
				result = ConnectorKichBan.Instance.method_1(string_);
			}
		}
		catch
		{
		}
		return result;
	}

	internal static void B58C1618(string E519250B, string A407F023)
	{
		DataTable dataTable = B484648C("", E519250B);
		if (dataTable.Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO main.Tuong_Tac (TenTuongTac, MoTa) VALUES ('" + E519250B.Replace("'", "''") + "', '" + A407F023.Replace("'", "''") + "');");
		}
		else
		{
			string text = dataTable.Rows[0]["MoTa"].ToString();
			if (text != A407F023)
			{
				ConnectorKichBan.Instance.method_2(string.Format("UPDATE main.Tuong_Tac SET MoTa='{0}' WHERE Id_TuongTac={1};", A407F023.Replace("'", "''"), dataTable.Rows[0]["Id_TuongTac"]));
			}
		}
	}

	public static DataTable GetAllHanhDongByKichBan(string string_0)
	{
		DataTable result = new DataTable();
		try
		{
			string string_ = "SELECT t1.Id_HanhDong, t1.TenHanhDong,t2.Id_TuongTac,t2.TenTuongTac, t2.MoTa FROM Hanh_Dong t1 JOIN Tuong_Tac t2 ON t1.Id_TuongTac = t2.Id_TuongTac WHERE t1.Id_KichBan = " + string_0 + " ORDER BY t1.STT";
			result = ConnectorKichBan.Instance.method_1(string_);
		}
		catch
		{
		}
		return result;
	}

	public static DataTable FB881189(string string_0)
	{
		DataTable result = new DataTable();
		try
		{
			string string_ = "SELECT t1.TenHanhDong,t1.CauHinh,t2.Id_TuongTac,t2.TenTuongTac, t2.MoTa FROM Hanh_Dong t1 JOIN Tuong_Tac t2 ON t1.Id_TuongTac = t2.Id_TuongTac WHERE t1.Id_HanhDong = " + string_0;
			result = ConnectorKichBan.Instance.method_1(string_);
		}
		catch
		{
		}
		return result;
	}

	public static DataTable EE968A20()
	{
		DataTable result = new DataTable();
		try
		{
			string string_ = "SELECT t1.Id_HanhDong,t1.TenHanhDong,t1.CauHinh,t2.Id_TuongTac,t2.TenTuongTac, t2.MoTa FROM Hanh_Dong t1 JOIN Tuong_Tac t2 ON t1.Id_TuongTac = t2.Id_TuongTac ORDER BY Id_HanhDong DESC LIMIT 1";
			result = ConnectorKichBan.Instance.method_1(string_);
		}
		catch
		{
		}
		return result;
	}

	public static bool smethod_10(string E2B350A8)
	{
		try
		{
			string string_ = "SELECT Id_HanhDong FROM Hanh_Dong WHERE TenHanhDong = '" + E2B350A8.Replace("'", "''") + "'";
			if (ConnectorKichBan.Instance.method_1(string_).Rows.Count > 0)
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	public static bool smethod_11(string string_0, string string_1, string string_2, string string_3)
	{
		bool result = false;
		try
		{
			string text = "";
			try
			{
				text = ConnectorKichBan.Instance.method_1("SELECT STT FROM Hanh_Dong WHERE Id_KichBan = " + string_0 + " ORDER BY STT DESC LIMIT 1").Rows[0]["STT"].ToString();
			}
			catch
			{
			}
			text = ((text == "") ? "1" : (Convert.ToInt32(text) + 1).ToString());
			string_3 = string_3.Replace("'", "''");
			string string_4 = "INSERT INTO Hanh_Dong (STT,Id_KichBan, TenHanhDong, Id_TuongTac, CauHinh) VALUES (" + text + "," + string_0 + ", '" + string_1.Replace("'", "''") + "', " + string_2 + ", '" + string_3.Replace("'", "''") + "')";
			if (ConnectorKichBan.Instance.method_2(string_4) > 0)
			{
				result = true;
			}
		}
		catch
		{
		}
		return result;
	}

	public static bool smethod_12(string F5B787AE, string string_0)
	{
		bool result = false;
		try
		{
			DataTable dataTable = ConnectorKichBan.Instance.method_1("SELECT * FROM Hanh_Dong WHERE Id_HanhDong = " + F5B787AE);
			string text = "";
			try
			{
				text = ConnectorKichBan.Instance.method_1("SELECT STT FROM Hanh_Dong WHERE Id_KichBan = " + dataTable.Rows[0]["Id_KichBan"].ToString() + " ORDER BY STT DESC LIMIT 1").Rows[0]["STT"].ToString();
			}
			catch
			{
			}
			text = ((text == "") ? "1" : (Convert.ToInt32(text) + 1).ToString());
			string string_ = "INSERT INTO Hanh_Dong (STT,Id_KichBan, TenHanhDong, Id_TuongTac, CauHinh) VALUES (" + text + "," + dataTable.Rows[0]["Id_KichBan"].ToString() + ", '" + string_0.Replace("'", "''") + "', " + dataTable.Rows[0]["Id_TuongTac"].ToString() + ", '" + dataTable.Rows[0]["CauHinh"].ToString() + "')";
			if (ConnectorKichBan.Instance.method_2(string_) > 0)
			{
				result = true;
			}
		}
		catch
		{
		}
		return result;
	}

	public static bool smethod_13(string CB39CD18, string string_0 = "", string string_1 = "")
	{
		bool result = false;
		try
		{
			string text = "";
			if (string_0 != "")
			{
				text = text + "TenHanhDong = '" + string_0.Replace("'", "''") + "',";
			}
			if (string_1 != "")
			{
				text = text + "CauHinh = '" + string_1.Replace("'", "''") + "'";
			}
			if (text != "")
			{
				text = text.TrimEnd(',');
				string string_2 = "UPDATE Hanh_Dong SET " + text + " WHERE Id_HanhDong = " + CB39CD18;
				if (ConnectorKichBan.Instance.method_2(string_2) > 0)
				{
					result = true;
				}
			}
		}
		catch
		{
		}
		return result;
	}

	public static bool smethod_14(string string_0, string string_1)
	{
		bool result = false;
		try
		{
			string text = ConnectorKichBan.Instance.method_1("SELECT STT FROM Hanh_Dong WHERE Id_HanhDong = " + string_0).Rows[0]["STT"].ToString();
			string text2 = ConnectorKichBan.Instance.method_1("SELECT STT FROM Hanh_Dong WHERE Id_HanhDong = " + string_1).Rows[0]["STT"].ToString();
			string string_2 = "UPDATE Hanh_Dong SET STT = " + text2 + " WHERE Id_HanhDong = " + string_0;
			string string_3 = "UPDATE Hanh_Dong SET STT = " + text + " WHERE Id_HanhDong = " + string_1;
			if (ConnectorKichBan.Instance.method_2(string_2) > 0 && ConnectorKichBan.Instance.method_2(string_3) > 0)
			{
				result = true;
			}
		}
		catch
		{
		}
		return result;
	}

	public static bool A18973AD(string BB378D2F)
	{
		bool result = false;
		try
		{
			string string_ = "DELETE FROM Hanh_Dong WHERE Id_HanhDong = " + BB378D2F;
			if (ConnectorKichBan.Instance.method_2(string_) > 0)
			{
				result = true;
			}
		}
		catch
		{
		}
		return result;
	}

	public static bool B4B92301(string string_0)
	{
		bool result = false;
		try
		{
			string string_ = "DELETE FROM Hanh_Dong WHERE Id_KichBan = " + string_0;
			if (ConnectorKichBan.Instance.method_2(string_) > 0)
			{
				result = true;
			}
		}
		catch
		{
		}
		return result;
	}

	public static List<string> A28D1728(string ECAE29A5, string C0853B85)
	{
		List<string> list = new List<string>();
		try
		{
			string string_ = "SELECT t1.Id_HanhDong FROM Hanh_Dong t1 JOIN Tuong_Tac t2 ON t1.Id_TuongTac = t2.Id_TuongTac WHERE t1.Id_KichBan = " + ECAE29A5 + " AND t2.TenTuongTac = '" + C0853B85.Replace("'", "''") + "'";
			DataTable dataTable = ConnectorKichBan.Instance.method_1(string_);
			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				list.Add(dataTable.Rows[i]["Id_HanhDong"].ToString());
			}
		}
		catch
		{
		}
		return list;
	}

	public static List<string> AB35FD82(string D4323226, string string_0)
	{
		List<string> list = new List<string>();
		try
		{
			string string_ = "SELECT t1.Id_HanhDong FROM Hanh_Dong t1 JOIN Tuong_Tac t2 ON t1.Id_TuongTac = t2.Id_TuongTac WHERE t1.Id_KichBan = " + D4323226;
			DataTable dataTable = ConnectorKichBan.Instance.method_1(string_);
			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				list.Add(dataTable.Rows[i]["Id_HanhDong"].ToString());
			}
		}
		catch
		{
		}
		return list;
	}

	public static string smethod_15(string EEA05EB1)
	{
		string result = "";
		try
		{
			string string_ = "SELECT CauHinh FROM Hanh_Dong WHERE Id_HanhDong = " + EEA05EB1;
			result = ConnectorKichBan.Instance.method_1(string_).Rows[0]["CauHinh"].ToString();
		}
		catch
		{
		}
		return result;
	}
}
