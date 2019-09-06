using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{

    public class Sim_GIL_623 : SimTemplate //»ÒÐÜ
    {

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            own.maxHp=12-p.enemyAnzCards ; //p.enemycards.count;
        }
    }

}