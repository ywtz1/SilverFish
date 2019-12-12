using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_050  : SimTemplate
	{
		        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		        {
		        	p.qiqiu();

		        }
	}
}