using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class proccessDataList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["action"] == "getpagetoken")
            {
                string pagedata = Request["pagedata"];
                if (!string.IsNullOrEmpty(pagedata))
                {

                    //获取index页面数据
                    NameValueCollection prams = new NameValueCollection();
                    //传送给detail的数据
                    prams.Add("keyValue", pagedata);
                    System.Net.WebClient myClient = new System.Net.WebClient();

                    //登录信息
                    myClient.Headers.Add("Cookie", @"__RequestVerificationToken=047t6BXjdo6dJ4R9RL6a6TKeqHKB5gM3ZqL_s2wrSW0fw7ZLhe-rXiRezS3rIBTVFcRk8omo8ofgBbzxh3ioLHsTOiyuG9QAzK98eiOuFA41; _deleteIds=; ValidateCode=ubdp; userinfo=%7b%22id%22%3a462869%2c%22email%22%3a%22945357506%40qq.com%22%2c%22loginPwd%22%3a%22wuji%22%2c%22nickName%22%3a%22%e7%a7%8b%e6%b0%b4%22%2c%22signature%22%3a%22%e8%ae%b0%e5%be%97%e5%86%99%e6%97%a5%e8%ae%b0%22%2c%22avatarUrl%22%3a%22http%3a%2f%2fuser.xiejianji.com%2f16091823425388462869A272434A.jpg%22%2c%22backgroundUrl%22%3a%22http%3a%2f%2fapi.xiejianji.com%2fUpFiles%2fInitImages%2fbackgroundInit.jpg%22%2c%22starCount%22%3a126%2c%22privacyPwd%22%3a%221235%22%2c%22isPrivacy%22%3a1%2c%22isPublic%22%3a0%2c%22isReview%22%3a1%2c%22registerDate%22%3a%2220160918231312%22%2c%22lastLoginDate%22%3a%2220170415172508%22%2c%22isTouchID%22%3a0%2c%22lastDiaryDate%22%3a%2220170415005016%22%2c%22VIP%22%3a0%2c%22buyVIPCount%22%3a0%2c%22isBanPasserby%22%3a0%2c%22wirteUpCount%22%3a0%2c%22isInvalid%22%3a0%2c%22vipEndDate%22%3a%22%22%2c%22vipType%22%3a0%2c%22notificationId%22%3a0%2c%22announcementId%22%3a0%2c%22shareDomain%22%3a%22http%3a%2f%2fwww.sharewuji.com%22%2c%22isVip%22%3a0%7d; qntoken=%7b%22mediaUpToken%22%3a%22vl82-w1ZItdvucyb0gejjhplWjZSkxHh3nwdrC29%3a7g9d07kh1y9xdkMsCH_OdedLVos%3d%3aeyJzY29wZSI6Ind1amltZWRpYSIsImRlYWRsaW5lIjoxNDkyODUzMTA4LCJjYWxsYmFja1VybCI6Imh0dHA6Ly9hcGkueGllamlhbmppLmNvbS9hcGkvRGlhcnlzL1Bvc3RDYWxsQmFjayIsImNhbGxiYWNrQm9keSI6Imhhc2g9JChldGFnKSZrZXk9JChrZXkpJmlkPSQoeDppZCkmdHlwZT0kKHg6ZmlsZVR5cGUpJnZlcmlmPSQoeDphS2V5KSJ9%22%2c%22userUpToken%22%3a%22vl82-w1ZItdvucyb0gejjhplWjZSkxHh3nwdrC29%3ah81zI43ja6EqEivJ3Xl6ntVJx1o%3d%3aeyJzY29wZSI6Ind1aml1c2VyIiwiZGVhZGxpbmUiOjE0OTI4NTMxMDgsImNhbGxiYWNrVXJsIjoiaHR0cDovL2FwaS54aWVqaWFuamkuY29tL2FwaS9EaWFyeXMvUG9zdENhbGxCYWNrIiwiY2FsbGJhY2tCb2R5IjoiaGFzaD0kKGV0YWcpJmtleT0kKGtleSkmaWQ9JCh4OmlkKSZ0eXBlPSQoeDpmaWxlVHlwZSkmdmVyaWY9JCh4OmFLZXkpIn0%3d%22%2c%22backgroundUpToken%22%3a%22vl82-w1ZItdvucyb0gejjhplWjZSkxHh3nwdrC29%3aiojl4qgdOiyJfKE6fRP2DR_fiOQ%3d%3aeyJzY29wZSI6Ind1amliYWNrZ3JvdW5kIiwiZGVhZGxpbmUiOjE0OTI4NTMxMDgsImNhbGxiYWNrVXJsIjoiaHR0cDovL2FwaS54aWVqaWFuamkuY29tL2FwaS9EaWFyeXMvUG9zdENhbGxCYWNrIiwiY2FsbGJhY2tCb2R5IjoiaGFzaD0kKGV0YWcpJmtleT0kKGtleSkmaWQ9JCh4OmlkKSZ0eXBlPSQoeDpmaWxlVHlwZSkmdmVyaWY9JCh4OmFLZXkpIn0%3d%22%2c%22videoUpToken%22%3a%22vl82-w1ZItdvucyb0gejjhplWjZSkxHh3nwdrC29%3a5gK-E0Lh9G7E0HJwjFPQhIDOdkI%3d%3aeyJzY29wZSI6Ind1aml2aWRlbyIsImRlYWRsaW5lIjoxNDkyODUzMTA4LCJjYWxsYmFja1VybCI6Imh0dHA6Ly9hcGkueGllamlhbmppLmNvbS9hcGkvRGlhcnlzL1Bvc3RDYWxsQmFjayIsImNhbGxiYWNrQm9keSI6Imhhc2g9JChldGFnKSZrZXk9JChrZXkpJmlkPSQoeDppZCkmdHlwZT0kKHg6ZmlsZVR5cGUpJnZlcmlmPSQoeDphS2V5KSJ9%22%7d");
                    myClient.Headers.Add("User-Agent: Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/57.0.2987.98 Safari/537.36");
                    //获取明细
                    byte[] htmldata = myClient.UploadValues("http://wujime.com/WuJi/GetMyDiarys", prams);
                    string html = System.Text.Encoding.UTF8.GetString(htmldata);

                    JObject jsonObj = JObject.Parse(html);
                    string data = jsonObj["data"].ToString();

                    Response.Write(data);
                    Response.End();
                }
            }
            else if (Request["action"] == "getdata")
            {
                string token = Request["token"];
                NameValueCollection prams = new NameValueCollection();
                prams.Add("keyValue", token);
                System.Net.WebClient myClient = new System.Net.WebClient();

                //登录信息
                myClient.Headers.Add("Cookie", @"__RequestVerificationToken=047t6BXjdo6dJ4R9RL6a6TKeqHKB5gM3ZqL_s2wrSW0fw7ZLhe-rXiRezS3rIBTVFcRk8omo8ofgBbzxh3ioLHsTOiyuG9QAzK98eiOuFA41; _deleteIds=; ValidateCode=ubdp; userinfo=%7b%22id%22%3a462869%2c%22email%22%3a%22945357506%40qq.com%22%2c%22loginPwd%22%3a%22wuji%22%2c%22nickName%22%3a%22%e7%a7%8b%e6%b0%b4%22%2c%22signature%22%3a%22%e8%ae%b0%e5%be%97%e5%86%99%e6%97%a5%e8%ae%b0%22%2c%22avatarUrl%22%3a%22http%3a%2f%2fuser.xiejianji.com%2f16091823425388462869A272434A.jpg%22%2c%22backgroundUrl%22%3a%22http%3a%2f%2fapi.xiejianji.com%2fUpFiles%2fInitImages%2fbackgroundInit.jpg%22%2c%22starCount%22%3a126%2c%22privacyPwd%22%3a%221235%22%2c%22isPrivacy%22%3a1%2c%22isPublic%22%3a0%2c%22isReview%22%3a1%2c%22registerDate%22%3a%2220160918231312%22%2c%22lastLoginDate%22%3a%2220170415172508%22%2c%22isTouchID%22%3a0%2c%22lastDiaryDate%22%3a%2220170415005016%22%2c%22VIP%22%3a0%2c%22buyVIPCount%22%3a0%2c%22isBanPasserby%22%3a0%2c%22wirteUpCount%22%3a0%2c%22isInvalid%22%3a0%2c%22vipEndDate%22%3a%22%22%2c%22vipType%22%3a0%2c%22notificationId%22%3a0%2c%22announcementId%22%3a0%2c%22shareDomain%22%3a%22http%3a%2f%2fwww.sharewuji.com%22%2c%22isVip%22%3a0%7d; qntoken=%7b%22mediaUpToken%22%3a%22vl82-w1ZItdvucyb0gejjhplWjZSkxHh3nwdrC29%3a7g9d07kh1y9xdkMsCH_OdedLVos%3d%3aeyJzY29wZSI6Ind1amltZWRpYSIsImRlYWRsaW5lIjoxNDkyODUzMTA4LCJjYWxsYmFja1VybCI6Imh0dHA6Ly9hcGkueGllamlhbmppLmNvbS9hcGkvRGlhcnlzL1Bvc3RDYWxsQmFjayIsImNhbGxiYWNrQm9keSI6Imhhc2g9JChldGFnKSZrZXk9JChrZXkpJmlkPSQoeDppZCkmdHlwZT0kKHg6ZmlsZVR5cGUpJnZlcmlmPSQoeDphS2V5KSJ9%22%2c%22userUpToken%22%3a%22vl82-w1ZItdvucyb0gejjhplWjZSkxHh3nwdrC29%3ah81zI43ja6EqEivJ3Xl6ntVJx1o%3d%3aeyJzY29wZSI6Ind1aml1c2VyIiwiZGVhZGxpbmUiOjE0OTI4NTMxMDgsImNhbGxiYWNrVXJsIjoiaHR0cDovL2FwaS54aWVqaWFuamkuY29tL2FwaS9EaWFyeXMvUG9zdENhbGxCYWNrIiwiY2FsbGJhY2tCb2R5IjoiaGFzaD0kKGV0YWcpJmtleT0kKGtleSkmaWQ9JCh4OmlkKSZ0eXBlPSQoeDpmaWxlVHlwZSkmdmVyaWY9JCh4OmFLZXkpIn0%3d%22%2c%22backgroundUpToken%22%3a%22vl82-w1ZItdvucyb0gejjhplWjZSkxHh3nwdrC29%3aiojl4qgdOiyJfKE6fRP2DR_fiOQ%3d%3aeyJzY29wZSI6Ind1amliYWNrZ3JvdW5kIiwiZGVhZGxpbmUiOjE0OTI4NTMxMDgsImNhbGxiYWNrVXJsIjoiaHR0cDovL2FwaS54aWVqaWFuamkuY29tL2FwaS9EaWFyeXMvUG9zdENhbGxCYWNrIiwiY2FsbGJhY2tCb2R5IjoiaGFzaD0kKGV0YWcpJmtleT0kKGtleSkmaWQ9JCh4OmlkKSZ0eXBlPSQoeDpmaWxlVHlwZSkmdmVyaWY9JCh4OmFLZXkpIn0%3d%22%2c%22videoUpToken%22%3a%22vl82-w1ZItdvucyb0gejjhplWjZSkxHh3nwdrC29%3a5gK-E0Lh9G7E0HJwjFPQhIDOdkI%3d%3aeyJzY29wZSI6Ind1aml2aWRlbyIsImRlYWRsaW5lIjoxNDkyODUzMTA4LCJjYWxsYmFja1VybCI6Imh0dHA6Ly9hcGkueGllamlhbmppLmNvbS9hcGkvRGlhcnlzL1Bvc3RDYWxsQmFjayIsImNhbGxiYWNrQm9keSI6Imhhc2g9JChldGFnKSZrZXk9JChrZXkpJmlkPSQoeDppZCkmdHlwZT0kKHg6ZmlsZVR5cGUpJnZlcmlmPSQoeDphS2V5KSJ9%22%7d");
                myClient.Headers.Add("User-Agent: Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/57.0.2987.98 Safari/537.36");
                //获取明细
                byte[] htmldata = myClient.UploadValues("http://wujime.com/WuJi/GetDiaryDetail", prams);
                string html = System.Text.Encoding.UTF8.GetString(htmldata);

                JObject jo = JObject.Parse(html);
                Response.Write(jo["data"].ToString());
                Response.End();
            }
            else if (Request["action"] == "savedata")
            {
                string jsondata = Request["jsondata"];
                JObject jsonObj = JObject.Parse(jsondata);
                diary ent = new diary();
                ent.address = jsonObj["address"].ToString();
                ent.content = jsonObj["content"].ToString();
                ent.Id = Guid.NewGuid().ToString();
                ent.key = jsonObj["id"].ToString(); ;
                ent.weekday = ToWeekday(Convert.ToInt32(jsonObj["weekday"]));
                ent.weather = ToWeather(Convert.ToInt32(jsonObj["weather"]));
                ent.createDate = DateTime.ParseExact(jsonObj["createDate"].ToString(),
                    "yyyyMMddHHmmss", System.Globalization.CultureInfo.CurrentCulture);
                ent.CJTime = DateTime.Now;

                diaryEntities db = new diaryEntities();
                if (db.diary.Where(o => o.key == ent.key).Count() > 0)
                {
                    Response.Write("数据已存在！");
                    Response.End();
                    return;
                }
                db.diary.Add(ent);
                db.SaveChanges();
                Response.Write("保存成功！");
                Response.End();
            }
        }

        #region util
        private string ToWeekday(int n)
        {
            string t = "";
            switch (n)
            {
                case 1:
                    t = "星期日";
                    break;
                case 2:
                    t = "星期一";
                    break;
                case 3:
                    t = "星期二";
                    break;
                case 4:
                    t = "星期三";
                    break;
                case 5:
                    t = "星期四";
                    break;
                case 6:
                    t = "星期五";
                    break;
                case 7:
                    t = "星期六";
                    break;
                default:
                    t = "";
                    break;
            }
            return t;
        }
        private string ToWeather(int n)
        {
            string t = "";
            switch (n)
            {
                case 1:
                    t = "晴天";
                    break;
                case 2:
                    t = "多云";
                    break;
                case 3:
                    t = "阴天";
                    break;
                case 4:
                    t = "大雨";
                    break;
                case 5:
                    t = "雷雨";
                    break;
                case 6:
                    t = "小雨";
                    break;
                case 7:
                    t = "雾";
                    break;
                case 8:
                    t = "雪";
                    break;
                case 9:
                    t = "雾霾";
                    break;
                case 10:
                    t = "夜间";
                    break;
                default:
                    return "";
            }
            return t;
        }
        #endregion
    }
}