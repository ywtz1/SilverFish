using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots

{
    /// <summary>
    /// King Phaoris
    /// ������˹���� 
    /// </summary>
    public class Sim_ULD_304 : SimTemplate
    {
        /// <summary>
        /// Battlecry: For each spell in your hand, summon a random minion of the same Cost.
        /// ս����������ÿ��һ�ŷ����ƣ����ٻ�һ������ֵ�����뷨������ͬ�������ӡ�
        /// </summary>
        /// <param name="p"></param>
        /// <param name="own"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if (hc.card.type == CardDB.cardtype.SPELL)
                    {
                        p.CallKid(p.getRandomCardForManaMinion(hc.manacost), p.ownMinions.Count, own.own);
                    }
                    if (p.ownMinions.Count == 7) break;
                }
            }
        }
    }
}