using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots

{
    /// <summary>
    /// EVIL Recruiter
    /// �ֵ���ļ��
    /// </summary>
    class Sim_ULD_162 : SimTemplate
    {
        /// <summary>
        /// Battlecry: Destroy a friendly Lackey to summon a 5/5 Demon.
        /// ս������һ���ѷ����࣬�ٻ�һ��5/5�Ķ�ħ��
        /// </summary>
        /// <param name="p"></param>
        /// <param name="own"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null)
            {
                CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ULD_162t);
                p.minionGetDestroyed(target);
                p.callKid(kid, own.zonepos, own.own);
            }
        }
    }
}