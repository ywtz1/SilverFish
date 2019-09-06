using System.Linq;

namespace HREngine.Bots
{

    public class Sim_ULD_157 : SimTemplate
    {

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
        	if(p.ownHeroAblility.card.name!=CardDB.cardName.heartofvirnaal)
            p.drawACard(CardDB.cardName.unknown, own.own, true);

        }
    }
}
