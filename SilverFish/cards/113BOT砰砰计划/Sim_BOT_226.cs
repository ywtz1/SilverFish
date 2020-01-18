using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
class Sim_BOT_226 : SimTemplate //* 虚魂破坏者
{
    //战吼：在本回合中，你的英雄每受到一点伤害，便获得+1攻击力.
 
    public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
    {
        if (p.ownHero.anzGotDmg > 0)
        {
            p.minionGetBuffed(own, 1 * p.ownHero.anzGotDmg, 1 * p.ownHero.anzGotDmg);
        }
        else if (p.enemyHero.anzGotDmg > 0)
        {
            p.minionGetBuffed(own, 1 * p.enemyHero.anzGotDmg, 1 * p.enemyHero.anzGotDmg);
        }
    }
}


}