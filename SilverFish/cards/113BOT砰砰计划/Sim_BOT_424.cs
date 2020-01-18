using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{


class Sim_BOT_424:SimTemplate//*机械克苏恩
{
	//CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOOT_500);
	
		public override void onCardPlay(Playfield p ,bool ownplay ,Minion target ,int choice)
		{
			if(p.ownDeckSize != 0)p.evaluatePenality+=1000;
		}


		public override void onDeathrattle(Playfield p,Minion m)
		{
			if(m.own)
			{
				Handmanager.Handcard hc = p.searchRandomMinionInHand ( p.owncards ,searchmode.searchLowestCost ,GAME_TAGs.Mob);
				if(p.owncards.Count==0 && p.ownMinions.Count==0 && p.ownDeckSize == 0)
				{
					p.enemyHero.Hp=0;
					p.minionGetDamageOrHeal(p.enemyHero, 1000);
				}

			}
		}
    
}
}

