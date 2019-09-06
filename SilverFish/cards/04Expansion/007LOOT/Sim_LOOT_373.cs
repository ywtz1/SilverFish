using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_373 : SimTemplate//静电震击对一个随从造成$2点伤害。<b>过载：</b>（1）</Tag>
    {


        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
            int i=12;
            
            for(;;)
            {
                foreach (Minion m in temp) 
                {
                    if(i==0)return;
                    if(m.HealthPoints==m.maxHp) continue;
                    p.minionGetDamageOrHeal(m, -1);
                    i--;
                    
                }
                if(i==0)return;
                p.minionGetDamageOrHeal(ownplay ? p.ownHero:p.enemyHero, -1);
                i--;
            }

        }

    }
}
