using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULD_185 : SimTemplate //神殿狂战士
	{

//    "<b>复生</b>\n受伤时具有+2\n攻击力。"

        public override void onEnrageStart(Playfield p, Minion m)
        {
            m.Attack += 2;
        }

        public override void onEnrageStop(Playfield p, Minion m)
        {
            m.Attack -= 2;
        }

	}
}