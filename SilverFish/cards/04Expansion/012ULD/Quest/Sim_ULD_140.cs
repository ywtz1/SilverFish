﻿using System.Linq;

namespace HREngine.Bots
{

    public class Sim_ULD_140 : SimTemplate
    {

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.evaluatePenality-=100;

        }
    }
}
