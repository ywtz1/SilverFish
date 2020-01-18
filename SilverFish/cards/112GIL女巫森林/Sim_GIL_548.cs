using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
  class Sim_GIL_548 : SimTemplate //Book of Specters
  {

//  Draw 3 cards. Discard any spells drawn.

    public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
    {
      p.drawACard(CardDB.cardName.unknown, ownplay);
      p.drawACard(CardDB.cardName.unknown, ownplay);
      

      bool alunethInHand = false;
      if (p.ownWeapon.Durability >= 1)
      {
        if (ownplay) p.evaluatePenality += 40;
      }

      else
      {
        foreach (Handmanager.Handcard hc in p.owncards)
        {
          if (hc.card.name == CardDB.cardName.aluneth)
          {
            alunethInHand = true;
            break;
          }
        }

        if (alunethInHand && p.ownMaxMana > 5 && ownplay)
        {
          p.evaluatePenality += 20;
        }
      }
    }
  }
}