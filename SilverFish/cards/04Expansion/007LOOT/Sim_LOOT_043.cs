using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_043 : SimTemplate 
	{

		

		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
            p.minionGetDamageOrHeal(ownplay ? p.ownHero : p.enemyHero, -dmg);

            p.minionGetDamageOrHeal(target, dmg);




		


		}
		/*public  override void inhand(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Handmanager.Handcard triggerhc)
		{
			int n=p.damagebyown;
			if(p.damagebyown-n >=4)
			{
				p.drawACard(CardDB.cardName.法术紫水晶, wasOwnCard, true);
                        p.removeCard(triggerhc);
			}

		}*/





	}
}