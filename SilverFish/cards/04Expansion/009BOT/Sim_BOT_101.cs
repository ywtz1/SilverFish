using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
class Sim_BOT_101 : SimTemplate //星界裂隙
{
 
    //    抽两张牌.
    public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
    {
        p.drawACard(CardDB.cardName.unknown, true);
        p.drawACard(CardDB.cardName.unknown, true);
 
    }
 
 
}


}