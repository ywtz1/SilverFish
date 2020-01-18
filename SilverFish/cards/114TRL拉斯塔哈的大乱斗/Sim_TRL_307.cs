using System;
using System.Collections.Generic;
using System.Text;


namespace HREngine.Bots
{
class Sim_TRL_307: SimTemplate //* Boommaster Flark
{
// Battlecry: Summon four 0/2 Goblin Bombs.



public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
{
	if(target!=null)
    p.minionGetDamageOrHeal(target, -4);
    p.drawACard (CardDB.cardName.unknown,ownplay,false);




}
}
}