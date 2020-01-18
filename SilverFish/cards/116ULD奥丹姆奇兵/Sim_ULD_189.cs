using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    /// <summary>
    /// Faceless Lurker
    /// ����Ǳ����
    /// </summary>
    public class Sim_ULD_189 : SimTemplate
    {
        /// <summary>
        /// Taunt Battlecry: Double this minion's Health.
        /// ����ս�𣺽�����ӵ�����ֵ������
        /// </summary>
        /// <param name="p"></param>
        /// <param name="own"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.minionGetBuffed(own, 0, own.Hp);
        }
    }
}