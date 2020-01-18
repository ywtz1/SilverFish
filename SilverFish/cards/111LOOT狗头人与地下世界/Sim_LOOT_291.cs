using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_291 : SimTemplate //蘑菇酿酒师</Tag>
 // <Tag enumID="184" type="String"><b>战吼：</b>恢复#4点生命值。</Tag>

	{
 
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            int heal = (own.own) ? p.getMinionHeal(4) : p.getEnemyMinionHeal(4);
            p.minionGetDamageOrHeal(target, -heal);
		}
	}
}