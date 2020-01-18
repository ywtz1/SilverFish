using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_596 : SimTemplate //* Õ¶¼¬µ¶
	{
		//After your hero attacks, summon two 1/1 Silver Hand Recruits.
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GIL_596);
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_101t);
        
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
			//int pos = (ownplay)? p.ownMinions.Count : p.enemyMinions.Count;
		   
		   //p.callKid(kid, pos, ownplay, false);
		   //p.callKid(kid, pos, ownplay);
        }
    }
}