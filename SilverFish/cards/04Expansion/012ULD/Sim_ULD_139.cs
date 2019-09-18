using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    /// <summary>
    /// Elise the Enlightened
    /// ����������˹
    /// </summary>
    class Sim_ULD_139 : SimTemplate
    {
        /// <summary>
        /// Battlecry: If your deck has no duplicates, duplicate your hand.
        /// ս���������ƿ���û����ͬ���ƣ�����������ơ�
        /// </summary>
        /// <param name="p"></param>
        /// <param name="own"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own && p.prozis.noDuplicates)
            {
                int ownCardsNum = p.owncards.Count;

                for (int i = 0; i < Math.Min(ownCardsNum, 10 - ownCardsNum); i++)
                {
                    p.drawACard(p.owncards[i].card.name, own.own, true);
                }
            }
        }
    }
}