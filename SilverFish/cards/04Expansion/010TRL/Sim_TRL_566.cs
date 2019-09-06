using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TRL_566 : SimTemplate //* Revenge of the Wild
    {
        //Summon your Beasts that died this turn.

       public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			
            foreach (GraveYardItem gyi in p.diedMinions.ToArray()) // toArray() because a knifejuggler could kill a minion due to the summon :D
            {
				if (gyi.own == ownplay)
                {
					CardDB.Card c = CardDB.Instance.getCardDataFromID(gyi.cardid);
                    int pos = (ownplay)? p.ownMinions.Count : p.enemyMinions.Count;
                    if ((TAG_RACE)c.race == TAG_RACE.PET)
                    {
                        p.CallKid(c, p.ownMinions.Count, gyi.own);
					}
                }
            }
            
        }
    }
}