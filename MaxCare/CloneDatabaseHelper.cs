using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

// Token: 0x02000050 RID: 80
public class CloneDatabaseHelper
{
    public static void CreateFolder(string name)
    {
        try
        {
            if (!Directory.Exists(name))
            {
                Directory.CreateDirectory(name);
            }
            if (!(name == "settings\\setting"))
            {
                return;
            }
        }
        catch
        {
        }
    }
    // Token: 0x06000405 RID: 1029 RVA: 0x000B0228 File Offset: 0x000AE428
    public static void CloneDatabase(string string_0 = "database\\db_maxcare.sqlite", string string_1 = "")
    {
        string fileName = Path.GetFileName(string_0);
        if (!Directory.Exists(string_1))
        {
            string_1 = Environment.GetEnvironmentVariable("LocalAppData") + "\\database";
            CreateFolder(string_1);
        }
        string text = string.Concat(new string[]
        {
            string_1,
            "\\",
            DateTime.Now.ToString("yyyyMMddHHmmss"),
            "_",
            fileName
        });
        ConnectorCloneDatabase connectorClonedb = new ConnectorCloneDatabase(string_0);
        connectorClonedb.CheckConnectServer();
        ConnectorCloneDatabase connectorClonedb2 = new ConnectorCloneDatabase(text);
        connectorClonedb2.CheckConnectServer();
        List<string> list = new List<string>();
        DataTable dataTable = connectorClonedb.ExecuteQuery("select name,sql from sqlite_master;");
        for (int i = 0; i < dataTable.Rows.Count; i++)
        {
            list.Add(dataTable.Rows[i]["name"].ToString());
            connectorClonedb2.ExecuteNonQuery(dataTable.Rows[i]["sql"].ToString());
        }
        for (int j = 0; j < list.Count; j++)
        {
            string text2 = list[j];
            if (!(text2 == "interacts"))
            {
                DataTable dataTable2 = connectorClonedb.ExecuteQuery("pragma table_info(" + text2 + ")");
                List<string> list2 = new List<string>();
                for (int k = 0; k < dataTable2.Rows.Count; k++)
                {
                    list2.Add(dataTable2.Rows[k]["name"].ToString());
                }
                string text3 = string.Concat(new string[]
                {
                    "INSERT INTO ",
                    text2,
                    "(",
                    string.Join(",", list2),
                    ") VALUES "
                });
                List<string> list3 = new List<string>();
                DataTable dataTable3 = connectorClonedb.ExecuteQuery("select * from " + text2);
                int num = 0;
                for (int l = 0; l < dataTable3.Rows.Count; l++)
                {
                    List<string> list4 = new List<string>();
                    for (int m = 0; m < dataTable3.Rows[l].ItemArray.Length; m++)
                    {
                        list4.Add(dataTable3.Rows[l][m].ToString().Replace("'", "''"));
                    }
                    list3.Add("('" + string.Join("','", list4) + "')");
                    num++;
                    if (num % 1000 == 0)
                    {
                        connectorClonedb2.ExecuteNonQuery(text3 + string.Join(",", list3));
                        list3 = new List<string>();
                    }
                }
                connectorClonedb2.ExecuteNonQuery(text3 + string.Join(",", list3));
            }
        }
    }
}
