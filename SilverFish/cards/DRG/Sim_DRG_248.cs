using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_248  : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if(target==null)return;
            if(target!=null&& !target.own)
            {
            	p.minionGetFrozen(target);
            	p.qiqiu();
        	}

    	}
	}
}