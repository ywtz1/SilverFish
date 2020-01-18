using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_254 : SimTemplate //* Flame Lance
	{
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_160t);//panther

		
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (choice == 1 || (p.ownFandralStaghelm > 0 && ownplay))
            {
                p.minionGetBuffed(target, 2, 4);
                if (!target.taunt)
                {
                    target.taunt = true;
                    if (target.own) p.anzOwnTaunt++;
                    else p.anzEnemyTaunt++;
                }
            }
            if (choice == 2 || (p.ownFandralStaghelm > 0 && ownplay))
            {
                int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
                p.callKid(kid, pos, ownplay, false);
            }
        }
	}
}