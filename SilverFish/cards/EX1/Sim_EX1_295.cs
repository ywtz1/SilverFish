using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_295 : SimTemplate //iceblock
	{
        //todo secret
//    geheimnis:/ wenn euer held tödlichen schaden erleidet, wird dieser verhindert und der held wird immun/ in diesem zug.
        public override void onSecretPlay(Playfield p, bool ownplay, Minion target, int number)
        {
            target.HealthPoints += number;
            target.immune = true;
            if(ownplay)
            {
            	foreach( Handmanager.Handcard bb in p.owncards)
            	{
            		if( bb.card.name==CardDB.cardName.cloudprince ||bb.card.name==CardDB.cardName.medivhsvalet)
            		p.evaluatePenality -= 10;
            	}
            }
        }

	}

}