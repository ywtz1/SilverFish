using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_512 : SimTemplate //Cheaty Anklebiter
	{

         //  Lifesteal
		 //  Battlecry: Deal 1 damage.
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            int dmg = 1;
            p.minionGetDamageOrHeal(target, dmg);
		}


	}
}