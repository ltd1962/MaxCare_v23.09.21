using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class DatagridviewHelper
{
	[CompilerGenerated]
	private sealed class Class110
	{
		public DataGridView dataGridView_0;

		public bool bool_0;

		internal void method_0()
		{
			foreach (DataGridViewColumn column in dataGridView_0.Columns)
			{
				column.SortMode = (bool_0 ? DataGridViewColumnSortMode.Automatic : DataGridViewColumnSortMode.NotSortable);
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class111
	{
		public string A2317228;

		public DataGridView dataGridView_0;

		public int FC09B6A5;

		public int A286F60C;

		internal void method_0()
		{
			A2317228 = dataGridView_0.Rows[FC09B6A5].Cells[A286F60C].Value.ToString();
		}
	}

	[CompilerGenerated]
	private sealed class CAB7068D
	{
		public string F003E79E;

		public DataGridView FB9E2916;

		public int int_0;

		public string D03AAB8D;

		internal void B7970C18()
		{
			F003E79E = FB9E2916.Rows[int_0].Cells[D03AAB8D].Value.ToString();
		}
	}

	[CompilerGenerated]
	private sealed class Class112
	{
		public DataGridView CB28B43F;

		public int FA35172F;

		public int int_0;

		public object object_0;

		internal void method_0()
		{
			CB28B43F.Rows[FA35172F].Cells[int_0].Value = object_0;
		}
	}

	[CompilerGenerated]
	private sealed class Class113
	{
		public DataGridView B6A916AC;

		public int int_0;

		public string string_0;

		public object BA20BE99;

		internal void method_0()
		{
			B6A916AC.Rows[int_0].Cells[string_0].Value = BA20BE99;
		}
	}

	private static Dictionary<DataGridView, bool> B38F1EA3 = new Dictionary<DataGridView, bool>();

	public static void smethod_0(DataGridView dataGridView_0, bool bool_0)
	{
		try
		{
			if (!B38F1EA3.ContainsKey(dataGridView_0))
			{
				B38F1EA3.Add(dataGridView_0, value: true);
			}
			if (B38F1EA3[dataGridView_0] == bool_0)
			{
				return;
			}
			dataGridView_0.Invoke((MethodInvoker)delegate
			{
				foreach (DataGridViewColumn column in dataGridView_0.Columns)
				{
					column.SortMode = (bool_0 ? DataGridViewColumnSortMode.Automatic : DataGridViewColumnSortMode.NotSortable);
				}
			});
			B38F1EA3[dataGridView_0] = bool_0;
		}
		catch (Exception)
		{
		}
	}

	public static void smethod_1(DataGridView dataGridView_0, int A5379DB6)
	{
		if (A5379DB6 == -1)
		{
			for (int i = 0; i < dataGridView_0.RowCount; i++)
			{
				smethod_2(dataGridView_0, i, -1);
			}
		}
		else
		{
			smethod_2(dataGridView_0, A5379DB6, -1);
		}
	}

	public static void smethod_2(DataGridView dataGridView_0, int int_0, int int_1)
	{
		if (int_1 == -1)
		{
			string text = GetStatusDataGridView(dataGridView_0, int_0, "cInfo");
			if (text == "Live")
			{
				int_1 = 2;
			}
			else if (text.Contains("Die") || text.Contains("Checkpoint") || text.Contains("Changed pass"))
			{
				int_1 = 1;
			}
		}
		switch (SettingsTool.GetSettings("configGeneral").GetValueInt("typePhanBietMau"))
		{
		case 0:
			switch (int_1)
			{
			case 0:
				dataGridView_0.Rows[int_0].DefaultCellStyle.BackColor = Color.White;
				break;
			case 1:
				dataGridView_0.Rows[int_0].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
				break;
			case 2:
				dataGridView_0.Rows[int_0].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
				break;
			}
			break;
		case 1:
			switch (int_1)
			{
			case 0:
				dataGridView_0.Rows[int_0].DefaultCellStyle.ForeColor = Color.Black;
				break;
			case 1:
				dataGridView_0.Rows[int_0].DefaultCellStyle.ForeColor = Color.Red;
				break;
			case 2:
				dataGridView_0.Rows[int_0].DefaultCellStyle.ForeColor = Color.Green;
				break;
			}
			break;
		}
	}

	public static void smethod_3(DataGridView E4B78E24, int int_0, string F5B62533, int int_1 = 0, string string_0 = "Đơ\u0323i {time} giây...")
	{
		try
		{
			int tickCount = Environment.TickCount;
			while (true)
			{
				int num = int_1 - (Environment.TickCount - tickCount) / 1000;
				if (num > 0)
				{
					SetStatusDataGridView(E4B78E24, int_0, F5B62533, string_0.Replace("{time}", num.ToString()));
					Common.Sleep(0.5);
					continue;
				}
				break;
			}
		}
		catch
		{
		}
	}

	public static string GetStatusDataGridView(DataGridView dataGridView_0, int int_0, int int_1)
	{
		string A2317228 = "";
		try
		{
			if (dataGridView_0.Rows[int_0].Cells[int_1].Value == null)
			{
				return "";
			}
			try
			{
				A2317228 = dataGridView_0.Rows[int_0].Cells[int_1].Value.ToString();
			}
			catch
			{
				dataGridView_0.Invoke((MethodInvoker)delegate
				{
					A2317228 = dataGridView_0.Rows[int_0].Cells[int_1].Value.ToString();
				});
			}
		}
		catch
		{
		}
		return A2317228;
	}

	public static string GetStatusDataGridView(DataGridView A2A2F605, int B71F99AE, string D3216E23)
	{
		string F003E79E = "";
		try
		{
			if (A2A2F605.Rows[B71F99AE].Cells[D3216E23].Value == null)
			{
				return "";
			}
			try
			{
				F003E79E = A2A2F605.Rows[B71F99AE].Cells[D3216E23].Value.ToString();
			}
			catch
			{
				A2A2F605.Invoke((MethodInvoker)delegate
				{
					F003E79E = A2A2F605.Rows[B71F99AE].Cells[D3216E23].Value.ToString();
				});
			}
		}
		catch
		{
		}
		return F003E79E;
	}

	public static void smethod_5(DataGridView dataGridView_0, int AE92BEB5, int int_0, object object_0)
	{
		try
		{
			try
			{
				dataGridView_0.Invoke((MethodInvoker)delegate
				{
					dataGridView_0.Rows[AE92BEB5].Cells[int_0].Value = object_0;
				});
			}
			catch
			{
				dataGridView_0.Rows[AE92BEB5].Cells[int_0].Value = object_0;
			}
		}
		catch
		{
		}
	}

	public static void SetStatusDataGridView(DataGridView dataGridView_0, int int_0, string D5A21DAF, object object_0)
	{
		try
		{
			if (UpdateStatus.isSaveSettings && D5A21DAF == "cStatus")
			{
				string f3B = GetStatusDataGridView(dataGridView_0, int_0, "cId");
				UpdateStatus.B1176AAC(f3B, object_0.ToString());
			}
			try
			{
				dataGridView_0.Invoke((MethodInvoker)delegate
				{
					dataGridView_0.Rows[int_0].Cells[D5A21DAF].Value = object_0;
				});
			}
			catch
			{
				dataGridView_0.Rows[int_0].Cells[D5A21DAF].Value = object_0;
			}
		}
		catch
		{
		}
	}

	public static void smethod_6(DataGridView dataGridView_0, DataTable dataTable_0, bool F58C3000 = false)
	{
		if (F58C3000)
		{
			for (int i = 0; i < dataTable_0.Rows.Count; i++)
			{
				DataRow dataRow = dataTable_0.Rows[i];
				dataGridView_0.Rows.Add(false, dataGridView_0.RowCount + 1, dataRow["id"], dataRow["uid"], dataRow["token"], dataRow["cookie1"], dataRow["email"], dataRow["phone"], dataRow["name"], dataRow["follow"], dataRow["friends"], dataRow["groups"], dataRow["pages"], dataRow["pagePro5"], dataRow["birthday"], dataRow["gender"], dataRow["pass"], dataRow["mailrecovery"], dataRow["passmail"], dataRow["backup"], dataRow["fa2"], dataRow["useragent"], dataRow["proxy"], dataRow["dateCreateAcc"], dataRow["avatar"], dataRow["profile"], dataRow["nameFile"], dataRow["interactEnd"], dataRow["info"], dataRow["ghiChu"], dataRow["location"], dataRow["hometown"], dataRow["currentCity"], dataRow["dating"], dataRow["ads"], dataRow["bm"], dataRow["wallPosts"], dataRow["fbBlock"], dataRow["job"], dataRow["dateDelete"], UpdateStatus.smethod_0(dataRow["id"].ToString()));
			}
			return;
		}
		for (int j = 0; j < dataTable_0.Rows.Count; j++)
		{
			DataRow dataRow2 = dataTable_0.Rows[j];
			dataGridView_0.Rows.Add(false, dataGridView_0.RowCount + 1, dataRow2["id"], dataRow2["uid"], dataRow2["token"], dataRow2["cookie1"], dataRow2["email"], dataRow2["email2"], dataRow2["phone"], dataRow2["name"], dataRow2["follow"], dataRow2["friends"], dataRow2["groups"], dataRow2["pages"], dataRow2["pagePro5"], dataRow2["birthday"], dataRow2["gender"], dataRow2["pass"], dataRow2["mailrecovery"], dataRow2["passmail"], dataRow2["backup"], dataRow2["fa2"], dataRow2["useragent"], dataRow2["proxy"], dataRow2["dateCreateAcc"], dataRow2["avatar"], dataRow2["profile"], dataRow2["nameFile"], dataRow2["interactEnd"], dataRow2["info"], dataRow2["ghiChu"], dataRow2["status282"], dataRow2["location"], dataRow2["hometown"], dataRow2["currentCity"], dataRow2["dating"], dataRow2["ads"], dataRow2["bm"], dataRow2["wallPosts"], dataRow2["fbBlock"], dataRow2["job"], dataRow2["kichban"], UpdateStatus.smethod_0(dataRow2["id"].ToString()));
		}
	}

	internal static void smethod_7(DataGridViewSortCompareEventArgs dataGridViewSortCompareEventArgs_0)
	{
		try
		{
			List<string> list = new List<string> { "cStt", "cFriend", "cGroup", "cFollow", "cPage", "cPagePro5", "cBM" };
			string text = dataGridViewSortCompareEventArgs_0.CellValue1.ToString().Trim();
			string text2 = dataGridViewSortCompareEventArgs_0.CellValue2.ToString().Trim();
			if (text == "" || text2 == "")
			{
				dataGridViewSortCompareEventArgs_0.SortResult = text.CompareTo(text2);
				dataGridViewSortCompareEventArgs_0.Handled = true;
				return;
			}
			if (list.Contains(dataGridViewSortCompareEventArgs_0.Column.Name))
			{
				if (!Common.IsNumber(text))
				{
					text = ((text != "") ? "-1" : "-2");
				}
				if (!Common.IsNumber(text2))
				{
					text2 = ((text2 != "") ? "-1" : "-2");
				}
				dataGridViewSortCompareEventArgs_0.SortResult = int.Parse(text).CompareTo(int.Parse(text2));
			}
			else if (dataGridViewSortCompareEventArgs_0.Column.Name == "cWallPosts")
			{
				dataGridViewSortCompareEventArgs_0.SortResult = int.Parse(text.Replace("+", "")).CompareTo(int.Parse(text2.Replace("+", "")));
			}
			else if (dataGridViewSortCompareEventArgs_0.Column.Name == "cInteractEnd")
			{
				dataGridViewSortCompareEventArgs_0.SortResult = Common.ConvertStringToDatetime(text).CompareTo(Common.ConvertStringToDatetime(text2));
			}
			else if (dataGridViewSortCompareEventArgs_0.Column.Name == "cDateDelete")
			{
				dataGridViewSortCompareEventArgs_0.SortResult = Common.ConvertStringToDatetime(text, "HH:mm:ss dd/MM/yyyy").CompareTo(Common.ConvertStringToDatetime(text2, "HH:mm:ss dd/MM/yyyy"));
			}
			else if (dataGridViewSortCompareEventArgs_0.Column.Name == "cJob")
			{
				string[] array = dataGridViewSortCompareEventArgs_0.CellValue1.ToString().Split(' ');
				string[] array2 = dataGridViewSortCompareEventArgs_0.CellValue2.ToString().Split(' ');
				string text3 = array[0].Trim().Substring(1, 10);
				string text4 = array2[0].Trim().Substring(1, 10);
				int num = int.Parse(array[1].Trim());
				int value = int.Parse(array2[1].Trim());
				if (text3 == text4)
				{
					dataGridViewSortCompareEventArgs_0.SortResult = num.CompareTo(value);
				}
				else
				{
					DateTime dateTime = DateTime.ParseExact(text3, "dd/MM/yyyy", CultureInfo.InvariantCulture);
					DateTime value2 = DateTime.ParseExact(text4, "dd/MM/yyyy", CultureInfo.InvariantCulture);
					dataGridViewSortCompareEventArgs_0.SortResult = dateTime.CompareTo(value2);
				}
			}
			else if (dataGridViewSortCompareEventArgs_0.Column.Name == "cStatus282")
			{
				string[] array3 = dataGridViewSortCompareEventArgs_0.CellValue1.ToString().Split('-');
				string[] array4 = dataGridViewSortCompareEventArgs_0.CellValue2.ToString().Split('-');
				string text5 = array3[0].Trim();
				string text6 = array4[0].Trim();
				if (text5 == text6)
				{
					int num2 = 0;
					int num3 = 0;
					if (array3.Count() > 2)
					{
						num2 = int.Parse(array3[2].Trim().Split(' ')[0]);
					}
					if (array4.Count() > 2)
					{
						num3 = int.Parse(array4[2].Trim().Split(' ')[0]);
					}
					if (num2 != num3)
					{
						dataGridViewSortCompareEventArgs_0.SortResult = num2.CompareTo(num3);
					}
					else
					{
						string s = array3[1].Trim();
						string s2 = array4[1].Trim();
						DateTime dateTime2 = DateTime.ParseExact(s, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
						DateTime value3 = DateTime.ParseExact(s2, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
						dataGridViewSortCompareEventArgs_0.SortResult = dateTime2.CompareTo(value3);
					}
				}
				else
				{
					dataGridViewSortCompareEventArgs_0.SortResult = text5.CompareTo(text6);
				}
			}
			else if (dataGridViewSortCompareEventArgs_0.Column.Name == "cStatus")
			{
				string text7 = text;
				string strB = text2;
				if (text.StartsWith("("))
				{
					text7 = text.Substring(text.IndexOf(")") + 1).Trim();
				}
				if (text2.StartsWith("("))
				{
					strB = text2.Substring(text2.IndexOf(")") + 1).Trim();
				}
				dataGridViewSortCompareEventArgs_0.SortResult = text7.CompareTo(strB);
			}
			else if (dataGridViewSortCompareEventArgs_0.Column.Name == "cBirthday")
			{
				dataGridViewSortCompareEventArgs_0.SortResult = Common.ConvertStringToDatetime(text, "M/d/yyyy").CompareTo(Common.ConvertStringToDatetime(text2, "M/d/yyyy"));
			}
			else if (dataGridViewSortCompareEventArgs_0.Column.Name == "cDateCreateAcc")
			{
				dataGridViewSortCompareEventArgs_0.SortResult = Common.ConvertStringToDatetime(text, "dd/MM/yyyy HH:mm:ss tt").CompareTo(Common.ConvertStringToDatetime(text2, "dd/MM/yyyy HH:mm:ss tt"));
			}
			else if (dataGridViewSortCompareEventArgs_0.Column.Name == "cEmail")
			{
				string text8 = "";
				string strB2 = "";
				if (text.Contains("@"))
				{
					text8 = text.Split('@')[1];
				}
				if (text2.Contains("@"))
				{
					strB2 = text2.Split('@')[1];
				}
				dataGridViewSortCompareEventArgs_0.SortResult = text8.CompareTo(strB2);
			}
			else
			{
				dataGridViewSortCompareEventArgs_0.SortResult = text.CompareTo(text2);
			}
		}
		catch (Exception)
		{
			dataGridViewSortCompareEventArgs_0.SortResult = 0;
		}
		dataGridViewSortCompareEventArgs_0.Handled = true;
	}
}
