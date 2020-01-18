using HREngine.Bots;

namespace Silverfish.cards._04Expansion._006ICC
{
    class Sim_ICC_850: SimTemplate //* Shadowblade
    {
        // Battlecry: Your hero is Immune this turn.

        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ICC_850);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);

            if (ownplay) p.ownHero.immune = true;
            else p.enemyHero.immune = true;
        }
    }
}