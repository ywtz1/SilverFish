using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_378ts : SimTemplate //* 猛兽出笼 衍生卡
	{

		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DAL_378t1); //Sapling

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int place = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            
            p.callKid(kid, place, ownplay, false);
		}
	}
}