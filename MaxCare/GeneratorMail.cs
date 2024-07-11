using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class GeneratorEmail
{
    private string email = "";

    public string domain = "";

    private string mail = "";

    public GeneratorEmail()
    {
    }

    public GeneratorEmail(string email)
    {
        this.email = email;
        domain = this.email.Split('@')[1];
        mail = this.email.Split('@')[0];
    }

    public string ReadMail(int type, int timeOut)
    {
        if (email.Split('@').Length < 2)
        {
            return "";
        }
        RequestXNet requestXNet = new RequestXNet("", "", "", 0);
        int tickCount = Environment.TickCount;
        do
        {
            List<string> list = new List<string>();
            string text = "";
            try
            {
                try
                {
                    text = requestXNet.RequestGet("https://generator.email/" + domain + "/" + mail);
                }
                catch (Exception)
                {
                    text = new RequestHttp().RequestGet("https://generator.email/" + domain + "/" + mail);
                }
            }
            catch
            {
            }
            foreach (Match item in Regex.Matches(text, $"href=\"(/{domain}/{mail}/.*?)\""))
            {
                list.Add(item.Groups[1].Value);
            }
            while (true)
            {
                string text2 = OtpMailHelper.GetOtpMail(text, type);
                if (text2 == "14072921")
                {
                    text2 = "";
                }
                if (text2 != "")
                {
                    return text2;
                }
                if (list.Count == 0)
                {
                    break;
                }
                text = requestXNet.RequestGet("https://generator.email/" + list[0]);
                list.RemoveAt(0);
            }
            Common.Sleep(3.0);
        }
        while (Environment.TickCount - tickCount < timeOut * 1000);
        return "";
    }

    public string CreateRandomEmail()
    {
        if (domain == "")
        {
            return "";
        }
        mail = Common.ConvertToUnSign((from t in SetupFolder.GetListHoVN()
                                       orderby Guid.NewGuid()
                                       select t).First() + (from t in SetupFolder.GetListTenVN()
                                                            orderby Guid.NewGuid()
                                                            select t).First()).Replace(" ", "").ToLower() + Common.CreateRandomNumber(6);
        return GetEmail();
    }

    public string GetEmail()
    {
        return mail + "@" + domain;
    }
}
