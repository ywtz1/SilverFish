using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DAL_570: SimTemplate //
    {
        // Battlecry: Summon all friendly Demons that died this game.

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BOT_031);//Wolf

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if(ownplay)
            {
                int n=p.ownMinions.Count;
                p.evaluatePenality -= 5*n;
            }
        }

        
    }
}