using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GIL_661 : SimTemplate//holy nova
    {
        //todo make it better :D
        //FÃ¼gt allen Feinden $2 Schaden zu. Stellt bei allen befreundeten Charakteren #2 Leben wieder her.
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int heal = (ownplay) ? p.getSpellHeal(6) : p.getEnemySpellHeal(6) ;
            p.allCharsOfASideGetDamage(ownplay, -heal);
            
        }

    }
}
