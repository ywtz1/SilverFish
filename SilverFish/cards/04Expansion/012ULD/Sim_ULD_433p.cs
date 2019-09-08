using System.Linq;

namespace HREngine.Bots
{

    public class Sim_ULD_433p : SimTemplate
    {

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardName.unknown,ownplay,true);
            int i = p.owncards.Count - 1;
            p.owncards[i].manacost -=2;

        }
    }
}
