using System;
using System.Collections.Generic;
using System.Text;


namespace HREngine.Bots
{
class Sim_BOT_263 : SimTemplate //* Soul Infusion
{
// Give the left-most minion in your hand +2/+2.
	public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
	{
		if (ownplay)
		{
		
			foreach (Handmanager.Handcard hc in p.owncards)
            {
                if (hc.card.type == CardDB.cardtype.MOB)  
                {
                	if(hc.card.name == CardDB.cardName.doublingimp)//双生小鬼)
                	p.evaluatePenality -= 15;
                	hc.addattack += 2;
				    hc.addHp += 2;
				    p.anzOwnExtraAngrHp += 4;
				    break;
                }
            }

		}
	}
}
}