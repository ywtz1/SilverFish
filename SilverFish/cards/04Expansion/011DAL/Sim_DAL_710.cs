using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_710 : SimTemplate //* Flame Lance
	{
		//使你的所有随从获得“亡语：召唤一个1/1的鱼人.
		
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;

            foreach (Minion m in temp)
            {
                m.souloftheforest++;
                p.evaluatePenality-=4;
            }
            if(p.ownMinions.Count>3)p.evaluatePenality-=10;
        }
	}
}