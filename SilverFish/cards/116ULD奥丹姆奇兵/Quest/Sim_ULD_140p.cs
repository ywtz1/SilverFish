using System.Linq;

namespace HREngine.Bots
{

    public class Sim_ULD_140p : SimTemplate
    {

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardName.unknown,ownplay,true);
        }
    }
}
