using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{

    public class Sim_DAL_770 : SimTemplate //Å·Ã×ÇÑ»ÙÃðÕß
    {
        //
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
			if (p.ownMaxMana ==10)
			{	
		        if (target != null)
				{	
                    int dmg = 10;
                    p.minionGetDamageOrHeal(target, dmg);
				}	
			}
        }
    }

}