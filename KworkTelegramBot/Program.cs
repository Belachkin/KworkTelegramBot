using System;
using System.Threading;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using System.Timers;
using Timer = System.Timers.Timer;
using Newtonsoft.Json.Linq;
using System.Reflection;
using Telegram.Bot.Types.Enums;
using static KworkTelegramBot.ColorConsole;
using static System.Console;

namespace KworkTelegramBot 
{
    class Program
    {
        public static JsonWhiteListModel whiteList;
        public static JsonTokenModel token;
        public static Timer timer = new Timer((1000 * 60) * 15);
        public static KworkJsonModel json;
        public static List<DbModel> resultModel;
        public static string url;
        static  void Main(string[] args)
        {
            GetLogo();
            
            json = KworkParsing.GetKworkProjectsJson("https://kwork.ru/projects");            
            Json.SaveJson("last_projects.json", json);

            timer.Elapsed += Timer_Elapsed2;
            timer.Enabled = true;
            timer.AutoReset = true;
            timer.Start();

            WriteLine("Таймер запущен");

            ReadLine();
        }

        private static async void Timer_Elapsed2(object? sender, ElapsedEventArgs e)
        {
            DateTime now = DateTime.Now;           
            WriteLine($"Ивент сработал | T: {now:T}");


            token = Json.GetToken();
            whiteList = Json.GetWhiteList();

            var client = new TelegramBotClient(token.token.ToString());

            json = KworkParsing.GetKworkProjectsJson(url);
            var json2 = Json.GetJsonModel("last_projects.json");

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
                    WriteLine($"Бот отправил новый пост: id {model.IdProject} | {model.Name}");
                    await client.SendTextMessageAsync(whiteList.chatId[0],
                        $"*{model.Name}* \n Желаемый бюджет: до  *{model.priceLimit}₽* \nДопустимый: до *{model.possiblePrice}₽* \nhttps://kwork.ru/{model.Url}/view\n{model.Description}"
                        , parseMode: ParseMode.Markdown
                        );
                }        
            }

            Json.SaveJson("resultModel.json", resultModel);
            Json.SaveJson("last_projects.json", json);            
        }

        private static Task Error(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
        {
            throw new NotImplementedException();
        }

        private static void GetLogo()
        {
            WriteLineColor("█░█ █░░░█ ▄▀▀▄ █▀▄ █░█ . ▀█▀ █▀▀ █░░ █▀▀ ▄▀▀ █▀▄ ▄▀▄ ██▄██ . █▀▄ ▄▀▀▄ ▀█▀", ConsoleColor.Yellow);
            WriteLineColor("█▀▄ █▄█▄█ █░░█ █▀▄ █▀▄ . ░█░ █▀▀ █░░ █▀▀ █░█ █▀▄ █▄█ █░▀░█ . █▀▄ █░░█ ░█░", ConsoleColor.Yellow);
            WriteLineColor("▀░▀ ▀▀░▀▀ ░▀▀░ ▀░▀ ▀░▀ . ░▀░ ▀▀▀ ▀▀▀ ▀▀▀ ░▀▀ ▀░▀ ▀░▀ ▀░░░▀ . ▀▀░ ░▀▀░ ░▀░\n\n\n", ConsoleColor.Yellow);

        }
    }
}