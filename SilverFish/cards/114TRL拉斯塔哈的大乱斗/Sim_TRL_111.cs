using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{


class Sim_TRL_111:SimTemplate//猎头者

{
	CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TRL_111);
	
		public override void onCardPlay(Playfield p ,bool ownplay ,Minion target ,int choice)
		{
			p.equipWeapon(weapon,ownplay);
			if(ownplay)
			foreach (Minion ma in p.ownMinions)
			{
				if((TAG_RACE)ma.handcard.card.race == TAG_RACE.PET)
				{
					p.ownWeapon.Durability+=1;
					break;
				}
			}

			else foreach (Minion ma in p.enemyMinions)
			{
				if((TAG_RACE)ma.handcard.card.race == TAG_RACE.PET)
				{
					p.enemyWeapon.Durability+=1;

					break;
				}
			
			}
			
			
			//p.evaluatePenality-=a;
		}



    
}
}

