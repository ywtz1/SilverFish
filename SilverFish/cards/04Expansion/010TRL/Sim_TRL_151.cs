using System;
using System.Collections.Generic;
using System.Text;


namespace HREngine.Bots
{
class Sim_TRL_151: SimTemplate //* Former Champ
//мкрш╧з╬Э
{
// Battlecry: Summon four 5/5.


CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TRL_151t); //5/5.






	public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
	{


		p.CallKid(kid, own.zonepos - 1, own.own);

	}



	
}
}