using System;
using System.Collections.Generic;
using System.Text;


namespace HREngine.Bots
{
class Sim_TRL_012: SimTemplate //* Boommaster Flark
{
// Battlecry: Summon four 0/2 Goblin Bombs.


CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_050); //µØ¾«Õ¨µ¯






public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
{
	if(target==null)return;
	p.minionGetDamageOrHeal(target, 2);
	if(target.HealthPoints <2)
	{
		int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;

		p.CallKid(kid, pos, ownplay);

	}



}
}
}