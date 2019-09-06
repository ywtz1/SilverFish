using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_184 : SimTemplate //* Grizzled Guardian
    {
        //亡语：招募</b>一个法力值消耗为（8）点的随从。</Tag>


        public override void onDeathrattle(Playfield p, Minion m)
        {
            
           p.zhaomu(m.own,TAG_RACE.INVALID,8,0);

        }
    }
}