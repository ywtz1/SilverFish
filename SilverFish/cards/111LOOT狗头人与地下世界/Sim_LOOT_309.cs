using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_309 : SimTemplate //* Oaken Summons
    {
        //Gain 6 Armor. Recruit a minion that costs(4) or less.

        //CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOOT_048);
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetArmor(ownplay ? p.ownHero : p.enemyHero, 6);
            p.zhaomu(ownplay,TAG_RACE.INVALID,-8,0);

        }
    }
}