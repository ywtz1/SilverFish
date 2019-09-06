using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_507t2 : SimTemplate //* Resurrect
	{
		// Summon a random friendly minion that died this game.
		
        CardDB cdb = CardDB.Instance;
        CardDB.Card kid = null; 

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            //if (p.numberofOwnDiedMinion >= 1)
            {
                int i=0;
                int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;

                if(p.numberofOwnDiedMinion == 1)
                {
                    int posi = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
                    kid = CardDB.Instance.getCardDataFromID((p.OwnLastDiedMinion == CardDB.cardIDEnum.None) ? CardDB.cardIDEnum.EX1_345t : p.OwnLastDiedMinion); // Shadow of Nothing 0:1 or ownMinion
                p.CallKid(kid, posi, ownplay, false);
                }
                else
                foreach ( KeyValuePair<CardDB.cardIDEnum, int> cn in p.OwnDiedMinions)
                {
                    kid = cdb.getCardDataFromID(cn.Key);

                    
                        p.CallKid(kid, pos++, ownplay);
                        i++;
                        if(i==4||pos>7)
                        break;
                }
                //if (i=(p.numberofOwnDiedMinion-i) >= 1) p.CallKid(kid, pos, ownplay);



                
            }
        }
    }
}