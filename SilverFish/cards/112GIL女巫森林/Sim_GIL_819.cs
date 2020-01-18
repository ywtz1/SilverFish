using System;
using System.Collections.Generic;
using System.Text;


namespace HREngine.Bots
{
class Sim_GIL_819: SimTemplate //* Witchs Cauldron
{
// After a friendly minions dies,add a random Shaman spell to your hand.





public override void onMinionDiedTrigger(Playfield p, Minion m, Minion diedMinion)
{
int diedMinions = (m.own) ? p.tempTrigger.ownMinionsDied : p.tempTrigger.enemyMinionsDied;
if (diedMinions == 0) return;
int residual = (p.pID == m.pID) ? diedMinions - m.extraParam2 : diedMinions;
m.pID = p.pID;
m.extraParam2 = diedMinions;
for (int i = 0; i < residual; i++)
{
	if(m.own)
    p.drawACard(CardDB.cardName.unknown, true, true);
    else 
    p.drawACard(CardDB.cardName.unknown, false, true);

}
}
}
}