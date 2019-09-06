using System;
using System.Collections.Generic;
using System.Text;


namespace HREngine.Bots
{
    /// <summary>
    /// Vex Crow
    /// ������ѻ
    /// </summary>
    class Sim_GIL_664 : SimTemplate 
    {
        /// <summary>
        /// Whenever you cast a spell, summon a random 2-Cost minion.
        /// ÿ����ʩ��һ������������ٻ�һ������ֵ����Ϊ2�� ��ӡ�
        /// </summary>
        /// </summary>
        /// <param name="p"></param>
        /// <param name="hc"></param>
        /// <param name="wasOwnCard"></param>
        /// <param name="triggerEffectMinion"></param>
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (triggerEffectMinion.own == wasOwnCard)
            {
                if (hc.card.type == CardDB.cardtype.SPELL)
                {
                    int pos = (wasOwnCard) ? p.ownMinions.Count : p.enemyMinions.Count;
                    p.CallKid(p.getRandomCardForManaMinion(2), pos, wasOwnCard);
                }
            }
        }
    }
}
