using System;
using System.Collections.Generic;
using System.Text;


namespace HREngine.Bots
{
class Sim_BOT_224 : SimTemplate //* Doubling Imp
{
// Battlecry: Summon a copy of this minion.


CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BOT_224); //Ë«ÉúÐ¡¹í


public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
{
	p.CallKid(kid, m.zonepos, m.own);
	List<Minion> temp = (m.own) ? p.ownMinions : p.enemyMinions;
	int count = 0;
	foreach (Minion mnn in temp)
	{
		if (mnn.name == CardDB.cardName.doublingimp && m.entitiyID != mnn.entitiyID && mnn.playedThisTurn)
		{
			mnn.setMinionToMinion(m);
			count++;
			if (count >= 1) break;
		}
	}
}
}
}