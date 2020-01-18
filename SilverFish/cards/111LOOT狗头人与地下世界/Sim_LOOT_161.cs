using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_161 : SimTemplate //* Carnivorous Cube
	{
		//Battlecry: Destroy a friendly minion. Deathrattle: Summon 2 copies of it.
		
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null)
            {
                p.LurkersDB.Add(own.entitiyID, new IDEnumOwner() { IDEnum = target.handcard.card.cardIDenum, own = target.own });
                p.minionGetDestroyed(target);
            }
        }
        
        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (p.LurkersDB.ContainsKey(m.entitiyID))
            {
                bool own = p.LurkersDB[m.entitiyID].own;
                int pos = own ? p.ownMinions.Count : p.enemyMinions.Count;
                p.callKid(CardDB.Instance.getCardDataFromID(p.LurkersDB[m.entitiyID].IDEnum), pos, own);
            }
        }
	}
}