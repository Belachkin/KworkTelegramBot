using System;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace KworkTelegramBot 
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new TelegramBotClient("");

            client.StartReceiving(Update, Error);


            Console.ReadLine();
        }

        private async static Task Update(ITelegramBotClient botClient, Update update, CancellationToken token)
        {
            var message = update.Message;
            if (message.Text != null)
            {
                Console.WriteLine($"{message.Chat.Id} | {message.Text}");
                if (message.Text.ToLower().Contains("здорова"))
                {
                  await botClient.SendTextMessageAsync(message.Chat.Id, "Здоровей видали!");
                  return;
                }   
            }
            if(message.Photo != null)
            {
                Console.WriteLine($"{message.Chat.Id} | Send Photo");
                await botClient.SendTextMessageAsync(message.Chat.Id, "Круто, но отправь фотку документом пожалуйста");
                return;
            }
            if (message.Photo != null)
            {
                
                await botClient.SendTextMessageAsync(message.Chat.Id, "Ща, погодь, сделаю лучше..");
                return;
            }
        }

        private static Task Error(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
        {
            throw new NotImplementedException();
        }
    }
}