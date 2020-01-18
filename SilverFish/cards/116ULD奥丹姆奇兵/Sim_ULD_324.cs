using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    /// <summary>
    /// Impbalming
    /// С���͸�
    /// </summary>
    public class Sim_ULD_324 : SimTemplate
    {
        /// <summary>
        /// Destroy a minion. Shuffle 3 Worthless Imps into your deck.
        /// ����һ����ӡ������š��ε�С��ϴ������ƿ⡣
        /// </summary>
        /// <param name="p"></param>
        /// <param name="ownplay"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetDestroyed(target);
            if (ownplay)
            {
                p.ownDeckSize += 3;
            }
            else
            {
                p.enemyDeckSize += 3;
            }
        }
    }
}