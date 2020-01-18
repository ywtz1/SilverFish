using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    /// <summary>
    /// History Buff
    /// ��ʷ������
    /// </summary>
    public class Sim_ULD_290 : SimTemplate
    {
        /// <summary>
        /// Whenever you play a minion, give a random minion in your hand +1/+1.
        /// ÿ����ʹ��һ������ƣ����ʹ�������е�һ������ƻ��+1/+1��
        /// </summary>
        /// <param name="p"></param>
        /// <param name="triggerEffectMinion"></param>
        /// <param name="summonedMinion"></param>
        public override void onMinionWasSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
        {
            if (summonedMinion.playedFromHand && summonedMinion.own == triggerEffectMinion.own && summonedMinion.entitiyID != triggerEffectMinion.entitiyID)
            {
                if (triggerEffectMinion.own)
                {
                    Handmanager.Handcard hc = p.searchRandomMinionInHand(p.owncards, searchmode.searchLowestCost, GAME_TAGs.Mob);
                    if (hc != null)
                    {
                        hc.addattack++;
                        hc.addHp++;
                        p.anzOwnExtraAngrHp += 2;
                    }
                }
            }
        }
    }
}