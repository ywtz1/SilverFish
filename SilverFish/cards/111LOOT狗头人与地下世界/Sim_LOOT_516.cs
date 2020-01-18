using System;
using System.Collections.Generic;
using System.Text;
//蛇发女妖佐拉错误设定（勉强能用）
namespace HREngine.Bots
{
	class Sim_LOOT_516 : SimTemplate //youthfulbrewmaster
	{

//    kampfschrei:/ lasst einen befreundeten diener vom schlachtfeld auf eure hand zurückkehren.
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if(target != null) p.minionReturnToHand(target, target.own, 0);
		}

	}
}