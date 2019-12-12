﻿using HREngine.Bots;

namespace SilverFish.cards._04Expansion._006ICC
{
    class Sim_ICC_049 : SimTemplate //* Toxic Arrow
    {
        // Deal 2 damage to a minion. If it survives, give it Poisonous.

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);

            p.minionGetDamageOrHeal(target, dmg);
            if (target!=null&&target.HealthPoints > 0) target.poisonous = true;
        }
    }
}