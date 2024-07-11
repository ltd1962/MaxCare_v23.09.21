using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

internal class CommonSQL
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A1359B88
	{
		public static readonly A1359B88 _003C_003E9 = new A1359B88();

		public static Func<DataRow, BaiViet> _003C_003E9__34_0;

		public static Func<DataRow, BaiViet> _003C_003E9__36_0;

		public static Func<DataRow, BaiViet> _003C_003E9__41_0;

		internal BaiViet method_0(DataRow dataRow_0)
		{
			return new BaiViet
			{
				Int32_0 = Convert.ToInt32(dataRow_0["id"]),
				D0B8AABE = Convert.ToString(dataRow_0["tenChuDe"]),
				String_3 = Convert.ToString(dataRow_0["ngaytao"]),
				String_1 = Convert.ToString(dataRow_0["anh"]),
				String_2 = Convert.ToString(dataRow_0["video"]),
				String_0 = Convert.ToString(dataRow_0["tieude"]),
				F836E2B8 = Convert.ToString(dataRow_0["noidung"])
			};
		}

		internal BaiViet A418A737(DataRow DCB2EB10)
		{
			return new BaiViet
			{
				Int32_0 = Convert.ToInt32(DCB2EB10["id"]),
				D0B8AABE = Convert.ToString(DCB2EB10["tenChuDe"]),
				String_3 = Convert.ToString(DCB2EB10["ngaytao"]),
				String_1 = Convert.ToString(DCB2EB10["anh"]),
				String_2 = Convert.ToString(DCB2EB10["video"]),
				String_0 = Convert.ToString(DCB2EB10["tieude"]),
				F836E2B8 = Convert.ToString(DCB2EB10["noidung"])
			};
		}

		internal BaiViet method_1(DataRow dataRow_0)
		{
			return new BaiViet
			{
				Int32_0 = Convert.ToInt32(dataRow_0["id"]),
				D0B8AABE = Convert.ToString(dataRow_0["tenChuDe"]),
				String_3 = Convert.ToString(dataRow_0["ngaytao"]),
				String_1 = Convert.ToString(dataRow_0["anh"]),
				String_2 = Convert.ToString(dataRow_0["video"]),
				String_0 = Convert.ToString(dataRow_0["tieude"]),
				F836E2B8 = Convert.ToString(dataRow_0["noidung"])
			};
		}
	}

	public static bool smethod_0(string string_0)
	{
		return Connector.Instance.method_5("SELECT COUNT(*) FROM files WHERE name='" + string_0 + "' AND active=1;") > 0;
	}

	public static DataTable C6B3348F(bool CAB18A83 = false, bool bool_0 = false)
	{
		DataTable result = new DataTable();
		try
		{
			string text = "";
			text = (bool_0 ? (CAB18A83 ? ("select id, name, STT from files WHERE id IN (SELECT DISTINCT idfile FROM accounts WHERE active=0) UNION SELECT -1 AS id, '" + Language.GetValue("[Tất cả thư mục]") + "' AS name, -1 AS STT UNION SELECT 999999 AS id, '" + Language.GetValue("[Chọn nhiều thư mục]") + "' AS name, 999999 AS STT ORDER BY STT") : "select id, name from files WHERE id IN (SELECT DISTINCT idfile FROM accounts WHERE active=0) ORDER BY STT") : (CAB18A83 ? ("select id, name, STT from files where active=1 UNION SELECT -1 AS id, '" + Language.GetValue("[Tất cả thư mục]") + "' AS name, -1 AS STT UNION SELECT 999999 AS id, '" + Language.GetValue("[Chọn nhiều thư mục]") + "' AS name, 999999 AS STT ORDER BY STT") : "select id, name from files where active=1 ORDER BY STT"));
			result = Connector.Instance.ExecuteQuery(text);
		}
		catch
		{
		}
		return result;
	}

	public static DataTable smethod_1()
	{
		DataTable result = new DataTable();
		try
		{
			string string_ = "DROP TABLE IF EXISTS tmp;CREATE TEMPORARY TABLE tmp(Stt INTEGER PRIMARY KEY AUTOINCREMENT, id INTEGER, name TEXT);INSERT INTO tmp (id, name) select id, name from files where active=1 ORDER BY STT;SELECT id, (Stt||'. '||name) AS Ten FROM tmp;";
			result = Connector.Instance.ExecuteQuery(string_);
		}
		catch
		{
		}
		return result;
	}

	public static bool B623BF13(string string_0)
	{
		bool result = true;
		try
		{
			int num = Connector.Instance.method_5("SELECT MAX(STT) FROM files");
			string string_ = "INSERT INTO files (name, createddate, active, STT) values('" + string_0 + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "',1," + (num + 1) + ")";
			Connector.Instance.ExecuteQuery(string_);
		}
		catch
		{
			result = false;
		}
		return result;
	}

	public static bool smethod_2(string string_0, string FD93ECBB)
	{
		try
		{
			string string_ = "UPDATE files SET name='" + FD93ECBB + "' where id=" + string_0;
			return Connector.Instance.ExecuteNonQuery(string_) > 0;
		}
		catch
		{
		}
		return false;
	}

	public static bool smethod_3(string string_0)
	{
		bool result = false;
		try
		{
			if (Connector.Instance.method_5("SELECT COUNT(idfile) FROM accounts WHERE idfile=" + string_0) == 0)
			{
				result = Connector.Instance.ExecuteNonQuery("delete from files where id=" + string_0) > 0;
			}
			else if (Connector.Instance.ExecuteNonQuery("UPDATE files SET active=0 where id=" + string_0) > 0)
			{
				result = smethod_13(string_0);
			}
		}
		catch
		{
		}
		return result;
	}

	public static bool smethod_4(string string_0, List<string> C595F6B9, string string_1 = "accounts")
	{
		List<string> list = new List<string>();
		string text = "";
		string text2 = "";
		string text3 = "";
		for (int i = 0; i < C595F6B9.Count; i++)
		{
			text = C595F6B9[i].Split('|')[0];
			text2 = C595F6B9[i].Split('|')[1];
			if (!string.IsNullOrEmpty(text))
			{
				list.Add(text);
				text3 = text3 + "WHEN '" + text + "' THEN '" + text2 + "' ";
			}
		}
		string string_2 = "UPDATE " + string_1 + " SET " + string_0 + " = CASE id " + text3 + "END WHERE id IN('" + string.Join("','", list) + "'); ";
		return Connector.Instance.ExecuteNonQuery(string_2) > 0;
	}

	public static bool E816EF1E()
	{
		bool result = false;
		try
		{
			result = Connector.Instance.ExecuteNonQuery("delete from files where id NOT IN (SELECT DISTINCT idfile FROM accounts) AND active=0") > 0;
		}
		catch
		{
		}
		return result;
	}

	public static DataTable smethod_5()
	{
		DataTable result = new DataTable();
		try
		{
			string string_ = "SELECT id, status FROM accounts";
			result = Connector.Instance.ExecuteQuery(string_);
		}
		catch
		{
		}
		return result;
	}

	public static DataTable smethod_6(List<string> list_0, bool EA1E5E83 = true)
	{
		DataTable result = new DataTable();
		try
		{
			string text = "";
			text = ((list_0 != null && list_0.Count != 0) ? ("where idfile IN (" + string.Join(",", list_0) + ") AND active=" + (EA1E5E83 ? 1 : 0)) : ("where active=" + (EA1E5E83 ? 1 : 0)));
			string string_ = "SELECT '-1' as id, '" + Language.GetValue("[Tất cả tình trạng]") + "' AS name UNION select DISTINCT '0' as id,info from accounts " + text + " ORDER BY id ASC";
			result = Connector.Instance.ExecuteQuery(string_);
		}
		catch
		{
		}
		return result;
	}

	public static bool D32F060B(string string_0, string B390D2BA, string string_1, string string_2, string string_3, string string_4, string string_5, string A1024612, string string_6, string string_7, string string_8, string string_9, string A783679D, string EAAC4B87, string string_10, string string_11 = "", string string_12 = "", string D02C5618 = "", string string_13 = "")
	{
		bool result = true;
		try
		{
			string format = "INSERT INTO accounts(uid, pass,token,cookie1,email,name,friends,groups,birthday,gender,info,fa2,backup,idfile,passmail,useragent,proxy,dateImport,active) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}',1)";
			format = string.Format(format, string_0, B390D2BA.Replace("'", "''"), string_1, string_2, string_3, string_5, A1024612, string_6, string_7, string_8, string_9, EAAC4B87, A783679D, string_10, string_12, D02C5618, string_13, DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
			Connector.Instance.ExecuteQuery(format);
		}
		catch
		{
			result = false;
		}
		return result;
	}

	public static List<string> AC0DF4A0(List<string> E515C31A)
	{
		List<string> list = new List<string>();
		try
		{
			int num = 100;
			int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)E515C31A.Count * 1.0 / 100.0)));
			string text = "";
			for (int i = 0; i < num2; i++)
			{
				text = "INSERT INTO accounts(uid, pass,token,cookie1,email,name,friends,groups,birthday,gender,info,fa2,idfile,passmail,useragent,proxy,dateCreateAcc,dateImport,mailrecovery,active,ghiChu) VALUES " + string.Join(",", E515C31A.GetRange(num * i, (num * i + num <= E515C31A.Count) ? num : (E515C31A.Count % num)));
				list.Add(text);
			}
		}
		catch (Exception)
		{
		}
		return list;
	}

	public static string ConvertToSqlInsertAccount(string D3A6101A, string AEA7D394, string D53167B4, string string_0, string string_1, string string_2, string EBA5F013, string string_3, string AD1D821B, string string_4, string A3BBB82D, string E20C2E08, string string_5, string FCB8341A, string BC25EBB7, string string_6, string A09C4302, string FFB63DA8, string BF82C72E)
	{
		string text = "";
		try
		{
			text = "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}',1,'{19}')";
			text = string.Format(text, D3A6101A.Replace("'", "''"), AEA7D394.Replace("'", "''"), D53167B4, string_0, string_1, string_2.Replace("'", "''"), EBA5F013, string_3, AD1D821B, string_4, A3BBB82D, E20C2E08, string_5, FCB8341A, BC25EBB7, string_6, A09C4302, DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), FFB63DA8, BF82C72E);
		}
		catch
		{
		}
		return text;
	}

	public static bool UpdateFieldToAccount(string string_0, string string_1, string string_2)
	{
		bool result = false;
		try
		{
			string text = "";
			if (string_1 == "pass")
			{
				text += ",pass_old=pass";
			}
			if (string_1 == "email")
			{
				text += ",email_old=email";
			}
			if (string_1 == "uid" && string_2.ToString().Trim() == "")
			{
				return false;
			}
			if (string_1 == "cookie1" && string_2.ToString().Trim() == "")
			{
				return false;
			}
			string string_3 = "update accounts set " + string_1 + " = '" + string_2.Replace("'", "''") + "'" + text + " where id=" + string_0;
			result = Connector.Instance.ExecuteNonQuery(string_3) > 0;
		}
		catch
		{
		}
		return result;
	}

	public static bool B52E91B6(string string_0, string AF9E1414, string BA0BFA0C, bool CD8EB4B3 = true)
	{
		bool result = false;
		try
		{
			if (AF9E1414.Split('|').Length == BA0BFA0C.Split('|').Length)
			{
				int num = AF9E1414.Split('|').Length;
				string text = "";
				for (int i = 0; i < num; i++)
				{
					if (CD8EB4B3 || !(BA0BFA0C.Split('|')[i].Trim() == ""))
					{
						text = text + AF9E1414.Split('|')[i] + "='" + BA0BFA0C.Split('|')[i].Replace("'", "''") + "',";
					}
				}
				text = text.TrimEnd(',');
				string string_ = "update accounts set " + text + " where id=" + string_0;
				result = Connector.Instance.ExecuteNonQuery(string_) > 0;
			}
		}
		catch
		{
		}
		return result;
	}

	public static bool ABA6020E(List<string> list_0, string FF277026, string string_0)
	{
		bool result = false;
		try
		{
			if (FF277026.Split('|').Length == string_0.Split('|').Length)
			{
				int num = FF277026.Split('|').Length;
				string text = "";
				for (int i = 0; i < num; i++)
				{
					string text2 = FF277026.Split('|')[i];
					text = text + text2 + "='" + string_0.Split('|')[i].Replace("'", "''") + "',";
					if (text2 == "email")
					{
						text += "email_old=email,";
					}
				}
				text = text.TrimEnd(',');
				int num2 = 100;
				int num3 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)list_0.Count * 1.0 / 100.0)));
				List<string> list = new List<string>();
				string text3 = "";
				for (int j = 0; j < num3; j++)
				{
					text3 = "update accounts set " + text + " where id IN (" + string.Join(",", list_0.GetRange(num2 * j, (num2 * j + num2 <= list_0.Count) ? num2 : (list_0.Count % num2))) + ")";
					list.Add(text3);
				}
				result = Connector.Instance.method_3(list) > 0;
			}
		}
		catch
		{
		}
		return result;
	}

	public static bool smethod_8(string BC824127, string BF2BF619, string string_0)
	{
		bool result = false;
		try
		{
			string string_ = "update files set " + BF2BF619 + " = '" + string_0.Replace("'", "''") + "' where id=" + BC824127;
			result = Connector.Instance.ExecuteNonQuery(string_) > 0;
		}
		catch
		{
		}
		return result;
	}

	public static bool smethod_9(List<string> A6B56D99, string string_0, string string_1)
	{
		bool result = false;
		try
		{
			int num = 100;
			int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)A6B56D99.Count * 1.0 / 100.0)));
			List<string> list = new List<string>();
			string text = "";
			string text2 = "";
			if (string_0 == "pass")
			{
				text2 = ",pass_old=pass";
			}
			if (string_0 == "email")
			{
				text2 = ",email_old=email";
			}
			for (int i = 0; i < num2; i++)
			{
				text = "update accounts set " + string_0 + " = '" + string_1.Replace("'", "''") + "'" + text2 + " where id IN (" + string.Join(",", A6B56D99.GetRange(num * i, (num * i + num <= A6B56D99.Count) ? num : (A6B56D99.Count % num))) + ")";
				list.Add(text);
			}
			result = Connector.Instance.method_3(list) > 0;
		}
		catch (Exception ex)
		{
			Common.ExportError2(null, ex.ToString());
		}
		return result;
	}

	public static bool smethod_10(List<string> list_0, string string_0, string F9BDF79C)
	{
		bool result = true;
		try
		{
			string string_ = "update files set " + string_0 + " = '" + F9BDF79C + "' where id IN (" + string.Join(",", list_0) + ")";
			result = Connector.Instance.ExecuteNonQuery(string_) > 0;
		}
		catch
		{
		}
		return result;
	}

	public static DataTable C8978B14(List<string> list_0 = null, string C6B2F59A = "", bool B2A883B3 = true)
	{
		DataTable result = new DataTable();
		try
		{
			string text = "WHERE ";
			string text2 = ((list_0 == null || list_0.Count <= 0) ? "" : ("t1.idFile IN (" + string.Join(",", list_0) + ")"));
			if (text2 != "")
			{
				text = text + text2 + " AND ";
			}
			string text3 = ((C6B2F59A != "") ? ("t1.info = '" + C6B2F59A + "'") : "");
			if (text3 != "")
			{
				text = text + text3 + " AND ";
			}
			string text4 = $"t1.active = '{(B2A883B3 ? 1 : 0)}'";
			text += text4;
			string string_ = "SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id " + text + " ORDER BY t1.idfile";
			result = Connector.Instance.ExecuteQuery(string_);
		}
		catch
		{
		}
		return result;
	}

	public static DataTable smethod_11(List<string> list_0, bool bool_0 = true, List<string> list_1 = null)
	{
		DataTable result = new DataTable();
		try
		{
			if (list_0[0].StartsWith("@"))
			{
				List<string> list = new List<string>();
				string text = "";
				for (int i = 0; i < list_0.Count; i++)
				{
					text = "SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id WHERE t1.email Like ('%" + list_0[i] + "%') and t1.active=" + (bool_0 ? "1" : "0");
					list.Add(text);
				}
				result = Connector.Instance.method_2(list);
			}
			else if (list_0[0].Contains("@"))
			{
				int num = 100;
				int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)list_0.Count * 1.0 / 100.0)));
				List<string> list2 = new List<string>();
				string text2 = "";
				for (int j = 0; j < num2; j++)
				{
					text2 = "SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id WHERE t1.email IN ('" + string.Join("','", list_0.GetRange(num * j, (num * j + num <= list_0.Count) ? num : (list_0.Count % num))) + "') and t1.active=" + (bool_0 ? "1" : "0") + " ORDER BY t1.email";
					list2.Add(text2);
				}
				result = Connector.Instance.method_2(list2);
			}
			else
			{
				int num3 = 5000;
				int num4 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)list_0.Count * 1.0 / 5000.0)));
				List<string> list3 = new List<string>();
				string text3 = "";
				for (int k = 0; k < num4; k++)
				{
					text3 = "SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id WHERE t1.uid IN ('" + string.Join("','", list_0.GetRange(num3 * k, (num3 * k + num3 <= list_0.Count) ? num3 : (list_0.Count % num3))) + "') and t1.active=" + (bool_0 ? "1" : "0") + " ORDER BY t1.uid";
					list3.Add(text3);
				}
				result = Connector.Instance.method_2(list3);
			}
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_, "GetAccFromFile");
		}
		return result;
	}

	public static DataTable FD107191(List<string> list_0)
	{
		DataTable result = new DataTable();
		try
		{
			int num = 100;
			int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)list_0.Count * 1.0 / 100.0)));
			List<string> list = new List<string>();
			string text = "";
			for (int i = 0; i < num2; i++)
			{
				text = "SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id WHERE t1.email IN ('" + string.Join("','", list_0.GetRange(num * i, (num * i + num <= list_0.Count) ? num : (list_0.Count % num))) + "') and t1.active=1 ORDER BY t1.email";
				list.Add(text);
			}
			result = Connector.Instance.method_2(list);
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_, "GetAccFromFile");
		}
		return result;
	}

	public static DataTable smethod_12(bool bool_0 = true)
	{
		DataTable result = new DataTable();
		try
		{
			string string_ = $"select uid from accounts where active={(bool_0 ? 1 : 0)};";
			result = Connector.Instance.ExecuteQuery(string_);
		}
		catch
		{
		}
		return result;
	}

	public static bool smethod_13(string D731593B)
	{
		bool result = true;
		try
		{
			result = Connector.Instance.ExecuteNonQuery("UPDATE accounts SET active=0, dateDelete='" + DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy") + "' where idfile=" + D731593B) > 0;
		}
		catch
		{
		}
		return result;
	}

	public static bool F41A6C30(string FD0F9102)
	{
		try
		{
			return Connector.Instance.ExecuteNonQuery("UPDATE accounts SET active=0, dateDelete='" + DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy") + "' where id=" + FD0F9102) > 0;
		}
		catch
		{
		}
		return false;
	}

	public static DataTable smethod_14(List<string> CA244397)
	{
		DataTable result = new DataTable();
		try
		{
			int num = 100;
			int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)CA244397.Count * 1.0 / 100.0)));
			List<string> list = new List<string>();
			string text = "";
			for (int i = 0; i < num2; i++)
			{
				text = "SELECT uid, pass, token, cookie1,email, passmail, fa2 FROM accounts WHERE id IN ('" + string.Join("','", CA244397.GetRange(num * i, (num * i + num <= CA244397.Count) ? num : (CA244397.Count % num))) + "')";
				list.Add(text);
			}
			result = Connector.Instance.method_2(list);
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_, "GetAccFromFile");
		}
		return result;
	}

	public static bool smethod_15(List<string> list_0, bool B798F03E = false)
	{
		if (B798F03E)
		{
			List<string> list = new List<string>();
			DataTable dataTable = smethod_14(list_0);
			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				string text = "";
				for (int j = 0; j < dataTable.Columns.Count; j++)
				{
					text = text + dataTable.Rows[i][j].ToString() + "|";
				}
				text = text.Substring(0, text.Length - 1);
				list.Add(text);
			}
			File.AppendAllText("bin.txt", "======" + DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy") + "======\r\n");
			File.AppendAllLines("bin.txt", list);
		}
		bool result = true;
		try
		{
			int num = 100;
			int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)list_0.Count * 1.0 / 100.0)));
			List<string> list2 = new List<string>();
			string text2 = "";
			for (int k = 0; k < num2; k++)
			{
				text2 = ((!B798F03E) ? ("UPDATE accounts SET active=0, dateDelete='" + DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy") + "' where id IN (" + string.Join(",", list_0.GetRange(num * k, (num * k + num <= list_0.Count) ? num : (list_0.Count % num))) + ")") : ("delete from accounts where id IN (" + string.Join(",", list_0.GetRange(num * k, (num * k + num <= list_0.Count) ? num : (list_0.Count % num))) + ")"));
				list2.Add(text2);
			}
			for (int l = 0; l < list2.Count; l++)
			{
				result = Connector.Instance.ExecuteNonQuery(list2[l]) > 0;
			}
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_, "DeleteAccountToDatabase");
		}
		return result;
	}

	public static bool smethod_16(string string_0)
	{
		string[] array = string_0.Split('|');
		string text = "";
		string text2 = "";
		string text3 = "";
		string text4 = "";
		string text5 = "";
		string text6 = "";
		string text7 = "";
		string text8 = "";
		string text9 = "";
		string text10 = "";
		string text11 = "";
		string text12 = "";
		string text13 = "";
		string text14 = "";
		string text15 = "";
		text = array[0];
		if (text.Trim() == "")
		{
			return false;
		}
		text2 = array[1];
		text3 = array[2];
		text4 = array[3];
		text5 = array[4];
		text6 = array[5];
		text7 = array[6];
		text8 = array[7];
		text9 = array[8];
		text10 = array[9];
		text11 = array[10];
		text12 = array[11];
		text13 = array[12];
		text14 = array[13];
		text15 = array[14];
		List<string> list = new List<string>();
		list.Add((text2 != "") ? ("pass|" + text2) : "");
		list.Add((text3 != "") ? ("token|" + text3) : "");
		list.Add((text4 != "") ? ("cookie1|" + text4) : "");
		list.Add((text5 != "") ? ("email|" + text5) : "");
		list.Add((text6 != "") ? ("passmail|" + text6) : "");
		list.Add((text7 != "") ? ("fa2|" + text7) : "");
		list.Add((text8 != "") ? ("useragent|" + text8) : "");
		list.Add((text9 != "") ? ("proxy|" + text9) : "");
		list.Add((text10 != "") ? ("birthday|" + text10) : "");
		list.Add((text11 != "") ? ("friends|" + text11) : "");
		list.Add((text12 != "") ? ("dateCreateAcc|" + text12) : "");
		list.Add((text13 != "") ? ("mailrecovery|" + text13) : "");
		list.Add((text14 != "") ? ("ghiChu|" + text14) : "");
		list.Add((text15 != "") ? ("interactEnd|" + text15) : "");
		string text16 = "update accounts set";
		foreach (string item in list)
		{
			if (item != "")
			{
				text16 = text16 + " " + item.Split('|')[0] + "='" + item.Split('|')[1] + "',";
				if (item.Split('|')[0] == "pass")
				{
					text16 += "pass_old=pass,";
				}
				if (item.Split('|')[0] == "email")
				{
					text16 += "email_old=email,";
				}
			}
		}
		text16 = text16.TrimEnd(',');
		text16 = text16 + " where uid='" + text + "'";
		return Connector.Instance.ExecuteNonQuery(text16) > 0;
	}

	public static bool smethod_17(string string_0)
	{
		string[] array = string_0.Split('|');
		string text = "";
		string text2 = "";
		string text3 = "";
		string text4 = "";
		string text5 = "";
		string text6 = "";
		string text7 = "";
		string text8 = "";
		string text9 = "";
		string text10 = "";
		string text11 = "";
		string text12 = "";
		string text13 = "";
		string text14 = "";
		text = array[1];
		text2 = array[2];
		text3 = array[3];
		text4 = array[4];
		text5 = array[5];
		text6 = array[6];
		text7 = array[7];
		text8 = array[8];
		text9 = array[9];
		text10 = array[10];
		text11 = array[11];
		text12 = array[12];
		text13 = array[13];
		text14 = array[14];
		List<string> list = new List<string>();
		list.Add((text != "") ? ("pass|" + text) : "");
		list.Add((text2 != "") ? ("token|" + text2) : "");
		list.Add((text3 != "") ? ("cookie1|" + text3) : "");
		list.Add((text4 != "") ? ("email|" + text4) : "");
		list.Add((text5 != "") ? ("passmail|" + text5) : "");
		list.Add((text6 != "") ? ("fa2|" + text6) : "");
		list.Add((text7 != "") ? ("useragent|" + text7) : "");
		list.Add((text8 != "") ? ("proxy|" + text8) : "");
		list.Add((text9 != "") ? ("birthday|" + text9) : "");
		list.Add((text10 != "") ? ("friends|" + text10) : "");
		list.Add((text11 != "") ? ("dateCreateAcc|" + text11) : "");
		list.Add((text12 != "") ? ("mailrecovery|" + text12) : "");
		list.Add((text13 != "") ? ("ghiChu|" + text13) : "");
		list.Add((text14 != "") ? ("interactEnd|" + text14) : "");
		string text15 = "update accounts set";
		foreach (string item in list)
		{
			if (item != "")
			{
				text15 = text15 + " " + item.Split('|')[0] + "='" + item.Split('|')[1] + "',";
				if (item.Split('|')[0] == "pass")
				{
					text15 += "pass_old=pass,";
				}
				if (item.Split('|')[0] == "email")
				{
					text15 += "email_old=email,";
				}
			}
		}
		text15 = text15.TrimEnd(',');
		text15 = text15 + " where email='" + text4 + "'";
		return Connector.Instance.ExecuteNonQuery(text15) > 0;
	}

	public static string BD3E5F36(string AEBD9806)
	{
		try
		{
			return Connector.Instance.method_5("SELECT idFile FROM accounts WHERE id='" + AEBD9806 + "'").ToString();
		}
		catch
		{
		}
		return "";
	}

	public static bool CheckColumnIsExistInTable(string string_0, string string_1)
	{
		return Connector.Instance.method_5("SELECT COUNT(*) AS count FROM pragma_table_info('" + string_0 + "') WHERE name='" + string_1 + "'") > 0;
	}

	public static bool smethod_19(string string_0)
	{
		return Connector.Instance.method_5("SELECT COUNT(*) FROM sqlite_master WHERE type='table' AND name='" + string_0 + "';") > 0;
	}

	public static bool AddColumnsIntoTable(string CB2A9537, string string_0, int CEBE8D22)
	{
		bool result = false;
		try
		{
			if (CheckColumnIsExistInTable(CB2A9537, string_0))
			{
				return true;
			}
			if (Connector.Instance.ExecuteNonQuery("ALTER TABLE " + CB2A9537 + " ADD COLUMN '" + string_0 + "' " + ((CEBE8D22 == 0) ? "INT" : "TEXT") + ";") > 0)
			{
				result = true;
			}
		}
		catch
		{
		}
		return result;
	}

	public static bool smethod_20(string string_0, string string_1, string A836892C)
	{
		bool result = true;
		try
		{
			string string_2 = "INSERT INTO interacts(uid, timeInteract,hanhDong,cauHinh) VALUES ('" + string_0 + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + string_1 + "','" + A836892C + "')";
			Connector.Instance.ExecuteQuery(string_2);
		}
		catch
		{
			result = false;
		}
		return result;
	}

	public static List<BaiViet> GetListBaiVietByID(string string_0)
	{
		List<BaiViet> result = new List<BaiViet>();
		try
		{
			string string_ = "select id, tenChuDe,ngaytao,tieude,anh,video,noidung from BaiViet WHERE id = " + string_0;
			DataTable source = Connector2.Instance.ExecuteQuery(string_);
			result = (from dataRow_0 in source.AsEnumerable()
				select new BaiViet
				{
					Int32_0 = Convert.ToInt32(dataRow_0["id"]),
					D0B8AABE = Convert.ToString(dataRow_0["tenChuDe"]),
					String_3 = Convert.ToString(dataRow_0["ngaytao"]),
					String_1 = Convert.ToString(dataRow_0["anh"]),
					String_2 = Convert.ToString(dataRow_0["video"]),
					String_0 = Convert.ToString(dataRow_0["tieude"]),
					F836E2B8 = Convert.ToString(dataRow_0["noidung"])
				}).ToList();
		}
		catch
		{
		}
		return result;
	}

	public static List<string> smethod_21()
	{
		List<string> list = new List<string>();
		try
		{
			string string_ = "select ten from ChuDe;";
			DataTable dataTable = Connector2.Instance.ExecuteQuery(string_);
			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				list.Add(dataTable.Rows[i][0].ToString());
			}
		}
		catch
		{
		}
		return list;
	}

	public static List<BaiViet> smethod_22(string EF0D791E = "")
	{
		List<BaiViet> result = new List<BaiViet>();
		try
		{
			string text = "";
			text = ((!(EF0D791E != "")) ? "select id,tenchude,ngaytao,tieude,anh,video,noidung from BaiViet" : ("select id,tenchude,ngaytao,tieude,anh,video,noidung from BaiViet WHERE tenchude='" + EF0D791E + "'"));
			DataTable source = Connector2.Instance.ExecuteQuery(text);
			result = (from DCB2EB10 in source.AsEnumerable()
				select new BaiViet
				{
					Int32_0 = Convert.ToInt32(DCB2EB10["id"]),
					D0B8AABE = Convert.ToString(DCB2EB10["tenChuDe"]),
					String_3 = Convert.ToString(DCB2EB10["ngaytao"]),
					String_1 = Convert.ToString(DCB2EB10["anh"]),
					String_2 = Convert.ToString(DCB2EB10["video"]),
					String_0 = Convert.ToString(DCB2EB10["tieude"]),
					F836E2B8 = Convert.ToString(DCB2EB10["noidung"])
				}).ToList();
		}
		catch
		{
		}
		return result;
	}

	public static bool smethod_23(int int_0)
	{
		bool result = false;
		if (Connector2.Instance.method_1("delete from BaiViet where id=" + int_0) > 0)
		{
			result = true;
		}
		return result;
	}

	public static bool smethod_24(string string_0)
	{
		bool flag = false;
		try
		{
			string string_ = "delete from ChuDe where ten='" + string_0 + "'";
			if (Connector2.Instance.method_1(string_) > 0)
			{
				smethod_25(string_0);
				return true;
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	public static bool smethod_25(string string_0)
	{
		bool result = false;
		if (Connector2.Instance.method_1("delete from BaiViet where tenchude='" + string_0 + "'") > 0)
		{
			result = true;
		}
		return result;
	}

	public static bool E4A3E496(string string_0)
	{
		bool result = true;
		try
		{
			string string_ = "insert into ChuDe values('" + string_0 + "')";
			Connector2.Instance.method_1(string_);
		}
		catch
		{
			result = false;
		}
		return result;
	}

	public static List<BaiViet> smethod_26()
	{
		List<BaiViet> result = new List<BaiViet>();
		try
		{
			string string_ = "select id, tenChuDe,ngaytao,tieude,anh,video,noidung from BaiViet ORDER BY id DESC LIMIT 1";
			DataTable source = Connector2.Instance.ExecuteQuery(string_);
			result = (from dataRow_0 in source.AsEnumerable()
				select new BaiViet
				{
					Int32_0 = Convert.ToInt32(dataRow_0["id"]),
					D0B8AABE = Convert.ToString(dataRow_0["tenChuDe"]),
					String_3 = Convert.ToString(dataRow_0["ngaytao"]),
					String_1 = Convert.ToString(dataRow_0["anh"]),
					String_2 = Convert.ToString(dataRow_0["video"]),
					String_0 = Convert.ToString(dataRow_0["tieude"]),
					F836E2B8 = Convert.ToString(dataRow_0["noidung"])
				}).ToList();
		}
		catch
		{
		}
		return result;
	}

	public static bool smethod_27(int int_0, BaiViet E5349E38)
	{
		bool result = true;
		try
		{
			string text = "";
			if (E5349E38.String_0 != null)
			{
				text = text + "tieude = '" + E5349E38.String_0.Replace("'", "''") + "',";
			}
			if (E5349E38.String_1 != null)
			{
				text = text + "anh = '" + E5349E38.String_1 + "',";
			}
			if (E5349E38.F836E2B8 != null)
			{
				text = text + "noidung = '" + E5349E38.F836E2B8.Replace("'", "''") + "',";
			}
			if (E5349E38.String_3 != null)
			{
				text = text + "ngaytao = '" + E5349E38.String_3 + "',";
			}
			if (E5349E38.D0B8AABE != null)
			{
				text = text + "tenchude = '" + E5349E38.D0B8AABE + "',";
			}
			if (E5349E38.String_2 != null)
			{
				text = text + "video = '" + E5349E38.String_2 + "',";
			}
			text = text.TrimEnd(',');
			if (text != "")
			{
				string string_ = "UPDATE BaiViet SET " + text + " WHERE id=" + int_0;
				Connector2.Instance.method_1(string_);
				result = true;
			}
		}
		catch
		{
			result = false;
		}
		return result;
	}

	public static bool smethod_28(string string_0, string F58C9B80)
	{
		bool result = true;
		try
		{
			string string_ = "UPDATE ChuDe SET ten = '" + F58C9B80 + "' WHERE ten='" + string_0 + "'";
			if (Connector2.Instance.method_1(string_) > 0)
			{
				List<BaiViet> list = smethod_22(string_0);
				for (int i = 0; i < list.Count; i++)
				{
					smethod_27(list[i].Int32_0, new BaiViet
					{
						D0B8AABE = F58C9B80
					});
				}
			}
		}
		catch
		{
			result = false;
		}
		return result;
	}

	public static bool smethod_29(string string_0, BaiViet class68_0)
	{
		bool result = true;
		try
		{
			string string_ = "insert into BaiViet(tenChuDe, tieude, noidung, ngaytao, anh,video) values('" + string_0 + "','" + class68_0.String_0.Replace("'", "''") + "','" + class68_0.F836E2B8.Replace("'", "''") + "','" + class68_0.String_3 + "','" + class68_0.String_1 + "','" + class68_0.String_2 + "')";
			Connector2.Instance.method_1(string_);
		}
		catch
		{
			result = false;
		}
		return result;
	}

	internal static DataTable smethod_30(string string_0)
	{
		DataTable result = new DataTable();
		try
		{
			string string_ = "SELECT pass, cookie1, email, fa2, proxy FROM accounts WHERE uid='" + string_0 + "'AND active=1";
			result = Connector.Instance.ExecuteQuery(string_);
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_, "GetPassByUid");
		}
		return result;
	}

	public static DataTable smethod_31(List<string> list_0, bool bool_0 = true)
	{
		DataTable result = new DataTable();
		try
		{
			if (list_0[0].StartsWith("@"))
			{
				List<string> list = new List<string>();
				string text = "";
				for (int i = 0; i < list_0.Count; i++)
				{
					text = "SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id WHERE t1.email Like ('%" + list_0[i] + "%') and t1.active=" + (bool_0 ? 1 : 0);
					list.Add(text);
				}
				result = Connector.Instance.method_2(list);
			}
			else if (list_0[0].Contains("@"))
			{
				int num = 100;
				int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)list_0.Count * 1.0 / 100.0)));
				List<string> list2 = new List<string>();
				string text2 = "";
				for (int j = 0; j < num2; j++)
				{
					text2 = "SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id WHERE t1.email IN ('" + string.Join("','", list_0.GetRange(num * j, (num * j + num <= list_0.Count) ? num : (list_0.Count % num))) + "') and t1.active=" + (bool_0 ? 1 : 0) + " ORDER BY t1.email";
					list2.Add(text2);
				}
				result = Connector.Instance.method_2(list2);
			}
			else
			{
				int num3 = 100;
				int num4 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)list_0.Count * 1.0 / 100.0)));
				List<string> list3 = new List<string>();
				string text3 = "";
				for (int k = 0; k < num4; k++)
				{
					text3 = "SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id WHERE t1.uid IN ('" + string.Join("','", list_0.GetRange(num3 * k, (num3 * k + num3 <= list_0.Count) ? num3 : (list_0.Count % num3))) + "') and t1.active=" + (bool_0 ? 1 : 0) + " ORDER BY t1.uid";
					list3.Add(text3);
				}
				result = Connector.Instance.method_2(list3);
			}
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_, "GetAccFromFile");
		}
		return result;
	}

	public static string smethod_32(string D58DFA04)
	{
		try
		{
			DataTable dataTable = Connector.Instance.ExecuteQuery("SELECT email, passmail FROM accounts WHERE id = " + D58DFA04);
			return dataTable.Rows[0]["email"]?.ToString() + "|" + dataTable.Rows[0]["passmail"];
		}
		catch (Exception)
		{
		}
		return "|";
	}

	public static bool BC0C4529(List<string> DC81EE05)
	{
		bool result = false;
		try
		{
			int num = 100;
			int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)DC81EE05.Count * 1.0 / 100.0)));
			List<string> list = new List<string>();
			string text = "";
			for (int i = 0; i < num2; i++)
			{
				text = "update accounts set pass=pass_old, pass_old=pass where id IN (" + string.Join(",", DC81EE05.GetRange(num * i, (num * i + num <= DC81EE05.Count) ? num : (DC81EE05.Count % num))) + ")";
				list.Add(text);
			}
			result = Connector.Instance.method_3(list) > 0;
		}
		catch
		{
		}
		return result;
	}

	public static bool A200291F(List<string> F987C23A)
	{
		bool result = false;
		try
		{
			int num = 100;
			int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)F987C23A.Count * 1.0 / 100.0)));
			List<string> list = new List<string>();
			string text = "";
			for (int i = 0; i < num2; i++)
			{
				text = "update accounts set email=email_old, email_old=email where id IN (" + string.Join(",", F987C23A.GetRange(num * i, (num * i + num <= F987C23A.Count) ? num : (F987C23A.Count % num))) + ")";
				list.Add(text);
			}
			result = Connector.Instance.method_3(list) > 0;
		}
		catch
		{
		}
		return result;
	}

	public static bool smethod_33(string string_0, string string_1)
	{
		bool result = false;
		try
		{
			string text = Connector.Instance.ExecuteQuery("SELECT STT FROM files WHERE id = " + string_0).Rows[0]["STT"].ToString();
			string text2 = Connector.Instance.ExecuteQuery("SELECT STT FROM files WHERE id = " + string_1).Rows[0]["STT"].ToString();
			string string_2 = "UPDATE files SET STT = " + text2 + " WHERE id = " + string_0;
			string string_3 = "UPDATE files SET STT = " + text + " WHERE id = " + string_1;
			if (Connector.Instance.ExecuteNonQuery(string_2) > 0 && Connector.Instance.ExecuteNonQuery(string_3) > 0)
			{
				result = true;
			}
		}
		catch
		{
		}
		return result;
	}
}
