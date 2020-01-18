using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{


class Sim_LOOT_500:SimTemplate//*Val'anyr
		//Deathrattle:Give a minion in your hand +4/+2.When it dies,reequip this.
{
	CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOOT_500);
	
		public override void onCardPlay(Playfield p ,bool ownplay ,Minion target ,int choice)
		{
			p.equipWeapon(weapon,ownplay);
		}


		public override void onDeathrattle(Playfield p,Minion m)
		{
			if(m.own)
			{
				Handmanager.Handcard hc = p.searchRandomMinionInHand ( p.owncards ,searchmode.searchLowestCost ,GAME_TAGs.Mob);
				
				if(hc!=null)
				{
					hc.addattack +=4;
					hc.addHp +=2;
					p.anzOwnExtraAngrHp +=6;
					hc.valanyr++;
				}
			}
		}
    
}
}

