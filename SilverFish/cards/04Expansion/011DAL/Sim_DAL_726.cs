using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_726 : SimTemplate //
	{

		

		
		public override void onAuraStarts(Playfield p, Minion own)
        {
            if (own.own)
            {
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if ((TAG_RACE)hc.card.race == TAG_RACE.MURLOC)
                    {
                        hc.manacost=1;
                    }
                }
            }
            else
            {

            }

        }


        public override void onAuraEnds(Playfield p, Minion own)
        {
            if (own.own)
            {
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if ((TAG_RACE)hc.card.race == TAG_RACE.MURLOC)
                    {
                        hc.manacost=hc.card.cost;
                    }
                }
            }

        }


	}
}