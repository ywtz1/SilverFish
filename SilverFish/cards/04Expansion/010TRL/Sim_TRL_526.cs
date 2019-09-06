using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TRL_526: SimTemplate //* Spiteful Summoner
    {
        // Battlecry: Reveal a spell from your deck.Summon a random minion with the same Cost.
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            int dmg = (own.own) ? p.getHeroPowerDamage(1) : p.getEnemyHeroPowerDamage(1);
            p.allMinionsGetDamage(dmg);


        }
    }
}