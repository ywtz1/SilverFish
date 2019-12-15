using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
class Sim_BOT_529 : SimTemplate //* 真言术：仿
{
    //选择一个友方随从，召唤一个该随从的5/5复制.
 
    public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
    {
        List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
        int pos = temp.Count;
        if (pos < 7)
        {
            p.callKid(target.handcard.card, pos, ownplay);
            temp[pos].setMinionToMinion(target);
            p.ownMinions[pos].HealthPoints = 5;
            p.ownMinions[pos].HealthPoints = 5;
            p.ownMinions[pos].maxHp = 5;
        }
    }
}


}