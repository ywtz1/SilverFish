using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GIL_685 : SimTemplate //* Flamewaker
    {
        // 如果该随从的攻击力大于或等于3，便具有<b>嘲讽</b>和<b>吸血</b>。

        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool ownplay, Minion m)
        {
            if (m.Attack>2)
            {
                m.taunt=true;
                m.lifesteal=true;
            }
            else
            {
                m.taunt=false;
                m.lifesteal=false;

            }
        }
    }
}