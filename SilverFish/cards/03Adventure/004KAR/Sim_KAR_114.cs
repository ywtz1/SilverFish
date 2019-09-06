using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_114 : SimTemplate //* Barnes
	{
		//Battlecry: Summon a 1/1 copy of a random minion in your deck.
		
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.OG_156a); //Ooze with Taunt
        CardDB.Card c = null;
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			bool a =false;            
			int pos = (own.own) ? p.ownMinions.Count : p.enemyMinions.Count;

			if(own.own)
			{
				foreach ( KeyValuePair<CardDB.cardIDEnum, int> cn in p.prozis.turnDeck)
                {
	                c = CardDB.Instance.getCardDataFromID(cn.Key);

	                if (c.type == CardDB.cardtype.MOB)
	                {
	                    p.CallKid(c, pos, own.own, false);
	                    foreach( Minion m in p.ownMinions)
	                    {
	                        if(m.handcard.card==c)
	                        {m.Attack = 1;m.HealthPoints = 1;m.maxHp = 1;break;}
	                    }
	                    a=true;
	                    break;
	                    
	                }

                }
			}
            if(!a)p.CallKid(kid, own.zonepos, own.own);
		}
	}
}