using System.Linq;

namespace HREngine.Bots
{

    public class Sim_ULD_711p3 : SimTemplate
    {
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ULD_711t);//4/3

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
        	int place = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.CallKid(kid, place, ownplay, false);
        }
    }
}
