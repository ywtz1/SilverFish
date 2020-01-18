using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_059 : SimTemplate //* gurubashiberserker
	{
    // Whenever this minion takes damage, gain +3 Attack.

        public override void onMinionGotDmgTrigger(Playfield p, Minion m, int anzOwnMinionsGotDmg, int anzEnemyMinionsGotDmg, int anzOwnHeroGotDmg, int anzEnemyHeroGotDmg)
        {
            if (m.anzGotDmg > 0)
            {
                int tmp = m.anzGotDmg;
                m.anzGotDmg = 0;
                for (int i = 0; i < tmp; i++)
                {
					if (m.own) p.ownHero.armor += 2;
                    else p.enemyHero.armor += 2;
                }
            }
        }
	}
}