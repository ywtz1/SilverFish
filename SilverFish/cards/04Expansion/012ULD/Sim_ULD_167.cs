using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    /// <summary>
    /// Diseased Vulture
    /// Ⱦ����أ��
    /// </summary>
    public class Sim_ULD_167 : SimTemplate
    {
        /// <summary>
        /// After your hero takes damage on your turn, summon a random 3-Cost minion.
        /// ���Ӣ�����Լ��Ļغ��ܵ��˺�������ٻ�һ������ֵ����Ϊ��3�������ӡ�
        /// </summary>
        /// <param name="p"></param>
        /// <param name="triggerEffectMinion"></param>
        /// <param name="anzOwnMinionsGotDmg"></param>
        /// <param name="anzEnemyMinionsGotDmg"></param>
        /// <param name="anzOwnHeroGotDmg"></param>
        /// <param name="anzEnemyHeroGotDmg"></param>
        public override void onMinionGotDmgTrigger(Playfield p, Minion triggerEffectMinion, int anzOwnMinionsGotDmg, int anzEnemyMinionsGotDmg, int anzOwnHeroGotDmg, int anzEnemyHeroGotDmg)
        {
            int pos = (triggerEffectMinion.own) ? p.ownMinions.Count : p.enemyMinions.Count;
            if (p.ownHero.anzGotDmg > 0 && triggerEffectMinion.own)
            {
                p.CallKid(p.getRandomCardForManaMinion(3), pos, triggerEffectMinion.own);
            }
            else if (p.enemyHero.anzGotDmg > 0 && !triggerEffectMinion.own)
            {
                p.CallKid(p.getRandomCardForManaMinion(3), pos, triggerEffectMinion.own);
            }
        }
    }
}