using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    /// <summary>
    /// Tomb Warden
    /// ��Ĺ������
    /// </summary>
    public class Sim_ULD_253 : SimTemplate
    {
        /// <summary>
        /// Taunt Battlecry: Summon a copy of this minion.
        /// ����ս���ٻ�һ������ӵĸ��ơ�
        /// </summary>
        /// <param name="p"></param>
        /// <param name="own"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.CallKid(own.handcard.card, own.zonepos, own.own);
            p.ownMinions[own.zonepos + 1].setMinionToMinion(own);
        }
    }
}