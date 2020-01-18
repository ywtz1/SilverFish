using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GIL_580: SimTemplate //城镇公告员
    {
        // 从你的牌库抽一张具有突袭的随从牌。

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardName.unknown, own.own);
        }
    }
}