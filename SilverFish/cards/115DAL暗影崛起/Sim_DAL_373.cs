using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_373 : SimTemplate //* 
	{

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.drawACard(CardDB.cardIDEnum.DAL_373ts, ownplay,true);
            if (target != null)
            {
                int dmg = (ownplay) ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
                p.minionGetDamageOrHeal(target, dmg);
            }
		}
	}
}