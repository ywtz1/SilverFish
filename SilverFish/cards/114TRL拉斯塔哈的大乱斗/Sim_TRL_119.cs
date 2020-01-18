using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_119 : SimTemplate //* 凶猛狂暴
	{
        //Recruit 3 minions that cost (2) or less.



		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
                        if(target==null)return;

            p.minionGetBuffed(target, 1, 1);
            Minion aa = (ownplay) ? p.searchRandomMinion(p.enemyMinions,searchmode.searchLowestHP) : p.searchRandomMinion(p.ownMinions,searchmode.searchHighestAttack);
            p.minionAttacksMinion(target,aa,true);




		}

	}
}