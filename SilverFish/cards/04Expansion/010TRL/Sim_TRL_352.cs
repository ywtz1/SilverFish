using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{


class Sim_TRL_352:SimTemplate//舔舔

{
	CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TRL_352);
	
		public override void onCardPlay(Playfield p ,bool ownplay ,Minion target ,int choice)
		{
            p.equipWeapon(weapon, ownplay);
            if (ownplay)
            {
                if (p.ueberladung > 0)
                {
                    p.minionGetBuffed(p.ownHero, 2, 0);
                    p.ownWeapon.Angr += 2;
                    p.ownSpiritclaws = true;
                }
            }
            else
            {
                //if (p.ueberladung > 0)
                {
                    p.minionGetBuffed(p.enemyHero, 2, 0);
                    p.enemyWeapon.Angr += 2;
                    p.enemySpiritclaws = true;
                }
            }
		}



    
}
}

