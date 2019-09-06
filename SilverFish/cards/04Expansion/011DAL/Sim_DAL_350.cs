using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_350 : SimTemplate //* ˮ��֮��
	{
        //���񣺶�һ��������2���˺������߻ָ�5������ֵ��

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			
			if (choice == 1 || (p.ownFandralStaghelm > 0 && ownplay))
			{
				int dmg = (ownplay) ? p.getSpellDamageDamage (2) : p.getEnemySpellDamageDamage (2);
				p.minionGetDamageOrHeal(target, dmg);

			}
			if (choice == 2 || (p.ownFandralStaghelm > 0 && ownplay))
			{
				int heal = (ownplay) ? p.getSpellHeal (5) : p.getEnemySpellHeal (5);
				p.minionGetDamageOrHeal(target, -heal);
			}



           
		}
	}
}