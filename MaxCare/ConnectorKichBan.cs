using System;
using System.Data;
using System.Data.SQLite;

public class ConnectorKichBan
{
    private static ConnectorKichBan instance;

    private string string_0 = "Data Source=interact\\interact.sqlite;Version=3;";

    private SQLiteConnection sqliteConnection_0 = null;

    public static ConnectorKichBan Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new ConnectorKichBan();
            }
            return instance;
        }
        private set
        {
            instance = value;
        }
    }

    private ConnectorKichBan()
    {
    }

    private void method_0()
    {
        try
        {
            if (sqliteConnection_0 == null)
            {
                sqliteConnection_0 = new SQLiteConnection(string_0);
            }
            if (sqliteConnection_0.State == ConnectionState.Closed)
            {
                sqliteConnection_0.Open();
            }
        }
        catch (Exception exception_)
        {
            Common.ExportError2(exception_, "CheckConnectServer");
        }
    }

    public DataTable method_1(string string_1)
    {
        DataTable dataTable = new DataTable();
        try
        {
            method_0();
            SQLiteCommand cmd = new SQLiteCommand(string_1, sqliteConnection_0);
            SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter(cmd);
            sQLiteDataAdapter.Fill(dataTable);
        }
        catch
        {
        }
        return dataTable;
    }

    public int method_2(string string_1)
    {
        int result = 0;
        try
        {
            method_0();
            SQLiteCommand sQLiteCommand = new SQLiteCommand(string_1, sqliteConnection_0);
            result = sQLiteCommand.ExecuteNonQuery();
        }
        catch (Exception)
        {
        }
        return result;
    }

    public int method_3(string CD85CB90)
    {
        int result = -1;
        try
        {
            method_0();
            SQLiteCommand sQLiteCommand = new SQLiteCommand(CD85CB90, sqliteConnection_0);
            long num = (long)sQLiteCommand.ExecuteScalar();
            result = (int)num;
        }
        catch
        {
        }
        return result;
    }
}
