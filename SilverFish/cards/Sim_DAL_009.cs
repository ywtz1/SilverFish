using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_009  : SimTemplate
	{
		int d=0;

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int dmg = (ownplay) ? p.getSpellDamageDamage(d+1) : p.getEnemySpellDamageDamage(d+1);
			p.allMinionOfASideGetDamage(true,dmg);
			p.allMinionOfASideGetDamage(false,dmg);
		}
	    public  override void inhand(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Handmanager.Handcard triggerhc)
        {
            d=triggerhc.shenji;
        }

	}
}
