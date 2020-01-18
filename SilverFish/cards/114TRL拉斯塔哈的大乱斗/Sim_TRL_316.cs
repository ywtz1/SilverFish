using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_316 : SimTemplate //* 
	{
		//Your Hero Power deals 1 extra damage.
		CardDB.Card kid2 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_298); //大螺丝

		public override void getBattlecryEffect(Playfield p,Minion own,Minion target,int choice)
		{
			int pos = (own.own) ? p.ownMinions.Count : p.enemyMinions.Count;
            if((own.own&&p.HeroPowerhealDamage>=8)||(!own.own &&p.HeroPowerhealDamage2>=8))
            p.callKid(kid2, pos, own.own, false);
            

            
		}

	}
}