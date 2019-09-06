using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{


		class Sim_BOT_548:SimTemplate //* Zilliax
//Magnetic,taunt,1ifesteal,divineshield,rush
		{
			public override void getBattlecryEffect(Playfield p,Minion own,Minion target,int choice)
			{
				p.minionGetRush(own);
				p.cili(own);
			}


 //int a=1;

		}
	}

