using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_317 : SimTemplate //* Elemental Destruction
	{
		//Deal 2 damage to all minions.

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
            //p.allMinionsGetDamage(dmg);
            foreach (Minion m in p.ownMinions)
            {
                if (m.entitiyID != -1) 
                {
                	p.minionGetDamageOrHeal(m, dmg, true);
                	if(m.Hp <0)	p.drawACard (CardDB.cardName.unknown,ownplay,true);

                }

            }
            foreach (Minion m in p.enemyMinions)
            {
                if (m.entitiyID != -1) 
                {
                	p.minionGetDamageOrHeal(m, dmg, true);
                	if(m.Hp <0)	p.drawACard (CardDB.cardName.unknown,ownplay,true);

                }            
            }

		}
	}
}