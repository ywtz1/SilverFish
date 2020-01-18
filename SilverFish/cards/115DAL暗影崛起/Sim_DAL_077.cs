using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_077 : SimTemplate //* Flame Lance
	{
		//战吼：使一个友方鱼人获得剧毒。
		
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if(target!=null&&(TAG_RACE) target.handcard.card.race == TAG_RACE.MURLOC)
            {
                target.poisonous = true;
            }
		}
	}
}