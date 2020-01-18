using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_910 : SimTemplate //* Grimestreet Outfitter
	{
		// Battlecry: Give all minions in your hand +2/+2.
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if (hc.card.type == CardDB.cardtype.MOB)
                    {
                        hc.addattack+=2;
                        hc.addHp+=2;
                        p.anzOwnExtraAngrHp += 4;
                    }
                }
            }
        }
	}
}