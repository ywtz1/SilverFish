using System;
using System.Collections.Generic;
using System.Text;


namespace HREngine.Bots
{
class Sim_BOT_445 : SimTemplate //* Mecharoo
{
//Deathrattle: Summon a 1/1 Jo-E Bot.


CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BOT_445t);


public override void onDeathrattle(Playfield p, Minion m)
{
p.callKid(kid, m.zonepos, m.own);
}
}
}