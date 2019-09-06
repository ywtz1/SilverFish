using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_589 : SimTemplate //* 凶猛狂暴
	{
        //Recruit 3 minions that cost (2) or less.



		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
                        if (ownplay)
            {
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if ((TAG_RACE)hc.card.race == TAG_RACE.PET)
                    p.drawACard(hc.card.cardIDenum, ownplay,true);
                }
            }



		}

	}
}