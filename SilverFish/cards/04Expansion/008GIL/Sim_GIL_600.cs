using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GIL_600 : SimTemplate//静电震击对一个随从造成$2点伤害。<b>过载：</b>（1）</Tag>
    {


        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
        	if(target!=null)
        	{
        		p.minionGetDamageOrHeal(target, 2);
                p.ueberladung++;
        	}
           


            
            
        }

    }
}
