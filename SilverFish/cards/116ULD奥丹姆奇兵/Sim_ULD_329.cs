using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    /// <summary>
    /// Dune Sculptor
    /// 沙丘塑形师
    /// </summary>
    public class Sim_ULD_329:SimTemplate
    {
        /// <summary>
        /// After you cast a spell, add a random Mage minion to your hand.
        /// 在你施放一个法术后，随机将一张法师随从牌置入你的手牌。
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