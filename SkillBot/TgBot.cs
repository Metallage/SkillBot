using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;

namespace SkillBot
{
    class TgBot
    {
        private TelegramBotClient weatherBot = new TelegramBotClient("792737919:AAFie5dytPbsFDWXG2tAivZxxMhOPFyjQxk");
        
        public string GetMe()
        {
            User me = weatherBot.GetMeAsync().Result;
            return me.FirstName;
        }

    }
}
