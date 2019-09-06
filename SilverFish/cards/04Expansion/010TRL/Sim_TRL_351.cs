using System;
using System.Collections.Generic;
using System.Text;


namespace HREngine.Bots
{
class Sim_TRL_351: SimTemplate //* Boommaster Flark
{
// Battlecry: Summon four 0/2 Goblin Bombs.


CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TRL_351t); //µØ¾«Õ¨µ¯






public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
{
int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
p.CallKid(kid, pos, ownplay);
p.CallKid(kid, pos, ownplay);
p.CallKid(kid, pos, ownplay);
if (ownplay) p.ueberladung += 3;
}
}
}