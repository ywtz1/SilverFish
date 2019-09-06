using System;
using System.Collections.Generic;
using System.Text;


namespace HREngine.Bots
{
class Sim_BOT_031 : SimTemplate //* Goblin Bomb
{
// Deathrattle: Deal 2 damage to the enemy hero.


public override void onDeathrattle(Playfield p, Minion m)
{
p.minionGetDamageOrHeal(m.own ? p.enemyHero : p.ownHero, 2);
}
}
}