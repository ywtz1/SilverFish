using System;
using System.Collections.Generic;
using System.Text;


namespace HREngine.Bots
{
class Sim_BOT_270: SimTemplate //* Giggling Inventor
{
// Battlecry: Summon two 1/2 Mechs with Taunt and Divine Shield.


CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GVG_085); //³³³³»úÆ÷ÈË


public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
{
	p.CallKid(kid, own.zonepos - 1, own.own);
	p.CallKid(kid, own.zonepos, own.own);
}
}
}