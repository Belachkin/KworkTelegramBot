using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KworkTelegramBot
{
    public class Json
    {

        public static JsonTokenModel GetToken()
        {
            string json = System.IO.File.ReadAllText("config/token.json");
            JsonTokenModel jsonTokenModel = JsonConvert.DeserializeObject<JsonTokenModel>(json);
            return jsonTokenModel;
        }

        public static JsonWhiteListModel GetWhiteList()
        {
            string json = System.IO.File.ReadAllText("config/whitelist.json");
            JsonWhiteListModel jsonWhiteListModel = JsonConvert.DeserializeObject<JsonWhiteListModel>(json);
            return jsonWhiteListModel;
        }

        public static void SaveJson(string path, object jsonModel)
        {
            var json = JsonConvert.SerializeObject(jsonModel);
            System.IO.File.WriteAllText(path, json);
        }

        public static KworkJsonModel GetJsonModel(string path)
        {
            string json = System.IO.File.ReadAllText(path);
            KworkJsonModel jsonModel = JsonConvert.DeserializeObject<KworkJsonModel>(json);
            return jsonModel;
        }

        public static UserConfigModel GetUserConfig(string path)
        {
            string json = System.IO.File.ReadAllText(path);
            UserConfigModel jsonModel = JsonConvert.DeserializeObject<UserConfigModel>(json);
            return jsonModel;
        }
    }

    public class JsonTokenModel
    {
        public string token { get; set; }
    }


    public class JsonWhiteListModel
    {
        public int[] chatId { get; set; }
    }

    public class UserConfigModel
    {
        public User[] users { get; set; }
        
        public class User
        {
            public int chatId { get; set; }
            public bool category_disign { get; set; }
            public bool category_it { get; set; }
            public bool category_text { get; set; }
            public bool category_seo { get; set; }
            public bool category_audion_video { get; set; }
            public bool category_business { get; set; }
        }

    }



}
