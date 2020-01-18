using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    /// <summary>
    /// Dune Sculptor
    /// ɳ������ʦ
    /// </summary>
    public class Sim_ULD_329:SimTemplate
    {
        /// <summary>
        /// After you cast a spell, add a random Mage minion to your hand.
        /// ����ʩ��һ�������������һ�ŷ�ʦ���������������ơ�
        /// </summary>
        /// <param name="p"></param>
        /// <param name="hc"></param>
        /// <param name="wasOwnCard"></param>
        /// <param name="triggerEffectMinion"></param>
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (wasOwnCard == triggerEffectMinion.own && hc.card.type == CardDB.cardtype.SPELL)
            {
                p.drawACard(CardDB.cardName.unknown, wasOwnCard, true);
            }
        }
    }
}