using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_149 : SimTemplate //* Blubber Baron
	{
		// Whenever you summon a Battlecry minion while this is in your hand, gain +1/+1.

        //handled

        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Handmanager.Handcard triggerhc)
        {
            //int n= p.numberofDiedMinion;
            //if(n+7>=p.numberofDiedMinion) triggerhc.manacost=7+n-p.numberofDiedMinion;
           // else triggerhc.manacost=0;


            

        }
    }
}