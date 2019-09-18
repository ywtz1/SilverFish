using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    /// <summary>
    /// High Priest Amet
    /// �߽׼�˾������ 
    /// </summary>
    public class Sim_ULD_262 : SimTemplate
    {
        /// <summary>
        /// Whenever you summon a minion, set its Health equal to this minion's.
        /// ÿ�����ٻ�һ����ӣ���������ֵ����Ϊ�뱾�����ͬ��
        /// </summary>
        /// <param name="p"></param>
        /// <param name="triggerEffectMinion"></param>
        /// <param name="summonedMinion"></param>
        public override void onMinionWasSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
        {
            if (triggerEffectMinion.own == summonedMinion.own && triggerEffectMinion.entitiyID != summonedMinion.entitiyID)
            {
                summonedMinion.HealthPoints = triggerEffectMinion.HealthPoints;
            }
        }
    }
}