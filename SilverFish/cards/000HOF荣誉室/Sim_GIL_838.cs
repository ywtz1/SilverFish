using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_838 : SimTemplate //黑猫
	{

//    zauberschaden +1/
public override void getBattlecryEffect(Playfield p,Minion own,Minion target,int choice)
{
    p.drawACard(CardDB.cardName.unknown, own.own, false);
}
        public override void onAuraStarts(Playfield p, Minion own)
		{
            if (own.own)
            {
                p.spellpower++;
            }
            else
            {
                p.enemyspellpower++;
            }
		}

        public override void onAuraEnds(Playfield p, Minion m)
        {

            if (m.own)
            {
                p.spellpower--;
            }
            else
            {
                p.enemyspellpower--;
            }
        }

	}
}