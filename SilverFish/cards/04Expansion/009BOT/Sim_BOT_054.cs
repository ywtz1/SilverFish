using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_054 : SimTemplate //生物计划

	{

//    erhaltet einen leeren manakristall.
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{

                if (p.ownMaxMana < 10)
                {
                    p.ownMaxMana+=2;
                }



                if (p.enemyMaxMana < 10)
                {
                    p.enemyMaxMana+=2;
                }

            
		}

	}
}