using System;
using System.Collections.Generic;
using System.Text;


namespace HREngine.Bots
{
    class Sim_GIL_840: SimTemplate //* Lady in White
    {
		// Battlecry: Cast 'Inner Fire' on every minion in your deck (set Attack equal to Health).
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own && p.prozis.getDeckCardsForCost(6) == CardDB.cardIDEnum.None) p.evaluatePenality -= 20;
        }
    }
}