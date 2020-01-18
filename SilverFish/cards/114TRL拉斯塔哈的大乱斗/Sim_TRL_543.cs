using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{


class Sim_TRL_543:SimTemplate//*Val'anyr
		//Deathrattle:Give a minion in your hand +4/+2.When it dies,reequip this.
{
	CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TRL_543);
	
		public override void onCardPlay(Playfield p ,bool ownplay ,Minion target ,int choice)
		{
			p.equipWeapon(weapon,ownplay);
			
		}



    
}
}

