using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    /// <summary>
    /// Reno the Relicologist
    /// ����ר����ŵ
    /// </summary>
    public class Sim_ULD_238 : SimTemplate
    {
        /// <summary>
        /// Battlecry: If your deck has no duplicates, deal 10 damage randomly split among all enemy minions.
        /// ս���������ƿ���û����ͬ���ƣ������10���˺���������䵽���ез�������ϡ�
        /// </summary>
        /// <param name="p"></param>
        /// <param name="own"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own && p.prozis.noDuplicates)
            {
                for (int i = 0; i < 10; i++)
                {
                    target = p.getEnemyCharTargetForRandomSingleDamage(1, true);
                    p.minionGetDamageOrHeal(target, 1);
                }
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    target = p.searchRandomMinion(p.ownMinions, searchmode.searchHighestAttack);
                    p.minionGetDamageOrHeal(target, 1);
                }
            }
        }
    }
}