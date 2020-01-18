using System;
using System.Collections.Generic;
using System.Text;


namespace HREngine.Bots
{
    /// <summary>
    /// Marsh Drake
    /// �������
    /// </summary>
    class Sim_GIL_683 : SimTemplate //* Marsh Drake
    {
        /// <summary>
        /// Battlecry: Summon a 2/1 Poisonous Drakeslayer for your opponent.
        /// ս��Ϊ��Ķ����ٻ�һ��2/1�����о綾�ķ������֡�
        /// </summary>
        /// <param name="p"></param>
        /// <param name="m"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GIL_683t); // 2/1 Poisonous Drakeslayer


        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            int pos = (own.own) ? p.enemyMinions.Count : p.ownMinions.Count;
            p.CallKid(kid, pos, !own.own);

        }
    }
}