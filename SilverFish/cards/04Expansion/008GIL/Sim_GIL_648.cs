using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    /// <summary>
    /// Chief Inspector
    /// �ܶ���
    /// </summary>
    class Sim_GIL_648 : SimTemplate //
    {
        /// <summary>
        /// Battlecry: Destroy all enemy Secrets.
        /// ս�𣺴ݻ����ез����ء�
        /// </summary>
        /// <param name="p"></param>
        /// <param name="own"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own) p.enemySecretList.Clear();
            else p.ownSecretsIDList.Clear();
        }
    }

}