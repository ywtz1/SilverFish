using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
class Sim_BOT_508 : SimTemplate //* 死金药剂
{
    // 触发一个友方随从的亡语两次.
 
    public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
    {
        p.doDeathrattles(new List<Minion>() { target });
        p.doDeathrattles(new List<Minion>() { target });
    }
}


}