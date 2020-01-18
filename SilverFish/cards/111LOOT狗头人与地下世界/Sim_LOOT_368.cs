using System;
using System.Collections.Generic;
using System.Text;


namespace HREngine.Bots
{
    class Sim_LOOT_368 : SimTemplate //* Voidlord
    {
        //


        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_065), m.zonepos - 1, m.own);
            p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_065), m.zonepos, m.own);
            p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_065), m.zonepos + 1, m.own);
        }
    }
}
