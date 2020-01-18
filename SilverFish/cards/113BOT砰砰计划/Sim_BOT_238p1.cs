using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_BOT_238p1: SimTemplate //* Siphon Life
    {
        // Hero Power: 造成$3点伤害。每回合切换

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getHeroPowerDamage(3) : p.getEnemyHeroPowerDamage(3);
            p.minionGetDamageOrHeal(target, dmg);

        }
    }
}