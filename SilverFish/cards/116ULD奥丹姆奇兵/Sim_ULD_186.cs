using System.Linq;

namespace HREngine.Bots
{

    public class Sim_ULD_186 : SimTemplate
    {

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.ULD_205, ownplay, true);
        }
    }
}
