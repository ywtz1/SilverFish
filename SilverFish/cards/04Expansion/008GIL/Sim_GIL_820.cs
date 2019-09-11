using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{

    public class Sim_GIL_820 : SimTemplate // 沙德沃克
    {
        CardDB cdb = CardDB.Instance;
        CardDB.Card c = null;
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                int pen=0;
                Minion VirtualTarget =null;
                foreach (Minion m in p.ownMinions)//防止不打先放沙德沃克
                {
                    if(m.Ready)p.evaluatePenality +=5;

                }
                foreach (KeyValuePair<CardDB.cardIDEnum, int> e in Probabilitymaker.Instance.ownCardsOut)
                {
                    c = cdb.getCardDataFromID(e.Key);
                    
                    if(c.battlecry)
                    {
                        //pen+=10;
                        //if(e.Value>1)pen+=5*(e.Value-1);
                        VirtualTarget =(p.ownMinions.Count!=0||p.ownMinions.Count!=0)?(p.ownMinions.Count>=p.ownMinions.Count? p.searchRandomMinion(p.ownMinions, searchmode.searchHighestAttack):p.searchRandomMinion(p.enemyMinions, searchmode.searchHighestAttack)):p.enemyHero;

                        c.CardSimulation.getBattlecryEffect(p,own,VirtualTarget,choice);
                        pen++;

                    }

                }
                foreach (KeyValuePair<CardDB.cardIDEnum, int> e in Probabilitymaker.Instance.ownCardsOut)
                {
                    c = cdb.getCardDataFromID(e.Key);
                    if(c.battlecry&&e.Value>1)
                    {
                        //pen+=10;
                        //if(e.Value>1)pen+=5*(e.Value-1);
                        VirtualTarget =(p.ownMinions.Count!=0||p.ownMinions.Count!=0)?(p.ownMinions.Count>=p.ownMinions.Count? p.searchRandomMinion(p.ownMinions, searchmode.searchHighestAttack):p.searchRandomMinion(p.enemyMinions, searchmode.searchHighestAttack)):p.enemyHero;

                        for(int i = 1;i<e.Value;i++)
                        {
                            c.CardSimulation.getBattlecryEffect(p,own,VirtualTarget,choice);
                            pen++;

                        }

                    }

                }
                p.evaluatePenality-=pen;

            }
        }
    }

}