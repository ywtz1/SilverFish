using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_371 : SimTemplate //* Flame Lance
	{
		//Deal 8 damage to a minion.
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if(target != null)
			{
				int dmg = (ownplay) ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);
            	p.minionGetDamageOrHeal(target, dmg);
				p.drawACard(CardDB.cardName.unknown, ownplay,true);
			}
            
		}
	}
}