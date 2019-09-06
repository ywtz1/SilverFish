using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    /// <summary>
    /// Lord Godfrey
    /// �߸���ѫ��
    /// </summary>
    class Sim_GIL_825: SimTemplate //* Defile
    {
        /// <summary>
        /// Battlecry: Deal 2 damage to all other minions. If any die, repeat this Battlecry.
        /// ս�𣺶���������������2���˺��������������������ظ���ս��Ч����
        /// </summary>
        /// <param name="p"></param>
        /// <param name="m"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            int dmg = (own.own) ? p.getMinionHeal(2) : p.getEnemyMinionHeal(2);
            int count = p.tempTrigger.ownMinionsDied + p.tempTrigger.enemyMinionsDied;
            int nextcount = 0;
            bool repeat;
            do
            {
                repeat = false;
                p.allMinionsGetDamage(dmg);
                nextcount = p.tempTrigger.ownMinionsDied + p.tempTrigger.enemyMinionsDied;
                if (nextcount > count) repeat = true;
                count = nextcount;
                if (count == (p.ownMinions.Count + p.enemyMinions.Count)) break;
            }
            while (repeat);
        }
    }
}