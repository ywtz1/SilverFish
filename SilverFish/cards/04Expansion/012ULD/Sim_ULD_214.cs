using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    /// <summary>
    /// Generous Mummy
    /// ������ľ����
    /// </summary>
    public class Sim_ULD_214 : SimTemplate
    {
        /// <summary>
        /// Reborn Your opponent's cards cost (1) less.
        /// ���� ����ֵĿ��Ʒ���ֵ���ļ��٣�1���㡣
        /// </summary>
        /// <param name="p"></param>
        /// <param name="own"></param>
        public override void onAuraStarts(Playfield p, Minion own)
        {
            if (!own.own) p.myCardsCostLess++;
        }

        public override void onAuraEnds(Playfield p, Minion own)
        {
            if (!own.own) p.myCardsCostLess--;
        }
    }
}