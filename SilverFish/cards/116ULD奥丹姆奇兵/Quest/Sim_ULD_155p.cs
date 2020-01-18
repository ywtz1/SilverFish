using System.Linq;

namespace HREngine.Bots
{

    public class Sim_ULD_155p : SimTemplate
    {

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.allMinionOfASideGetBuffed(ownplay, 2, 0);
        }
    }
}
