using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_350a : SimTemplate //* ���̾���
	{
        //��һ��������2���˺���

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			
			
				int dmg = (ownplay) ? p.getSpellDamageDamage (2) : p.getEnemySpellDamageDamage (2);
				p.minionGetDamageOrHeal(target, dmg);

			


           
		}
	}
}