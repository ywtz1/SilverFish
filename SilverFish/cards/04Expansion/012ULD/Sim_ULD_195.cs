using System.Linq;

namespace HREngine.Bots
{

    public class Sim_ULD_195 : SimTemplate
    {

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardName.unknown, own.own);
        }
    }
}
