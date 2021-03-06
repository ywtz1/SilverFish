using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    /// <summary>
    /// Improve Morale
    /// 提振士气
    /// </summary>
	class Sim_DAL_769 : SimTemplate 
	{
        /// <summary>
        /// Deal 1 damage to a minion. If it survives, add a Lackey to your hand.
        /// 对一个随从造成1点伤害。如果它依然存活，则将一张跟班牌置入你的手牌。
        /// </summary>
        /// <param name="p"></param>
        /// <param name="ownplay"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int damage = ownplay ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
            p.minionGetDamageOrHeal(target, damage);
            if (target.Hp >= 1)
            {
                p.drawACard(CardDB.cardIDEnum.DAL_615, ownplay, true);
            }
        }
	}
}