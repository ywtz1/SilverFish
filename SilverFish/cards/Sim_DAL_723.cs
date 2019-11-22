using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_723  : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if(target!=null&&target.Attack<p.mana)
			{
				p.minionGetDestroyed(target);
				p.mana=0;
			}
		}
	}
}