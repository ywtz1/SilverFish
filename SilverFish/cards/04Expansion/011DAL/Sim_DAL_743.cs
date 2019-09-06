using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_743 : SimTemplate //* 荆棘帮斗猪
	{
        //突袭，亡语：召唤一个1/1的鱼人。

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DAL_743t);//鱼人
        
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.CallKid(kid, m.zonepos-1, m.own);           
        }
	}
}