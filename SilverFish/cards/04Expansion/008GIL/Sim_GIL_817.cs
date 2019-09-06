using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GIL_817: SimTemplate //* Happy Ghoul
    {
        // Costs (0) if your hero was healed this turn.
        public override void onACharGotHealed(Playfield p, Minion triggerEffectMinion, int charsGotHealed)
        {

            if (charsGotHealed <0 )
            {
                    triggerEffectMinion.divineshild = true;
            }
        }

    }
}