using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_351e : SimTemplate //* 远古的祝福
	{
        //使你的所有随从获得+1/+1.

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.allMinionOfASideGetBuffed(ownplay, 1, 1);              
        }
	}
}