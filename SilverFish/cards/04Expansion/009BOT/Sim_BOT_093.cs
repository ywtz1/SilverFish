using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_BOT_093 : SimTemplate//元素反应
    {


        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard (CardDB.cardName.unknown,ownplay,false);

            
            
        }

    }
}
