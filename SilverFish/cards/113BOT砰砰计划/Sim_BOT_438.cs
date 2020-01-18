using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_438 : SimTemplate //* Flame Lance
	{
		//Deal 8 damage to a minion.
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;

            foreach (Minion m in temp)
            {
                m.infest++;
            }
		}
	}
}