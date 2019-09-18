using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    /// <summary>
    /// Quicksand Elemental
    /// ��ɳԪ��
    /// </summary>
    public class Sim_ULD_197 : SimTemplate
    {
        /// <summary>
        /// Battlecry: Give all enemy minions -2 Attack this turn.
        /// ս���ڱ��غ��У�ʹ���ез���ӻ��-2��������
        /// </summary>
        /// <param name="p"></param>
        /// <param name="own"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            List<Minion> temp = (own.own) ? p.enemyMinions : p.ownMinions;
            foreach (Minion m in temp)
            {
                p.minionGetTempBuff(m, -2, 0);
            }
        }
    }
}