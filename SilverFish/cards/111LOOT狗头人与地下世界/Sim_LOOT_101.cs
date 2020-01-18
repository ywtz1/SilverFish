using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_101 : SimTemplate //Explosive Runes
	{
        //Secret: After your opponent plays a minion, deal $6 damage to it and any excess to their hero.
		
        public override void onSecretPlay(Playfield p, bool ownplay, Minion target, int number)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(6) : p.getEnemySpellDamageDamage(6);

            p.minionGetDamageOrHeal(target, dmg);
        }

	}

}
