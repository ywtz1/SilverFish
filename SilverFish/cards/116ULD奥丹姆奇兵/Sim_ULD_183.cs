using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    /// <summary>
    /// Anubisath Warbringer
    /// ��Ŭ����˹ս��ʹ��
    /// </summary>
    public class Sim_ULD_183 : SimTemplate
    {
        /// <summary>
        /// Deathrattle: Give all minions in your hand +3/+3.
        /// ���ʹ�������е���������ƻ��+3/+3��
        /// </summary>
        /// <param name="p"></param>
        /// <param name="m"></param>
        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.own)
            {
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if (hc.card.type == CardDB.cardtype.MOB)
                    {
                        hc.addattack += 3;
                        hc.addHp += 3;
                        p.anzOwnExtraAngrHp += 6;
                    }
                }
            }
        }
    }
}