using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
class Sim_BOT_251:SimTemplate //* spider bomb
{//Magnetic deathratt1l
		public override void getBattlecryEffect(Playfield p,Minion own,Minion target,int choice)

	{
		//own.spiderbomb++;
		p.cili(own);


		
	}
	public override void onDeathrattle(Playfield p,Minion m)
	{Minion t=null;
		if(m.own)
		{
			t=p.searchRandomMinion(p.enemyMinions,searchmode.searchLowestHP);
		}
		else
		{
			t=p.searchRandomMinion(p.ownMinions,searchmode.searchHighestAttack);
		}
		if(t!=null)p.minionGetDestroyed(t);
	}
}
}