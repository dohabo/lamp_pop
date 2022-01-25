using Car_Head_Lamp.DAO;
using Car_Head_Lamp.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Car_Head_Lamp.Network
{
    class ThingSpeak
    {
        const string url = "http://api.thingspeak.com/";
        const string APIKEY_WRITE = "0ZN8VEH9U3XF61I0";

        public bool sendDataToThingSpeak(string field1, int field2,
            int field3, int field4, int field5,
            int field6, string field7, string field8)
        {
            string sbQS = string.Empty;
            // http 통신
            sbQS += url + "update?key=" + APIKEY_WRITE;
            if (field1 != null)
            {
                sbQS += "&field1=" + HttpUtility.UrlEncode(field1);
            }
            if (field2.ToString() != null)
            {
                sbQS += "&field2=" + HttpUtility.UrlEncode(field2.ToString());
            }
            if (field3.ToString() != null)
            {
                sbQS += "&field3=" + HttpUtility.UrlEncode(field3.ToString());
            }
            if (field4.ToString() != null)
            {
                sbQS += "&field4=" + HttpUtility.UrlEncode(field4.ToString());
            }
            if (field5.ToString() != null)
            {
                sbQS += "&field5=" + HttpUtility.UrlEncode(field5.ToString());
            }
            if (field6.ToString() != null)
            {
                sbQS += "&field6=" + HttpUtility.UrlEncode(field6.ToString());
            }
            if (field7 != null)
            {
                sbQS += "&field7=" + HttpUtility.UrlEncode(field7);
            }
            if (field8 != null)
            {
                sbQS += "&field8=" + HttpUtility.UrlEncode(field8);
            }
            int res = Convert.ToInt32(postToThingSpeak(sbQS));
            if (res <= 0)
            {
                return false;
            }
            return true;
        }


        public string postToThingSpeak(string str)
        {
            string response = string.Empty;
            byte[] buf = new byte[8192];

            HttpWebRequest myRequest =
                (HttpWebRequest)WebRequest.Create(str);
            HttpWebResponse webResponse =
                (HttpWebResponse)myRequest.GetResponse();

            try
            {
                Stream myResponse = webResponse.GetResponseStream();
                int count = 0;
                do
                {
                    count = myResponse.Read(buf, 0, buf.Length);
                    if (count != 0)
                    {
                        response += Encoding.ASCII.GetString(buf, 0, count);
                    }
                } while (count > 0);
                return response;
            }
            catch (WebException e)
            {
                Console.WriteLine("응답 에러: " + e.Message);
            }
            return "0";
        }

        public List<PassQuan> readThingSpeak()
        {
            string url = "https://api.thingspeak.com/channels/1504087/feeds.json?api_key=4UXN04XCDVWPDJN0&results=1";
            WebClient webClient = new WebClient();
            var data = webClient.DownloadString(url);
            dynamic feed = JsonConvert.DeserializeObject<dynamic>(data);
            List<dynamic> feeds = feed.feeds.ToObject<List<dynamic>>();
            List<PassQuan> list = new List<PassQuan>();

            Console.WriteLine("채널 정보: " + feed.channel.name);
            for (int i = 0; i < feeds.Count; i++)
            {
                string time = feeds[i].created_at;
                string orderNum = OraMgr.Instance.getOrderNum();
                string orderQuan = feeds[i].field1;
                string process1PassQuan = feeds[i].field2;
                string process2PassQuan = feeds[i].field3;
                string process3PassQuan = feeds[i].field4;
                string process4PassQuan = feeds[i].field5;
                string process5PassQuan = feeds[i].field6;

                list.Add(new PassQuan(orderQuan, process1PassQuan, process2PassQuan,
                    process3PassQuan, process4PassQuan, process5PassQuan));
            }
            return list;
        }

        //public List<Work> readThingSpeak()
        //{
        //    string url = "https://api.thingspeak.com/channels/1502554/feeds.json?api_key=WIAOVFYS6568TQK2&results=1";
        //    WebClient webClient = new WebClient();
        //    var data = webClient.DownloadString(url);
        //    dynamic feed = JsonConvert.DeserializeObject<dynamic>(data);
        //    List<dynamic> feeds = feed.feeds.ToObject<List<dynamic>>();
        //    List<LineEnvData> list = new List<LineEnvData>();

        //    Console.WriteLine("채널 정보: " + feed.channel.name);
        //    for (int i = 0; i < feeds.Count; i++)
        //    {
        //        string time = feeds[i].created_at;
        //        string temp1 = feeds[i].field1;
        //        string humi1 = feeds[i].field2;
        //        string dust1 = feeds[i].field3;
        //        string temp2 = feeds[i].field4;
        //        string humi2 = feeds[i].field5;
        //        string dust2 = feeds[i].field6;

        //        list.Add(new LineEnvData(time, temp1, humi1, dust1,
        //            temp2, humi2, dust2));
        //    }
        //    return list;
        //}
    }
    class ThingSpeakTimer
    {
        Timer timer;

        public ThingSpeakTimer(Timer timer)
        {
            this.timer = timer;
        }

        ~ThingSpeakTimer()
        {
            Console.WriteLine("타이머 소멸");
            stopTimer();
        }

        public void stopTimer()
        {
            timer.Dispose();
        }
    }
}
