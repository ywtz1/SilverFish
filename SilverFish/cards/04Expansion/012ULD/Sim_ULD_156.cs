using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    /// <summary>
    /// Dinotamer Brann
    /// ������ʦ������
    /// </summary>
    public class Sim_ULD_156 : SimTemplate
    {
        /// <summary>
        /// Battlecry: If your deck has no duplicates, summon King Krush.
        /// ս���������ƿ���û����ͬ���ƣ����ٻ���������³ʲ��
        /// </summary>
        /// <param name="p"></param>
        /// <param name="own"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own && p.prozis.noDuplicates)
            {
                CardDB.Card krush = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ULD_156t3);
                p.CallKid(krush, own.zonepos, own.own);
            }
        }
    }
}