using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    /// <summary>
    /// Improve Morale
    /// ����ʿ��
    /// </summary>
	class Sim_DAL_769 : SimTemplate 
	{
        /// <summary>
        /// Deal 1 damage to a minion. If it survives, add a Lackey to your hand.
        /// ��һ��������1���˺����������Ȼ����һ�Ÿ���������������ơ�
        /// </summary>
        /// <param name="p"></param>
        /// <param name="ownplay"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int damage = ownplay ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
            p.minionGetDamageOrHeal(target, damage);
            if (target.HealthPoints >= 1)
            {
                p.drawACard(CardDB.cardIDEnum.DAL_615, ownplay, true);
            }
        }
	}
}