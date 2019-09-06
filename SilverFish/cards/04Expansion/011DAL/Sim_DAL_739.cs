using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DAL_739: SimTemplate //* Acherus Veteran
    {
        // 战吼：使一个友方随从获得+1攻击力和突袭。

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			         if(target == null) return;
			         if(!target.Ready) p.evaluatePenality -= 4;
			         if(target.Attack==0)p.evaluatePenality -= 6;
			         target.Attack++;
			         p.minionGetRush(target);

            
		}
	}
}