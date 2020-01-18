using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GIL_504h: SimTemplate //
    {
//在你使用一张随从牌后，随机将一张萨满法术牌置入你的手牌


        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetDamageOrHeal(p.ownHero, 5);
        }
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool ownplay, Handmanager.Handcard triggerhc)
        {
           if (hc.card.type == CardDB.cardtype.MOB)p.drawACard(CardDB.cardName.unknown,ownplay,true);
            
        }
    }
}