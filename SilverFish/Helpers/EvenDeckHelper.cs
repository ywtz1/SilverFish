using System.Collections.Generic;
using System.Linq;
using HREngine.Bots;

namespace SilverFish.Helpers
{
    public class EvenDeckHelper
    {

		private static bool _EvenDeckChecked;
		private static bool _IsEvenDeck;


		//[DefaultValue(false)]
        public static bool EvenDeckChecked 
		{
            get {  return _EvenDeckChecked; }
			set {  _EvenDeckChecked = value; }

        }
		//[DefaultValue(false)]

        public static bool IsEvenDeck 
		{
            get { return _IsEvenDeck; }
			set {  _IsEvenDeck=value; }
        }
        public static void Reset()
        {
            EvenDeckChecked = false;
            IsEvenDeck = false;
        }

        public static void EvenShamanCheck(Dictionary<CardDB.cardIDEnum, int> dictionary)
        {
            if (EvenDeckChecked)
            {
                return;
            }

            if (dictionary.Keys.Contains(CardDB.cardIDEnum.GIL_692))
            {
                bool isEvenShaman = true;
                foreach (var item in dictionary.Keys)
                {
                    var card = CardDB.Instance.getCardDataFromID(item);
                    if (card.cost % 2 != 0)
                    {
                        isEvenShaman = false;
                        break;
                    }
                }

                if (isEvenShaman)
                {
                    IsEvenDeck = true;
                }
            }

            EvenDeckChecked = true;
        }

        public static int GetOwnHeroPowerCost()
        {
            if (EvenDeckChecked && IsEvenDeck)
            {
                return 1;
            }

            return 2;
        }
    }
}
