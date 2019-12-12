using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_099t2  : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
        	int posi = own.own ? p.ownMinions.Count : p.enemyMinions.Count;
                    p.CallKid(CardDB.cardIDEnum.DRG_099t2t, posi, own.own, false);
        }
    }
}