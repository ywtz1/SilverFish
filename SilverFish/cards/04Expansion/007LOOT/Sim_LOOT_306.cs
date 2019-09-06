using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_306 : SimTemplate //* Grizzled Guardian
    {
        //亡语：</b><b>招募</b>一个恶魔。</Tag>


        public override void onDeathrattle(Playfield p, Minion m)
        {
            
           p.zhaomu(m.own,TAG_RACE.DEMON,0,0);

        }
    }
}