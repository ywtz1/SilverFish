using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GIL_504: SimTemplate //* Bloodreaver Gul'dan
    {
        // Battlecry: Summon all friendly Demons that died this game.


        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.setNewHeroPower(CardDB.cardIDEnum.GIL_504h, ownplay); // Siphon Life
            if (ownplay) p.ownHero.armor += 5;
            else p.enemyHero.armor += 5;
            p.allMinionsGetDamage(3);
            p.ownAbilityReady = false;
            p.evaluatePenality -= 20;







                
        }
    }
}