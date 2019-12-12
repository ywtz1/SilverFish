using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_615 : SimTemplate //* Flame Lance
	{
		//将一个友方随从变形成为一个法力值消耗增加（1）点的随从。
		
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
         if(target == null) return;
         //if(target.Ready)p.evaluatePenality += 10;
         p.minionTransform(target, p.getRandomCardForManaMinion(target.handcard.card.cost + 1));
		}
	}
}