using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    /// <summary>
    /// Infested Goblin
    /// 招虫的地精
    /// </summary>
    class Sim_ULD_250 : SimTemplate
    {
        /// <summary>
        /// Taunt Deathrattle: Add two 1/1 Scarabs with Taunt to your hand.
        /// 嘲讽，亡语：将两张1/1并具有嘲讽的“甲虫”置入你的手牌。
        /// </summary>
        /// <param name="p"></param>
        /// <param name="m"></param>
        public override void onDeathrattle(Playfield p, Minion m)
        {


            p.drawACard(CardDB.cardIDEnum.ULD_215t, m.own, true);//甲虫 Scarab
            p.drawACard(CardDB.cardIDEnum.ULD_215t, m.own, true);
        }
    }
}