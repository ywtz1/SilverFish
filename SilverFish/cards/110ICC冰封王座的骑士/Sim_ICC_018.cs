using HREngine.Bots;

namespace Silverfish.cards._04Expansion._006ICC
{
    class Sim_ICC_018: SimTemplate //* Phantom Freebooter
    {
        // Battlecry: Gain stats equal to your weapon's.

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.minionGetBuffed(own, 1, 1);
            if (own.own)
            {
                own.Attack += p.ownWeapon.Angr;
                own.Hp += p.ownWeapon.Durability;
                own.maxHp += p.ownWeapon.Durability;
            }
            else
            {
                own.Attack += p.enemyWeapon.Angr;
                own.Hp += p.enemyWeapon.Durability;
                own.maxHp += p.enemyWeapon.Durability;
            }
        }
    }
}
