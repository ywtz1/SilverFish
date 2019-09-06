using System;
using System.Collections.Generic;
using System.Text;namespace HREngine.Bots
{
class Sim_BOT_447 : SimTemplate //*Crystallizer 晶化师
{
//Deal 5 damage to your hero. Gain 5 armour.

public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
{
p.minionGetDamageOrHeal(own.own ? p.ownHero : p.enemyHero, 5);
p.minionGetArmor(own.own ? p.ownHero : p.enemyHero, 5);
}
}
}