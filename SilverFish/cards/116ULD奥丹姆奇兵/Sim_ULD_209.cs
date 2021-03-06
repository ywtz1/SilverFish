using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    /// <summary>
    /// Vulpera Scoundrel
    /// 狐人恶棍
    /// </summary>
    public class Sim_ULD_209 : SimTemplate
    {
        /// <summary>
        /// Battlecry: Discover a spell or pick a mystery choice.
        /// 战吼：发现一张法术牌或选择一个神秘选项。
        /// </summary>
        /// <param name="p"></param>
        /// <param name="own"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardName.thecoin, own.own, true);
        }
    }
}