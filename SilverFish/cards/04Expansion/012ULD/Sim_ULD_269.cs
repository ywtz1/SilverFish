using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    /// <summary>
    /// Wretched Reclaimer
    /// ���ӵĻ�����
    /// </summary>
    public class Sim_ULD_269 : SimTemplate
    {
        /// <summary>
        /// Battlecry: Destroy a friendly minion, then return it to life with full Health.
        /// ս������һ���ѷ���ӣ�Ȼ���临���������������ֵ��
        /// </summary>
        /// <param name="p"></param>
        /// <param name="own"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null)
            {
                bool minionOwn = target.own;
                int minionPos = target.zonepos;
                CardDB.Card c = target.handcard.card;
                p.minionGetDestroyed(target);
                p.CallKid(c, minionPos, minionOwn);
            }
        }
    }
}