using System.Linq;

namespace HREngine.Bots
{

    public class Sim_ULD_158 : SimTemplate
    {

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.allMinionOfASideGetDamage(!own.own, 1);
        }
    }
}
