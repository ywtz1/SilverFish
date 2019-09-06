using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_155 : SimTemplate //赤环蜂
	{

//    <b>突袭</b>\n受伤时具有+3攻\n击力。",

        public override void onEnrageStart(Playfield p, Minion m)
        {
            m.Attack += 3;
        }

        public override void onEnrageStop(Playfield p, Minion m)
        {
            m.Attack -= 3;
        }

	}
}