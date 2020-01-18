using HREngine.Bots;

namespace Silverfish.cards._04Expansion._006ICC
{
    class Sim_ICC_050: SimTemplate //* Webweave
    {
        // Summon two 1/2 Poisonous Spiders

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ICC_051t); //Poisonous Spider

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;

            p.callKid(kid, pos, ownplay, false);
            p.callKid(kid, pos, ownplay);
        }
    }
}