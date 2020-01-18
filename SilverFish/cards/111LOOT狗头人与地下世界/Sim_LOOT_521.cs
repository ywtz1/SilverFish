using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_521 : SimTemplate //* master oakheart 
	{
        //Recruit a 1, 2, and 3-Attack minion.
        	//CardDB.Card c;
			//CardDB.Card c1;
			//CardDB.Card c2;
			//CardDB.Card c3;
		public override void getBattlecryEffect(Playfield p,Minion own,Minion target,int choice)
		{


			p.zhaomu(own.own,TAG_RACE.INVALID,0,1);
			p.zhaomu(own.own,TAG_RACE.INVALID,0,2,CardDB.cardName.unknown);
			p.zhaomu(own.own,TAG_RACE.INVALID,0,3,CardDB.cardName.unknown);

			/*int pos =(own.own) ? p.ownMinions.Count : p.enemyMinions.Count;

			foreach ( KeyValuePair<CardDB.cardIDEnum, int> cn in p.prozis.turnDeck)
			{
				c = CardDB.Instance.getCardDataFromID(cn.Key);

				if (c.type == CardDB.cardtype.MOB&&c.Attack == 1&&c1.name== CardDB.cardName.unknown)
				{
					pos = own.own ? p.ownMinions.Count : p.enemyMinions.Count;

					p.callKid(c, pos, own.own, false);

					c1=c;
				}
				else p.prozis.turnDeck2.Add(cn.Key, cn.Value);

				if (c.type == CardDB.cardtype.MOB&&c.Attack == 2&&c2.name== CardDB.cardName.unknown)
				{
					pos = own.own ? p.ownMinions.Count : p.enemyMinions.Count;
					p.callKid(c, pos, own.own, false);

					c2=c;

				}
				else p.prozis.turnDeck2.Add(cn.Key, cn.Value);
				
				if (c.type == CardDB.cardtype.MOB&&c.Attack == 3&&c3.name== CardDB.cardName.unknown)
				{
					pos = own.own ? p.ownMinions.Count : p.enemyMinions.Count;
					p.callKid(c, pos, own.own, false);
					c3=c;

				}
				else p.prozis.turnDeck2.Add(cn.Key, cn.Value);

			}

				p.prozis.turnDeck.Clear();
			foreach ( KeyValuePair<CardDB.cardIDEnum, int> cn in p.prozis.turnDeck2)
				{
					
					p.prozis.turnDeck.Add(cn.Key, cn.Value);
				}



			*/
		}

	}
}