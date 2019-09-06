using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_437 : SimTemplate //* 凶猛狂暴
	{
        //Recruit 3 minions that cost (2) or less.



		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if(target==null)return;
            p.minionGetBuffed(target, 3, 3);
            p.minionGetRush(target);
            if (ownplay)
            {
                target.destroyOnOwnTurnEnd = true;
            }
            else
            {
                target.destroyOnEnemyTurnEnd = true;
            }
            

		}

	}
}