using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots

{
    /// <summary>
    /// Pharaoh's Blessing
    /// ����ף��
    /// </summary>
    public class Sim_ULD_143 : SimTemplate
    {
        /// <summary>
        /// Give a minion +4/+4, Divine Shield, and Taunt.
        /// ʹһ����ӻ��+4/+4��ʥ���Լ�����
        /// </summary>
        /// <param name="p"></param>
        /// <param name="ownplay"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetBuffed(target, 4, 4);
            target.divineshild = true;
            if (!target.taunt)
            {
                target.taunt = true;
                if (target.own) p.anzOwnTaunt++;
                else p.anzEnemyTaunt++;
            }
        }
    }
}