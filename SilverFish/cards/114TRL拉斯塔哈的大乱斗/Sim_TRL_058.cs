﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TRL_058 : SimTemplate
    {


        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
        	p.drawACard (CardDB.cardName.unknown,ownplay,true);
           


            
            
        }

    }
}
