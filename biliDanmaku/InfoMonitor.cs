using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace biliDanmaku
{
    static class InfoMonitor
    {
        private static string connectStr = "https://api.bilibili.com/x/relation/stat?vmid=";
        private static string connectStr2 = "https://api.bilibili.com/x/space/upstat?mid=";
        public static int fan_number = 0;
        public static int play_number = 0;
        public static bool succeed = false;
        private static HttpClient httpClient = new HttpClient() { Timeout = TimeSpan.FromSeconds(5) };
        public async static Task<bool> Getinfo(int userid) {
            succeed = false;
            //try {
                var req = await httpClient.GetStringAsync(connectStr + userid.ToString() + "&jsonp=jsonp");
                Console.WriteLine(req.ToString());
                var userobj1 = JObject.Parse(req);
                fan_number = int.Parse(userobj1["data"]["follower"].ToString());
                req = await httpClient.GetStringAsync(connectStr2 + userid.ToString());
                Console.WriteLine(req.ToString());
                var userobj2 = JObject.Parse(req);
                Console.WriteLine(userobj2["data"]["archive"]["view"].ToString());
                play_number = int.Parse(userobj2["data"]["archive"]["view"].ToString());
                succeed = true;
            /*
            }
            catch (Exception) {

            }
            */
            
            return true;
        }

    }
}
