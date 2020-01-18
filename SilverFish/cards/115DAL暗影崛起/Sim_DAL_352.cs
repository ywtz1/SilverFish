using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DAL_352 : SimTemplate //* 晶歌传送门
	{



        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardName.unknown, ownplay , true);
            bool a=false;
            if (ownplay)
            {
                foreach(Handmanager.Handcard hc in p.owncards)
                {
                    if(hc.card.type == CardDB.cardtype.MOB)
                    {
                        a=true;
                        break;
                    }
                }
                if(!a)
                {
                    p.drawACard(CardDB.cardName.unknown, ownplay , true);
                    p.drawACard(CardDB.cardName.unknown, ownplay , true);
                }
            }
        }
	}
}