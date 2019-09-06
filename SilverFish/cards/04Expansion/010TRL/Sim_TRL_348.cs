using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_348 : SimTemplate //* Springpaw
	{
		//Rush, Battlecry: Can't attack heroes this turn. Add a 1/1 Lynx with rush to your hand.

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		
        {
            p.drawACard(CardDB.cardIDEnum.TRL_348t, own.own, true);
            own.cantAttackHeroes = true;
		}

        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (triggerEffectMinion.own == turnStartOfOwner) triggerEffectMinion.cantAttackHeroes = false;
        }
	}
}