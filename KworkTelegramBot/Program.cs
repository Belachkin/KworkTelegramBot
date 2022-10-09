using System;
using System.Threading;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using System.Timers;
using Timer = System.Timers.Timer;
using Newtonsoft.Json.Linq;
using System.Reflection;

namespace KworkTelegramBot 
{
    class Program
    {
        public static JsonWhiteListModel whiteList;
        public static JsonTokenModel token;
        public static Timer timer = new Timer((1000 * 60) * 15);
        public static KworkJsonModel json;
        public static List<DbModel> resultModel;
        
        static void Main(string[] args)
        {
                        
            json = KworkParsing.GetKworkProjectsJson("https://kwork.ru/projects");
            GetJson.SaveJson("json1.json", json);
            GetJson.SaveJson("json2.json", json);

            timer.Elapsed += Timer_Elapsed2;
            timer.Enabled = true;
            timer.AutoReset = true;
            timer.Start();

            Console.WriteLine("Таймер запущен");

            Console.ReadLine();
        }

        private static async void Timer_Elapsed2(object? sender, ElapsedEventArgs e)
        {
            DateTime now = DateTime.Now;           
            Console.WriteLine($"Ивент сработал | T: {now:T}");


            token = GetJson.GetToken();
            whiteList = GetJson.GetWhiteList();

            var client = new TelegramBotClient(token.token.ToString());

            json = KworkParsing.GetKworkProjectsJson("https://kwork.ru/projects");
            var json2 = GetJson.GetJsonModel("json2.json");

            resultModel = new List<DbModel>();

            foreach(var model in json2.data.wants)
            {
                resultModel.Add(new DbModel(
                    model.id,
                    model.name,
                    model.description,
                    model.url,
                    model.priceLimit,
                    model.possiblePriceLimit,
                    model.timeLeft,
                    model.kworkCount                          
                    ));
            }

            foreach (var model1 in json.data.wants)
            {
                foreach (var model2 in resultModel)
                {
                    if(model1.id == model2.IdProject)
                    {
                        model2.isMatch = true;
                    }
                }
            }

            foreach(var model in resultModel)
            {
                if(model.isMatch != true)
                {
                    Console.WriteLine($"Бот отправил новый пост: id {model.IdProject} | {model.Name}");
                    await client.SendTextMessageAsync(whiteList.chatId[0],
                        $"**{model.Name}**\n{model.Description}\n https://kwork.ru/{model.Url}/view \nЖелаемый бюджет: до **{model.priceLimit}₽**\nДопустимый: до **{model.possiblePrice}₽**"
                        );
                }        
            }

            GetJson.SaveJson("resultModel.json", resultModel);
            GetJson.SaveJson("json2.json", json);
            
        }

        private static Task Error(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
        {
            throw new NotImplementedException();
        }
    }
}