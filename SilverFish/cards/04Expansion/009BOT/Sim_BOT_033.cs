using System;
using System.Collections.Generic;
using System.Text;


namespace HREngine.Bots
{
class Sim_BOT_033: SimTemplate //* Boommaster Flark
{
// Battlecry: Summon a 0/2 Goblin Bombs.造成$2点伤害


CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BOT_031); //地精炸弹

public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
{
	if (target != null) p.minionGetDamageOrHeal(target, 2);
	int pos =(ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
p.CallKid(kid, pos, ownplay);

}
}
}