using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots

{
    /// <summary>
    /// Psychopomp
    /// 接引冥神 
    /// </summary>
    public class Sim_ULD_268 : SimTemplate
    {
        /// <summary>
        /// Battlecry: Summon a random friendly minion that died this game. Give it Reborn.
        /// 战吼：随机召唤一个在本局对战中死亡的友方随从。使其获得复生。
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