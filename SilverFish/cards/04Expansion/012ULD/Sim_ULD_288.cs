using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots

{
    /// <summary>
    /// Anka, the Buried
    /// ������İ��� 
    /// </summary>
    public class Sim_ULD_288 : SimTemplate
    {
        /// <summary>
        /// Battlecry: Change each Deathrattle minion in your hand into a 1/1 that costs (1).
        /// ս��ʹ�����������о������������Ʊ�Ϊ1/1���ҷ���ֵ����Ϊ��1���㡣
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
                    if (hc.card.type == CardDB.cardtype.MOB && hc.card.deathrattle)
                    {
                        hc.manacost = 1;
                        hc.addattack = 1 - hc.card.Attack;
                        hc.addHp = 1 - hc.card.Health;
                    }
                }
            }
        }
    }
}