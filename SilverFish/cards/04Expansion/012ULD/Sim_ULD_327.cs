using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots

{
    /// <summary>
    /// Bazaar Mugger 
    /// ���ж�Ʀ
    /// </summary>
    public class Sim_ULD_327 : SimTemplate
    {
        /// <summary>
        /// Rush Battlecry: Add a random minion from another class to your hand.
        /// ͻϮս�������һ������ְҵ�����������������ơ�
        /// </summary>
        /// <param name="p"></param>
        /// <param name="own"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardName.unknown, own.own, true);
        }
    }
}