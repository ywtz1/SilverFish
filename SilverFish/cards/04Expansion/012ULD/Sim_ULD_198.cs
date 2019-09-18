using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    /// <summary>
    /// Conjured Mirage
    /// ħ������ 
    /// </summary>
    public class Sim_ULD_198 : SimTemplate
    {
        /// <summary>
        /// Taunt At the start of your turn, shuffle this minion into your deck.
        /// ��������ĻغϿ�ʼʱ���������ϴ������ƿ⡣
        /// </summary>
        /// <param name="p"></param>
        /// <param name="triggerEffectMinion"></param>
        /// <param name="turnStartOfOwner"></param>
        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (triggerEffectMinion.own == turnStartOfOwner)
            {
                p.minionReturnToDeck(triggerEffectMinion, turnStartOfOwner);
            }
        }
    }
}