using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    /// <summary>
    /// Pit Crocolisk
    /// 深坑鳄鱼
    /// </summary>
    public class Sim_ULD_190 : SimTemplate
    {
        /// <summary>
        /// Battlecry: Deal 5 damage.
        /// 战吼：造成5点伤害。
        /// </summary>
        /// <param name="p"></param>
        /// <param name="own"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.minionGetDamageOrHeal(target, 5);
        }
    }
}