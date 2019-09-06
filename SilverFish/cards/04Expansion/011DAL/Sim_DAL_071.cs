using System;
using System.Collections.Generic;
using System.Text;


namespace HREngine.Bots
{
    class Sim_DAL_071 : SimTemplate //* Faldorei Strider
    {
        //Battlecry: 44


        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{       
			if(target!=null)
			{
				int mana=target.handcard.card.cost + 1;
            	p.minionTransform(target, p.getRandomCardForManaMinion(mana));

			}
		}
    }
}