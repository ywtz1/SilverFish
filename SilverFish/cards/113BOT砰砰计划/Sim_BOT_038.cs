using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_038 : SimTemplate //*<Tag enumID="185" type="String">烟火技师</Tag>
  //<Tag enumID="184" type="String"><b>战吼：</b>使一个友方机械获得+1/+1。如果它具有<b>亡语</b>，则将其触发。</Tag>
	{
		
        	//CardDB.Card c;
			//CardDB.Card c1;
			//CardDB.Card c2;
			//CardDB.Card c3;
		public override void getBattlecryEffect(Playfield p,Minion own,Minion target,int choice)
		{
			if (target != null) 
			{
				if((TAG_RACE)target.handcard.card.race ==TAG_RACE.MECHANICAL)
				{
					p.minionGetBuffed(target, 1, 1);
					p.doDeathrattles(new List<Minion>() { target });
				}
			}
		}


	}
}