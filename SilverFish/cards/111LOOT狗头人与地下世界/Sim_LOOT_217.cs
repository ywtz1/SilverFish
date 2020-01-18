using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_217 : SimTemplate //* To My Side!
	{
		//Summon 2 Animal Companions.
		
        CardDB.Card c1 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.NEW1_034);//Huffer
        CardDB.Card c2 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.NEW1_033);//Leokk
        
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int pos = (ownplay)?  p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(c1, pos, ownplay, false);
            p.callKid(c2, pos, ownplay);
		}
	}
}