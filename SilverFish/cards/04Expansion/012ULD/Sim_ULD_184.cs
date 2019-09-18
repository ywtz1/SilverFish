using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    /// <summary>
    /// Kobold Sandtrooper
    /// ��ͷ��ɳĮ����
    /// </summary>
    public class Sim_ULD_184 : SimTemplate
    {
        /// <summary>
        /// Deathrattle: Deal 3 damage to the enemy hero.
        /// ����Եз�Ӣ�����3���˺���
        /// </summary>
        /// <param name="p"></param>
        /// <param name="m"></param>
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.minionGetDamageOrHeal(m.own ? p.enemyHero : p.ownHero, 3);
        }
    }
}