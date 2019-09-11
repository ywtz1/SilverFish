using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_245 : SimTemplate //风暴聚合器
	{

//    战吼：造成2点伤害
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if(ownplay)
			{
	            foreach (Minion m in p.ownMinions)
	            {
	            	p.minionTransform(m, p.getRandomCardForManaMinion(6));
	            }			
	        }

		}


	}
}