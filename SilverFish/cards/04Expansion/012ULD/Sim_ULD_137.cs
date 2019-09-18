using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots

{
    /// <summary>
    /// Garden Gnome
    /// ԰��٪�� 
    /// </summary>
    public class Sim_ULD_137 : SimTemplate
    {
        /// <summary>
        /// Battlecry: If you're holding a spell that costs (5) or more, summon two 2/2 Treants.
        /// ս���������������з���ֵ���Ĵ��ڻ���ڣ�5���ķ����ƣ����ٻ�����2/2�����ˡ�
        /// </summary>
        /// <param name="p"></param>
        /// <param name="own"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ULD_137t);

            if (own.own)
            {
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if (hc.card.cost >= 5 && hc.card.type == CardDB.cardtype.SPELL)
                    {
                        p.CallKid(kid, own.zonepos, own.own, false);
                        p.CallKid(kid, own.zonepos - 1, own.own);
                        break;
                    }
                }
            }
        }
    }
}