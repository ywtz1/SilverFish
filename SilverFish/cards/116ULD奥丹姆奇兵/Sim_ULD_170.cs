using System.Linq;

namespace HREngine.Bots
{

    public class Sim_ULD_170 : SimTemplate
    {

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
        	if(own.own)
        	{
        		bool t=false;
        	 	foreach (Minion maa in p.ownMinions)
                {
                    if(maa.name==CardDB.cardName.facelesslackey ||maa.name==CardDB.cardName.koboldlackey ||maa.name==CardDB.cardName.titaniclackey 
                        ||maa.name==CardDB.cardName.witchylackey ||maa.name==CardDB.cardName.goblinlackey ||maa.name==CardDB.cardName.ethereallackey)
                    {
                        t=true; 
                        break;
                    }
                }

                if(t&& target!=null)p.minionGetDamageOrHeal(target, 3);
                if(!t)p.evaluatePenality += 10;
        	}
        	//if(own.own&& target!=null)p.minionGetDamageOrHeal(target, 3);

        }
    }
}
