using MinsoftLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MinsoftLib
{
    public class TokenHelper
    {

        private static async Task First_Request_Get(string Cookies, string useragent)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
            httpClient.DefaultRequestHeaders.Add("Accept-Language", "en-us,en;q=0.5");
            httpClient.DefaultRequestHeaders.Add("sec-fetch-site", "same-origin");
            httpClient.DefaultRequestHeaders.Add("Cookie", Cookies);
            httpClient.DefaultRequestHeaders.Add("Referer", "https://www.facebook.com");
            httpClient.DefaultRequestHeaders.Add("User-Agent", useragent);
            HttpResponseMessage response = await httpClient.GetAsync("https://www.facebook.com/dialog/oauth?client_id=124024574287414&redirect_uri=https://www.instagram.com/accounts/signup/&&scope=email&response_type=token");
        }

        private static string Second_Request_Get(string cookies, string useragent)
        {
            RequestXNet requestXnet = new RequestXNet(cookies, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/104.0.0.0 Safari/537.36", "", 0);
            string responseBody = requestXnet.RequestGet($"https://www.facebook.com/dialog/oauth?scope=user_about_me,user_actions.books,user_actions.fitness,user_actions.music,user_actions.news,user_actions.video,user_activities,user_birthday,user_education_history,user_events,user_friends,user_games_activity,user_groups,user_hometown,user_interests,user_likes,user_location,user_managed_groups,user_photos,user_posts,user_relationship_details,user_relationships,user_religion_politics,user_status,user_tagged_places,user_videos,user_website,user_work_history,email,manage_notifications,manage_pages,publish_actions,publish_pages,read_friendlists,read_insights,read_page_mailboxes,read_stream,rsvp_event,read_mailbox&response_type=token&client_id=124024574287414&redirect_uri=fb124024574287414://authorize/&sso_key=com&display=&fbclid=IwAR1KPwp2DVh2Cu7KdeANz-dRC_wYNjjHk5nR5F-BzGGj7-gTnKimAmeg08k");
            return responseBody;
        }


        private static string Third_Request_Post(string cookies, string jazoest, string fb_dtsg, string scope, string logger_id, string encrypted_post_bod, string encrypted_query_string, string useragent)
        {
            string response = "";
            xNet.HttpRequest req = new xNet.HttpRequest();
            req.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
            req.AddHeader("Accept-Language", "en-us,en;q=0.5");
            req.AddHeader("Cookie", cookies);
            req.AddHeader("Referer", $@"https://www.facebook.com/dialog/oauth?encrypted_query_string={encrypted_query_string}");
            req.AddHeader("sec-fetch-site", "same-origin");
            req.AddHeader("User-Agent", useragent);
            req.AddParam("jazoest", jazoest);
            req.AddParam("fb_dtsg", fb_dtsg);
            req.AddParam("from_post", "1");
            req.AddParam("__CONFIRM__", "1");
            req.AddParam("scope", scope);
            req.AddParam("display", "page");
            req.AddParam("sdk", "");
            req.AddParam("sdk_version", "");
            req.AddParam("domain", "");
            req.AddParam("sso_device", "ios");
            req.AddParam("state", "");
            req.AddParam("user_code", "");
            req.AddParam("nonce", "");
            req.AddParam("logger_id", logger_id);
            req.AddParam("auth_type", "");
            req.AddParam("auth_nonce", "");
            req.AddParam("code_challenge", "");
            req.AddParam("code_challenge_method", "");
            req.AddParam("encrypted_post_body", encrypted_post_bod);
            req.AddParam("return_format[]", "access_token");
            req.AddParam("__spin_r", "");
            req.AddParam("__spin_b", "");
            req.AddParam("__spin_t", "");
            response = req.Post("https://www.facebook.com/v1.0/dialog/oauth/skip/submit/").ToString();
            return response;
        }


        public static async Task<string> Get_Token_Insta(string cookies, int row, string UA)
        {
            string response = "";
            string response2 = "";
            string access_token = "";
            string jazoest = "";
            string fb_dtsg = "";
            string scope = "";
            string logger_id = "";
            string encrypted_post_body = "";
            string encrypted_query_string = "";
            try
            {
                await First_Request_Get(cookies, UA);
                response = Second_Request_Get(cookies, UA);
                jazoest = Regex.Match(response, @"name=\\\""jazoest\\\"" value=\\\""(.*?)\\\""").Groups[1].Value;
                fb_dtsg = Regex.Match(response, @"name=\\\""fb_dtsg\\\"" value=\\\""(.*?)\\\"" ").Groups[1].Value;
                scope = Regex.Match(response, @"name=\\\""scope\\\"" value=\\\""(.*?)\\\""").Groups[1].Value;
                logger_id = Regex.Match(response, @"name=\\\""logger_id\\\"" value=\\\""(.*?)\\\""").Groups[1].Value;
                encrypted_post_body = Regex.Match(response, @"name=\\\""encrypted_post_body\\\"" value=\\\""(.*?)\\\""").Groups[1].Value;
                encrypted_query_string = Regex.Match(response, @"URL=\/dialog\/oauth\?encrypted_query_string=(.*?)&amp").Groups[1].Value;
                response2 = Third_Request_Post(cookies, jazoest, fb_dtsg, scope, logger_id, encrypted_post_body, encrypted_query_string, UA);
                access_token = Regex.Match(response2, @"access_token=(.*?)&").Groups[1].Value;
            }
            catch
            {
            }
            return access_token;
        }
    }
}
