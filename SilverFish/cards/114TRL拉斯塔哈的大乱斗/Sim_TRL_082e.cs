using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
class Sim_TRL_082e:SimTemplate //* spider bomb
{

	public override void onDeathrattle(Playfield p,Minion m)
	{
		int pos = (m.own) ? p.ownMinions.Count : p.enemyMinions.Count;

		p.callKid(p.getRandomCardForManaMinion(m.handcard.card.cost+1), pos, m.own);

	}
}
}