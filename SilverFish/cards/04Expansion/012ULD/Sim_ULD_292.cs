using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    /// <summary>
    /// Oasis Surger
    /// ����ӿ����
    /// </summary>
    public class Sim_ULD_292 : SimTemplate
    {
        /// <summary>
        /// Rush Choose One - Gain +2/+2; or Summon a copy of this minion.
        /// ͻϮ���񣺻��+2/+2�����ٻ�һ������ӵĸ��ơ�
        /// </summary>
        /// <param name="p"></param>
        /// <param name="own"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (choice == 1 || (p.ownFandralStaghelm > 0 && own.own))
            {
                p.minionGetBuffed(own, 2, 2);
            }
            if (choice == 2 || (p.ownFandralStaghelm > 0 && own.own))
            {
                p.CallKid(own.handcard.card, own.zonepos, own.own);
                p.ownMinions[own.zonepos + 1].setMinionToMinion(own);
            }
        }
    }
}