using System;
using System.Data;
using System.Data.SQLite;

// Token: 0x02000051 RID: 81
public class ConnectorCloneDatabase
{
    // Token: 0x06000407 RID: 1031 RVA: 0x00074C5B File Offset: 0x00072E5B
    public ConnectorCloneDatabase(string string_1)
    {
        this.string_0 = "Data Source=" + string_1 + ";Version=3;";
    }

    // Token: 0x06000408 RID: 1032 RVA: 0x000B052C File Offset: 0x000AE72C
    public void CheckConnectServer()
    {
        try
        {
            if (this.sqliteConnection_0 == null)
            {
                this.sqliteConnection_0 = new SQLiteConnection(this.string_0);
            }
            if (this.sqliteConnection_0.State == ConnectionState.Closed)
            {
                this.sqliteConnection_0.Open();
            }
        }
        catch (Exception)
        {
        }
    }

    // Token: 0x06000409 RID: 1033 RVA: 0x000B0588 File Offset: 0x000AE788
    public DataTable ExecuteQuery(string string_1)
    {
        DataTable dataTable = new DataTable();
        try
        {
            this.CheckConnectServer();
            SQLiteCommand sqliteCommand = new SQLiteCommand(string_1, this.sqliteConnection_0);
            SQLiteDataAdapter sqliteDataAdapter = new SQLiteDataAdapter(sqliteCommand);
            sqliteDataAdapter.Fill(dataTable);
        }
        catch
        {
        }
        return dataTable;
    }

    // Token: 0x0600040A RID: 1034 RVA: 0x000B05D8 File Offset: 0x000AE7D8
    public int ExecuteNonQuery(string string_1)
    {
        int num = 0;
        try
        {
            this.CheckConnectServer();
            SQLiteCommand sqliteCommand = new SQLiteCommand(string_1, this.sqliteConnection_0);
            num = sqliteCommand.ExecuteNonQuery();
        }
        catch (Exception)
        {
        }
        return num;
    }

    // Token: 0x0400026F RID: 623
    private string string_0;

    // Token: 0x04000270 RID: 624
    private SQLiteConnection sqliteConnection_0 = null;
}
