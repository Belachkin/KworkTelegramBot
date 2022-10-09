using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KworkTelegramBot
{
    public class KworkParsing
    {
        public static KworkJsonModel GetKworkProjectsJson(string url)
        {
            using (var client = new HttpClient())
            {
                using (var request = new HttpRequestMessage(HttpMethod.Post, url))
                {
                    string boundary = DateTime.Now.Ticks.ToString("x");

                    Dictionary<string, string> headers = new Dictionary<string, string>
                    {
                        {"Host", "kwork.ru"},
                        {"Accept-Encoding", "gzip, deflate, br"},
                        {"Origin", "https://kwork.ru"},
                        {"Connection", "keep-alive"},
                        {"Referer", "https://kwork.ru/projects"},
                        {"Cookie", "_kmid=67be4542c64049fee70dade8beb68934; _kmfvt=1665064604; site_version=desktop; RORSSQIHEK=245b72cb8ab193ee146c48cfa04b83a3; referrer_url=https%3A%2F%2Fkwork.ru%2Fprojects; isFacebookAvailable=false; _gcl_au=1.1.787892970.1665064606; _ym_uid=1665064607928676043; _ym_d=1665064607; yandex_client_id=1665064607928676043; _ga=GA1.2.145756961.1665064607; _gid=GA1.2.11868369.1665064607; _ubtcuid=cl8xjr4eg00002ad2t7oxz8r5; google_client_id=145756961.1665064607; _sp_id.b695=5f52adb8-34fb-41cf-b8cd-7a5fb4a434cc.1665064607.2.1665090469.1665071781.6d0399c5-d6a6-463b-a1bc-6f7bcdbe8229; _ym_isad=2; _sp_ses.b695=*"},
                        {"Sec-Fetch-Dest", "empty"},
                        {"Sec-Fetch-Mode", "cors"},
                        {"Sec-Fetch-Site", "same-origin"},
                        {"User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:105.0) Gecko/20100101 Firefox/105.0"},
                        {"Accept", "application/json, text/plain, */*"},
                        {"Accept-Language", "ru-RU,ru;q=0.8,en-US;q=0.5,en;q=0.3"},
                        {"X-Requested-With", "XMLHttpRequest"},
                        {"Content-Type", "multipart/form-data;  boundary=---------------------------" + boundary + "--"},
                    };

                    var content = new FormUrlEncodedContent(headers);
                    var uri = new Uri(url);

                    using (var resp = client.PostAsync(uri, content).Result)
                    {
                        if (resp.IsSuccessStatusCode)
                        {
                            var json = resp.Content.ReadAsStringAsync().Result;
                            if (!string.IsNullOrEmpty(json))
                            {
                                KworkJsonModel result = JsonConvert.DeserializeObject<KworkJsonModel>(json);
                                return result;
                            }
                        }
                        return null;
                    }
                }
            }
        }
    }
}
