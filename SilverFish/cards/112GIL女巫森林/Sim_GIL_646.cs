using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_646 : SimTemplate //* fatiaojiqiren
	{
		//Your Hero Power deals 1 extra damage.
		//int a=0;

        public override void onAuraStarts(Playfield p, Minion m)
		{
			//a=p.ownHeroPowerExtraDamage+2;
			if (m.own) p.fatiaojiqiren*=2;
            else p.fatiaojiqiren2*=2;

            //if (own.own) p.ownHeroPowerExtraDamage+=a;
            //else p.enemyHeroPowerExtraDamage+=a;
		}

	public override void onAuraEnds(Playfield p, Minion own)
        {
            //if (own.own) p.ownHeroPowerExtraDamage-=a;
           // else p.enemyHeroPowerExtraDamage-=a;
            if (own.own) p.fatiaojiqiren/=2;
            else p.fatiaojiqiren2/=2;
        }
	}
}