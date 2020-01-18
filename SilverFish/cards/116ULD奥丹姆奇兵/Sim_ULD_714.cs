using HREngine.Bots;
 

namespace Silverfish.cards._04Expansion._012ULD
{
    /// <summary>
    /// Penance
    /// 苦修
    /// </summary>
    public class Sim_ULD_714 : SimTemplate
    {
        /// <summary>
        /// Lifesteal Deal 3 damage to a minion.
        /// 吸血 对一个随从造成3点伤害
        /// </summary>
        /// <param name="p"></param>
        /// <param name="ownplay"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);

            int oldHp = target.Hp;
            p.minionGetDamageOrHeal(target, dmg);
            if (oldHp > target.Hp) p.applySpellLifesteal(oldHp - target.Hp, ownplay);
        }
    }
}