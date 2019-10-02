using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_141ts : SimTemplate 
	{

		
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {


                    p.evaluatePenality -=5;


            //p.drawACard (CardDB.cardName.unknown,ownplay,false);
        }
	}
}