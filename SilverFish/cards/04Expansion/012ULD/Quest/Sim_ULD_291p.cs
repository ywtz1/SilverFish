using System.Linq;

namespace HREngine.Bots
{

    public class Sim_ULD_291p : SimTemplate
    {

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
        	p.evaluatePenality-=1;
        	if(p.cardsPlayedThisTurn!=0) p.evaluatePenality+=8;//防止不第一个打

        }
    }
}
