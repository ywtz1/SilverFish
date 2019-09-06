using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_511 : SimTemplate //* master oakheart 
	{
        //Recruit a 1, 2, and 3-Attack minion.
        	//CardDB.Card c;
			//CardDB.Card c1;
			//CardDB.Card c2;
			//CardDB.Card c3;
		public override void getBattlecryEffect(Playfield p,Minion own,Minion target,int choice)
		{


			p.zhaomu(own.own,TAG_RACE.PET,0,0);
			
		}
		public override void onDeathrattle(Playfield p, Minion m)
        {
            
           p.zhaomu(m.own,TAG_RACE.PET,0,0);

        }

	}
}