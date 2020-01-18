using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_537 : SimTemplate //* 
	{
		//亡语：</b>召唤一个8/8的机械暴龙
		        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BOT_537t); 

        public override void onDeathrattle(Playfield p, Minion m)
        {
          int pos = (m.own) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(kid, pos, m.own, false);
        }
    }
}