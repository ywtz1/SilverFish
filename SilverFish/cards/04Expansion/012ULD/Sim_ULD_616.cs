using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ULD_616 : SimTemplate //泰坦造物跟班
    {
        // <b>战吼：</b>使一个友方随从获得+2生命值和嘲讽

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null)
            {
                p.minionGetBuffed(target, 0, 2);
                p.minionGetTaunt(target);
            }
        }
    }
}