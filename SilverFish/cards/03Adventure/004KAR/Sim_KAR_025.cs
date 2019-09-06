using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_025 : SimTemplate //* Kara Kazham!
	{
		//Summon a 1/1 Candle, 2/2 Broom, and 3/3 Teapot.
		
        CardDB.Card c1 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.KAR_025a);//Candle
        CardDB.Card c2 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.KAR_025b);//Broom
        CardDB.Card c3 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.KAR_025c);//Teapot
        
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int pos = (ownplay)?  p.ownMinions.Count : p.enemyMinions.Count;
            p.CallKid(c1, pos, ownplay, false);
            p.CallKid(c2, pos, ownplay);
            p.CallKid(c3, pos, ownplay);
		}
	}
}