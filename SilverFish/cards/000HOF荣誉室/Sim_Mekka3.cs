using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_Mekka3 : SimTemplate //emboldener3000
	{

//    verleiht am ende eures zuges einem zufälligen diener +1/+1.

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                Minion tm = null;
                int ges = 1000;
                foreach (Minion m in p.ownMinions)
                {
                    if (m.Attack + m.Hp < ges)
                    {
                        tm = m;
                        ges = m.Attack + m.Hp;
                    }
                }
                foreach (Minion m in p.enemyMinions)
                {
                    if (m.Attack + m.Hp < ges)
                    {
                        tm = m;
                        ges = m.Attack + m.Hp;
                    }
                }
                if (ges <= 999)
                {
                    p.minionGetBuffed(tm, 1, 1);
                }
            }
        }

	}
}