using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_BOT_431: SimTemplate //* 祖尔金
    {
        // Battlecry: Summon all friendly Demons that died this game.

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BOT_031);//Wolf

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {

            int pos =(own.own) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(kid, pos, own.own);
        }

        
    }
}