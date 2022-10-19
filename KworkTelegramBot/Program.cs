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
        public static Timer timer;
        public static KworkJsonModel json;
        public static List<WantsModel> resultModel;
        public static string url;
        public static UserConfigModel userConfig;
        static void Main(string[] args)
        {
            try
            {
                
                GetLogo();
                token = Json.GetToken();
                WriteColor("Таймер в минутах: ", ConsoleColor.Blue);
                int min = Convert.ToInt32(ReadLine());
                timer = new Timer((1000 * 60) * min);

                WriteColor("url: ", ConsoleColor.Blue);
                url = ReadLine();

                userConfig = Json.GetUserConfig("config/user_config.json");

                json = KworkParsing.GetKworkProjectsJson(url);
                Json.SaveJson("last_projects.json", json);

                timer.Elapsed += Timer_Elapsed;
                timer.Enabled = true;
                timer.AutoReset = true;
                timer.Start();

                WriteLineColor("Таймер запущен", ConsoleColor.Green);

                var client = new TelegramBotClient(token.token.ToString());
                client.StartReceiving(Update, Error);

                ReadLine();
            }
            catch(Exception ex)
            {
                WriteLineColor(ex.Message, ConsoleColor.Red);
            }
            
        }



        private static async void Timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            try
            {
                DateTime now = DateTime.Now;
                WriteLine($"Ивент сработал | T: {now:T}");

                
                whiteList = Json.GetWhiteList();

                var client = new TelegramBotClient(token.token.ToString());

                json = KworkParsing.GetKworkProjectsJson(url);
                var json2 = Json.GetJsonModel("last_projects.json");

                resultModel = new List<WantsModel>();

                foreach (var model in json2.data.wants)
                {
                    resultModel.Add(new WantsModel(
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

                foreach (var lastModel in json.data.wants)
                {
                    foreach (var firstModel in resultModel)
                    {
                        if (lastModel.id == firstModel.IdProject)
                        {
                            firstModel.isMatch = true;
                        }
                    }
                }

                foreach (var model in resultModel)
                {
                    if (model.isMatch != true)
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
            catch (Exception ex)
            {
                WriteLineColor(ex.Message, ConsoleColor.Red);
            }               
        }

        private static async Task Update(ITelegramBotClient botClient, Update update, CancellationToken token)
        {
            var message = update.Message;
            ReplyKeyboardMarkup replyKeyboardMarkup = new(new[]
            {
                new KeyboardButton[] { Config.MarkupButton.Design, Config.MarkupButton.IT, Config.MarkupButton.Text },
                new KeyboardButton[] { Config.MarkupButton.SEO, Config.MarkupButton.AudioVideo, Config.MarkupButton.Business },
                new KeyboardButton[] { Config.MarkupButton.Save }
            })
            {
                ResizeKeyboard = true
            };

            if(message.Text == "/start")
            {
                await botClient.SendTextMessageAsync(
                chatId: message.Chat.Id,
                text: "Привет, я *BelachkinCloudBot* 🤖 \n\nПомогу тебе быстро получать уведомления о новых проектах на бирже *kwork* \nВыбери категорию, и давай начнем",
                replyMarkup: replyKeyboardMarkup,
                parseMode: ParseMode.MarkdownV2
                );

                if (!userConfig.users.Any(x => x.chatId == message.Chat.Id))
                {
                    UserConfigModel.User newUser = new UserConfigModel.User(chatId: message.Chat.Id);                    
                }
                else
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Найдено совпадение в списке пользователей!");
                }

                


                //UserConfigModel.User newUser = new UserConfigModel.User();
                //newUser.chatId = message.Chat.Id;
            }

                               
        }

        private static async Task Error(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
        {
            WriteLineColor($"Error: {arg2.Message}\n{arg2.InnerException}\n{arg2.Source}\n{arg2.HelpLink}", ConsoleColor.Red);
        }

        private static void GetLogo()
        {
            WriteLineColor("█░█ █░░░█ ▄▀▀▄ █▀▄ █░█ . ▀█▀ █▀▀ █░░ █▀▀ ▄▀▀ █▀▄ ▄▀▄ ██▄██ . █▀▄ ▄▀▀▄ ▀█▀", ConsoleColor.Blue);
            WriteLineColor("█▀▄ █▄█▄█ █░░█ █▀▄ █▀▄ . ░█░ █▀▀ █░░ █▀▀ █░█ █▀▄ █▄█ █░▀░█ . █▀▄ █░░█ ░█░", ConsoleColor.Blue);
            WriteLineColor("▀░▀ ▀▀░▀▀ ░▀▀░ ▀░▀ ▀░▀ . ░▀░ ▀▀▀ ▀▀▀ ▀▀▀ ░▀▀ ▀░▀ ▀░▀ ▀░░░▀ . ▀▀░ ░▀▀░ ░▀░\n\n\n", ConsoleColor.Blue);

        }
    }
}