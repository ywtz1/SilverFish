using System;
using System.Collections.Generic;
using System.Text;


namespace HREngine.Bots
{
class Sim_TRL_541 : SimTemplate //* Mecharoo
{
//Deathrattle: Summon a 1/1 Jo-E Bot.


CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TRL_503t);


public override void onDeathrattle(Playfield p, Minion m)
{
	p.duoluozhixue++;
}
}
}