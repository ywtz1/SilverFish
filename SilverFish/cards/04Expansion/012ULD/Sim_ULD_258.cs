using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots

{
    /// <summary>
    /// Armagedillo
    /// 硕铠鼠
    /// </summary>
    class Sim_ULD_258 : SimTemplate
    {
        /// <summary>
        /// Taunt At the end of your turn, give all Taunt minions in your hand +2/+2.
        /// 嘲讽在你的回合结束时，使你手牌中所有嘲讽随从牌获得+2/+2。
        /// </summary>
        /// <param name="p"></param>
        /// <param name="triggerEffectMinion"></param>
        /// <param name="turnEndOfOwner"></param>
        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if (hc.card.type == CardDB.cardtype.MOB && hc.card.tank)
                    {
                        hc.addattack += 2;
                        hc.addHp += 2;
                        p.anzOwnExtraAngrHp += 4;
                    }
                }
            }
        }
    }
}