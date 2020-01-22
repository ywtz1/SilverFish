namespace HREngine.Bots
{
	class Sim_BOT_407 : SimTemplate //* 雷云元素 Thunderhead
	{
		//[x]After you play a card with<b>Overload</b>, summon two1/1 Sparks with <b>Rush</b>.
		//在你使用一张<b>过载</b>牌后，召唤两个1/1并具有<b>突袭</b>的“火花”。
		//
		        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BOT_102t);//

		public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
		{
			if (hc.card.overload >0 && wasOwnCard == triggerEffectMinion.own)
            {
                p.callKid(kid, triggerEffectMinion.zonepos, triggerEffectMinion.own);
            	p.callKid(kid, triggerEffectMinion.zonepos - 1, triggerEffectMinion.own);
            }

		}



	}
}