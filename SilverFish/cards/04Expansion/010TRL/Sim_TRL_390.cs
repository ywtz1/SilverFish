using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_390 : SimTemplate //* 大胆的吞火者
	{
		//Your Hero Power deals 2 extra damage.
               
        public override void getBattlecryEffect(Playfield p,Minion own,Minion target,int choice)
		{
            if (own.own)p.ownHeroPowerExtraDamageturn+=2;
            else p.enemyHeroPowerExtraDamageturn+=2;
            if (own.own) p.ownHeroPowerExtraDamage+=2;
            else p.enemyHeroPowerExtraDamage+=2;

		}


	}
}