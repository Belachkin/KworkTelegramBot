using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KworkTelegramBot
{
    public class WantsModel
    {
        public WantsModel
            (
            int _idPoject,
            string _name,
            string _description,
            string _url,
            string _priceLimit,
            int _possiblePrice,
            string _timeLeft,
            string _kworkCount,
            bool _isMatch
            )
        {
            IdProject = _idPoject;
            Name = _name;
            Description = _description;
            Url = _url;
            priceLimit = _priceLimit;
            possiblePrice = _possiblePrice;
            timeLeft = _timeLeft;
            kworkCount = _kworkCount;
            isMatch = _isMatch;
        }
        public WantsModel
            (
            int _idPoject,
            string _name,
            string _description,
            string _url,
            string _priceLimit,
            int _possiblePrice,
            string _timeLeft,
            string _kworkCount
            
            )
        {
            IdProject = _idPoject;
            Name = _name;
            Description = _description;
            Url = _url;
            priceLimit = _priceLimit;
            possiblePrice = _possiblePrice;
            timeLeft = _timeLeft;
            kworkCount = _kworkCount;
            
        }
        public WantsModel()
        {

        }

        public int IdProject { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string priceLimit { get; set; }
        public int possiblePrice { get; set; }
        public string timeLeft { get; set; }
        public string kworkCount { get; set; }
        public bool? isMatch { get; set; }
    }
}
