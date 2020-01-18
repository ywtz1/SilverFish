using System;
using System.Collections.Generic;
using System.Text;


namespace HREngine.Bots
{
class Sim_TRL_363 : SimTemplate //* Mecharoo
{
//Deathrattle: Summon a 1/1 Jo-E Bot.


CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TRL_363t);


public override void onDeathrattle(Playfield p, Minion m)
{
	int pos = !m.own ? p.ownMinions.Count : p.enemyMinions.Count;
p.callKid(kid, pos, !m.own);
}
}
}