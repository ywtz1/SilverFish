using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{



 class Sim_BOT_538 : SimTemplate //* 火花引擎
{
 //Battlecry: 将一张1/1并具有突袭的火花置入你的手牌.
 
 public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
 {
 p.drawACard(CardDB.cardIDEnum.BOT_102t, own.own, true);
 }
}

 
}