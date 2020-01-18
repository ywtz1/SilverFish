using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_287t : SimTemplate //counterspell
	{
        //todo secret
//    geheimnis:/ wenn euer gegner einen zauber wirkt, kontert/ ihr ihn.
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.evaluatePenality-=30;
        }

	}
}