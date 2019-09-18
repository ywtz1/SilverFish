using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots

{
    /// <summary>
    /// Psychopomp
    /// ����ڤ�� 
    /// </summary>
    public class Sim_ULD_268 : SimTemplate
    {
        /// <summary>
        /// Battlecry: Summon a random friendly minion that died this game. Give it Reborn.
        /// ս������ٻ�һ���ڱ��ֶ�ս���������ѷ���ӡ�ʹ���ø�����
        /// </summary>
        /// <param name="p"></param>
        /// <param name="own"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                if (p.OwnLastDiedMinion != CardDB.cardIDEnum.None)
                {
                    CardDB.Card kid = CardDB.Instance.getCardDataFromID(p.OwnLastDiedMinion);
					kid.Reborn = true;
                    p.CallKid(kid, own.zonepos, own.own);
                    
                }
            }
        }
    }
}