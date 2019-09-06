using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_654 : SimTemplate //战路
	{
		//回响，对所有随从造成1点伤害。
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
            p.drawACard(CardDB.cardName.warpath, ownplay);
			p.allMinionsGetDamage(dmg);
			p.evaluatePenality += 10;
		}
	}
}