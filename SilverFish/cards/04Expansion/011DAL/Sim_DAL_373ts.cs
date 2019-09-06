using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_373ts : SimTemplate //*  衍生卡
	{


		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (target != null)
            {
                int dmg = (ownplay) ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
                p.minionGetDamageOrHeal(target, dmg);
            }
		}
	}
}