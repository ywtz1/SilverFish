using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_079 : SimTemplate //* wandering monster
    {
        //Secret:When an enemy attacks your hero, summon a 3-Cost minion as the new target.
		
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_020);

        public override void onSecretPlay(Playfield p, bool ownplay, Minion attacker, Minion target, out int number)
        {
            number = 0;
            if (ownplay)
            {
                int pos = p.ownMinions.Count;
                p.callKid(kid, pos, true, true, true);
                if (p.ownMinions.Count >= 1)
                {
                    if (p.ownMinions[p.ownMinions.Count - 1].name == CardDB.cardName.defender)
                    {
                        number = p.ownMinions[p.ownMinions.Count - 1].entitiyID;
                    }
                }
            }
            else
            {
                int pos = p.enemyMinions.Count;
                p.callKid(kid, pos, false, true, true);

                if (p.enemyMinions.Count >= 1)
                {
                    if (p.enemyMinions[p.enemyMinions.Count - 1].name == CardDB.cardName.defender)
                    {
                        number = p.enemyMinions[p.enemyMinions.Count - 1].entitiyID;
                    }
                }
            }
        }
    }
}