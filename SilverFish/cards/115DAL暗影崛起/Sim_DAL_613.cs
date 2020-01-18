using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_613 : SimTemplate //* Flame Lance
	{
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_158t); //烈焰小鬼
		
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			int place = (own.own) ? p.ownMinions.Count : p.enemyMinions.Count;
            
            p.callKid(kid, place, own.own, false);
            
		}
	}
}