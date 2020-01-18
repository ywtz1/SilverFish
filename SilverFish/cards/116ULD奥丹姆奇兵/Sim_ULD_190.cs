using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    /// <summary>
    /// Pit Crocolisk
    /// �������
    /// </summary>
    public class Sim_ULD_190 : SimTemplate
    {
        /// <summary>
        /// Battlecry: Deal 5 damage.
        /// ս�����5���˺���
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