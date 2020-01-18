
namespace HREngine.Bots
{
    /// <summary>
    /// Drain Soul
    /// ��ȡ���
    /// </summary>
    class Sim_ICC_055: SimTemplate
    {
        /// <summary>
        /// Lifesteal Deal 2 damage to a minion.
        /// ��Ѫ ��һ�������� 2���˺���
        /// </summary>
        /// <param name="p"></param>
        /// <param name="ownplay"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);

            int oldHp = target.Hp;
            p.minionGetDamageOrHeal(target, dmg);
            if (oldHp > target.Hp) p.applySpellLifesteal(oldHp-target.Hp, ownplay);
        }
    }
}