		using System;
		using System.Collections.Generic;
		using System.Text;

		namespace HREngine.Bots
		{


		class Sim_BOT_312:SimTemplate //*
		
		{
			CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BOT_312t);
			public override void getBattlecryEffect(Playfield p,Minion own,Minion target,int choice)
			{
				//own.robot312++;
					//p.cili(own);
	              
	        }
	    public override void onDeathrattle(Playfield p, Minion m)
        {
          int pos = (m.own) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.CallKid(kid, pos, m.own, false);
            p.CallKid(kid, pos, m.own, false);
            p.CallKid(kid, pos, m.own, false);
        }





	      }
	  }