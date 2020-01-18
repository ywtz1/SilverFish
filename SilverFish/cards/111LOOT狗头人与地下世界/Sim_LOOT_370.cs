using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_370 : SimTemplate //* xunqiuzhudui
    {
        //. Recruit a minion 

        //CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOOT_048);
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            
            p.zhaomu(ownplay,TAG_RACE.INVALID,0,0);

        }
    }
}