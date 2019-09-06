using System;
using System.Collections.Generic;
using System.Text;


namespace HREngine.Bots
{
class Sim_BOT_532: SimTemplate //* Explodinator
{
// Battlecry: Summon two 0/2 Goblin Bombs.


CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BOT_031); //µØ¾«Õ¨µ¯


public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
{
p.CallKid(kid, own.zonepos - 1, own.own); //1st left
p.CallKid(kid, own.zonepos, own.own);
}
}
}