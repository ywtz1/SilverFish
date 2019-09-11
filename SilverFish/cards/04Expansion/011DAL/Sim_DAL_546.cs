using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DAL_546: SimTemplate //咖啡师
    {


        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if(own.own)
            {
                foreach (Minion m in p.ownMinions)
                {
                    if(target.handcard.card.battlecry)p.drawACard(target.handcard.card.name, ownplay, true);
                }           
            }
        }
    }
}