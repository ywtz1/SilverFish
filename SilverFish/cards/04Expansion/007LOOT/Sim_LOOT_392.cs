using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_392 : SimTemplate//* Twig of the World Tree
    {
        //Deathrattle: Gain 10 Mana Crystals.

        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOOT_392);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
        }

        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.own)
            {
                p.mana = 10;
                p.ownMaxMana = 10;
            }
            else
            {
                p.mana = 10;
                p.enemyMaxMana = 10;
            }
        }
    }
}
