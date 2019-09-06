using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_049 : SimTemplate //* 下水道渔人
	{
		//在你使用一张鱼人牌后，随机将一张鱼人牌置入你的手牌
		
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (triggerEffectMinion.own == wasOwnCard && (TAG_RACE)hc.card.race == TAG_RACE.MURLOC)
            {
                //p.drawACard(CardDB.cardName.unknown, wasOwnCard,true);
                p.drawACard(CardDB.cardIDEnum.CFM_310t, wasOwnCard,true);
            }
        }
        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            //if (p.ownMaxMana==2) p.evaluatePenality += 20;


        }
	}
}