using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_018 : SimTemplate //铁钩掠夺者
//如果你的生命值小于或等于15点，则获得+3/+3和<b>嘲讽</b>。
{

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{

                   if(p.ownHero.HealthPoints <=15)
                   {
                   	own.taunt=true;
                   	p.minionGetBuffed(own,3,3);
                   }

		}

	}
}