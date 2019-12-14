using SilverFish.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
namespace HREngine.Bots
{


    public class varadd//自定义变量
    {

        //public static int lingjie=0;//莫瑞甘的灵界
        //public static CardDB.Card Echocardplayed=null;//回响
        //public static CardDB.Card Echocardplayed2=null;//回响
        public static int HeroPowerkilledaminion = 0;//英雄技能杀掉的随从数
        public static int HeroPowerhealDamage = 0;//英雄技能造成伤害
        public static int HeroPowerhealDamage2 = 0;//敌方
        public static int HeroPowerusedtime = 0;//英雄技能使用次数
        public static int HeroPowerusedtime2 = 0;
        public static CardDB.cardIDEnum OwnLastDiedMinion = CardDB.cardIDEnum.None;
        public static int numberofOwnDiedMinion = 0;//复活计数
        public static int numberofOwnDiedMinion2=0;
        public static int numberofDiedMinion = 0;
        public static int damagebyown = 0;//法术紫水晶
        public static int duoluozhixue= 0;//堕落之血 
        public static int fatiaojiqiren = 1;
        public static int fatiaojiqiren2 = 1;
        public static int ownHeroPowerExtraDamageturn = 0;//本回合英雄技能额外伤害
        public static int enemyHeroPowerExtraDamageturn = 0;
        public static bool penpen=false;//砰砰突袭

        //public static List<CardDB.cardIDEnum> OwnDiedMinion = new List<CardDB.cardIDEnum>();
        public static List<CardDB.cardIDEnum> frostmournekill = new List<CardDB.cardIDEnum>();
        public static Dictionary<CardDB.cardIDEnum, int> OwnDiedMinions = new Dictionary<CardDB.cardIDEnum, int>();
        public static Dictionary<CardDB.cardIDEnum, int> returntodecklist = new Dictionary<CardDB.cardIDEnum, int>();

        public static List<CardDB.cardIDEnum> yongwanlist = new List<CardDB.cardIDEnum>();//用了两张的卡
        //public static int ownHeroGotDmgbyown;
        public static CardDB.Card SpellLastPlayed = null;
        public static int nzhaomu=0;//招募数
        public static int nqiqiu=0;




        public static void gamestart()//初始化
        {
            Helpfunctions.Instance.ErrorLog("[varadd]游戏开始 初始化");

            //lingjie=0;//莫瑞甘的灵界
            //Echocardplayed=null;//回响
            //Echocardplayed2=null;//回响
            HeroPowerkilledaminion = 0;//英雄技能杀掉的随从数
            HeroPowerhealDamage = 0;//英雄技能造成伤害
            HeroPowerhealDamage2 = 0;//敌方
            HeroPowerusedtime = 0;//英雄技能使用次数
            HeroPowerusedtime2 = 0;
            OwnLastDiedMinion = CardDB.cardIDEnum.None;
            numberofOwnDiedMinion = 0;//复活计数
            numberofOwnDiedMinion2=0;
            numberofDiedMinion = 0;
            damagebyown = 0;//法术紫水晶
            duoluozhixue= 0;//堕落之血 
            fatiaojiqiren = 1;
            fatiaojiqiren2 = 1;
            ownHeroPowerExtraDamageturn = 0;//本回合英雄技能额外伤害
            enemyHeroPowerExtraDamageturn = 0;
            penpen=false;//砰砰突袭


            frostmournekill = new List<CardDB.cardIDEnum>();
            OwnDiedMinions = new Dictionary<CardDB.cardIDEnum, int>();
            returntodecklist = new Dictionary<CardDB.cardIDEnum, int>();

            yongwanlist = new List<CardDB.cardIDEnum>();//用了两张的卡
            //ownHeroGotDmgbyown;
            nzhaomu=0;//招募数
            nqiqiu=0;//祈求迦拉克隆


        }
        public static void VarSaveFrombestplay(Playfield p)//从bestplay中缓存数据 
        {
            HeroPowerkilledaminion = p.HeroPowerkilledaminion;//英雄技能杀掉的随从数
            HeroPowerhealDamage = p.HeroPowerhealDamage;//英雄技能造成伤害
            HeroPowerhealDamage2 = p.HeroPowerhealDamage2;//敌方
            HeroPowerusedtime = p.HeroPowerusedtime;//英雄技能使用次数
            HeroPowerusedtime2 = p.HeroPowerusedtime2;
            OwnLastDiedMinion = p.OwnLastDiedMinion;
            numberofOwnDiedMinion = p.numberofOwnDiedMinion;//复活计数
            numberofOwnDiedMinion2=p.numberofOwnDiedMinion2;
            numberofDiedMinion = p.numberofDiedMinion;
            damagebyown = p.damagebyown;//法术紫水晶
            duoluozhixue= p.duoluozhixue;//堕落之血 
            fatiaojiqiren = p.fatiaojiqiren;
            fatiaojiqiren2 = p.fatiaojiqiren2;
            ownHeroPowerExtraDamageturn = p.ownHeroPowerExtraDamageturn;//本回合英雄技能额外伤害
            enemyHeroPowerExtraDamageturn = p.enemyHeroPowerExtraDamageturn;
            penpen=p.penpen;//砰砰突袭


            frostmournekill = p.frostmournekill;
            OwnDiedMinions = p.OwnDiedMinions;
            returntodecklist = p.returntodecklist;

            yongwanlist = p.yongwanlist;//用了两张的卡
            //ownHeroGotDmgbyown;
            nzhaomu=p.nzhaomu;//招募数
            nqiqiu=p.nqiqiu;//祈求迦拉克隆
            if(nqiqiu>0)Helpfunctions.Instance.ErrorLog("[varadd]祈求迦拉克隆次数："+nqiqiu);
        }
        public static void PlayfieldLoadVar(Playfield p)
        {
            p.HeroPowerkilledaminion = HeroPowerkilledaminion;//英雄技能杀掉的随从数
            p.HeroPowerhealDamage = HeroPowerhealDamage;//英雄技能造成伤害
            p.HeroPowerhealDamage2 = HeroPowerhealDamage2;//敌方
            p.HeroPowerusedtime = HeroPowerusedtime;//英雄技能使用次数
            p.HeroPowerusedtime2 = HeroPowerusedtime2;
            p.OwnLastDiedMinion = OwnLastDiedMinion;
            p.numberofOwnDiedMinion = numberofOwnDiedMinion;//复活计数
            p.numberofOwnDiedMinion2=numberofOwnDiedMinion2;
            p.numberofDiedMinion = numberofDiedMinion;
            p.damagebyown = damagebyown;//法术紫水晶
            p.duoluozhixue= duoluozhixue;//堕落之血 
            p.fatiaojiqiren = fatiaojiqiren;
            p.fatiaojiqiren2 = fatiaojiqiren2;
            p.ownHeroPowerExtraDamageturn = ownHeroPowerExtraDamageturn;//本回合英雄技能额外伤害
            p.enemyHeroPowerExtraDamageturn = enemyHeroPowerExtraDamageturn;
            p.penpen=penpen;//砰砰突袭


            p.frostmournekill = frostmournekill;
            p.OwnDiedMinions = OwnDiedMinions;
            p.returntodecklist = returntodecklist;

            p.yongwanlist = yongwanlist;//用了两张的卡

            p.nzhaomu=nzhaomu;//招募数
            p.nqiqiu=nqiqiu;//祈求迦拉克隆
        }        


    }
}

