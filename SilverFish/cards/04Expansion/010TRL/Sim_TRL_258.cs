using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TRL_258 : SimTemplate //* Psychicscream
    {
        //fxxk

      public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
      {
        if(p.enemyMinions.Count+p.ownMinions.Count > 1)
        {


         Minion aa = null;
         Minion hh = null;
         int a=0,h=0;

         foreach (Minion m in p.enemyMinions)
         {
          if(m.Attack <a)
          {
            a=m.Attack;
            
            aa=m;
          }
          if(m.HealthPoints>h)
          {
            h=m.HealthPoints;
            hh=m;
          }       
        }
        foreach (Minion m in p.ownMinions)
        {
          if(m.Attack <a)
          {
            a=m.Attack;
            
            aa=m;
          }
          if(m.HealthPoints>h)
          {
            h=m.HealthPoints;
            hh=m;
          }       
        }

        foreach (Minion m in p.enemyMinions)
        {
          if(m==hh)
          {
            m.HealthPoints-=a;
            continue;
            
          }

          p.minionGetDestroyed(m);
        }
        foreach (Minion m in p.ownMinions)
        {
          if(m==hh)
          {
            m.HealthPoints-=a;
            continue;
            
          }
          p.minionGetDestroyed(m);
        }
      }


      

    }
  }
}