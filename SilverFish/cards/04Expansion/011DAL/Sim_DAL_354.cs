using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_354 : SimTemplate //* 橡果人
	{
		//Deathrattle: 将两张1/1的"松鼠"置入你的手牌.				
		
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardIDEnum.DAL_354t, m.own, true);
			p.drawACard(CardDB.cardIDEnum.DAL_354t, m.own, true);
        }
	}
}