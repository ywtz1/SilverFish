﻿using HREngine.Bots;

namespace Silverfish.cards._04Expansion._006ICC
{
    class Sim_ICC_235 : SimTemplate //* Shadow Essence
    {
        // Summon a 5/5 copy of a random minion in your deck.

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_014); //King Mukla 5/5

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(kid, pos, ownplay, false);
        }
    }
}