using System;
using System.Collections.Generic;
using System.Text;


namespace HREngine.Bots
{
class Sim_TRL_253 : SimTemplate //* Doubling Imp
{
// Battlecry: Summon a copy of this minion.


CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TRL_253); 


public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
{
	int count = (m.own) ? p.ownMinions.Count : p.enemyMinions.Count;
	for(int i=7;i > count;i--)
	p.CallKid(kid, m.zonepos, m.own);

	List<Minion> temp = (m.own) ? p.ownMinions : p.enemyMinions;
	foreach (Minion mnn in temp)
	{
		if (mnn.name == CardDB.cardName.hireekthebat && m.entitiyID != mnn.entitiyID && mnn.playedThisTurn)
		{
			mnn.setMinionToMinion(m);
		}
	}
}
}
}