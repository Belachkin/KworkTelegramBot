using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KworkTelegramBot
{
    internal class Config
    {
        public class Category
        {
            public const string DesignUrl = "https://kwork.ru/projects?c=15";
            public const string ItUrl = "https://kwork.ru/projects?c=11";
            public const string SeoUrl = "https://kwork.ru/projects?c=17";
            public const string TextUrl = "https://kwork.ru/projects?c=5";
            public const string AudioVideoUrl = "https://kwork.ru/projects?c=7";
            public const string BusinessUrl = "https://kwork.ru/projects?c=83";
//TODO: Add AdsUrl
        }

        public class MarkupButton
        {
            public const string Design = "Дизайн 🖌";
            public const string IT = "Разработка и IT 👨‍💻";
            public const string SEO = "SEO и трафик 📈";
            public const string Text = "Тексты и переводы 📝";
            public const string AudioVideo = "Аудио, видео, съемка 🎵📸";
            public const string Business = "Бизнес и жизнь 💰";

            public const string Save = "Сохранить и начать 💾";
        }
    }
}
