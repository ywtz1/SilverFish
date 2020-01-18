using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_010 : SimTemplate //* 托瓦格尔的阴谋
	{
		//
		
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target == null) p.minionAddToDeck(target, target.own, 1);
        }

	}
}