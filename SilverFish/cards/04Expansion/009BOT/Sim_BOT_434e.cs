using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_BOT_434e : SimTemplate //* Shadow Reflection
    {
        //Each time you play a card, transform this into a copy of it.

        //handled

        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Handmanager.Handcard triggerhc)
        {
        	if(hc.card.type == CardDB.cardtype.MOB)
            {
            	triggerhc.setHCtoHC(hc);
            	triggerhc.addattack =3-triggerhc.card.Attack;
            	triggerhc.addHp =4-triggerhc.card.Health;
            }


        }
    }
}