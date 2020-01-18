using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_043t3 : SimTemplate 
	{

		

		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			
			int dmg = (ownplay) ? p.getSpellDamageDamage(7) : p.getEnemySpellDamageDamage(7);
            p.minionGetDamageOrHeal(ownplay ? p.ownHero : p.enemyHero, -dmg);

            p.minionGetDamageOrHeal(target, dmg);

		}




	}
}