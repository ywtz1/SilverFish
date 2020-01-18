using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    /// <summary>
    /// Riftcleaver
    /// ��϶���� 
    /// </summary>
    public class Sim_ULD_165 : SimTemplate
    {
        /// <summary>
        /// Battlecry: Destroy a minion. Your hero takes damage equal to its Health.
        /// ս������һ����ӡ����Ӣ���ܵ���ͬ�ڸ��������ֵ���˺���
        /// </summary>
        /// <param name="p"></param>
        /// <param name="own"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null)
            {
                p.minionGetDamageOrHeal(own.own ? p.ownHero : p.enemyHero, target.Hp);
                p.minionGetDestroyed(target);
            }
        }
    }
}