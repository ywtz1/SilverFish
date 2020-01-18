using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GIL_203 : SimTemplate //* Cinderstorm
    {
        //Deal $5 damage randomly split among all enemies.

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.loatheb = true;
        }
    }
}