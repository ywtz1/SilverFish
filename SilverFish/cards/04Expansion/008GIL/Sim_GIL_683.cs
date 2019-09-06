using System;
using System.Collections.Generic;
using System.Text;


namespace HREngine.Bots
{
    /// <summary>
    /// Marsh Drake
    /// 沼泽飞龙
    /// </summary>
    class Sim_GIL_683 : SimTemplate //* Marsh Drake
    {
        /// <summary>
        /// Battlecry: Summon a 2/1 Poisonous Drakeslayer for your opponent.
        /// 战吼：为你的对手召唤一个2/1并具有剧毒的飞龙猎手。
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