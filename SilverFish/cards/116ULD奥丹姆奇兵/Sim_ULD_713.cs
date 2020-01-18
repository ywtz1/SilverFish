using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    /// <summary>
    /// Swarm of Locusts
    /// �ɻȳ�Ⱥ
    /// </summary>
    public class Sim_ULD_713 : SimTemplate
    {
        /// <summary>
        /// Summon seven 1/1 Locusts with Rush.
        /// �ٻ���ֻ1/1������ͻϮ�Ļȳ档
        /// </summary>
        /// <param name="p"></param>
        /// <param name="ownplay"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            CardDB.Card locust = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ULD_430t);
            if (ownplay)
            {
                for (int i = 0; i < 7; i++)
                {
                    int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
                    p.callKid(locust, pos, ownplay);
                }
            }
        }
    }
}