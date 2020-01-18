using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_252 : SimTemplate //* Clutchmother Zavas
	{
		//Whenever you discard this, give it +2/+2 and return it to your hand.


        public override bool onCardDicscard(Playfield p, Handmanager.Handcard hc, Minion own, int num, bool checkBonus)
        {
            if (checkBonus) return true;
			if (own != null) return false;

            p.drawACard(CardDB.cardName.highpriestessjeklik, true, true);
            p.drawACard(CardDB.cardName.highpriestessjeklik, true, true);

            int i = p.owncards.Count - 1;
            p.owncards[i].setHCtoHC(hc);
            p.owncards[i-1].setHCtoHC(hc);



            return true;
        }
    }
}