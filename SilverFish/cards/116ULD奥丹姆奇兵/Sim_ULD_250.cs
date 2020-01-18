using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    /// <summary>
    /// Infested Goblin
    /// �г�ĵؾ�
    /// </summary>
    class Sim_ULD_250 : SimTemplate
    {
        /// <summary>
        /// Taunt Deathrattle: Add two 1/1 Scarabs with Taunt to your hand.
        /// �������������1/1�����г���ġ��׳桱����������ơ�
        /// </summary>
        /// <param name="p"></param>
        /// <param name="m"></param>
        public override void onDeathrattle(Playfield p, Minion m)
        {


            p.drawACard(CardDB.cardIDEnum.ULD_215t, m.own, true);//�׳� Scarab
            p.drawACard(CardDB.cardIDEnum.ULD_215t, m.own, true);
        }
    }
}