using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_291 : SimTemplate //* Flame Lance
	{
		//从你的牌库中抽一张法力值消耗大于或等于（5）的法术牌
		
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{

            

                p.drawACard(CardDB.cardName.unknown, own.own,true);
                //p.evaluatePenality-=10;
            
		}
	}
}