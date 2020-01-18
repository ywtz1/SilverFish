using HREngine.Bots;

namespace Silverfish.cards._04Expansion._006ICC
{
    class Sim_ICC_853: SimTemplate //* Prince Valanar
    {
        // Battlecry: If your deck has no 4-Cost cards, gain Lifesteal and Taunt.

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own && p.prozis.getDeckCardsForCost(4) == CardDB.cardIDEnum.None)
            {
                own.lifesteal = true;
                own.taunt = true;
                p.anzOwnTaunt++;
            }
        }
    }
}