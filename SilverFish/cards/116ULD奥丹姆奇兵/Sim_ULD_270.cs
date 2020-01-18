using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    /// <summary>
    /// Sandhoof Waterbearer
    /// ɳ���ˮ��
    /// </summary>
    public class Sim_ULD_270 : SimTemplate
    {
        /// <summary>
        /// At the end of your turn, restore 5 Health to a damaged friendly character.
        /// ����ĻغϽ���ʱ��Ϊһ�����˵��ѷ���ɫ�ָ�5������ֵ��
        /// </summary>
        /// <param name="p"></param>
        /// <param name="triggerEffectMinion"></param>
        /// <param name="turnEndOfOwner"></param>
        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                int heal = (turnEndOfOwner) ? p.getMinionHeal(5) : p.getEnemyMinionHeal(5);
                List<Minion> temp = (turnEndOfOwner) ? p.ownMinions : p.enemyMinions;
                if (temp.Count >= 1)
                {
                    bool healed = false;
                    foreach (Minion m in temp)
                    {
                        if (m.wounded)
                        {
                            p.minionGetDamageOrHeal(m, -heal);
                            healed = true;
                            break;
                        }
                    }
                    if (!healed)
                    {
                        p.minionGetDamageOrHeal(turnEndOfOwner ? p.ownHero : p.enemyHero, -heal);
                    }
                }
                else
                {
                    p.minionGetDamageOrHeal(turnEndOfOwner ? p.ownHero : p.enemyHero, -heal);
                }
            }
        }
    }
}