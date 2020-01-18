using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    /// <summary>
    /// Ramkahen Wildtamer
    /// ���¿���ѱ��ʦ
    /// </summary>
    public class Sim_ULD_151 : SimTemplate
    {
        /// <summary>
        /// Battlecry: Copy a random Beast in your hand.
        /// ս���������һ���������е�Ұ���ơ�
        /// </summary>
        /// <param name="p"></param>
        /// <param name="own"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                Handmanager.Handcard hc = p.searchRandomMinionInHand(p.owncards, searchmode.searchLowestCost, GAME_TAGs.CARDRACE, TAG_RACE.PET);
                if (hc != null) p.drawACard(hc.card.name, own.own, true);
            }
        }
    }
}