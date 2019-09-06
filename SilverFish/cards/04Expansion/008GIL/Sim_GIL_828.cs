using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_828 : SimTemplate //* 凶猛狂暴
	{
        //Recruit 3 minions that cost (2) or less.



		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.minionGetBuffed(target, 3, 3);
            p.minionAddToDeck(target,ownplay,3);
            p.evaluatePenality-=2;
            if(target.charge!=0)p.evaluatePenality-=5;
            else if(target.rush>0)p.evaluatePenality-=4;
            if(target.handcard.card.lifesteal)p.evaluatePenality-=2;


		}

	}
}