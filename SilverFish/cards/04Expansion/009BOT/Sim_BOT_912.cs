using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_912 : SimTemplate //* Resurrect
	{
		// Summon a random friendly minion that died this game.
		
        CardDB cdb = CardDB.Instance;
        CardDB.Card kid = null; 

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {


            int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
            int kids = 3;

            {
             
                if (p.numberofOwnDiedMinion >= 1&&kids > 0)
                {
                    
                foreach ( KeyValuePair<CardDB.cardIDEnum, int> cn in p.OwnDiedMinions)
                {
                    kid = cdb.getCardDataFromID(cn.Key);

                        if ((TAG_RACE)kid.race == TAG_RACE.MECHANICAL)
                        {
                            p.CallKid(kid, pos, ownplay);
                            kids--;
                            if(kids==0)
                            break;
                        }
                        
                    }
                //if (p.numberofOwnDiedMinion-i >= 1) p.CallKid(kid, pos, ownplay);




                }
            }


                
            
        }
    }
}