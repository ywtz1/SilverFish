using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{

    public class Sim_GIL_820 : SimTemplate // É³µÂÎÖ¿Ë
    {
        CardDB cdb = CardDB.Instance;
        CardDB.Card c = null;
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                int pen=0;
                Minion VirtualTarget =null;
                foreach (KeyValuePair<CardDB.cardIDEnum, int> e in Probabilitymaker.Instance.ownCardsOut)
                {
                    c = cdb.getCardDataFromID(e.Key);
                    
                    if(c.battlecry)
                    {
                        //pen+=10;
                        //if(e.Value>1)pen+=5*(e.Value-1);
                        VirtualTarget =(p.ownMinions.Count!=0||p.ownMinions.Count!=0)?(p.ownMinions.Count>=p.ownMinions.Count? p.searchRandomMinion(p.ownMinions, searchmode.searchHighestAttack):p.searchRandomMinion(p.enemyMinions, searchmode.searchHighestAttack)):p.enemyHero;

                        c.CardSimulation.getBattlecryEffect(p,own,VirtualTarget,choice);
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
                        }

                    }

                }
                p.evaluatePenality-=pen;

            }
        }
    }

}