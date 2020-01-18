using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    /// <summary>
    /// WANTED!
    /// ͨ����
    /// </summary>
	class Sim_GIL_687 : SimTemplate 
	{
        /// <summary>
        /// Deal $3 damage to a minion. If that kills it, add a Coin to your hand.
        /// ��һ��������$3���˺��������ͨ���ɱ������ӣ���һ�����˱�����������ơ�
        /// </summary>
        /// <param name="p"></param>
        /// <param name="ownplay"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
            if (dmg >= target.Hp && !target.divineshild && !target.immune)
            {
                //this.owncarddraw++;
                p.drawACard(CardDB.cardName.thecoin, ownplay);
            }
            p.minionGetDamageOrHeal(target, dmg);
        }
    }
}