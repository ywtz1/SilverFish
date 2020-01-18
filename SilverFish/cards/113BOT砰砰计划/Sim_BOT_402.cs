using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_402 : SimTemplate //* 凶猛狂暴
	{
        //Recruit 3 minions that cost (2) or less.



		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.drawACard(CardDB.cardName.unknown, ownplay, true);


		}

	}
}