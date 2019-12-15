using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
class Sim_BOT_222 : SimTemplate //灵魂炸弹
{
 
    //   Deal $4 damage to a minion and the enemy hero.
 
    public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
    {
        int dmg = (ownplay) ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);
 
        p.minionGetDamageOrHeal(target, dmg);
 
        if (ownplay) p.minionGetDamageOrHeal(p.ownHero, dmg);
        else p.minionGetDamageOrHeal(p.enemyHero, dmg);
    }
 
 
}


}