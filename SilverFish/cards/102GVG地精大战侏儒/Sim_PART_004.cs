using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_PART_004 : SimTemplate //Finicky Cloakfield
    {

        //   Give a friendly minion Stealth until your next turn.


        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if(target==null)return;
            target.stealth = true;
            target.conceal = true;
        }


    }

}