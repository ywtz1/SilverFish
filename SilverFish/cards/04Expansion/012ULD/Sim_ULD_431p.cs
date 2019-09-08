using System.Linq;

namespace HREngine.Bots
{

    public class Sim_ULD_431p : SimTemplate
    {

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null && target.own)
            {
                int position = p.ownMinions.Count;
                p.CallKid(target.handcard.card, position, true);
                p.ownMinions[position].setMinionToMinion(target);
                target.Attack=2;target.maxHp=2;target.HealthPoints=2;
            }
        }
    }
}
