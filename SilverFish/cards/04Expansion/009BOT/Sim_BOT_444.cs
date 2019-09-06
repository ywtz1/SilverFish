using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_444 : SimTemplate //生物计划

	{

//    erhaltet einen leeren manakristall.
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int n=p.ownMinionsDiedTurn+p.enemyMinionsDiedTurn;
            if(ownplay)

                if (p.ownMaxMana < 10)
                {
                    p.ownMaxMana+=n;
                }
            else
                if (p.enemyMaxMana < 10)
                {
                    p.enemyMaxMana+= n;
                }

            
		}

	}
}