using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_099 : SimTemplate //* Grimestreet Pawnbroker
	{
		// Battlecry: Give a random weapon in your hand +1/+1.

    public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
            {
            if (ownplay)
            {
                Handmanager.Handcard hc = p.searchRandomMinionInHand(p.owncards, searchmode.searchLowestCost, GAME_TAGs.Weapon);
                if (hc != null)
                {
                
            p.CallKid(hc.card,  p.ownMinions.Count, ownplay,false);
                }
            }
        }
	}
}