using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    /// <summary>
    /// Vulpera Scoundrel
    /// ���˶��
    /// </summary>
    public class Sim_ULD_209 : SimTemplate
    {
        /// <summary>
        /// Battlecry: Discover a spell or pick a mystery choice.
        /// ս�𣺷���һ�ŷ����ƻ�ѡ��һ������ѡ�
        /// </summary>
        /// <param name="p"></param>
        /// <param name="own"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardName.thecoin, own.own, true);
        }
    }
}