using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_023  : SimTemplate
	{
		public override void onMinionIsSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
        {
            if ((TAG_RACE)summonedMinion.handcard.card.race == TAG_RACE.PIRATE && triggerEffectMinion.own == summonedMinion.own)
            {
                Minion target = null;

                if (triggerEffectMinion.own)
                {
                    target = p.getEnemyCharTargetForRandomSingleDamage(2);
                }
                else
                {
                    target = p.searchRandomMinion(p.ownMinions, searchmode.searchHighestAttack); //damage the Highest (pessimistic)
                    if (target == null) target = p.ownHero;
                }
                p.minionGetDamageOrHeal(target, 2, true);
            }
        }
	}
}