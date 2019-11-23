using System;
using System.Collections.Generic;
using System.Text;
using SilverFish.Helpers;
namespace HREngine.Bots
{
	class Sim_BRM_017 : SimTemplate //* Resurrect
	{
		// Summon a random friendly minion that died this game.
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (p.OwnLastDiedMinion!=CardDB.cardIDEnum.None)
            {
                int posi = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
                CardDB.Card kid = CardDB.Instance.getCardDataFromID(p.OwnLastDiedMinion); // Shadow of Nothing 0:1 or ownMinion
                p.CallKid(kid, posi, ownplay, false);
            }
		}
	}
}