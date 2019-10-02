using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_436 : SimTemplate //* Flame Lance
	{
		//Deal 8 damage to a minion.
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{

            p.drawACard (CardDB.cardName.unknown,ownplay,false);
            //Dictionary<CardDB.cardIDEnum, int> deck =p.Decknow();

            foreach (KeyValuePair<CardDB.cardIDEnum, int> cid in p.Decknow())
            {

                if (cid.Key==CardDB.cardIDEnum.ULD_304)
                {
                	p.evaluatePenality -=50;
                	break;
                }
            }

            p.drawACard (CardDB.cardName.unknown,ownplay,false);
		}
	}
}