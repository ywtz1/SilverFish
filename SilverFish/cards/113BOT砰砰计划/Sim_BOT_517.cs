using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
class Sim_BOT_517 : SimTemplate //* 引力翻转
{
 // Battlecry: Swap the Attack and Health of a minion.
 
 public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
 {
 if (target != null) p.minionSwapAngrAndHP(target);
 }
}

}