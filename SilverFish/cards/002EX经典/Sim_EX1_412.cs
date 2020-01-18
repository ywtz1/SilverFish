using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_412 : SimTemplate //ragingworgen
	{

//    wutanfall:/ windzorn/ und +1 angriff
        public override void onEnrageStart(Playfield p, Minion m)
        {
            m.Attack++;
            p.minionGetWindfurry(m);
        }

        public override void onEnrageStop(Playfield p, Minion m)
        {
            m.Attack--;
            m.windfury = false;
            if (m.numAttacksThisTurn == 1) m.Ready = false;
        }


	}
}