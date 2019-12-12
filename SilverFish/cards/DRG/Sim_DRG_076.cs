using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_076  : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (target != null)
			{
				target.setMinionToMinion(own);
			}
		}
	}
}