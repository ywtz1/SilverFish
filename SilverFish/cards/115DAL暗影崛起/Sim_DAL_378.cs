using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_378 : SimTemplate //* 猛兽出笼
	{

		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DAL_378t1); //Sapling

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.drawACard(CardDB.cardIDEnum.DAL_378ts, ownplay,true);
            int place = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            
            p.callKid(kid, place, ownplay, false);
		}
	}
}