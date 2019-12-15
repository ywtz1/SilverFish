using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_509 : SimTemplate //* 丧钟机器人
	{
	 //亡语:从你的牌库中抽一张具有亡语的随从牌.
	 
	 CardDB.Card c = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GIL_616t2);
	 
	 public override void onDeathrattle(Playfield p, Minion m)
	 {
	 p.drawACard(CardDB.cardName.unknown, m.own);
	 }
	}


}