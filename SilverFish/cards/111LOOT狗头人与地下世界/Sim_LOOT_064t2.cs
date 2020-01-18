using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_064t2 : SimTemplate//
    {


        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
        	if(target.own)
        	{
        		int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
                p.callKid(target.handcard.card, pos, ownplay);
                p.callKid(target.handcard.card, pos, ownplay);
                p.callKid(target.handcard.card, pos, ownplay);
        		//m.handcard.card.name

        	}




            
            
        }


    }
}
