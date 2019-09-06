using System.Linq;

namespace HREngine.Bots
{

    public class Sim_ULD_726 : SimTemplate
    {

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.EX1_287, ownplay, true);
        }
    }
}
