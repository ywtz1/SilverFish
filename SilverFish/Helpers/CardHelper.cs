using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using HREngine.Bots;
using Silverfish.cards._04Expansion._012ULD;

using Silverfish.cards._04Expansion._006ICC;
using Silverfish.cards._04Expansion._008GIL;
namespace Silverfish.Helpers
{
    public class CardHelper
    {
        private static readonly Type[] AssemblyTypes;

        static CardHelper()
        {
            var assembly = Assembly.GetExecutingAssembly();
            AssemblyTypes = assembly.GetTypes();
        }

        public static SimTemplate Getsim_card(CardDB.cardIDEnum tempCardIdEnum)
        {
            var result = new SimTemplate();


            var className = ("Sim_"+tempCardIdEnum);
            var list = GetTypeByName(className);
            if (list.Count != 1)
            {
                if (list.Count >= 2)
                {
                    var content = string.Join(",", list.Select(x => x.FullName));
                    throw new Exception("Find multiple card simulation class for "+tempCardIdEnum +":"+ content);
                }
            }
            else
            {
                var type = list[0];
                var simTemplateInstance = Activator.CreateInstance(typeof(SimTemplate),className);
                if (simTemplateInstance is SimTemplate)
                {
					
                    result = Activator.CreateInstance(type) as SimTemplate;
                    //return getSimCard(tempCardIdEnum);
                }
                else
                {
                    throw new Exception("class " + className + " should inherit from " +typeof(SimTemplate));
                }
            }

            return result;
        }

        /// <summary>
        /// Gets a all Type instances matching the specified class name with just non-namespace qualified class name.
        /// </summary>
        /// <param name="className">Name of the class sought.</param>
        /// <returns>Types that have the class name specified. They may not be in the same namespace.</returns>
        public static List<Type> GetTypeByName(string className)
        {
            var collection = AssemblyTypes.Where(t => t.Name.Equals(className));
            return collection.ToList();
        }

        public static bool Issim_cardImplemented(SimTemplate sim_card)
        {
            var type = sim_card.GetType();
            var baseType = typeof(SimTemplate);
            bool implemented = type.IsSubclassOf(baseType);
            return implemented;
        }
        public static SimTemplate getSimCard(CardDB.cardIDEnum id)
        {
            switch (id)
            {
                case CardDB.cardIDEnum.None:
                    return new Sim_None();
                case CardDB.cardIDEnum.PlaceholderCard:
                    return new Sim_PlaceholderCard();
 ///case CardDB.cardIDEnum.///TB:
                    ///return new Sim_///TB();
                case CardDB.cardIDEnum.FB_LK_ClearBoard:
                    return new Sim_FB_LK_ClearBoard();
                case CardDB.cardIDEnum.FB_Champs_CS2_188:
                    return new Sim_FB_Champs_CS2_188();
                case CardDB.cardIDEnum.BRMA14_10H_TB:
                    return new Sim_BRMA14_10H_TB();
                case CardDB.cardIDEnum.FB_Champs_SetEvent_copy:
                    return new Sim_FB_Champs_SetEvent_copy();
                case CardDB.cardIDEnum.TB_EVILBRM_Priest_02:
                    return new Sim_TB_EVILBRM_Priest_02();
                case CardDB.cardIDEnum.TB_Firefest2_Ahune_H:
                    return new Sim_TB_Firefest2_Ahune_H();
                case CardDB.cardIDEnum.TB_LEAGUE_REVIVAL_Druid_04:
                    return new Sim_TB_LEAGUE_REVIVAL_Druid_04();
                case CardDB.cardIDEnum.TB_EVILBRM_Warrior_10:
                    return new Sim_TB_EVILBRM_Warrior_10();
                case CardDB.cardIDEnum.TB_Coopv3_102b:
                    return new Sim_TB_Coopv3_102b();
                case CardDB.cardIDEnum.FB_Duelers_Drawn:
                    return new Sim_FB_Duelers_Drawn();
                case CardDB.cardIDEnum.TB_Amalgam_Ench:
                    return new Sim_TB_Amalgam_Ench();
                case CardDB.cardIDEnum.FB_RagRaid_Amulet:
                    return new Sim_FB_RagRaid_Amulet();
                case CardDB.cardIDEnum.TB_EVILBRM_LOOTA_805:
                    return new Sim_TB_EVILBRM_LOOTA_805();
                case CardDB.cardIDEnum.FB_Champs_NEW1_008:
                    return new Sim_FB_Champs_NEW1_008();
                case CardDB.cardIDEnum.TB_LOEA13_2:
                    return new Sim_TB_LOEA13_2();
                case CardDB.cardIDEnum.FB_Champs_NEW1_008b:
                    return new Sim_FB_Champs_NEW1_008b();
                case CardDB.cardIDEnum.FB_Champs_NEW1_008a:
                    return new Sim_FB_Champs_NEW1_008a();
                case CardDB.cardIDEnum.TB_FW_ImbaTron:
                    return new Sim_TB_FW_ImbaTron();
                case CardDB.cardIDEnum.TB_MechWar_Boss1:
                    return new Sim_TB_MechWar_Boss1();
                case CardDB.cardIDEnum.FB_SPT_AnnoyOPrime:
                    return new Sim_FB_SPT_AnnoyOPrime();
                case CardDB.cardIDEnum.FB_Toki_Boss_teen:
                    return new Sim_FB_Toki_Boss_teen();
                case CardDB.cardIDEnum.TB_KTRAF_1:
                    return new Sim_TB_KTRAF_1();
                case CardDB.cardIDEnum.TB_EVILBRM_RafaamHeroPower:
                    return new Sim_TB_EVILBRM_RafaamHeroPower();
                case CardDB.cardIDEnum.TB_EVILBRM_Warrior_08:
                    return new Sim_TB_EVILBRM_Warrior_08();
                case CardDB.cardIDEnum.TB_SPT_BossWeapon:
                    return new Sim_TB_SPT_BossWeapon();
                case CardDB.cardIDEnum.FB_Toki_TimePortalSpell:
                    return new Sim_FB_Toki_TimePortalSpell();
                case CardDB.cardIDEnum.TB_EVILBRM_Warrior_09:
                    return new Sim_TB_EVILBRM_Warrior_09();
                case CardDB.cardIDEnum.TB_SPT_DPromoSecre8e:
                    return new Sim_TB_SPT_DPromoSecre8e();
                case CardDB.cardIDEnum.BRMC_86:
                    return new Sim_BRMC_86();
                case CardDB.cardIDEnum.TB_EVILBRM_Atramedes:
                    return new Sim_TB_EVILBRM_Atramedes();
                case CardDB.cardIDEnum.FB_Toki_IncreaseHealth:
                    return new Sim_FB_Toki_IncreaseHealth();
                case CardDB.cardIDEnum.FB_Toki_IncreaseHealthEnch:
                    return new Sim_FB_Toki_IncreaseHealthEnch();
                case CardDB.cardIDEnum.FB_Champs_AT_045:
                    return new Sim_FB_Champs_AT_045();
                case CardDB.cardIDEnum.FB_Champs_AT_045eee:
                    return new Sim_FB_Champs_AT_045eee();
                case CardDB.cardIDEnum.TB_BossRumble_002:
                    return new Sim_TB_BossRumble_002();
                case CardDB.cardIDEnum.TB_BountyHunt_Azalina:
                    return new Sim_TB_BountyHunt_Azalina();
                case CardDB.cardIDEnum.TB_207_BagOfSpells:
                    return new Sim_TB_207_BagOfSpells();
                case CardDB.cardIDEnum.TB_CoOpv3_003:
                    return new Sim_TB_CoOpv3_003();
                case CardDB.cardIDEnum.FB_TopX_Ban:
                    return new Sim_FB_TopX_Ban();
                case CardDB.cardIDEnum.TB_100th_BananaPlayerEnchant:
                    return new Sim_TB_100th_BananaPlayerEnchant();
                case CardDB.cardIDEnum.TB_EVILBRM_Geddon:
                    return new Sim_TB_EVILBRM_Geddon();
                case CardDB.cardIDEnum.TB_SPT_BossHeroPower:
                    return new Sim_TB_SPT_BossHeroPower();
                case CardDB.cardIDEnum.FB_BuildABrawl001c:
                    return new Sim_FB_BuildABrawl001c();
                case CardDB.cardIDEnum.TB_207_TolBarad:
                    return new Sim_TB_207_TolBarad();
                case CardDB.cardIDEnum.FB_BuildABrawl001c_ench:
                    return new Sim_FB_BuildABrawl001c_ench();
                case CardDB.cardIDEnum.TB_SPT_Minion2:
                    return new Sim_TB_SPT_Minion2();
                case CardDB.cardIDEnum.TB_EVILBRM_Rogue_10:
                    return new Sim_TB_EVILBRM_Rogue_10();
                case CardDB.cardIDEnum.TB_EVILBRM_Shaman_07:
                    return new Sim_TB_EVILBRM_Shaman_07();
                case CardDB.cardIDEnum.TB_PickYourFate_10:
                    return new Sim_TB_PickYourFate_10();
                case CardDB.cardIDEnum.FB_Champs_EX1_165b:
                    return new Sim_FB_Champs_EX1_165b();
                case CardDB.cardIDEnum.TB_LEAGUE_REVIVAL_Druid_10:
                    return new Sim_TB_LEAGUE_REVIVAL_Druid_10();
                case CardDB.cardIDEnum.FB_RagRaid_Hero:
                    return new Sim_FB_RagRaid_Hero();
                case CardDB.cardIDEnum.TB_006:
                    return new Sim_TB_006();
                case CardDB.cardIDEnum.TB_006e:
                    return new Sim_TB_006e();
                case CardDB.cardIDEnum.FB_Champs_EX1_005:
                    return new Sim_FB_Champs_EX1_005();
                case CardDB.cardIDEnum.TB_EVILBRM_Shaman_05:
                    return new Sim_TB_EVILBRM_Shaman_05();
                case CardDB.cardIDEnum.KAR_a10_Boss2H_TB:
                    return new Sim_KAR_a10_Boss2H_TB();
                case CardDB.cardIDEnum.FB_Champs_CS2_233:
                    return new Sim_FB_Champs_CS2_233();
                case CardDB.cardIDEnum.TB_FoxBlessing:
                    return new Sim_TB_FoxBlessing();
                case CardDB.cardIDEnum.TB_BlingBrawl_Blade1e:
                    return new Sim_TB_BlingBrawl_Blade1e();
                case CardDB.cardIDEnum.TB_BlingBrawl_Blade2e:
                    return new Sim_TB_BlingBrawl_Blade2e();
                case CardDB.cardIDEnum.TB_NewBlinkFox:
                    return new Sim_TB_NewBlinkFox();
                case CardDB.cardIDEnum.FB_BuildABrawl003c:
                    return new Sim_FB_BuildABrawl003c();
                case CardDB.cardIDEnum.FB_BuildABrawl003c_ench:
                    return new Sim_FB_BuildABrawl003c_ench();
                case CardDB.cardIDEnum.TB_BountyHunt_BloodWitch:
                    return new Sim_TB_BountyHunt_BloodWitch();
                case CardDB.cardIDEnum.FB_LK008h:
                    return new Sim_FB_LK008h();
                case CardDB.cardIDEnum.TB_DK_Guldan:
                    return new Sim_TB_DK_Guldan();
                case CardDB.cardIDEnum.TB_Chupacabran_HP:
                    return new Sim_TB_Chupacabran_HP();
                case CardDB.cardIDEnum.TB_Chupacabran_HP_E:
                    return new Sim_TB_Chupacabran_HP_E();
                case CardDB.cardIDEnum.TB_Ignoblegarden1:
                    return new Sim_TB_Ignoblegarden1();
                case CardDB.cardIDEnum.TB_Noblegarden_003t1e:
                    return new Sim_TB_Noblegarden_003t1e();
                case CardDB.cardIDEnum.TB_Noblegarden_003t1e2:
                    return new Sim_TB_Noblegarden_003t1e2();
                case CardDB.cardIDEnum.TB_Noblegarden_003t1:
                    return new Sim_TB_Noblegarden_003t1();
                case CardDB.cardIDEnum.TB_CoOpBossSpell_2:
                    return new Sim_TB_CoOpBossSpell_2();
                case CardDB.cardIDEnum.FB_Juggernaut_Bomb_Effect:
                    return new Sim_FB_Juggernaut_Bomb_Effect();
                case CardDB.cardIDEnum.FB_Juggernaut_MinionEnchant:
                    return new Sim_FB_Juggernaut_MinionEnchant();
                case CardDB.cardIDEnum.TB_EVILBRM_Warrior_04:
                    return new Sim_TB_EVILBRM_Warrior_04();
                case CardDB.cardIDEnum.BRMA17_5_TB:
                    return new Sim_BRMA17_5_TB();
                case CardDB.cardIDEnum.FB_Champs_ICC_705:
                    return new Sim_FB_Champs_ICC_705();
                case CardDB.cardIDEnum.TB_PickYourFate_10_EnchMinion:
                    return new Sim_TB_PickYourFate_10_EnchMinion();
                case CardDB.cardIDEnum.TB_PickYourFate_9_EnchMinion:
                    return new Sim_TB_PickYourFate_9_EnchMinion();
                case CardDB.cardIDEnum.TB_MechWar_Boss2:
                    return new Sim_TB_MechWar_Boss2();
                case CardDB.cardIDEnum.TB_BoomBotFestival_001e:
                    return new Sim_TB_BoomBotFestival_001e();
                case CardDB.cardIDEnum.TB_MechWar_Boss2_HeroPower:
                    return new Sim_TB_MechWar_Boss2_HeroPower();
                case CardDB.cardIDEnum.TB_Henchmania_BoomEnchantBan:
                    return new Sim_TB_Henchmania_BoomEnchantBan();
                case CardDB.cardIDEnum.TB_001:
                    return new Sim_TB_001();
                case CardDB.cardIDEnum.FB_Toki_Boss_spell:
                    return new Sim_FB_Toki_Boss_spell();
                case CardDB.cardIDEnum.TB_LEAGUE_REVIVAL_BrannAIHero:
                    return new Sim_TB_LEAGUE_REVIVAL_BrannAIHero();
                case CardDB.cardIDEnum.TB_LEAGUE_REVIVAL_BrannHistory:
                    return new Sim_TB_LEAGUE_REVIVAL_BrannHistory();
                case CardDB.cardIDEnum.TB_LethalSetup02:
                    return new Sim_TB_LethalSetup02();
                case CardDB.cardIDEnum.TB_FireFestival_Brazier:
                    return new Sim_TB_FireFestival_Brazier();
                case CardDB.cardIDEnum.TB_BossRumble_003hp:
                    return new Sim_TB_BossRumble_003hp();
                case CardDB.cardIDEnum.TB_BountyHunt_Brushwood:
                    return new Sim_TB_BountyHunt_Brushwood();
                case CardDB.cardIDEnum.FB_Toki_Boss_baby:
                    return new Sim_FB_Toki_Boss_baby();
                case CardDB.cardIDEnum.TB_ckBuildDeck_Dalaran:
                    return new Sim_TB_ckBuildDeck_Dalaran();
                case CardDB.cardIDEnum.FB_BuildABrawl_Tools_reset:
                    return new Sim_FB_BuildABrawl_Tools_reset();
                case CardDB.cardIDEnum.FB_BuildABrawl_Tools_ench:
                    return new Sim_FB_BuildABrawl_Tools_ench();
                case CardDB.cardIDEnum.TB_Noblegarden_002t1:
                    return new Sim_TB_Noblegarden_002t1();
                case CardDB.cardIDEnum.TB_LEAGUE_REVIVAL_FinleyHistory:
                    return new Sim_TB_LEAGUE_REVIVAL_FinleyHistory();
                case CardDB.cardIDEnum.TB_LEAGUE_REVIVAL_FinleySandHero:
                    return new Sim_TB_LEAGUE_REVIVAL_FinleySandHero();
                case CardDB.cardIDEnum.BRMC_97e:
                    return new Sim_BRMC_97e();
                case CardDB.cardIDEnum.FB_RagRaid_DestroyEverything:
                    return new Sim_FB_RagRaid_DestroyEverything();
                case CardDB.cardIDEnum.FB_BuildABrawl001a:
                    return new Sim_FB_BuildABrawl001a();
                case CardDB.cardIDEnum.FB_BuildABrawl001a_ench:
                    return new Sim_FB_BuildABrawl001a_ench();
                case CardDB.cardIDEnum.TB_KaraPortal_002:
                    return new Sim_TB_KaraPortal_002();
                case CardDB.cardIDEnum.FB_Champs_LOOT_093:
                    return new Sim_FB_Champs_LOOT_093();
                case CardDB.cardIDEnum.FB_LK004:
                    return new Sim_FB_LK004();
                case CardDB.cardIDEnum.FB_ELO001d:
                    return new Sim_FB_ELO001d();
                case CardDB.cardIDEnum.FB_RagRaid_ResetCancel:
                    return new Sim_FB_RagRaid_ResetCancel();
                case CardDB.cardIDEnum.FB_LK011:
                    return new Sim_FB_LK011();
                case CardDB.cardIDEnum.TB_HeadlessHorseman_004:
                    return new Sim_TB_HeadlessHorseman_004();
                case CardDB.cardIDEnum.TB_Presents_002:
                    return new Sim_TB_Presents_002();
                case CardDB.cardIDEnum.TB_Noblegarden_005:
                    return new Sim_TB_Noblegarden_005();
                case CardDB.cardIDEnum.TP_Bling_HP2:
                    return new Sim_TP_Bling_HP2();
                case CardDB.cardIDEnum.TB_CoOpv3_201:
                    return new Sim_TB_CoOpv3_201();
                case CardDB.cardIDEnum.TB_CheaterChess_Black:
                    return new Sim_TB_CheaterChess_Black();
                case CardDB.cardIDEnum.TB_HeadlessHorseman_s001b:
                    return new Sim_TB_HeadlessHorseman_s001b();
                case CardDB.cardIDEnum.FB_Champs_EX1_165a:
                    return new Sim_FB_Champs_EX1_165a();
                case CardDB.cardIDEnum.TB_BuildaBoss_001:
                    return new Sim_TB_BuildaBoss_001();
                case CardDB.cardIDEnum.TB_207_TreasureCatacombs:
                    return new Sim_TB_207_TreasureCatacombs();
                case CardDB.cardIDEnum.TB_Firefest2_003:
                    return new Sim_TB_Firefest2_003();
                case CardDB.cardIDEnum.FB_Champs_SetUp_Ench:
                    return new Sim_FB_Champs_SetUp_Ench();
                case CardDB.cardIDEnum.TB_MP_01e:
                    return new Sim_TB_MP_01e();
                case CardDB.cardIDEnum.TB_FoxBlessing6:
                    return new Sim_TB_FoxBlessing6();
                case CardDB.cardIDEnum.TB_GiftExchange_Enchantment:
                    return new Sim_TB_GiftExchange_Enchantment();
                case CardDB.cardIDEnum.TB_TagTeam:
                    return new Sim_TB_TagTeam();
                case CardDB.cardIDEnum.FB_LK003:
                    return new Sim_FB_LK003();
                case CardDB.cardIDEnum.TB_SPT_DPromoCrate3:
                    return new Sim_TB_SPT_DPromoCrate3();
                case CardDB.cardIDEnum.TB_Firefest2_004:
                    return new Sim_TB_Firefest2_004();
                case CardDB.cardIDEnum.TB_LEAGUE_REVIVAL_Druid_03:
                    return new Sim_TB_LEAGUE_REVIVAL_Druid_03();
                case CardDB.cardIDEnum.TB_012:
                    return new Sim_TB_012();
                case CardDB.cardIDEnum.TB_014:
                    return new Sim_TB_014();
                case CardDB.cardIDEnum.TB_010e:
                    return new Sim_TB_010e();
                case CardDB.cardIDEnum.TB_BountyHunt_Chupacabran:
                    return new Sim_TB_BountyHunt_Chupacabran();
                case CardDB.cardIDEnum.TB_SPT_Boss:
                    return new Sim_TB_SPT_Boss();
                case CardDB.cardIDEnum.TB_SPT_MTH_Boss0:
                    return new Sim_TB_SPT_MTH_Boss0();
                case CardDB.cardIDEnum.FB_BuildABrawl003b:
                    return new Sim_FB_BuildABrawl003b();
                case CardDB.cardIDEnum.FB_BuildABrawl003b_ench:
                    return new Sim_FB_BuildABrawl003b_ench();
                case CardDB.cardIDEnum.TB_CoOpv3_004:
                    return new Sim_TB_CoOpv3_004();
                case CardDB.cardIDEnum.TB_CoOpv3_005:
                    return new Sim_TB_CoOpv3_005();
                case CardDB.cardIDEnum.TB_207_Cloneball:
                    return new Sim_TB_207_Cloneball();
                case CardDB.cardIDEnum.FB_Champs_CS2_073:
                    return new Sim_FB_Champs_CS2_073();
                case CardDB.cardIDEnum.TB_EVILBRM_Rogue_01:
                    return new Sim_TB_EVILBRM_Rogue_01();
                case CardDB.cardIDEnum.FB_ELO002:
                    return new Sim_FB_ELO002();
                case CardDB.cardIDEnum.FB_ELO001c:
                    return new Sim_FB_ELO001c();
                case CardDB.cardIDEnum.TB_FireFestEnch:
                    return new Sim_TB_FireFestEnch();
                case CardDB.cardIDEnum.TB_HeadlessHorseman_HP3:
                    return new Sim_TB_HeadlessHorseman_HP3();
                case CardDB.cardIDEnum.FB_SPT_Annoyo_HP:
                    return new Sim_FB_SPT_Annoyo_HP();
                case CardDB.cardIDEnum.FB_SPT_Annoyo_HP_0:
                    return new Sim_FB_SPT_Annoyo_HP_0();
                case CardDB.cardIDEnum.FB_SPT_Annoyo_HP_1:
                    return new Sim_FB_SPT_Annoyo_HP_1();
                case CardDB.cardIDEnum.TB_BossRumble_002hp:
                    return new Sim_TB_BossRumble_002hp();
                case CardDB.cardIDEnum.TB_BountyHunt_Consume:
                    return new Sim_TB_BountyHunt_Consume();
                case CardDB.cardIDEnum.TB_LethalSetup001a:
                    return new Sim_TB_LethalSetup001a();
                case CardDB.cardIDEnum.TB_CoopHero_H_001:
                    return new Sim_TB_CoopHero_H_001();
                case CardDB.cardIDEnum.BRMC_95he:
                    return new Sim_BRMC_95he();
                case CardDB.cardIDEnum.BRMC_95h:
                    return new Sim_BRMC_95h();
                case CardDB.cardIDEnum.BRMC_92:
                    return new Sim_BRMC_92();
                case CardDB.cardIDEnum.FB_Champs_LOOT_149:
                    return new Sim_FB_Champs_LOOT_149();
                case CardDB.cardIDEnum.TB_CoOpv3_BOSS4e:
                    return new Sim_TB_CoOpv3_BOSS4e();
                case CardDB.cardIDEnum.TB_009:
                    return new Sim_TB_009();
                case CardDB.cardIDEnum.TB_HeadlessHorseman_XXX:
                    return new Sim_TB_HeadlessHorseman_XXX();
                case CardDB.cardIDEnum.FB_Champs_UNG_067t1:
                    return new Sim_FB_Champs_UNG_067t1();
                case CardDB.cardIDEnum.FB_Champs_UNG_067t1e:
                    return new Sim_FB_Champs_UNG_067t1e();
                case CardDB.cardIDEnum.FB_Champs_UNG_067t1e2:
                    return new Sim_FB_Champs_UNG_067t1e2();
                case CardDB.cardIDEnum.EVILBRM_DALA_Warlock_11:
                    return new Sim_EVILBRM_DALA_Warlock_11();
                case CardDB.cardIDEnum.TB_EVILBRM_Rogue_08:
                    return new Sim_TB_EVILBRM_Rogue_08();
                case CardDB.cardIDEnum.FB_Champs_skele21:
                    return new Sim_FB_Champs_skele21();
                case CardDB.cardIDEnum.TB_TagTeam_Paladin:
                    return new Sim_TB_TagTeam_Paladin();
                case CardDB.cardIDEnum.FB_Champs_LOOT_017:
                    return new Sim_FB_Champs_LOOT_017();
                case CardDB.cardIDEnum.TB_LEAGUE_REVIVAL_TekahnAIHero:
                    return new Sim_TB_LEAGUE_REVIVAL_TekahnAIHero();
                case CardDB.cardIDEnum.TB_KTRAF_10e:
                    return new Sim_TB_KTRAF_10e();
                case CardDB.cardIDEnum.TB_SPT_DPromo_Hero:
                    return new Sim_TB_SPT_DPromo_Hero();
                case CardDB.cardIDEnum.FB_Champs_FP1_028e:
                    return new Sim_FB_Champs_FP1_028e();
                case CardDB.cardIDEnum.TB_KTRAF_101:
                    return new Sim_TB_KTRAF_101();
                case CardDB.cardIDEnum.FB_Toki_Boss_Poison:
                    return new Sim_FB_Toki_Boss_Poison();
                case CardDB.cardIDEnum.TB_FoxBlessing2:
                    return new Sim_TB_FoxBlessing2();
                case CardDB.cardIDEnum.TB_TagTeam_Warlock:
                    return new Sim_TB_TagTeam_Warlock();
                case CardDB.cardIDEnum.TB_EVILBRM_Rogue_05:
                    return new Sim_TB_EVILBRM_Rogue_05();
                case CardDB.cardIDEnum.TB_PickYourFate_9:
                    return new Sim_TB_PickYourFate_9();
                case CardDB.cardIDEnum.TB_DeathrattleYog_ench:
                    return new Sim_TB_DeathrattleYog_ench();
                case CardDB.cardIDEnum.TB_DK_Valeera_HP:
                    return new Sim_TB_DK_Valeera_HP();
                case CardDB.cardIDEnum.TB_DK_Rexxar:
                    return new Sim_TB_DK_Rexxar();
                case CardDB.cardIDEnum.TB_Zombeast_H:
                    return new Sim_TB_Zombeast_H();
                case CardDB.cardIDEnum.NAX12_02H_2_TB:
                    return new Sim_NAX12_02H_2_TB();
                case CardDB.cardIDEnum.NAX12_02H_2c_TB:
                    return new Sim_NAX12_02H_2c_TB();
                case CardDB.cardIDEnum.TB_010:
                    return new Sim_TB_010();
                case CardDB.cardIDEnum.TB_MammothParty_hp001:
                    return new Sim_TB_MammothParty_hp001();
                case CardDB.cardIDEnum.TB_SPT_MTH_Boss:
                    return new Sim_TB_SPT_MTH_Boss();
                case CardDB.cardIDEnum.FB_LKStats002b:
                    return new Sim_FB_LKStats002b();
                case CardDB.cardIDEnum.FB_Toki_Quest:
                    return new Sim_FB_Toki_Quest();
                case CardDB.cardIDEnum.FB_Toki_ReverseTurnEnch:
                    return new Sim_FB_Toki_ReverseTurnEnch();
                case CardDB.cardIDEnum.TB_Noblegarden_005e:
                    return new Sim_TB_Noblegarden_005e();
                case CardDB.cardIDEnum.TB_007:
                    return new Sim_TB_007();
                case CardDB.cardIDEnum.TB_007e:
                    return new Sim_TB_007e();
                case CardDB.cardIDEnum.TB_SPT_DPromoHP:
                    return new Sim_TB_SPT_DPromoHP();
                case CardDB.cardIDEnum.FB_RagRaid_DoubleBlast:
                    return new Sim_FB_RagRaid_DoubleBlast();
                case CardDB.cardIDEnum.TB_LEAGUE_REVIVAL_BrannAIHp:
                    return new Sim_TB_LEAGUE_REVIVAL_BrannAIHp();
                case CardDB.cardIDEnum.TB_PickYourFate_4:
                    return new Sim_TB_PickYourFate_4();
                case CardDB.cardIDEnum.TB_PickYourFate_7_2nd:
                    return new Sim_TB_PickYourFate_7_2nd();
                case CardDB.cardIDEnum.TB_PickYourFate_11rand:
                    return new Sim_TB_PickYourFate_11rand();
                case CardDB.cardIDEnum.TB_PickYourFate_1:
                    return new Sim_TB_PickYourFate_1();
                case CardDB.cardIDEnum.TB_PickYourFate_6_2nd:
                    return new Sim_TB_PickYourFate_6_2nd();
                case CardDB.cardIDEnum.TB_PickYourFate_3:
                    return new Sim_TB_PickYourFate_3();
                case CardDB.cardIDEnum.TB_SPT_DPromoCrate2:
                    return new Sim_TB_SPT_DPromoCrate2();
                case CardDB.cardIDEnum.FB_Duelers_Discover:
                    return new Sim_FB_Duelers_Discover();
                case CardDB.cardIDEnum.FB_Duelers_Discover1:
                    return new Sim_FB_Duelers_Discover1();
                case CardDB.cardIDEnum.FB_Duelers_Discover2:
                    return new Sim_FB_Duelers_Discover2();
                case CardDB.cardIDEnum.FB_Duelers_Discover3:
                    return new Sim_FB_Duelers_Discover3();
                case CardDB.cardIDEnum.FB_Duelers_Discover4:
                    return new Sim_FB_Duelers_Discover4();
                case CardDB.cardIDEnum.FB_Duelers_Discover5:
                    return new Sim_FB_Duelers_Discover5();
                case CardDB.cardIDEnum.TB_DiscoverMyDeck_Enchantment:
                    return new Sim_TB_DiscoverMyDeck_Enchantment();
                case CardDB.cardIDEnum.TB_TagTeam_GetClass:
                    return new Sim_TB_TagTeam_GetClass();
                case CardDB.cardIDEnum.FB_LK_GetClass_copy:
                    return new Sim_FB_LK_GetClass_copy();
                case CardDB.cardIDEnum.TB_MammothParty_303:
                    return new Sim_TB_MammothParty_303();
                case CardDB.cardIDEnum.TB_CoOpv3_011:
                    return new Sim_TB_CoOpv3_011();
                case CardDB.cardIDEnum.TB_Ignoblegarden3:
                    return new Sim_TB_Ignoblegarden3();
                case CardDB.cardIDEnum.TB_Dorothee_001:
                    return new Sim_TB_Dorothee_001();
                case CardDB.cardIDEnum.TB_DoubleMinions_ench:
                    return new Sim_TB_DoubleMinions_ench();
                case CardDB.cardIDEnum.TB_DoubleMinions_spell:
                    return new Sim_TB_DoubleMinions_spell();
                case CardDB.cardIDEnum.TB_CoOpBossSpell_5:
                    return new Sim_TB_CoOpBossSpell_5();
                case CardDB.cardIDEnum.TB_EVILBRM_BoomH:
                    return new Sim_TB_EVILBRM_BoomH();
                case CardDB.cardIDEnum.TB_FW_DrBoomMega:
                    return new Sim_TB_FW_DrBoomMega();
                case CardDB.cardIDEnum.BRMC_84:
                    return new Sim_BRMC_84();
                case CardDB.cardIDEnum.BRMC_98e:
                    return new Sim_BRMC_98e();
                case CardDB.cardIDEnum.TB_Coopv3_100:
                    return new Sim_TB_Coopv3_100();
                case CardDB.cardIDEnum.BRMC_88:
                    return new Sim_BRMC_88();
                case CardDB.cardIDEnum.EVILBRM_DALA_Warlock_03:
                    return new Sim_EVILBRM_DALA_Warlock_03();
                case CardDB.cardIDEnum.FB_Duelers_Draw:
                    return new Sim_FB_Duelers_Draw();
                case CardDB.cardIDEnum.TB_EVILBRM_Rogue_09:
                    return new Sim_TB_EVILBRM_Rogue_09();
                case CardDB.cardIDEnum.TB_DrawnDiscovery_Ench:
                    return new Sim_TB_DrawnDiscovery_Ench();
                case CardDB.cardIDEnum.TB_Superfriends002e:
                    return new Sim_TB_Superfriends002e();
                case CardDB.cardIDEnum.FB_Juggernaut_Druid:
                    return new Sim_FB_Juggernaut_Druid();
                case CardDB.cardIDEnum.FB_LK_Druid_copy:
                    return new Sim_FB_LK_Druid_copy();
                case CardDB.cardIDEnum.FB_Champs_EX1_165:
                    return new Sim_FB_Champs_EX1_165();
                case CardDB.cardIDEnum.FB_Champs_EX1_165t1:
                    return new Sim_FB_Champs_EX1_165t1();
                case CardDB.cardIDEnum.FB_Champs_EX1_165t2:
                    return new Sim_FB_Champs_EX1_165t2();
                case CardDB.cardIDEnum.FB_Champs_OG_044a:
                    return new Sim_FB_Champs_OG_044a();
                case CardDB.cardIDEnum.TB_FW_Mortar:
                    return new Sim_TB_FW_Mortar();
                case CardDB.cardIDEnum.TB_CoOpv3_006:
                    return new Sim_TB_CoOpv3_006();
                case CardDB.cardIDEnum.TB_TagTeam_Mage:
                    return new Sim_TB_TagTeam_Mage();
                case CardDB.cardIDEnum.TB_EVILBRM_Shaman_06:
                    return new Sim_TB_EVILBRM_Shaman_06();
                case CardDB.cardIDEnum.TB_LEAGUE_REVIVAL_Elise:
                    return new Sim_TB_LEAGUE_REVIVAL_Elise();
                case CardDB.cardIDEnum.FB_ELO001bench:
                    return new Sim_FB_ELO001bench();
                case CardDB.cardIDEnum.TB_SPT_Minion2e:
                    return new Sim_TB_SPT_Minion2e();
                case CardDB.cardIDEnum.FB_Champs_LOOT_080t2:
                    return new Sim_FB_Champs_LOOT_080t2();
                case CardDB.cardIDEnum.EVILBRM_DALA_Warlock_10:
                    return new Sim_EVILBRM_DALA_Warlock_10();
                case CardDB.cardIDEnum.TB_SpeedRun_End:
                    return new Sim_TB_SpeedRun_End();
                case CardDB.cardIDEnum.TB_EndlessMinions01:
                    return new Sim_TB_EndlessMinions01();
                case CardDB.cardIDEnum.HERO_FB_Juggernaut:
                    return new Sim_HERO_FB_Juggernaut();
                case CardDB.cardIDEnum.TB_SPT_DpromoPortal:
                    return new Sim_TB_SPT_DpromoPortal();
                case CardDB.cardIDEnum.TB_CoOpv3_BOSS3e:
                    return new Sim_TB_CoOpv3_BOSS3e();
                case CardDB.cardIDEnum.FB_Champs_EX1_619:
                    return new Sim_FB_Champs_EX1_619();
                case CardDB.cardIDEnum.BRMA11_2H_2_TB:
                    return new Sim_BRMA11_2H_2_TB();
                case CardDB.cardIDEnum.TB_LEAGUE_REVIVAL_TekahnAIHp:
                    return new Sim_TB_LEAGUE_REVIVAL_TekahnAIHp();
                case CardDB.cardIDEnum.FB_Champs_CS2_108:
                    return new Sim_FB_Champs_CS2_108();
                case CardDB.cardIDEnum.FB_Toki_ManaPortal2:
                    return new Sim_FB_Toki_ManaPortal2();
                case CardDB.cardIDEnum.TB_BountyHunt_Experiment3C:
                    return new Sim_TB_BountyHunt_Experiment3C();
                case CardDB.cardIDEnum.TB_CoOpv3_009:
                    return new Sim_TB_CoOpv3_009();
                case CardDB.cardIDEnum.TB_Coopv3_009t:
                    return new Sim_TB_Coopv3_009t();
                case CardDB.cardIDEnum.TB_CoOpv3_010:
                    return new Sim_TB_CoOpv3_010();
                case CardDB.cardIDEnum.TB_Superfriends001e:
                    return new Sim_TB_Superfriends001e();
                case CardDB.cardIDEnum.TB_KTRAF_6m:
                    return new Sim_TB_KTRAF_6m();
                case CardDB.cardIDEnum.TB_PickYourFate_10_Ench:
                    return new Sim_TB_PickYourFate_10_Ench();
                case CardDB.cardIDEnum.TB_PickYourFate_2_EnchMinion:
                    return new Sim_TB_PickYourFate_2_EnchMinion();
                case CardDB.cardIDEnum.TB_PickYourFate_4_EnchMinion:
                    return new Sim_TB_PickYourFate_4_EnchMinion();
                case CardDB.cardIDEnum.TB_PickYourFate_7_EnchMiniom2nd:
                    return new Sim_TB_PickYourFate_7_EnchMiniom2nd();
                case CardDB.cardIDEnum.TB_PickYourFate_7_EnchMinion:
                    return new Sim_TB_PickYourFate_7_EnchMinion();
                case CardDB.cardIDEnum.TB_PickYourFate_Confused:
                    return new Sim_TB_PickYourFate_Confused();
                case CardDB.cardIDEnum.TB_PickYourFate_Windfury:
                    return new Sim_TB_PickYourFate_Windfury();
                case CardDB.cardIDEnum.TB_PickYourFate_11_Ench:
                    return new Sim_TB_PickYourFate_11_Ench();
                case CardDB.cardIDEnum.TB_PickYourFate_12_Ench:
                    return new Sim_TB_PickYourFate_12_Ench();
                case CardDB.cardIDEnum.TB_PickYourFate_7_Ench_2nd:
                    return new Sim_TB_PickYourFate_7_Ench_2nd();
                case CardDB.cardIDEnum.TB_PickYourFate7Ench:
                    return new Sim_TB_PickYourFate7Ench();
                case CardDB.cardIDEnum.TB_PickYourFate_8_Ench:
                    return new Sim_TB_PickYourFate_8_Ench();
                case CardDB.cardIDEnum.TB_PickYourFate_8_EnchRand:
                    return new Sim_TB_PickYourFate_8_EnchRand();
                case CardDB.cardIDEnum.TB_PickYourFate_9_Ench:
                    return new Sim_TB_PickYourFate_9_Ench();
                case CardDB.cardIDEnum.TB_PickYourFate_8rand:
                    return new Sim_TB_PickYourFate_8rand();
                case CardDB.cardIDEnum.TB_PickYourFate_2:
                    return new Sim_TB_PickYourFate_2();
                case CardDB.cardIDEnum.TB_PickYourFate_7:
                    return new Sim_TB_PickYourFate_7();
                case CardDB.cardIDEnum.TB_PickYourFate_12:
                    return new Sim_TB_PickYourFate_12();
                case CardDB.cardIDEnum.TB_PickYourFate_6:
                    return new Sim_TB_PickYourFate_6();
                case CardDB.cardIDEnum.TB_PickYourFate_5:
                    return new Sim_TB_PickYourFate_5();
                case CardDB.cardIDEnum.TB_HeadlessHorseman_s005:
                    return new Sim_TB_HeadlessHorseman_s005();
                case CardDB.cardIDEnum.TB_LEAGUE_REVIVAL_Druid_06:
                    return new Sim_TB_LEAGUE_REVIVAL_Druid_06();
                case CardDB.cardIDEnum.TB_HeadlessHorseman_s004:
                    return new Sim_TB_HeadlessHorseman_s004();
                case CardDB.cardIDEnum.FB_Champs_CS2_106:
                    return new Sim_FB_Champs_CS2_106();
                case CardDB.cardIDEnum.FB_LKStats001a:
                    return new Sim_FB_LKStats001a();
                case CardDB.cardIDEnum.TB_LevelUp_002:
                    return new Sim_TB_LevelUp_002();
                case CardDB.cardIDEnum.TB_FireFestival_Fireworks:
                    return new Sim_TB_FireFestival_Fireworks();
                case CardDB.cardIDEnum.TB_Firefest2_003e:
                    return new Sim_TB_Firefest2_003e();
                case CardDB.cardIDEnum.TB_3Wishes_Spell:
                    return new Sim_TB_3Wishes_Spell();
                case CardDB.cardIDEnum.TB_EVILBRM_Shaman_03:
                    return new Sim_TB_EVILBRM_Shaman_03();
                case CardDB.cardIDEnum.TB_CoOpv3_007:
                    return new Sim_TB_CoOpv3_007();
                case CardDB.cardIDEnum.TB_CoOpv3_008:
                    return new Sim_TB_CoOpv3_008();
                case CardDB.cardIDEnum.FB_Champs_EX1_565:
                    return new Sim_FB_Champs_EX1_565();
                case CardDB.cardIDEnum.TB_EVILBRM_Shaman_01:
                    return new Sim_TB_EVILBRM_Shaman_01();
                case CardDB.cardIDEnum.TB_BlingBrawl_Weapon:
                    return new Sim_TB_BlingBrawl_Weapon();
                case CardDB.cardIDEnum.TB_CoOpv3_200:
                    return new Sim_TB_CoOpv3_200();
                case CardDB.cardIDEnum.FB_Champs_EX1_571:
                    return new Sim_FB_Champs_EX1_571();
                case CardDB.cardIDEnum.TB_FW_OmegaMax:
                    return new Sim_TB_FW_OmegaMax();
                case CardDB.cardIDEnum.TB_FoxBlessingEnch:
                    return new Sim_TB_FoxBlessingEnch();
                case CardDB.cardIDEnum.TB_Coopv3_101:
                    return new Sim_TB_Coopv3_101();
                case CardDB.cardIDEnum.TB_Firefest2_002:
                    return new Sim_TB_Firefest2_002();
                case CardDB.cardIDEnum.FB_LK007p:
                    return new Sim_FB_LK007p();
                case CardDB.cardIDEnum.TB_Firefest2_Ahune_HP:
                    return new Sim_TB_Firefest2_Ahune_HP();
                case CardDB.cardIDEnum.TB_DK_Jaina:
                    return new Sim_TB_DK_Jaina();
                case CardDB.cardIDEnum.TB_Firefest2_005:
                    return new Sim_TB_Firefest2_005();
                case CardDB.cardIDEnum.TB_Firefest2_005e:
                    return new Sim_TB_Firefest2_005e();
                case CardDB.cardIDEnum.TB_MammothParty_s101a:
                    return new Sim_TB_MammothParty_s101a();
                case CardDB.cardIDEnum.FB_Toki_ManaPortal:
                    return new Sim_FB_Toki_ManaPortal();
                case CardDB.cardIDEnum.FB_Champs_EX1_095:
                    return new Sim_FB_Champs_EX1_095();
                case CardDB.cardIDEnum.BRMC_99:
                    return new Sim_BRMC_99();
                case CardDB.cardIDEnum.TB_EVILBRM_Garr:
                    return new Sim_TB_EVILBRM_Garr();
                case CardDB.cardIDEnum.TB_LEAGUE_REVIVAL_RenoAIHp:
                    return new Sim_TB_LEAGUE_REVIVAL_RenoAIHp();
                case CardDB.cardIDEnum.HRW02_1:
                    return new Sim_HRW02_1();
                case CardDB.cardIDEnum.HRW02_2:
                    return new Sim_HRW02_2();
                case CardDB.cardIDEnum.TB_CoOp_Mechazod_OLD:
                    return new Sim_TB_CoOp_Mechazod_OLD();
                case CardDB.cardIDEnum.TB_CoOp_Mechazod_V2:
                    return new Sim_TB_CoOp_Mechazod_V2();
                case CardDB.cardIDEnum.TB_Henchmania_George:
                    return new Sim_TB_Henchmania_George();
                case CardDB.cardIDEnum.TB_Champs_GetChampsDeckID:
                    return new Sim_TB_Champs_GetChampsDeckID();
                case CardDB.cardIDEnum.TB_CoOpv3_BOSS2e:
                    return new Sim_TB_CoOpv3_BOSS2e();
                case CardDB.cardIDEnum.TB_GiftReceiptSpell:
                    return new Sim_TB_GiftReceiptSpell();
                case CardDB.cardIDEnum.TB_AllMinionsTauntCharge:
                    return new Sim_TB_AllMinionsTauntCharge();
                case CardDB.cardIDEnum.TB_CoOpv3_001:
                    return new Sim_TB_CoOpv3_001();
                case CardDB.cardIDEnum.TB_KTRAF_3:
                    return new Sim_TB_KTRAF_3();
                case CardDB.cardIDEnum.TB_CoOpv3_009e:
                    return new Sim_TB_CoOpv3_009e();
                case CardDB.cardIDEnum.TB_Noblegarden_003t7e:
                    return new Sim_TB_Noblegarden_003t7e();
                case CardDB.cardIDEnum.TB_Noblegarden_003t7e2:
                    return new Sim_TB_Noblegarden_003t7e2();
                case CardDB.cardIDEnum.TB_Noblegarden_003t7:
                    return new Sim_TB_Noblegarden_003t7();
                case CardDB.cardIDEnum.ART_BOT_Bundle_001:
                    return new Sim_ART_BOT_Bundle_001();
                case CardDB.cardIDEnum.BRMC_95:
                    return new Sim_BRMC_95();
                case CardDB.cardIDEnum.TB_KTRAF_4:
                    return new Sim_TB_KTRAF_4();
                case CardDB.cardIDEnum.TB_KTRAF_5:
                    return new Sim_TB_KTRAF_5();
                case CardDB.cardIDEnum.TB_KoboldGiftEnch:
                    return new Sim_TB_KoboldGiftEnch();
                case CardDB.cardIDEnum.TB_KoboldGiftSpell:
                    return new Sim_TB_KoboldGiftSpell();
                case CardDB.cardIDEnum.FB_BuildABrawl002a_ench:
                    return new Sim_FB_BuildABrawl002a_ench();
                case CardDB.cardIDEnum.FB_ELO002_copy:
                    return new Sim_FB_ELO002_copy();
                case CardDB.cardIDEnum.FB_Champs_LOOT_080t3:
                    return new Sim_FB_Champs_LOOT_080t3();
                case CardDB.cardIDEnum.FB_ELO002a_copy:
                    return new Sim_FB_ELO002a_copy();
                case CardDB.cardIDEnum.FB_ELO002a_ench_copy:
                    return new Sim_FB_ELO002a_ench_copy();
                case CardDB.cardIDEnum.FB_ELO002c_copy:
                    return new Sim_FB_ELO002c_copy();
                case CardDB.cardIDEnum.FB_ELO002c_ench_copy:
                    return new Sim_FB_ELO002c_ench_copy();
                case CardDB.cardIDEnum.FB_ELO002b_copy:
                    return new Sim_FB_ELO002b_copy();
                case CardDB.cardIDEnum.FB_ELO002b_ench_copy:
                    return new Sim_FB_ELO002b_ench_copy();
                case CardDB.cardIDEnum.TB_Noblegarden_003t3e:
                    return new Sim_TB_Noblegarden_003t3e();
                case CardDB.cardIDEnum.TB_Noblegarden_003t3e2:
                    return new Sim_TB_Noblegarden_003t3e2();
                case CardDB.cardIDEnum.TB_Noblegarden_003t3:
                    return new Sim_TB_Noblegarden_003t3();
                case CardDB.cardIDEnum.TB_KTRAF_6:
                    return new Sim_TB_KTRAF_6();
                case CardDB.cardIDEnum.TB_SPT_DPromoMinion2:
                    return new Sim_TB_SPT_DPromoMinion2();
                case CardDB.cardIDEnum.TB_EVILBRM_HagathaH:
                    return new Sim_TB_EVILBRM_HagathaH();
                case CardDB.cardIDEnum.TB_BossRumble_001:
                    return new Sim_TB_BossRumble_001();
                case CardDB.cardIDEnum.TB_SPT_MTH_Minion1:
                    return new Sim_TB_SPT_MTH_Minion1();
                case CardDB.cardIDEnum.TB_GiftReceiptSpell_Start:
                    return new Sim_TB_GiftReceiptSpell_Start();
                case CardDB.cardIDEnum.TB_GiftExchange_Snowball:
                    return new Sim_TB_GiftExchange_Snowball();
                case CardDB.cardIDEnum.NAX8_02H_TB:
                    return new Sim_NAX8_02H_TB();
                case CardDB.cardIDEnum.FB_Champs_EX1_556:
                    return new Sim_FB_Champs_EX1_556();
                case CardDB.cardIDEnum.TB_Noblegarden_006:
                    return new Sim_TB_Noblegarden_006();
                case CardDB.cardIDEnum.TB_HeadlessHorseman_H1:
                    return new Sim_TB_HeadlessHorseman_H1();
                case CardDB.cardIDEnum.TB_HeadlessHorseman_H1a:
                    return new Sim_TB_HeadlessHorseman_H1a();
                case CardDB.cardIDEnum.TB_HeadlessHorseman_001:
                    return new Sim_TB_HeadlessHorseman_001();
                case CardDB.cardIDEnum.TB_KTRAF_7:
                    return new Sim_TB_KTRAF_7();
                case CardDB.cardIDEnum.TB_SPT_DPromoMinion:
                    return new Sim_TB_SPT_DPromoMinion();
                case CardDB.cardIDEnum.TB_SPT_DPromoMinionInit:
                    return new Sim_TB_SPT_DPromoMinionInit();
                case CardDB.cardIDEnum.TB_SPT_DPromoMinionChamp:
                    return new Sim_TB_SPT_DPromoMinionChamp();
                case CardDB.cardIDEnum.TB_MechWar_Boss1_HeroPower:
                    return new Sim_TB_MechWar_Boss1_HeroPower();
                case CardDB.cardIDEnum.TB_Henchmania_Discover:
                    return new Sim_TB_Henchmania_Discover();
                case CardDB.cardIDEnum.TB_SPT_DPromoSpellBovine1e:
                    return new Sim_TB_SPT_DPromoSpellBovine1e();
                case CardDB.cardIDEnum.FB_LK_BossSetup001b:
                    return new Sim_FB_LK_BossSetup001b();
                case CardDB.cardIDEnum.FB_Champs_EX1_246:
                    return new Sim_FB_Champs_EX1_246();
                case CardDB.cardIDEnum.BRMC_96:
                    return new Sim_BRMC_96();
                case CardDB.cardIDEnum.TB_EVILBRM_Omokk:
                    return new Sim_TB_EVILBRM_Omokk();
                case CardDB.cardIDEnum.FB_Juggernaut_Hunter:
                    return new Sim_FB_Juggernaut_Hunter();
                case CardDB.cardIDEnum.FB_LK_Hunter_copy:
                    return new Sim_FB_LK_Hunter_copy();
                case CardDB.cardIDEnum.FB_Champs_CS2_084:
                    return new Sim_FB_Champs_CS2_084();
                case CardDB.cardIDEnum.TB_BountyHunt_Hypnotize:
                    return new Sim_TB_BountyHunt_Hypnotize();
                case CardDB.cardIDEnum.BRMC_86e:
                    return new Sim_BRMC_86e();
                case CardDB.cardIDEnum.TB_Iceblock:
                    return new Sim_TB_Iceblock();
                case CardDB.cardIDEnum.TB_CoOpv3_012:
                    return new Sim_TB_CoOpv3_012();
                case CardDB.cardIDEnum.TB_CoOpv3_013:
                    return new Sim_TB_CoOpv3_013();
                case CardDB.cardIDEnum.TB_Henchmania_ChuHt:
                    return new Sim_TB_Henchmania_ChuHt();
                case CardDB.cardIDEnum.EVILBRM_DALA_Warlock_07:
                    return new Sim_EVILBRM_DALA_Warlock_07();
                case CardDB.cardIDEnum.FB_LKStats002a:
                    return new Sim_FB_LKStats002a();
                case CardDB.cardIDEnum.FB_Annoyo_003:
                    return new Sim_FB_Annoyo_003();
                case CardDB.cardIDEnum.EX1_tk33_2_TB:
                    return new Sim_EX1_tk33_2_TB();
                case CardDB.cardIDEnum.FB_Toki2:
                    return new Sim_FB_Toki2();
                case CardDB.cardIDEnum.FB_Champs_EX1_169:
                    return new Sim_FB_Champs_EX1_169();
                case CardDB.cardIDEnum.FB_LK_BossSetup001:
                    return new Sim_FB_LK_BossSetup001();
                case CardDB.cardIDEnum.FB_LKStats001:
                    return new Sim_FB_LKStats001();
                case CardDB.cardIDEnum.FB_BuildABrawl001:
                    return new Sim_FB_BuildABrawl001();
                case CardDB.cardIDEnum.FB_BuildABrawl002:
                    return new Sim_FB_BuildABrawl002();
                case CardDB.cardIDEnum.FB_BuildABrawl003:
                    return new Sim_FB_BuildABrawl003();
                case CardDB.cardIDEnum.FB_ELO001:
                    return new Sim_FB_ELO001();
                case CardDB.cardIDEnum.TB_Champs_KeepWinnerDeck_Choice:
                    return new Sim_TB_Champs_KeepWinnerDeck_Choice();
                case CardDB.cardIDEnum.FB_IKC_AllStar_Setup_Ench:
                    return new Sim_FB_IKC_AllStar_Setup_Ench();
                case CardDB.cardIDEnum.FB_IKC_KeepOld_Ench:
                    return new Sim_FB_IKC_KeepOld_Ench();
                case CardDB.cardIDEnum.FB_IKC_KeepSetUp_Ench:
                    return new Sim_FB_IKC_KeepSetUp_Ench();
                case CardDB.cardIDEnum.TB_KTRAF_8:
                    return new Sim_TB_KTRAF_8();
                case CardDB.cardIDEnum.TB_Coopv3_103:
                    return new Sim_TB_Coopv3_103();
                case CardDB.cardIDEnum.TB_EVILBRM_Warrior_06:
                    return new Sim_TB_EVILBRM_Warrior_06();
                case CardDB.cardIDEnum.BRMA02_2_2_TB:
                    return new Sim_BRMA02_2_2_TB();
                case CardDB.cardIDEnum.BRMA02_2_2c_TB:
                    return new Sim_BRMA02_2_2c_TB();
                case CardDB.cardIDEnum.FB_Toki2_Hero:
                    return new Sim_FB_Toki2_Hero();
                case CardDB.cardIDEnum.TB_207CatacombQ:
                    return new Sim_TB_207CatacombQ();
                case CardDB.cardIDEnum.TB_Marin_001:
                    return new Sim_TB_Marin_001();
                case CardDB.cardIDEnum.TB_BossRumble_003:
                    return new Sim_TB_BossRumble_003();
                case CardDB.cardIDEnum.FB_Champs_EX1_166:
                    return new Sim_FB_Champs_EX1_166();
                case CardDB.cardIDEnum.TB_KTRAF_H_1:
                    return new Sim_TB_KTRAF_H_1();
                case CardDB.cardIDEnum.HRW02_3:
                    return new Sim_HRW02_3();
                case CardDB.cardIDEnum.TB_CoOpBossSpell_6:
                    return new Sim_TB_CoOpBossSpell_6();
                case CardDB.cardIDEnum.TB_LEAGUE_REVIVAL_BrannBoss:
                    return new Sim_TB_LEAGUE_REVIVAL_BrannBoss();
                case CardDB.cardIDEnum.TB_EVILBRM_TogwaggleH:
                    return new Sim_TB_EVILBRM_TogwaggleH();
                case CardDB.cardIDEnum.TB_John_002h:
                    return new Sim_TB_John_002h();
                case CardDB.cardIDEnum.FB_Champs_NEW1_019:
                    return new Sim_FB_Champs_NEW1_019();
                case CardDB.cardIDEnum.TB_SPT_DPromoSecret9e:
                    return new Sim_TB_SPT_DPromoSecret9e();
                case CardDB.cardIDEnum.TB_KTRAF_2:
                    return new Sim_TB_KTRAF_2();
                case CardDB.cardIDEnum.TB_KoboldGiftMinion:
                    return new Sim_TB_KoboldGiftMinion();
                case CardDB.cardIDEnum.TB_FoxBlessing1:
                    return new Sim_TB_FoxBlessing1();
                case CardDB.cardIDEnum.FB_Champs_ICC_221:
                    return new Sim_FB_Champs_ICC_221();
                case CardDB.cardIDEnum.FB_Champs_ICC_221e:
                    return new Sim_FB_Champs_ICC_221e();
                case CardDB.cardIDEnum.TB_EVILBRM_Rogue_12:
                    return new Sim_TB_EVILBRM_Rogue_12();
                case CardDB.cardIDEnum.FB_Champs_EX1_029:
                    return new Sim_FB_Champs_EX1_029();
                case CardDB.cardIDEnum.FB_Champs_LOOT_080:
                    return new Sim_FB_Champs_LOOT_080();
                case CardDB.cardIDEnum.FB_Champs_LOOT_333:
                    return new Sim_FB_Champs_LOOT_333();
                case CardDB.cardIDEnum.TB_LevelUp_001:
                    return new Sim_TB_LevelUp_001();
                case CardDB.cardIDEnum.FB_LKStats002:
                    return new Sim_FB_LKStats002();
                case CardDB.cardIDEnum.FB_LKStats002ench:
                    return new Sim_FB_LKStats002ench();
                case CardDB.cardIDEnum.TB_SPT_DPromoSpell1:
                    return new Sim_TB_SPT_DPromoSpell1();
                case CardDB.cardIDEnum.TB_MammothParty_s101b:
                    return new Sim_TB_MammothParty_s101b();
                case CardDB.cardIDEnum.EVILBRM_DALA_Warlock_09:
                    return new Sim_EVILBRM_DALA_Warlock_09();
                case CardDB.cardIDEnum.BRMC_100:
                    return new Sim_BRMC_100();
                case CardDB.cardIDEnum.BRMC_100e:
                    return new Sim_BRMC_100e();
                case CardDB.cardIDEnum.BRMC_90:
                    return new Sim_BRMC_90();
                case CardDB.cardIDEnum.FB_LKDebug001:
                    return new Sim_FB_LKDebug001();
                case CardDB.cardIDEnum.FB_LKDebug002:
                    return new Sim_FB_LKDebug002();
                case CardDB.cardIDEnum.FB_LK_012h:
                    return new Sim_FB_LK_012h();
                case CardDB.cardIDEnum.TB_BoomAnnoy_001e:
                    return new Sim_TB_BoomAnnoy_001e();
                case CardDB.cardIDEnum.BRMC_85:
                    return new Sim_BRMC_85();
                case CardDB.cardIDEnum.TB_EVILBRM_LazulH:
                    return new Sim_TB_EVILBRM_LazulH();
                case CardDB.cardIDEnum.TB_CoopHero_HP_001:
                    return new Sim_TB_CoopHero_HP_001();
                case CardDB.cardIDEnum.FB_Juggernaut_Mage:
                    return new Sim_FB_Juggernaut_Mage();
                case CardDB.cardIDEnum.FB_LK_Mage_copy:
                    return new Sim_FB_LK_Mage_copy();
                case CardDB.cardIDEnum.TBA01_5e:
                    return new Sim_TBA01_5e();
                case CardDB.cardIDEnum.TB_BossBattle_KoboldHP:
                    return new Sim_TB_BossBattle_KoboldHP();
                case CardDB.cardIDEnum.TB_John_002p:
                    return new Sim_TB_John_002p();
                case CardDB.cardIDEnum.TB_EVILBRM_LOOTA_813:
                    return new Sim_TB_EVILBRM_LOOTA_813();
                case CardDB.cardIDEnum.TB_Coopv3_104:
                    return new Sim_TB_Coopv3_104();
                case CardDB.cardIDEnum.TB_Coopv3_104_NewClasses:
                    return new Sim_TB_Coopv3_104_NewClasses();
                case CardDB.cardIDEnum.TB_DK_Malfurion:
                    return new Sim_TB_DK_Malfurion();
                case CardDB.cardIDEnum.FB_Champs_NEW1_012:
                    return new Sim_FB_Champs_NEW1_012();
                case CardDB.cardIDEnum.KARA_13_17:
                    return new Sim_KARA_13_17();
                case CardDB.cardIDEnum.FB_BuildABrawl002b_ench:
                    return new Sim_FB_BuildABrawl002b_ench();
                case CardDB.cardIDEnum.FB_LK_BossSetup001a:
                    return new Sim_FB_LK_BossSetup001a();
                case CardDB.cardIDEnum.TB_KTRAF_08w:
                    return new Sim_TB_KTRAF_08w();
                case CardDB.cardIDEnum.TB_207masterChest:
                    return new Sim_TB_207masterChest();
                case CardDB.cardIDEnum.FB_Annoyo_002d:
                    return new Sim_FB_Annoyo_002d();
                case CardDB.cardIDEnum.BRMA07_2_2_TB:
                    return new Sim_BRMA07_2_2_TB();
                case CardDB.cardIDEnum.BRMA07_2_2c_TB:
                    return new Sim_BRMA07_2_2c_TB();
                case CardDB.cardIDEnum.TB_MechWar_Minion1:
                    return new Sim_TB_MechWar_Minion1();
                case CardDB.cardIDEnum.TB_CoOpv3_203:
                    return new Sim_TB_CoOpv3_203();
                case CardDB.cardIDEnum.TB_FoxBlessing4:
                    return new Sim_TB_FoxBlessing4();
                case CardDB.cardIDEnum.TB_Firefest2_001:
                    return new Sim_TB_Firefest2_001();
                case CardDB.cardIDEnum.TB_EVILBRM_Warrior_01:
                    return new Sim_TB_EVILBRM_Warrior_01();
                case CardDB.cardIDEnum.KARA_13_22:
                    return new Sim_KARA_13_22();
                case CardDB.cardIDEnum.TB_SC20_004:
                    return new Sim_TB_SC20_004();
                case CardDB.cardIDEnum.TB_SC20_001c:
                    return new Sim_TB_SC20_001c();
                case CardDB.cardIDEnum.TB_Mini_1e:
                    return new Sim_TB_Mini_1e();
                case CardDB.cardIDEnum.FB_Toki_BadMinion:
                    return new Sim_FB_Toki_BadMinion();
                case CardDB.cardIDEnum.TB_FireFestival_MRag:
                    return new Sim_TB_FireFestival_MRag();
                case CardDB.cardIDEnum.TB_EVILBRM_Priest_11:
                    return new Sim_TB_EVILBRM_Priest_11();
                case CardDB.cardIDEnum.TB_KeepWinnerDeck_Mirror:
                    return new Sim_TB_KeepWinnerDeck_Mirror();
                case CardDB.cardIDEnum.FB_LKStats002c:
                    return new Sim_FB_LKStats002c();
                case CardDB.cardIDEnum.FB_LKStats001d:
                    return new Sim_FB_LKStats001d();
                case CardDB.cardIDEnum.BRMC_87:
                    return new Sim_BRMC_87();
                case CardDB.cardIDEnum.TBA01_6:
                    return new Sim_TBA01_6();
                case CardDB.cardIDEnum.TB_SPT_DPromoSpellBovine1:
                    return new Sim_TB_SPT_DPromoSpellBovine1();
                case CardDB.cardIDEnum.FB_SPT_AnnoyO_Ench:
                    return new Sim_FB_SPT_AnnoyO_Ench();
                case CardDB.cardIDEnum.TB_Firefest2a:
                    return new Sim_TB_Firefest2a();
                case CardDB.cardIDEnum.TB_Firefest2b:
                    return new Sim_TB_Firefest2b();
                case CardDB.cardIDEnum.TB_LEAGUE_REVIVAL_FinleySwap:
                    return new Sim_TB_LEAGUE_REVIVAL_FinleySwap();
                case CardDB.cardIDEnum.TB_Firefest2d:
                    return new Sim_TB_Firefest2d();
                case CardDB.cardIDEnum.TB_Firefest2c:
                    return new Sim_TB_Firefest2c();
                case CardDB.cardIDEnum.TB_Henchmania_MrChu:
                    return new Sim_TB_Henchmania_MrChu();
                case CardDB.cardIDEnum.TB_PickYourFate_11b:
                    return new Sim_TB_PickYourFate_11b();
                case CardDB.cardIDEnum.TB_DeckRecipe_MyDeckID:
                    return new Sim_TB_DeckRecipe_MyDeckID();
                case CardDB.cardIDEnum.TB_Henchmania_Myra:
                    return new Sim_TB_Henchmania_Myra();
                case CardDB.cardIDEnum.TB_Pilot1:
                    return new Sim_TB_Pilot1();
                case CardDB.cardIDEnum.TB_MnkWf01:
                    return new Sim_TB_MnkWf01();
                case CardDB.cardIDEnum.FB_Champs_LOE_038:
                    return new Sim_FB_Champs_LOE_038();
                case CardDB.cardIDEnum.TB_LEAGUE_REVIVAL_Druid_05:
                    return new Sim_TB_LEAGUE_REVIVAL_Druid_05();
                case CardDB.cardIDEnum.TB_Henchmania_MyraH:
                    return new Sim_TB_Henchmania_MyraH();
                case CardDB.cardIDEnum.TB_KTRAF_HP_KT_3:
                    return new Sim_TB_KTRAF_HP_KT_3();
                case CardDB.cardIDEnum.TB_CoOpv3_Boss:
                    return new Sim_TB_CoOpv3_Boss();
                case CardDB.cardIDEnum.TB_CoOpv3_Boss_FB:
                    return new Sim_TB_CoOpv3_Boss_FB();
                case CardDB.cardIDEnum.TB_CoOpv3_Boss_NewClasses:
                    return new Sim_TB_CoOpv3_Boss_NewClasses();
                case CardDB.cardIDEnum.TB_EVILBRM_Nefarian:
                    return new Sim_TB_EVILBRM_Nefarian();
                case CardDB.cardIDEnum.TBA01_4:
                    return new Sim_TBA01_4();
                case CardDB.cardIDEnum.TB_CoopHero_001:
                    return new Sim_TB_CoopHero_001();
                case CardDB.cardIDEnum.FB_LK_NewHeroCards:
                    return new Sim_FB_LK_NewHeroCards();
                case CardDB.cardIDEnum.TB_TagTeam_NewHeroCards:
                    return new Sim_TB_TagTeam_NewHeroCards();
                case CardDB.cardIDEnum.FB_TagTeam_Druid_Ench:
                    return new Sim_FB_TagTeam_Druid_Ench();
                case CardDB.cardIDEnum.FB_LK_Druid_Ench_copy:
                    return new Sim_FB_LK_Druid_Ench_copy();
                case CardDB.cardIDEnum.FB_TagTeam_Hunter_Ench:
                    return new Sim_FB_TagTeam_Hunter_Ench();
                case CardDB.cardIDEnum.FB_LK_Hunter_Ench_copy:
                    return new Sim_FB_LK_Hunter_Ench_copy();
                case CardDB.cardIDEnum.FB_TagTeam_Mage_Ench:
                    return new Sim_FB_TagTeam_Mage_Ench();
                case CardDB.cardIDEnum.FB_LK_Mage_Ench_copy:
                    return new Sim_FB_LK_Mage_Ench_copy();
                case CardDB.cardIDEnum.FB_TagTeam_Paladin_Ench:
                    return new Sim_FB_TagTeam_Paladin_Ench();
                case CardDB.cardIDEnum.FB_LK_Paladin_Ench_copy:
                    return new Sim_FB_LK_Paladin_Ench_copy();
                case CardDB.cardIDEnum.FB_TagTeam_Priest_Ench:
                    return new Sim_FB_TagTeam_Priest_Ench();
                case CardDB.cardIDEnum.FB_LK_Priest_Ench_copy:
                    return new Sim_FB_LK_Priest_Ench_copy();
                case CardDB.cardIDEnum.FB_TagTeam_Rogue_Ench:
                    return new Sim_FB_TagTeam_Rogue_Ench();
                case CardDB.cardIDEnum.FB_LK_Rogue_Ench_copy:
                    return new Sim_FB_LK_Rogue_Ench_copy();
                case CardDB.cardIDEnum.FB_TagTeam_Shaman_Ench:
                    return new Sim_FB_TagTeam_Shaman_Ench();
                case CardDB.cardIDEnum.FB_LK_Shaman_Ench_copy:
                    return new Sim_FB_LK_Shaman_Ench_copy();
                case CardDB.cardIDEnum.FB_TagTeam_Warlock_Ench:
                    return new Sim_FB_TagTeam_Warlock_Ench();
                case CardDB.cardIDEnum.FB_LK_Warlock_Ench_copy:
                    return new Sim_FB_LK_Warlock_Ench_copy();
                case CardDB.cardIDEnum.FB_TagTeam_Warrior_Ench:
                    return new Sim_FB_TagTeam_Warrior_Ench();
                case CardDB.cardIDEnum.FB_LK_Warrior_Ench_copy:
                    return new Sim_FB_LK_Warrior_Ench_copy();
                case CardDB.cardIDEnum.TB_IgnoblegardenEgg:
                    return new Sim_TB_IgnoblegardenEgg();
                case CardDB.cardIDEnum.TB_Noblegarden_002:
                    return new Sim_TB_Noblegarden_002();
                case CardDB.cardIDEnum.TB_Noblegarden_002t2:
                    return new Sim_TB_Noblegarden_002t2();
                case CardDB.cardIDEnum.TB_Noblegarden_004:
                    return new Sim_TB_Noblegarden_004();
                case CardDB.cardIDEnum.TB_MammothParty_s998:
                    return new Sim_TB_MammothParty_s998();
                case CardDB.cardIDEnum.FB_LK_BossSetup001c:
                    return new Sim_FB_LK_BossSetup001c();
                case CardDB.cardIDEnum.TB_KTRAF_10:
                    return new Sim_TB_KTRAF_10();
                case CardDB.cardIDEnum.FB_Champs_EX1_164:
                    return new Sim_FB_Champs_EX1_164();
                case CardDB.cardIDEnum.TB_LEAGUE_REVIVAL_Druid_07:
                    return new Sim_TB_LEAGUE_REVIVAL_Druid_07();
                case CardDB.cardIDEnum.TB_Superfriends001:
                    return new Sim_TB_Superfriends001();
                case CardDB.cardIDEnum.TB_EVILBRM_Priest_06:
                    return new Sim_TB_EVILBRM_Priest_06();
                case CardDB.cardIDEnum.TBST_004:
                    return new Sim_TBST_004();
                case CardDB.cardIDEnum.TBST_003:
                    return new Sim_TBST_003();
                case CardDB.cardIDEnum.TBST_002:
                    return new Sim_TBST_002();
                case CardDB.cardIDEnum.TBST_001:
                    return new Sim_TBST_001();
                case CardDB.cardIDEnum.TBST_005:
                    return new Sim_TBST_005();
                case CardDB.cardIDEnum.TBST_006:
                    return new Sim_TBST_006();
                case CardDB.cardIDEnum.TB_FW_Warpere:
                    return new Sim_TB_FW_Warpere();
                case CardDB.cardIDEnum.TB_FW_Warper:
                    return new Sim_TB_FW_Warper();
                case CardDB.cardIDEnum.BRMC_93:
                    return new Sim_BRMC_93();
                case CardDB.cardIDEnum.TB_EVILBRM_Omnotron01:
                    return new Sim_TB_EVILBRM_Omnotron01();
                case CardDB.cardIDEnum.TB_EVILBRM_Onyxia01:
                    return new Sim_TB_EVILBRM_Onyxia01();
                case CardDB.cardIDEnum.BRMA09_2_TB:
                    return new Sim_BRMA09_2_TB();
                case CardDB.cardIDEnum.BRMC_83:
                    return new Sim_BRMC_83();
                case CardDB.cardIDEnum.FB_Juggernaut_Druid_Ench:
                    return new Sim_FB_Juggernaut_Druid_Ench();
                case CardDB.cardIDEnum.FB_Juggernaut_Hunter_Ench:
                    return new Sim_FB_Juggernaut_Hunter_Ench();
                case CardDB.cardIDEnum.FB_Juggernaut_Mage_Ench:
                    return new Sim_FB_Juggernaut_Mage_Ench();
                case CardDB.cardIDEnum.FB_Juggernaut_Paladin_Ench:
                    return new Sim_FB_Juggernaut_Paladin_Ench();
                case CardDB.cardIDEnum.FB_Juggernaut_Priest_Ench:
                    return new Sim_FB_Juggernaut_Priest_Ench();
                case CardDB.cardIDEnum.FB_Juggernaut_Rogue_Ench:
                    return new Sim_FB_Juggernaut_Rogue_Ench();
                case CardDB.cardIDEnum.FB_Juggernaut_Shaman_Ench:
                    return new Sim_FB_Juggernaut_Shaman_Ench();
                case CardDB.cardIDEnum.FB_Juggernaut_Warlock_Ench:
                    return new Sim_FB_Juggernaut_Warlock_Ench();
                case CardDB.cardIDEnum.FB_Juggernaut_Warrior_Ench:
                    return new Sim_FB_Juggernaut_Warrior_Ench();
                case CardDB.cardIDEnum.TB_Noblegarden_003t5e:
                    return new Sim_TB_Noblegarden_003t5e();
                case CardDB.cardIDEnum.TB_Noblegarden_003t5e2:
                    return new Sim_TB_Noblegarden_003t5e2();
                case CardDB.cardIDEnum.TB_Noblegarden_003t5:
                    return new Sim_TB_Noblegarden_003t5();
                case CardDB.cardIDEnum.TB_SPT_MTH_Minion3:
                    return new Sim_TB_SPT_MTH_Minion3();
                case CardDB.cardIDEnum.HRW02_1e:
                    return new Sim_HRW02_1e();
                case CardDB.cardIDEnum.TB_CoOpBossSpell_4:
                    return new Sim_TB_CoOpBossSpell_4();
                case CardDB.cardIDEnum.TB_CoOp_Mechazod2:
                    return new Sim_TB_CoOp_Mechazod2();
                case CardDB.cardIDEnum.TB_EVILBRM_BoomHeroPower:
                    return new Sim_TB_EVILBRM_BoomHeroPower();
                case CardDB.cardIDEnum.FB_Toki_SummonParadoxes:
                    return new Sim_FB_Toki_SummonParadoxes();
                case CardDB.cardIDEnum.FB_Juggernaut_Paladin:
                    return new Sim_FB_Juggernaut_Paladin();
                case CardDB.cardIDEnum.FB_LK_Paladin_copy:
                    return new Sim_FB_LK_Paladin_copy();
                case CardDB.cardIDEnum.TB_ShrinesPaladin:
                    return new Sim_TB_ShrinesPaladin();
                case CardDB.cardIDEnum.FB_Toki_Boss_Minion1:
                    return new Sim_FB_Toki_Boss_Minion1();
                case CardDB.cardIDEnum.TB_SPT_MTH_BossWeapon:
                    return new Sim_TB_SPT_MTH_BossWeapon();
                case CardDB.cardIDEnum.TB_SPT_MTH_Minion2:
                    return new Sim_TB_SPT_MTH_Minion2();
                case CardDB.cardIDEnum.TB_SPT_MTH_BossHeroPower:
                    return new Sim_TB_SPT_MTH_BossHeroPower();
                case CardDB.cardIDEnum.TB_SPT_MTH_Boss3:
                    return new Sim_TB_SPT_MTH_Boss3();
                case CardDB.cardIDEnum.TB_MammothParty_m001:
                    return new Sim_TB_MammothParty_m001();
                case CardDB.cardIDEnum.TB_MammothParty_m001_alt:
                    return new Sim_TB_MammothParty_m001_alt();
                case CardDB.cardIDEnum.KARA_13_20:
                    return new Sim_KARA_13_20();
                case CardDB.cardIDEnum.TB_KaraPortals_003:
                    return new Sim_TB_KaraPortals_003();
                case CardDB.cardIDEnum.TB_KaraPortal_001:
                    return new Sim_TB_KaraPortal_001();
                case CardDB.cardIDEnum.TB_MammothParty_s101:
                    return new Sim_TB_MammothParty_s101();
                case CardDB.cardIDEnum.TB_SPT_MTH_Boss2:
                    return new Sim_TB_SPT_MTH_Boss2();
                case CardDB.cardIDEnum.FB_Champs_CFM_637:
                    return new Sim_FB_Champs_CFM_637();
                case CardDB.cardIDEnum.TB_KTRAF_12:
                    return new Sim_TB_KTRAF_12();
                case CardDB.cardIDEnum.TB_MammothParty_hp002:
                    return new Sim_TB_MammothParty_hp002();
                case CardDB.cardIDEnum.TB_DiscoverMyDeck_Discovery:
                    return new Sim_TB_DiscoverMyDeck_Discovery();
                case CardDB.cardIDEnum.TB_HeadlessHorseman_GameEnch:
                    return new Sim_TB_HeadlessHorseman_GameEnch();
                case CardDB.cardIDEnum.FB_Juggernaut_PickClass_Column:
                    return new Sim_FB_Juggernaut_PickClass_Column();
                case CardDB.cardIDEnum.FB_Juggernaut_PickClass_Row:
                    return new Sim_FB_Juggernaut_PickClass_Row();
                case CardDB.cardIDEnum.TB_PickYourFate_1_Ench:
                    return new Sim_TB_PickYourFate_1_Ench();
                case CardDB.cardIDEnum.TB_PickYourFate_2_Ench:
                    return new Sim_TB_PickYourFate_2_Ench();
                case CardDB.cardIDEnum.TB_PickYourFate_3_Ench:
                    return new Sim_TB_PickYourFate_3_Ench();
                case CardDB.cardIDEnum.TB_PickYourFate_4_Ench:
                    return new Sim_TB_PickYourFate_4_Ench();
                case CardDB.cardIDEnum.TB_PickYourFate_5_Ench:
                    return new Sim_TB_PickYourFate_5_Ench();
                case CardDB.cardIDEnum.TB_PickYourFate:
                    return new Sim_TB_PickYourFate();
                case CardDB.cardIDEnum.TB_PickYourFateRandom:
                    return new Sim_TB_PickYourFateRandom();
                case CardDB.cardIDEnum.TB_PickYourFate_2nd:
                    return new Sim_TB_PickYourFate_2nd();
                case CardDB.cardIDEnum.TB_ClassRandom_Pick2nd_100th:
                    return new Sim_TB_ClassRandom_Pick2nd_100th();
                case CardDB.cardIDEnum.TB_ClassRandom_PickSecondClass:
                    return new Sim_TB_ClassRandom_PickSecondClass();
                case CardDB.cardIDEnum.TB_LEAGUE_REVIVAL_FinleySandPile:
                    return new Sim_TB_LEAGUE_REVIVAL_FinleySandPile();
                case CardDB.cardIDEnum.BRMA01_2H_2_TB:
                    return new Sim_BRMA01_2H_2_TB();
                case CardDB.cardIDEnum.BRMA01_2H_2c_TB:
                    return new Sim_BRMA01_2H_2c_TB();
                case CardDB.cardIDEnum.TB_BRMA01_2H_2:
                    return new Sim_TB_BRMA01_2H_2();
                case CardDB.cardIDEnum.TB_MammothParty_Boss002:
                    return new Sim_TB_MammothParty_Boss002();
                case CardDB.cardIDEnum.TB_Noblegarden_003t6e:
                    return new Sim_TB_Noblegarden_003t6e();
                case CardDB.cardIDEnum.TB_Noblegarden_003t6e2:
                    return new Sim_TB_Noblegarden_003t6e2();
                case CardDB.cardIDEnum.TB_Noblegarden_003t6:
                    return new Sim_TB_Noblegarden_003t6();
                case CardDB.cardIDEnum.TB_EVILBRM_Priest_07:
                    return new Sim_TB_EVILBRM_Priest_07();
                case CardDB.cardIDEnum.TB_015:
                    return new Sim_TB_015();
                case CardDB.cardIDEnum.TB_HeadlessHorseman_s001c:
                    return new Sim_TB_HeadlessHorseman_s001c();
                case CardDB.cardIDEnum.TB_BountyHunter_Plaguemaster:
                    return new Sim_TB_BountyHunter_Plaguemaster();
                case CardDB.cardIDEnum.FB_IKC_SetupNo:
                    return new Sim_FB_IKC_SetupNo();
                case CardDB.cardIDEnum.FB_ELO001a:
                    return new Sim_FB_ELO001a();
                case CardDB.cardIDEnum.TB_013:
                    return new Sim_TB_013();
                case CardDB.cardIDEnum.NAX11_02H_2_TB:
                    return new Sim_NAX11_02H_2_TB();
                case CardDB.cardIDEnum.FB_Toki_TimePortal_Reload:
                    return new Sim_FB_Toki_TimePortal_Reload();
                case CardDB.cardIDEnum.TB_SC20_001:
                    return new Sim_TB_SC20_001();
                case CardDB.cardIDEnum.FB_Toki_TimePortal:
                    return new Sim_FB_Toki_TimePortal();
                case CardDB.cardIDEnum.FB_Champs_LOOT_306:
                    return new Sim_FB_Champs_LOOT_306();
                case CardDB.cardIDEnum.TB_CoopHero_002:
                    return new Sim_TB_CoopHero_002();
                case CardDB.cardIDEnum.TB_Presents_001:
                    return new Sim_TB_Presents_001();
                case CardDB.cardIDEnum.FB_Juggernaut_Priest:
                    return new Sim_FB_Juggernaut_Priest();
                case CardDB.cardIDEnum.FB_LK_Priest_copy:
                    return new Sim_FB_LK_Priest_copy();
                case CardDB.cardIDEnum.TB_CoOpBossSpell_1:
                    return new Sim_TB_CoOpBossSpell_1();
                case CardDB.cardIDEnum.FB_LK_013h:
                    return new Sim_FB_LK_013h();
                case CardDB.cardIDEnum.TB_LEAGUE_REVIVAL_Druid_09:
                    return new Sim_TB_LEAGUE_REVIVAL_Druid_09();
                case CardDB.cardIDEnum.TB_HeadlessHorseman_003:
                    return new Sim_TB_HeadlessHorseman_003();
                case CardDB.cardIDEnum.TB_Noblegarden_003t2e:
                    return new Sim_TB_Noblegarden_003t2e();
                case CardDB.cardIDEnum.TB_Noblegarden_003t2e2:
                    return new Sim_TB_Noblegarden_003t2e2();
                case CardDB.cardIDEnum.TB_Noblegarden_003t2:
                    return new Sim_TB_Noblegarden_003t2();
                case CardDB.cardIDEnum.TB_Lethal002:
                    return new Sim_TB_Lethal002();
                case CardDB.cardIDEnum.TB_Lethal003:
                    return new Sim_TB_Lethal003();
                case CardDB.cardIDEnum.TB_Lethal007:
                    return new Sim_TB_Lethal007();
                case CardDB.cardIDEnum.TB_Lethal009:
                    return new Sim_TB_Lethal009();
                case CardDB.cardIDEnum.TB_Lethal004:
                    return new Sim_TB_Lethal004();
                case CardDB.cardIDEnum.TB_Lethal005:
                    return new Sim_TB_Lethal005();
                case CardDB.cardIDEnum.TB_Lethal006:
                    return new Sim_TB_Lethal006();
                case CardDB.cardIDEnum.TB_Lethal010:
                    return new Sim_TB_Lethal010();
                case CardDB.cardIDEnum.TB_Lethal008:
                    return new Sim_TB_Lethal008();
                case CardDB.cardIDEnum.TB_EVILBRM_RafaamH:
                    return new Sim_TB_EVILBRM_RafaamH();
                case CardDB.cardIDEnum.TB_KTRAF_H_2:
                    return new Sim_TB_KTRAF_H_2();
                case CardDB.cardIDEnum.TB_Frost_Rag:
                    return new Sim_TB_Frost_Rag();
                case CardDB.cardIDEnum.TB_EVILBRM_Ragnaros01:
                    return new Sim_TB_EVILBRM_Ragnaros01();
                case CardDB.cardIDEnum.TB_Firefest2_Rag_H:
                    return new Sim_TB_Firefest2_Rag_H();
                case CardDB.cardIDEnum.TB_FW_Rag:
                    return new Sim_TB_FW_Rag();
                case CardDB.cardIDEnum.TBA01_1:
                    return new Sim_TBA01_1();
                case CardDB.cardIDEnum.FB_RagRaid_InnkeeperTools:
                    return new Sim_FB_RagRaid_InnkeeperTools();
                case CardDB.cardIDEnum.TB_Coopv3_105:
                    return new Sim_TB_Coopv3_105();
                case CardDB.cardIDEnum.TB_FireFestival_Rakanishu:
                    return new Sim_TB_FireFestival_Rakanishu();
                case CardDB.cardIDEnum.TB_RandomHand_ench:
                    return new Sim_TB_RandomHand_ench();
                case CardDB.cardIDEnum.TB_RandomHand_spell:
                    return new Sim_TB_RandomHand_spell();
                case CardDB.cardIDEnum.FB_BuildABrawl001b:
                    return new Sim_FB_BuildABrawl001b();
                case CardDB.cardIDEnum.TB_207_Randomonium:
                    return new Sim_TB_207_Randomonium();
                case CardDB.cardIDEnum.FB_BuildABrawl001b_ench:
                    return new Sim_FB_BuildABrawl001b_ench();
                case CardDB.cardIDEnum.TB_MammothParty_s002ee:
                    return new Sim_TB_MammothParty_s002ee();
                case CardDB.cardIDEnum.FB_Champs_CFM_020e:
                    return new Sim_FB_Champs_CFM_020e();
                case CardDB.cardIDEnum.FB_Champs_CFM_020:
                    return new Sim_FB_Champs_CFM_020();
                case CardDB.cardIDEnum.BRMC_98:
                    return new Sim_BRMC_98();
                case CardDB.cardIDEnum.FB_Annoyo_001:
                    return new Sim_FB_Annoyo_001();
                case CardDB.cardIDEnum.TB_LEAGUE_REVIVAL_Druid_02:
                    return new Sim_TB_LEAGUE_REVIVAL_Druid_02();
                case CardDB.cardIDEnum.TB_Noblegarden_003t8e:
                    return new Sim_TB_Noblegarden_003t8e();
                case CardDB.cardIDEnum.TB_Noblegarden_003t8e2:
                    return new Sim_TB_Noblegarden_003t8e2();
                case CardDB.cardIDEnum.KARA_13_19:
                    return new Sim_KARA_13_19();
                case CardDB.cardIDEnum.TB_Noblegarden_003t8:
                    return new Sim_TB_Noblegarden_003t8();
                case CardDB.cardIDEnum.TB_EVILBRM_Shaman_10:
                    return new Sim_TB_EVILBRM_Shaman_10();
                case CardDB.cardIDEnum.TB_MammothParty_302:
                    return new Sim_TB_MammothParty_302();
                case CardDB.cardIDEnum.TB_CoOpBossSpell_3:
                    return new Sim_TB_CoOpBossSpell_3();
                case CardDB.cardIDEnum.FB_LK002:
                    return new Sim_FB_LK002();
                case CardDB.cardIDEnum.FB_LK005:
                    return new Sim_FB_LK005();
                case CardDB.cardIDEnum.TB_LEAGUE_REVIVAL_RenoAIHero:
                    return new Sim_TB_LEAGUE_REVIVAL_RenoAIHero();
                case CardDB.cardIDEnum.TB_LEAGUE_REVIVAL_RenoHistory:
                    return new Sim_TB_LEAGUE_REVIVAL_RenoHistory();
                case CardDB.cardIDEnum.TB_MP_02e:
                    return new Sim_TB_MP_02e();
                case CardDB.cardIDEnum.TB_Champs_KeepWinnerDeck_IK:
                    return new Sim_TB_Champs_KeepWinnerDeck_IK();
                case CardDB.cardIDEnum.TB_Champs_KeepWinnerDeck_Reset:
                    return new Sim_TB_Champs_KeepWinnerDeck_Reset();
                case CardDB.cardIDEnum.TB_RandomDeckRecipeResetDecks:
                    return new Sim_TB_RandomDeckRecipeResetDecks();
                case CardDB.cardIDEnum.FB_Champs_Reset:
                    return new Sim_FB_Champs_Reset();
                case CardDB.cardIDEnum.FB_ELO001b:
                    return new Sim_FB_ELO001b();
                case CardDB.cardIDEnum.TB_RandomDeckRecipeResetYours:
                    return new Sim_TB_RandomDeckRecipeResetYours();
                case CardDB.cardIDEnum.TB_LethalSetup001b:
                    return new Sim_TB_LethalSetup001b();
                case CardDB.cardIDEnum.TB_LEAGUE_REVIVAL_Druid_08:
                    return new Sim_TB_LEAGUE_REVIVAL_Druid_08();
                case CardDB.cardIDEnum.TB_MammothParty_301:
                    return new Sim_TB_MammothParty_301();
                case CardDB.cardIDEnum.BRMC_99e:
                    return new Sim_BRMC_99e();
                case CardDB.cardIDEnum.FB_Juggernaut_Rogue:
                    return new Sim_FB_Juggernaut_Rogue();
                case CardDB.cardIDEnum.FB_LK_Rogue_copy:
                    return new Sim_FB_LK_Rogue_copy();
                case CardDB.cardIDEnum.KARA_13_23:
                    return new Sim_KARA_13_23();
                case CardDB.cardIDEnum.TB_Ignoblegarden2:
                    return new Sim_TB_Ignoblegarden2();
                case CardDB.cardIDEnum.TB_Ignoblegarden2e:
                    return new Sim_TB_Ignoblegarden2e();
                case CardDB.cardIDEnum.TB_008:
                    return new Sim_TB_008();
                case CardDB.cardIDEnum.TB_TagTeam_Druid:
                    return new Sim_TB_TagTeam_Druid();
                case CardDB.cardIDEnum.TB_EVILBRM_Warrior_05:
                    return new Sim_TB_EVILBRM_Warrior_05();
                case CardDB.cardIDEnum.KARA_13_19e:
                    return new Sim_KARA_13_19e();
                case CardDB.cardIDEnum.TB_KaraPortal_003:
                    return new Sim_TB_KaraPortal_003();
                case CardDB.cardIDEnum.TB_Face_Ench1:
                    return new Sim_TB_Face_Ench1();
                case CardDB.cardIDEnum.TB_LEAGUE_REVIVAL_FinleyChest:
                    return new Sim_TB_LEAGUE_REVIVAL_FinleyChest();
                case CardDB.cardIDEnum.TB_KTRAF_11:
                    return new Sim_TB_KTRAF_11();
                case CardDB.cardIDEnum.FB_Champs_ICC_466:
                    return new Sim_FB_Champs_ICC_466();
                case CardDB.cardIDEnum.FB_Reload_SavedCard:
                    return new Sim_FB_Reload_SavedCard();
                case CardDB.cardIDEnum.TB_EVILBRM_Rogue_07:
                    return new Sim_TB_EVILBRM_Rogue_07();
                case CardDB.cardIDEnum.TB_DK_Garrosh:
                    return new Sim_TB_DK_Garrosh();
                case CardDB.cardIDEnum.TB_ClassRandom_Druid:
                    return new Sim_TB_ClassRandom_Druid();
                case CardDB.cardIDEnum.TB_ClassRandom_Hunter:
                    return new Sim_TB_ClassRandom_Hunter();
                case CardDB.cardIDEnum.TB_ClassRandom_Mage:
                    return new Sim_TB_ClassRandom_Mage();
                case CardDB.cardIDEnum.TB_ClassRandom_Paladin:
                    return new Sim_TB_ClassRandom_Paladin();
                case CardDB.cardIDEnum.TB_ClassRandom_Priest:
                    return new Sim_TB_ClassRandom_Priest();
                case CardDB.cardIDEnum.TB_ClassRandom_Rogue:
                    return new Sim_TB_ClassRandom_Rogue();
                case CardDB.cardIDEnum.TB_ClassRandom_Shaman:
                    return new Sim_TB_ClassRandom_Shaman();
                case CardDB.cardIDEnum.TB_ClassRandom_Warlock:
                    return new Sim_TB_ClassRandom_Warlock();
                case CardDB.cardIDEnum.TB_ClassRandom_Warrior:
                    return new Sim_TB_ClassRandom_Warrior();
                case CardDB.cardIDEnum.TB_3Wishes_Spell_2:
                    return new Sim_TB_3Wishes_Spell_2();
                case CardDB.cardIDEnum.TB_Coopv3_102a:
                    return new Sim_TB_Coopv3_102a();
                case CardDB.cardIDEnum.TB_HeadlessHorseman_HP5:
                    return new Sim_TB_HeadlessHorseman_HP5();
                case CardDB.cardIDEnum.TB_HeadlessHorseman_HP5e:
                    return new Sim_TB_HeadlessHorseman_HP5e();
                case CardDB.cardIDEnum.FB_BuildABrawl002c_ench:
                    return new Sim_FB_BuildABrawl002c_ench();
                case CardDB.cardIDEnum.FB_BuildABrawl002c:
                    return new Sim_FB_BuildABrawl002c();
                case CardDB.cardIDEnum.FB_Champs_SetEvent:
                    return new Sim_FB_Champs_SetEvent();
                case CardDB.cardIDEnum.FB_Champs_SetEventMulligan:
                    return new Sim_FB_Champs_SetEventMulligan();
                case CardDB.cardIDEnum.FB_IKC_SetupYes:
                    return new Sim_FB_IKC_SetupYes();
                case CardDB.cardIDEnum.TB_Coopv3_102:
                    return new Sim_TB_Coopv3_102();
                case CardDB.cardIDEnum.TB_ShadowReflection_001:
                    return new Sim_TB_ShadowReflection_001();
                case CardDB.cardIDEnum.TB_ShadowReflection_001e:
                    return new Sim_TB_ShadowReflection_001e();
                case CardDB.cardIDEnum.TB_GP_01e_copy1:
                    return new Sim_TB_GP_01e_copy1();
                case CardDB.cardIDEnum.TB_GP_03:
                    return new Sim_TB_GP_03();
                case CardDB.cardIDEnum.TB_GP_01e:
                    return new Sim_TB_GP_01e();
                case CardDB.cardIDEnum.TB_GP_01e_v2:
                    return new Sim_TB_GP_01e_v2();
                case CardDB.cardIDEnum.TB_DK_Anduin:
                    return new Sim_TB_DK_Anduin();
                case CardDB.cardIDEnum.TB_EVILBRM_Priest_04:
                    return new Sim_TB_EVILBRM_Priest_04();
                case CardDB.cardIDEnum.FB_Juggernaut_Shaman:
                    return new Sim_FB_Juggernaut_Shaman();
                case CardDB.cardIDEnum.FB_LK_Shaman_copy:
                    return new Sim_FB_LK_Shaman_copy();
                case CardDB.cardIDEnum.TB_BlingBrawl_Hero1p:
                    return new Sim_TB_BlingBrawl_Hero1p();
                case CardDB.cardIDEnum.TB_BlingBrawl_Hero1e:
                    return new Sim_TB_BlingBrawl_Hero1e();
                case CardDB.cardIDEnum.FB_Toki_Boss_Shielded:
                    return new Sim_FB_Toki_Boss_Shielded();
                case CardDB.cardIDEnum.TB_SPT_DPromoEnch3:
                    return new Sim_TB_SPT_DPromoEnch3();
                case CardDB.cardIDEnum.TB_SPT_Minion1:
                    return new Sim_TB_SPT_Minion1();
                case CardDB.cardIDEnum.TB_Noblegarden_003e:
                    return new Sim_TB_Noblegarden_003e();
                case CardDB.cardIDEnum.TB_Noblegarden_003:
                    return new Sim_TB_Noblegarden_003();
                case CardDB.cardIDEnum.TB_LEAGUE_REVIVAL_FinleySandHP:
                    return new Sim_TB_LEAGUE_REVIVAL_FinleySandHP();
                case CardDB.cardIDEnum.TB_SpeedRun_Show:
                    return new Sim_TB_SpeedRun_Show();
                case CardDB.cardIDEnum.TB_BountyHunt_Shudderwock:
                    return new Sim_TB_BountyHunt_Shudderwock();
                case CardDB.cardIDEnum.TB_Noblegarden_003t4e:
                    return new Sim_TB_Noblegarden_003t4e();
                case CardDB.cardIDEnum.TB_Noblegarden_003t4e2:
                    return new Sim_TB_Noblegarden_003t4e2();
                case CardDB.cardIDEnum.TB_Noblegarden_003t4:
                    return new Sim_TB_Noblegarden_003t4();
                case CardDB.cardIDEnum.FB_LK_014h:
                    return new Sim_FB_LK_014h();
                case CardDB.cardIDEnum.TB_HeadlessHorseman_002:
                    return new Sim_TB_HeadlessHorseman_002();
                case CardDB.cardIDEnum.TB_LEAGUE_REVIVAL_FinleyAIHero:
                    return new Sim_TB_LEAGUE_REVIVAL_FinleyAIHero();
                case CardDB.cardIDEnum.TB_LEAGUE_REVIVAL_FinleyHero:
                    return new Sim_TB_LEAGUE_REVIVAL_FinleyHero();
                case CardDB.cardIDEnum.TB_KTRAF_2s:
                    return new Sim_TB_KTRAF_2s();
                case CardDB.cardIDEnum.TB_HeadlessHorseman_HP1:
                    return new Sim_TB_HeadlessHorseman_HP1();
                case CardDB.cardIDEnum.TB_BossRumble_001hp:
                    return new Sim_TB_BossRumble_001hp();
                case CardDB.cardIDEnum.TB_SPT_DPromoHP2:
                    return new Sim_TB_SPT_DPromoHP2();
                case CardDB.cardIDEnum.FB_LK001:
                    return new Sim_FB_LK001();
                case CardDB.cardIDEnum.TB_MammothParty_s004:
                    return new Sim_TB_MammothParty_s004();
                case CardDB.cardIDEnum.BRMC_91:
                    return new Sim_BRMC_91();
                case CardDB.cardIDEnum.FB_Champs_EX1_308:
                    return new Sim_FB_Champs_EX1_308();
                case CardDB.cardIDEnum.TB_KTRAF_4m:
                    return new Sim_TB_KTRAF_4m();
                case CardDB.cardIDEnum.TB_HeadlessHorseman_005:
                    return new Sim_TB_HeadlessHorseman_005();
                case CardDB.cardIDEnum.TB_PickYourFate_8:
                    return new Sim_TB_PickYourFate_8();
                case CardDB.cardIDEnum.TB_Spellwrite_001:
                    return new Sim_TB_Spellwrite_001();
                case CardDB.cardIDEnum.TB_EVILBRM_Shaman_08:
                    return new Sim_TB_EVILBRM_Shaman_08();
                case CardDB.cardIDEnum.TB_EVILBRM_Rogue_11:
                    return new Sim_TB_EVILBRM_Rogue_11();
                case CardDB.cardIDEnum.FB_Champs_KAR_063:
                    return new Sim_FB_Champs_KAR_063();
                case CardDB.cardIDEnum.FB_ELO002a:
                    return new Sim_FB_ELO002a();
                case CardDB.cardIDEnum.FB_ELO002a_ench:
                    return new Sim_FB_ELO002a_ench();
                case CardDB.cardIDEnum.FB_ELO002c:
                    return new Sim_FB_ELO002c();
                case CardDB.cardIDEnum.FB_ELO002c_ench:
                    return new Sim_FB_ELO002c_ench();
                case CardDB.cardIDEnum.FB_ELO002b:
                    return new Sim_FB_ELO002b();
                case CardDB.cardIDEnum.FB_ELO002b_ench:
                    return new Sim_FB_ELO002b_ench();
                case CardDB.cardIDEnum.FB_Champs_LOOT_539:
                    return new Sim_FB_Champs_LOOT_539();
                case CardDB.cardIDEnum.FB_RagRaid_Draw:
                    return new Sim_FB_RagRaid_Draw();
                case CardDB.cardIDEnum.TB_KTRAF_HP_RAF3:
                    return new Sim_TB_KTRAF_HP_RAF3();
                case CardDB.cardIDEnum.TB_KTRAF_HP_RAF5:
                    return new Sim_TB_KTRAF_HP_RAF5();
                case CardDB.cardIDEnum.TB_KTRAF_HP_RAF4:
                    return new Sim_TB_KTRAF_HP_RAF4();
                case CardDB.cardIDEnum.TB_SPT_DPromoSpellPortal2:
                    return new Sim_TB_SPT_DPromoSpellPortal2();
                case CardDB.cardIDEnum.TB_SpeedRun_Start:
                    return new Sim_TB_SpeedRun_Start();
                case CardDB.cardIDEnum.TB_FoxBlessing5:
                    return new Sim_TB_FoxBlessing5();
                case CardDB.cardIDEnum.TB_GiftExchange_Treasure_Spell:
                    return new Sim_TB_GiftExchange_Treasure_Spell();
                case CardDB.cardIDEnum.TB_HeadlessHorseman_H2:
                    return new Sim_TB_HeadlessHorseman_H2();
                case CardDB.cardIDEnum.TB_HeadlessHorseman_H2b:
                    return new Sim_TB_HeadlessHorseman_H2b();
                case CardDB.cardIDEnum.TB_HeadlessHorseman_H2c:
                    return new Sim_TB_HeadlessHorseman_H2c();
                case CardDB.cardIDEnum.TB_HeadlessHorseman_H2a:
                    return new Sim_TB_HeadlessHorseman_H2a();
                case CardDB.cardIDEnum.TB_SPT_Minion3e:
                    return new Sim_TB_SPT_Minion3e();
                case CardDB.cardIDEnum.FB_Duelers_Endl:
                    return new Sim_FB_Duelers_Endl();
                case CardDB.cardIDEnum.FB_Duelers_SuddenDeath:
                    return new Sim_FB_Duelers_SuddenDeath();
                case CardDB.cardIDEnum.BRMC_94:
                    return new Sim_BRMC_94();
                case CardDB.cardIDEnum.TB_EVILBRM_GarrSummon:
                    return new Sim_TB_EVILBRM_GarrSummon();
                case CardDB.cardIDEnum.TB_SPT_DPromoSpell2:
                    return new Sim_TB_SPT_DPromoSpell2();
                case CardDB.cardIDEnum.FB_Toki_Boss_mental:
                    return new Sim_FB_Toki_Boss_mental();
                case CardDB.cardIDEnum.FB_BuildABrawl002a:
                    return new Sim_FB_BuildABrawl002a();
                case CardDB.cardIDEnum.FB_LK_Raid_Hero:
                    return new Sim_FB_LK_Raid_Hero();
                case CardDB.cardIDEnum.FB_LK_Raid_Hero_Battledamaged:
                    return new Sim_FB_LK_Raid_Hero_Battledamaged();
                case CardDB.cardIDEnum.KARA_13_16:
                    return new Sim_KARA_13_16();
                case CardDB.cardIDEnum.TB_SwapBossHeroPowerByClass:
                    return new Sim_TB_SwapBossHeroPowerByClass();
                case CardDB.cardIDEnum.FB_LK009:
                    return new Sim_FB_LK009();
                case CardDB.cardIDEnum.TB_SwapHeroWithDeathKnight:
                    return new Sim_TB_SwapHeroWithDeathKnight();
                case CardDB.cardIDEnum.TB_LEAGUE_REVIVAL_Druid_01:
                    return new Sim_TB_LEAGUE_REVIVAL_Druid_01();
                case CardDB.cardIDEnum.TB_SC20_003:
                    return new Sim_TB_SC20_003();
                case CardDB.cardIDEnum.TB_SC20_001b:
                    return new Sim_TB_SC20_001b();
                case CardDB.cardIDEnum.EVILBRM_DALA_Warlock_02:
                    return new Sim_EVILBRM_DALA_Warlock_02();
                case CardDB.cardIDEnum.TB_FactionWar_Boss_Rag_0:
                    return new Sim_TB_FactionWar_Boss_Rag_0();
                case CardDB.cardIDEnum.TB_FoxBlessing3:
                    return new Sim_TB_FoxBlessing3();
                case CardDB.cardIDEnum.TB_SPT_Minion3:
                    return new Sim_TB_SPT_Minion3();
                case CardDB.cardIDEnum.TagTeamIceBlock:
                    return new Sim_TagTeamIceBlock();
                case CardDB.cardIDEnum.TB_011:
                    return new Sim_TB_011();
                case CardDB.cardIDEnum.TOT_100e:
                    return new Sim_TOT_100e();
                case CardDB.cardIDEnum.TB_GreatCurves_01:
                    return new Sim_TB_GreatCurves_01();
                case CardDB.cardIDEnum.TB_RMC_001:
                    return new Sim_TB_RMC_001();
                case CardDB.cardIDEnum.TB_RandHero2_001:
                    return new Sim_TB_RandHero2_001();
                case CardDB.cardIDEnum.TB_207MaskedBallE:
                    return new Sim_TB_207MaskedBallE();
                case CardDB.cardIDEnum.TB_207TolBaradE:
                    return new Sim_TB_207TolBaradE();
                case CardDB.cardIDEnum.TB_MechWar_CommonCards:
                    return new Sim_TB_MechWar_CommonCards();
                case CardDB.cardIDEnum.TB_RandCardCost:
                    return new Sim_TB_RandCardCost();
                case CardDB.cardIDEnum.TBUD_1:
                    return new Sim_TBUD_1();
                case CardDB.cardIDEnum.TB_CoOpv3_101e:
                    return new Sim_TB_CoOpv3_101e();
                case CardDB.cardIDEnum.TB_SC20_002:
                    return new Sim_TB_SC20_002();
                case CardDB.cardIDEnum.TB_SC20_001a:
                    return new Sim_TB_SC20_001a();
                case CardDB.cardIDEnum.TB_LEAGUE_REVIVAL_Terraviss:
                    return new Sim_TB_LEAGUE_REVIVAL_Terraviss();
                case CardDB.cardIDEnum.FB_Champs_UNG_067:
                    return new Sim_FB_Champs_UNG_067();
                case CardDB.cardIDEnum.TB_SPT_DPromo_Hero2:
                    return new Sim_TB_SPT_DPromo_Hero2();
                case CardDB.cardIDEnum.FB_LK010:
                    return new Sim_FB_LK010();
                case CardDB.cardIDEnum.TB_Blizzcon2016_GoonsEnchant:
                    return new Sim_TB_Blizzcon2016_GoonsEnchant();
                case CardDB.cardIDEnum.TB_Blizzcon2016_LotusEnchant:
                    return new Sim_TB_Blizzcon2016_LotusEnchant();
                case CardDB.cardIDEnum.TB_Blizzcon2016_KabalEnchant:
                    return new Sim_TB_Blizzcon2016_KabalEnchant();
                case CardDB.cardIDEnum.BRMA06_2H_TB:
                    return new Sim_BRMA06_2H_TB();
                case CardDB.cardIDEnum.FB_BuildABrawl002b:
                    return new Sim_FB_BuildABrawl002b();
                case CardDB.cardIDEnum.TB_207_MaskedBall:
                    return new Sim_TB_207_MaskedBall();
                case CardDB.cardIDEnum.FB_TopX_Mystery:
                    return new Sim_FB_TopX_Mystery();
                case CardDB.cardIDEnum.TB_SPT_DPromo_EnterPortal:
                    return new Sim_TB_SPT_DPromo_EnterPortal();
                case CardDB.cardIDEnum.TB_SPT_DPromoSpellPortal:
                    return new Sim_TB_SPT_DPromoSpellPortal();
                case CardDB.cardIDEnum.TB_TagTeam_Warrior:
                    return new Sim_TB_TagTeam_Warrior();
                case CardDB.cardIDEnum.TB_BRMA10_3H:
                    return new Sim_TB_BRMA10_3H();
                case CardDB.cardIDEnum.TB_TagTeam_Rogue:
                    return new Sim_TB_TagTeam_Rogue();
                case CardDB.cardIDEnum.TB_207_VoidSingularity:
                    return new Sim_TB_207_VoidSingularity();
                case CardDB.cardIDEnum.EVILBRM_DALA_Rogue_02:
                    return new Sim_EVILBRM_DALA_Rogue_02();
                case CardDB.cardIDEnum.TB_EVILBRM_Rogue_02:
                    return new Sim_TB_EVILBRM_Rogue_02();
                case CardDB.cardIDEnum.TB_3Wishes_Spell_3:
                    return new Sim_TB_3Wishes_Spell_3();
                case CardDB.cardIDEnum.TB_DK_Thrall:
                    return new Sim_TB_DK_Thrall();
                case CardDB.cardIDEnum.FB_Toki_BossSpell_01:
                    return new Sim_FB_Toki_BossSpell_01();
                case CardDB.cardIDEnum.FB_Toki_AttackPlayers:
                    return new Sim_FB_Toki_AttackPlayers();
                case CardDB.cardIDEnum.FB_Toki_do_auto:
                    return new Sim_FB_Toki_do_auto();
                case CardDB.cardIDEnum.FB_LK006:
                    return new Sim_FB_LK006();
                case CardDB.cardIDEnum.FB_Toki_Hero:
                    return new Sim_FB_Toki_Hero();
                case CardDB.cardIDEnum.FB_RagRaid_InnkeeperReset:
                    return new Sim_FB_RagRaid_InnkeeperReset();
                case CardDB.cardIDEnum.TB_TagTeam_Shaman:
                    return new Sim_TB_TagTeam_Shaman();
                case CardDB.cardIDEnum.TB_BuildaBoss_404p:
                    return new Sim_TB_BuildaBoss_404p();
                case CardDB.cardIDEnum.FB_Champs_EX1_tk9:
                    return new Sim_FB_Champs_EX1_tk9();
                case CardDB.cardIDEnum.TB_EVILBRM_Rogue_03:
                    return new Sim_TB_EVILBRM_Rogue_03();
                case CardDB.cardIDEnum.TB_EVILBRM_DALA_Priest_09:
                    return new Sim_TB_EVILBRM_DALA_Priest_09();
                case CardDB.cardIDEnum.TB_CoOpv3_002:
                    return new Sim_TB_CoOpv3_002();
                case CardDB.cardIDEnum.TB_SPT_DpromoEX1_312:
                    return new Sim_TB_SPT_DpromoEX1_312();
                case CardDB.cardIDEnum.TB_TwoTurnsEnchant:
                    return new Sim_TB_TwoTurnsEnchant();
                case CardDB.cardIDEnum.TB_TagTeam_Priest:
                    return new Sim_TB_TagTeam_Priest();
                case CardDB.cardIDEnum.TB_KTRAF_104:
                    return new Sim_TB_KTRAF_104();
                case CardDB.cardIDEnum.TB_Henchmania_ChuH:
                    return new Sim_TB_Henchmania_ChuH();
                case CardDB.cardIDEnum.TB_KTRAF_Under:
                    return new Sim_TB_KTRAF_Under();
                case CardDB.cardIDEnum.FB_Champs_FP1_028:
                    return new Sim_FB_Champs_FP1_028();
                case CardDB.cardIDEnum.TB_Murlocs_Ench:
                    return new Sim_TB_Murlocs_Ench();
                case CardDB.cardIDEnum.TB_CoOpv3_104e:
                    return new Sim_TB_CoOpv3_104e();
                case CardDB.cardIDEnum.TB_TagTeam_Hunter:
                    return new Sim_TB_TagTeam_Hunter();
                case CardDB.cardIDEnum.FB_RagRaid_DeckRefresh:
                    return new Sim_FB_RagRaid_DeckRefresh();
                case CardDB.cardIDEnum.FB_Annoyo_002a:
                    return new Sim_FB_Annoyo_002a();
                case CardDB.cardIDEnum.FB_Annoyo_002b:
                    return new Sim_FB_Annoyo_002b();
                case CardDB.cardIDEnum.FB_Annoyo_002c:
                    return new Sim_FB_Annoyo_002c();
                case CardDB.cardIDEnum.TB_DK_Uther:
                    return new Sim_TB_DK_Uther();
                case CardDB.cardIDEnum.BRMC_97:
                    return new Sim_BRMC_97();
                case CardDB.cardIDEnum.TB_EVILBRM_Vaelastrasz:
                    return new Sim_TB_EVILBRM_Vaelastrasz();
                case CardDB.cardIDEnum.TB_DK_Valeera:
                    return new Sim_TB_DK_Valeera();
                case CardDB.cardIDEnum.TB_100th_001:
                    return new Sim_TB_100th_001();
                case CardDB.cardIDEnum.TB_Vargoth_ench:
                    return new Sim_TB_Vargoth_ench();
                case CardDB.cardIDEnum.TB_CoOpv3_202:
                    return new Sim_TB_CoOpv3_202();
                case CardDB.cardIDEnum.TB_SPT_DPromoSecret4:
                    return new Sim_TB_SPT_DPromoSecret4();
                case CardDB.cardIDEnum.TB_SPT_DPromoSecret10:
                    return new Sim_TB_SPT_DPromoSecret10();
                case CardDB.cardIDEnum.TB_SPT_DPromoSecret9:
                    return new Sim_TB_SPT_DPromoSecret9();
                case CardDB.cardIDEnum.TB_SPT_DPromoSecret5:
                    return new Sim_TB_SPT_DPromoSecret5();
                case CardDB.cardIDEnum.TB_SPT_DPromoSecre8:
                    return new Sim_TB_SPT_DPromoSecre8();
                case CardDB.cardIDEnum.TB_SPT_DPromoSecret1:
                    return new Sim_TB_SPT_DPromoSecret1();
                case CardDB.cardIDEnum.TB_SPT_DPromoSecret2:
                    return new Sim_TB_SPT_DPromoSecret2();
                case CardDB.cardIDEnum.TB_SPT_DPromoSecret7:
                    return new Sim_TB_SPT_DPromoSecret7();
                case CardDB.cardIDEnum.TB_SPT_DPromoSecret6:
                    return new Sim_TB_SPT_DPromoSecret6();
                case CardDB.cardIDEnum.TB_SPT_DPromoSecret3:
                    return new Sim_TB_SPT_DPromoSecret3();
                case CardDB.cardIDEnum.TB_Henchmania_VOController:
                    return new Sim_TB_Henchmania_VOController();
                case CardDB.cardIDEnum.TB_VoidSingularityMinion:
                    return new Sim_TB_VoidSingularityMinion();
                case CardDB.cardIDEnum.TB_VoidSingularityEnch:
                    return new Sim_TB_VoidSingularityEnch();
                case CardDB.cardIDEnum.FB_LK_WaitForDiscover:
                    return new Sim_FB_LK_WaitForDiscover();
                case CardDB.cardIDEnum.FB_TagTeam_WaitForDiscover:
                    return new Sim_FB_TagTeam_WaitForDiscover();
                case CardDB.cardIDEnum.KARA_13_15:
                    return new Sim_KARA_13_15();
                case CardDB.cardIDEnum.FB_Juggernaut_Warlock:
                    return new Sim_FB_Juggernaut_Warlock();
                case CardDB.cardIDEnum.FB_LK_Warlock_copy:
                    return new Sim_FB_LK_Warlock_copy();
                case CardDB.cardIDEnum.TB_ShrinesWarlock:
                    return new Sim_TB_ShrinesWarlock();
                case CardDB.cardIDEnum.FB_Juggernaut_Warrior:
                    return new Sim_FB_Juggernaut_Warrior();
                case CardDB.cardIDEnum.FB_LK_Warrior_copy:
                    return new Sim_FB_LK_Warrior_copy();
                case CardDB.cardIDEnum.TB_ShrinesWarrior:
                    return new Sim_TB_ShrinesWarrior();
                case CardDB.cardIDEnum.TB_SPT_DPromoCrate1:
                    return new Sim_TB_SPT_DPromoCrate1();
                case CardDB.cardIDEnum.NAX3_02_TB:
                    return new Sim_NAX3_02_TB();
                case CardDB.cardIDEnum.TB_LEAGUE_REVIVAL_TerravisHp:
                    return new Sim_TB_LEAGUE_REVIVAL_TerravisHp();
                case CardDB.cardIDEnum.TB_BountyHunt_Wharrgarbl:
                    return new Sim_TB_BountyHunt_Wharrgarbl();
                case CardDB.cardIDEnum.TB_EVILBRM_Priest_05:
                    return new Sim_TB_EVILBRM_Priest_05();
                case CardDB.cardIDEnum.TB_EVILBRM_OnyxiaHeroPower:
                    return new Sim_TB_EVILBRM_OnyxiaHeroPower();
                case CardDB.cardIDEnum.TB_207_ClonesAttack:
                    return new Sim_TB_207_ClonesAttack();
                case CardDB.cardIDEnum.BRMC_89:
                    return new Sim_BRMC_89();
                case CardDB.cardIDEnum.KAR_a10_Boss1H_TB:
                    return new Sim_KAR_a10_Boss1H_TB();
                case CardDB.cardIDEnum.KAR_a10_Boss1H_TB22:
                    return new Sim_KAR_a10_Boss1H_TB22();
                case CardDB.cardIDEnum.TB_CoOpv3_BOSSe:
                    return new Sim_TB_CoOpv3_BOSSe();
                case CardDB.cardIDEnum.FB_Champs_CS2_013:
                    return new Sim_FB_Champs_CS2_013();
                case CardDB.cardIDEnum.BRMA13_4_2_TB:
                    return new Sim_BRMA13_4_2_TB();
                case CardDB.cardIDEnum.TBA01_5:
                    return new Sim_TBA01_5();
                case CardDB.cardIDEnum.TB_SPT_Minion1e:
                    return new Sim_TB_SPT_Minion1e();
                case CardDB.cardIDEnum.TB_BountyHunt_Winslow:
                    return new Sim_TB_BountyHunt_Winslow();
                case CardDB.cardIDEnum.TB_GiftExchange_Treasure:
                    return new Sim_TB_GiftExchange_Treasure();
                case CardDB.cardIDEnum.TB_HeadlessHorseman_s001a:
                    return new Sim_TB_HeadlessHorseman_s001a();
                case CardDB.cardIDEnum.TB_HeadlessHorseman_HP4:
                    return new Sim_TB_HeadlessHorseman_HP4();
                case CardDB.cardIDEnum.FB_Toki_Boss_aggro:
                    return new Sim_FB_Toki_Boss_aggro();
                case CardDB.cardIDEnum.TB_Henchmania_DiscoverB:
                    return new Sim_TB_Henchmania_DiscoverB();
                case CardDB.cardIDEnum.TB_Henchmania_DiscoverBe:
                    return new Sim_TB_Henchmania_DiscoverBe();
                case CardDB.cardIDEnum.TB_Henchmania_DiscoverA:
                    return new Sim_TB_Henchmania_DiscoverA();
                case CardDB.cardIDEnum.TB_Henchmania_DiscoverAe:
                    return new Sim_TB_Henchmania_DiscoverAe();
                case CardDB.cardIDEnum.TB_Henchmania_DiscoverD:
                    return new Sim_TB_Henchmania_DiscoverD();
                case CardDB.cardIDEnum.TB_Henchmania_DiscoverDe:
                    return new Sim_TB_Henchmania_DiscoverDe();
                case CardDB.cardIDEnum.TB_Henchmania_DiscoverC:
                    return new Sim_TB_Henchmania_DiscoverC();
                case CardDB.cardIDEnum.TB_Henchmania_DiscoverCe:
                    return new Sim_TB_Henchmania_DiscoverCe();
                case CardDB.cardIDEnum.TB_HeadlessHorseman_005e:
                    return new Sim_TB_HeadlessHorseman_005e();
                case CardDB.cardIDEnum.TB_207_YellowBrick:
                    return new Sim_TB_207_YellowBrick();
                case CardDB.cardIDEnum.TB_YoggServant_Enchant:
                    return new Sim_TB_YoggServant_Enchant();
                case CardDB.cardIDEnum.TB_TagTeam_ClearBoard:
                    return new Sim_TB_TagTeam_ClearBoard();
                case CardDB.cardIDEnum.TB_ZombeastSpell:
                    return new Sim_TB_ZombeastSpell();
                case CardDB.cardIDEnum.TB_ZombeastEnch:
                    return new Sim_TB_ZombeastEnch();
                case CardDB.cardIDEnum.TB_Presents_003:
                    return new Sim_TB_Presents_003();
                case CardDB.cardIDEnum.AT_063:
                    return new Sim_AT_063();
                case CardDB.cardIDEnum.AT_071e:
                    return new Sim_AT_071e();
                case CardDB.cardIDEnum.AT_071:
                    return new Sim_AT_071();
                case CardDB.cardIDEnum.AT_053:
                    return new Sim_AT_053();
                case CardDB.cardIDEnum.AT_036:
                    return new Sim_AT_036();
                case CardDB.cardIDEnum.AT_004:
                    return new Sim_AT_004();
                case CardDB.cardIDEnum.AT_087:
                    return new Sim_AT_087();
                case CardDB.cardIDEnum.AT_077:
                    return new Sim_AT_077();
                case CardDB.cardIDEnum.AT_109:
                    return new Sim_AT_109();
                case CardDB.cardIDEnum.AT_108:
                    return new Sim_AT_108();
                case CardDB.cardIDEnum.AT_043:
                    return new Sim_AT_043();
                case CardDB.cardIDEnum.AT_045:
                    return new Sim_AT_045();
                case CardDB.cardIDEnum.AT_045eee:
                    return new Sim_AT_045eee();
                case CardDB.cardIDEnum.AT_062:
                    return new Sim_AT_062();
                case CardDB.cardIDEnum.AT_132_HUNTER:
                    return new Sim_AT_132_HUNTER();
                case CardDB.cardIDEnum.AT_064:
                    return new Sim_AT_064();
                case CardDB.cardIDEnum.AT_060:
                    return new Sim_AT_060();
                case CardDB.cardIDEnum.AT_035:
                    return new Sim_AT_035();
                case CardDB.cardIDEnum.AT_005t:
                    return new Sim_AT_005t();
                case CardDB.cardIDEnum.AT_124:
                    return new Sim_AT_124();
                case CardDB.cardIDEnum.AT_068:
                    return new Sim_AT_068();
                case CardDB.cardIDEnum.AT_068e:
                    return new Sim_AT_068e();
                case CardDB.cardIDEnum.AT_089:
                    return new Sim_AT_089();
                case CardDB.cardIDEnum.AT_089e:
                    return new Sim_AT_089e();
                case CardDB.cardIDEnum.AT_059:
                    return new Sim_AT_059();
                case CardDB.cardIDEnum.AT_116e:
                    return new Sim_AT_116e();
                case CardDB.cardIDEnum.AT_029:
                    return new Sim_AT_029();
                case CardDB.cardIDEnum.AT_033:
                    return new Sim_AT_033();
                case CardDB.cardIDEnum.AT_041e:
                    return new Sim_AT_041e();
                case CardDB.cardIDEnum.AT_102:
                    return new Sim_AT_102();
                case CardDB.cardIDEnum.AT_117e:
                    return new Sim_AT_117e();
                case CardDB.cardIDEnum.AT_050:
                    return new Sim_AT_050();
                case CardDB.cardIDEnum.AT_028e:
                    return new Sim_AT_028e();
                case CardDB.cardIDEnum.AT_123:
                    return new Sim_AT_123();
                case CardDB.cardIDEnum.AT_096:
                    return new Sim_AT_096();
                case CardDB.cardIDEnum.AT_008:
                    return new Sim_AT_008();
                case CardDB.cardIDEnum.AT_110:
                    return new Sim_AT_110();
                case CardDB.cardIDEnum.AT_073:
                    return new Sim_AT_073();
                case CardDB.cardIDEnum.AT_073e:
                    return new Sim_AT_073e();
                case CardDB.cardIDEnum.AT_018:
                    return new Sim_AT_018();
                case CardDB.cardIDEnum.AT_016:
                    return new Sim_AT_016();
                case CardDB.cardIDEnum.AT_016e:
                    return new Sim_AT_016e();
                case CardDB.cardIDEnum.AT_015:
                    return new Sim_AT_015();
                case CardDB.cardIDEnum.AT_121:
                    return new Sim_AT_121();
                case CardDB.cardIDEnum.AT_031:
                    return new Sim_AT_031();
                case CardDB.cardIDEnum.AT_006:
                    return new Sim_AT_006();
                case CardDB.cardIDEnum.AT_025:
                    return new Sim_AT_025();
                case CardDB.cardIDEnum.AT_024e:
                    return new Sim_AT_024e();
                case CardDB.cardIDEnum.AT_038:
                    return new Sim_AT_038();
                case CardDB.cardIDEnum.AT_024:
                    return new Sim_AT_024();
                case CardDB.cardIDEnum.AT_132_DRUIDe:
                    return new Sim_AT_132_DRUIDe();
                case CardDB.cardIDEnum.AT_132_DRUID:
                    return new Sim_AT_132_DRUID();
                case CardDB.cardIDEnum.AT_047:
                    return new Sim_AT_047();
                case CardDB.cardIDEnum.AT_083:
                    return new Sim_AT_083();
                case CardDB.cardIDEnum.AT_083e:
                    return new Sim_AT_083e();
                case CardDB.cardIDEnum.AT_063t:
                    return new Sim_AT_063t();
                case CardDB.cardIDEnum.AT_019:
                    return new Sim_AT_019();
                case CardDB.cardIDEnum.AT_019e:
                    return new Sim_AT_019e();
                case CardDB.cardIDEnum.AT_042:
                    return new Sim_AT_042();
                case CardDB.cardIDEnum.AT_042t:
                    return new Sim_AT_042t();
                case CardDB.cardIDEnum.AT_042t2:
                    return new Sim_AT_042t2();
                case CardDB.cardIDEnum.OG_044c:
                    return new Sim_OG_044c();
                case CardDB.cardIDEnum.AT_081:
                    return new Sim_AT_081();
                case CardDB.cardIDEnum.AT_002:
                    return new Sim_AT_002();
                case CardDB.cardIDEnum.AT_051:
                    return new Sim_AT_051();
                case CardDB.cardIDEnum.AT_045e:
                    return new Sim_AT_045e();
                case CardDB.cardIDEnum.AT_078:
                    return new Sim_AT_078();
                case CardDB.cardIDEnum.AT_084e:
                    return new Sim_AT_084e();
                case CardDB.cardIDEnum.AT_114:
                    return new Sim_AT_114();
                case CardDB.cardIDEnum.AT_047e:
                    return new Sim_AT_047e();
                case CardDB.cardIDEnum.AT_077e:
                    return new Sim_AT_077e();
                case CardDB.cardIDEnum.AT_029e:
                    return new Sim_AT_029e();
                case CardDB.cardIDEnum.AT_131:
                    return new Sim_AT_131();
                case CardDB.cardIDEnum.AT_003:
                    return new Sim_AT_003();
                case CardDB.cardIDEnum.AT_020:
                    return new Sim_AT_020();
                case CardDB.cardIDEnum.AT_021e:
                    return new Sim_AT_021e();
                case CardDB.cardIDEnum.AT_115:
                    return new Sim_AT_115();
                case CardDB.cardIDEnum.AT_115e:
                    return new Sim_AT_115e();
                case CardDB.cardIDEnum.AT_132_MAGE:
                    return new Sim_AT_132_MAGE();
                case CardDB.cardIDEnum.AT_022:
                    return new Sim_AT_022();
                case CardDB.cardIDEnum.AT_129:
                    return new Sim_AT_129();
                case CardDB.cardIDEnum.AT_094:
                    return new Sim_AT_094();
                case CardDB.cardIDEnum.AT_001:
                    return new Sim_AT_001();
                case CardDB.cardIDEnum.AT_055:
                    return new Sim_AT_055();
                case CardDB.cardIDEnum.AT_066e:
                    return new Sim_AT_066e();
                case CardDB.cardIDEnum.AT_093:
                    return new Sim_AT_093();
                case CardDB.cardIDEnum.AT_120:
                    return new Sim_AT_120();
                case CardDB.cardIDEnum.AT_133:
                    return new Sim_AT_133();
                case CardDB.cardIDEnum.AT_080:
                    return new Sim_AT_080();
                case CardDB.cardIDEnum.AT_122:
                    return new Sim_AT_122();
                case CardDB.cardIDEnum.AT_118:
                    return new Sim_AT_118();
                case CardDB.cardIDEnum.AT_037a:
                    return new Sim_AT_037a();
                case CardDB.cardIDEnum.AT_057o:
                    return new Sim_AT_057o();
                case CardDB.cardIDEnum.AT_132_PRIEST:
                    return new Sim_AT_132_PRIEST();
                case CardDB.cardIDEnum.AT_132_SHAMANa:
                    return new Sim_AT_132_SHAMANa();
                case CardDB.cardIDEnum.AT_048:
                    return new Sim_AT_048();
                case CardDB.cardIDEnum.AT_011:
                    return new Sim_AT_011();
                case CardDB.cardIDEnum.AT_121e:
                    return new Sim_AT_121e();
                case CardDB.cardIDEnum.AT_092:
                    return new Sim_AT_092();
                case CardDB.cardIDEnum.AT_125:
                    return new Sim_AT_125();
                case CardDB.cardIDEnum.AT_105:
                    return new Sim_AT_105();
                case CardDB.cardIDEnum.AT_109e:
                    return new Sim_AT_109e();
                case CardDB.cardIDEnum.AT_119e:
                    return new Sim_AT_119e();
                case CardDB.cardIDEnum.AT_132:
                    return new Sim_AT_132();
                case CardDB.cardIDEnum.AT_040e:
                    return new Sim_AT_040e();
                case CardDB.cardIDEnum.AT_065:
                    return new Sim_AT_065();
                case CardDB.cardIDEnum.AT_065e:
                    return new Sim_AT_065e();
                case CardDB.cardIDEnum.AT_058:
                    return new Sim_AT_058();
                case CardDB.cardIDEnum.AT_041:
                    return new Sim_AT_041();
                case CardDB.cardIDEnum.AT_099:
                    return new Sim_AT_099();
                case CardDB.cardIDEnum.AT_119:
                    return new Sim_AT_119();
                case CardDB.cardIDEnum.AT_034e:
                    return new Sim_AT_034e();
                case CardDB.cardIDEnum.AT_084:
                    return new Sim_AT_084();
                case CardDB.cardIDEnum.AT_050t:
                    return new Sim_AT_050t();
                case CardDB.cardIDEnum.AT_011e:
                    return new Sim_AT_011e();
                case CardDB.cardIDEnum.AT_106:
                    return new Sim_AT_106();
                case CardDB.cardIDEnum.AT_042a:
                    return new Sim_AT_042a();
                case CardDB.cardIDEnum.AT_037:
                    return new Sim_AT_037();
                case CardDB.cardIDEnum.AT_061:
                    return new Sim_AT_061();
                case CardDB.cardIDEnum.AT_061e:
                    return new Sim_AT_061e();
                case CardDB.cardIDEnum.AT_082:
                    return new Sim_AT_082();
                case CardDB.cardIDEnum.AT_067:
                    return new Sim_AT_067();
                case CardDB.cardIDEnum.AT_085:
                    return new Sim_AT_085();
                case CardDB.cardIDEnum.AT_085e:
                    return new Sim_AT_085e();
                case CardDB.cardIDEnum.AT_112:
                    return new Sim_AT_112();
                case CardDB.cardIDEnum.AT_117:
                    return new Sim_AT_117();
                case CardDB.cardIDEnum.AT_027e:
                    return new Sim_AT_027e();
                case CardDB.cardIDEnum.AT_075e:
                    return new Sim_AT_075e();
                case CardDB.cardIDEnum.AT_090e:
                    return new Sim_AT_090e();
                case CardDB.cardIDEnum.AT_045ee:
                    return new Sim_AT_045ee();
                case CardDB.cardIDEnum.AT_088:
                    return new Sim_AT_088();
                case CardDB.cardIDEnum.AT_090:
                    return new Sim_AT_090();
                case CardDB.cardIDEnum.AT_044:
                    return new Sim_AT_044();
                case CardDB.cardIDEnum.AT_076:
                    return new Sim_AT_076();
                case CardDB.cardIDEnum.AT_079:
                    return new Sim_AT_079();
                case CardDB.cardIDEnum.AT_036t:
                    return new Sim_AT_036t();
                case CardDB.cardIDEnum.AT_035t:
                    return new Sim_AT_035t();
                case CardDB.cardIDEnum.AT_127:
                    return new Sim_AT_127();
                case CardDB.cardIDEnum.AT_103:
                    return new Sim_AT_103();
                case CardDB.cardIDEnum.AT_037b:
                    return new Sim_AT_037b();
                case CardDB.cardIDEnum.AT_066:
                    return new Sim_AT_066();
                case CardDB.cardIDEnum.AT_042b:
                    return new Sim_AT_042b();
                case CardDB.cardIDEnum.AT_101:
                    return new Sim_AT_101();
                case CardDB.cardIDEnum.AT_034:
                    return new Sim_AT_034();
                case CardDB.cardIDEnum.AT_132_ROGUEt:
                    return new Sim_AT_132_ROGUEt();
                case CardDB.cardIDEnum.AT_132_ROGUE:
                    return new Sim_AT_132_ROGUE();
                case CardDB.cardIDEnum.AT_005:
                    return new Sim_AT_005();
                case CardDB.cardIDEnum.AT_006e:
                    return new Sim_AT_006e();
                case CardDB.cardIDEnum.AT_049e:
                    return new Sim_AT_049e();
                case CardDB.cardIDEnum.AT_013:
                    return new Sim_AT_013();
                case CardDB.cardIDEnum.AT_013e:
                    return new Sim_AT_013e();
                case CardDB.cardIDEnum.AT_056:
                    return new Sim_AT_056();
                case CardDB.cardIDEnum.AT_081e:
                    return new Sim_AT_081e();
                case CardDB.cardIDEnum.AT_010:
                    return new Sim_AT_010();
                case CardDB.cardIDEnum.AT_113:
                    return new Sim_AT_113();
                case CardDB.cardIDEnum.AT_111:
                    return new Sim_AT_111();
                case CardDB.cardIDEnum.AT_009:
                    return new Sim_AT_009();
                case CardDB.cardIDEnum.AT_086:
                    return new Sim_AT_086();
                case CardDB.cardIDEnum.AT_037t:
                    return new Sim_AT_037t();
                case CardDB.cardIDEnum.AT_039e:
                    return new Sim_AT_039e();
                case CardDB.cardIDEnum.AT_039:
                    return new Sim_AT_039();
                case CardDB.cardIDEnum.AT_130:
                    return new Sim_AT_130();
                case CardDB.cardIDEnum.AT_074:
                    return new Sim_AT_074();
                case CardDB.cardIDEnum.AT_074e2:
                    return new Sim_AT_074e2();
                case CardDB.cardIDEnum.AT_132_SHAMANb:
                    return new Sim_AT_132_SHAMANb();
                case CardDB.cardIDEnum.AT_028:
                    return new Sim_AT_028();
                case CardDB.cardIDEnum.AT_014:
                    return new Sim_AT_014();
                case CardDB.cardIDEnum.AT_014e:
                    return new Sim_AT_014e();
                case CardDB.cardIDEnum.AT_032:
                    return new Sim_AT_032();
                case CardDB.cardIDEnum.AT_032e:
                    return new Sim_AT_032e();
                case CardDB.cardIDEnum.AT_032e_copy:
                    return new Sim_AT_032e_copy();
                case CardDB.cardIDEnum.AT_098:
                    return new Sim_AT_098();
                case CardDB.cardIDEnum.AT_095:
                    return new Sim_AT_095();
                case CardDB.cardIDEnum.AT_100:
                    return new Sim_AT_100();
                case CardDB.cardIDEnum.AT_070:
                    return new Sim_AT_070();
                case CardDB.cardIDEnum.AT_132_WARLOCK:
                    return new Sim_AT_132_WARLOCK();
                case CardDB.cardIDEnum.AT_069:
                    return new Sim_AT_069();
                case CardDB.cardIDEnum.AT_012:
                    return new Sim_AT_012();
                case CardDB.cardIDEnum.AT_007:
                    return new Sim_AT_007();
                case CardDB.cardIDEnum.AT_057:
                    return new Sim_AT_057();
                case CardDB.cardIDEnum.AT_132_SHAMANc:
                    return new Sim_AT_132_SHAMANc();
                case CardDB.cardIDEnum.AT_132_WARRIOR:
                    return new Sim_AT_132_WARRIOR();
                case CardDB.cardIDEnum.AT_054:
                    return new Sim_AT_054();
                case CardDB.cardIDEnum.AT_132_PALADIN:
                    return new Sim_AT_132_PALADIN();
                case CardDB.cardIDEnum.AT_128:
                    return new Sim_AT_128();
                case CardDB.cardIDEnum.AT_049:
                    return new Sim_AT_049();
                case CardDB.cardIDEnum.AT_021:
                    return new Sim_AT_021();
                case CardDB.cardIDEnum.AT_052:
                    return new Sim_AT_052();
                case CardDB.cardIDEnum.AT_132_SHAMAN:
                    return new Sim_AT_132_SHAMAN();
                case CardDB.cardIDEnum.AT_097:
                    return new Sim_AT_097();
                case CardDB.cardIDEnum.AT_091:
                    return new Sim_AT_091();
                case CardDB.cardIDEnum.AT_082e:
                    return new Sim_AT_082e();
                case CardDB.cardIDEnum.AT_069e:
                    return new Sim_AT_069e();
                case CardDB.cardIDEnum.AT_104:
                    return new Sim_AT_104();
                case CardDB.cardIDEnum.AT_046:
                    return new Sim_AT_046();
                case CardDB.cardIDEnum.AT_017:
                    return new Sim_AT_017();
                case CardDB.cardIDEnum.AT_017e:
                    return new Sim_AT_017e();
                case CardDB.cardIDEnum.AT_030:
                    return new Sim_AT_030();
                case CardDB.cardIDEnum.AT_072:
                    return new Sim_AT_072();
                case CardDB.cardIDEnum.AT_133e:
                    return new Sim_AT_133e();
                case CardDB.cardIDEnum.AT_086e:
                    return new Sim_AT_086e();
                case CardDB.cardIDEnum.AT_023:
                    return new Sim_AT_023();
                case CardDB.cardIDEnum.AT_099t:
                    return new Sim_AT_099t();
                case CardDB.cardIDEnum.AT_075:
                    return new Sim_AT_075();
                case CardDB.cardIDEnum.AT_040:
                    return new Sim_AT_040();
                case CardDB.cardIDEnum.AT_027:
                    return new Sim_AT_027();
                case CardDB.cardIDEnum.AT_096e:
                    return new Sim_AT_096e();
                case CardDB.cardIDEnum.AT_132_SHAMANd:
                    return new Sim_AT_132_SHAMANd();
                case CardDB.cardIDEnum.AT_026:
                    return new Sim_AT_026();
                case CardDB.cardIDEnum.AT_116:
                    return new Sim_AT_116();
 ///case CardDB.cardIDEnum.///HERO_SKINS:
                    ///return new Sim_///HERO_SKINS();
                case CardDB.cardIDEnum.HERO_05a:
                    return new Sim_HERO_05a();
                case CardDB.cardIDEnum.CS2_102_H1:
                    return new Sim_CS2_102_H1();
                case CardDB.cardIDEnum.DS1h_292_H1_AT_132:
                    return new Sim_DS1h_292_H1_AT_132();
                case CardDB.cardIDEnum.CS2_083b_H1:
                    return new Sim_CS2_083b_H1();
                case CardDB.cardIDEnum.AT_132_DRUIDa:
                    return new Sim_AT_132_DRUIDa();
                case CardDB.cardIDEnum.AT_132_DRUIDb:
                    return new Sim_AT_132_DRUIDb();
                case CardDB.cardIDEnum.HERO_06b:
                    return new Sim_HERO_06b();
                case CardDB.cardIDEnum.CS2_034_H1:
                    return new Sim_CS2_034_H1();
                case CardDB.cardIDEnum.CS2_034_H2:
                    return new Sim_CS2_034_H2();
                case CardDB.cardIDEnum.CS2_034_H1_AT_132:
                    return new Sim_CS2_034_H1_AT_132();
                case CardDB.cardIDEnum.CS2_034_H2_AT_132:
                    return new Sim_CS2_034_H2_AT_132();
                case CardDB.cardIDEnum.CS1h_001_H1_AT_132:
                    return new Sim_CS1h_001_H1_AT_132();
                case CardDB.cardIDEnum.CS1h_001_H2_AT_132:
                    return new Sim_CS1h_001_H2_AT_132();
                case CardDB.cardIDEnum.HERO_08b:
                    return new Sim_HERO_08b();
                case CardDB.cardIDEnum.HERO_02b:
                    return new Sim_HERO_02b();
                case CardDB.cardIDEnum.HERO_04a:
                    return new Sim_HERO_04a();
                case CardDB.cardIDEnum.CS1h_001_H1:
                    return new Sim_CS1h_001_H1();
                case CardDB.cardIDEnum.CS1h_001_H2:
                    return new Sim_CS1h_001_H2();
                case CardDB.cardIDEnum.CS2_056_H1:
                    return new Sim_CS2_056_H1();
                case CardDB.cardIDEnum.CS2_056_H2:
                    return new Sim_CS2_056_H2();
                case CardDB.cardIDEnum.HERO_06a:
                    return new Sim_HERO_06a();
                case CardDB.cardIDEnum.HERO_09b:
                    return new Sim_HERO_09b();
                case CardDB.cardIDEnum.HERO_01a:
                    return new Sim_HERO_01a();
                case CardDB.cardIDEnum.HERO_03a:
                    return new Sim_HERO_03a();
                case CardDB.cardIDEnum.HERO_07b:
                    return new Sim_HERO_07b();
                case CardDB.cardIDEnum.HERO_08a:
                    return new Sim_HERO_08a();
                case CardDB.cardIDEnum.HERO_02a:
                    return new Sim_HERO_02a();
                case CardDB.cardIDEnum.HERO_07a:
                    return new Sim_HERO_07a();
                case CardDB.cardIDEnum.AT_132_ROGUEt_H1:
                    return new Sim_AT_132_ROGUEt_H1();
                case CardDB.cardIDEnum.AT_132_ROGUE_H1:
                    return new Sim_AT_132_ROGUE_H1();
                case CardDB.cardIDEnum.HERO_04b:
                    return new Sim_HERO_04b();
                case CardDB.cardIDEnum.CS2_101_H1:
                    return new Sim_CS2_101_H1();
                case CardDB.cardIDEnum.CS2_101_H2:
                    return new Sim_CS2_101_H2();
                case CardDB.cardIDEnum.CS2_101_H3:
                    return new Sim_CS2_101_H3();
                case CardDB.cardIDEnum.CS2_017_HS1:
                    return new Sim_CS2_017_HS1();
                case CardDB.cardIDEnum.CS2_017_HS2:
                    return new Sim_CS2_017_HS2();
                case CardDB.cardIDEnum.HERO_04c:
                    return new Sim_HERO_04c();
                case CardDB.cardIDEnum.AT_132_WARLOCKa:
                    return new Sim_AT_132_WARLOCKa();
                case CardDB.cardIDEnum.AT_132_WARLOCKb:
                    return new Sim_AT_132_WARLOCKb();
                case CardDB.cardIDEnum.DS1h_292_H1:
                    return new Sim_DS1h_292_H1();
                case CardDB.cardIDEnum.CS2_102_H1_AT_132:
                    return new Sim_CS2_102_H1_AT_132();
                case CardDB.cardIDEnum.CS2_101_H1_AT_132:
                    return new Sim_CS2_101_H1_AT_132();
                case CardDB.cardIDEnum.CS2_101_H2_AT_132:
                    return new Sim_CS2_101_H2_AT_132();
                case CardDB.cardIDEnum.CS2_101_H3_AT_132:
                    return new Sim_CS2_101_H3_AT_132();
                case CardDB.cardIDEnum.HERO_02c:
                    return new Sim_HERO_02c();
                case CardDB.cardIDEnum.CS2_049_H1:
                    return new Sim_CS2_049_H1();
                case CardDB.cardIDEnum.CS2_049_H2:
                    return new Sim_CS2_049_H2();
                case CardDB.cardIDEnum.CS2_049_H3:
                    return new Sim_CS2_049_H3();
                case CardDB.cardIDEnum.CS2_049_H1_AT_132:
                    return new Sim_CS2_049_H1_AT_132();
                case CardDB.cardIDEnum.CS2_049_H2_AT_132:
                    return new Sim_CS2_049_H2_AT_132();
                case CardDB.cardIDEnum.CS2_049_H3_AT_132:
                    return new Sim_CS2_049_H3_AT_132();
                case CardDB.cardIDEnum.HERO_09a:
                    return new Sim_HERO_09a();
                case CardDB.cardIDEnum.CS2_082_H1:
                    return new Sim_CS2_082_H1();
 ///case CardDB.cardIDEnum.///CORE:
                    ///return new Sim_///CORE();
                case CardDB.cardIDEnum.EX1_066:
                    return new Sim_EX1_066();
                case CardDB.cardIDEnum.GAME_004:
                    return new Sim_GAME_004();
                case CardDB.cardIDEnum.CS2_041:
                    return new Sim_CS2_041();
                case CardDB.cardIDEnum.CS2_041e:
                    return new Sim_CS2_041e();
                case CardDB.cardIDEnum.HERO_09:
                    return new Sim_HERO_09();
                case CardDB.cardIDEnum.NEW1_031:
                    return new Sim_NEW1_031();
                case CardDB.cardIDEnum.CS2_025:
                    return new Sim_CS2_025();
                case CardDB.cardIDEnum.CS2_023:
                    return new Sim_CS2_023();
                case CardDB.cardIDEnum.EX1_277:
                    return new Sim_EX1_277();
                case CardDB.cardIDEnum.DS1_185:
                    return new Sim_DS1_185();
                case CardDB.cardIDEnum.CS2_112:
                    return new Sim_CS2_112();
                case CardDB.cardIDEnum.CS2_155:
                    return new Sim_CS2_155();
                case CardDB.cardIDEnum.CS2_102:
                    return new Sim_CS2_102();
                case CardDB.cardIDEnum.CS2_076:
                    return new Sim_CS2_076();
                case CardDB.cardIDEnum.CS2_080:
                    return new Sim_CS2_080();
                case CardDB.cardIDEnum.GAME_002:
                    return new Sim_GAME_002();
                case CardDB.cardIDEnum.CS2_072:
                    return new Sim_CS2_072();
                case CardDB.cardIDEnum.EX1_399e:
                    return new Sim_EX1_399e();
                case CardDB.cardIDEnum.BCON_026:
                    return new Sim_BCON_026();
                case CardDB.cardIDEnum.CS2_092:
                    return new Sim_CS2_092();
                case CardDB.cardIDEnum.CS2_092e:
                    return new Sim_CS2_092e();
                case CardDB.cardIDEnum.CS2_087:
                    return new Sim_CS2_087();
                case CardDB.cardIDEnum.CS2_087e:
                    return new Sim_CS2_087e();
                case CardDB.cardIDEnum.CS2_172:
                    return new Sim_CS2_172();
                case CardDB.cardIDEnum.CS2_046:
                    return new Sim_CS2_046();
                case CardDB.cardIDEnum.CS2_046e:
                    return new Sim_CS2_046e();
                case CardDB.cardIDEnum.CS2_173:
                    return new Sim_CS2_173();
                case CardDB.cardIDEnum.CS2_boar:
                    return new Sim_CS2_boar();
                case CardDB.cardIDEnum.CS2_187:
                    return new Sim_CS2_187();
                case CardDB.cardIDEnum.BCON_024:
                    return new Sim_BCON_024();
                case CardDB.cardIDEnum.CS2_200:
                    return new Sim_CS2_200();
                case CardDB.cardIDEnum.CS2_103:
                    return new Sim_CS2_103();
                case CardDB.cardIDEnum.CS2_103e2:
                    return new Sim_CS2_103e2();
                case CardDB.cardIDEnum.DS1_178e:
                    return new Sim_DS1_178e();
                case CardDB.cardIDEnum.EX1_084e:
                    return new Sim_EX1_084e();
                case CardDB.cardIDEnum.CS2_182:
                    return new Sim_CS2_182();
                case CardDB.cardIDEnum.CS2_005:
                    return new Sim_CS2_005();
                case CardDB.cardIDEnum.CS2_005o:
                    return new Sim_CS2_005o();
                case CardDB.cardIDEnum.CS2_017o:
                    return new Sim_CS2_017o();
                case CardDB.cardIDEnum.CS2_114:
                    return new Sim_CS2_114();
                case CardDB.cardIDEnum.EX1_019e:
                    return new Sim_EX1_019e();
                case CardDB.cardIDEnum.GAME_003:
                    return new Sim_GAME_003();
                case CardDB.cardIDEnum.GAME_003e:
                    return new Sim_GAME_003e();
                case CardDB.cardIDEnum.CS2_093:
                    return new Sim_CS2_093();
                case CardDB.cardIDEnum.CS2_201:
                    return new Sim_CS2_201();
                case CardDB.cardIDEnum.CS2_063:
                    return new Sim_CS2_063();
                case CardDB.cardIDEnum.CS2_063e:
                    return new Sim_CS2_063e();
                case CardDB.cardIDEnum.GBL_009e:
                    return new Sim_GBL_009e();
                case CardDB.cardIDEnum.GBL_001e:
                    return new Sim_GBL_001e();
                case CardDB.cardIDEnum.GBL_003e:
                    return new Sim_GBL_003e();
                case CardDB.cardIDEnum.GBL_007e:
                    return new Sim_GBL_007e();
                case CardDB.cardIDEnum.GBL_002e:
                    return new Sim_GBL_002e();
                case CardDB.cardIDEnum.GBL_005e:
                    return new Sim_GBL_005e();
                case CardDB.cardIDEnum.GBL_006e:
                    return new Sim_GBL_006e();
                case CardDB.cardIDEnum.GBL_004e:
                    return new Sim_GBL_004e();
                case CardDB.cardIDEnum.GBL_008e:
                    return new Sim_GBL_008e();
                case CardDB.cardIDEnum.BCON_021:
                    return new Sim_BCON_021();
                case CardDB.cardIDEnum.CS2_083b:
                    return new Sim_CS2_083b();
                case CardDB.cardIDEnum.EX1_582:
                    return new Sim_EX1_582();
                case CardDB.cardIDEnum.DS1_055:
                    return new Sim_DS1_055();
                case CardDB.cardIDEnum.BCON_001:
                    return new Sim_BCON_001();
                case CardDB.cardIDEnum.BCON_001e:
                    return new Sim_BCON_001e();
                case CardDB.cardIDEnum.CS2_074:
                    return new Sim_CS2_074();
                case CardDB.cardIDEnum.CS2_074e:
                    return new Sim_CS2_074e();
                case CardDB.cardIDEnum.CS2_236:
                    return new Sim_CS2_236();
                case CardDB.cardIDEnum.CS2_236e:
                    return new Sim_CS2_236e();
                case CardDB.cardIDEnum.EX1_025:
                    return new Sim_EX1_025();
                case CardDB.cardIDEnum.CS2_061:
                    return new Sim_CS2_061();
                case CardDB.cardIDEnum.CS2_064:
                    return new Sim_CS2_064();
                case CardDB.cardIDEnum.CS2_189:
                    return new Sim_CS2_189();
                case CardDB.cardIDEnum.CS2_122e:
                    return new Sim_CS2_122e();
                case CardDB.cardIDEnum.CS2_013t:
                    return new Sim_CS2_013t();
                case CardDB.cardIDEnum.CS2_108:
                    return new Sim_CS2_108();
                case CardDB.cardIDEnum.NEW1_033o:
                    return new Sim_NEW1_033o();
                case CardDB.cardIDEnum.EX1_129:
                    return new Sim_EX1_129();
                case CardDB.cardIDEnum.DFX_001:
                    return new Sim_DFX_001();
                case CardDB.cardIDEnum.EX1_306:
                    return new Sim_EX1_306();
                case CardDB.cardIDEnum.CS2_106:
                    return new Sim_CS2_106();
                case CardDB.cardIDEnum.CS2_042:
                    return new Sim_CS2_042();
                case CardDB.cardIDEnum.CS2_029:
                    return new Sim_CS2_029();
                case CardDB.cardIDEnum.CS2_034:
                    return new Sim_CS2_034();
                case CardDB.cardIDEnum.CS2_032:
                    return new Sim_CS2_032();
                case CardDB.cardIDEnum.DFX_005:
                    return new Sim_DFX_005();
                case CardDB.cardIDEnum.EX1_565o:
                    return new Sim_EX1_565o();
                case CardDB.cardIDEnum.EX1_565:
                    return new Sim_EX1_565();
                case CardDB.cardIDEnum.hexfrog:
                    return new Sim_hexfrog();
                case CardDB.cardIDEnum.CS2_026:
                    return new Sim_CS2_026();
                case CardDB.cardIDEnum.DFX_003:
                    return new Sim_DFX_003();
                case CardDB.cardIDEnum.CS2_037:
                    return new Sim_CS2_037();
                case CardDB.cardIDEnum.CS2_024:
                    return new Sim_CS2_024();
                case CardDB.cardIDEnum.CS2_226e:
                    return new Sim_CS2_226e();
                case CardDB.cardIDEnum.CS2_121:
                    return new Sim_CS2_121();
                case CardDB.cardIDEnum.CS2_226:
                    return new Sim_CS2_226();
                case CardDB.cardIDEnum.DS1_175o:
                    return new Sim_DS1_175o();
                case CardDB.cardIDEnum.HERO_01:
                    return new Sim_HERO_01();
                case CardDB.cardIDEnum.BCON_015:
                    return new Sim_BCON_015();
                case CardDB.cardIDEnum.CS2_147:
                    return new Sim_CS2_147();
                case CardDB.cardIDEnum.CS1_042:
                    return new Sim_CS1_042();
                case CardDB.cardIDEnum.EX1_508:
                    return new Sim_EX1_508();
                case CardDB.cardIDEnum.CS2_088:
                    return new Sim_CS2_088();
                case CardDB.cardIDEnum.HERO_07:
                    return new Sim_HERO_07();
                case CardDB.cardIDEnum.EX1_399:
                    return new Sim_EX1_399();
                case CardDB.cardIDEnum.CS2_094:
                    return new Sim_CS2_094();
                case CardDB.cardIDEnum.EX1_371:
                    return new Sim_EX1_371();
                case CardDB.cardIDEnum.BCON_012:
                    return new Sim_BCON_012();
                case CardDB.cardIDEnum.NEW1_009:
                    return new Sim_NEW1_009();
                case CardDB.cardIDEnum.CS2_007:
                    return new Sim_CS2_007();
                case CardDB.cardIDEnum.CS2_062:
                    return new Sim_CS2_062();
                case CardDB.cardIDEnum.CS2_105:
                    return new Sim_CS2_105();
                case CardDB.cardIDEnum.CS2_105e:
                    return new Sim_CS2_105e();
                case CardDB.cardIDEnum.EX1_246:
                    return new Sim_EX1_246();
                case CardDB.cardIDEnum.EX1_246e:
                    return new Sim_EX1_246e();
                case CardDB.cardIDEnum.DFX_004:
                    return new Sim_DFX_004();
                case CardDB.cardIDEnum.CS2_089:
                    return new Sim_CS2_089();
                case CardDB.cardIDEnum.CS1_112:
                    return new Sim_CS1_112();
                case CardDB.cardIDEnum.CS1_130:
                    return new Sim_CS1_130();
                case CardDB.cardIDEnum.DS1_070:
                    return new Sim_DS1_070();
                case CardDB.cardIDEnum.NEW1_034:
                    return new Sim_NEW1_034();
                case CardDB.cardIDEnum.EX1_360:
                    return new Sim_EX1_360();
                case CardDB.cardIDEnum.EX1_360e:
                    return new Sim_EX1_360e();
                case CardDB.cardIDEnum.CS2_084:
                    return new Sim_CS2_084();
                case CardDB.cardIDEnum.CS2_084e:
                    return new Sim_CS2_084e();
                case CardDB.cardIDEnum.EX1_169:
                    return new Sim_EX1_169();
                case CardDB.cardIDEnum.CS2_232:
                    return new Sim_CS2_232();
                case CardDB.cardIDEnum.CS2_141:
                    return new Sim_CS2_141();
                case CardDB.cardIDEnum.CS2_125:
                    return new Sim_CS2_125();
                case CardDB.cardIDEnum.HERO_08:
                    return new Sim_HERO_08();
                case CardDB.cardIDEnum.EX1_539:
                    return new Sim_EX1_539();
                case CardDB.cardIDEnum.CS2_142:
                    return new Sim_CS2_142();
                case CardDB.cardIDEnum.NEW1_011:
                    return new Sim_NEW1_011();
                case CardDB.cardIDEnum.NEW1_033:
                    return new Sim_NEW1_033();
                case CardDB.cardIDEnum.CS1h_001:
                    return new Sim_CS1h_001();
                case CardDB.cardIDEnum.CS2_056:
                    return new Sim_CS2_056();
                case CardDB.cardIDEnum.CS2_091:
                    return new Sim_CS2_091();
                case CardDB.cardIDEnum.CS2_162:
                    return new Sim_CS2_162();
                case CardDB.cardIDEnum.GAME_001:
                    return new Sim_GAME_001();
                case CardDB.cardIDEnum.CS2_118:
                    return new Sim_CS2_118();
                case CardDB.cardIDEnum.HERO_06:
                    return new Sim_HERO_06();
                case CardDB.cardIDEnum.CS2_009:
                    return new Sim_CS2_009();
                case CardDB.cardIDEnum.CS2_009e:
                    return new Sim_CS2_009e();
                case CardDB.cardIDEnum.DS1_070o:
                    return new Sim_DS1_070o();
                case CardDB.cardIDEnum.EX1_025t:
                    return new Sim_EX1_025t();
                case CardDB.cardIDEnum.CS2_222o:
                    return new Sim_CS2_222o();
                case CardDB.cardIDEnum.CS1_113:
                    return new Sim_CS1_113();
                case CardDB.cardIDEnum.CS2_003:
                    return new Sim_CS2_003();
                case CardDB.cardIDEnum.CS2_027:
                    return new Sim_CS2_027();
                case CardDB.cardIDEnum.CS2_mirror:
                    return new Sim_CS2_mirror();
                case CardDB.cardIDEnum.NEW1_032:
                    return new Sim_NEW1_032();
                case CardDB.cardIDEnum.EX1_508o:
                    return new Sim_EX1_508o();
                case CardDB.cardIDEnum.CS2_008:
                    return new Sim_CS2_008();
                case CardDB.cardIDEnum.EX1_302:
                    return new Sim_EX1_302();
                case CardDB.cardIDEnum.DS1_183:
                    return new Sim_DS1_183();
                case CardDB.cardIDEnum.CS2_168:
                    return new Sim_CS2_168();
                case CardDB.cardIDEnum.EX1_506a:
                    return new Sim_EX1_506a();
                case CardDB.cardIDEnum.EX1_506:
                    return new Sim_EX1_506();
                case CardDB.cardIDEnum.BCON_008:
                    return new Sim_BCON_008();
                case CardDB.cardIDEnum.BCON_008e:
                    return new Sim_BCON_008e();
                case CardDB.cardIDEnum.EX1_593:
                    return new Sim_EX1_593();
                case CardDB.cardIDEnum.GAME_006:
                    return new Sim_GAME_006();
                case CardDB.cardIDEnum.CS2_235:
                    return new Sim_CS2_235();
                case CardDB.cardIDEnum.EX1_015:
                    return new Sim_EX1_015();
                case CardDB.cardIDEnum.CS2_119:
                    return new Sim_CS2_119();
                case CardDB.cardIDEnum.CS2_197:
                    return new Sim_CS2_197();
                case CardDB.cardIDEnum.EX1_191:
                    return new Sim_EX1_191();
                case CardDB.cardIDEnum.EX1_191e:
                    return new Sim_EX1_191e();
                case CardDB.cardIDEnum.CS2_022:
                    return new Sim_CS2_022();
                case CardDB.cardIDEnum.CS2_022e:
                    return new Sim_CS2_022e();
                case CardDB.cardIDEnum.BCON_004:
                    return new Sim_BCON_004();
                case CardDB.cardIDEnum.CS2_004:
                    return new Sim_CS2_004();
                case CardDB.cardIDEnum.CS2_004e:
                    return new Sim_CS2_004e();
                case CardDB.cardIDEnum.EX1_192:
                    return new Sim_EX1_192();
                case CardDB.cardIDEnum.CS2_122:
                    return new Sim_CS2_122();
                case CardDB.cardIDEnum.CS2_196:
                    return new Sim_CS2_196();
                case CardDB.cardIDEnum.CS2_213:
                    return new Sim_CS2_213();
                case CardDB.cardIDEnum.CS2_101:
                    return new Sim_CS2_101();
                case CardDB.cardIDEnum.HERO_05:
                    return new Sim_HERO_05();
                case CardDB.cardIDEnum.CS2_120:
                    return new Sim_CS2_120();
                case CardDB.cardIDEnum.CS2_045:
                    return new Sim_CS2_045();
                case CardDB.cardIDEnum.CS2_045e:
                    return new Sim_CS2_045e();
                case CardDB.cardIDEnum.NEW1_003:
                    return new Sim_NEW1_003();
                case CardDB.cardIDEnum.EX1_581:
                    return new Sim_EX1_581();
                case CardDB.cardIDEnum.CS2_011:
                    return new Sim_CS2_011();
                case CardDB.cardIDEnum.CS2_011o:
                    return new Sim_CS2_011o();
                case CardDB.cardIDEnum.CS2_050:
                    return new Sim_CS2_050();
                case CardDB.cardIDEnum.CS2_179:
                    return new Sim_CS2_179();
                case CardDB.cardIDEnum.CS2_057:
                    return new Sim_CS2_057();
                case CardDB.cardIDEnum.EX1_622:
                    return new Sim_EX1_622();
                case CardDB.cardIDEnum.CS2_234:
                    return new Sim_CS2_234();
                case CardDB.cardIDEnum.CS2_017:
                    return new Sim_CS2_017();
                case CardDB.cardIDEnum.CS2_083e:
                    return new Sim_CS2_083e();
                case CardDB.cardIDEnum.EX1_019:
                    return new Sim_EX1_019();
                case CardDB.cardIDEnum.CS2_tk1:
                    return new Sim_CS2_tk1();
                case CardDB.cardIDEnum.EX1_606:
                    return new Sim_EX1_606();
                case CardDB.cardIDEnum.EX1_278:
                    return new Sim_EX1_278();
                case CardDB.cardIDEnum.CS2_101t:
                    return new Sim_CS2_101t();
                case CardDB.cardIDEnum.CS2_127:
                    return new Sim_CS2_127();
                case CardDB.cardIDEnum.CS2_075:
                    return new Sim_CS2_075();
                case CardDB.cardIDEnum.skele11:
                    return new Sim_skele11();
                case CardDB.cardIDEnum.BCON_016:
                    return new Sim_BCON_016();
                case CardDB.cardIDEnum.BCON_016e:
                    return new Sim_BCON_016e();
                case CardDB.cardIDEnum.EX1_308:
                    return new Sim_EX1_308();
                case CardDB.cardIDEnum.CS2_077:
                    return new Sim_CS2_077();
                case CardDB.cardIDEnum.EX1_173:
                    return new Sim_EX1_173();
                case CardDB.cardIDEnum.CS2_237:
                    return new Sim_CS2_237();
                case CardDB.cardIDEnum.DS1h_292:
                    return new Sim_DS1h_292();
                case CardDB.cardIDEnum.CS2_051:
                    return new Sim_CS2_051();
                case CardDB.cardIDEnum.CS2_171:
                    return new Sim_CS2_171();
                case CardDB.cardIDEnum.CS2_150:
                    return new Sim_CS2_150();
                case CardDB.cardIDEnum.CS2_222:
                    return new Sim_CS2_222();
                case CardDB.cardIDEnum.CS2_131:
                    return new Sim_CS2_131();
                case CardDB.cardIDEnum.CS2_012:
                    return new Sim_CS2_012();
                case CardDB.cardIDEnum.GAME_005:
                    return new Sim_GAME_005();
                case CardDB.cardIDEnum.GAME_005e:
                    return new Sim_GAME_005e();
                case CardDB.cardIDEnum.HERO_02:
                    return new Sim_HERO_02();
                case CardDB.cardIDEnum.DS1_175:
                    return new Sim_DS1_175();
                case CardDB.cardIDEnum.DFX_002:
                    return new Sim_DFX_002();
                case CardDB.cardIDEnum.CS2_049:
                    return new Sim_CS2_049();
                case CardDB.cardIDEnum.EX1_244:
                    return new Sim_EX1_244();
                case CardDB.cardIDEnum.EX1_244e:
                    return new Sim_EX1_244e();
                case CardDB.cardIDEnum.GAME_011:
                    return new Sim_GAME_011();
                case CardDB.cardIDEnum.DS1_184:
                    return new Sim_DS1_184();
                case CardDB.cardIDEnum.CS2_097:
                    return new Sim_CS2_097();
                case CardDB.cardIDEnum.DS1_178:
                    return new Sim_DS1_178();
                case CardDB.cardIDEnum.HERO_04:
                    return new Sim_HERO_04();
                case CardDB.cardIDEnum.HERO_03:
                    return new Sim_HERO_03();
                case CardDB.cardIDEnum.CS2_065:
                    return new Sim_CS2_065();
                case CardDB.cardIDEnum.EX1_011:
                    return new Sim_EX1_011();
                case CardDB.cardIDEnum.CS2_186:
                    return new Sim_CS2_186();
                case CardDB.cardIDEnum.EX1_084:
                    return new Sim_EX1_084();
                case CardDB.cardIDEnum.CS2_033:
                    return new Sim_CS2_033();
                case CardDB.cardIDEnum.EX1_400:
                    return new Sim_EX1_400();
                case CardDB.cardIDEnum.CS2_082:
                    return new Sim_CS2_082();
                case CardDB.cardIDEnum.CS2_013:
                    return new Sim_CS2_013();
                case CardDB.cardIDEnum.CS2_039:
                    return new Sim_CS2_039();
                case CardDB.cardIDEnum.EX1_587:
                    return new Sim_EX1_587();
                case CardDB.cardIDEnum.CS2_124:
                    return new Sim_CS2_124();
                case CardDB.cardIDEnum.CS2_052:
                    return new Sim_CS2_052();
 ///case CardDB.cardIDEnum.///BOOMSDAY:
                    ///return new Sim_///BOOMSDAY();
                case CardDB.cardIDEnum.BOTA_320:
                    return new Sim_BOTA_320();
                case CardDB.cardIDEnum.BOTA_448:
                    return new Sim_BOTA_448();
                case CardDB.cardIDEnum.BOTA_312:
                    return new Sim_BOTA_312();
                case CardDB.cardIDEnum.BOTA_614:
                    return new Sim_BOTA_614();
                case CardDB.cardIDEnum.BOTA_612:
                    return new Sim_BOTA_612();
                case CardDB.cardIDEnum.BOTA_616:
                    return new Sim_BOTA_616();
                case CardDB.cardIDEnum.BOTA_524:
                    return new Sim_BOTA_524();
                case CardDB.cardIDEnum.BOTA_330:
                    return new Sim_BOTA_330();
                case CardDB.cardIDEnum.BOTA_432:
                    return new Sim_BOTA_432();
                case CardDB.cardIDEnum.BOTA_450:
                    return new Sim_BOTA_450();
                case CardDB.cardIDEnum.BOTA_439:
                    return new Sim_BOTA_439();
                case CardDB.cardIDEnum.BOT_087:
                    return new Sim_BOT_087();
                case CardDB.cardIDEnum.BOT_087e:
                    return new Sim_BOT_087e();
                case CardDB.cardIDEnum.BOTA_503:
                    return new Sim_BOTA_503();
                case CardDB.cardIDEnum.BOTA_515:
                    return new Sim_BOTA_515();
                case CardDB.cardIDEnum.BOTA_444:
                    return new Sim_BOTA_444();
                case CardDB.cardIDEnum.BOT_911:
                    return new Sim_BOT_911();
                case CardDB.cardIDEnum.BOT_911e:
                    return new Sim_BOT_911e();
                case CardDB.cardIDEnum.BOT_270t:
                    return new Sim_BOT_270t();
                case CardDB.cardIDEnum.BOT_539:
                    return new Sim_BOT_539();
                case CardDB.cardIDEnum.BOT_219e:
                    return new Sim_BOT_219e();
                case CardDB.cardIDEnum.BOT_101:
                    return new Sim_BOT_101();
                case CardDB.cardIDEnum.BOT_256:
                    return new Sim_BOT_256();
                case CardDB.cardIDEnum.BOTA_BOSS_03h:
                    return new Sim_BOTA_BOSS_03h();
                case CardDB.cardIDEnum.BOT_559:
                    return new Sim_BOT_559();
                case CardDB.cardIDEnum.BOT_908:
                    return new Sim_BOT_908();
                case CardDB.cardIDEnum.BOTA_240:
                    return new Sim_BOTA_240();
                case CardDB.cardIDEnum.BOTA_102:
                    return new Sim_BOTA_102();
                case CardDB.cardIDEnum.BOTA_303:
                    return new Sim_BOTA_303();
                case CardDB.cardIDEnum.BOT_246:
                    return new Sim_BOT_246();
                case CardDB.cardIDEnum.BOT_237:
                    return new Sim_BOT_237();
                case CardDB.cardIDEnum.BOT_237e:
                    return new Sim_BOT_237e();
                case CardDB.cardIDEnum.BOT_238p:
                    return new Sim_BOT_238p();
                case CardDB.cardIDEnum.BOT_054:
                    return new Sim_BOT_054();
                case CardDB.cardIDEnum.BOT_238p2:
                    return new Sim_BOT_238p2();
                case CardDB.cardIDEnum.BOT_565:
                    return new Sim_BOT_565();
                case CardDB.cardIDEnum.BOTA_706:
                    return new Sim_BOTA_706();
                case CardDB.cardIDEnum.BOT_511t:
                    return new Sim_BOT_511t();
                case CardDB.cardIDEnum.BOT_033:
                    return new Sim_BOT_033();
                case CardDB.cardIDEnum.BOTA_229:
                    return new Sim_BOTA_229();
                case CardDB.cardIDEnum.BOT_034:
                    return new Sim_BOT_034();
                case CardDB.cardIDEnum.BOTA_BOSS_16h:
                    return new Sim_BOTA_BOSS_16h();
                case CardDB.cardIDEnum.BOTA_BOSS_15h:
                    return new Sim_BOTA_BOSS_15h();
                case CardDB.cardIDEnum.BOT_238e:
                    return new Sim_BOT_238e();
                case CardDB.cardIDEnum.BOT_238e2:
                    return new Sim_BOT_238e2();
                case CardDB.cardIDEnum.BOTA_441:
                    return new Sim_BOTA_441();
                case CardDB.cardIDEnum.BOT_413e:
                    return new Sim_BOT_413e();
                case CardDB.cardIDEnum.BOT_413:
                    return new Sim_BOT_413();
                case CardDB.cardIDEnum.BOTA_505:
                    return new Sim_BOTA_505();
                case CardDB.cardIDEnum.BOTA_203:
                    return new Sim_BOTA_203();
                case CardDB.cardIDEnum.BOT_021:
                    return new Sim_BOT_021();
                case CardDB.cardIDEnum.BOT_021e:
                    return new Sim_BOT_021e();
                case CardDB.cardIDEnum.BOT_534:
                    return new Sim_BOT_534();
                case CardDB.cardIDEnum.BOTA_513:
                    return new Sim_BOTA_513();
                case CardDB.cardIDEnum.BOT_531:
                    return new Sim_BOT_531();
                case CardDB.cardIDEnum.BOT_531e:
                    return new Sim_BOT_531e();
                case CardDB.cardIDEnum.BOT_531e2:
                    return new Sim_BOT_531e2();
                case CardDB.cardIDEnum.BOTA_525:
                    return new Sim_BOTA_525();
                case CardDB.cardIDEnum.BOT_438e:
                    return new Sim_BOT_438e();
                case CardDB.cardIDEnum.BOTA_613:
                    return new Sim_BOTA_613();
                case CardDB.cardIDEnum.BOT_414:
                    return new Sim_BOT_414();
                case CardDB.cardIDEnum.BOT_567e:
                    return new Sim_BOT_567e();
                case CardDB.cardIDEnum.BOT_435:
                    return new Sim_BOT_435();
                case CardDB.cardIDEnum.BOT_258e:
                    return new Sim_BOT_258e();
                case CardDB.cardIDEnum.BOTA_301:
                    return new Sim_BOTA_301();
                case CardDB.cardIDEnum.BOTA_241e:
                    return new Sim_BOTA_241e();
                case CardDB.cardIDEnum.BOTA_241:
                    return new Sim_BOTA_241();
                case CardDB.cardIDEnum.BOTA_431:
                    return new Sim_BOTA_431();
                case CardDB.cardIDEnum.BOT_562:
                    return new Sim_BOT_562();
                case CardDB.cardIDEnum.BOTA_653:
                    return new Sim_BOTA_653();
                case CardDB.cardIDEnum.BOT_604:
                    return new Sim_BOT_604();
                case CardDB.cardIDEnum.BOTA_307:
                    return new Sim_BOTA_307();
                case CardDB.cardIDEnum.BOTA_232:
                    return new Sim_BOTA_232();
                case CardDB.cardIDEnum.BOT_576:
                    return new Sim_BOT_576();
                case CardDB.cardIDEnum.BOTA_516:
                    return new Sim_BOTA_516();
                case CardDB.cardIDEnum.BOT_447:
                    return new Sim_BOT_447();
                case CardDB.cardIDEnum.BOT_236:
                    return new Sim_BOT_236();
                case CardDB.cardIDEnum.BOTA_BOSS_18h:
                    return new Sim_BOTA_BOSS_18h();
                case CardDB.cardIDEnum.BOT_909:
                    return new Sim_BOT_909();
                case CardDB.cardIDEnum.BOTA_324:
                    return new Sim_BOTA_324();
                case CardDB.cardIDEnum.BOTA_212:
                    return new Sim_BOTA_212();
                case CardDB.cardIDEnum.BOTA_434:
                    return new Sim_BOTA_434();
                case CardDB.cardIDEnum.BOT_438:
                    return new Sim_BOT_438();
                case CardDB.cardIDEnum.BOT_448:
                    return new Sim_BOT_448();
                case CardDB.cardIDEnum.BOT_509:
                    return new Sim_BOT_509();
                case CardDB.cardIDEnum.BOT_559e:
                    return new Sim_BOT_559e();
                case CardDB.cardIDEnum.BOTA_BOSS_20p4:
                    return new Sim_BOTA_BOSS_20p4();
                case CardDB.cardIDEnum.BOTA_532:
                    return new Sim_BOTA_532();
                case CardDB.cardIDEnum.BOTA_438:
                    return new Sim_BOTA_438();
                case CardDB.cardIDEnum.BOT_238p4:
                    return new Sim_BOT_238p4();
                case CardDB.cardIDEnum.BOT_913:
                    return new Sim_BOT_913();
                case CardDB.cardIDEnum.BOTA_208:
                    return new Sim_BOTA_208();
                case CardDB.cardIDEnum.BOTA_208e:
                    return new Sim_BOTA_208e();
                case CardDB.cardIDEnum.BOTA_BOSS_08h:
                    return new Sim_BOTA_BOSS_08h();
                case CardDB.cardIDEnum.BOT_419:
                    return new Sim_BOT_419();
                case CardDB.cardIDEnum.BOTA_BOSS_06h:
                    return new Sim_BOTA_BOSS_06h();
                case CardDB.cardIDEnum.BOTA_310:
                    return new Sim_BOTA_310();
                case CardDB.cardIDEnum.BOT_562e:
                    return new Sim_BOT_562e();
                case CardDB.cardIDEnum.BOTA_514:
                    return new Sim_BOTA_514();
                case CardDB.cardIDEnum.BOTA_445:
                    return new Sim_BOTA_445();
                case CardDB.cardIDEnum.BOTA_611:
                    return new Sim_BOTA_611();
                case CardDB.cardIDEnum.BOTA_652:
                    return new Sim_BOTA_652();
                case CardDB.cardIDEnum.BOTA_615:
                    return new Sim_BOTA_615();
                case CardDB.cardIDEnum.BOTA_625:
                    return new Sim_BOTA_625();
                case CardDB.cardIDEnum.BOT_224:
                    return new Sim_BOT_224();
                case CardDB.cardIDEnum.BOT_517e:
                    return new Sim_BOT_517e();
                case CardDB.cardIDEnum.BOTA_BOSS_20h:
                    return new Sim_BOTA_BOSS_20h();
                case CardDB.cardIDEnum.BOTA_BOSS_20h2:
                    return new Sim_BOTA_BOSS_20h2();
                case CardDB.cardIDEnum.BOT_238:
                    return new Sim_BOT_238();
                case CardDB.cardIDEnum.BOT_433:
                    return new Sim_BOT_433();
                case CardDB.cardIDEnum.BOTA_BOSS_09h:
                    return new Sim_BOTA_BOSS_09h();
                case CardDB.cardIDEnum.BOTA_427:
                    return new Sim_BOTA_427();
                case CardDB.cardIDEnum.BOTA_511:
                    return new Sim_BOTA_511();
                case CardDB.cardIDEnum.BOT_423:
                    return new Sim_BOT_423();
                case CardDB.cardIDEnum.BOTA_BOSS_04p:
                    return new Sim_BOTA_BOSS_04p();
                case CardDB.cardIDEnum.BOT_104:
                    return new Sim_BOT_104();
                case CardDB.cardIDEnum.BOT_521:
                    return new Sim_BOT_521();
                case CardDB.cardIDEnum.BOT_411:
                    return new Sim_BOT_411();
                case CardDB.cardIDEnum.BOTA_BOSS_13h:
                    return new Sim_BOTA_BOSS_13h();
                case CardDB.cardIDEnum.BOT_411e:
                    return new Sim_BOT_411e();
                case CardDB.cardIDEnum.BOT_411e2:
                    return new Sim_BOT_411e2();
                case CardDB.cardIDEnum.BOT_550e:
                    return new Sim_BOT_550e();
                case CardDB.cardIDEnum.BOT_550:
                    return new Sim_BOT_550();
                case CardDB.cardIDEnum.BOT_093:
                    return new Sim_BOT_093();
                case CardDB.cardIDEnum.BOT_540:
                    return new Sim_BOT_540();
                case CardDB.cardIDEnum.BOTA_334:
                    return new Sim_BOTA_334();
                case CardDB.cardIDEnum.BOT_059:
                    return new Sim_BOT_059();
                case CardDB.cardIDEnum.BOT_099:
                    return new Sim_BOT_099();
                case CardDB.cardIDEnum.BOTA_BOSS_14p:
                    return new Sim_BOTA_BOSS_14p();
                case CardDB.cardIDEnum.BOT_532:
                    return new Sim_BOT_532();
                case CardDB.cardIDEnum.BOTA_510:
                    return new Sim_BOTA_510();
                case CardDB.cardIDEnum.BOT_219:
                    return new Sim_BOT_219();
                case CardDB.cardIDEnum.BOT_079:
                    return new Sim_BOT_079();
                case CardDB.cardIDEnum.BOTA_429:
                    return new Sim_BOTA_429();
                case CardDB.cardIDEnum.BOTA_526:
                    return new Sim_BOTA_526();
                case CardDB.cardIDEnum.BOTA_BOSS_16p:
                    return new Sim_BOTA_BOSS_16p();
                case CardDB.cardIDEnum.BOTA_BOSS_15p:
                    return new Sim_BOTA_BOSS_15p();
                case CardDB.cardIDEnum.BOT_038:
                    return new Sim_BOT_038();
                case CardDB.cardIDEnum.BOTA_500:
                    return new Sim_BOTA_500();
                case CardDB.cardIDEnum.BOT_429:
                    return new Sim_BOT_429();
                case CardDB.cardIDEnum.BOT_568e:
                    return new Sim_BOT_568e();
                case CardDB.cardIDEnum.BOT_434:
                    return new Sim_BOT_434();
                case CardDB.cardIDEnum.BOTA_BOSS_07h:
                    return new Sim_BOTA_BOSS_07h();
                case CardDB.cardIDEnum.BOT_444:
                    return new Sim_BOT_444();
                case CardDB.cardIDEnum.BOT_434e:
                    return new Sim_BOT_434e();
                case CardDB.cardIDEnum.BOT_434e2:
                    return new Sim_BOT_434e2();
                case CardDB.cardIDEnum.BOT_423e:
                    return new Sim_BOT_423e();
                case CardDB.cardIDEnum.BOTA_643:
                    return new Sim_BOTA_643();
                case CardDB.cardIDEnum.BOTA_317:
                    return new Sim_BOTA_317();
                case CardDB.cardIDEnum.BOTA_203e:
                    return new Sim_BOTA_203e();
                case CardDB.cardIDEnum.BOTA_302:
                    return new Sim_BOTA_302();
                case CardDB.cardIDEnum.BOTA_305:
                    return new Sim_BOTA_305();
                case CardDB.cardIDEnum.BOTA_314:
                    return new Sim_BOTA_314();
                case CardDB.cardIDEnum.BOTA_337:
                    return new Sim_BOTA_337();
                case CardDB.cardIDEnum.BOTA_654:
                    return new Sim_BOTA_654();
                case CardDB.cardIDEnum.BOTA_BOSS_20p2:
                    return new Sim_BOTA_BOSS_20p2();
                case CardDB.cardIDEnum.BOT_907e:
                    return new Sim_BOT_907e();
                case CardDB.cardIDEnum.BOTA_210:
                    return new Sim_BOTA_210();
                case CardDB.cardIDEnum.BOT_907:
                    return new Sim_BOT_907();
                case CardDB.cardIDEnum.BOT_042t:
                    return new Sim_BOT_042t();
                case CardDB.cardIDEnum.BOTA_223:
                    return new Sim_BOTA_223();
                case CardDB.cardIDEnum.BOT_270:
                    return new Sim_BOT_270();
                case CardDB.cardIDEnum.BOT_507:
                    return new Sim_BOT_507();
                case CardDB.cardIDEnum.BOTA_BOSS_07p:
                    return new Sim_BOTA_BOSS_07p();
                case CardDB.cardIDEnum.BOT_444e:
                    return new Sim_BOT_444e();
                case CardDB.cardIDEnum.BOTA_BOSS_17p:
                    return new Sim_BOTA_BOSS_17p();
                case CardDB.cardIDEnum.BOT_910:
                    return new Sim_BOT_910();
                case CardDB.cardIDEnum.BOT_906:
                    return new Sim_BOT_906();
                case CardDB.cardIDEnum.BOT_906e:
                    return new Sim_BOT_906e();
                case CardDB.cardIDEnum.BOTA_BOSS_17h:
                    return new Sim_BOTA_BOSS_17h();
                case CardDB.cardIDEnum.BOT_031:
                    return new Sim_BOT_031();
                case CardDB.cardIDEnum.BOT_437:
                    return new Sim_BOT_437();
                case CardDB.cardIDEnum.BOTA_446:
                    return new Sim_BOTA_446();
                case CardDB.cardIDEnum.BOT_218t:
                    return new Sim_BOT_218t();
                case CardDB.cardIDEnum.BOTA_634:
                    return new Sim_BOTA_634();
                case CardDB.cardIDEnum.BOT_555:
                    return new Sim_BOT_555();
                case CardDB.cardIDEnum.BOTA_322:
                    return new Sim_BOTA_322();
                case CardDB.cardIDEnum.BOTA_636:
                    return new Sim_BOTA_636();
                case CardDB.cardIDEnum.BOTA_518:
                    return new Sim_BOTA_518();
                case CardDB.cardIDEnum.BOT_280e:
                    return new Sim_BOT_280e();
                case CardDB.cardIDEnum.BOT_280:
                    return new Sim_BOT_280();
                case CardDB.cardIDEnum.BOTA_421:
                    return new Sim_BOTA_421();
                case CardDB.cardIDEnum.BOTA_319:
                    return new Sim_BOTA_319();
                case CardDB.cardIDEnum.BOTA_311:
                    return new Sim_BOTA_311();
                case CardDB.cardIDEnum.BOTA_433:
                    return new Sim_BOTA_433();
                case CardDB.cardIDEnum.BOT_079e:
                    return new Sim_BOT_079e();
                case CardDB.cardIDEnum.BOTA_502:
                    return new Sim_BOTA_502();
                case CardDB.cardIDEnum.BOTA_231e:
                    return new Sim_BOTA_231e();
                case CardDB.cardIDEnum.BOTA_231:
                    return new Sim_BOTA_231();
                case CardDB.cardIDEnum.BOTA_533:
                    return new Sim_BOTA_533();
                case CardDB.cardIDEnum.BOT_263e:
                    return new Sim_BOT_263e();
                case CardDB.cardIDEnum.BOTA_521:
                    return new Sim_BOTA_521();
                case CardDB.cardIDEnum.BOT_445t:
                    return new Sim_BOT_445t();
                case CardDB.cardIDEnum.BOT_404:
                    return new Sim_BOT_404();
                case CardDB.cardIDEnum.BOTA_641:
                    return new Sim_BOTA_641();
                case CardDB.cardIDEnum.BOT_238p3:
                    return new Sim_BOT_238p3();
                case CardDB.cardIDEnum.BOT_606:
                    return new Sim_BOT_606();
                case CardDB.cardIDEnum.BOTA_BOSS_20p3:
                    return new Sim_BOTA_BOSS_20p3();
                case CardDB.cardIDEnum.BOT_912:
                    return new Sim_BOT_912();
                case CardDB.cardIDEnum.BOTA_329:
                    return new Sim_BOTA_329();
                case CardDB.cardIDEnum.BOT_283e:
                    return new Sim_BOT_283e();
                case CardDB.cardIDEnum.BOT_288:
                    return new Sim_BOT_288();
                case CardDB.cardIDEnum.BOT_420:
                    return new Sim_BOT_420();
                case CardDB.cardIDEnum.BOTA_306:
                    return new Sim_BOTA_306();
                case CardDB.cardIDEnum.BOTA_702:
                    return new Sim_BOTA_702();
                case CardDB.cardIDEnum.BOTA_313:
                    return new Sim_BOTA_313();
                case CardDB.cardIDEnum.BOTA_624:
                    return new Sim_BOTA_624();
                case CardDB.cardIDEnum.BOTA_318:
                    return new Sim_BOTA_318();
                case CardDB.cardIDEnum.BOT_910e:
                    return new Sim_BOT_910e();
                case CardDB.cardIDEnum.BOTA_BOSS_12h:
                    return new Sim_BOTA_BOSS_12h();
                case CardDB.cardIDEnum.BOT_544:
                    return new Sim_BOT_544();
                case CardDB.cardIDEnum.BOTA_509:
                    return new Sim_BOTA_509();
                case CardDB.cardIDEnum.BOT_257:
                    return new Sim_BOT_257();
                case CardDB.cardIDEnum.BOTA_649:
                    return new Sim_BOTA_649();
                case CardDB.cardIDEnum.BOT_066t:
                    return new Sim_BOT_066t();
                case CardDB.cardIDEnum.BOTA_623:
                    return new Sim_BOTA_623();
                case CardDB.cardIDEnum.BOT_066:
                    return new Sim_BOT_066();
                case CardDB.cardIDEnum.BOT_537:
                    return new Sim_BOT_537();
                case CardDB.cardIDEnum.BOT_445:
                    return new Sim_BOT_445();
                case CardDB.cardIDEnum.BOT_424:
                    return new Sim_BOT_424();
                case CardDB.cardIDEnum.BOT_533:
                    return new Sim_BOT_533();
                case CardDB.cardIDEnum.BOT_601:
                    return new Sim_BOT_601();
                case CardDB.cardIDEnum.BOT_312t:
                    return new Sim_BOT_312t();
                case CardDB.cardIDEnum.BOT_238p6:
                    return new Sim_BOT_238p6();
                case CardDB.cardIDEnum.BOT_535:
                    return new Sim_BOT_535();
                case CardDB.cardIDEnum.BOT_543e:
                    return new Sim_BOT_543e();
                case CardDB.cardIDEnum.BOTA_700:
                    return new Sim_BOTA_700();
                case CardDB.cardIDEnum.BOT_107:
                    return new Sim_BOT_107();
                case CardDB.cardIDEnum.BOT_107e:
                    return new Sim_BOT_107e();
                case CardDB.cardIDEnum.BOT_219te:
                    return new Sim_BOT_219te();
                case CardDB.cardIDEnum.BOT_219t:
                    return new Sim_BOT_219t();
                case CardDB.cardIDEnum.BOT_523:
                    return new Sim_BOT_523();
                case CardDB.cardIDEnum.BOT_243:
                    return new Sim_BOT_243();
                case CardDB.cardIDEnum.BOTA_BOSS_14h:
                    return new Sim_BOTA_BOSS_14h();
                case CardDB.cardIDEnum.BOT_242:
                    return new Sim_BOT_242();
                case CardDB.cardIDEnum.BOTA_512:
                    return new Sim_BOTA_512();
                case CardDB.cardIDEnum.BOT_286:
                    return new Sim_BOT_286();
                case CardDB.cardIDEnum.BOT_508:
                    return new Sim_BOT_508();
                case CardDB.cardIDEnum.BOT_243e:
                    return new Sim_BOT_243e();
                case CardDB.cardIDEnum.BOT_039:
                    return new Sim_BOT_039();
                case CardDB.cardIDEnum.BOT_039e:
                    return new Sim_BOT_039e();
                case CardDB.cardIDEnum.BOTA_522:
                    return new Sim_BOTA_522();
                case CardDB.cardIDEnum.BOT_226e:
                    return new Sim_BOT_226e();
                case CardDB.cardIDEnum.BOT_226:
                    return new Sim_BOT_226();
                case CardDB.cardIDEnum.BOTA_336:
                    return new Sim_BOTA_336();
                case CardDB.cardIDEnum.BOT_422b:
                    return new Sim_BOT_422b();
                case CardDB.cardIDEnum.BOTA_430:
                    return new Sim_BOTA_430();
                case CardDB.cardIDEnum.BOTA_529:
                    return new Sim_BOTA_529();
                case CardDB.cardIDEnum.BOTA_333:
                    return new Sim_BOTA_333();
                case CardDB.cardIDEnum.BOT_422a:
                    return new Sim_BOT_422a();
                case CardDB.cardIDEnum.BOT_422ae:
                    return new Sim_BOT_422ae();
                case CardDB.cardIDEnum.BOT_536:
                    return new Sim_BOT_536();
                case CardDB.cardIDEnum.BOT_299:
                    return new Sim_BOT_299();
                case CardDB.cardIDEnum.BOT_296:
                    return new Sim_BOT_296();
                case CardDB.cardIDEnum.BOT_216:
                    return new Sim_BOT_216();
                case CardDB.cardIDEnum.BOT_543:
                    return new Sim_BOT_543();
                case CardDB.cardIDEnum.BOT_296e:
                    return new Sim_BOT_296e();
                case CardDB.cardIDEnum.BOT_576e:
                    return new Sim_BOT_576e();
                case CardDB.cardIDEnum.BOTA_531:
                    return new Sim_BOTA_531();
                case CardDB.cardIDEnum.BOTA_BOSS_05p:
                    return new Sim_BOTA_BOSS_05p();
                case CardDB.cardIDEnum.BOTA_633:
                    return new Sim_BOTA_633();
                case CardDB.cardIDEnum.BOTA_601:
                    return new Sim_BOTA_601();
                case CardDB.cardIDEnum.BOT_267:
                    return new Sim_BOT_267();
                case CardDB.cardIDEnum.BOTA_315:
                    return new Sim_BOTA_315();
                case CardDB.cardIDEnum.BOTA_451:
                    return new Sim_BOTA_451();
                case CardDB.cardIDEnum.BOT_283:
                    return new Sim_BOT_283();
                case CardDB.cardIDEnum.BOTA_BOSS_10h:
                    return new Sim_BOTA_BOSS_10h();
                case CardDB.cardIDEnum.BOTA_425:
                    return new Sim_BOTA_425();
                case CardDB.cardIDEnum.BOTA_440:
                    return new Sim_BOTA_440();
                case CardDB.cardIDEnum.BOT_529:
                    return new Sim_BOT_529();
                case CardDB.cardIDEnum.BOTA_328:
                    return new Sim_BOTA_328();
                case CardDB.cardIDEnum.BOTA_635:
                    return new Sim_BOTA_635();
                case CardDB.cardIDEnum.BOT_038e:
                    return new Sim_BOT_038e();
                case CardDB.cardIDEnum.BOT_436:
                    return new Sim_BOT_436();
                case CardDB.cardIDEnum.BOTA_504:
                    return new Sim_BOTA_504();
                case CardDB.cardIDEnum.BOTA_309:
                    return new Sim_BOTA_309();
                case CardDB.cardIDEnum.BOTA_420:
                    return new Sim_BOTA_420();
                case CardDB.cardIDEnum.BOTA_BOSS_18p:
                    return new Sim_BOTA_BOSS_18p();
                case CardDB.cardIDEnum.BOT_565t:
                    return new Sim_BOT_565t();
                case CardDB.cardIDEnum.BOTA_244:
                    return new Sim_BOTA_244();
                case CardDB.cardIDEnum.BOT_566e:
                    return new Sim_BOT_566e();
                case CardDB.cardIDEnum.BOT_566e2:
                    return new Sim_BOT_566e2();
                case CardDB.cardIDEnum.BOT_566:
                    return new Sim_BOT_566();
                case CardDB.cardIDEnum.BOT_529e:
                    return new Sim_BOT_529e();
                case CardDB.cardIDEnum.BOT_312:
                    return new Sim_BOT_312();
                case CardDB.cardIDEnum.BOT_312e:
                    return new Sim_BOT_312e();
                case CardDB.cardIDEnum.BOT_600:
                    return new Sim_BOT_600();
                case CardDB.cardIDEnum.BOTA_626:
                    return new Sim_BOTA_626();
                case CardDB.cardIDEnum.BOTA_517:
                    return new Sim_BOTA_517();
                case CardDB.cardIDEnum.BOTA_644:
                    return new Sim_BOTA_644();
                case CardDB.cardIDEnum.BOT_537t:
                    return new Sim_BOT_537t();
                case CardDB.cardIDEnum.BOT_067:
                    return new Sim_BOT_067();
                case CardDB.cardIDEnum.BOT_067e:
                    return new Sim_BOT_067e();
                case CardDB.cardIDEnum.BOT_069e:
                    return new Sim_BOT_069e();
                case CardDB.cardIDEnum.BOT_050:
                    return new Sim_BOT_050();
                case CardDB.cardIDEnum.BOTA_426:
                    return new Sim_BOTA_426();
                case CardDB.cardIDEnum.BOT_511:
                    return new Sim_BOT_511();
                case CardDB.cardIDEnum.BOT_402:
                    return new Sim_BOT_402();
                case CardDB.cardIDEnum.BOT_218:
                    return new Sim_BOT_218();
                case CardDB.cardIDEnum.BOTA_331:
                    return new Sim_BOTA_331();
                case CardDB.cardIDEnum.BOTA_650:
                    return new Sim_BOTA_650();
                case CardDB.cardIDEnum.BOTA_506:
                    return new Sim_BOTA_506();
                case CardDB.cardIDEnum.BOTA_435:
                    return new Sim_BOTA_435();
                case CardDB.cardIDEnum.BOT_453:
                    return new Sim_BOT_453();
                case CardDB.cardIDEnum.BOT_234:
                    return new Sim_BOT_234();
                case CardDB.cardIDEnum.BOT_234e:
                    return new Sim_BOT_234e();
                case CardDB.cardIDEnum.BOTA_530:
                    return new Sim_BOTA_530();
                case CardDB.cardIDEnum.BOT_020:
                    return new Sim_BOT_020();
                case CardDB.cardIDEnum.BOT_020e:
                    return new Sim_BOT_020e();
                case CardDB.cardIDEnum.BOT_437e:
                    return new Sim_BOT_437e();
                case CardDB.cardIDEnum.BOTA_501:
                    return new Sim_BOTA_501();
                case CardDB.cardIDEnum.BOT_700:
                    return new Sim_BOT_700();
                case CardDB.cardIDEnum.BOT_700e:
                    return new Sim_BOT_700e();
                case CardDB.cardIDEnum.BOTA_BOSS_09p:
                    return new Sim_BOTA_BOSS_09p();
                case CardDB.cardIDEnum.BOT_263:
                    return new Sim_BOT_263();
                case CardDB.cardIDEnum.BOTA_603:
                    return new Sim_BOTA_603();
                case CardDB.cardIDEnum.BOTA_622:
                    return new Sim_BOTA_622();
                case CardDB.cardIDEnum.BOT_102t:
                    return new Sim_BOT_102t();
                case CardDB.cardIDEnum.BOT_102:
                    return new Sim_BOT_102();
                case CardDB.cardIDEnum.BOT_538:
                    return new Sim_BOT_538();
                case CardDB.cardIDEnum.BOTA_332:
                    return new Sim_BOTA_332();
                case CardDB.cardIDEnum.BOT_251:
                    return new Sim_BOT_251();
                case CardDB.cardIDEnum.BOT_251e:
                    return new Sim_BOT_251e();
                case CardDB.cardIDEnum.BOT_222:
                    return new Sim_BOT_222();
                case CardDB.cardIDEnum.BOTA_617:
                    return new Sim_BOTA_617();
                case CardDB.cardIDEnum.BOT_308:
                    return new Sim_BOT_308();
                case CardDB.cardIDEnum.BOTA_101:
                    return new Sim_BOTA_101();
                case CardDB.cardIDEnum.BOTA_304:
                    return new Sim_BOTA_304();
                case CardDB.cardIDEnum.BOT_552:
                    return new Sim_BOT_552();
                case CardDB.cardIDEnum.BOT_103:
                    return new Sim_BOT_103();
                case CardDB.cardIDEnum.BOTA_BOSS_04h:
                    return new Sim_BOTA_BOSS_04h();
                case CardDB.cardIDEnum.BOT_257e:
                    return new Sim_BOT_257e();
                case CardDB.cardIDEnum.BOT_603:
                    return new Sim_BOT_603();
                case CardDB.cardIDEnum.BOTA_242:
                    return new Sim_BOTA_242();
                case CardDB.cardIDEnum.BOTA_242e:
                    return new Sim_BOTA_242e();
                case CardDB.cardIDEnum.BOTA_423:
                    return new Sim_BOTA_423();
                case CardDB.cardIDEnum.BOTA_422:
                    return new Sim_BOTA_422();
                case CardDB.cardIDEnum.BOT_558e:
                    return new Sim_BOT_558e();
                case CardDB.cardIDEnum.BOT_291:
                    return new Sim_BOT_291();
                case CardDB.cardIDEnum.BOTA_BOSS_13p:
                    return new Sim_BOTA_BOSS_13p();
                case CardDB.cardIDEnum.BOTA_642:
                    return new Sim_BOTA_642();
                case CardDB.cardIDEnum.BOT_573:
                    return new Sim_BOT_573();
                case CardDB.cardIDEnum.BOTA_211:
                    return new Sim_BOTA_211();
                case CardDB.cardIDEnum.BOT_406:
                    return new Sim_BOT_406();
                case CardDB.cardIDEnum.BOTA_701:
                    return new Sim_BOTA_701();
                case CardDB.cardIDEnum.BOT_436e:
                    return new Sim_BOT_436e();
                case CardDB.cardIDEnum.BOTA_645:
                    return new Sim_BOTA_645();
                case CardDB.cardIDEnum.BOT_422:
                    return new Sim_BOT_422();
                case CardDB.cardIDEnum.BOT_558:
                    return new Sim_BOT_558();
                case CardDB.cardIDEnum.BOTA_BOSS_01h2:
                    return new Sim_BOTA_BOSS_01h2();
                case CardDB.cardIDEnum.BOTA_631:
                    return new Sim_BOTA_631();
                case CardDB.cardIDEnum.BOTA_321:
                    return new Sim_BOTA_321();
                case CardDB.cardIDEnum.BOT_069:
                    return new Sim_BOT_069();
                case CardDB.cardIDEnum.BOTA_520:
                    return new Sim_BOTA_520();
                case CardDB.cardIDEnum.BOTA_651:
                    return new Sim_BOTA_651();
                case CardDB.cardIDEnum.BOTA_424:
                    return new Sim_BOTA_424();
                case CardDB.cardIDEnum.BOTA_519:
                    return new Sim_BOTA_519();
                case CardDB.cardIDEnum.BOT_568:
                    return new Sim_BOT_568();
                case CardDB.cardIDEnum.BOTA_234:
                    return new Sim_BOTA_234();
                case CardDB.cardIDEnum.BOT_245:
                    return new Sim_BOT_245();
                case CardDB.cardIDEnum.BOTA_207:
                    return new Sim_BOTA_207();
                case CardDB.cardIDEnum.BOTA_453:
                    return new Sim_BOTA_453();
                case CardDB.cardIDEnum.BOTA_316:
                    return new Sim_BOTA_316();
                case CardDB.cardIDEnum.BOTA_507:
                    return new Sim_BOTA_507();
                case CardDB.cardIDEnum.BOT_407:
                    return new Sim_BOT_407();
                case CardDB.cardIDEnum.BOTA_437:
                    return new Sim_BOTA_437();
                case CardDB.cardIDEnum.BOTA_323:
                    return new Sim_BOTA_323();
                case CardDB.cardIDEnum.BOT_517:
                    return new Sim_BOT_517();
                case CardDB.cardIDEnum.BOTA_327:
                    return new Sim_BOTA_327();
                case CardDB.cardIDEnum.BOT_083e:
                    return new Sim_BOT_083e();
                case CardDB.cardIDEnum.BOTA_447:
                    return new Sim_BOTA_447();
                case CardDB.cardIDEnum.BOT_083:
                    return new Sim_BOT_083();
                case CardDB.cardIDEnum.BOTA_BOSS_20p1:
                    return new Sim_BOTA_BOSS_20p1();
                case CardDB.cardIDEnum.BOTA_214:
                    return new Sim_BOTA_214();
                case CardDB.cardIDEnum.BOTA_235:
                    return new Sim_BOTA_235();
                case CardDB.cardIDEnum.BOTA_200:
                    return new Sim_BOTA_200();
                case CardDB.cardIDEnum.BOTA_632:
                    return new Sim_BOTA_632();
                case CardDB.cardIDEnum.BOT_254:
                    return new Sim_BOT_254();
                case CardDB.cardIDEnum.BOT_098:
                    return new Sim_BOT_098();
                case CardDB.cardIDEnum.BOTA_621:
                    return new Sim_BOTA_621();
                case CardDB.cardIDEnum.BOT_309:
                    return new Sim_BOT_309();
                case CardDB.cardIDEnum.BOTA_202:
                    return new Sim_BOTA_202();
                case CardDB.cardIDEnum.BOT_035:
                    return new Sim_BOT_035();
                case CardDB.cardIDEnum.BOT_035e:
                    return new Sim_BOT_035e();
                case CardDB.cardIDEnum.BOT_084:
                    return new Sim_BOT_084();
                case CardDB.cardIDEnum.BOTA_655:
                    return new Sim_BOTA_655();
                case CardDB.cardIDEnum.BOT_443:
                    return new Sim_BOT_443();
                case CardDB.cardIDEnum.BOT_451:
                    return new Sim_BOT_451();
                case CardDB.cardIDEnum.BOT_101e2:
                    return new Sim_BOT_101e2();
                case CardDB.cardIDEnum.BOT_563:
                    return new Sim_BOT_563();
                case CardDB.cardIDEnum.BOT_563e:
                    return new Sim_BOT_563e();
                case CardDB.cardIDEnum.BOTA_452:
                    return new Sim_BOTA_452();
                case CardDB.cardIDEnum.BOT_401:
                    return new Sim_BOT_401();
                case CardDB.cardIDEnum.BOT_042:
                    return new Sim_BOT_042();
                case CardDB.cardIDEnum.BOT_443e:
                    return new Sim_BOT_443e();
                case CardDB.cardIDEnum.BOT_431:
                    return new Sim_BOT_431();
                case CardDB.cardIDEnum.BOT_914:
                    return new Sim_BOT_914();
                case CardDB.cardIDEnum.BOT_914h:
                    return new Sim_BOT_914h();
                case CardDB.cardIDEnum.BOT_238p1:
                    return new Sim_BOT_238p1();
                case CardDB.cardIDEnum.BOT_258:
                    return new Sim_BOT_258();
                case CardDB.cardIDEnum.BOTA_BOSS_05h:
                    return new Sim_BOTA_BOSS_05h();
                case CardDB.cardIDEnum.BOT_567:
                    return new Sim_BOT_567();
                case CardDB.cardIDEnum.BOT_548:
                    return new Sim_BOT_548();
                case CardDB.cardIDEnum.BOT_548e:
                    return new Sim_BOT_548e();
 ///case CardDB.cardIDEnum.///BRM:
                    ///return new Sim_///BRM();
                case CardDB.cardIDEnum.BRMA15_4:
                    return new Sim_BRMA15_4();
                case CardDB.cardIDEnum.BRMA14_10:
                    return new Sim_BRMA14_10();
                case CardDB.cardIDEnum.BRMA14_10H:
                    return new Sim_BRMA14_10H();
                case CardDB.cardIDEnum.BRMA14_2:
                    return new Sim_BRMA14_2();
                case CardDB.cardIDEnum.BRMA14_2H:
                    return new Sim_BRMA14_2H();
                case CardDB.cardIDEnum.BRMA14_6:
                    return new Sim_BRMA14_6();
                case CardDB.cardIDEnum.BRMA14_6H:
                    return new Sim_BRMA14_6H();
                case CardDB.cardIDEnum.BRMA14_8:
                    return new Sim_BRMA14_8();
                case CardDB.cardIDEnum.BRMA14_8H:
                    return new Sim_BRMA14_8H();
                case CardDB.cardIDEnum.BRMA14_4:
                    return new Sim_BRMA14_4();
                case CardDB.cardIDEnum.BRMA14_4H:
                    return new Sim_BRMA14_4H();
                case CardDB.cardIDEnum.BRMA14_3:
                    return new Sim_BRMA14_3();
                case CardDB.cardIDEnum.BRMA16_1:
                    return new Sim_BRMA16_1();
                case CardDB.cardIDEnum.BRMA16_1H:
                    return new Sim_BRMA16_1H();
                case CardDB.cardIDEnum.BRM_016:
                    return new Sim_BRM_016();
                case CardDB.cardIDEnum.BRMA05_1:
                    return new Sim_BRMA05_1();
                case CardDB.cardIDEnum.BRMA05_1H:
                    return new Sim_BRMA05_1H();
                case CardDB.cardIDEnum.BRM_022t:
                    return new Sim_BRM_022t();
                case CardDB.cardIDEnum.BRMA09_4:
                    return new Sim_BRMA09_4();
                case CardDB.cardIDEnum.BRMA09_4H:
                    return new Sim_BRMA09_4H();
                case CardDB.cardIDEnum.BRM_034:
                    return new Sim_BRM_034();
                case CardDB.cardIDEnum.BRM_033:
                    return new Sim_BRM_033();
                case CardDB.cardIDEnum.BRMA10_6e:
                    return new Sim_BRMA10_6e();
                case CardDB.cardIDEnum.BRMA17_6:
                    return new Sim_BRMA17_6();
                case CardDB.cardIDEnum.BRMA17_6H:
                    return new Sim_BRMA17_6H();
                case CardDB.cardIDEnum.BRMA17_5:
                    return new Sim_BRMA17_5();
                case CardDB.cardIDEnum.BRMA17_5H:
                    return new Sim_BRMA17_5H();
                case CardDB.cardIDEnum.BRMA12_2:
                    return new Sim_BRMA12_2();
                case CardDB.cardIDEnum.BRMA12_2H:
                    return new Sim_BRMA12_2H();
                case CardDB.cardIDEnum.BRMA12_6:
                    return new Sim_BRMA12_6();
                case CardDB.cardIDEnum.BRMA12_6H:
                    return new Sim_BRMA12_6H();
                case CardDB.cardIDEnum.BRMA12_5:
                    return new Sim_BRMA12_5();
                case CardDB.cardIDEnum.BRMA12_5H:
                    return new Sim_BRMA12_5H();
                case CardDB.cardIDEnum.BRMA12_7:
                    return new Sim_BRMA12_7();
                case CardDB.cardIDEnum.BRMA12_7H:
                    return new Sim_BRMA12_7H();
                case CardDB.cardIDEnum.BRMA12_4:
                    return new Sim_BRMA12_4();
                case CardDB.cardIDEnum.BRMA12_4H:
                    return new Sim_BRMA12_4H();
                case CardDB.cardIDEnum.BRMA12_3:
                    return new Sim_BRMA12_3();
                case CardDB.cardIDEnum.BRMA12_3H:
                    return new Sim_BRMA12_3H();
                case CardDB.cardIDEnum.BRMA11_3:
                    return new Sim_BRMA11_3();
                case CardDB.cardIDEnum.BRM_031:
                    return new Sim_BRM_031();
                case CardDB.cardIDEnum.BRMA12_1:
                    return new Sim_BRMA12_1();
                case CardDB.cardIDEnum.BRMA12_1H:
                    return new Sim_BRMA12_1H();
                case CardDB.cardIDEnum.BRMA12_8t:
                    return new Sim_BRMA12_8t();
                case CardDB.cardIDEnum.BRMA12_9:
                    return new Sim_BRMA12_9();
                case CardDB.cardIDEnum.BRMA10_5:
                    return new Sim_BRMA10_5();
                case CardDB.cardIDEnum.BRMA10_5H:
                    return new Sim_BRMA10_5H();
                case CardDB.cardIDEnum.BRMA12_8:
                    return new Sim_BRMA12_8();
                case CardDB.cardIDEnum.BRMA17_7:
                    return new Sim_BRMA17_7();
                case CardDB.cardIDEnum.BRM_014:
                    return new Sim_BRM_014();
                case CardDB.cardIDEnum.BRMA01_1:
                    return new Sim_BRMA01_1();
                case CardDB.cardIDEnum.BRMA01_1H:
                    return new Sim_BRMA01_1H();
                case CardDB.cardIDEnum.BRMA10_4:
                    return new Sim_BRMA10_4();
                case CardDB.cardIDEnum.BRMA10_4H:
                    return new Sim_BRMA10_4H();
                case CardDB.cardIDEnum.BRMA01_3:
                    return new Sim_BRMA01_3();
                case CardDB.cardIDEnum.BRM_008:
                    return new Sim_BRM_008();
                case CardDB.cardIDEnum.BRMA02_2t:
                    return new Sim_BRMA02_2t();
                case CardDB.cardIDEnum.BRM_005:
                    return new Sim_BRM_005();
                case CardDB.cardIDEnum.BRM_027p:
                    return new Sim_BRM_027p();
                case CardDB.cardIDEnum.BRMA13_8:
                    return new Sim_BRMA13_8();
                case CardDB.cardIDEnum.BRM_027pH:
                    return new Sim_BRM_027pH();
                case CardDB.cardIDEnum.BRMA09_5:
                    return new Sim_BRMA09_5();
                case CardDB.cardIDEnum.BRMA09_5H:
                    return new Sim_BRMA09_5H();
                case CardDB.cardIDEnum.BRMA12_8te:
                    return new Sim_BRMA12_8te();
                case CardDB.cardIDEnum.BRM_020e:
                    return new Sim_BRM_020e();
                case CardDB.cardIDEnum.BRM_033e:
                    return new Sim_BRM_033e();
                case CardDB.cardIDEnum.BRM_018:
                    return new Sim_BRM_018();
                case CardDB.cardIDEnum.BRM_022:
                    return new Sim_BRM_022();
                case CardDB.cardIDEnum.BRMA09_4Ht:
                    return new Sim_BRMA09_4Ht();
                case CardDB.cardIDEnum.BRMA09_4t:
                    return new Sim_BRMA09_4t();
                case CardDB.cardIDEnum.BRM_020:
                    return new Sim_BRM_020();
                case CardDB.cardIDEnum.BRM_003:
                    return new Sim_BRM_003();
                case CardDB.cardIDEnum.BRM_003e:
                    return new Sim_BRM_003e();
                case CardDB.cardIDEnum.BRMA16_5:
                    return new Sim_BRMA16_5();
                case CardDB.cardIDEnum.BRMA08_3:
                    return new Sim_BRMA08_3();
                case CardDB.cardIDEnum.BRM_024:
                    return new Sim_BRM_024();
                case CardDB.cardIDEnum.BRM_010:
                    return new Sim_BRM_010();
                case CardDB.cardIDEnum.BRM_010t:
                    return new Sim_BRM_010t();
                case CardDB.cardIDEnum.BRM_010t2:
                    return new Sim_BRM_010t2();
                case CardDB.cardIDEnum.OG_044b:
                    return new Sim_OG_044b();
                case CardDB.cardIDEnum.BRMA16_2:
                    return new Sim_BRMA16_2();
                case CardDB.cardIDEnum.BRMA16_2H:
                    return new Sim_BRMA16_2H();
                case CardDB.cardIDEnum.BRMA14_7:
                    return new Sim_BRMA14_7();
                case CardDB.cardIDEnum.BRMA14_7H:
                    return new Sim_BRMA14_7H();
                case CardDB.cardIDEnum.BRMA14_7e:
                    return new Sim_BRMA14_7e();
                case CardDB.cardIDEnum.BRM_028:
                    return new Sim_BRM_028();
                case CardDB.cardIDEnum.BRMA03_1:
                    return new Sim_BRMA03_1();
                case CardDB.cardIDEnum.BRMA03_1H:
                    return new Sim_BRMA03_1H();
                case CardDB.cardIDEnum.BRMA11_2:
                    return new Sim_BRMA11_2();
                case CardDB.cardIDEnum.BRMA11_2H:
                    return new Sim_BRMA11_2H();
                case CardDB.cardIDEnum.BRM_010b:
                    return new Sim_BRM_010b();
                case CardDB.cardIDEnum.BRM_010a:
                    return new Sim_BRM_010a();
                case CardDB.cardIDEnum.BRM_012:
                    return new Sim_BRM_012();
                case CardDB.cardIDEnum.BRMA04_3:
                    return new Sim_BRMA04_3();
                case CardDB.cardIDEnum.BRMA04_3H:
                    return new Sim_BRMA04_3H();
                case CardDB.cardIDEnum.BRMA_01:
                    return new Sim_BRMA_01();
                case CardDB.cardIDEnum.BRM_002:
                    return new Sim_BRM_002();
                case CardDB.cardIDEnum.BRMA06_4:
                    return new Sim_BRMA06_4();
                case CardDB.cardIDEnum.BRMA06_4H:
                    return new Sim_BRMA06_4H();
                case CardDB.cardIDEnum.BRM_007:
                    return new Sim_BRM_007();
                case CardDB.cardIDEnum.BRMA04_1:
                    return new Sim_BRMA04_1();
                case CardDB.cardIDEnum.BRMA04_1H:
                    return new Sim_BRMA04_1H();
                case CardDB.cardIDEnum.BRMA08_1:
                    return new Sim_BRMA08_1();
                case CardDB.cardIDEnum.BRMA08_1H:
                    return new Sim_BRMA08_1H();
                case CardDB.cardIDEnum.BRMA01_4:
                    return new Sim_BRMA01_4();
                case CardDB.cardIDEnum.BRM_019:
                    return new Sim_BRM_019();
                case CardDB.cardIDEnum.BRMA01_4t:
                    return new Sim_BRMA01_4t();
                case CardDB.cardIDEnum.BRMA09_5Ht:
                    return new Sim_BRMA09_5Ht();
                case CardDB.cardIDEnum.BRMA09_5t:
                    return new Sim_BRMA09_5t();
                case CardDB.cardIDEnum.BRMA02_1:
                    return new Sim_BRMA02_1();
                case CardDB.cardIDEnum.BRMA02_1H:
                    return new Sim_BRMA02_1H();
                case CardDB.cardIDEnum.BRMA07_1:
                    return new Sim_BRMA07_1();
                case CardDB.cardIDEnum.BRMA07_1H:
                    return new Sim_BRMA07_1H();
                case CardDB.cardIDEnum.BRM_026:
                    return new Sim_BRM_026();
                case CardDB.cardIDEnum.BRMA16_5e:
                    return new Sim_BRMA16_5e();
                case CardDB.cardIDEnum.BRMA05_2:
                    return new Sim_BRMA05_2();
                case CardDB.cardIDEnum.BRMA05_2H:
                    return new Sim_BRMA05_2H();
                case CardDB.cardIDEnum.BRM_006t:
                    return new Sim_BRM_006t();
                case CardDB.cardIDEnum.BRM_006:
                    return new Sim_BRM_006();
                case CardDB.cardIDEnum.BRM_028e:
                    return new Sim_BRM_028e();
                case CardDB.cardIDEnum.BRMA10_3e:
                    return new Sim_BRMA10_3e();
                case CardDB.cardIDEnum.BRMA08_2:
                    return new Sim_BRMA08_2();
                case CardDB.cardIDEnum.BRMA08_2H:
                    return new Sim_BRMA08_2H();
                case CardDB.cardIDEnum.BRMA02_2:
                    return new Sim_BRMA02_2();
                case CardDB.cardIDEnum.BRMA02_2H:
                    return new Sim_BRMA02_2H();
                case CardDB.cardIDEnum.BRM_024e:
                    return new Sim_BRM_024e();
                case CardDB.cardIDEnum.BRMA17_4:
                    return new Sim_BRMA17_4();
                case CardDB.cardIDEnum.BRM_011:
                    return new Sim_BRM_011();
                case CardDB.cardIDEnum.BRM_011t:
                    return new Sim_BRM_011t();
                case CardDB.cardIDEnum.BRMA05_3:
                    return new Sim_BRMA05_3();
                case CardDB.cardIDEnum.BRMA05_3e:
                    return new Sim_BRMA05_3e();
                case CardDB.cardIDEnum.BRMA05_3H:
                    return new Sim_BRMA05_3H();
                case CardDB.cardIDEnum.BRMA05_3He:
                    return new Sim_BRMA05_3He();
                case CardDB.cardIDEnum.BRMA13_6:
                    return new Sim_BRMA13_6();
                case CardDB.cardIDEnum.BRMA13_1:
                    return new Sim_BRMA13_1();
                case CardDB.cardIDEnum.BRMA13_1H:
                    return new Sim_BRMA13_1H();
                case CardDB.cardIDEnum.BRMA04_2:
                    return new Sim_BRMA04_2();
                case CardDB.cardIDEnum.BRMA14_9:
                    return new Sim_BRMA14_9();
                case CardDB.cardIDEnum.BRMA14_9H:
                    return new Sim_BRMA14_9H();
                case CardDB.cardIDEnum.BRMA14_12:
                    return new Sim_BRMA14_12();
                case CardDB.cardIDEnum.BRM_027:
                    return new Sim_BRM_027();
                case CardDB.cardIDEnum.BRMA06_1:
                    return new Sim_BRMA06_1();
                case CardDB.cardIDEnum.BRMA06_1H:
                    return new Sim_BRMA06_1H();
                case CardDB.cardIDEnum.BRMA15_1:
                    return new Sim_BRMA15_1();
                case CardDB.cardIDEnum.BRMA15_1H:
                    return new Sim_BRMA15_1H();
                case CardDB.cardIDEnum.BRMA07_2:
                    return new Sim_BRMA07_2();
                case CardDB.cardIDEnum.BRMA07_2H:
                    return new Sim_BRMA07_2H();
                case CardDB.cardIDEnum.BRM_001e:
                    return new Sim_BRM_001e();
                case CardDB.cardIDEnum.BRMA03_3:
                    return new Sim_BRMA03_3();
                case CardDB.cardIDEnum.BRMA03_3H:
                    return new Sim_BRMA03_3H();
                case CardDB.cardIDEnum.BRMA03_3e:
                    return new Sim_BRMA03_3e();
                case CardDB.cardIDEnum.BRMA12_10:
                    return new Sim_BRMA12_10();
                case CardDB.cardIDEnum.BRM_030:
                    return new Sim_BRM_030();
                case CardDB.cardIDEnum.BRMA13_3:
                    return new Sim_BRMA13_3();
                case CardDB.cardIDEnum.BRMA13_3H:
                    return new Sim_BRMA13_3H();
                case CardDB.cardIDEnum.BRMA17_2:
                    return new Sim_BRMA17_2();
                case CardDB.cardIDEnum.BRMA17_2H:
                    return new Sim_BRMA17_2H();
                case CardDB.cardIDEnum.BRMA17_8:
                    return new Sim_BRMA17_8();
                case CardDB.cardIDEnum.BRMA17_8H:
                    return new Sim_BRMA17_8H();
                case CardDB.cardIDEnum.BRMA09_3:
                    return new Sim_BRMA09_3();
                case CardDB.cardIDEnum.BRMA09_3H:
                    return new Sim_BRMA09_3H();
                case CardDB.cardIDEnum.BRMA09_3Ht:
                    return new Sim_BRMA09_3Ht();
                case CardDB.cardIDEnum.BRMA09_3t:
                    return new Sim_BRMA09_3t();
                case CardDB.cardIDEnum.BRMA14_1:
                    return new Sim_BRMA14_1();
                case CardDB.cardIDEnum.BRMA14_1H:
                    return new Sim_BRMA14_1H();
                case CardDB.cardIDEnum.BRM_012e:
                    return new Sim_BRM_012e();
                case CardDB.cardIDEnum.BRMA17_3:
                    return new Sim_BRMA17_3();
                case CardDB.cardIDEnum.BRMA17_3H:
                    return new Sim_BRMA17_3H();
                case CardDB.cardIDEnum.BRMA17_9:
                    return new Sim_BRMA17_9();
                case CardDB.cardIDEnum.BRMA09_2:
                    return new Sim_BRMA09_2();
                case CardDB.cardIDEnum.BRMA09_2H:
                    return new Sim_BRMA09_2H();
                case CardDB.cardIDEnum.BRMA01_2:
                    return new Sim_BRMA01_2();
                case CardDB.cardIDEnum.BRMA01_2H:
                    return new Sim_BRMA01_2H();
                case CardDB.cardIDEnum.BRMA15_2He:
                    return new Sim_BRMA15_2He();
                case CardDB.cardIDEnum.BRMA03_2:
                    return new Sim_BRMA03_2();
                case CardDB.cardIDEnum.BRM_014e:
                    return new Sim_BRM_014e();
                case CardDB.cardIDEnum.BRM_013:
                    return new Sim_BRM_013();
                case CardDB.cardIDEnum.BRM_027h:
                    return new Sim_BRM_027h();
                case CardDB.cardIDEnum.BRMA06_3:
                    return new Sim_BRMA06_3();
                case CardDB.cardIDEnum.BRMA06_3H:
                    return new Sim_BRMA06_3H();
                case CardDB.cardIDEnum.BRMA10_1:
                    return new Sim_BRMA10_1();
                case CardDB.cardIDEnum.BRMA10_1H:
                    return new Sim_BRMA10_1H();
                case CardDB.cardIDEnum.BRMA10_6:
                    return new Sim_BRMA10_6();
                case CardDB.cardIDEnum.BRMA14_11:
                    return new Sim_BRMA14_11();
                case CardDB.cardIDEnum.BRMA15_3:
                    return new Sim_BRMA15_3();
                case CardDB.cardIDEnum.BRM_029:
                    return new Sim_BRM_029();
                case CardDB.cardIDEnum.BRMA09_1:
                    return new Sim_BRMA09_1();
                case CardDB.cardIDEnum.BRMA09_1H:
                    return new Sim_BRMA09_1H();
                case CardDB.cardIDEnum.BRM_017:
                    return new Sim_BRM_017();
                case CardDB.cardIDEnum.BRM_015:
                    return new Sim_BRM_015();
                case CardDB.cardIDEnum.BRMA16_4:
                    return new Sim_BRMA16_4();
                case CardDB.cardIDEnum.BRMA04_4:
                    return new Sim_BRMA04_4();
                case CardDB.cardIDEnum.BRMA04_4H:
                    return new Sim_BRMA04_4H();
                case CardDB.cardIDEnum.BRM_001:
                    return new Sim_BRM_001();
                case CardDB.cardIDEnum.BRMA13_5:
                    return new Sim_BRMA13_5();
                case CardDB.cardIDEnum.BRMA16_3:
                    return new Sim_BRMA16_3();
                case CardDB.cardIDEnum.BRMA16_3e:
                    return new Sim_BRMA16_3e();
                case CardDB.cardIDEnum.BRM_030t:
                    return new Sim_BRM_030t();
                case CardDB.cardIDEnum.BRMA15_2:
                    return new Sim_BRMA15_2();
                case CardDB.cardIDEnum.BRMA15_2H:
                    return new Sim_BRMA15_2H();
                case CardDB.cardIDEnum.BRMA06_2:
                    return new Sim_BRMA06_2();
                case CardDB.cardIDEnum.BRMA06_2H:
                    return new Sim_BRMA06_2H();
                case CardDB.cardIDEnum.BRMA10_3:
                    return new Sim_BRMA10_3();
                case CardDB.cardIDEnum.BRMA10_3H:
                    return new Sim_BRMA10_3H();
                case CardDB.cardIDEnum.BRMA09_6:
                    return new Sim_BRMA09_6();
                case CardDB.cardIDEnum.BRMA07_3:
                    return new Sim_BRMA07_3();
                case CardDB.cardIDEnum.BRMA14_5:
                    return new Sim_BRMA14_5();
                case CardDB.cardIDEnum.BRMA14_5H:
                    return new Sim_BRMA14_5H();
                case CardDB.cardIDEnum.BRMA13_2:
                    return new Sim_BRMA13_2();
                case CardDB.cardIDEnum.BRMA13_2H:
                    return new Sim_BRMA13_2H();
                case CardDB.cardIDEnum.BRM_004e:
                    return new Sim_BRM_004e();
                case CardDB.cardIDEnum.BRM_004:
                    return new Sim_BRM_004();
                case CardDB.cardIDEnum.BRM_018e:
                    return new Sim_BRM_018e();
                case CardDB.cardIDEnum.BRMA11_1:
                    return new Sim_BRMA11_1();
                case CardDB.cardIDEnum.BRMA11_1H:
                    return new Sim_BRMA11_1H();
                case CardDB.cardIDEnum.BRM_025:
                    return new Sim_BRM_025();
                case CardDB.cardIDEnum.BRM_009:
                    return new Sim_BRM_009();
                case CardDB.cardIDEnum.BRM_004t:
                    return new Sim_BRM_004t();
                case CardDB.cardIDEnum.BRMA09_2Ht:
                    return new Sim_BRMA09_2Ht();
                case CardDB.cardIDEnum.BRMA09_2t:
                    return new Sim_BRMA09_2t();
                case CardDB.cardIDEnum.BRMA13_7:
                    return new Sim_BRMA13_7();
                case CardDB.cardIDEnum.BRMA13_4:
                    return new Sim_BRMA13_4();
                case CardDB.cardIDEnum.BRMA13_4H:
                    return new Sim_BRMA13_4H();
 ///case CardDB.cardIDEnum.///GANGS:
                    ///return new Sim_///GANGS();
                case CardDB.cardIDEnum.CFM_751:
                    return new Sim_CFM_751();
                case CardDB.cardIDEnum.CFM_756:
                    return new Sim_CFM_756();
                case CardDB.cardIDEnum.CFM_315:
                    return new Sim_CFM_315();
                case CardDB.cardIDEnum.CFM_854:
                    return new Sim_CFM_854();
                case CardDB.cardIDEnum.CFM_807:
                    return new Sim_CFM_807();
                case CardDB.cardIDEnum.CFM_902:
                    return new Sim_CFM_902();
                case CardDB.cardIDEnum.CFM_658:
                    return new Sim_CFM_658();
                case CardDB.cardIDEnum.CFM_646:
                    return new Sim_CFM_646();
                case CardDB.cardIDEnum.CFM_648:
                    return new Sim_CFM_648();
                case CardDB.cardIDEnum.CFM_608:
                    return new Sim_CFM_608();
                case CardDB.cardIDEnum.CFM_611:
                    return new Sim_CFM_611();
                case CardDB.cardIDEnum.CFM_647:
                    return new Sim_CFM_647();
                case CardDB.cardIDEnum.CFM_064:
                    return new Sim_CFM_064();
                case CardDB.cardIDEnum.CFM_667:
                    return new Sim_CFM_667();
                case CardDB.cardIDEnum.CFM_631:
                    return new Sim_CFM_631();
                case CardDB.cardIDEnum.CFM_669:
                    return new Sim_CFM_669();
                case CardDB.cardIDEnum.CFM_310:
                    return new Sim_CFM_310();
                case CardDB.cardIDEnum.CFM_617:
                    return new Sim_CFM_617();
                case CardDB.cardIDEnum.CFM_630:
                    return new Sim_CFM_630();
                case CardDB.cardIDEnum.CFM_671:
                    return new Sim_CFM_671();
                case CardDB.cardIDEnum.CFM_606t:
                    return new Sim_CFM_606t();
                case CardDB.cardIDEnum.CFM_610:
                    return new Sim_CFM_610();
                case CardDB.cardIDEnum.CFM_602a:
                    return new Sim_CFM_602a();
                case CardDB.cardIDEnum.CFM_658e:
                    return new Sim_CFM_658e();
                case CardDB.cardIDEnum.CFM_851:
                    return new Sim_CFM_851();
                case CardDB.cardIDEnum.CFM_855:
                    return new Sim_CFM_855();
                case CardDB.cardIDEnum.CFM_611e:
                    return new Sim_CFM_611e();
                case CardDB.cardIDEnum.CFM_611e2:
                    return new Sim_CFM_611e2();
                case CardDB.cardIDEnum.CFM_696:
                    return new Sim_CFM_696();
                case CardDB.cardIDEnum.CFM_790:
                    return new Sim_CFM_790();
                case CardDB.cardIDEnum.CFM_335:
                    return new Sim_CFM_335();
                case CardDB.cardIDEnum.CFM_685:
                    return new Sim_CFM_685();
                case CardDB.cardIDEnum.CFM_668:
                    return new Sim_CFM_668();
                case CardDB.cardIDEnum.CFM_668t:
                    return new Sim_CFM_668t();
                case CardDB.cardIDEnum.CFM_668t2:
                    return new Sim_CFM_668t2();
                case CardDB.cardIDEnum.CFM_662:
                    return new Sim_CFM_662();
                case CardDB.cardIDEnum.CFM_605:
                    return new Sim_CFM_605();
                case CardDB.cardIDEnum.CFM_325e:
                    return new Sim_CFM_325e();
                case CardDB.cardIDEnum.CFM_651e:
                    return new Sim_CFM_651e();
                case CardDB.cardIDEnum.CFM_609:
                    return new Sim_CFM_609();
                case CardDB.cardIDEnum.CFM_621t18:
                    return new Sim_CFM_621t18();
                case CardDB.cardIDEnum.CFM_621t33:
                    return new Sim_CFM_621t33();
                case CardDB.cardIDEnum.CFM_621t4:
                    return new Sim_CFM_621t4();
                case CardDB.cardIDEnum.CFM_094:
                    return new Sim_CFM_094();
                case CardDB.cardIDEnum.CFM_328:
                    return new Sim_CFM_328();
                case CardDB.cardIDEnum.CFM_313:
                    return new Sim_CFM_313();
                case CardDB.cardIDEnum.CFM_344:
                    return new Sim_CFM_344();
                case CardDB.cardIDEnum.CFM_308a:
                    return new Sim_CFM_308a();
                case CardDB.cardIDEnum.CFM_308b:
                    return new Sim_CFM_308b();
                case CardDB.cardIDEnum.CFM_626e:
                    return new Sim_CFM_626e();
                case CardDB.cardIDEnum.CFM_687e:
                    return new Sim_CFM_687e();
                case CardDB.cardIDEnum.CFM_021:
                    return new Sim_CFM_021();
                case CardDB.cardIDEnum.CFM_654:
                    return new Sim_CFM_654();
                case CardDB.cardIDEnum.CFM_693:
                    return new Sim_CFM_693();
                case CardDB.cardIDEnum.CFM_659:
                    return new Sim_CFM_659();
                case CardDB.cardIDEnum.CFM_808:
                    return new Sim_CFM_808();
                case CardDB.cardIDEnum.CFM_816e:
                    return new Sim_CFM_816e();
                case CardDB.cardIDEnum.CFM_800:
                    return new Sim_CFM_800();
                case CardDB.cardIDEnum.CFM_621e:
                    return new Sim_CFM_621e();
                case CardDB.cardIDEnum.CFM_621e2:
                    return new Sim_CFM_621e2();
                case CardDB.cardIDEnum.CFM_621e3:
                    return new Sim_CFM_621e3();
                case CardDB.cardIDEnum.CFM_621t24:
                    return new Sim_CFM_621t24();
                case CardDB.cardIDEnum.CFM_621t32:
                    return new Sim_CFM_621t32();
                case CardDB.cardIDEnum.CFM_621t6:
                    return new Sim_CFM_621t6();
                case CardDB.cardIDEnum.CFM_623:
                    return new Sim_CFM_623();
                case CardDB.cardIDEnum.CFM_604:
                    return new Sim_CFM_604();
                case CardDB.cardIDEnum.CFM_621t12:
                    return new Sim_CFM_621t12();
                case CardDB.cardIDEnum.CFM_639:
                    return new Sim_CFM_639();
                case CardDB.cardIDEnum.CFM_321:
                    return new Sim_CFM_321();
                case CardDB.cardIDEnum.CFM_753:
                    return new Sim_CFM_753();
                case CardDB.cardIDEnum.CFM_755:
                    return new Sim_CFM_755();
                case CardDB.cardIDEnum.CFM_062:
                    return new Sim_CFM_062();
                case CardDB.cardIDEnum.CFM_853:
                    return new Sim_CFM_853();
                case CardDB.cardIDEnum.CFM_650:
                    return new Sim_CFM_650();
                case CardDB.cardIDEnum.CFM_754:
                    return new Sim_CFM_754();
                case CardDB.cardIDEnum.CFM_666:
                    return new Sim_CFM_666();
                case CardDB.cardIDEnum.CFM_621t16:
                    return new Sim_CFM_621t16();
                case CardDB.cardIDEnum.CFM_621t2:
                    return new Sim_CFM_621t2();
                case CardDB.cardIDEnum.CFM_621t25:
                    return new Sim_CFM_621t25();
                case CardDB.cardIDEnum.CFM_026:
                    return new Sim_CFM_026();
                case CardDB.cardIDEnum.CFM_653:
                    return new Sim_CFM_653();
                case CardDB.cardIDEnum.CFM_643:
                    return new Sim_CFM_643();
                case CardDB.cardIDEnum.CFM_067:
                    return new Sim_CFM_067();
                case CardDB.cardIDEnum.CFM_940:
                    return new Sim_CFM_940();
                case CardDB.cardIDEnum.CFM_621t19:
                    return new Sim_CFM_621t19();
                case CardDB.cardIDEnum.CFM_621t27:
                    return new Sim_CFM_621t27();
                case CardDB.cardIDEnum.CFM_621t5:
                    return new Sim_CFM_621t5();
                case CardDB.cardIDEnum.CFM_621t37:
                    return new Sim_CFM_621t37();
                case CardDB.cardIDEnum.CFM_621t38:
                    return new Sim_CFM_621t38();
                case CardDB.cardIDEnum.CFM_621t39:
                    return new Sim_CFM_621t39();
                case CardDB.cardIDEnum.CFM_687:
                    return new Sim_CFM_687();
                case CardDB.cardIDEnum.CFM_343:
                    return new Sim_CFM_343();
                case CardDB.cardIDEnum.CFM_713:
                    return new Sim_CFM_713();
                case CardDB.cardIDEnum.CFM_312:
                    return new Sim_CFM_312();
                case CardDB.cardIDEnum.CFM_717:
                    return new Sim_CFM_717();
                case CardDB.cardIDEnum.CFM_712_t01:
                    return new Sim_CFM_712_t01();
                case CardDB.cardIDEnum.CFM_712_t02:
                    return new Sim_CFM_712_t02();
                case CardDB.cardIDEnum.CFM_712_t03:
                    return new Sim_CFM_712_t03();
                case CardDB.cardIDEnum.CFM_712_t04:
                    return new Sim_CFM_712_t04();
                case CardDB.cardIDEnum.CFM_712_t05:
                    return new Sim_CFM_712_t05();
                case CardDB.cardIDEnum.CFM_712_t06:
                    return new Sim_CFM_712_t06();
                case CardDB.cardIDEnum.CFM_712_t07:
                    return new Sim_CFM_712_t07();
                case CardDB.cardIDEnum.CFM_712_t08:
                    return new Sim_CFM_712_t08();
                case CardDB.cardIDEnum.CFM_712_t09:
                    return new Sim_CFM_712_t09();
                case CardDB.cardIDEnum.CFM_712_t10:
                    return new Sim_CFM_712_t10();
                case CardDB.cardIDEnum.CFM_712_t11:
                    return new Sim_CFM_712_t11();
                case CardDB.cardIDEnum.CFM_712_t12:
                    return new Sim_CFM_712_t12();
                case CardDB.cardIDEnum.CFM_712_t13:
                    return new Sim_CFM_712_t13();
                case CardDB.cardIDEnum.CFM_712_t14:
                    return new Sim_CFM_712_t14();
                case CardDB.cardIDEnum.CFM_712_t15:
                    return new Sim_CFM_712_t15();
                case CardDB.cardIDEnum.CFM_712_t16:
                    return new Sim_CFM_712_t16();
                case CardDB.cardIDEnum.CFM_712_t17:
                    return new Sim_CFM_712_t17();
                case CardDB.cardIDEnum.CFM_712_t18:
                    return new Sim_CFM_712_t18();
                case CardDB.cardIDEnum.CFM_712_t19:
                    return new Sim_CFM_712_t19();
                case CardDB.cardIDEnum.CFM_712_t20:
                    return new Sim_CFM_712_t20();
                case CardDB.cardIDEnum.CFM_712_t21:
                    return new Sim_CFM_712_t21();
                case CardDB.cardIDEnum.CFM_712_t22:
                    return new Sim_CFM_712_t22();
                case CardDB.cardIDEnum.CFM_712_t23:
                    return new Sim_CFM_712_t23();
                case CardDB.cardIDEnum.CFM_712_t24:
                    return new Sim_CFM_712_t24();
                case CardDB.cardIDEnum.CFM_712_t25:
                    return new Sim_CFM_712_t25();
                case CardDB.cardIDEnum.CFM_712_t26:
                    return new Sim_CFM_712_t26();
                case CardDB.cardIDEnum.CFM_712_t27:
                    return new Sim_CFM_712_t27();
                case CardDB.cardIDEnum.CFM_712_t28:
                    return new Sim_CFM_712_t28();
                case CardDB.cardIDEnum.CFM_712_t29:
                    return new Sim_CFM_712_t29();
                case CardDB.cardIDEnum.CFM_712_t30:
                    return new Sim_CFM_712_t30();
                case CardDB.cardIDEnum.CFM_602:
                    return new Sim_CFM_602();
                case CardDB.cardIDEnum.CFM_707:
                    return new Sim_CFM_707();
                case CardDB.cardIDEnum.CFM_690:
                    return new Sim_CFM_690();
                case CardDB.cardIDEnum.CFM_715:
                    return new Sim_CFM_715();
                case CardDB.cardIDEnum.CFM_602b:
                    return new Sim_CFM_602b();
                case CardDB.cardIDEnum.CFM_691:
                    return new Sim_CFM_691();
                case CardDB.cardIDEnum.CFM_061:
                    return new Sim_CFM_061();
                case CardDB.cardIDEnum.CFM_619:
                    return new Sim_CFM_619();
                case CardDB.cardIDEnum.CFM_649:
                    return new Sim_CFM_649();
                case CardDB.cardIDEnum.CFM_760:
                    return new Sim_CFM_760();
                case CardDB.cardIDEnum.CFM_621_m2:
                    return new Sim_CFM_621_m2();
                case CardDB.cardIDEnum.CFM_621_m3:
                    return new Sim_CFM_621_m3();
                case CardDB.cardIDEnum.CFM_621_m4:
                    return new Sim_CFM_621_m4();
                case CardDB.cardIDEnum.CFM_066:
                    return new Sim_CFM_066();
                case CardDB.cardIDEnum.CFM_657:
                    return new Sim_CFM_657();
                case CardDB.cardIDEnum.CFM_626:
                    return new Sim_CFM_626();
                case CardDB.cardIDEnum.CFM_663:
                    return new Sim_CFM_663();
                case CardDB.cardIDEnum.CFM_621:
                    return new Sim_CFM_621();
                case CardDB.cardIDEnum.CFM_621t:
                    return new Sim_CFM_621t();
                case CardDB.cardIDEnum.CFM_621t14:
                    return new Sim_CFM_621t14();
                case CardDB.cardIDEnum.CFM_621t15:
                    return new Sim_CFM_621t15();
                case CardDB.cardIDEnum.CFM_621t22:
                    return new Sim_CFM_621t22();
                case CardDB.cardIDEnum.CFM_621t30:
                    return new Sim_CFM_621t30();
                case CardDB.cardIDEnum.CFM_621t8:
                    return new Sim_CFM_621t8();
                case CardDB.cardIDEnum.CFM_333:
                    return new Sim_CFM_333();
                case CardDB.cardIDEnum.CFM_063:
                    return new Sim_CFM_063();
                case CardDB.cardIDEnum.CFM_063e:
                    return new Sim_CFM_063e();
                case CardDB.cardIDEnum.CFM_750:
                    return new Sim_CFM_750();
                case CardDB.cardIDEnum.CFM_308:
                    return new Sim_CFM_308();
                case CardDB.cardIDEnum.CFM_810:
                    return new Sim_CFM_810();
                case CardDB.cardIDEnum.CFM_621t11:
                    return new Sim_CFM_621t11();
                case CardDB.cardIDEnum.CFM_648t:
                    return new Sim_CFM_648t();
                case CardDB.cardIDEnum.CFM_342e:
                    return new Sim_CFM_342e();
                case CardDB.cardIDEnum.CFM_852:
                    return new Sim_CFM_852();
                case CardDB.cardIDEnum.CFM_634:
                    return new Sim_CFM_634();
                case CardDB.cardIDEnum.CFM_697:
                    return new Sim_CFM_697();
                case CardDB.cardIDEnum.CFM_342:
                    return new Sim_CFM_342();
                case CardDB.cardIDEnum.CFM_811:
                    return new Sim_CFM_811();
                case CardDB.cardIDEnum.CFM_672:
                    return new Sim_CFM_672();
                case CardDB.cardIDEnum.CFM_603e:
                    return new Sim_CFM_603e();
                case CardDB.cardIDEnum.CFM_606:
                    return new Sim_CFM_606();
                case CardDB.cardIDEnum.CFM_060e:
                    return new Sim_CFM_060e();
                case CardDB.cardIDEnum.CFM_660:
                    return new Sim_CFM_660();
                case CardDB.cardIDEnum.CFM_614:
                    return new Sim_CFM_614();
                case CardDB.cardIDEnum.CFM_670:
                    return new Sim_CFM_670();
                case CardDB.cardIDEnum.CFM_759:
                    return new Sim_CFM_759();
                case CardDB.cardIDEnum.CFM_120:
                    return new Sim_CFM_120();
                case CardDB.cardIDEnum.CFM_310t:
                    return new Sim_CFM_310t();
                case CardDB.cardIDEnum.CFM_621t21:
                    return new Sim_CFM_621t21();
                case CardDB.cardIDEnum.CFM_621t29:
                    return new Sim_CFM_621t29();
                case CardDB.cardIDEnum.CFM_651:
                    return new Sim_CFM_651();
                case CardDB.cardIDEnum.CFM_621t10:
                    return new Sim_CFM_621t10();
                case CardDB.cardIDEnum.CFM_621t20:
                    return new Sim_CFM_621t20();
                case CardDB.cardIDEnum.CFM_621t28:
                    return new Sim_CFM_621t28();
                case CardDB.cardIDEnum.CFM_637:
                    return new Sim_CFM_637();
                case CardDB.cardIDEnum.CFM_616:
                    return new Sim_CFM_616();
                case CardDB.cardIDEnum.CFM_661:
                    return new Sim_CFM_661();
                case CardDB.cardIDEnum.CFM_337t:
                    return new Sim_CFM_337t();
                case CardDB.cardIDEnum.CFM_337:
                    return new Sim_CFM_337();
                case CardDB.cardIDEnum.CFM_603:
                    return new Sim_CFM_603();
                case CardDB.cardIDEnum.CFM_620:
                    return new Sim_CFM_620();
                case CardDB.cardIDEnum.CFM_300:
                    return new Sim_CFM_300();
                case CardDB.cardIDEnum.TB_HealthAttackSwap_Ench:
                    return new Sim_TB_HealthAttackSwap_Ench();
                case CardDB.cardIDEnum.CFM_316t:
                    return new Sim_CFM_316t();
                case CardDB.cardIDEnum.CFM_316:
                    return new Sim_CFM_316();
                case CardDB.cardIDEnum.CFM_020e:
                    return new Sim_CFM_020e();
                case CardDB.cardIDEnum.CFM_020:
                    return new Sim_CFM_020();
                case CardDB.cardIDEnum.CFM_060:
                    return new Sim_CFM_060();
                case CardDB.cardIDEnum.CFM_614e:
                    return new Sim_CFM_614e();
                case CardDB.cardIDEnum.CFM_699e:
                    return new Sim_CFM_699e();
                case CardDB.cardIDEnum.CFM_699:
                    return new Sim_CFM_699();
                case CardDB.cardIDEnum.CFM_652:
                    return new Sim_CFM_652();
                case CardDB.cardIDEnum.CFM_341:
                    return new Sim_CFM_341();
                case CardDB.cardIDEnum.CFM_610e:
                    return new Sim_CFM_610e();
                case CardDB.cardIDEnum.CFM_621t23:
                    return new Sim_CFM_621t23();
                case CardDB.cardIDEnum.CFM_621t31:
                    return new Sim_CFM_621t31();
                case CardDB.cardIDEnum.CFM_621t9:
                    return new Sim_CFM_621t9();
                case CardDB.cardIDEnum.CFM_636:
                    return new Sim_CFM_636();
                case CardDB.cardIDEnum.CFM_694:
                    return new Sim_CFM_694();
                case CardDB.cardIDEnum.CFM_781:
                    return new Sim_CFM_781();
                case CardDB.cardIDEnum.CFM_336:
                    return new Sim_CFM_336();
                case CardDB.cardIDEnum.CFM_621_m5:
                    return new Sim_CFM_621_m5();
                case CardDB.cardIDEnum.CFM_661e:
                    return new Sim_CFM_661e();
                case CardDB.cardIDEnum.CFM_064e:
                    return new Sim_CFM_064e();
                case CardDB.cardIDEnum.CFM_716:
                    return new Sim_CFM_716();
                case CardDB.cardIDEnum.CFM_325:
                    return new Sim_CFM_325();
                case CardDB.cardIDEnum.CFM_905:
                    return new Sim_CFM_905();
                case CardDB.cardIDEnum.CFM_334:
                    return new Sim_CFM_334();
                case CardDB.cardIDEnum.CFM_305:
                    return new Sim_CFM_305();
                case CardDB.cardIDEnum.CFM_026e:
                    return new Sim_CFM_026e();
                case CardDB.cardIDEnum.CFM_305e:
                    return new Sim_CFM_305e();
                case CardDB.cardIDEnum.CFM_334e:
                    return new Sim_CFM_334e();
                case CardDB.cardIDEnum.CFM_336e:
                    return new Sim_CFM_336e();
                case CardDB.cardIDEnum.CFM_338e:
                    return new Sim_CFM_338e();
                case CardDB.cardIDEnum.CFM_631e:
                    return new Sim_CFM_631e();
                case CardDB.cardIDEnum.CFM_639e:
                    return new Sim_CFM_639e();
                case CardDB.cardIDEnum.CFM_643e:
                    return new Sim_CFM_643e();
                case CardDB.cardIDEnum.CFM_643e2:
                    return new Sim_CFM_643e2();
                case CardDB.cardIDEnum.CFM_650e:
                    return new Sim_CFM_650e();
                case CardDB.cardIDEnum.CFM_685e:
                    return new Sim_CFM_685e();
                case CardDB.cardIDEnum.CFM_752e:
                    return new Sim_CFM_752e();
                case CardDB.cardIDEnum.CFM_753e:
                    return new Sim_CFM_753e();
                case CardDB.cardIDEnum.CFM_754e:
                    return new Sim_CFM_754e();
                case CardDB.cardIDEnum.CFM_755e:
                    return new Sim_CFM_755e();
                case CardDB.cardIDEnum.CFM_853e:
                    return new Sim_CFM_853e();
                case CardDB.cardIDEnum.TB_BossRumble001hpe:
                    return new Sim_TB_BossRumble001hpe();
                case CardDB.cardIDEnum.CFM_688:
                    return new Sim_CFM_688();
                case CardDB.cardIDEnum.CFM_752:
                    return new Sim_CFM_752();
                case CardDB.cardIDEnum.CFM_621t17:
                    return new Sim_CFM_621t17();
                case CardDB.cardIDEnum.CFM_621t26:
                    return new Sim_CFM_621t26();
                case CardDB.cardIDEnum.CFM_621t3:
                    return new Sim_CFM_621t3();
                case CardDB.cardIDEnum.CFM_039:
                    return new Sim_CFM_039();
                case CardDB.cardIDEnum.CFM_656:
                    return new Sim_CFM_656();
                case CardDB.cardIDEnum.CFM_621t13:
                    return new Sim_CFM_621t13();
                case CardDB.cardIDEnum.CFM_315t:
                    return new Sim_CFM_315t();
                case CardDB.cardIDEnum.CFM_809:
                    return new Sim_CFM_809();
                case CardDB.cardIDEnum.CFM_851e:
                    return new Sim_CFM_851e();
                case CardDB.cardIDEnum.CFM_324t:
                    return new Sim_CFM_324t();
                case CardDB.cardIDEnum.CFM_655:
                    return new Sim_CFM_655();
                case CardDB.cardIDEnum.CFM_694e:
                    return new Sim_CFM_694e();
                case CardDB.cardIDEnum.CFM_338:
                    return new Sim_CFM_338();
                case CardDB.cardIDEnum.CFM_900:
                    return new Sim_CFM_900();
                case CardDB.cardIDEnum.CFM_816:
                    return new Sim_CFM_816();
                case CardDB.cardIDEnum.CFM_617e:
                    return new Sim_CFM_617e();
                case CardDB.cardIDEnum.CFM_065:
                    return new Sim_CFM_065();
                case CardDB.cardIDEnum.CFM_671e:
                    return new Sim_CFM_671e();
                case CardDB.cardIDEnum.CFM_095:
                    return new Sim_CFM_095();
                case CardDB.cardIDEnum.CFM_324:
                    return new Sim_CFM_324();
                case CardDB.cardIDEnum.CFM_815:
                    return new Sim_CFM_815();
                case CardDB.cardIDEnum.CFM_025:
                    return new Sim_CFM_025();
                case CardDB.cardIDEnum.CFM_665:
                    return new Sim_CFM_665();
                case CardDB.cardIDEnum.CFM_806:
                    return new Sim_CFM_806();
 ///case CardDB.cardIDEnum.///CREDITS:
                    ///return new Sim_///CREDITS();
                case CardDB.cardIDEnum.CRED_79:
                    return new Sim_CRED_79();
                case CardDB.cardIDEnum.CRED_102:
                    return new Sim_CRED_102();
                case CardDB.cardIDEnum.CRED_52:
                    return new Sim_CRED_52();
                case CardDB.cardIDEnum.CRED_84:
                    return new Sim_CRED_84();
                case CardDB.cardIDEnum.CRED_15:
                    return new Sim_CRED_15();
                case CardDB.cardIDEnum.CRED_18:
                    return new Sim_CRED_18();
                case CardDB.cardIDEnum.CRED_08:
                    return new Sim_CRED_08();
                case CardDB.cardIDEnum.CRED_09:
                    return new Sim_CRED_09();
                case CardDB.cardIDEnum.CRED_19:
                    return new Sim_CRED_19();
                case CardDB.cardIDEnum.CRED_03:
                    return new Sim_CRED_03();
                case CardDB.cardIDEnum.CRED_59:
                    return new Sim_CRED_59();
                case CardDB.cardIDEnum.CRED_89:
                    return new Sim_CRED_89();
                case CardDB.cardIDEnum.CRED_103:
                    return new Sim_CRED_103();
                case CardDB.cardIDEnum.CRED_20:
                    return new Sim_CRED_20();
                case CardDB.cardIDEnum.CRED_111:
                    return new Sim_CRED_111();
                case CardDB.cardIDEnum.CRED_50:
                    return new Sim_CRED_50();
                case CardDB.cardIDEnum.CRED_13:
                    return new Sim_CRED_13();
                case CardDB.cardIDEnum.CRED_21:
                    return new Sim_CRED_21();
                case CardDB.cardIDEnum.CRED_22:
                    return new Sim_CRED_22();
                case CardDB.cardIDEnum.CRED_53:
                    return new Sim_CRED_53();
                case CardDB.cardIDEnum.CRED_105:
                    return new Sim_CRED_105();
                case CardDB.cardIDEnum.CRED_107:
                    return new Sim_CRED_107();
                case CardDB.cardIDEnum.CRED_61:
                    return new Sim_CRED_61();
                case CardDB.cardIDEnum.CRED_95:
                    return new Sim_CRED_95();
                case CardDB.cardIDEnum.CRED_109:
                    return new Sim_CRED_109();
                case CardDB.cardIDEnum.CRED_69:
                    return new Sim_CRED_69();
                case CardDB.cardIDEnum.CRED_48:
                    return new Sim_CRED_48();
                case CardDB.cardIDEnum.CRED_23:
                    return new Sim_CRED_23();
                case CardDB.cardIDEnum.CRED_47:
                    return new Sim_CRED_47();
                case CardDB.cardIDEnum.CRED_115:
                    return new Sim_CRED_115();
                case CardDB.cardIDEnum.CRED_55:
                    return new Sim_CRED_55();
                case CardDB.cardIDEnum.CRED_73:
                    return new Sim_CRED_73();
                case CardDB.cardIDEnum.CRED_110:
                    return new Sim_CRED_110();
                case CardDB.cardIDEnum.CRED_24:
                    return new Sim_CRED_24();
                case CardDB.cardIDEnum.CRED_80:
                    return new Sim_CRED_80();
                case CardDB.cardIDEnum.CRED_06:
                    return new Sim_CRED_06();
                case CardDB.cardIDEnum.CRED_74:
                    return new Sim_CRED_74();
                case CardDB.cardIDEnum.CRED_56:
                    return new Sim_CRED_56();
                case CardDB.cardIDEnum.CRED_25:
                    return new Sim_CRED_25();
                case CardDB.cardIDEnum.CRED_26:
                    return new Sim_CRED_26();
                case CardDB.cardIDEnum.CRED_02:
                    return new Sim_CRED_02();
                case CardDB.cardIDEnum.CRED_63:
                    return new Sim_CRED_63();
                case CardDB.cardIDEnum.CRED_98:
                    return new Sim_CRED_98();
                case CardDB.cardIDEnum.CRED_54:
                    return new Sim_CRED_54();
                case CardDB.cardIDEnum.CRED_16:
                    return new Sim_CRED_16();
                case CardDB.cardIDEnum.CRED_112:
                    return new Sim_CRED_112();
                case CardDB.cardIDEnum.CRED_27:
                    return new Sim_CRED_27();
                case CardDB.cardIDEnum.CRED_28:
                    return new Sim_CRED_28();
                case CardDB.cardIDEnum.CRED_100:
                    return new Sim_CRED_100();
                case CardDB.cardIDEnum.CRED_82:
                    return new Sim_CRED_82();
                case CardDB.cardIDEnum.CRED_99:
                    return new Sim_CRED_99();
                case CardDB.cardIDEnum.CRED_01:
                    return new Sim_CRED_01();
                case CardDB.cardIDEnum.CRED_66:
                    return new Sim_CRED_66();
                case CardDB.cardIDEnum.CRED_29:
                    return new Sim_CRED_29();
                case CardDB.cardIDEnum.CRED_58:
                    return new Sim_CRED_58();
                case CardDB.cardIDEnum.CRED_11:
                    return new Sim_CRED_11();
                case CardDB.cardIDEnum.CRED_30:
                    return new Sim_CRED_30();
                case CardDB.cardIDEnum.CRED_92:
                    return new Sim_CRED_92();
                case CardDB.cardIDEnum.CRED_31:
                    return new Sim_CRED_31();
                case CardDB.cardIDEnum.CRED_51:
                    return new Sim_CRED_51();
                case CardDB.cardIDEnum.CRED_32:
                    return new Sim_CRED_32();
                case CardDB.cardIDEnum.CRED_93:
                    return new Sim_CRED_93();
                case CardDB.cardIDEnum.CRED_33:
                    return new Sim_CRED_33();
                case CardDB.cardIDEnum.CRED_43:
                    return new Sim_CRED_43();
                case CardDB.cardIDEnum.CRED_45:
                    return new Sim_CRED_45();
                case CardDB.cardIDEnum.CRED_97:
                    return new Sim_CRED_97();
                case CardDB.cardIDEnum.CRED_83:
                    return new Sim_CRED_83();
                case CardDB.cardIDEnum.CRED_116:
                    return new Sim_CRED_116();
                case CardDB.cardIDEnum.CRED_118:
                    return new Sim_CRED_118();
                case CardDB.cardIDEnum.CRED_46:
                    return new Sim_CRED_46();
                case CardDB.cardIDEnum.CRED_94:
                    return new Sim_CRED_94();
                case CardDB.cardIDEnum.CRED_49:
                    return new Sim_CRED_49();
                case CardDB.cardIDEnum.CRED_05:
                    return new Sim_CRED_05();
                case CardDB.cardIDEnum.CRED_90:
                    return new Sim_CRED_90();
                case CardDB.cardIDEnum.CRED_64:
                    return new Sim_CRED_64();
                case CardDB.cardIDEnum.CRED_77:
                    return new Sim_CRED_77();
                case CardDB.cardIDEnum.CRED_108:
                    return new Sim_CRED_108();
                case CardDB.cardIDEnum.CRED_62:
                    return new Sim_CRED_62();
                case CardDB.cardIDEnum.CRED_117:
                    return new Sim_CRED_117();
                case CardDB.cardIDEnum.CRED_65:
                    return new Sim_CRED_65();
                case CardDB.cardIDEnum.CRED_57:
                    return new Sim_CRED_57();
                case CardDB.cardIDEnum.CRED_78:
                    return new Sim_CRED_78();
                case CardDB.cardIDEnum.CRED_34:
                    return new Sim_CRED_34();
                case CardDB.cardIDEnum.CRED_35:
                    return new Sim_CRED_35();
                case CardDB.cardIDEnum.CRED_101:
                    return new Sim_CRED_101();
                case CardDB.cardIDEnum.CRED_60:
                    return new Sim_CRED_60();
                case CardDB.cardIDEnum.CRED_71:
                    return new Sim_CRED_71();
                case CardDB.cardIDEnum.CRED_10:
                    return new Sim_CRED_10();
                case CardDB.cardIDEnum.CRED_67:
                    return new Sim_CRED_67();
                case CardDB.cardIDEnum.CRED_36:
                    return new Sim_CRED_36();
                case CardDB.cardIDEnum.CRED_91:
                    return new Sim_CRED_91();
                case CardDB.cardIDEnum.CRED_70:
                    return new Sim_CRED_70();
                case CardDB.cardIDEnum.CRED_86:
                    return new Sim_CRED_86();
                case CardDB.cardIDEnum.CRED_76:
                    return new Sim_CRED_76();
                case CardDB.cardIDEnum.CRED_85:
                    return new Sim_CRED_85();
                case CardDB.cardIDEnum.CRED_106:
                    return new Sim_CRED_106();
                case CardDB.cardIDEnum.CRED_68:
                    return new Sim_CRED_68();
                case CardDB.cardIDEnum.CRED_12:
                    return new Sim_CRED_12();
                case CardDB.cardIDEnum.CRED_37:
                    return new Sim_CRED_37();
                case CardDB.cardIDEnum.CRED_17:
                    return new Sim_CRED_17();
                case CardDB.cardIDEnum.CRED_38:
                    return new Sim_CRED_38();
                case CardDB.cardIDEnum.CRED_39:
                    return new Sim_CRED_39();
                case CardDB.cardIDEnum.CRED_40:
                    return new Sim_CRED_40();
                case CardDB.cardIDEnum.CRED_41:
                    return new Sim_CRED_41();
                case CardDB.cardIDEnum.CRED_81:
                    return new Sim_CRED_81();
                case CardDB.cardIDEnum.CRED_96:
                    return new Sim_CRED_96();
                case CardDB.cardIDEnum.CRED_72:
                    return new Sim_CRED_72();
                case CardDB.cardIDEnum.CRED_75:
                    return new Sim_CRED_75();
                case CardDB.cardIDEnum.CRED_04:
                    return new Sim_CRED_04();
                case CardDB.cardIDEnum.CRED_87:
                    return new Sim_CRED_87();
                case CardDB.cardIDEnum.CRED_42:
                    return new Sim_CRED_42();
                case CardDB.cardIDEnum.CRED_114:
                    return new Sim_CRED_114();
                case CardDB.cardIDEnum.CRED_44:
                    return new Sim_CRED_44();
                case CardDB.cardIDEnum.CRED_88:
                    return new Sim_CRED_88();
                case CardDB.cardIDEnum.CRED_14:
                    return new Sim_CRED_14();
                case CardDB.cardIDEnum.CRED_113:
                    return new Sim_CRED_113();
                case CardDB.cardIDEnum.CRED_07:
                    return new Sim_CRED_07();
 ///case CardDB.cardIDEnum.///EXPERT1:
                    ///return new Sim_///EXPERT1();
                case CardDB.cardIDEnum.EX1_097:
                    return new Sim_EX1_097();
                case CardDB.cardIDEnum.CS2_188:
                    return new Sim_CS2_188();
                case CardDB.cardIDEnum.EX1_007:
                    return new Sim_EX1_007();
                case CardDB.cardIDEnum.NEW1_010:
                    return new Sim_NEW1_010();
                case CardDB.cardIDEnum.EX1_006:
                    return new Sim_EX1_006();
                case CardDB.cardIDEnum.EX1_382:
                    return new Sim_EX1_382();
                case CardDB.cardIDEnum.EX1_561:
                    return new Sim_EX1_561();
                case CardDB.cardIDEnum.EX1_561e:
                    return new Sim_EX1_561e();
                case CardDB.cardIDEnum.EX1_393:
                    return new Sim_EX1_393();
                case CardDB.cardIDEnum.CS2_038:
                    return new Sim_CS2_038();
                case CardDB.cardIDEnum.CS2_038e:
                    return new Sim_CS2_038e();
                case CardDB.cardIDEnum.EX1_057:
                    return new Sim_EX1_057();
                case CardDB.cardIDEnum.EX1_584:
                    return new Sim_EX1_584();
                case CardDB.cardIDEnum.NEW1_008:
                    return new Sim_NEW1_008();
                case CardDB.cardIDEnum.EX1_178:
                    return new Sim_EX1_178();
                case CardDB.cardIDEnum.NEW1_008b:
                    return new Sim_NEW1_008b();
                case CardDB.cardIDEnum.NEW1_008a:
                    return new Sim_NEW1_008a();
                case CardDB.cardIDEnum.EX1_045:
                    return new Sim_EX1_045();
                case CardDB.cardIDEnum.EX1_009:
                    return new Sim_EX1_009();
                case CardDB.cardIDEnum.EX1_608e:
                    return new Sim_EX1_608e();
                case CardDB.cardIDEnum.EX1_398:
                    return new Sim_EX1_398();
                case CardDB.cardIDEnum.EX1_187:
                    return new Sim_EX1_187();
                case CardDB.cardIDEnum.EX1_089:
                    return new Sim_EX1_089();
                case CardDB.cardIDEnum.EX1_187e:
                    return new Sim_EX1_187e();
                case CardDB.cardIDEnum.EX1_559:
                    return new Sim_EX1_559();
                case CardDB.cardIDEnum.EX1_067:
                    return new Sim_EX1_067();
                case CardDB.cardIDEnum.EX1_362:
                    return new Sim_EX1_362();
                case CardDB.cardIDEnum.EX1_008:
                    return new Sim_EX1_008();
                case CardDB.cardIDEnum.EX1_402:
                    return new Sim_EX1_402();
                case CardDB.cardIDEnum.EX1_383t:
                    return new Sim_EX1_383t();
                case CardDB.cardIDEnum.EX1_591:
                    return new Sim_EX1_591();
                case CardDB.cardIDEnum.EX1_384:
                    return new Sim_EX1_384();
                case CardDB.cardIDEnum.EX1_110t:
                    return new Sim_EX1_110t();
                case CardDB.cardIDEnum.EX1_014t:
                    return new Sim_EX1_014t();
                case CardDB.cardIDEnum.EX1_014te:
                    return new Sim_EX1_014te();
                case CardDB.cardIDEnum.EX1_320:
                    return new Sim_EX1_320();
                case CardDB.cardIDEnum.EX1_249:
                    return new Sim_EX1_249();
                case CardDB.cardIDEnum.EX1_188:
                    return new Sim_EX1_188();
                case CardDB.cardIDEnum.EX1_398t:
                    return new Sim_EX1_398t();
                case CardDB.cardIDEnum.EX1_392:
                    return new Sim_EX1_392();
                case CardDB.cardIDEnum.EX1_165b:
                    return new Sim_EX1_165b();
                case CardDB.cardIDEnum.EX1_604o:
                    return new Sim_EX1_604o();
                case CardDB.cardIDEnum.EX1_549:
                    return new Sim_EX1_549();
                case CardDB.cardIDEnum.EX1_549o:
                    return new Sim_EX1_549o();
                case CardDB.cardIDEnum.EX1_126:
                    return new Sim_EX1_126();
                case CardDB.cardIDEnum.EX1_005:
                    return new Sim_EX1_005();
                case CardDB.cardIDEnum.EX1_570:
                    return new Sim_EX1_570();
                case CardDB.cardIDEnum.EX1_570e:
                    return new Sim_EX1_570e();
                case CardDB.cardIDEnum.CS2_233:
                    return new Sim_CS2_233();
                case CardDB.cardIDEnum.EX1_509e:
                    return new Sim_EX1_509e();
                case CardDB.cardIDEnum.EX1_355:
                    return new Sim_EX1_355();
                case CardDB.cardIDEnum.EX1_355e:
                    return new Sim_EX1_355e();
                case CardDB.cardIDEnum.EX1_363:
                    return new Sim_EX1_363();
                case CardDB.cardIDEnum.EX1_363e:
                    return new Sim_EX1_363e();
                case CardDB.cardIDEnum.EX1_363e2:
                    return new Sim_EX1_363e2();
                case CardDB.cardIDEnum.CS2_028:
                    return new Sim_CS2_028();
                case CardDB.cardIDEnum.EX1_323w:
                    return new Sim_EX1_323w();
                case CardDB.cardIDEnum.CS2_059:
                    return new Sim_CS2_059();
                case CardDB.cardIDEnum.EX1_590:
                    return new Sim_EX1_590();
                case CardDB.cardIDEnum.CS2_059o:
                    return new Sim_CS2_059o();
                case CardDB.cardIDEnum.EX1_012:
                    return new Sim_EX1_012();
                case CardDB.cardIDEnum.EX1_411e:
                    return new Sim_EX1_411e();
                case CardDB.cardIDEnum.NEW1_025:
                    return new Sim_NEW1_025();
                case CardDB.cardIDEnum.NEW1_018:
                    return new Sim_NEW1_018();
                case CardDB.cardIDEnum.NEW1_025e:
                    return new Sim_NEW1_025e();
                case CardDB.cardIDEnum.EX1_407:
                    return new Sim_EX1_407();
                case CardDB.cardIDEnum.EX1_189:
                    return new Sim_EX1_189();
                case CardDB.cardIDEnum.EX1_091:
                    return new Sim_EX1_091();
                case CardDB.cardIDEnum.EX1_110:
                    return new Sim_EX1_110();
                case CardDB.cardIDEnum.EX1_181:
                    return new Sim_EX1_181();
                case CardDB.cardIDEnum.tt_004o:
                    return new Sim_tt_004o();
                case CardDB.cardIDEnum.NEW1_024:
                    return new Sim_NEW1_024();
                case CardDB.cardIDEnum.EX1_165a:
                    return new Sim_EX1_165a();
                case CardDB.cardIDEnum.EX1_573:
                    return new Sim_EX1_573();
                case CardDB.cardIDEnum.EX1_621:
                    return new Sim_EX1_621();
                case CardDB.cardIDEnum.CS2_073:
                    return new Sim_CS2_073();
                case CardDB.cardIDEnum.CS2_073e:
                    return new Sim_CS2_073e();
                case CardDB.cardIDEnum.CS2_073e2:
                    return new Sim_CS2_073e2();
                case CardDB.cardIDEnum.EX1_103:
                    return new Sim_EX1_103();
                case CardDB.cardIDEnum.NEW1_036:
                    return new Sim_NEW1_036();
                case CardDB.cardIDEnum.NEW1_036e:
                    return new Sim_NEW1_036e();
                case CardDB.cardIDEnum.NEW1_036e2:
                    return new Sim_NEW1_036e2();
                case CardDB.cardIDEnum.EX1_275:
                    return new Sim_EX1_275();
                case CardDB.cardIDEnum.EX1_304e:
                    return new Sim_EX1_304e();
                case CardDB.cardIDEnum.EX1_287:
                    return new Sim_EX1_287();
                case CardDB.cardIDEnum.EX1_287t:
                    return new Sim_EX1_287t();
                case CardDB.cardIDEnum.EX1_059:
                    return new Sim_EX1_059();
                case CardDB.cardIDEnum.EX1_603:
                    return new Sim_EX1_603();
                case CardDB.cardIDEnum.EX1_595:
                    return new Sim_EX1_595();
                case CardDB.cardIDEnum.skele21:
                    return new Sim_skele21();
                case CardDB.cardIDEnum.EX1_046:
                    return new Sim_EX1_046();
                case CardDB.cardIDEnum.EX1_617:
                    return new Sim_EX1_617();
                case CardDB.cardIDEnum.NEW1_030:
                    return new Sim_NEW1_030();
                case CardDB.cardIDEnum.EX1_130a:
                    return new Sim_EX1_130a();
                case CardDB.cardIDEnum.EX1_093:
                    return new Sim_EX1_093();
                case CardDB.cardIDEnum.EX1_131t:
                    return new Sim_EX1_131t();
                case CardDB.cardIDEnum.EX1_131:
                    return new Sim_EX1_131();
                case CardDB.cardIDEnum.EX1_573a:
                    return new Sim_EX1_573a();
                case CardDB.cardIDEnum.EX1_573ae:
                    return new Sim_EX1_573ae();
                case CardDB.cardIDEnum.EX1_102:
                    return new Sim_EX1_102();
                case CardDB.cardIDEnum.EX1_596:
                    return new Sim_EX1_596();
                case CardDB.cardIDEnum.EX1_596e:
                    return new Sim_EX1_596e();
                case CardDB.cardIDEnum.EX1_tk29:
                    return new Sim_EX1_tk29();
                case CardDB.cardIDEnum.EX1_162:
                    return new Sim_EX1_162();
                case CardDB.cardIDEnum.NEW1_014e:
                    return new Sim_NEW1_014e();
                case CardDB.cardIDEnum.EX1_166b:
                    return new Sim_EX1_166b();
                case CardDB.cardIDEnum.EX1_567:
                    return new Sim_EX1_567();
                case CardDB.cardIDEnum.NEW1_021:
                    return new Sim_NEW1_021();
                case CardDB.cardIDEnum.NEW1_022:
                    return new Sim_NEW1_022();
                case CardDB.cardIDEnum.DREAM_04:
                    return new Sim_DREAM_04();
                case CardDB.cardIDEnum.EX1_165:
                    return new Sim_EX1_165();
                case CardDB.cardIDEnum.EX1_165t1:
                    return new Sim_EX1_165t1();
                case CardDB.cardIDEnum.EX1_165t2:
                    return new Sim_EX1_165t2();
                case CardDB.cardIDEnum.OG_044a:
                    return new Sim_OG_044a();
                case CardDB.cardIDEnum.EX1_243:
                    return new Sim_EX1_243();
                case CardDB.cardIDEnum.EX1_536:
                    return new Sim_EX1_536();
                case CardDB.cardIDEnum.EX1_250:
                    return new Sim_EX1_250();
                case CardDB.cardIDEnum.EX1_245:
                    return new Sim_EX1_245();
                case CardDB.cardIDEnum.CS2_117:
                    return new Sim_CS2_117();
                case CardDB.cardIDEnum.EX1_613:
                    return new Sim_EX1_613();
                case CardDB.cardIDEnum.EX1_004e:
                    return new Sim_EX1_004e();
                case CardDB.cardIDEnum.DREAM_03:
                    return new Sim_DREAM_03();
                case CardDB.cardIDEnum.EX1_170:
                    return new Sim_EX1_170();
                case CardDB.cardIDEnum.EX1_055o:
                    return new Sim_EX1_055o();
                case CardDB.cardIDEnum.KARA_08_04e:
                    return new Sim_KARA_08_04e();
                case CardDB.cardIDEnum.EX1_009e:
                    return new Sim_EX1_009e();
                case CardDB.cardIDEnum.EX1_390e:
                    return new Sim_EX1_390e();
                case CardDB.cardIDEnum.EX1_393e:
                    return new Sim_EX1_393e();
                case CardDB.cardIDEnum.EX1_412e:
                    return new Sim_EX1_412e();
                case CardDB.cardIDEnum.EX1_414e:
                    return new Sim_EX1_414e();
                case CardDB.cardIDEnum.EX1_164b:
                    return new Sim_EX1_164b();
                case CardDB.cardIDEnum.EX1_619:
                    return new Sim_EX1_619();
                case CardDB.cardIDEnum.EX1_619e:
                    return new Sim_EX1_619e();
                case CardDB.cardIDEnum.NEW1_037e:
                    return new Sim_NEW1_037e();
                case CardDB.cardIDEnum.EX1_274:
                    return new Sim_EX1_274();
                case CardDB.cardIDEnum.EX1_124:
                    return new Sim_EX1_124();
                case CardDB.cardIDEnum.EX1_059e:
                    return new Sim_EX1_059e();
                case CardDB.cardIDEnum.EX1_537:
                    return new Sim_EX1_537();
                case CardDB.cardIDEnum.EX1_610:
                    return new Sim_EX1_610();
                case CardDB.cardIDEnum.EX1_132:
                    return new Sim_EX1_132();
                case CardDB.cardIDEnum.EX1_564:
                    return new Sim_EX1_564();
                case CardDB.cardIDEnum.NEW1_023:
                    return new Sim_NEW1_023();
                case CardDB.cardIDEnum.CS2_053:
                    return new Sim_CS2_053();
                case CardDB.cardIDEnum.CS2_053e:
                    return new Sim_CS2_053e();
                case CardDB.cardIDEnum.EX1_301:
                    return new Sim_EX1_301();
                case CardDB.cardIDEnum.CS1_069:
                    return new Sim_CS1_069();
                case CardDB.cardIDEnum.EX1_248:
                    return new Sim_EX1_248();
                case CardDB.cardIDEnum.EX1_finkle:
                    return new Sim_EX1_finkle();
                case CardDB.cardIDEnum.EX1_319:
                    return new Sim_EX1_319();
                case CardDB.cardIDEnum.EX1_614t:
                    return new Sim_EX1_614t();
                case CardDB.cardIDEnum.EX1_544:
                    return new Sim_EX1_544();
                case CardDB.cardIDEnum.tt_004:
                    return new Sim_tt_004();
                case CardDB.cardIDEnum.EX1_571:
                    return new Sim_EX1_571();
                case CardDB.cardIDEnum.EX1_251:
                    return new Sim_EX1_251();
                case CardDB.cardIDEnum.EX1_611:
                    return new Sim_EX1_611();
                case CardDB.cardIDEnum.EX1_283:
                    return new Sim_EX1_283();
                case CardDB.cardIDEnum.EX1_604:
                    return new Sim_EX1_604();
                case CardDB.cardIDEnum.NEW1_017e:
                    return new Sim_NEW1_017e();
                case CardDB.cardIDEnum.CS2_181e:
                    return new Sim_CS2_181e();
                case CardDB.cardIDEnum.EX1_095:
                    return new Sim_EX1_095();
                case CardDB.cardIDEnum.EX1_183:
                    return new Sim_EX1_183();
                case CardDB.cardIDEnum.EX1_183e:
                    return new Sim_EX1_183e();
                case CardDB.cardIDEnum.DS1_188:
                    return new Sim_DS1_188();
                case CardDB.cardIDEnum.DS1_188e:
                    return new Sim_DS1_188e();
                case CardDB.cardIDEnum.NEW1_040t:
                    return new Sim_NEW1_040t();
                case CardDB.cardIDEnum.EX1_411:
                    return new Sim_EX1_411();
                case CardDB.cardIDEnum.NEW1_024o:
                    return new Sim_NEW1_024o();
                case CardDB.cardIDEnum.EX1_414:
                    return new Sim_EX1_414();
                case CardDB.cardIDEnum.NEW1_038o:
                    return new Sim_NEW1_038o();
                case CardDB.cardIDEnum.NEW1_038:
                    return new Sim_NEW1_038();
                case CardDB.cardIDEnum.EX1_093e:
                    return new Sim_EX1_093e();
                case CardDB.cardIDEnum.EX1_558:
                    return new Sim_EX1_558();
                case CardDB.cardIDEnum.EX1_556:
                    return new Sim_EX1_556();
                case CardDB.cardIDEnum.EX1_137:
                    return new Sim_EX1_137();
                case CardDB.cardIDEnum.EX1_409t:
                    return new Sim_EX1_409t();
                case CardDB.cardIDEnum.EX1_190:
                    return new Sim_EX1_190();
                case CardDB.cardIDEnum.NEW1_040:
                    return new Sim_NEW1_040();
                case CardDB.cardIDEnum.EX1_624:
                    return new Sim_EX1_624();
                case CardDB.cardIDEnum.EX1_365:
                    return new Sim_EX1_365();
                case CardDB.cardIDEnum.EX1_538t:
                    return new Sim_EX1_538t();
                case CardDB.cardIDEnum.EX1_043e:
                    return new Sim_EX1_043e();
                case CardDB.cardIDEnum.NEW1_017:
                    return new Sim_NEW1_017();
                case CardDB.cardIDEnum.EX1_534t:
                    return new Sim_EX1_534t();
                case CardDB.cardIDEnum.EX1_289:
                    return new Sim_EX1_289();
                case CardDB.cardIDEnum.EX1_179:
                    return new Sim_EX1_179();
                case CardDB.cardIDEnum.EX1_614:
                    return new Sim_EX1_614();
                case CardDB.cardIDEnum.EX1_598:
                    return new Sim_EX1_598();
                case CardDB.cardIDEnum.EX1_597:
                    return new Sim_EX1_597();
                case CardDB.cardIDEnum.EX1_tk34:
                    return new Sim_EX1_tk34();
                case CardDB.cardIDEnum.EX1_tk33:
                    return new Sim_EX1_tk33();
                case CardDB.cardIDEnum.EX1_623e:
                    return new Sim_EX1_623e();
                case CardDB.cardIDEnum.CS2_181:
                    return new Sim_CS2_181();
                case CardDB.cardIDEnum.CS1_129:
                    return new Sim_CS1_129();
                case CardDB.cardIDEnum.CS1_129e:
                    return new Sim_CS1_129e();
                case CardDB.cardIDEnum.EX1_607:
                    return new Sim_EX1_607();
                case CardDB.cardIDEnum.EX1_607e:
                    return new Sim_EX1_607e();
                case CardDB.cardIDEnum.CS2_188o:
                    return new Sim_CS2_188o();
                case CardDB.cardIDEnum.CS2_203:
                    return new Sim_CS2_203();
                case CardDB.cardIDEnum.EX1_017:
                    return new Sim_EX1_017();
                case CardDB.cardIDEnum.EX1_366e:
                    return new Sim_EX1_366e();
                case CardDB.cardIDEnum.EX1_166:
                    return new Sim_EX1_166();
                case CardDB.cardIDEnum.EX1_080o:
                    return new Sim_EX1_080o();
                case CardDB.cardIDEnum.NEW1_005:
                    return new Sim_NEW1_005();
                case CardDB.cardIDEnum.NEW1_029t:
                    return new Sim_NEW1_029t();
                case CardDB.cardIDEnum.EX1_543:
                    return new Sim_EX1_543();
                case CardDB.cardIDEnum.EX1_014:
                    return new Sim_EX1_014();
                case CardDB.cardIDEnum.EX1_612:
                    return new Sim_EX1_612();
                case CardDB.cardIDEnum.NEW1_019:
                    return new Sim_NEW1_019();
                case CardDB.cardIDEnum.DREAM_01:
                    return new Sim_DREAM_01();
                case CardDB.cardIDEnum.EX1_241:
                    return new Sim_EX1_241();
                case CardDB.cardIDEnum.EX1_354:
                    return new Sim_EX1_354();
                case CardDB.cardIDEnum.EX1_160b:
                    return new Sim_EX1_160b();
                case CardDB.cardIDEnum.EX1_160be:
                    return new Sim_EX1_160be();
                case CardDB.cardIDEnum.EX1_116:
                    return new Sim_EX1_116();
                case CardDB.cardIDEnum.EX1_029:
                    return new Sim_EX1_029();
                case CardDB.cardIDEnum.EX1_044e:
                    return new Sim_EX1_044e();
                case CardDB.cardIDEnum.EX1_238:
                    return new Sim_EX1_238();
                case CardDB.cardIDEnum.EX1_259:
                    return new Sim_EX1_259();
                case CardDB.cardIDEnum.EX1_335:
                    return new Sim_EX1_335();
                case CardDB.cardIDEnum.EX1_001:
                    return new Sim_EX1_001();
                case CardDB.cardIDEnum.EX1_341:
                    return new Sim_EX1_341();
                case CardDB.cardIDEnum.EX1_096:
                    return new Sim_EX1_096();
                case CardDB.cardIDEnum.EX1_323:
                    return new Sim_EX1_323();
                case CardDB.cardIDEnum.EX1_323h:
                    return new Sim_EX1_323h();
                case CardDB.cardIDEnum.EX1_100:
                    return new Sim_EX1_100();
                case CardDB.cardIDEnum.EX1_082:
                    return new Sim_EX1_082();
                case CardDB.cardIDEnum.EX1_563:
                    return new Sim_EX1_563();
                case CardDB.cardIDEnum.EX1_055:
                    return new Sim_EX1_055();
                case CardDB.cardIDEnum.EX1_616e:
                    return new Sim_EX1_616e();
                case CardDB.cardIDEnum.NEW1_012o:
                    return new Sim_NEW1_012o();
                case CardDB.cardIDEnum.EX1_575:
                    return new Sim_EX1_575();
                case CardDB.cardIDEnum.EX1_616:
                    return new Sim_EX1_616();
                case CardDB.cardIDEnum.NEW1_012:
                    return new Sim_NEW1_012();
                case CardDB.cardIDEnum.EX1_155:
                    return new Sim_EX1_155();
                case CardDB.cardIDEnum.EX1_155ae:
                    return new Sim_EX1_155ae();
                case CardDB.cardIDEnum.EX1_155be:
                    return new Sim_EX1_155be();
                case CardDB.cardIDEnum.EX1_626:
                    return new Sim_EX1_626();
                case CardDB.cardIDEnum.NEW1_014:
                    return new Sim_NEW1_014();
                case CardDB.cardIDEnum.NEW1_037:
                    return new Sim_NEW1_037();
                case CardDB.cardIDEnum.CS2_227e:
                    return new Sim_CS2_227e();
                case CardDB.cardIDEnum.NEW1_029:
                    return new Sim_NEW1_029();
                case CardDB.cardIDEnum.EX1_085:
                    return new Sim_EX1_085();
                case CardDB.cardIDEnum.EX1_tk31:
                    return new Sim_EX1_tk31();
                case CardDB.cardIDEnum.EX1_625t2:
                    return new Sim_EX1_625t2();
                case CardDB.cardIDEnum.EX1_625t:
                    return new Sim_EX1_625t();
                case CardDB.cardIDEnum.EX1_345:
                    return new Sim_EX1_345();
                case CardDB.cardIDEnum.EX1_294:
                    return new Sim_EX1_294();
                case CardDB.cardIDEnum.EX1_533:
                    return new Sim_EX1_533();
                case CardDB.cardIDEnum.EX1_396:
                    return new Sim_EX1_396();
                case CardDB.cardIDEnum.EX1_166a:
                    return new Sim_EX1_166a();
                case CardDB.cardIDEnum.EX1_408:
                    return new Sim_EX1_408();
                case CardDB.cardIDEnum.EX1_105:
                    return new Sim_EX1_105();
                case CardDB.cardIDEnum.EX1_103e:
                    return new Sim_EX1_103e();
                case CardDB.cardIDEnum.EX1_509:
                    return new Sim_EX1_509();
                case CardDB.cardIDEnum.EX1_507:
                    return new Sim_EX1_507();
                case CardDB.cardIDEnum.EX1_557:
                    return new Sim_EX1_557();
                case CardDB.cardIDEnum.EX1_154b:
                    return new Sim_EX1_154b();
                case CardDB.cardIDEnum.EX1_411e2:
                    return new Sim_EX1_411e2();
                case CardDB.cardIDEnum.DREAM_05:
                    return new Sim_DREAM_05();
                case CardDB.cardIDEnum.DREAM_05e:
                    return new Sim_DREAM_05e();
                case CardDB.cardIDEnum.EX1_130:
                    return new Sim_EX1_130();
                case CardDB.cardIDEnum.EX1_164:
                    return new Sim_EX1_164();
                case CardDB.cardIDEnum.EX1_560:
                    return new Sim_EX1_560();
                case CardDB.cardIDEnum.EX1_562:
                    return new Sim_EX1_562();
                case CardDB.cardIDEnum.EX1_258e:
                    return new Sim_EX1_258e();
                case CardDB.cardIDEnum.EX1_160t:
                    return new Sim_EX1_160t();
                case CardDB.cardIDEnum.EX1_522:
                    return new Sim_EX1_522();
                case CardDB.cardIDEnum.EX1_133:
                    return new Sim_EX1_133();
                case CardDB.cardIDEnum.EX1_182:
                    return new Sim_EX1_182();
                case CardDB.cardIDEnum.EX1_076e:
                    return new Sim_EX1_076e();
                case CardDB.cardIDEnum.EX1_076:
                    return new Sim_EX1_076();
                case CardDB.cardIDEnum.EX1_313:
                    return new Sim_EX1_313();
                case CardDB.cardIDEnum.EX1_315e:
                    return new Sim_EX1_315e();
                case CardDB.cardIDEnum.EX1_612o:
                    return new Sim_EX1_612o();
                case CardDB.cardIDEnum.EX1_160:
                    return new Sim_EX1_160();
                case CardDB.cardIDEnum.EX1_145:
                    return new Sim_EX1_145();
                case CardDB.cardIDEnum.EX1_145e:
                    return new Sim_EX1_145e();
                case CardDB.cardIDEnum.EX1_145o:
                    return new Sim_EX1_145o();
                case CardDB.cardIDEnum.EX1_583:
                    return new Sim_EX1_583();
                case CardDB.cardIDEnum.EX1_350:
                    return new Sim_EX1_350();
                case CardDB.cardIDEnum.EX1_279:
                    return new Sim_EX1_279();
                case CardDB.cardIDEnum.EX1_044:
                    return new Sim_EX1_044();
                case CardDB.cardIDEnum.EX1_412:
                    return new Sim_EX1_412();
                case CardDB.cardIDEnum.CS2_104:
                    return new Sim_CS2_104();
                case CardDB.cardIDEnum.CS2_104e:
                    return new Sim_CS2_104e();
                case CardDB.cardIDEnum.EX1_164a:
                    return new Sim_EX1_164a();
                case CardDB.cardIDEnum.CS2_161:
                    return new Sim_CS2_161();
                case CardDB.cardIDEnum.EX1_274e:
                    return new Sim_EX1_274e();
                case CardDB.cardIDEnum.EX1_136:
                    return new Sim_EX1_136();
                case CardDB.cardIDEnum.EX1_379:
                    return new Sim_EX1_379();
                case CardDB.cardIDEnum.EX1_379e:
                    return new Sim_EX1_379e();
                case CardDB.cardIDEnum.EX1_184:
                    return new Sim_EX1_184();
                case CardDB.cardIDEnum.EX1_178a:
                    return new Sim_EX1_178a();
                case CardDB.cardIDEnum.EX1_178ae:
                    return new Sim_EX1_178ae();
                case CardDB.cardIDEnum.EX1_578:
                    return new Sim_EX1_578();
                case CardDB.cardIDEnum.EX1_534:
                    return new Sim_EX1_534();
                case CardDB.cardIDEnum.EX1_020:
                    return new Sim_EX1_020();
                case CardDB.cardIDEnum.EX1_531:
                    return new Sim_EX1_531();
                case CardDB.cardIDEnum.EX1_586:
                    return new Sim_EX1_586();
                case CardDB.cardIDEnum.EX1_080:
                    return new Sim_EX1_080();
                case CardDB.cardIDEnum.EX1_317:
                    return new Sim_EX1_317();
                case CardDB.cardIDEnum.EX1_334:
                    return new Sim_EX1_334();
                case CardDB.cardIDEnum.EX1_334e:
                    return new Sim_EX1_334e();
                case CardDB.cardIDEnum.EX1_345t:
                    return new Sim_EX1_345t();
                case CardDB.cardIDEnum.EX1_303:
                    return new Sim_EX1_303();
                case CardDB.cardIDEnum.EX1_625:
                    return new Sim_EX1_625();
                case CardDB.cardIDEnum.EX1_590e:
                    return new Sim_EX1_590e();
                case CardDB.cardIDEnum.EX1_144:
                    return new Sim_EX1_144();
                case CardDB.cardIDEnum.EX1_573b:
                    return new Sim_EX1_573b();
                case CardDB.cardIDEnum.CS2_221e:
                    return new Sim_CS2_221e();
                case CardDB.cardIDEnum.EX1_410:
                    return new Sim_EX1_410();
                case CardDB.cardIDEnum.EX1_405:
                    return new Sim_EX1_405();
                case CardDB.cardIDEnum.EX1_134:
                    return new Sim_EX1_134();
                case CardDB.cardIDEnum.EX1_186:
                    return new Sim_EX1_186();
                case CardDB.cardIDEnum.EX1_185:
                    return new Sim_EX1_185();
                case CardDB.cardIDEnum.EX1_185e:
                    return new Sim_EX1_185e();
                case CardDB.cardIDEnum.EX1_332:
                    return new Sim_EX1_332();
                case CardDB.cardIDEnum.CS2_151:
                    return new Sim_CS2_151();
                case CardDB.cardIDEnum.EX1_023:
                    return new Sim_EX1_023();
                case CardDB.cardIDEnum.EX1_309:
                    return new Sim_EX1_309();
                case CardDB.cardIDEnum.EX1_391:
                    return new Sim_EX1_391();
                case CardDB.cardIDEnum.EX1_554t:
                    return new Sim_EX1_554t();
                case CardDB.cardIDEnum.EX1_554:
                    return new Sim_EX1_554();
                case CardDB.cardIDEnum.EX1_609:
                    return new Sim_EX1_609();
                case CardDB.cardIDEnum.EX1_154a:
                    return new Sim_EX1_154a();
                case CardDB.cardIDEnum.EX1_608:
                    return new Sim_EX1_608();
                case CardDB.cardIDEnum.EX1_158:
                    return new Sim_EX1_158();
                case CardDB.cardIDEnum.EX1_158e:
                    return new Sim_EX1_158e();
                case CardDB.cardIDEnum.EX1_591e:
                    return new Sim_EX1_591e();
                case CardDB.cardIDEnum.NEW1_027:
                    return new Sim_NEW1_027();
                case CardDB.cardIDEnum.CS2_146:
                    return new Sim_CS2_146();
                case CardDB.cardIDEnum.tt_010:
                    return new Sim_tt_010();
                case CardDB.cardIDEnum.tt_010a:
                    return new Sim_tt_010a();
                case CardDB.cardIDEnum.EX1_048:
                    return new Sim_EX1_048();
                case CardDB.cardIDEnum.EX1_tk11:
                    return new Sim_EX1_tk11();
                case CardDB.cardIDEnum.CS2_221:
                    return new Sim_CS2_221();
                case CardDB.cardIDEnum.CS2_152:
                    return new Sim_CS2_152();
                case CardDB.cardIDEnum.EX1_tk28:
                    return new Sim_EX1_tk28();
                case CardDB.cardIDEnum.NEW1_041:
                    return new Sim_NEW1_041();
                case CardDB.cardIDEnum.EX1_382e:
                    return new Sim_EX1_382e();
                case CardDB.cardIDEnum.NEW1_007:
                    return new Sim_NEW1_007();
                case CardDB.cardIDEnum.NEW1_007b:
                    return new Sim_NEW1_007b();
                case CardDB.cardIDEnum.NEW1_007a:
                    return new Sim_NEW1_007a();
                case CardDB.cardIDEnum.EX1_247:
                    return new Sim_EX1_247();
                case CardDB.cardIDEnum.EX1_028:
                    return new Sim_EX1_028();
                case CardDB.cardIDEnum.EX1_162o:
                    return new Sim_EX1_162o();
                case CardDB.cardIDEnum.EX1_160a:
                    return new Sim_EX1_160a();
                case CardDB.cardIDEnum.EX1_315:
                    return new Sim_EX1_315();
                case CardDB.cardIDEnum.EX1_058:
                    return new Sim_EX1_058();
                case CardDB.cardIDEnum.EX1_032:
                    return new Sim_EX1_032();
                case CardDB.cardIDEnum.EX1_366:
                    return new Sim_EX1_366();
                case CardDB.cardIDEnum.EX1_390:
                    return new Sim_EX1_390();
                case CardDB.cardIDEnum.EX1_584e:
                    return new Sim_EX1_584e();
                case CardDB.cardIDEnum.EX1_046e:
                    return new Sim_EX1_046e();
                case CardDB.cardIDEnum.EX1_623:
                    return new Sim_EX1_623();
                case CardDB.cardIDEnum.EX1_577:
                    return new Sim_EX1_577();
                case CardDB.cardIDEnum.EX1_002:
                    return new Sim_EX1_002();
                case CardDB.cardIDEnum.EX1_155b:
                    return new Sim_EX1_155b();
                case CardDB.cardIDEnum.EX1_339:
                    return new Sim_EX1_339();
                case CardDB.cardIDEnum.EX1_021:
                    return new Sim_EX1_021();
                case CardDB.cardIDEnum.EX1_155a:
                    return new Sim_EX1_155a();
                case CardDB.cardIDEnum.EX1_083:
                    return new Sim_EX1_083();
                case CardDB.cardIDEnum.EX1_383:
                    return new Sim_EX1_383();
                case CardDB.cardIDEnum.EX1_180:
                    return new Sim_EX1_180();
                case CardDB.cardIDEnum.EX1_611e:
                    return new Sim_EX1_611e();
                case CardDB.cardIDEnum.EX1_158t:
                    return new Sim_EX1_158t();
                case CardDB.cardIDEnum.EX1_573t:
                    return new Sim_EX1_573t();
                case CardDB.cardIDEnum.EX1_tk9:
                    return new Sim_EX1_tk9();
                case CardDB.cardIDEnum.NEW1_018e:
                    return new Sim_NEW1_018e();
                case CardDB.cardIDEnum.EX1_043:
                    return new Sim_EX1_043();
                case CardDB.cardIDEnum.EX1_312:
                    return new Sim_EX1_312();
                case CardDB.cardIDEnum.EX1_258:
                    return new Sim_EX1_258();
                case CardDB.cardIDEnum.EX1_538:
                    return new Sim_EX1_538();
                case CardDB.cardIDEnum.EX1_409:
                    return new Sim_EX1_409();
                case CardDB.cardIDEnum.EX1_409e:
                    return new Sim_EX1_409e();
                case CardDB.cardIDEnum.EX1_536e:
                    return new Sim_EX1_536e();
                case CardDB.cardIDEnum.EX1_178b:
                    return new Sim_EX1_178b();
                case CardDB.cardIDEnum.EX1_178be:
                    return new Sim_EX1_178be();
                case CardDB.cardIDEnum.EX1_613e:
                    return new Sim_EX1_613e();
                case CardDB.cardIDEnum.EX1_594:
                    return new Sim_EX1_594();
                case CardDB.cardIDEnum.CS2_227:
                    return new Sim_CS2_227();
                case CardDB.cardIDEnum.NEW1_026t:
                    return new Sim_NEW1_026t();
                case CardDB.cardIDEnum.NEW1_026:
                    return new Sim_NEW1_026();
                case CardDB.cardIDEnum.EX1_304:
                    return new Sim_EX1_304();
                case CardDB.cardIDEnum.EX1_001e:
                    return new Sim_EX1_001e();
                case CardDB.cardIDEnum.EX1_531e:
                    return new Sim_EX1_531e();
                case CardDB.cardIDEnum.ds1_whelptoken:
                    return new Sim_ds1_whelptoken();
                case CardDB.cardIDEnum.EX1_116t:
                    return new Sim_EX1_116t();
                case CardDB.cardIDEnum.EX1_603e:
                    return new Sim_EX1_603e();
                case CardDB.cardIDEnum.NEW1_020:
                    return new Sim_NEW1_020();
                case CardDB.cardIDEnum.EX1_033:
                    return new Sim_EX1_033();
                case CardDB.cardIDEnum.CS2_231:
                    return new Sim_CS2_231();
                case CardDB.cardIDEnum.EX1_010:
                    return new Sim_EX1_010();
                case CardDB.cardIDEnum.EX1_317t:
                    return new Sim_EX1_317t();
                case CardDB.cardIDEnum.EX1_154:
                    return new Sim_EX1_154();
                case CardDB.cardIDEnum.CS2_169:
                    return new Sim_CS2_169();
                case CardDB.cardIDEnum.EX1_004:
                    return new Sim_EX1_004();
                case CardDB.cardIDEnum.EX1_049:
                    return new Sim_EX1_049();
                case CardDB.cardIDEnum.EX1_572:
                    return new Sim_EX1_572();
                case CardDB.cardIDEnum.DREAM_02:
                    return new Sim_DREAM_02();
 ///case CardDB.cardIDEnum.///HOF:
                    ///return new Sim_///HOF();
                case CardDB.cardIDEnum.EX1_284:
                    return new Sim_EX1_284();
                case CardDB.cardIDEnum.GIL_826:
                    return new Sim_GIL_826();
                case CardDB.cardIDEnum.GIL_838:
                    return new Sim_GIL_838();
                case CardDB.cardIDEnum.NEW1_016:
                    return new Sim_NEW1_016();
                case CardDB.cardIDEnum.Mekka4t:
                    return new Sim_Mekka4t();
                case CardDB.cardIDEnum.EX1_050:
                    return new Sim_EX1_050();
                case CardDB.cardIDEnum.EX1_128:
                    return new Sim_EX1_128();
                case CardDB.cardIDEnum.EX1_128e:
                    return new Sim_EX1_128e();
                case CardDB.cardIDEnum.EX1_349:
                    return new Sim_EX1_349();
                case CardDB.cardIDEnum.EX1_310:
                    return new Sim_EX1_310();
                case CardDB.cardIDEnum.PRO_001:
                    return new Sim_PRO_001();
                case CardDB.cardIDEnum.Mekka3e:
                    return new Sim_Mekka3e();
                case CardDB.cardIDEnum.Mekka3:
                    return new Sim_Mekka3();
                case CardDB.cardIDEnum.EX1_112:
                    return new Sim_EX1_112();
                case CardDB.cardIDEnum.GIL_692:
                    return new Sim_GIL_692();
                case CardDB.cardIDEnum.GIL_837:
                    return new Sim_GIL_837();
                case CardDB.cardIDEnum.GIL_130:
                    return new Sim_GIL_130();
                case CardDB.cardIDEnum.Mekka1:
                    return new Sim_Mekka1();
                case CardDB.cardIDEnum.PRO_001a:
                    return new Sim_PRO_001a();
                case CardDB.cardIDEnum.EX1_295:
                    return new Sim_EX1_295();
                case CardDB.cardIDEnum.EX1_295o:
                    return new Sim_EX1_295o();
                case CardDB.cardIDEnum.CS2_031:
                    return new Sim_CS2_031();
                case CardDB.cardIDEnum.DS1_233:
                    return new Sim_DS1_233();
                case CardDB.cardIDEnum.EX1_620:
                    return new Sim_EX1_620();
                case CardDB.cardIDEnum.EX1_507e:
                    return new Sim_EX1_507e();
                case CardDB.cardIDEnum.GIL_530:
                    return new Sim_GIL_530();
                case CardDB.cardIDEnum.PRO_001at:
                    return new Sim_PRO_001at();
                case CardDB.cardIDEnum.EX1_161:
                    return new Sim_EX1_161();
                case CardDB.cardIDEnum.EX1_062:
                    return new Sim_EX1_062();
                case CardDB.cardIDEnum.Mekka4:
                    return new Sim_Mekka4();
                case CardDB.cardIDEnum.PRO_001c:
                    return new Sim_PRO_001c();
                case CardDB.cardIDEnum.EX1_316:
                    return new Sim_EX1_316();
                case CardDB.cardIDEnum.EX1_316e:
                    return new Sim_EX1_316e();
                case CardDB.cardIDEnum.EX1_298:
                    return new Sim_EX1_298();
                case CardDB.cardIDEnum.Mekka2:
                    return new Sim_Mekka2();
                case CardDB.cardIDEnum.PRO_001b:
                    return new Sim_PRO_001b();
                case CardDB.cardIDEnum.EX1_016:
                    return new Sim_EX1_016();
                case CardDB.cardIDEnum.Mekka4e:
                    return new Sim_Mekka4e();
                case CardDB.cardIDEnum.NEW1_004:
                    return new Sim_NEW1_004();
                case CardDB.cardIDEnum.NEW1_027e:
                    return new Sim_NEW1_027e();
 ///case CardDB.cardIDEnum.///DALARAN:
                    ///return new Sim_///DALARAN();
                case CardDB.cardIDEnum.DALA_738:
                    return new Sim_DALA_738();
                case CardDB.cardIDEnum.DALA_738e:
                    return new Sim_DALA_738e();
                case CardDB.cardIDEnum.DALA_BOSS_75p:
                    return new Sim_DALA_BOSS_75p();
                case CardDB.cardIDEnum.DALA_BOSS_30p:
                    return new Sim_DALA_BOSS_30p();
                case CardDB.cardIDEnum.DAL_354:
                    return new Sim_DAL_354();
                case CardDB.cardIDEnum.DALA_Priest_02:
                    return new Sim_DALA_Priest_02();
                case CardDB.cardIDEnum.DALA_Hunter_08:
                    return new Sim_DALA_Hunter_08();
                case CardDB.cardIDEnum.DALA_BOSS_32e4:
                    return new Sim_DALA_BOSS_32e4();
                case CardDB.cardIDEnum.DALA_BOSS_39h:
                    return new Sim_DALA_BOSS_39h();
                case CardDB.cardIDEnum.DALA_BOSS_13h:
                    return new Sim_DALA_BOSS_13h();
                case CardDB.cardIDEnum.DALA_BOSS_16h:
                    return new Sim_DALA_BOSS_16h();
                case CardDB.cardIDEnum.DALA_Druid_04:
                    return new Sim_DALA_Druid_04();
                case CardDB.cardIDEnum.DALA_Warrior_10:
                    return new Sim_DALA_Warrior_10();
                case CardDB.cardIDEnum.DAL_087t:
                    return new Sim_DAL_087t();
                case CardDB.cardIDEnum.DAL_087tw:
                    return new Sim_DAL_087tw();
                case CardDB.cardIDEnum.DALA_BOSS_71h:
                    return new Sim_DALA_BOSS_71h();
                case CardDB.cardIDEnum.DAL_351e:
                    return new Sim_DAL_351e();
                case CardDB.cardIDEnum.DALA_722:
                    return new Sim_DALA_722();
                case CardDB.cardIDEnum.DALA_850:
                    return new Sim_DALA_850();
                case CardDB.cardIDEnum.DALA_850e:
                    return new Sim_DALA_850e();
                case CardDB.cardIDEnum.DALA_852:
                    return new Sim_DALA_852();
                case CardDB.cardIDEnum.DALA_852e:
                    return new Sim_DALA_852e();
                case CardDB.cardIDEnum.DALA_860:
                    return new Sim_DALA_860();
                case CardDB.cardIDEnum.DALA_860e:
                    return new Sim_DALA_860e();
                case CardDB.cardIDEnum.DALA_865:
                    return new Sim_DALA_865();
                case CardDB.cardIDEnum.DALA_865e:
                    return new Sim_DALA_865e();
                case CardDB.cardIDEnum.DALA_858:
                    return new Sim_DALA_858();
                case CardDB.cardIDEnum.DALA_858e:
                    return new Sim_DALA_858e();
                case CardDB.cardIDEnum.DALA_857:
                    return new Sim_DALA_857();
                case CardDB.cardIDEnum.DALA_857e:
                    return new Sim_DALA_857e();
                case CardDB.cardIDEnum.DALA_859:
                    return new Sim_DALA_859();
                case CardDB.cardIDEnum.DALA_864:
                    return new Sim_DALA_864();
                case CardDB.cardIDEnum.DALA_864e:
                    return new Sim_DALA_864e();
                case CardDB.cardIDEnum.DALA_863:
                    return new Sim_DALA_863();
                case CardDB.cardIDEnum.DALA_867:
                    return new Sim_DALA_867();
                case CardDB.cardIDEnum.DALA_867e:
                    return new Sim_DALA_867e();
                case CardDB.cardIDEnum.DALA_854:
                    return new Sim_DALA_854();
                case CardDB.cardIDEnum.DALA_854e:
                    return new Sim_DALA_854e();
                case CardDB.cardIDEnum.DALA_861:
                    return new Sim_DALA_861();
                case CardDB.cardIDEnum.DALA_861e:
                    return new Sim_DALA_861e();
                case CardDB.cardIDEnum.DALA_853:
                    return new Sim_DALA_853();
                case CardDB.cardIDEnum.DALA_853e:
                    return new Sim_DALA_853e();
                case CardDB.cardIDEnum.DALA_862:
                    return new Sim_DALA_862();
                case CardDB.cardIDEnum.DALA_862e:
                    return new Sim_DALA_862e();
                case CardDB.cardIDEnum.DALA_855:
                    return new Sim_DALA_855();
                case CardDB.cardIDEnum.DALA_855e:
                    return new Sim_DALA_855e();
                case CardDB.cardIDEnum.DALA_866:
                    return new Sim_DALA_866();
                case CardDB.cardIDEnum.DALA_866e:
                    return new Sim_DALA_866e();
                case CardDB.cardIDEnum.DALA_851:
                    return new Sim_DALA_851();
                case CardDB.cardIDEnum.DALA_851e:
                    return new Sim_DALA_851e();
                case CardDB.cardIDEnum.DALA_856:
                    return new Sim_DALA_856();
                case CardDB.cardIDEnum.DALA_856e:
                    return new Sim_DALA_856e();
                case CardDB.cardIDEnum.DALA_BOSS_08p:
                    return new Sim_DALA_BOSS_08p();
                case CardDB.cardIDEnum.DALA_BOSS_08px:
                    return new Sim_DALA_BOSS_08px();
                case CardDB.cardIDEnum.DALA_BOSS_08h:
                    return new Sim_DALA_BOSS_08h();
                case CardDB.cardIDEnum.DAL_185:
                    return new Sim_DAL_185();
                case CardDB.cardIDEnum.DAL_548e:
                    return new Sim_DAL_548e();
                case CardDB.cardIDEnum.DAL_372:
                    return new Sim_DAL_372();
                case CardDB.cardIDEnum.DALA_BOSS_67p:
                    return new Sim_DALA_BOSS_67p();
                case CardDB.cardIDEnum.DAL_092:
                    return new Sim_DAL_092();
                case CardDB.cardIDEnum.DAL_434:
                    return new Sim_DAL_434();
                case CardDB.cardIDEnum.DAL_736:
                    return new Sim_DAL_736();
                case CardDB.cardIDEnum.DALA_BOSS_09h:
                    return new Sim_DALA_BOSS_09h();
                case CardDB.cardIDEnum.DALA_BOSS_69h:
                    return new Sim_DALA_BOSS_69h();
                case CardDB.cardIDEnum.DALA_BOSS_60h:
                    return new Sim_DALA_BOSS_60h();
                case CardDB.cardIDEnum.DAL_558:
                    return new Sim_DAL_558();
                case CardDB.cardIDEnum.DALA_BOSS_67h:
                    return new Sim_DALA_BOSS_67h();
                case CardDB.cardIDEnum.DAL_422:
                    return new Sim_DAL_422();
                case CardDB.cardIDEnum.DALA_BOSS_24p:
                    return new Sim_DALA_BOSS_24p();
                case CardDB.cardIDEnum.DALA_BOSS_24px:
                    return new Sim_DALA_BOSS_24px();
                case CardDB.cardIDEnum.DALA_BOSS_24e:
                    return new Sim_DALA_BOSS_24e();
                case CardDB.cardIDEnum.DALA_BOSS_06p:
                    return new Sim_DALA_BOSS_06p();
                case CardDB.cardIDEnum.DALA_Warrior_08:
                    return new Sim_DALA_Warrior_08();
                case CardDB.cardIDEnum.DALA_Warrior_09:
                    return new Sim_DALA_Warrior_09();
                case CardDB.cardIDEnum.DAL_609e:
                    return new Sim_DAL_609e();
                case CardDB.cardIDEnum.DAL_366t1:
                    return new Sim_DAL_366t1();
                case CardDB.cardIDEnum.DALA_BOSS_25p:
                    return new Sim_DALA_BOSS_25p();
                case CardDB.cardIDEnum.DALA_BOSS_25px:
                    return new Sim_DALA_BOSS_25px();
                case CardDB.cardIDEnum.DALA_BOSS_02h:
                    return new Sim_DALA_BOSS_02h();
                case CardDB.cardIDEnum.DAL_548:
                    return new Sim_DAL_548();
                case CardDB.cardIDEnum.DALA_BOSS_11p:
                    return new Sim_DALA_BOSS_11p();
                case CardDB.cardIDEnum.DALA_BOSS_11px:
                    return new Sim_DALA_BOSS_11px();
                case CardDB.cardIDEnum.DALA_BOSS_11e:
                    return new Sim_DALA_BOSS_11e();
                case CardDB.cardIDEnum.DALA_BOSS_11ex:
                    return new Sim_DALA_BOSS_11ex();
                case CardDB.cardIDEnum.DALA_Paladin_HP1:
                    return new Sim_DALA_Paladin_HP1();
                case CardDB.cardIDEnum.DALA_725:
                    return new Sim_DALA_725();
                case CardDB.cardIDEnum.DALA_BOSS_64h:
                    return new Sim_DALA_BOSS_64h();
                case CardDB.cardIDEnum.DAL_546:
                    return new Sim_DAL_546();
                case CardDB.cardIDEnum.DALA_Druid_HP2e:
                    return new Sim_DALA_Druid_HP2e();
                case CardDB.cardIDEnum.DALA_BOSS_99h:
                    return new Sim_DALA_BOSS_99h();
                case CardDB.cardIDEnum.DALA_BOSS_98h:
                    return new Sim_DALA_BOSS_98h();
                case CardDB.cardIDEnum.DAL_592:
                    return new Sim_DAL_592();
                case CardDB.cardIDEnum.DALA_Hunter_11:
                    return new Sim_DALA_Hunter_11();
                case CardDB.cardIDEnum.DALA_Rogue_10:
                    return new Sim_DALA_Rogue_10();
                case CardDB.cardIDEnum.DALA_Shaman_07:
                    return new Sim_DALA_Shaman_07();
                case CardDB.cardIDEnum.DALA_BOSS_75e1:
                    return new Sim_DALA_BOSS_75e1();
                case CardDB.cardIDEnum.DALA_Druid_10:
                    return new Sim_DALA_Druid_10();
                case CardDB.cardIDEnum.DAL_553:
                    return new Sim_DAL_553();
                case CardDB.cardIDEnum.DALA_Hunter_05:
                    return new Sim_DALA_Hunter_05();
                case CardDB.cardIDEnum.DALA_724:
                    return new Sim_DALA_724();
                case CardDB.cardIDEnum.DALA_724d:
                    return new Sim_DALA_724d();
                case CardDB.cardIDEnum.DALA_724e:
                    return new Sim_DALA_724e();
                case CardDB.cardIDEnum.DALA_Warlock_01:
                    return new Sim_DALA_Warlock_01();
                case CardDB.cardIDEnum.DALA_Druid_11:
                    return new Sim_DALA_Druid_11();
                case CardDB.cardIDEnum.DALA_Warrior_03:
                    return new Sim_DALA_Warrior_03();
                case CardDB.cardIDEnum.DALA_Shaman_05:
                    return new Sim_DALA_Shaman_05();
                case CardDB.cardIDEnum.DALA_BOSS_59p:
                    return new Sim_DALA_BOSS_59p();
                case CardDB.cardIDEnum.DALA_BOSS_59px:
                    return new Sim_DALA_BOSS_59px();
                case CardDB.cardIDEnum.DALA_BOSS_58e:
                    return new Sim_DALA_BOSS_58e();
                case CardDB.cardIDEnum.DALA_BOSS_58p:
                    return new Sim_DALA_BOSS_58p();
                case CardDB.cardIDEnum.DAL_064:
                    return new Sim_DAL_064();
                case CardDB.cardIDEnum.DALA_BOSS_15p:
                    return new Sim_DALA_BOSS_15p();
                case CardDB.cardIDEnum.DAL_351:
                    return new Sim_DAL_351();
                case CardDB.cardIDEnum.DAL_351ts:
                    return new Sim_DAL_351ts();
                case CardDB.cardIDEnum.DALA_BOSS_31p:
                    return new Sim_DALA_BOSS_31p();
                case CardDB.cardIDEnum.DALA_BOSS_31px:
                    return new Sim_DALA_BOSS_31px();
                case CardDB.cardIDEnum.DALA_BOSS_31e:
                    return new Sim_DALA_BOSS_31e();
                case CardDB.cardIDEnum.DALA_BOSS_31ex:
                    return new Sim_DALA_BOSS_31ex();
                case CardDB.cardIDEnum.DALA_BOSS_70p:
                    return new Sim_DALA_BOSS_70p();
                case CardDB.cardIDEnum.DALA_BOSS_70px:
                    return new Sim_DALA_BOSS_70px();
                case CardDB.cardIDEnum.DALA_BOSS_70e:
                    return new Sim_DALA_BOSS_70e();
                case CardDB.cardIDEnum.DALA_Warrior_04:
                    return new Sim_DALA_Warrior_04();
                case CardDB.cardIDEnum.DALA_BOSS_53e:
                    return new Sim_DALA_BOSS_53e();
                case CardDB.cardIDEnum.DALA_BOSS_53p:
                    return new Sim_DALA_BOSS_53p();
                case CardDB.cardIDEnum.DALA_BOSS_53px:
                    return new Sim_DALA_BOSS_53px();
                case CardDB.cardIDEnum.DALA_739:
                    return new Sim_DALA_739();
                case CardDB.cardIDEnum.DALA_BOSS_22h:
                    return new Sim_DALA_BOSS_22h();
                case CardDB.cardIDEnum.DALA_BOSS_58h:
                    return new Sim_DALA_BOSS_58h();
                case CardDB.cardIDEnum.DALA_Paladin_HP2:
                    return new Sim_DALA_Paladin_HP2();
                case CardDB.cardIDEnum.DALA_BOSS_56e:
                    return new Sim_DALA_BOSS_56e();
                case CardDB.cardIDEnum.DALA_BOSS_56p:
                    return new Sim_DALA_BOSS_56p();
                case CardDB.cardIDEnum.DAL_146t:
                    return new Sim_DAL_146t();
                case CardDB.cardIDEnum.DAL_146:
                    return new Sim_DAL_146();
                case CardDB.cardIDEnum.DALA_912:
                    return new Sim_DALA_912();
                case CardDB.cardIDEnum.DALA_BOSS_63p:
                    return new Sim_DALA_BOSS_63p();
                case CardDB.cardIDEnum.DALA_BOSS_63px:
                    return new Sim_DALA_BOSS_63px();
                case CardDB.cardIDEnum.DALA_BOSS_03t2:
                    return new Sim_DALA_BOSS_03t2();
                case CardDB.cardIDEnum.DAL_760:
                    return new Sim_DAL_760();
                case CardDB.cardIDEnum.DALA_Mage_06:
                    return new Sim_DALA_Mage_06();
                case CardDB.cardIDEnum.DALA_Mage_HP1:
                    return new Sim_DALA_Mage_HP1();
                case CardDB.cardIDEnum.DALA_829t:
                    return new Sim_DALA_829t();
                case CardDB.cardIDEnum.DAL_727:
                    return new Sim_DAL_727();
                case CardDB.cardIDEnum.DALA_BOSS_64e:
                    return new Sim_DALA_BOSS_64e();
                case CardDB.cardIDEnum.DALA_Eudora:
                    return new Sim_DALA_Eudora();
                case CardDB.cardIDEnum.DALA_BOSS_55h:
                    return new Sim_DALA_BOSS_55h();
                case CardDB.cardIDEnum.DALA_BOSS_34h:
                    return new Sim_DALA_BOSS_34h();
                case CardDB.cardIDEnum.DALA_Shaman_09:
                    return new Sim_DALA_Shaman_09();
                case CardDB.cardIDEnum.DALA_717:
                    return new Sim_DALA_717();
                case CardDB.cardIDEnum.DAL_721:
                    return new Sim_DAL_721();
                case CardDB.cardIDEnum.DALA_501:
                    return new Sim_DALA_501();
                case CardDB.cardIDEnum.DAL_554:
                    return new Sim_DAL_554();
                case CardDB.cardIDEnum.DALA_Druid_03:
                    return new Sim_DALA_Druid_03();
                case CardDB.cardIDEnum.DALA_BOSS_01p:
                    return new Sim_DALA_BOSS_01p();
                case CardDB.cardIDEnum.DALA_BOSS_01px:
                    return new Sim_DALA_BOSS_01px();
                case CardDB.cardIDEnum.DALA_BOSS_01h:
                    return new Sim_DALA_BOSS_01h();
                case CardDB.cardIDEnum.DAL_060:
                    return new Sim_DAL_060();
                case CardDB.cardIDEnum.DAL_579p:
                    return new Sim_DAL_579p();
                case CardDB.cardIDEnum.DALA_Rogue_06:
                    return new Sim_DALA_Rogue_06();
                case CardDB.cardIDEnum.DALA_BOSS_26p:
                    return new Sim_DALA_BOSS_26p();
                case CardDB.cardIDEnum.DALA_BOSS_26px:
                    return new Sim_DALA_BOSS_26px();
                case CardDB.cardIDEnum.DALA_Mage_02:
                    return new Sim_DALA_Mage_02();
                case CardDB.cardIDEnum.DALA_Rogue_01:
                    return new Sim_DALA_Rogue_01();
                case CardDB.cardIDEnum.DALA_BOSS_75h:
                    return new Sim_DALA_BOSS_75h();
                case CardDB.cardIDEnum.DAL_573:
                    return new Sim_DAL_573();
                case CardDB.cardIDEnum.DAL_177:
                    return new Sim_DAL_177();
                case CardDB.cardIDEnum.DAL_177ts:
                    return new Sim_DAL_177ts();
                case CardDB.cardIDEnum.DALA_700:
                    return new Sim_DALA_700();
                case CardDB.cardIDEnum.DAL_039:
                    return new Sim_DAL_039();
                case CardDB.cardIDEnum.DALA_BOSS_12h:
                    return new Sim_DALA_BOSS_12h();
                case CardDB.cardIDEnum.DAL_733t:
                    return new Sim_DAL_733t();
                case CardDB.cardIDEnum.DAL_350:
                    return new Sim_DAL_350();
                case CardDB.cardIDEnum.DAL_799:
                    return new Sim_DAL_799();
                case CardDB.cardIDEnum.DAL_352:
                    return new Sim_DAL_352();
                case CardDB.cardIDEnum.DALA_Priest_01:
                    return new Sim_DALA_Priest_01();
                case CardDB.cardIDEnum.DALA_Warlock_11:
                    return new Sim_DALA_Warlock_11();
                case CardDB.cardIDEnum.DALA_Rogue_HP2:
                    return new Sim_DALA_Rogue_HP2();
                case CardDB.cardIDEnum.DALA_Rogue_08:
                    return new Sim_DALA_Rogue_08();
                case CardDB.cardIDEnum.DALA_BOSS_49h:
                    return new Sim_DALA_BOSS_49h();
                case CardDB.cardIDEnum.DALA_BOSS_63h:
                    return new Sim_DALA_BOSS_63h();
                case CardDB.cardIDEnum.DALA_729:
                    return new Sim_DALA_729();
                case CardDB.cardIDEnum.DAL_085:
                    return new Sim_DAL_085();
                case CardDB.cardIDEnum.DALA_BOSS_26h:
                    return new Sim_DALA_BOSS_26h();
                case CardDB.cardIDEnum.DAL_735:
                    return new Sim_DAL_735();
                case CardDB.cardIDEnum.DALA_Warrior_02:
                    return new Sim_DALA_Warrior_02();
                case CardDB.cardIDEnum.DALA_BOSS_53h:
                    return new Sim_DALA_BOSS_53h();
                case CardDB.cardIDEnum.DAL_728:
                    return new Sim_DAL_728();
                case CardDB.cardIDEnum.DALA_BOSS_44p:
                    return new Sim_DALA_BOSS_44p();
                case CardDB.cardIDEnum.DALA_BOSS_44px:
                    return new Sim_DALA_BOSS_44px();
                case CardDB.cardIDEnum.DALA_BOSS_62p:
                    return new Sim_DALA_BOSS_62p();
                case CardDB.cardIDEnum.DALA_BOSS_62px:
                    return new Sim_DALA_BOSS_62px();
                case CardDB.cardIDEnum.DALA_BOSS_62e:
                    return new Sim_DALA_BOSS_62e();
                case CardDB.cardIDEnum.DALA_BOSS_62ex:
                    return new Sim_DALA_BOSS_62ex();
                case CardDB.cardIDEnum.DAL_173:
                    return new Sim_DAL_173();
                case CardDB.cardIDEnum.DALA_BOSS_06h:
                    return new Sim_DALA_BOSS_06h();
                case CardDB.cardIDEnum.DALA_Hunter_03:
                    return new Sim_DALA_Hunter_03();
                case CardDB.cardIDEnum.DALA_Rogue_05:
                    return new Sim_DALA_Rogue_05();
                case CardDB.cardIDEnum.DAL_141:
                    return new Sim_DAL_141();
                case CardDB.cardIDEnum.DAL_141ts:
                    return new Sim_DAL_141ts();
                case CardDB.cardIDEnum.DALA_833t4:
                    return new Sim_DALA_833t4();
                case CardDB.cardIDEnum.DALA_Warlock_08:
                    return new Sim_DALA_Warlock_08();
                case CardDB.cardIDEnum.DALA_Warlock_HP2t:
                    return new Sim_DALA_Warlock_HP2t();
                case CardDB.cardIDEnum.DAL_059:
                    return new Sim_DAL_059();
                case CardDB.cardIDEnum.DALA_Warlock_06:
                    return new Sim_DALA_Warlock_06();
                case CardDB.cardIDEnum.DALA_BOSS_18h:
                    return new Sim_DALA_BOSS_18h();
                case CardDB.cardIDEnum.DALA_902:
                    return new Sim_DALA_902();
                case CardDB.cardIDEnum.DALA_Priest_HP1:
                    return new Sim_DALA_Priest_HP1();
                case CardDB.cardIDEnum.DALA_Priest_HP1e:
                    return new Sim_DALA_Priest_HP1e();
                case CardDB.cardIDEnum.DALA_743:
                    return new Sim_DALA_743();
                case CardDB.cardIDEnum.DAL_008:
                    return new Sim_DAL_008();
                case CardDB.cardIDEnum.DALA_BOSS_36h:
                    return new Sim_DALA_BOSS_36h();
                case CardDB.cardIDEnum.DALA_Warrior_07:
                    return new Sim_DALA_Warrior_07();
                case CardDB.cardIDEnum.DAL_147e:
                    return new Sim_DAL_147e();
                case CardDB.cardIDEnum.DAL_147:
                    return new Sim_DAL_147();
                case CardDB.cardIDEnum.DALA_Priest_08:
                    return new Sim_DALA_Priest_08();
                case CardDB.cardIDEnum.DALA_Paladin_03:
                    return new Sim_DALA_Paladin_03();
                case CardDB.cardIDEnum.DALA_BOSS_69p:
                    return new Sim_DALA_BOSS_69p();
                case CardDB.cardIDEnum.DALA_BOSS_69px:
                    return new Sim_DALA_BOSS_69px();
                case CardDB.cardIDEnum.DALA_Rogue_09:
                    return new Sim_DALA_Rogue_09();
                case CardDB.cardIDEnum.DALA_Warlock_03:
                    return new Sim_DALA_Warlock_03();
                case CardDB.cardIDEnum.DALA_711:
                    return new Sim_DALA_711();
                case CardDB.cardIDEnum.DAL_733:
                    return new Sim_DAL_733();
                case CardDB.cardIDEnum.DALA_Druid_HPe:
                    return new Sim_DALA_Druid_HPe();
                case CardDB.cardIDEnum.DAL_431t:
                    return new Sim_DAL_431t();
                case CardDB.cardIDEnum.DAL_731:
                    return new Sim_DAL_731();
                case CardDB.cardIDEnum.DALA_721:
                    return new Sim_DALA_721();
                case CardDB.cardIDEnum.DAL_563:
                    return new Sim_DAL_563();
                case CardDB.cardIDEnum.DALA_BOSS_73p:
                    return new Sim_DALA_BOSS_73p();
                case CardDB.cardIDEnum.DALA_BOSS_73px:
                    return new Sim_DALA_BOSS_73px();
                case CardDB.cardIDEnum.DALA_BOSS_73e:
                    return new Sim_DALA_BOSS_73e();
                case CardDB.cardIDEnum.DALA_BOSS_73ex:
                    return new Sim_DALA_BOSS_73ex();
                case CardDB.cardIDEnum.DAL_566:
                    return new Sim_DAL_566();
                case CardDB.cardIDEnum.DALA_713:
                    return new Sim_DALA_713();
                case CardDB.cardIDEnum.DALA_Shaman_06:
                    return new Sim_DALA_Shaman_06();
                case CardDB.cardIDEnum.DALA_BOSS_51t:
                    return new Sim_DALA_BOSS_51t();
                case CardDB.cardIDEnum.DALA_Mage_07:
                    return new Sim_DALA_Mage_07();
                case CardDB.cardIDEnum.DALA_718:
                    return new Sim_DALA_718();
                case CardDB.cardIDEnum.DALA_746:
                    return new Sim_DALA_746();
                case CardDB.cardIDEnum.DALA_746d:
                    return new Sim_DALA_746d();
                case CardDB.cardIDEnum.DALA_746e:
                    return new Sim_DALA_746e();
                case CardDB.cardIDEnum.DALA_748:
                    return new Sim_DALA_748();
                case CardDB.cardIDEnum.DALA_748e:
                    return new Sim_DALA_748e();
                case CardDB.cardIDEnum.DALA_747:
                    return new Sim_DALA_747();
                case CardDB.cardIDEnum.DALA_747e:
                    return new Sim_DALA_747e();
                case CardDB.cardIDEnum.DALA_733:
                    return new Sim_DALA_733();
                case CardDB.cardIDEnum.DALA_733e2:
                    return new Sim_DALA_733e2();
                case CardDB.cardIDEnum.DALA_733e:
                    return new Sim_DALA_733e();
                case CardDB.cardIDEnum.DALA_Hunter_07:
                    return new Sim_DALA_Hunter_07();
                case CardDB.cardIDEnum.DALA_Warlock_10:
                    return new Sim_DALA_Warlock_10();
                case CardDB.cardIDEnum.DALA_BOSS_16p:
                    return new Sim_DALA_BOSS_16p();
                case CardDB.cardIDEnum.DALA_BOSS_16px:
                    return new Sim_DALA_BOSS_16px();
                case CardDB.cardIDEnum.DALA_BOSS_16e:
                    return new Sim_DALA_BOSS_16e();
                case CardDB.cardIDEnum.DALA_BOSS_44h:
                    return new Sim_DALA_BOSS_44h();
                case CardDB.cardIDEnum.DAL_741:
                    return new Sim_DAL_741();
                case CardDB.cardIDEnum.DAL_400:
                    return new Sim_DAL_400();
                case CardDB.cardIDEnum.DAL_413:
                    return new Sim_DAL_413();
                case CardDB.cardIDEnum.DAL_606:
                    return new Sim_DAL_606();
                case CardDB.cardIDEnum.DAL_415:
                    return new Sim_DAL_415();
                case CardDB.cardIDEnum.DALA_706:
                    return new Sim_DALA_706();
                case CardDB.cardIDEnum.DALA_737e:
                    return new Sim_DALA_737e();
                case CardDB.cardIDEnum.DALA_Shaman_HP1:
                    return new Sim_DALA_Shaman_HP1();
                case CardDB.cardIDEnum.DALA_BOSS_29p:
                    return new Sim_DALA_BOSS_29p();
                case CardDB.cardIDEnum.DAL_774:
                    return new Sim_DAL_774();
                case CardDB.cardIDEnum.DALA_BOSS_36t:
                    return new Sim_DALA_BOSS_36t();
                case CardDB.cardIDEnum.DALA_865e2:
                    return new Sim_DALA_865e2();
                case CardDB.cardIDEnum.DALA_BOSS_59t3:
                    return new Sim_DALA_BOSS_59t3();
                case CardDB.cardIDEnum.DAL_613:
                    return new Sim_DAL_613();
                case CardDB.cardIDEnum.DAL_744:
                    return new Sim_DAL_744();
                case CardDB.cardIDEnum.DAL_744e:
                    return new Sim_DAL_744e();
                case CardDB.cardIDEnum.DALA_Mage_09:
                    return new Sim_DALA_Mage_09();
                case CardDB.cardIDEnum.DAL_607:
                    return new Sim_DAL_607();
                case CardDB.cardIDEnum.DAL_582t2:
                    return new Sim_DAL_582t2();
                case CardDB.cardIDEnum.DAL_582t:
                    return new Sim_DAL_582t();
                case CardDB.cardIDEnum.DALA_Druid_06:
                    return new Sim_DALA_Druid_06();
                case CardDB.cardIDEnum.DALA_833t2:
                    return new Sim_DALA_833t2();
                case CardDB.cardIDEnum.DALA_Shaman_03:
                    return new Sim_DALA_Shaman_03();
                case CardDB.cardIDEnum.DAL_607e:
                    return new Sim_DAL_607e();
                case CardDB.cardIDEnum.DAL_747:
                    return new Sim_DAL_747();
                case CardDB.cardIDEnum.DALA_BOSS_07h:
                    return new Sim_DALA_BOSS_07h();
                case CardDB.cardIDEnum.DALA_Shaman_01:
                    return new Sim_DALA_Shaman_01();
                case CardDB.cardIDEnum.DALA_716:
                    return new Sim_DALA_716();
                case CardDB.cardIDEnum.DALA_BOSS_07e:
                    return new Sim_DALA_BOSS_07e();
                case CardDB.cardIDEnum.DALA_BOSS_07p2:
                    return new Sim_DALA_BOSS_07p2();
                case CardDB.cardIDEnum.DAL_773e:
                    return new Sim_DAL_773e();
                case CardDB.cardIDEnum.DALA_BOSS_39p:
                    return new Sim_DALA_BOSS_39p();
                case CardDB.cardIDEnum.DALA_BOSS_12p:
                    return new Sim_DALA_BOSS_12p();
                case CardDB.cardIDEnum.DALA_BOSS_12px:
                    return new Sim_DALA_BOSS_12px();
                case CardDB.cardIDEnum.DAL_723:
                    return new Sim_DAL_723();
                case CardDB.cardIDEnum.DALA_BOSS_44e:
                    return new Sim_DALA_BOSS_44e();
                case CardDB.cardIDEnum.DALA_BOSS_44ex:
                    return new Sim_DALA_BOSS_44ex();
                case CardDB.cardIDEnum.DALA_Priest_03:
                    return new Sim_DALA_Priest_03();
                case CardDB.cardIDEnum.DALA_Mage_HP2:
                    return new Sim_DALA_Mage_HP2();
                case CardDB.cardIDEnum.DALA_833t:
                    return new Sim_DALA_833t();
                case CardDB.cardIDEnum.DALA_BOSS_59t2:
                    return new Sim_DALA_BOSS_59t2();
                case CardDB.cardIDEnum.DALA_George:
                    return new Sim_DALA_George();
                case CardDB.cardIDEnum.DALA_725e:
                    return new Sim_DALA_725e();
                case CardDB.cardIDEnum.DALA_702:
                    return new Sim_DALA_702();
                case CardDB.cardIDEnum.DALA_Mage_05:
                    return new Sim_DALA_Mage_05();
                case CardDB.cardIDEnum.DAL_739:
                    return new Sim_DAL_739();
                case CardDB.cardIDEnum.DALA_BOSS_33h:
                    return new Sim_DALA_BOSS_33h();
                case CardDB.cardIDEnum.DALA_709:
                    return new Sim_DALA_709();
                case CardDB.cardIDEnum.DALA_904:
                    return new Sim_DALA_904();
                case CardDB.cardIDEnum.DALA_913e:
                    return new Sim_DALA_913e();
                case CardDB.cardIDEnum.DAL_554t:
                    return new Sim_DAL_554t();
                case CardDB.cardIDEnum.DALA_BOSS_57p:
                    return new Sim_DALA_BOSS_57p();
                case CardDB.cardIDEnum.DALA_705:
                    return new Sim_DALA_705();
                case CardDB.cardIDEnum.DALA_864e2:
                    return new Sim_DALA_864e2();
                case CardDB.cardIDEnum.DAL_747t:
                    return new Sim_DAL_747t();
                case CardDB.cardIDEnum.DALA_744:
                    return new Sim_DALA_744();
                case CardDB.cardIDEnum.DALA_744e2:
                    return new Sim_DALA_744e2();
                case CardDB.cardIDEnum.DALA_744d:
                    return new Sim_DALA_744d();
                case CardDB.cardIDEnum.DALA_744e:
                    return new Sim_DALA_744e();
                case CardDB.cardIDEnum.DAL_009:
                    return new Sim_DAL_009();
                case CardDB.cardIDEnum.DALA_Paladin_06:
                    return new Sim_DALA_Paladin_06();
                case CardDB.cardIDEnum.DALA_BOSS_62h:
                    return new Sim_DALA_BOSS_62h();
                case CardDB.cardIDEnum.DAL_350b:
                    return new Sim_DAL_350b();
                case CardDB.cardIDEnum.DALA_BOSS_35p:
                    return new Sim_DALA_BOSS_35p();
                case CardDB.cardIDEnum.DALA_BOSS_35px:
                    return new Sim_DALA_BOSS_35px();
                case CardDB.cardIDEnum.DALA_Paladin_05:
                    return new Sim_DALA_Paladin_05();
                case CardDB.cardIDEnum.DAL_058:
                    return new Sim_DAL_058();
                case CardDB.cardIDEnum.DAL_417:
                    return new Sim_DAL_417();
                case CardDB.cardIDEnum.DAL_416:
                    return new Sim_DAL_416();
                case CardDB.cardIDEnum.DAL_087:
                    return new Sim_DAL_087();
                case CardDB.cardIDEnum.DAL_743:
                    return new Sim_DAL_743();
                case CardDB.cardIDEnum.DAL_040:
                    return new Sim_DAL_040();
                case CardDB.cardIDEnum.DAL_090:
                    return new Sim_DAL_090();
                case CardDB.cardIDEnum.DAL_743t:
                    return new Sim_DAL_743t();
                case CardDB.cardIDEnum.DALA_BOSS_75e4:
                    return new Sim_DALA_BOSS_75e4();
                case CardDB.cardIDEnum.DAL_727e:
                    return new Sim_DAL_727e();
                case CardDB.cardIDEnum.DAL_560:
                    return new Sim_DAL_560();
                case CardDB.cardIDEnum.DALA_BOSS_73h:
                    return new Sim_DALA_BOSS_73h();
                case CardDB.cardIDEnum.DALA_BOSS_25t:
                    return new Sim_DALA_BOSS_25t();
                case CardDB.cardIDEnum.DALA_BOSS_75e5:
                    return new Sim_DALA_BOSS_75e5();
                case CardDB.cardIDEnum.DALA_BOSS_52e:
                    return new Sim_DALA_BOSS_52e();
                case CardDB.cardIDEnum.DALA_BOSS_52ex:
                    return new Sim_DALA_BOSS_52ex();
                case CardDB.cardIDEnum.DALA_BOSS_52p:
                    return new Sim_DALA_BOSS_52p();
                case CardDB.cardIDEnum.DALA_BOSS_52px:
                    return new Sim_DALA_BOSS_52px();
                case CardDB.cardIDEnum.DALA_Paladin_04:
                    return new Sim_DALA_Paladin_04();
                case CardDB.cardIDEnum.DALA_Hunter_HPe:
                    return new Sim_DALA_Hunter_HPe();
                case CardDB.cardIDEnum.DAL_589:
                    return new Sim_DAL_589();
                case CardDB.cardIDEnum.DAL_589e:
                    return new Sim_DAL_589e();
                case CardDB.cardIDEnum.DALA_723:
                    return new Sim_DALA_723();
                case CardDB.cardIDEnum.DALA_723e:
                    return new Sim_DALA_723e();
                case CardDB.cardIDEnum.DALA_BOSS_46h:
                    return new Sim_DALA_BOSS_46h();
                case CardDB.cardIDEnum.DALA_BOSS_40p:
                    return new Sim_DALA_BOSS_40p();
                case CardDB.cardIDEnum.DALA_BOSS_40px:
                    return new Sim_DALA_BOSS_40px();
                case CardDB.cardIDEnum.DAL_751t:
                    return new Sim_DAL_751t();
                case CardDB.cardIDEnum.DALA_BOSS_65p:
                    return new Sim_DALA_BOSS_65p();
                case CardDB.cardIDEnum.DAL_605:
                    return new Sim_DAL_605();
                case CardDB.cardIDEnum.DAL_561e:
                    return new Sim_DAL_561e();
                case CardDB.cardIDEnum.DALA_BOSS_36p:
                    return new Sim_DALA_BOSS_36p();
                case CardDB.cardIDEnum.DALA_BOSS_36px:
                    return new Sim_DALA_BOSS_36px();
                case CardDB.cardIDEnum.DAL_769:
                    return new Sim_DAL_769();
                case CardDB.cardIDEnum.DALA_Warrior_HP2t:
                    return new Sim_DALA_Warrior_HP2t();
                case CardDB.cardIDEnum.DAL_605e:
                    return new Sim_DAL_605e();
                case CardDB.cardIDEnum.DALA_Warlock_07:
                    return new Sim_DALA_Warlock_07();
                case CardDB.cardIDEnum.DALA_BOSS_32e3:
                    return new Sim_DALA_BOSS_32e3();
                case CardDB.cardIDEnum.DALA_502:
                    return new Sim_DALA_502();
                case CardDB.cardIDEnum.DALA_Mage_11:
                    return new Sim_DALA_Mage_11();
                case CardDB.cardIDEnum.DALA_BOSS_32e2:
                    return new Sim_DALA_BOSS_32e2();
                case CardDB.cardIDEnum.DALA_BOSS_64p:
                    return new Sim_DALA_BOSS_64p();
                case CardDB.cardIDEnum.DALA_BOSS_64px:
                    return new Sim_DALA_BOSS_64px();
                case CardDB.cardIDEnum.DALA_Warrior_HP1e:
                    return new Sim_DALA_Warrior_HP1e();
                case CardDB.cardIDEnum.DALA_Warrior_HP1:
                    return new Sim_DALA_Warrior_HP1();
                case CardDB.cardIDEnum.DALA_Warrior_06:
                    return new Sim_DALA_Warrior_06();
                case CardDB.cardIDEnum.DAL_752:
                    return new Sim_DAL_752();
                case CardDB.cardIDEnum.DALA_BOSS_25h:
                    return new Sim_DALA_BOSS_25h();
                case CardDB.cardIDEnum.DALA_Paladin_11:
                    return new Sim_DALA_Paladin_11();
                case CardDB.cardIDEnum.DAL_561:
                    return new Sim_DAL_561();
                case CardDB.cardIDEnum.DALA_716t:
                    return new Sim_DALA_716t();
                case CardDB.cardIDEnum.DALA_BOSS_43p:
                    return new Sim_DALA_BOSS_43p();
                case CardDB.cardIDEnum.DAL_609:
                    return new Sim_DAL_609();
                case CardDB.cardIDEnum.DALA_BOSS_74h:
                    return new Sim_DALA_BOSS_74h();
                case CardDB.cardIDEnum.DALA_BOSS_04h:
                    return new Sim_DALA_BOSS_04h();
                case CardDB.cardIDEnum.DALA_BOSS_72h:
                    return new Sim_DALA_BOSS_72h();
                case CardDB.cardIDEnum.DAL_732:
                    return new Sim_DAL_732();
                case CardDB.cardIDEnum.DAL_575:
                    return new Sim_DAL_575();
                case CardDB.cardIDEnum.DALA_BOSS_14t:
                    return new Sim_DALA_BOSS_14t();
                case CardDB.cardIDEnum.DALA_911:
                    return new Sim_DALA_911();
                case CardDB.cardIDEnum.DALA_Rogue_04:
                    return new Sim_DALA_Rogue_04();
                case CardDB.cardIDEnum.DALA_504:
                    return new Sim_DALA_504();
                case CardDB.cardIDEnum.DALA_503:
                    return new Sim_DALA_503();
                case CardDB.cardIDEnum.DAL_576:
                    return new Sim_DAL_576();
                case CardDB.cardIDEnum.DAL_576e:
                    return new Sim_DAL_576e();
                case CardDB.cardIDEnum.DALA_BOSS_32h:
                    return new Sim_DALA_BOSS_32h();
                case CardDB.cardIDEnum.DAL_614:
                    return new Sim_DAL_614();
                case CardDB.cardIDEnum.DALA_Kriziki:
                    return new Sim_DALA_Kriziki();
                case CardDB.cardIDEnum.DALA_BOSS_47p:
                    return new Sim_DALA_BOSS_47p();
                case CardDB.cardIDEnum.DALA_BOSS_47px:
                    return new Sim_DALA_BOSS_47px();
                case CardDB.cardIDEnum.DALA_BOSS_47h:
                    return new Sim_DALA_BOSS_47h();
                case CardDB.cardIDEnum.DAL_011e:
                    return new Sim_DAL_011e();
                case CardDB.cardIDEnum.DAL_011:
                    return new Sim_DAL_011();
                case CardDB.cardIDEnum.DALA_Warlock_12:
                    return new Sim_DALA_Warlock_12();
                case CardDB.cardIDEnum.DALA_Druid_12:
                    return new Sim_DALA_Druid_12();
                case CardDB.cardIDEnum.DALA_Hunter_12:
                    return new Sim_DALA_Hunter_12();
                case CardDB.cardIDEnum.DALA_Mage_12:
                    return new Sim_DALA_Mage_12();
                case CardDB.cardIDEnum.DALA_Paladin_12:
                    return new Sim_DALA_Paladin_12();
                case CardDB.cardIDEnum.DALA_Priest_12:
                    return new Sim_DALA_Priest_12();
                case CardDB.cardIDEnum.DALA_Rogue_12:
                    return new Sim_DALA_Rogue_12();
                case CardDB.cardIDEnum.DALA_Shaman_12:
                    return new Sim_DALA_Shaman_12();
                case CardDB.cardIDEnum.DALA_Warrior_12:
                    return new Sim_DALA_Warrior_12();
                case CardDB.cardIDEnum.DALA_BOSS_52h:
                    return new Sim_DALA_BOSS_52h();
                case CardDB.cardIDEnum.DALA_Druid_HP1:
                    return new Sim_DALA_Druid_HP1();
                case CardDB.cardIDEnum.DAL_355:
                    return new Sim_DAL_355();
                case CardDB.cardIDEnum.DAL_568:
                    return new Sim_DAL_568();
                case CardDB.cardIDEnum.DAL_568e:
                    return new Sim_DAL_568e();
                case CardDB.cardIDEnum.DAL_568ts:
                    return new Sim_DAL_568ts();
                case CardDB.cardIDEnum.DALA_BOSS_39e:
                    return new Sim_DALA_BOSS_39e();
                case CardDB.cardIDEnum.DALA_Warlock_09:
                    return new Sim_DALA_Warlock_09();
                case CardDB.cardIDEnum.DALA_BOSS_19p:
                    return new Sim_DALA_BOSS_19p();
                case CardDB.cardIDEnum.DALA_BOSS_19px:
                    return new Sim_DALA_BOSS_19px();
                case CardDB.cardIDEnum.DALA_BOSS_68h:
                    return new Sim_DALA_BOSS_68h();
                case CardDB.cardIDEnum.DALA_BOSS_19h:
                    return new Sim_DALA_BOSS_19h();
                case CardDB.cardIDEnum.DALA_BOSS_54h:
                    return new Sim_DALA_BOSS_54h();
                case CardDB.cardIDEnum.DALA_BOSS_59t:
                    return new Sim_DALA_BOSS_59t();
                case CardDB.cardIDEnum.DALA_707:
                    return new Sim_DALA_707();
                case CardDB.cardIDEnum.DAL_357:
                    return new Sim_DAL_357();
                case CardDB.cardIDEnum.DALA_903e:
                    return new Sim_DALA_903e();
                case CardDB.cardIDEnum.DAL_366t3:
                    return new Sim_DAL_366t3();
                case CardDB.cardIDEnum.DAL_751:
                    return new Sim_DAL_751();
                case CardDB.cardIDEnum.DALA_BOSS_59h:
                    return new Sim_DALA_BOSS_59h();
                case CardDB.cardIDEnum.DAL_729:
                    return new Sim_DAL_729();
                case CardDB.cardIDEnum.DALA_BOSS_33p:
                    return new Sim_DALA_BOSS_33p();
                case CardDB.cardIDEnum.DALA_Mage_HPe:
                    return new Sim_DALA_Mage_HPe();
                case CardDB.cardIDEnum.DAL_773:
                    return new Sim_DAL_773();
                case CardDB.cardIDEnum.DAL_182:
                    return new Sim_DAL_182();
                case CardDB.cardIDEnum.DAL_608:
                    return new Sim_DAL_608();
                case CardDB.cardIDEnum.DALA_BOSS_43h:
                    return new Sim_DALA_BOSS_43h();
                case CardDB.cardIDEnum.DALA_BOSS_32p:
                    return new Sim_DALA_BOSS_32p();
                case CardDB.cardIDEnum.DALA_BOSS_29h:
                    return new Sim_DALA_BOSS_29h();
                case CardDB.cardIDEnum.DAL_603:
                    return new Sim_DAL_603();
                case CardDB.cardIDEnum.DALA_BOSS_05p:
                    return new Sim_DALA_BOSS_05p();
                case CardDB.cardIDEnum.DAL_748:
                    return new Sim_DAL_748();
                case CardDB.cardIDEnum.DALA_BOSS_66h:
                    return new Sim_DALA_BOSS_66h();
                case CardDB.cardIDEnum.DAL_371:
                    return new Sim_DAL_371();
                case CardDB.cardIDEnum.DAL_724:
                    return new Sim_DAL_724();
                case CardDB.cardIDEnum.DALA_726:
                    return new Sim_DALA_726();
                case CardDB.cardIDEnum.DALA_BOSS_27p:
                    return new Sim_DALA_BOSS_27p();
                case CardDB.cardIDEnum.DALA_833t3:
                    return new Sim_DALA_833t3();
                case CardDB.cardIDEnum.DALA_BOSS_68px:
                    return new Sim_DALA_BOSS_68px();
                case CardDB.cardIDEnum.DALA_Warrior_01:
                    return new Sim_DALA_Warrior_01();
                case CardDB.cardIDEnum.DALA_906e:
                    return new Sim_DALA_906e();
                case CardDB.cardIDEnum.DALA_BOSS_34p:
                    return new Sim_DALA_BOSS_34p();
                case CardDB.cardIDEnum.DAL_163:
                    return new Sim_DAL_163();
                case CardDB.cardIDEnum.DALA_BOSS_51h:
                    return new Sim_DALA_BOSS_51h();
                case CardDB.cardIDEnum.DALA_BOSS_68p:
                    return new Sim_DALA_BOSS_68p();
                case CardDB.cardIDEnum.DALA_Priest_11:
                    return new Sim_DALA_Priest_11();
                case CardDB.cardIDEnum.DALA_BOSS_10h:
                    return new Sim_DALA_BOSS_10h();
                case CardDB.cardIDEnum.DALA_BOSS_47t:
                    return new Sim_DALA_BOSS_47t();
                case CardDB.cardIDEnum.DALA_BOSS_15h:
                    return new Sim_DALA_BOSS_15h();
                case CardDB.cardIDEnum.DALA_BOSS_45h:
                    return new Sim_DALA_BOSS_45h();
                case CardDB.cardIDEnum.DALA_Chu:
                    return new Sim_DALA_Chu();
                case CardDB.cardIDEnum.DAL_052:
                    return new Sim_DAL_052();
                case CardDB.cardIDEnum.DAL_052e:
                    return new Sim_DAL_052e();
                case CardDB.cardIDEnum.DALA_Mage_01:
                    return new Sim_DALA_Mage_01();
                case CardDB.cardIDEnum.DALA_730:
                    return new Sim_DALA_730();
                case CardDB.cardIDEnum.DALA_Paladin_07:
                    return new Sim_DALA_Paladin_07();
                case CardDB.cardIDEnum.DALA_BOSS_75e2:
                    return new Sim_DALA_BOSS_75e2();
                case CardDB.cardIDEnum.DAL_071:
                    return new Sim_DAL_071();
                case CardDB.cardIDEnum.DAL_571e:
                    return new Sim_DAL_571e();
                case CardDB.cardIDEnum.DAL_571:
                    return new Sim_DAL_571();
                case CardDB.cardIDEnum.DALA_Druid_05:
                    return new Sim_DALA_Druid_05();
                case CardDB.cardIDEnum.DALA_854e2:
                    return new Sim_DALA_854e2();
                case CardDB.cardIDEnum.DAL_570:
                    return new Sim_DAL_570();
                case CardDB.cardIDEnum.DAL_570e:
                    return new Sim_DAL_570e();
                case CardDB.cardIDEnum.DALA_BOSS_66p:
                    return new Sim_DALA_BOSS_66p();
                case CardDB.cardIDEnum.DAL_377:
                    return new Sim_DAL_377();
                case CardDB.cardIDEnum.DALA_BOSS_32e1:
                    return new Sim_DALA_BOSS_32e1();
                case CardDB.cardIDEnum.DALA_BOSS_11h:
                    return new Sim_DALA_BOSS_11h();
                case CardDB.cardIDEnum.DAL_581:
                    return new Sim_DAL_581();
                case CardDB.cardIDEnum.DALA_BOSS_50h:
                    return new Sim_DALA_BOSS_50h();
                case CardDB.cardIDEnum.DALA_Druid_07:
                    return new Sim_DALA_Druid_07();
                case CardDB.cardIDEnum.DAL_376:
                    return new Sim_DAL_376();
                case CardDB.cardIDEnum.DALA_861e2:
                    return new Sim_DALA_861e2();
                case CardDB.cardIDEnum.DALA_Barkeye:
                    return new Sim_DALA_Barkeye();
                case CardDB.cardIDEnum.DALA_BOSS_37h:
                    return new Sim_DALA_BOSS_37h();
                case CardDB.cardIDEnum.DALA_Priest_06:
                    return new Sim_DALA_Priest_06();
                case CardDB.cardIDEnum.DAL_770:
                    return new Sim_DAL_770();
                case CardDB.cardIDEnum.DAL_752e2:
                    return new Sim_DAL_752e2();
                case CardDB.cardIDEnum.DALA_BOSS_04p:
                    return new Sim_DALA_BOSS_04p();
                case CardDB.cardIDEnum.DALA_Hunter_HP1:
                    return new Sim_DALA_Hunter_HP1();
                case CardDB.cardIDEnum.DALA_Hunter_HP1e:
                    return new Sim_DALA_Hunter_HP1e();
                case CardDB.cardIDEnum.DALA_712:
                    return new Sim_DALA_712();
                case CardDB.cardIDEnum.DALA_BOSS_14p:
                    return new Sim_DALA_BOSS_14p();
                case CardDB.cardIDEnum.DALA_BOSS_14px:
                    return new Sim_DALA_BOSS_14px();
                case CardDB.cardIDEnum.DALA_Shaman_04:
                    return new Sim_DALA_Shaman_04();
                case CardDB.cardIDEnum.DALA_715:
                    return new Sim_DALA_715();
                case CardDB.cardIDEnum.DALA_715e:
                    return new Sim_DALA_715e();
                case CardDB.cardIDEnum.DALA_Hunter_09:
                    return new Sim_DALA_Hunter_09();
                case CardDB.cardIDEnum.DALA_BOSS_40h:
                    return new Sim_DALA_BOSS_40h();
                case CardDB.cardIDEnum.DALA_Warlock_05:
                    return new Sim_DALA_Warlock_05();
                case CardDB.cardIDEnum.DALA_Warlock_HP1:
                    return new Sim_DALA_Warlock_HP1();
                case CardDB.cardIDEnum.DALA_Paladin_HPe:
                    return new Sim_DALA_Paladin_HPe();
                case CardDB.cardIDEnum.DALA_BOSS_38t:
                    return new Sim_DALA_BOSS_38t();
                case CardDB.cardIDEnum.DALA_BOSS_59e:
                    return new Sim_DALA_BOSS_59e();
                case CardDB.cardIDEnum.DALA_Hunter_HP2:
                    return new Sim_DALA_Hunter_HP2();
                case CardDB.cardIDEnum.DALA_BOSS_61t:
                    return new Sim_DALA_BOSS_61t();
                case CardDB.cardIDEnum.DAL_350a:
                    return new Sim_DAL_350a();
                case CardDB.cardIDEnum.DALA_Priest_07:
                    return new Sim_DALA_Priest_07();
                case CardDB.cardIDEnum.DAL_095e:
                    return new Sim_DAL_095e();
                case CardDB.cardIDEnum.DAL_602:
                    return new Sim_DAL_602();
                case CardDB.cardIDEnum.DALA_BOSS_42h:
                    return new Sim_DALA_BOSS_42h();
                case CardDB.cardIDEnum.DALA_BOSS_42p:
                    return new Sim_DALA_BOSS_42p();
                case CardDB.cardIDEnum.DALA_BOSS_42px:
                    return new Sim_DALA_BOSS_42px();
                case CardDB.cardIDEnum.DALA_854e3:
                    return new Sim_DALA_854e3();
                case CardDB.cardIDEnum.DAL_582:
                    return new Sim_DAL_582();
                case CardDB.cardIDEnum.DAL_565:
                    return new Sim_DAL_565();
                case CardDB.cardIDEnum.DALA_BOSS_38p:
                    return new Sim_DALA_BOSS_38p();
                case CardDB.cardIDEnum.DALA_BOSS_38px:
                    return new Sim_DALA_BOSS_38px();
                case CardDB.cardIDEnum.DAL_544:
                    return new Sim_DAL_544();
                case CardDB.cardIDEnum.DAL_578:
                    return new Sim_DAL_578();
                case CardDB.cardIDEnum.DAL_563e:
                    return new Sim_DAL_563e();
                case CardDB.cardIDEnum.DALA_Mage_04:
                    return new Sim_DALA_Mage_04();
                case CardDB.cardIDEnum.DALA_BOSS_21p:
                    return new Sim_DALA_BOSS_21p();
                case CardDB.cardIDEnum.DALA_BOSS_03p:
                    return new Sim_DALA_BOSS_03p();
                case CardDB.cardIDEnum.DALA_BOSS_03px:
                    return new Sim_DALA_BOSS_03px();
                case CardDB.cardIDEnum.DALA_BOSS_03t3:
                    return new Sim_DALA_BOSS_03t3();
                case CardDB.cardIDEnum.DALA_BOSS_03t3e:
                    return new Sim_DALA_BOSS_03t3e();
                case CardDB.cardIDEnum.DALA_Priest_HPe:
                    return new Sim_DALA_Priest_HPe();
                case CardDB.cardIDEnum.DALA_Hunter_10:
                    return new Sim_DALA_Hunter_10();
                case CardDB.cardIDEnum.DAL_560e2:
                    return new Sim_DAL_560e2();
                case CardDB.cardIDEnum.DALA_BOSS_46p:
                    return new Sim_DALA_BOSS_46p();
                case CardDB.cardIDEnum.DALA_BOSS_46px:
                    return new Sim_DALA_BOSS_46px();
                case CardDB.cardIDEnum.DALA_Druid_09:
                    return new Sim_DALA_Druid_09();
                case CardDB.cardIDEnum.DALA_Paladin_10:
                    return new Sim_DALA_Paladin_10();
                case CardDB.cardIDEnum.DAL_551:
                    return new Sim_DAL_551();
                case CardDB.cardIDEnum.DALA_BOSS_56h:
                    return new Sim_DALA_BOSS_56h();
                case CardDB.cardIDEnum.DAL_007:
                    return new Sim_DAL_007();
                case CardDB.cardIDEnum.DALA_BOSS_55p:
                    return new Sim_DALA_BOSS_55p();
                case CardDB.cardIDEnum.DALA_BOSS_55px:
                    return new Sim_DALA_BOSS_55px();
                case CardDB.cardIDEnum.DALA_Rakanishu:
                    return new Sim_DALA_Rakanishu();
                case CardDB.cardIDEnum.DALA_801:
                    return new Sim_DALA_801();
                case CardDB.cardIDEnum.DALA_802:
                    return new Sim_DALA_802();
                case CardDB.cardIDEnum.DALA_800:
                    return new Sim_DALA_800();
                case CardDB.cardIDEnum.DALA_803:
                    return new Sim_DALA_803();
                case CardDB.cardIDEnum.DALA_804:
                    return new Sim_DALA_804();
                case CardDB.cardIDEnum.DALA_805:
                    return new Sim_DALA_805();
                case CardDB.cardIDEnum.DALA_806:
                    return new Sim_DALA_806();
                case CardDB.cardIDEnum.DALA_807:
                    return new Sim_DALA_807();
                case CardDB.cardIDEnum.DALA_808:
                    return new Sim_DALA_808();
                case CardDB.cardIDEnum.DALA_BOSS_24h:
                    return new Sim_DALA_BOSS_24h();
                case CardDB.cardIDEnum.DAL_373:
                    return new Sim_DAL_373();
                case CardDB.cardIDEnum.DAL_373ts:
                    return new Sim_DAL_373ts();
                case CardDB.cardIDEnum.DALA_BOSS_27h:
                    return new Sim_DALA_BOSS_27h();
                case CardDB.cardIDEnum.DAL_577:
                    return new Sim_DAL_577();
                case CardDB.cardIDEnum.DAL_577ts:
                    return new Sim_DAL_577ts();
                case CardDB.cardIDEnum.DALA_BOSS_45p:
                    return new Sim_DALA_BOSS_45p();
                case CardDB.cardIDEnum.DALA_BOSS_45px:
                    return new Sim_DALA_BOSS_45px();
                case CardDB.cardIDEnum.DAL_070e:
                    return new Sim_DAL_070e();
                case CardDB.cardIDEnum.DALA_Druid_02:
                    return new Sim_DALA_Druid_02();
                case CardDB.cardIDEnum.DALA_901:
                    return new Sim_DALA_901();
                case CardDB.cardIDEnum.DALA_907:
                    return new Sim_DALA_907();
                case CardDB.cardIDEnum.DAL_366t2:
                    return new Sim_DAL_366t2();
                case CardDB.cardIDEnum.DAL_749:
                    return new Sim_DAL_749();
                case CardDB.cardIDEnum.DALA_728:
                    return new Sim_DALA_728();
                case CardDB.cardIDEnum.DALA_728d:
                    return new Sim_DALA_728d();
                case CardDB.cardIDEnum.DALA_728e:
                    return new Sim_DALA_728e();
                case CardDB.cardIDEnum.DALA_BOSS_03t:
                    return new Sim_DALA_BOSS_03t();
                case CardDB.cardIDEnum.DALA_BOSS_03e:
                    return new Sim_DALA_BOSS_03e();
                case CardDB.cardIDEnum.DALA_Shaman_HP2:
                    return new Sim_DALA_Shaman_HP2();
                case CardDB.cardIDEnum.DALA_Shaman_10:
                    return new Sim_DALA_Shaman_10();
                case CardDB.cardIDEnum.DALA_BOSS_09p:
                    return new Sim_DALA_BOSS_09p();
                case CardDB.cardIDEnum.DALA_BOSS_09px:
                    return new Sim_DALA_BOSS_09px();
                case CardDB.cardIDEnum.DALA_737:
                    return new Sim_DALA_737();
                case CardDB.cardIDEnum.DALA_502e:
                    return new Sim_DALA_502e();
                case CardDB.cardIDEnum.DALA_905:
                    return new Sim_DALA_905();
                case CardDB.cardIDEnum.DALA_905e:
                    return new Sim_DALA_905e();
                case CardDB.cardIDEnum.DALA_BOSS_56t:
                    return new Sim_DALA_BOSS_56t();
                case CardDB.cardIDEnum.DALA_Druid_08:
                    return new Sim_DALA_Druid_08();
                case CardDB.cardIDEnum.DALA_735:
                    return new Sim_DALA_735();
                case CardDB.cardIDEnum.DALA_735e2:
                    return new Sim_DALA_735e2();
                case CardDB.cardIDEnum.DALA_735e:
                    return new Sim_DALA_735e();
                case CardDB.cardIDEnum.DALA_Paladin_08:
                    return new Sim_DALA_Paladin_08();
                case CardDB.cardIDEnum.DALA_731e2:
                    return new Sim_DALA_731e2();
                case CardDB.cardIDEnum.DALA_731:
                    return new Sim_DALA_731();
                case CardDB.cardIDEnum.DALA_731e:
                    return new Sim_DALA_731e();
                case CardDB.cardIDEnum.DALA_Rogue_HPe:
                    return new Sim_DALA_Rogue_HPe();
                case CardDB.cardIDEnum.DALA_741e2:
                    return new Sim_DALA_741e2();
                case CardDB.cardIDEnum.DALA_906:
                    return new Sim_DALA_906();
                case CardDB.cardIDEnum.DALA_Warrior_05:
                    return new Sim_DALA_Warrior_05();
                case CardDB.cardIDEnum.DALA_Warlock_04:
                    return new Sim_DALA_Warlock_04();
                case CardDB.cardIDEnum.DALA_BOSS_61h:
                    return new Sim_DALA_BOSS_61h();
                case CardDB.cardIDEnum.DAL_088:
                    return new Sim_DAL_088();
                case CardDB.cardIDEnum.DALA_BOSS_50p:
                    return new Sim_DALA_BOSS_50p();
                case CardDB.cardIDEnum.DALA_BOSS_50px:
                    return new Sim_DALA_BOSS_50px();
                case CardDB.cardIDEnum.DALA_BOSS_28e:
                    return new Sim_DALA_BOSS_28e();
                case CardDB.cardIDEnum.DALA_Rogue_07:
                    return new Sim_DALA_Rogue_07();
                case CardDB.cardIDEnum.DAL_726:
                    return new Sim_DAL_726();
                case CardDB.cardIDEnum.DAL_726e:
                    return new Sim_DAL_726e();
                case CardDB.cardIDEnum.DALA_707e:
                    return new Sim_DALA_707e();
                case CardDB.cardIDEnum.DALA_BOSS_06dk:
                    return new Sim_DALA_BOSS_06dk();
                case CardDB.cardIDEnum.DALA_BOSS_28p:
                    return new Sim_DALA_BOSS_28p();
                case CardDB.cardIDEnum.DALA_Paladin_01:
                    return new Sim_DALA_Paladin_01();
                case CardDB.cardIDEnum.DALA_Hunter_02:
                    return new Sim_DALA_Hunter_02();
                case CardDB.cardIDEnum.DALA_727e:
                    return new Sim_DALA_727e();
                case CardDB.cardIDEnum.DAL_030e:
                    return new Sim_DAL_030e();
                case CardDB.cardIDEnum.DALA_Priest_04:
                    return new Sim_DALA_Priest_04();
                case CardDB.cardIDEnum.DAL_030:
                    return new Sim_DAL_030();
                case CardDB.cardIDEnum.DALA_Shaman_HPe:
                    return new Sim_DALA_Shaman_HPe();
                case CardDB.cardIDEnum.DALA_BOSS_23p:
                    return new Sim_DALA_BOSS_23p();
                case CardDB.cardIDEnum.DALA_BOSS_23px:
                    return new Sim_DALA_BOSS_23px();
                case CardDB.cardIDEnum.DALA_BOSS_23h:
                    return new Sim_DALA_BOSS_23h();
                case CardDB.cardIDEnum.DALA_BOSS_22p:
                    return new Sim_DALA_BOSS_22p();
                case CardDB.cardIDEnum.DALA_BOSS_22px:
                    return new Sim_DALA_BOSS_22px();
                case CardDB.cardIDEnum.DALA_Hunter_HP2e:
                    return new Sim_DALA_Hunter_HP2e();
                case CardDB.cardIDEnum.DALA_Hunter_HP2t:
                    return new Sim_DALA_Hunter_HP2t();
                case CardDB.cardIDEnum.DALA_Shaman_11:
                    return new Sim_DALA_Shaman_11();
                case CardDB.cardIDEnum.DAL_587:
                    return new Sim_DAL_587();
                case CardDB.cardIDEnum.DAL_739e:
                    return new Sim_DAL_739e();
                case CardDB.cardIDEnum.DALA_BOSS_22ex:
                    return new Sim_DALA_BOSS_22ex();
                case CardDB.cardIDEnum.DALA_701e:
                    return new Sim_DALA_701e();
                case CardDB.cardIDEnum.DALA_BOSS_70h:
                    return new Sim_DALA_BOSS_70h();
                case CardDB.cardIDEnum.DALA_743e:
                    return new Sim_DALA_743e();
                case CardDB.cardIDEnum.DALA_BOSS_13p:
                    return new Sim_DALA_BOSS_13p();
                case CardDB.cardIDEnum.DAL_433:
                    return new Sim_DAL_433();
                case CardDB.cardIDEnum.DALA_Paladin_02:
                    return new Sim_DALA_Paladin_02();
                case CardDB.cardIDEnum.DAL_771:
                    return new Sim_DAL_771();
                case CardDB.cardIDEnum.DALA_Priest_HP2:
                    return new Sim_DALA_Priest_HP2();
                case CardDB.cardIDEnum.DALA_Priest_HP2e:
                    return new Sim_DALA_Priest_HP2e();
                case CardDB.cardIDEnum.DALA_BOSS_35h:
                    return new Sim_DALA_BOSS_35h();
                case CardDB.cardIDEnum.DAL_710:
                    return new Sim_DAL_710();
                case CardDB.cardIDEnum.DAL_710e:
                    return new Sim_DAL_710e();
                case CardDB.cardIDEnum.DALA_BOSS_74p:
                    return new Sim_DALA_BOSS_74p();
                case CardDB.cardIDEnum.DALA_BOSS_74px:
                    return new Sim_DALA_BOSS_74px();
                case CardDB.cardIDEnum.DALA_719:
                    return new Sim_DALA_719();
                case CardDB.cardIDEnum.DALA_727:
                    return new Sim_DALA_727();
                case CardDB.cardIDEnum.DAL_081e:
                    return new Sim_DAL_081e();
                case CardDB.cardIDEnum.DALA_BOSS_54p:
                    return new Sim_DALA_BOSS_54p();
                case CardDB.cardIDEnum.DAL_089:
                    return new Sim_DAL_089();
                case CardDB.cardIDEnum.DALA_Hunter_01:
                    return new Sim_DALA_Hunter_01();
                case CardDB.cardIDEnum.DALA_Rogue_11:
                    return new Sim_DALA_Rogue_11();
                case CardDB.cardIDEnum.DAL_081:
                    return new Sim_DAL_081();
                case CardDB.cardIDEnum.DAL_357t:
                    return new Sim_DAL_357t();
                case CardDB.cardIDEnum.DALA_Shaman_02:
                    return new Sim_DALA_Shaman_02();
                case CardDB.cardIDEnum.DALA_Squeamlish:
                    return new Sim_DALA_Squeamlish();
                case CardDB.cardIDEnum.DAL_354t:
                    return new Sim_DAL_354t();
                case CardDB.cardIDEnum.DALA_Shaman_08:
                    return new Sim_DALA_Shaman_08();
                case CardDB.cardIDEnum.DALA_736:
                    return new Sim_DALA_736();
                case CardDB.cardIDEnum.DALA_736e:
                    return new Sim_DALA_736e();
                case CardDB.cardIDEnum.DAL_379e:
                    return new Sim_DAL_379e();
                case CardDB.cardIDEnum.DALA_BOSS_72p:
                    return new Sim_DALA_BOSS_72p();
                case CardDB.cardIDEnum.DALA_831e2:
                    return new Sim_DALA_831e2();
                case CardDB.cardIDEnum.DAL_086e:
                    return new Sim_DAL_086e();
                case CardDB.cardIDEnum.DALA_908e:
                    return new Sim_DALA_908e();
                case CardDB.cardIDEnum.DALA_BOSS_20p:
                    return new Sim_DALA_BOSS_20p();
                case CardDB.cardIDEnum.DALA_BOSS_20px:
                    return new Sim_DALA_BOSS_20px();
                case CardDB.cardIDEnum.DAL_714e:
                    return new Sim_DAL_714e();
                case CardDB.cardIDEnum.DALA_BOSS_10p:
                    return new Sim_DALA_BOSS_10p();
                case CardDB.cardIDEnum.DALA_BOSS_10px:
                    return new Sim_DALA_BOSS_10px();
                case CardDB.cardIDEnum.DALA_Priest_10:
                    return new Sim_DALA_Priest_10();
                case CardDB.cardIDEnum.DALA_BOSS_41p:
                    return new Sim_DALA_BOSS_41p();
                case CardDB.cardIDEnum.DALA_BOSS_41px:
                    return new Sim_DALA_BOSS_41px();
                case CardDB.cardIDEnum.DALA_BOSS_60p:
                    return new Sim_DALA_BOSS_60p();
                case CardDB.cardIDEnum.DALA_BOSS_60px:
                    return new Sim_DALA_BOSS_60px();
                case CardDB.cardIDEnum.DALA_BOSS_71p:
                    return new Sim_DALA_BOSS_71p();
                case CardDB.cardIDEnum.DALA_BOSS_71px:
                    return new Sim_DALA_BOSS_71px();
                case CardDB.cardIDEnum.DALA_Mage_03:
                    return new Sim_DALA_Mage_03();
                case CardDB.cardIDEnum.DAL_086:
                    return new Sim_DAL_086();
                case CardDB.cardIDEnum.DAL_539:
                    return new Sim_DAL_539();
                case CardDB.cardIDEnum.DALA_704:
                    return new Sim_DALA_704();
                case CardDB.cardIDEnum.DAL_431:
                    return new Sim_DAL_431();
                case CardDB.cardIDEnum.DALA_720:
                    return new Sim_DALA_720();
                case CardDB.cardIDEnum.DALA_Druid_01:
                    return new Sim_DALA_Druid_01();
                case CardDB.cardIDEnum.DALA_Warlock_02:
                    return new Sim_DALA_Warlock_02();
                case CardDB.cardIDEnum.DAL_062:
                    return new Sim_DAL_062();
                case CardDB.cardIDEnum.DAL_062e:
                    return new Sim_DAL_062e();
                case CardDB.cardIDEnum.DAL_719:
                    return new Sim_DAL_719();
                case CardDB.cardIDEnum.DALA_903:
                    return new Sim_DALA_903();
                case CardDB.cardIDEnum.DALA_BOSS_07p:
                    return new Sim_DALA_BOSS_07p();
                case CardDB.cardIDEnum.DALA_BOSS_17h:
                    return new Sim_DALA_BOSS_17h();
                case CardDB.cardIDEnum.DALA_BOSS_37p:
                    return new Sim_DALA_BOSS_37p();
                case CardDB.cardIDEnum.DALA_BOSS_37px:
                    return new Sim_DALA_BOSS_37px();
                case CardDB.cardIDEnum.DALA_913:
                    return new Sim_DALA_913();
                case CardDB.cardIDEnum.DALA_BOSS_06px:
                    return new Sim_DALA_BOSS_06px();
                case CardDB.cardIDEnum.DALA_Warrior_11:
                    return new Sim_DALA_Warrior_11();
                case CardDB.cardIDEnum.DALA_Hunter_04:
                    return new Sim_DALA_Hunter_04();
                case CardDB.cardIDEnum.DALA_Mage_08:
                    return new Sim_DALA_Mage_08();
                case CardDB.cardIDEnum.DALA_Tekahn:
                    return new Sim_DALA_Tekahn();
                case CardDB.cardIDEnum.DALA_908:
                    return new Sim_DALA_908();
                case CardDB.cardIDEnum.DALA_BOSS_05h:
                    return new Sim_DALA_BOSS_05h();
                case CardDB.cardIDEnum.DAL_070:
                    return new Sim_DAL_070();
                case CardDB.cardIDEnum.DALA_701:
                    return new Sim_DALA_701();
                case CardDB.cardIDEnum.DALA_714:
                    return new Sim_DALA_714();
                case CardDB.cardIDEnum.DALA_714a:
                    return new Sim_DALA_714a();
                case CardDB.cardIDEnum.DALA_714b:
                    return new Sim_DALA_714b();
                case CardDB.cardIDEnum.DALA_714c:
                    return new Sim_DALA_714c();
                case CardDB.cardIDEnum.DALA_BOSS_02p:
                    return new Sim_DALA_BOSS_02p();
                case CardDB.cardIDEnum.DALA_BOSS_02px:
                    return new Sim_DALA_BOSS_02px();
                case CardDB.cardIDEnum.DAL_256:
                    return new Sim_DAL_256();
                case CardDB.cardIDEnum.DAL_256ts:
                    return new Sim_DAL_256ts();
                case CardDB.cardIDEnum.DALA_910:
                    return new Sim_DALA_910();
                case CardDB.cardIDEnum.DALA_BOSS_03h:
                    return new Sim_DALA_BOSS_03h();
                case CardDB.cardIDEnum.DALA_745:
                    return new Sim_DALA_745();
                case CardDB.cardIDEnum.DALA_703:
                    return new Sim_DALA_703();
                case CardDB.cardIDEnum.DALA_BOSS_58t2:
                    return new Sim_DALA_BOSS_58t2();
                case CardDB.cardIDEnum.DALA_Warlock_HP2:
                    return new Sim_DALA_Warlock_HP2();
                case CardDB.cardIDEnum.DALA_BOSS_30h:
                    return new Sim_DALA_BOSS_30h();
                case CardDB.cardIDEnum.DALA_Paladin_09:
                    return new Sim_DALA_Paladin_09();
                case CardDB.cardIDEnum.DALA_914:
                    return new Sim_DALA_914();
                case CardDB.cardIDEnum.DALA_914e:
                    return new Sim_DALA_914e();
                case CardDB.cardIDEnum.DALA_BOSS_58t:
                    return new Sim_DALA_BOSS_58t();
                case CardDB.cardIDEnum.DALA_Rogue_02:
                    return new Sim_DALA_Rogue_02();
                case CardDB.cardIDEnum.DAL_379t:
                    return new Sim_DAL_379t();
                case CardDB.cardIDEnum.DALA_BOSS_51t2:
                    return new Sim_DALA_BOSS_51t2();
                case CardDB.cardIDEnum.DALA_BOSS_14h:
                    return new Sim_DALA_BOSS_14h();
                case CardDB.cardIDEnum.DALA_BOSS_31h:
                    return new Sim_DALA_BOSS_31h();
                case CardDB.cardIDEnum.DALA_BOSS_51p:
                    return new Sim_DALA_BOSS_51p();
                case CardDB.cardIDEnum.DALA_Hunter_06:
                    return new Sim_DALA_Hunter_06();
                case CardDB.cardIDEnum.DALA_BOSS_38h:
                    return new Sim_DALA_BOSS_38h();
                case CardDB.cardIDEnum.DALA_BOSS_48p:
                    return new Sim_DALA_BOSS_48p();
                case CardDB.cardIDEnum.DALA_741:
                    return new Sim_DALA_741();
                case CardDB.cardIDEnum.DALA_741e:
                    return new Sim_DALA_741e();
                case CardDB.cardIDEnum.DAL_010:
                    return new Sim_DAL_010();
                case CardDB.cardIDEnum.DALA_735e3:
                    return new Sim_DALA_735e3();
                case CardDB.cardIDEnum.DALA_702e:
                    return new Sim_DALA_702e();
                case CardDB.cardIDEnum.DALA_BOSS_18p:
                    return new Sim_DALA_BOSS_18p();
                case CardDB.cardIDEnum.DALA_BOSS_18px:
                    return new Sim_DALA_BOSS_18px();
                case CardDB.cardIDEnum.DALA_Druid_HP2:
                    return new Sim_DALA_Druid_HP2();
                case CardDB.cardIDEnum.DAL_077:
                    return new Sim_DAL_077();
                case CardDB.cardIDEnum.DAL_077e:
                    return new Sim_DAL_077e();
                case CardDB.cardIDEnum.DALA_BOSS_25e:
                    return new Sim_DALA_BOSS_25e();
                case CardDB.cardIDEnum.DAL_752e:
                    return new Sim_DAL_752e();
                case CardDB.cardIDEnum.DALA_BOSS_57e:
                    return new Sim_DALA_BOSS_57e();
                case CardDB.cardIDEnum.DALA_BOSS_57h:
                    return new Sim_DALA_BOSS_57h();
                case CardDB.cardIDEnum.DALA_Mage_10:
                    return new Sim_DALA_Mage_10();
                case CardDB.cardIDEnum.DAL_078:
                    return new Sim_DAL_078();
                case CardDB.cardIDEnum.DAL_256t2:
                    return new Sim_DAL_256t2();
                case CardDB.cardIDEnum.DALA_Rogue_03:
                    return new Sim_DALA_Rogue_03();
                case CardDB.cardIDEnum.DAL_775:
                    return new Sim_DAL_775();
                case CardDB.cardIDEnum.DAL_366t4:
                    return new Sim_DAL_366t4();
                case CardDB.cardIDEnum.DALA_BOSS_75e3:
                    return new Sim_DALA_BOSS_75e3();
                case CardDB.cardIDEnum.DALA_BOSS_17p:
                    return new Sim_DALA_BOSS_17p();
                case CardDB.cardIDEnum.DALA_833:
                    return new Sim_DALA_833();
                case CardDB.cardIDEnum.DALA_829:
                    return new Sim_DALA_829();
                case CardDB.cardIDEnum.DALA_830:
                    return new Sim_DALA_830();
                case CardDB.cardIDEnum.DALA_832:
                    return new Sim_DALA_832();
                case CardDB.cardIDEnum.DALA_831:
                    return new Sim_DALA_831();
                case CardDB.cardIDEnum.DALA_Priest_09:
                    return new Sim_DALA_Priest_09();
                case CardDB.cardIDEnum.DALA_BOSS_49p:
                    return new Sim_DALA_BOSS_49p();
                case CardDB.cardIDEnum.DALA_BOSS_49px:
                    return new Sim_DALA_BOSS_49px();
                case CardDB.cardIDEnum.DAL_049:
                    return new Sim_DAL_049();
                case CardDB.cardIDEnum.DAL_714:
                    return new Sim_DAL_714();
                case CardDB.cardIDEnum.DAL_550:
                    return new Sim_DAL_550();
                case CardDB.cardIDEnum.DALA_BOSS_30t:
                    return new Sim_DALA_BOSS_30t();
                case CardDB.cardIDEnum.DALA_Warrior_HP2:
                    return new Sim_DALA_Warrior_HP2();
                case CardDB.cardIDEnum.DALA_831e:
                    return new Sim_DALA_831e();
                case CardDB.cardIDEnum.DALA_BOSS_41h:
                    return new Sim_DALA_BOSS_41h();
                case CardDB.cardIDEnum.DAL_366:
                    return new Sim_DAL_366();
                case CardDB.cardIDEnum.DAL_378:
                    return new Sim_DAL_378();
                case CardDB.cardIDEnum.DAL_378ts:
                    return new Sim_DAL_378ts();
                case CardDB.cardIDEnum.DAL_538:
                    return new Sim_DAL_538();
                case CardDB.cardIDEnum.DAL_065:
                    return new Sim_DAL_065();
                case CardDB.cardIDEnum.DALA_708:
                    return new Sim_DALA_708();
                case CardDB.cardIDEnum.DAL_604:
                    return new Sim_DAL_604();
                case CardDB.cardIDEnum.DALA_BOSS_65h:
                    return new Sim_DALA_BOSS_65h();
                case CardDB.cardIDEnum.DALA_BOSS_20h:
                    return new Sim_DALA_BOSS_20h();
                case CardDB.cardIDEnum.DAL_088t2:
                    return new Sim_DAL_088t2();
                case CardDB.cardIDEnum.DAL_716:
                    return new Sim_DAL_716();
                case CardDB.cardIDEnum.DAL_566t:
                    return new Sim_DAL_566t();
                case CardDB.cardIDEnum.DAL_379:
                    return new Sim_DAL_379();
                case CardDB.cardIDEnum.DALA_Vessina:
                    return new Sim_DALA_Vessina();
                case CardDB.cardIDEnum.DAL_759:
                    return new Sim_DAL_759();
                case CardDB.cardIDEnum.DALA_832t:
                    return new Sim_DALA_832t();
                case CardDB.cardIDEnum.DAL_095:
                    return new Sim_DAL_095();
                case CardDB.cardIDEnum.DAL_096:
                    return new Sim_DAL_096();
                case CardDB.cardIDEnum.DALA_BOSS_48t:
                    return new Sim_DALA_BOSS_48t();
                case CardDB.cardIDEnum.DALA_BOSS_48e:
                    return new Sim_DALA_BOSS_48e();
                case CardDB.cardIDEnum.DAL_720:
                    return new Sim_DAL_720();
                case CardDB.cardIDEnum.DAL_047:
                    return new Sim_DAL_047();
                case CardDB.cardIDEnum.DALA_Warlock_HPe:
                    return new Sim_DALA_Warlock_HPe();
                case CardDB.cardIDEnum.DALA_Warrior_HPe:
                    return new Sim_DALA_Warrior_HPe();
                case CardDB.cardIDEnum.DALA_BOSS_61p:
                    return new Sim_DALA_BOSS_61p();
                case CardDB.cardIDEnum.DALA_Priest_05:
                    return new Sim_DALA_Priest_05();
                case CardDB.cardIDEnum.DAL_742e:
                    return new Sim_DAL_742e();
                case CardDB.cardIDEnum.DAL_742:
                    return new Sim_DAL_742();
                case CardDB.cardIDEnum.DALA_BOSS_21h:
                    return new Sim_DALA_BOSS_21h();
                case CardDB.cardIDEnum.DALA_BOSS_58e2:
                    return new Sim_DALA_BOSS_58e2();
                case CardDB.cardIDEnum.DAL_432:
                    return new Sim_DAL_432();
                case CardDB.cardIDEnum.DAL_615:
                    return new Sim_DAL_615();
                case CardDB.cardIDEnum.DALA_Mage_HP1e:
                    return new Sim_DALA_Mage_HP1e();
                case CardDB.cardIDEnum.DALA_740:
                    return new Sim_DALA_740();
                case CardDB.cardIDEnum.DALA_740ts:
                    return new Sim_DALA_740ts();
                case CardDB.cardIDEnum.DALA_740ts2:
                    return new Sim_DALA_740ts2();
                case CardDB.cardIDEnum.DALA_740e3:
                    return new Sim_DALA_740e3();
                case CardDB.cardIDEnum.DALA_740ts3:
                    return new Sim_DALA_740ts3();
                case CardDB.cardIDEnum.DALA_740e2:
                    return new Sim_DALA_740e2();
                case CardDB.cardIDEnum.DALA_740e:
                    return new Sim_DALA_740e();
                case CardDB.cardIDEnum.DALA_740ts4:
                    return new Sim_DALA_740ts4();
                case CardDB.cardIDEnum.DALA_740ts5:
                    return new Sim_DALA_740ts5();
                case CardDB.cardIDEnum.DAL_063:
                    return new Sim_DAL_063();
                case CardDB.cardIDEnum.DAL_378t1:
                    return new Sim_DAL_378t1();
                case CardDB.cardIDEnum.DALA_BOSS_28h:
                    return new Sim_DALA_BOSS_28h();
                case CardDB.cardIDEnum.DALA_BOSS_03t4:
                    return new Sim_DALA_BOSS_03t4();
                case CardDB.cardIDEnum.DALA_Rogue_HP1:
                    return new Sim_DALA_Rogue_HP1();
                case CardDB.cardIDEnum.DALA_909:
                    return new Sim_DALA_909();
                case CardDB.cardIDEnum.DAL_800:
                    return new Sim_DAL_800();
                case CardDB.cardIDEnum.DAL_800h:
                    return new Sim_DAL_800h();
                case CardDB.cardIDEnum.DALA_BOSS_48h:
                    return new Sim_DALA_BOSS_48h();
 ///case CardDB.cardIDEnum.///NAXX:
                    ///return new Sim_///NAXX();
                case CardDB.cardIDEnum.FP1_026:
                    return new Sim_FP1_026();
                case CardDB.cardIDEnum.NAX1_01:
                    return new Sim_NAX1_01();
                case CardDB.cardIDEnum.NAX1h_01:
                    return new Sim_NAX1h_01();
                case CardDB.cardIDEnum.FP1_020:
                    return new Sim_FP1_020();
                case CardDB.cardIDEnum.FP1_031:
                    return new Sim_FP1_031();
                case CardDB.cardIDEnum.NAX9_01:
                    return new Sim_NAX9_01();
                case CardDB.cardIDEnum.NAX9_01H:
                    return new Sim_NAX9_01H();
                case CardDB.cardIDEnum.NAX15_04:
                    return new Sim_NAX15_04();
                case CardDB.cardIDEnum.NAX15_04H:
                    return new Sim_NAX15_04H();
                case CardDB.cardIDEnum.FP1_005e:
                    return new Sim_FP1_005e();
                case CardDB.cardIDEnum.FP1_029:
                    return new Sim_FP1_029();
                case CardDB.cardIDEnum.FP1_023:
                    return new Sim_FP1_023();
                case CardDB.cardIDEnum.FP1_028e:
                    return new Sim_FP1_028e();
                case CardDB.cardIDEnum.NAX6_03:
                    return new Sim_NAX6_03();
                case CardDB.cardIDEnum.FP1_006:
                    return new Sim_FP1_006();
                case CardDB.cardIDEnum.FP1_009:
                    return new Sim_FP1_009();
                case CardDB.cardIDEnum.FP1_021:
                    return new Sim_FP1_021();
                case CardDB.cardIDEnum.NAX12_02:
                    return new Sim_NAX12_02();
                case CardDB.cardIDEnum.NAX12_02e:
                    return new Sim_NAX12_02e();
                case CardDB.cardIDEnum.NAX12_02H:
                    return new Sim_NAX12_02H();
                case CardDB.cardIDEnum.FP1_018:
                    return new Sim_FP1_018();
                case CardDB.cardIDEnum.FP1_003:
                    return new Sim_FP1_003();
                case CardDB.cardIDEnum.NAX12_04:
                    return new Sim_NAX12_04();
                case CardDB.cardIDEnum.NAX12_04e:
                    return new Sim_NAX12_04e();
                case CardDB.cardIDEnum.NAX5_02:
                    return new Sim_NAX5_02();
                case CardDB.cardIDEnum.NAX5_02H:
                    return new Sim_NAX5_02H();
                case CardDB.cardIDEnum.NAX12_03e:
                    return new Sim_NAX12_03e();
                case CardDB.cardIDEnum.NAX11_03:
                    return new Sim_NAX11_03();
                case CardDB.cardIDEnum.FP1_015:
                    return new Sim_FP1_015();
                case CardDB.cardIDEnum.NAX13_04H:
                    return new Sim_NAX13_04H();
                case CardDB.cardIDEnum.NAX15_02:
                    return new Sim_NAX15_02();
                case CardDB.cardIDEnum.NAX15_02H:
                    return new Sim_NAX15_02H();
                case CardDB.cardIDEnum.NAX14_02:
                    return new Sim_NAX14_02();
                case CardDB.cardIDEnum.NAX14_03:
                    return new Sim_NAX14_03();
                case CardDB.cardIDEnum.NAX6_03te:
                    return new Sim_NAX6_03te();
                case CardDB.cardIDEnum.NAX12_01:
                    return new Sim_NAX12_01();
                case CardDB.cardIDEnum.NAX12_01H:
                    return new Sim_NAX12_01H();
                case CardDB.cardIDEnum.NAX8_01:
                    return new Sim_NAX8_01();
                case CardDB.cardIDEnum.NAX8_01H:
                    return new Sim_NAX8_01H();
                case CardDB.cardIDEnum.NAX2_01:
                    return new Sim_NAX2_01();
                case CardDB.cardIDEnum.NAX2_01H:
                    return new Sim_NAX2_01H();
                case CardDB.cardIDEnum.NAX11_01:
                    return new Sim_NAX11_01();
                case CardDB.cardIDEnum.NAX11_01H:
                    return new Sim_NAX11_01H();
                case CardDB.cardIDEnum.NAX15_03n:
                    return new Sim_NAX15_03n();
                case CardDB.cardIDEnum.NAX15_03t:
                    return new Sim_NAX15_03t();
                case CardDB.cardIDEnum.NAX8_02:
                    return new Sim_NAX8_02();
                case CardDB.cardIDEnum.NAX8_02H:
                    return new Sim_NAX8_02H();
                case CardDB.cardIDEnum.NAX10_03:
                    return new Sim_NAX10_03();
                case CardDB.cardIDEnum.NAX10_03H:
                    return new Sim_NAX10_03H();
                case CardDB.cardIDEnum.FP1_002:
                    return new Sim_FP1_002();
                case CardDB.cardIDEnum.NAX5_01:
                    return new Sim_NAX5_01();
                case CardDB.cardIDEnum.NAX5_01H:
                    return new Sim_NAX5_01H();
                case CardDB.cardIDEnum.NAX2_05He:
                    return new Sim_NAX2_05He();
                case CardDB.cardIDEnum.NAX10_02:
                    return new Sim_NAX10_02();
                case CardDB.cardIDEnum.NAX10_02H:
                    return new Sim_NAX10_02H();
                case CardDB.cardIDEnum.NAX7_01:
                    return new Sim_NAX7_01();
                case CardDB.cardIDEnum.NAX7_01H:
                    return new Sim_NAX7_01H();
                case CardDB.cardIDEnum.NAX15_01e:
                    return new Sim_NAX15_01e();
                case CardDB.cardIDEnum.NAX15_01He:
                    return new Sim_NAX15_01He();
                case CardDB.cardIDEnum.NAX12_03:
                    return new Sim_NAX12_03();
                case CardDB.cardIDEnum.NAX12_03H:
                    return new Sim_NAX12_03H();
                case CardDB.cardIDEnum.FP1_013:
                    return new Sim_FP1_013();
                case CardDB.cardIDEnum.NAX15_01:
                    return new Sim_NAX15_01();
                case CardDB.cardIDEnum.NAX15_01H:
                    return new Sim_NAX15_01H();
                case CardDB.cardIDEnum.NAX9_02:
                    return new Sim_NAX9_02();
                case CardDB.cardIDEnum.NAX9_02H:
                    return new Sim_NAX9_02H();
                case CardDB.cardIDEnum.FP1_030:
                    return new Sim_FP1_030();
                case CardDB.cardIDEnum.NAX6_01:
                    return new Sim_NAX6_01();
                case CardDB.cardIDEnum.NAX6_01H:
                    return new Sim_NAX6_01H();
                case CardDB.cardIDEnum.NAX1_05:
                    return new Sim_NAX1_05();
                case CardDB.cardIDEnum.FP1_004:
                    return new Sim_FP1_004();
                case CardDB.cardIDEnum.FP1_010:
                    return new Sim_FP1_010();
                case CardDB.cardIDEnum.NAX3_01:
                    return new Sim_NAX3_01();
                case CardDB.cardIDEnum.NAX3_01H:
                    return new Sim_NAX3_01H();
                case CardDB.cardIDEnum.NAX9_07:
                    return new Sim_NAX9_07();
                case CardDB.cardIDEnum.NAX9_07e:
                    return new Sim_NAX9_07e();
                case CardDB.cardIDEnum.NAX7_04:
                    return new Sim_NAX7_04();
                case CardDB.cardIDEnum.NAX7_04H:
                    return new Sim_NAX7_04H();
                case CardDB.cardIDEnum.NAX7_05:
                    return new Sim_NAX7_05();
                case CardDB.cardIDEnum.NAX5_03:
                    return new Sim_NAX5_03();
                case CardDB.cardIDEnum.NAX15_05:
                    return new Sim_NAX15_05();
                case CardDB.cardIDEnum.NAX11_04:
                    return new Sim_NAX11_04();
                case CardDB.cardIDEnum.NAX11_04e:
                    return new Sim_NAX11_04e();
                case CardDB.cardIDEnum.NAXM_001:
                    return new Sim_NAXM_001();
                case CardDB.cardIDEnum.FP1_030e:
                    return new Sim_FP1_030e();
                case CardDB.cardIDEnum.NAX6_02:
                    return new Sim_NAX6_02();
                case CardDB.cardIDEnum.NAX6_02H:
                    return new Sim_NAX6_02H();
                case CardDB.cardIDEnum.NAX3_03:
                    return new Sim_NAX3_03();
                case CardDB.cardIDEnum.FP1_017:
                    return new Sim_FP1_017();
                case CardDB.cardIDEnum.FP1_007t:
                    return new Sim_FP1_007t();
                case CardDB.cardIDEnum.NAX1_03:
                    return new Sim_NAX1_03();
                case CardDB.cardIDEnum.NAX1h_03:
                    return new Sim_NAX1h_03();
                case CardDB.cardIDEnum.FP1_007:
                    return new Sim_FP1_007();
                case CardDB.cardIDEnum.NAX4_01:
                    return new Sim_NAX4_01();
                case CardDB.cardIDEnum.NAX4_01H:
                    return new Sim_NAX4_01H();
                case CardDB.cardIDEnum.NAX10_01:
                    return new Sim_NAX10_01();
                case CardDB.cardIDEnum.NAX10_01H:
                    return new Sim_NAX10_01H();
                case CardDB.cardIDEnum.NAX4_05:
                    return new Sim_NAX4_05();
                case CardDB.cardIDEnum.NAX11_02:
                    return new Sim_NAX11_02();
                case CardDB.cardIDEnum.NAX11_02H:
                    return new Sim_NAX11_02H();
                case CardDB.cardIDEnum.FP1_019:
                    return new Sim_FP1_019();
                case CardDB.cardIDEnum.NAX13_02e:
                    return new Sim_NAX13_02e();
                case CardDB.cardIDEnum.NAX13_02:
                    return new Sim_NAX13_02();
                case CardDB.cardIDEnum.FP1_023e:
                    return new Sim_FP1_023e();
                case CardDB.cardIDEnum.NAX14_04:
                    return new Sim_NAX14_04();
                case CardDB.cardIDEnum.NAX2_03:
                    return new Sim_NAX2_03();
                case CardDB.cardIDEnum.NAX2_03H:
                    return new Sim_NAX2_03H();
                case CardDB.cardIDEnum.NAX4_04:
                    return new Sim_NAX4_04();
                case CardDB.cardIDEnum.NAX4_04H:
                    return new Sim_NAX4_04H();
                case CardDB.cardIDEnum.FP1_025:
                    return new Sim_FP1_025();
                case CardDB.cardIDEnum.FP1_031e:
                    return new Sim_FP1_031e();
                case CardDB.cardIDEnum.NAX9_05:
                    return new Sim_NAX9_05();
                case CardDB.cardIDEnum.NAX9_05H:
                    return new Sim_NAX9_05H();
                case CardDB.cardIDEnum.NAX14_01:
                    return new Sim_NAX14_01();
                case CardDB.cardIDEnum.NAX14_01H:
                    return new Sim_NAX14_01H();
                case CardDB.cardIDEnum.FP1_005:
                    return new Sim_FP1_005();
                case CardDB.cardIDEnum.NAX9_04:
                    return new Sim_NAX9_04();
                case CardDB.cardIDEnum.NAX9_04H:
                    return new Sim_NAX9_04H();
                case CardDB.cardIDEnum.NAXM_002:
                    return new Sim_NAXM_002();
                case CardDB.cardIDEnum.NAX4_03:
                    return new Sim_NAX4_03();
                case CardDB.cardIDEnum.NAX4_03H:
                    return new Sim_NAX4_03H();
                case CardDB.cardIDEnum.NAX1_04:
                    return new Sim_NAX1_04();
                case CardDB.cardIDEnum.NAX1h_04:
                    return new Sim_NAX1h_04();
                case CardDB.cardIDEnum.NAX15_04a:
                    return new Sim_NAX15_04a();
                case CardDB.cardIDEnum.FP1_012t:
                    return new Sim_FP1_012t();
                case CardDB.cardIDEnum.FP1_012:
                    return new Sim_FP1_012();
                case CardDB.cardIDEnum.FP1_008:
                    return new Sim_FP1_008();
                case CardDB.cardIDEnum.NAX8_05t:
                    return new Sim_NAX8_05t();
                case CardDB.cardIDEnum.FP1_002t:
                    return new Sim_FP1_002t();
                case CardDB.cardIDEnum.NAX8_03t:
                    return new Sim_NAX8_03t();
                case CardDB.cardIDEnum.NAX8_04t:
                    return new Sim_NAX8_04t();
                case CardDB.cardIDEnum.NAX6_03t:
                    return new Sim_NAX6_03t();
                case CardDB.cardIDEnum.NAX6_04:
                    return new Sim_NAX6_04();
                case CardDB.cardIDEnum.FP1_014:
                    return new Sim_FP1_014();
                case CardDB.cardIDEnum.NAX13_05H:
                    return new Sim_NAX13_05H();
                case CardDB.cardIDEnum.FP1_027:
                    return new Sim_FP1_027();
                case CardDB.cardIDEnum.NAX13_03:
                    return new Sim_NAX13_03();
                case CardDB.cardIDEnum.NAX13_03e:
                    return new Sim_NAX13_03e();
                case CardDB.cardIDEnum.FP1_014t:
                    return new Sim_FP1_014t();
                case CardDB.cardIDEnum.NAX13_01:
                    return new Sim_NAX13_01();
                case CardDB.cardIDEnum.NAX13_01H:
                    return new Sim_NAX13_01H();
                case CardDB.cardIDEnum.NAX9_03:
                    return new Sim_NAX9_03();
                case CardDB.cardIDEnum.NAX9_03H:
                    return new Sim_NAX9_03H();
                case CardDB.cardIDEnum.FP1_019t:
                    return new Sim_FP1_019t();
                case CardDB.cardIDEnum.NAX7_03:
                    return new Sim_NAX7_03();
                case CardDB.cardIDEnum.NAX7_03H:
                    return new Sim_NAX7_03H();
                case CardDB.cardIDEnum.NAX7_02:
                    return new Sim_NAX7_02();
                case CardDB.cardIDEnum.FP1_028:
                    return new Sim_FP1_028();
                case CardDB.cardIDEnum.NAX9_06:
                    return new Sim_NAX9_06();
                case CardDB.cardIDEnum.NAX8_05:
                    return new Sim_NAX8_05();
                case CardDB.cardIDEnum.NAX8_03:
                    return new Sim_NAX8_03();
                case CardDB.cardIDEnum.NAX8_04:
                    return new Sim_NAX8_04();
                case CardDB.cardIDEnum.FP1_024:
                    return new Sim_FP1_024();
                case CardDB.cardIDEnum.FP1_020e:
                    return new Sim_FP1_020e();
                case CardDB.cardIDEnum.FP1_022:
                    return new Sim_FP1_022();
                case CardDB.cardIDEnum.FP1_016:
                    return new Sim_FP1_016();
                case CardDB.cardIDEnum.NAX3_02:
                    return new Sim_NAX3_02();
                case CardDB.cardIDEnum.NAX3_02H:
                    return new Sim_NAX3_02H();
                case CardDB.cardIDEnum.FP1_017e:
                    return new Sim_FP1_017e();
                case CardDB.cardIDEnum.FP1_011:
                    return new Sim_FP1_011();
                case CardDB.cardIDEnum.NAX2_05e:
                    return new Sim_NAX2_05e();
                case CardDB.cardIDEnum.NAX2_05:
                    return new Sim_NAX2_05();
                case CardDB.cardIDEnum.NAX2_05H:
                    return new Sim_NAX2_05H();
                case CardDB.cardIDEnum.FP1_001:
                    return new Sim_FP1_001();
 ///case CardDB.cardIDEnum.///GILNEAS:
                    ///return new Sim_///GILNEAS();
                case CardDB.cardIDEnum.GILA_BOSS_66p:
                    return new Sim_GILA_BOSS_66p();
                case CardDB.cardIDEnum.GILA_BOSS_20h:
                    return new Sim_GILA_BOSS_20h();
                case CardDB.cardIDEnum.GILA_BOSS_56p:
                    return new Sim_GILA_BOSS_56p();
                case CardDB.cardIDEnum.GILA_500p2t:
                    return new Sim_GILA_500p2t();
                case CardDB.cardIDEnum.GILA_BOSS_48e:
                    return new Sim_GILA_BOSS_48e();
                case CardDB.cardIDEnum.GILA_BOSS_48t:
                    return new Sim_GILA_BOSS_48t();
                case CardDB.cardIDEnum.GILA_BOSS_48e2:
                    return new Sim_GILA_BOSS_48e2();
                case CardDB.cardIDEnum.GILA_BOSS_27t:
                    return new Sim_GILA_BOSS_27t();
                case CardDB.cardIDEnum.GILA_BOSS_27t2:
                    return new Sim_GILA_BOSS_27t2();
                case CardDB.cardIDEnum.GILA_810e:
                    return new Sim_GILA_810e();
                case CardDB.cardIDEnum.GIL_840e:
                    return new Sim_GIL_840e();
                case CardDB.cardIDEnum.GILA_821b:
                    return new Sim_GILA_821b();
                case CardDB.cardIDEnum.GIL_116:
                    return new Sim_GIL_116();
                case CardDB.cardIDEnum.GIL_691:
                    return new Sim_GIL_691();
                case CardDB.cardIDEnum.GILA_Darius_06:
                    return new Sim_GILA_Darius_06();
                case CardDB.cardIDEnum.GILA_597:
                    return new Sim_GILA_597();
                case CardDB.cardIDEnum.GILA_BOSS_54e:
                    return new Sim_GILA_BOSS_54e();
                case CardDB.cardIDEnum.GILA_Darius_04:
                    return new Sim_GILA_Darius_04();
                case CardDB.cardIDEnum.GIL_198:
                    return new Sim_GIL_198();
                case CardDB.cardIDEnum.GILA_BOSS_55h:
                    return new Sim_GILA_BOSS_55h();
                case CardDB.cardIDEnum.GIL_800e2:
                    return new Sim_GIL_800e2();
                case CardDB.cardIDEnum.GIL_815:
                    return new Sim_GIL_815();
                case CardDB.cardIDEnum.GILA_506t:
                    return new Sim_GILA_506t();
                case CardDB.cardIDEnum.GILA_BOSS_42h:
                    return new Sim_GILA_BOSS_42h();
                case CardDB.cardIDEnum.GIL_508t:
                    return new Sim_GIL_508t();
                case CardDB.cardIDEnum.GILA_BOSS_52e:
                    return new Sim_GILA_BOSS_52e();
                case CardDB.cardIDEnum.GILA_BOSS_52p2:
                    return new Sim_GILA_BOSS_52p2();
                case CardDB.cardIDEnum.GILA_854:
                    return new Sim_GILA_854();
                case CardDB.cardIDEnum.GILA_BOSS_52h2:
                    return new Sim_GILA_BOSS_52h2();
                case CardDB.cardIDEnum.GILA_854t:
                    return new Sim_GILA_854t();
                case CardDB.cardIDEnum.GIL_634:
                    return new Sim_GIL_634();
                case CardDB.cardIDEnum.GILA_Darius_01:
                    return new Sim_GILA_Darius_01();
                case CardDB.cardIDEnum.GILA_812:
                    return new Sim_GILA_812();
                case CardDB.cardIDEnum.GIL_504h:
                    return new Sim_GIL_504h();
                case CardDB.cardIDEnum.GIL_507e:
                    return new Sim_GIL_507e();
                case CardDB.cardIDEnum.GIL_507:
                    return new Sim_GIL_507();
                case CardDB.cardIDEnum.GIL_152:
                    return new Sim_GIL_152();
                case CardDB.cardIDEnum.GIL_561:
                    return new Sim_GIL_561();
                case CardDB.cardIDEnum.GIL_836:
                    return new Sim_GIL_836();
                case CardDB.cardIDEnum.GIL_827:
                    return new Sim_GIL_827();
                case CardDB.cardIDEnum.GILA_BOSS_24t:
                    return new Sim_GILA_BOSS_24t();
                case CardDB.cardIDEnum.GILA_412e:
                    return new Sim_GILA_412e();
                case CardDB.cardIDEnum.GILA_412:
                    return new Sim_GILA_412();
                case CardDB.cardIDEnum.GILA_BOSS_30p:
                    return new Sim_GILA_BOSS_30p();
                case CardDB.cardIDEnum.GIL_693:
                    return new Sim_GIL_693();
                case CardDB.cardIDEnum.GILA_BOSS_30h:
                    return new Sim_GILA_BOSS_30h();
                case CardDB.cardIDEnum.GIL_547e:
                    return new Sim_GIL_547e();
                case CardDB.cardIDEnum.GILA_400t:
                    return new Sim_GILA_400t();
                case CardDB.cardIDEnum.GILA_BOSS_35p:
                    return new Sim_GILA_BOSS_35p();
                case CardDB.cardIDEnum.GILA_BOSS_35e2:
                    return new Sim_GILA_BOSS_35e2();
                case CardDB.cardIDEnum.GILA_BOSS_33e2:
                    return new Sim_GILA_BOSS_33e2();
                case CardDB.cardIDEnum.GILA_500t3:
                    return new Sim_GILA_500t3();
                case CardDB.cardIDEnum.GIL_807:
                    return new Sim_GIL_807();
                case CardDB.cardIDEnum.GIL_601e:
                    return new Sim_GIL_601e();
                case CardDB.cardIDEnum.GIL_645:
                    return new Sim_GIL_645();
                case CardDB.cardIDEnum.GIL_548:
                    return new Sim_GIL_548();
                case CardDB.cardIDEnum.GILA_Toki_11:
                    return new Sim_GILA_Toki_11();
                case CardDB.cardIDEnum.GILA_806:
                    return new Sim_GILA_806();
                case CardDB.cardIDEnum.GILA_BOSS_41h:
                    return new Sim_GILA_BOSS_41h();
                case CardDB.cardIDEnum.GILA_410:
                    return new Sim_GILA_410();
                case CardDB.cardIDEnum.GILA_BOSS_42p:
                    return new Sim_GILA_BOSS_42p();
                case CardDB.cardIDEnum.GILA_403:
                    return new Sim_GILA_403();
                case CardDB.cardIDEnum.GILA_BOSS_38p:
                    return new Sim_GILA_BOSS_38p();
                case CardDB.cardIDEnum.GILA_814:
                    return new Sim_GILA_814();
                case CardDB.cardIDEnum.GILA_814e:
                    return new Sim_GILA_814e();
                case CardDB.cardIDEnum.GILA_BOSS_67p:
                    return new Sim_GILA_BOSS_67p();
                case CardDB.cardIDEnum.GILA_601:
                    return new Sim_GILA_601();
                case CardDB.cardIDEnum.GILA_BOSS_60h:
                    return new Sim_GILA_BOSS_60h();
                case CardDB.cardIDEnum.GIL_905:
                    return new Sim_GIL_905();
                case CardDB.cardIDEnum.GILA_802:
                    return new Sim_GILA_802();
                case CardDB.cardIDEnum.GIL_635:
                    return new Sim_GIL_635();
                case CardDB.cardIDEnum.GIL_119:
                    return new Sim_GIL_119();
                case CardDB.cardIDEnum.GIL_142:
                    return new Sim_GIL_142();
                case CardDB.cardIDEnum.GILA_Toki_01:
                    return new Sim_GILA_Toki_01();
                case CardDB.cardIDEnum.GILA_901:
                    return new Sim_GILA_901();
                case CardDB.cardIDEnum.GIL_506:
                    return new Sim_GIL_506();
                case CardDB.cardIDEnum.GIL_648:
                    return new Sim_GIL_648();
                case CardDB.cardIDEnum.GILA_BOSS_48p:
                    return new Sim_GILA_BOSS_48p();
                case CardDB.cardIDEnum.GILA_BOSS_23p:
                    return new Sim_GILA_BOSS_23p();
                case CardDB.cardIDEnum.GILA_BOSS_23t:
                    return new Sim_GILA_BOSS_23t();
                case CardDB.cardIDEnum.GILA_BOSS_35h:
                    return new Sim_GILA_BOSS_35h();
                case CardDB.cardIDEnum.GIL_147:
                    return new Sim_GIL_147();
                case CardDB.cardIDEnum.GILA_907:
                    return new Sim_GILA_907();
                case CardDB.cardIDEnum.GIL_646:
                    return new Sim_GIL_646();
                case CardDB.cardIDEnum.GIL_805:
                    return new Sim_GIL_805();
                case CardDB.cardIDEnum.GILA_816a:
                    return new Sim_GILA_816a();
                case CardDB.cardIDEnum.GILA_Darius_07:
                    return new Sim_GILA_Darius_07();
                case CardDB.cardIDEnum.GILA_495:
                    return new Sim_GILA_495();
                case CardDB.cardIDEnum.GILA_414:
                    return new Sim_GILA_414();
                case CardDB.cardIDEnum.GILA_414e2:
                    return new Sim_GILA_414e2();
                case CardDB.cardIDEnum.GILA_414e:
                    return new Sim_GILA_414e();
                case CardDB.cardIDEnum.GILA_BOSS_27p:
                    return new Sim_GILA_BOSS_27p();
                case CardDB.cardIDEnum.GILA_595:
                    return new Sim_GILA_595();
                case CardDB.cardIDEnum.GIL_905e:
                    return new Sim_GIL_905e();
                case CardDB.cardIDEnum.GIL_578:
                    return new Sim_GIL_578();
                case CardDB.cardIDEnum.GILA_BOSS_52e2:
                    return new Sim_GILA_BOSS_52e2();
                case CardDB.cardIDEnum.GILA_BOSS_54h:
                    return new Sim_GILA_BOSS_54h();
                case CardDB.cardIDEnum.GILA_821c:
                    return new Sim_GILA_821c();
                case CardDB.cardIDEnum.GILA_817:
                    return new Sim_GILA_817();
                case CardDB.cardIDEnum.GIL_620e:
                    return new Sim_GIL_620e();
                case CardDB.cardIDEnum.GILA_BOSS_52h:
                    return new Sim_GILA_BOSS_52h();
                case CardDB.cardIDEnum.GILA_BOSS_49t:
                    return new Sim_GILA_BOSS_49t();
                case CardDB.cardIDEnum.GILA_BOSS_49t2:
                    return new Sim_GILA_BOSS_49t2();
                case CardDB.cardIDEnum.GIL_583e:
                    return new Sim_GIL_583e();
                case CardDB.cardIDEnum.GILA_BOSS_62p:
                    return new Sim_GILA_BOSS_62p();
                case CardDB.cardIDEnum.GILA_513:
                    return new Sim_GILA_513();
                case CardDB.cardIDEnum.GILA_513e:
                    return new Sim_GILA_513e();
                case CardDB.cardIDEnum.GILA_BOSS_45h:
                    return new Sim_GILA_BOSS_45h();
                case CardDB.cardIDEnum.GIL_640:
                    return new Sim_GIL_640();
                case CardDB.cardIDEnum.GIL_692e:
                    return new Sim_GIL_692e();
                case CardDB.cardIDEnum.GIL_665:
                    return new Sim_GIL_665();
                case CardDB.cardIDEnum.GIL_665e:
                    return new Sim_GIL_665e();
                case CardDB.cardIDEnum.GIL_557:
                    return new Sim_GIL_557();
                case CardDB.cardIDEnum.GILA_BOSS_60t:
                    return new Sim_GILA_BOSS_60t();
                case CardDB.cardIDEnum.GILA_819:
                    return new Sim_GILA_819();
                case CardDB.cardIDEnum.GIL_902:
                    return new Sim_GIL_902();
                case CardDB.cardIDEnum.GILA_BOSS_22h:
                    return new Sim_GILA_BOSS_22h();
                case CardDB.cardIDEnum.GIL_547:
                    return new Sim_GIL_547();
                case CardDB.cardIDEnum.GILA_600h:
                    return new Sim_GILA_600h();
                case CardDB.cardIDEnum.GILA_600h2:
                    return new Sim_GILA_600h2();
                case CardDB.cardIDEnum.GIL_543:
                    return new Sim_GIL_543();
                case CardDB.cardIDEnum.GIL_121:
                    return new Sim_GIL_121();
                case CardDB.cardIDEnum.GIL_537:
                    return new Sim_GIL_537();
                case CardDB.cardIDEnum.GILA_BOSS_51p:
                    return new Sim_GILA_BOSS_51p();
                case CardDB.cardIDEnum.GIL_565:
                    return new Sim_GIL_565();
                case CardDB.cardIDEnum.GIL_118:
                    return new Sim_GIL_118();
                case CardDB.cardIDEnum.GILA_BOSS_57p:
                    return new Sim_GILA_BOSS_57p();
                case CardDB.cardIDEnum.GILA_BOSS_34p:
                    return new Sim_GILA_BOSS_34p();
                case CardDB.cardIDEnum.GIL_145e:
                    return new Sim_GIL_145e();
                case CardDB.cardIDEnum.GIL_828:
                    return new Sim_GIL_828();
                case CardDB.cardIDEnum.GIL_828e:
                    return new Sim_GIL_828e();
                case CardDB.cardIDEnum.GIL_188a:
                    return new Sim_GIL_188a();
                case CardDB.cardIDEnum.GIL_188b:
                    return new Sim_GIL_188b();
                case CardDB.cardIDEnum.GILA_494:
                    return new Sim_GILA_494();
                case CardDB.cardIDEnum.GIL_661:
                    return new Sim_GIL_661();
                case CardDB.cardIDEnum.GILA_BOSS_44h:
                    return new Sim_GILA_BOSS_44h();
                case CardDB.cardIDEnum.GILA_400p:
                    return new Sim_GILA_400p();
                case CardDB.cardIDEnum.GIL_620:
                    return new Sim_GIL_620();
                case CardDB.cardIDEnum.GIL_577t:
                    return new Sim_GIL_577t();
                case CardDB.cardIDEnum.GILA_913:
                    return new Sim_GILA_913();
                case CardDB.cardIDEnum.GILA_913e:
                    return new Sim_GILA_913e();
                case CardDB.cardIDEnum.GILA_Darius_11:
                    return new Sim_GILA_Darius_11();
                case CardDB.cardIDEnum.GILA_605:
                    return new Sim_GILA_605();
                case CardDB.cardIDEnum.GILA_605e2:
                    return new Sim_GILA_605e2();
                case CardDB.cardIDEnum.GIL_683t:
                    return new Sim_GIL_683t();
                case CardDB.cardIDEnum.GILA_BOSS_68e:
                    return new Sim_GILA_BOSS_68e();
                case CardDB.cardIDEnum.GIL_188:
                    return new Sim_GIL_188();
                case CardDB.cardIDEnum.GIL_188t:
                    return new Sim_GIL_188t();
                case CardDB.cardIDEnum.GIL_188t2:
                    return new Sim_GIL_188t2();
                case CardDB.cardIDEnum.GIL_188t3:
                    return new Sim_GIL_188t3();
                case CardDB.cardIDEnum.GIL_508:
                    return new Sim_GIL_508();
                case CardDB.cardIDEnum.GIL_800:
                    return new Sim_GIL_800();
                case CardDB.cardIDEnum.GIL_200:
                    return new Sim_GIL_200();
                case CardDB.cardIDEnum.GIL_200t:
                    return new Sim_GIL_200t();
                case CardDB.cardIDEnum.GIL_586:
                    return new Sim_GIL_586();
                case CardDB.cardIDEnum.GIL_000:
                    return new Sim_GIL_000();
                case CardDB.cardIDEnum.GILA_BOSS_50p:
                    return new Sim_GILA_BOSS_50p();
                case CardDB.cardIDEnum.GILA_Toki_07:
                    return new Sim_GILA_Toki_07();
                case CardDB.cardIDEnum.GIL_128:
                    return new Sim_GIL_128();
                case CardDB.cardIDEnum.GILA_BOSS_46e:
                    return new Sim_GILA_BOSS_46e();
                case CardDB.cardIDEnum.GILA_BOSS_29e:
                    return new Sim_GILA_BOSS_29e();
                case CardDB.cardIDEnum.GILA_BOSS_29t:
                    return new Sim_GILA_BOSS_29t();
                case CardDB.cardIDEnum.GIL_515e:
                    return new Sim_GIL_515e();
                case CardDB.cardIDEnum.GILA_903:
                    return new Sim_GILA_903();
                case CardDB.cardIDEnum.GIL_155e:
                    return new Sim_GIL_155e();
                case CardDB.cardIDEnum.GILA_805e2:
                    return new Sim_GILA_805e2();
                case CardDB.cardIDEnum.GILA_805:
                    return new Sim_GILA_805();
                case CardDB.cardIDEnum.GILA_805e:
                    return new Sim_GILA_805e();
                case CardDB.cardIDEnum.GILA_Toki_03:
                    return new Sim_GILA_Toki_03();
                case CardDB.cardIDEnum.GILA_496:
                    return new Sim_GILA_496();
                case CardDB.cardIDEnum.GILA_813:
                    return new Sim_GILA_813();
                case CardDB.cardIDEnum.GILA_813e:
                    return new Sim_GILA_813e();
                case CardDB.cardIDEnum.GILA_BOSS_27h:
                    return new Sim_GILA_BOSS_27h();
                case CardDB.cardIDEnum.GILA_501:
                    return new Sim_GILA_501();
                case CardDB.cardIDEnum.GILA_604:
                    return new Sim_GILA_604();
                case CardDB.cardIDEnum.GILA_604e2:
                    return new Sim_GILA_604e2();
                case CardDB.cardIDEnum.GIL_130e:
                    return new Sim_GIL_130e();
                case CardDB.cardIDEnum.GIL_677:
                    return new Sim_GIL_677();
                case CardDB.cardIDEnum.GILA_BOSS_56h:
                    return new Sim_GILA_BOSS_56h();
                case CardDB.cardIDEnum.GILA_BOSS_21p:
                    return new Sim_GILA_BOSS_21p();
                case CardDB.cardIDEnum.GILA_BOSS_49p:
                    return new Sim_GILA_BOSS_49p();
                case CardDB.cardIDEnum.GILA_BOSS_21e:
                    return new Sim_GILA_BOSS_21e();
                case CardDB.cardIDEnum.GIL_527:
                    return new Sim_GIL_527();
                case CardDB.cardIDEnum.GIL_637:
                    return new Sim_GIL_637();
                case CardDB.cardIDEnum.GIL_655:
                    return new Sim_GIL_655();
                case CardDB.cardIDEnum.GIL_191:
                    return new Sim_GIL_191();
                case CardDB.cardIDEnum.GILA_600p:
                    return new Sim_GILA_600p();
                case CardDB.cardIDEnum.GILA_506:
                    return new Sim_GILA_506();
                case CardDB.cardIDEnum.GILA_506e:
                    return new Sim_GILA_506e();
                case CardDB.cardIDEnum.GIL_526e:
                    return new Sim_GIL_526e();
                case CardDB.cardIDEnum.GIL_833:
                    return new Sim_GIL_833();
                case CardDB.cardIDEnum.GILA_BOSS_39h:
                    return new Sim_GILA_BOSS_39h();
                case CardDB.cardIDEnum.GILA_509:
                    return new Sim_GILA_509();
                case CardDB.cardIDEnum.GILA_BOSS_24p:
                    return new Sim_GILA_BOSS_24p();
                case CardDB.cardIDEnum.GILA_Toki_04:
                    return new Sim_GILA_Toki_04();
                case CardDB.cardIDEnum.GILA_BOSS_47p:
                    return new Sim_GILA_BOSS_47p();
                case CardDB.cardIDEnum.GIL_120:
                    return new Sim_GIL_120();
                case CardDB.cardIDEnum.GILA_BOSS_51h:
                    return new Sim_GILA_BOSS_51h();
                case CardDB.cardIDEnum.GILA_801:
                    return new Sim_GILA_801();
                case CardDB.cardIDEnum.GILA_825d:
                    return new Sim_GILA_825d();
                case CardDB.cardIDEnum.GILA_825:
                    return new Sim_GILA_825();
                case CardDB.cardIDEnum.GILA_825e:
                    return new Sim_GILA_825e();
                case CardDB.cardIDEnum.GIL_678:
                    return new Sim_GIL_678();
                case CardDB.cardIDEnum.GIL_545:
                    return new Sim_GIL_545();
                case CardDB.cardIDEnum.GIL_202:
                    return new Sim_GIL_202();
                case CardDB.cardIDEnum.GIL_202t:
                    return new Sim_GIL_202t();
                case CardDB.cardIDEnum.GILA_851a:
                    return new Sim_GILA_851a();
                case CardDB.cardIDEnum.GILA_803:
                    return new Sim_GILA_803();
                case CardDB.cardIDEnum.GIL_618:
                    return new Sim_GIL_618();
                case CardDB.cardIDEnum.GILA_BOSS_49h:
                    return new Sim_GILA_BOSS_49h();
                case CardDB.cardIDEnum.GIL_618e:
                    return new Sim_GIL_618e();
                case CardDB.cardIDEnum.GILA_BOSS_31h:
                    return new Sim_GILA_BOSS_31h();
                case CardDB.cardIDEnum.GILA_BOSS_26h:
                    return new Sim_GILA_BOSS_26h();
                case CardDB.cardIDEnum.GILA_492:
                    return new Sim_GILA_492();
                case CardDB.cardIDEnum.GILA_BOSS_65h:
                    return new Sim_GILA_BOSS_65h();
                case CardDB.cardIDEnum.GILA_BOSS_40p:
                    return new Sim_GILA_BOSS_40p();
                case CardDB.cardIDEnum.GILA_BOSS_43p:
                    return new Sim_GILA_BOSS_43p();
                case CardDB.cardIDEnum.GILA_BOSS_43t:
                    return new Sim_GILA_BOSS_43t();
                case CardDB.cardIDEnum.GILA_BOSS_43h:
                    return new Sim_GILA_BOSS_43h();
                case CardDB.cardIDEnum.GILA_BOSS_36h:
                    return new Sim_GILA_BOSS_36h();
                case CardDB.cardIDEnum.GIL_623e:
                    return new Sim_GIL_623e();
                case CardDB.cardIDEnum.GILA_610:
                    return new Sim_GILA_610();
                case CardDB.cardIDEnum.GILA_BOSS_24h:
                    return new Sim_GILA_BOSS_24h();
                case CardDB.cardIDEnum.GILA_BOSS_32e:
                    return new Sim_GILA_BOSS_32e();
                case CardDB.cardIDEnum.GIL_655e:
                    return new Sim_GIL_655e();
                case CardDB.cardIDEnum.GILA_BOSS_23h:
                    return new Sim_GILA_BOSS_23h();
                case CardDB.cardIDEnum.GILA_BOSS_58h:
                    return new Sim_GILA_BOSS_58h();
                case CardDB.cardIDEnum.GILA_BOSS_62h:
                    return new Sim_GILA_BOSS_62h();
                case CardDB.cardIDEnum.GILA_BOSS_20p:
                    return new Sim_GILA_BOSS_20p();
                case CardDB.cardIDEnum.GILA_BOSS_41t:
                    return new Sim_GILA_BOSS_41t();
                case CardDB.cardIDEnum.GIL_504:
                    return new Sim_GIL_504();
                case CardDB.cardIDEnum.GILA_BOSS_61h:
                    return new Sim_GILA_BOSS_61h();
                case CardDB.cardIDEnum.GILA_850b:
                    return new Sim_GILA_850b();
                case CardDB.cardIDEnum.GILA_500t2:
                    return new Sim_GILA_500t2();
                case CardDB.cardIDEnum.GILA_BOSS_33p:
                    return new Sim_GILA_BOSS_33p();
                case CardDB.cardIDEnum.GIL_125e:
                    return new Sim_GIL_125e();
                case CardDB.cardIDEnum.GILA_818:
                    return new Sim_GILA_818();
                case CardDB.cardIDEnum.GILA_816c:
                    return new Sim_GILA_816c();
                case CardDB.cardIDEnum.GIL_534:
                    return new Sim_GIL_534();
                case CardDB.cardIDEnum.GIL_903:
                    return new Sim_GIL_903();
                case CardDB.cardIDEnum.GILA_BOSS_44p:
                    return new Sim_GILA_BOSS_44p();
                case CardDB.cardIDEnum.GILA_804:
                    return new Sim_GILA_804();
                case CardDB.cardIDEnum.GILA_804e:
                    return new Sim_GILA_804e();
                case CardDB.cardIDEnum.GIL_134:
                    return new Sim_GIL_134();
                case CardDB.cardIDEnum.GIL_650e:
                    return new Sim_GIL_650e();
                case CardDB.cardIDEnum.GIL_650:
                    return new Sim_GIL_650();
                case CardDB.cardIDEnum.GILA_400h:
                    return new Sim_GILA_400h();
                case CardDB.cardIDEnum.GILA_BOSS_20e:
                    return new Sim_GILA_BOSS_20e();
                case CardDB.cardIDEnum.GILA_507:
                    return new Sim_GILA_507();
                case CardDB.cardIDEnum.GILA_503:
                    return new Sim_GILA_503();
                case CardDB.cardIDEnum.GIL_607t:
                    return new Sim_GIL_607t();
                case CardDB.cardIDEnum.ICC_828t5:
                    return new Sim_ICC_828t5();
                case CardDB.cardIDEnum.GILA_BOSS_64p:
                    return new Sim_GILA_BOSS_64p();
                case CardDB.cardIDEnum.GIL_191t:
                    return new Sim_GIL_191t();
                case CardDB.cardIDEnum.GILA_906:
                    return new Sim_GILA_906();
                case CardDB.cardIDEnum.GILA_BOSS_29p:
                    return new Sim_GILA_BOSS_29p();
                case CardDB.cardIDEnum.GILA_BOSS_68t:
                    return new Sim_GILA_BOSS_68t();
                case CardDB.cardIDEnum.GILA_BOSS_48h:
                    return new Sim_GILA_BOSS_48h();
                case CardDB.cardIDEnum.GIL_608e:
                    return new Sim_GIL_608e();
                case CardDB.cardIDEnum.GILA_BOSS_34h:
                    return new Sim_GILA_BOSS_34h();
                case CardDB.cardIDEnum.GILA_503e:
                    return new Sim_GILA_503e();
                case CardDB.cardIDEnum.GILA_603e3:
                    return new Sim_GILA_603e3();
                case CardDB.cardIDEnum.GILA_BOSS_37p:
                    return new Sim_GILA_BOSS_37p();
                case CardDB.cardIDEnum.GILA_599:
                    return new Sim_GILA_599();
                case CardDB.cardIDEnum.GILA_Toki_06:
                    return new Sim_GILA_Toki_06();
                case CardDB.cardIDEnum.GIL_840:
                    return new Sim_GIL_840();
                case CardDB.cardIDEnum.GILA_Darius_08:
                    return new Sim_GILA_Darius_08();
                case CardDB.cardIDEnum.GILA_Toki_05:
                    return new Sim_GILA_Toki_05();
                case CardDB.cardIDEnum.GIL_622:
                    return new Sim_GIL_622();
                case CardDB.cardIDEnum.GIL_825:
                    return new Sim_GIL_825();
                case CardDB.cardIDEnum.GILA_BOSS_59h:
                    return new Sim_GILA_BOSS_59h();
                case CardDB.cardIDEnum.GILA_Toki_09:
                    return new Sim_GILA_Toki_09();
                case CardDB.cardIDEnum.GIL_513:
                    return new Sim_GIL_513();
                case CardDB.cardIDEnum.GILA_415:
                    return new Sim_GILA_415();
                case CardDB.cardIDEnum.GILA_415e:
                    return new Sim_GILA_415e();
                case CardDB.cardIDEnum.GIL_125:
                    return new Sim_GIL_125();
                case CardDB.cardIDEnum.GILA_Toki_08:
                    return new Sim_GILA_Toki_08();
                case CardDB.cardIDEnum.GILA_BOSS_25h:
                    return new Sim_GILA_BOSS_25h();
                case CardDB.cardIDEnum.GIL_128e:
                    return new Sim_GIL_128e();
                case CardDB.cardIDEnum.GIL_683:
                    return new Sim_GIL_683();
                case CardDB.cardIDEnum.GILA_Toki_10:
                    return new Sim_GILA_Toki_10();
                case CardDB.cardIDEnum.GILA_592:
                    return new Sim_GILA_592();
                case CardDB.cardIDEnum.GIL_803:
                    return new Sim_GIL_803();
                case CardDB.cardIDEnum.GILA_852b:
                    return new Sim_GILA_852b();
                case CardDB.cardIDEnum.GIL_510:
                    return new Sim_GIL_510();
                case CardDB.cardIDEnum.GIL_510e:
                    return new Sim_GIL_510e();
                case CardDB.cardIDEnum.GILA_BOSS_67e:
                    return new Sim_GILA_BOSS_67e();
                case CardDB.cardIDEnum.GILA_BOSS_46p:
                    return new Sim_GILA_BOSS_46p();
                case CardDB.cardIDEnum.GILA_852ae:
                    return new Sim_GILA_852ae();
                case CardDB.cardIDEnum.GIL_124:
                    return new Sim_GIL_124();
                case CardDB.cardIDEnum.GIL_837e:
                    return new Sim_GIL_837e();
                case CardDB.cardIDEnum.GIL_682:
                    return new Sim_GIL_682();
                case CardDB.cardIDEnum.GIL_682t:
                    return new Sim_GIL_682t();
                case CardDB.cardIDEnum.GILA_827:
                    return new Sim_GILA_827();
                case CardDB.cardIDEnum.GILA_BOSS_37e2:
                    return new Sim_GILA_BOSS_37e2();
                case CardDB.cardIDEnum.GILA_BOSS_37t:
                    return new Sim_GILA_BOSS_37t();
                case CardDB.cardIDEnum.GILA_BOSS_26p:
                    return new Sim_GILA_BOSS_26p();
                case CardDB.cardIDEnum.GILA_826:
                    return new Sim_GILA_826();
                case CardDB.cardIDEnum.GIL_624:
                    return new Sim_GIL_624();
                case CardDB.cardIDEnum.GIL_681:
                    return new Sim_GIL_681();
                case CardDB.cardIDEnum.GIL_190:
                    return new Sim_GIL_190();
                case CardDB.cardIDEnum.GIL_190t:
                    return new Sim_GIL_190t();
                case CardDB.cardIDEnum.GILA_BOSS_32h:
                    return new Sim_GILA_BOSS_32h();
                case CardDB.cardIDEnum.GILA_589:
                    return new Sim_GILA_589();
                case CardDB.cardIDEnum.GILA_852a:
                    return new Sim_GILA_852a();
                case CardDB.cardIDEnum.GILA_BOSS_61t3:
                    return new Sim_GILA_BOSS_61t3();
                case CardDB.cardIDEnum.GILA_490:
                    return new Sim_GILA_490();
                case CardDB.cardIDEnum.GILA_BOSS_54p:
                    return new Sim_GILA_BOSS_54p();
                case CardDB.cardIDEnum.GILA_491:
                    return new Sim_GILA_491();
                case CardDB.cardIDEnum.GIL_685:
                    return new Sim_GIL_685();
                case CardDB.cardIDEnum.GILA_BOSS_40e:
                    return new Sim_GILA_BOSS_40e();
                case CardDB.cardIDEnum.GIL_207:
                    return new Sim_GIL_207();
                case CardDB.cardIDEnum.GIL_696:
                    return new Sim_GIL_696();
                case CardDB.cardIDEnum.GILA_607:
                    return new Sim_GILA_607();
                case CardDB.cardIDEnum.GILA_607e2:
                    return new Sim_GILA_607e2();
                case CardDB.cardIDEnum.GILA_Darius_02:
                    return new Sim_GILA_Darius_02();
                case CardDB.cardIDEnum.GILA_BOSS_59p:
                    return new Sim_GILA_BOSS_59p();
                case CardDB.cardIDEnum.GILA_BOSS_68h:
                    return new Sim_GILA_BOSS_68h();
                case CardDB.cardIDEnum.GILA_BOSS_60p:
                    return new Sim_GILA_BOSS_60p();
                case CardDB.cardIDEnum.GILA_BOSS_68p:
                    return new Sim_GILA_BOSS_68p();
                case CardDB.cardIDEnum.GILA_BOSS_45p:
                    return new Sim_GILA_BOSS_45p();
                case CardDB.cardIDEnum.GIL_694:
                    return new Sim_GIL_694();
                case CardDB.cardIDEnum.GILA_411:
                    return new Sim_GILA_411();
                case CardDB.cardIDEnum.GILA_411e:
                    return new Sim_GILA_411e();
                case CardDB.cardIDEnum.GILA_853b:
                    return new Sim_GILA_853b();
                case CardDB.cardIDEnum.GIL_201:
                    return new Sim_GIL_201();
                case CardDB.cardIDEnum.GIL_201t:
                    return new Sim_GIL_201t();
                case CardDB.cardIDEnum.GILA_910:
                    return new Sim_GILA_910();
                case CardDB.cardIDEnum.GIL_156:
                    return new Sim_GIL_156();
                case CardDB.cardIDEnum.GIL_113:
                    return new Sim_GIL_113();
                case CardDB.cardIDEnum.GILA_BOSS_57h:
                    return new Sim_GILA_BOSS_57h();
                case CardDB.cardIDEnum.GILA_852be:
                    return new Sim_GILA_852be();
                case CardDB.cardIDEnum.GILA_594:
                    return new Sim_GILA_594();
                case CardDB.cardIDEnum.GIL_640e:
                    return new Sim_GIL_640e();
                case CardDB.cardIDEnum.GIL_577:
                    return new Sim_GIL_577();
                case CardDB.cardIDEnum.GIL_515:
                    return new Sim_GIL_515();
                case CardDB.cardIDEnum.GILA_BOSS_67h:
                    return new Sim_GILA_BOSS_67h();
                case CardDB.cardIDEnum.GIL_212:
                    return new Sim_GIL_212();
                case CardDB.cardIDEnum.GILA_BOSS_38h:
                    return new Sim_GILA_BOSS_38h();
                case CardDB.cardIDEnum.GIL_203:
                    return new Sim_GIL_203();
                case CardDB.cardIDEnum.GIL_203e:
                    return new Sim_GIL_203e();
                case CardDB.cardIDEnum.GIL_203e2:
                    return new Sim_GIL_203e2();
                case CardDB.cardIDEnum.GIL_803e:
                    return new Sim_GIL_803e();
                case CardDB.cardIDEnum.GIL_155:
                    return new Sim_GIL_155();
                case CardDB.cardIDEnum.GIL_534t:
                    return new Sim_GIL_534t();
                case CardDB.cardIDEnum.GILA_593:
                    return new Sim_GILA_593();
                case CardDB.cardIDEnum.GILA_911:
                    return new Sim_GILA_911();
                case CardDB.cardIDEnum.GILA_911e:
                    return new Sim_GILA_911e();
                case CardDB.cardIDEnum.GILA_820:
                    return new Sim_GILA_820();
                case CardDB.cardIDEnum.GILA_BOSS_61t:
                    return new Sim_GILA_BOSS_61t();
                case CardDB.cardIDEnum.GIL_667:
                    return new Sim_GIL_667();
                case CardDB.cardIDEnum.GILA_BOSS_21h:
                    return new Sim_GILA_BOSS_21h();
                case CardDB.cardIDEnum.GILA_824:
                    return new Sim_GILA_824();
                case CardDB.cardIDEnum.GILA_824e:
                    return new Sim_GILA_824e();
                case CardDB.cardIDEnum.GILA_591:
                    return new Sim_GILA_591();
                case CardDB.cardIDEnum.GILA_816b:
                    return new Sim_GILA_816b();
                case CardDB.cardIDEnum.GILA_BOSS_26t2:
                    return new Sim_GILA_BOSS_26t2();
                case CardDB.cardIDEnum.GILA_608:
                    return new Sim_GILA_608();
                case CardDB.cardIDEnum.GIL_581:
                    return new Sim_GIL_581();
                case CardDB.cardIDEnum.GILA_BOSS_29h:
                    return new Sim_GILA_BOSS_29h();
                case CardDB.cardIDEnum.GIL_601:
                    return new Sim_GIL_601();
                case CardDB.cardIDEnum.GILA_500p2:
                    return new Sim_GILA_500p2();
                case CardDB.cardIDEnum.GILA_BOSS_33t:
                    return new Sim_GILA_BOSS_33t();
                case CardDB.cardIDEnum.GILA_612:
                    return new Sim_GILA_612();
                case CardDB.cardIDEnum.GILA_612e:
                    return new Sim_GILA_612e();
                case CardDB.cardIDEnum.GILA_BOSS_63h:
                    return new Sim_GILA_BOSS_63h();
                case CardDB.cardIDEnum.GILA_BOSS_57t:
                    return new Sim_GILA_BOSS_57t();
                case CardDB.cardIDEnum.GILA_BOSS_22p:
                    return new Sim_GILA_BOSS_22p();
                case CardDB.cardIDEnum.GIL_902e:
                    return new Sim_GIL_902e();
                case CardDB.cardIDEnum.GILA_413:
                    return new Sim_GILA_413();
                case CardDB.cardIDEnum.GIL_142e:
                    return new Sim_GIL_142e();
                case CardDB.cardIDEnum.GIL_820:
                    return new Sim_GIL_820();
                case CardDB.cardIDEnum.GILA_BOSS_47h:
                    return new Sim_GILA_BOSS_47h();
                case CardDB.cardIDEnum.GILA_401:
                    return new Sim_GILA_401();
                case CardDB.cardIDEnum.GIL_596:
                    return new Sim_GIL_596();
                case CardDB.cardIDEnum.GIL_801:
                    return new Sim_GIL_801();
                case CardDB.cardIDEnum.GILA_810:
                    return new Sim_GILA_810();
                case CardDB.cardIDEnum.GILA_BOSS_52p:
                    return new Sim_GILA_BOSS_52p();
                case CardDB.cardIDEnum.GILA_BOSS_55t2:
                    return new Sim_GILA_BOSS_55t2();
                case CardDB.cardIDEnum.GIL_145:
                    return new Sim_GIL_145();
                case CardDB.cardIDEnum.GILA_598:
                    return new Sim_GILA_598();
                case CardDB.cardIDEnum.GIL_672:
                    return new Sim_GIL_672();
                case CardDB.cardIDEnum.GIL_529:
                    return new Sim_GIL_529();
                case CardDB.cardIDEnum.GIL_529t:
                    return new Sim_GIL_529t();
                case CardDB.cardIDEnum.GILA_BOSS_31p:
                    return new Sim_GILA_BOSS_31p();
                case CardDB.cardIDEnum.GIL_658:
                    return new Sim_GIL_658();
                case CardDB.cardIDEnum.GILA_BOSS_40h:
                    return new Sim_GILA_BOSS_40h();
                case CardDB.cardIDEnum.GIL_658e:
                    return new Sim_GIL_658e();
                case CardDB.cardIDEnum.GIL_616:
                    return new Sim_GIL_616();
                case CardDB.cardIDEnum.GIL_616t:
                    return new Sim_GIL_616t();
                case CardDB.cardIDEnum.GIL_672e:
                    return new Sim_GIL_672e();
                case CardDB.cardIDEnum.GILA_BOSS_61te:
                    return new Sim_GILA_BOSS_61te();
                case CardDB.cardIDEnum.GIL_513e:
                    return new Sim_GIL_513e();
                case CardDB.cardIDEnum.GILA_811:
                    return new Sim_GILA_811();
                case CardDB.cardIDEnum.GIL_835:
                    return new Sim_GIL_835();
                case CardDB.cardIDEnum.GILA_500t:
                    return new Sim_GILA_500t();
                case CardDB.cardIDEnum.GIL_624e:
                    return new Sim_GIL_624e();
                case CardDB.cardIDEnum.GILA_489:
                    return new Sim_GILA_489();
                case CardDB.cardIDEnum.GILA_BOSS_65p:
                    return new Sim_GILA_BOSS_65p();
                case CardDB.cardIDEnum.GIL_596e:
                    return new Sim_GIL_596e();
                case CardDB.cardIDEnum.GILA_511:
                    return new Sim_GILA_511();
                case CardDB.cardIDEnum.GILA_511e:
                    return new Sim_GILA_511e();
                case CardDB.cardIDEnum.GILA_497:
                    return new Sim_GILA_497();
                case CardDB.cardIDEnum.GIL_586e:
                    return new Sim_GIL_586e();
                case CardDB.cardIDEnum.GILA_602e3:
                    return new Sim_GILA_602e3();
                case CardDB.cardIDEnum.GILA_Darius_09:
                    return new Sim_GILA_Darius_09();
                case CardDB.cardIDEnum.GILA_904:
                    return new Sim_GILA_904();
                case CardDB.cardIDEnum.GILA_BOSS_26t:
                    return new Sim_GILA_BOSS_26t();
                case CardDB.cardIDEnum.GILA_821a:
                    return new Sim_GILA_821a();
                case CardDB.cardIDEnum.GILA_BOSS_41p:
                    return new Sim_GILA_BOSS_41p();
                case CardDB.cardIDEnum.GIL_816:
                    return new Sim_GIL_816();
                case CardDB.cardIDEnum.GIL_558:
                    return new Sim_GIL_558();
                case CardDB.cardIDEnum.GIL_200e:
                    return new Sim_GIL_200e();
                case CardDB.cardIDEnum.GIL_528:
                    return new Sim_GIL_528();
                case CardDB.cardIDEnum.GIL_528t:
                    return new Sim_GIL_528t();
                case CardDB.cardIDEnum.GILA_Darius_03:
                    return new Sim_GILA_Darius_03();
                case CardDB.cardIDEnum.GILA_603:
                    return new Sim_GILA_603();
                case CardDB.cardIDEnum.GILA_603e2:
                    return new Sim_GILA_603e2();
                case CardDB.cardIDEnum.GILA_BOSS_63p:
                    return new Sim_GILA_BOSS_63p();
                case CardDB.cardIDEnum.GIL_213:
                    return new Sim_GIL_213();
                case CardDB.cardIDEnum.GILA_900p:
                    return new Sim_GILA_900p();
                case CardDB.cardIDEnum.GILA_BOSS_58e:
                    return new Sim_GILA_BOSS_58e();
                case CardDB.cardIDEnum.GILA_BOSS_58p:
                    return new Sim_GILA_BOSS_58p();
                case CardDB.cardIDEnum.GIL_598:
                    return new Sim_GIL_598();
                case CardDB.cardIDEnum.GILA_500h3:
                    return new Sim_GILA_500h3();
                case CardDB.cardIDEnum.GILA_500h4:
                    return new Sim_GILA_500h4();
                case CardDB.cardIDEnum.GILA_508:
                    return new Sim_GILA_508();
                case CardDB.cardIDEnum.GIL_817:
                    return new Sim_GIL_817();
                case CardDB.cardIDEnum.GILA_BOSS_66h:
                    return new Sim_GILA_BOSS_66h();
                case CardDB.cardIDEnum.GILA_590:
                    return new Sim_GILA_590();
                case CardDB.cardIDEnum.GILA_BOSS_33h:
                    return new Sim_GILA_BOSS_33h();
                case CardDB.cardIDEnum.GILA_BOSS_50h:
                    return new Sim_GILA_BOSS_50h();
                case CardDB.cardIDEnum.GILA_498:
                    return new Sim_GILA_498();
                case CardDB.cardIDEnum.GILA_BOSS_39p:
                    return new Sim_GILA_BOSS_39p();
                case CardDB.cardIDEnum.GIL_119e:
                    return new Sim_GIL_119e();
                case CardDB.cardIDEnum.GIL_549:
                    return new Sim_GIL_549();
                case CardDB.cardIDEnum.GILA_900h:
                    return new Sim_GILA_900h();
                case CardDB.cardIDEnum.GILA_900h2:
                    return new Sim_GILA_900h2();
                case CardDB.cardIDEnum.GILA_510:
                    return new Sim_GILA_510();
                case CardDB.cardIDEnum.GIL_583:
                    return new Sim_GIL_583();
                case CardDB.cardIDEnum.GIL_580:
                    return new Sim_GIL_580();
                case CardDB.cardIDEnum.GIL_607:
                    return new Sim_GIL_607();
                case CardDB.cardIDEnum.GILA_851b:
                    return new Sim_GILA_851b();
                case CardDB.cardIDEnum.GILA_BOSS_25p:
                    return new Sim_GILA_BOSS_25p();
                case CardDB.cardIDEnum.GILA_596:
                    return new Sim_GILA_596();
                case CardDB.cardIDEnum.GIL_663t:
                    return new Sim_GIL_663t();
                case CardDB.cardIDEnum.GILA_611:
                    return new Sim_GILA_611();
                case CardDB.cardIDEnum.GILA_BOSS_33e:
                    return new Sim_GILA_BOSS_33e();
                case CardDB.cardIDEnum.GILA_BOSS_55p:
                    return new Sim_GILA_BOSS_55p();
                case CardDB.cardIDEnum.GILA_852ce:
                    return new Sim_GILA_852ce();
                case CardDB.cardIDEnum.GILA_499:
                    return new Sim_GILA_499();
                case CardDB.cardIDEnum.GIL_809:
                    return new Sim_GIL_809();
                case CardDB.cardIDEnum.GILA_BOSS_32p:
                    return new Sim_GILA_BOSS_32p();
                case CardDB.cardIDEnum.GILA_493:
                    return new Sim_GILA_493();
                case CardDB.cardIDEnum.GILA_BOSS_35t:
                    return new Sim_GILA_BOSS_35t();
                case CardDB.cardIDEnum.GILA_Darius_05:
                    return new Sim_GILA_Darius_05();
                case CardDB.cardIDEnum.GILA_507e:
                    return new Sim_GILA_507e();
                case CardDB.cardIDEnum.GILA_852c:
                    return new Sim_GILA_852c();
                case CardDB.cardIDEnum.GIL_664:
                    return new Sim_GIL_664();
                case CardDB.cardIDEnum.GIL_143:
                    return new Sim_GIL_143();
                case CardDB.cardIDEnum.ICC_828t7:
                    return new Sim_ICC_828t7();
                case CardDB.cardIDEnum.GILA_602:
                    return new Sim_GILA_602();
                case CardDB.cardIDEnum.GILA_602e2:
                    return new Sim_GILA_602e2();
                case CardDB.cardIDEnum.GIL_562:
                    return new Sim_GIL_562();
                case CardDB.cardIDEnum.ICC_828t6:
                    return new Sim_ICC_828t6();
                case CardDB.cardIDEnum.GIL_607e:
                    return new Sim_GIL_607e();
                case CardDB.cardIDEnum.GILA_BOSS_46h:
                    return new Sim_GILA_BOSS_46h();
                case CardDB.cardIDEnum.GIL_813:
                    return new Sim_GIL_813();
                case CardDB.cardIDEnum.GIL_614:
                    return new Sim_GIL_614();
                case CardDB.cardIDEnum.GIL_614e1:
                    return new Sim_GIL_614e1();
                case CardDB.cardIDEnum.GIL_614e2:
                    return new Sim_GIL_614e2();
                case CardDB.cardIDEnum.GIL_680:
                    return new Sim_GIL_680();
                case CardDB.cardIDEnum.GIL_687:
                    return new Sim_GIL_687();
                case CardDB.cardIDEnum.GILA_Darius_10:
                    return new Sim_GILA_Darius_10();
                case CardDB.cardIDEnum.GIL_654:
                    return new Sim_GIL_654();
                case CardDB.cardIDEnum.GILA_817t:
                    return new Sim_GILA_817t();
                case CardDB.cardIDEnum.GILA_818t:
                    return new Sim_GILA_818t();
                case CardDB.cardIDEnum.GILA_819t:
                    return new Sim_GILA_819t();
                case CardDB.cardIDEnum.GILA_BOSS_37h:
                    return new Sim_GILA_BOSS_37h();
                case CardDB.cardIDEnum.GILA_Toki_02:
                    return new Sim_GILA_Toki_02();
                case CardDB.cardIDEnum.GIL_518:
                    return new Sim_GIL_518();
                case CardDB.cardIDEnum.GILA_BOSS_64h:
                    return new Sim_GILA_BOSS_64h();
                case CardDB.cardIDEnum.GIL_553t:
                    return new Sim_GIL_553t();
                case CardDB.cardIDEnum.GILA_BOSS_55t:
                    return new Sim_GILA_BOSS_55t();
                case CardDB.cardIDEnum.GIL_553:
                    return new Sim_GIL_553();
                case CardDB.cardIDEnum.GIL_571:
                    return new Sim_GIL_571();
                case CardDB.cardIDEnum.GIL_531:
                    return new Sim_GIL_531();
                case CardDB.cardIDEnum.GIL_819:
                    return new Sim_GIL_819();
                case CardDB.cardIDEnum.GILA_BOSS_36p:
                    return new Sim_GILA_BOSS_36p();
                case CardDB.cardIDEnum.GIL_663:
                    return new Sim_GIL_663();
                case CardDB.cardIDEnum.GIL_623:
                    return new Sim_GIL_623();
                case CardDB.cardIDEnum.GIL_608:
                    return new Sim_GIL_608();
                case CardDB.cardIDEnum.GIL_584:
                    return new Sim_GIL_584();
                case CardDB.cardIDEnum.GILA_BOSS_99t:
                    return new Sim_GILA_BOSS_99t();
                case CardDB.cardIDEnum.GILA_BOSS_99t2:
                    return new Sim_GILA_BOSS_99t2();
                case CardDB.cardIDEnum.GILA_BOSS_99t3:
                    return new Sim_GILA_BOSS_99t3();
                case CardDB.cardIDEnum.GIL_616t2:
                    return new Sim_GIL_616t2();
                case CardDB.cardIDEnum.GIL_653e:
                    return new Sim_GIL_653e();
                case CardDB.cardIDEnum.GIL_653:
                    return new Sim_GIL_653();
                case CardDB.cardIDEnum.GIL_117:
                    return new Sim_GIL_117();
                case CardDB.cardIDEnum.GILA_851c:
                    return new Sim_GILA_851c();
                case CardDB.cardIDEnum.GIL_526:
                    return new Sim_GIL_526();
                case CardDB.cardIDEnum.GIL_600:
                    return new Sim_GIL_600();
 ///case CardDB.cardIDEnum.///GVG:
                    ///return new Sim_///GVG();
                case CardDB.cardIDEnum.GVG_029:
                    return new Sim_GVG_029();
                case CardDB.cardIDEnum.GVG_077:
                    return new Sim_GVG_077();
                case CardDB.cardIDEnum.GVG_085:
                    return new Sim_GVG_085();
                case CardDB.cardIDEnum.GVG_030:
                    return new Sim_GVG_030();
                case CardDB.cardIDEnum.GVG_069:
                    return new Sim_GVG_069();
                case CardDB.cardIDEnum.GVG_091:
                    return new Sim_GVG_091();
                case CardDB.cardIDEnum.GVG_086e:
                    return new Sim_GVG_086e();
                case CardDB.cardIDEnum.PART_001:
                    return new Sim_PART_001();
                case CardDB.cardIDEnum.PART_001e:
                    return new Sim_PART_001e();
                case CardDB.cardIDEnum.GVG_030a:
                    return new Sim_GVG_030a();
                case CardDB.cardIDEnum.GVG_030ae:
                    return new Sim_GVG_030ae();
                case CardDB.cardIDEnum.GVG_119:
                    return new Sim_GVG_119();
                case CardDB.cardIDEnum.GVG_063:
                    return new Sim_GVG_063();
                case CardDB.cardIDEnum.GVG_099:
                    return new Sim_GVG_099();
                case CardDB.cardIDEnum.GVG_110t:
                    return new Sim_GVG_110t();
                case CardDB.cardIDEnum.GVG_050:
                    return new Sim_GVG_050();
                case CardDB.cardIDEnum.GVG_100e:
                    return new Sim_GVG_100e();
                case CardDB.cardIDEnum.GVG_068:
                    return new Sim_GVG_068();
                case CardDB.cardIDEnum.GVG_056t:
                    return new Sim_GVG_056t();
                case CardDB.cardIDEnum.GVG_017:
                    return new Sim_GVG_017();
                case CardDB.cardIDEnum.GVG_041a:
                    return new Sim_GVG_041a();
                case CardDB.cardIDEnum.GVG_092t:
                    return new Sim_GVG_092t();
                case CardDB.cardIDEnum.PART_004e:
                    return new Sim_PART_004e();
                case CardDB.cardIDEnum.GVG_121:
                    return new Sim_GVG_121();
                case CardDB.cardIDEnum.GVG_082:
                    return new Sim_GVG_082();
                case CardDB.cardIDEnum.GVG_062:
                    return new Sim_GVG_062();
                case CardDB.cardIDEnum.GVG_073:
                    return new Sim_GVG_073();
                case CardDB.cardIDEnum.GVG_059:
                    return new Sim_GVG_059();
                case CardDB.cardIDEnum.GVG_013:
                    return new Sim_GVG_013();
                case CardDB.cardIDEnum.GVG_024:
                    return new Sim_GVG_024();
                case CardDB.cardIDEnum.GVG_038:
                    return new Sim_GVG_038();
                case CardDB.cardIDEnum.GVG_052:
                    return new Sim_GVG_052();
                case CardDB.cardIDEnum.GVG_041:
                    return new Sim_GVG_041();
                case CardDB.cardIDEnum.GVG_041c:
                    return new Sim_GVG_041c();
                case CardDB.cardIDEnum.GVG_015:
                    return new Sim_GVG_015();
                case CardDB.cardIDEnum.GVG_019:
                    return new Sim_GVG_019();
                case CardDB.cardIDEnum.GVG_019e:
                    return new Sim_GVG_019e();
                case CardDB.cardIDEnum.GVG_110:
                    return new Sim_GVG_110();
                case CardDB.cardIDEnum.GVG_080:
                    return new Sim_GVG_080();
                case CardDB.cardIDEnum.GVG_080t:
                    return new Sim_GVG_080t();
                case CardDB.cardIDEnum.GVG_066:
                    return new Sim_GVG_066();
                case CardDB.cardIDEnum.GVG_005:
                    return new Sim_GVG_005();
                case CardDB.cardIDEnum.PART_005:
                    return new Sim_PART_005();
                case CardDB.cardIDEnum.GVG_107:
                    return new Sim_GVG_107();
                case CardDB.cardIDEnum.GVG_051e:
                    return new Sim_GVG_051e();
                case CardDB.cardIDEnum.GVG_076:
                    return new Sim_GVG_076();
                case CardDB.cardIDEnum.GVG_023a:
                    return new Sim_GVG_023a();
                case CardDB.cardIDEnum.GVG_026:
                    return new Sim_GVG_026();
                case CardDB.cardIDEnum.GVG_020:
                    return new Sim_GVG_020();
                case CardDB.cardIDEnum.GVG_016:
                    return new Sim_GVG_016();
                case CardDB.cardIDEnum.PART_004:
                    return new Sim_PART_004();
                case CardDB.cardIDEnum.GVG_007:
                    return new Sim_GVG_007();
                case CardDB.cardIDEnum.GVG_001:
                    return new Sim_GVG_001();
                case CardDB.cardIDEnum.GVG_100:
                    return new Sim_GVG_100();
                case CardDB.cardIDEnum.GVG_084:
                    return new Sim_GVG_084();
                case CardDB.cardIDEnum.GVG_113:
                    return new Sim_GVG_113();
                case CardDB.cardIDEnum.GVG_079:
                    return new Sim_GVG_079();
                case CardDB.cardIDEnum.GVG_049:
                    return new Sim_GVG_049();
                case CardDB.cardIDEnum.GVG_028t:
                    return new Sim_GVG_028t();
                case CardDB.cardIDEnum.GVG_117:
                    return new Sim_GVG_117();
                case CardDB.cardIDEnum.GVG_032b:
                    return new Sim_GVG_032b();
                case CardDB.cardIDEnum.GVG_032a:
                    return new Sim_GVG_032a();
                case CardDB.cardIDEnum.GVG_081:
                    return new Sim_GVG_081();
                case CardDB.cardIDEnum.GVG_043:
                    return new Sim_GVG_043();
                case CardDB.cardIDEnum.GVG_043e:
                    return new Sim_GVG_043e();
                case CardDB.cardIDEnum.GVG_098:
                    return new Sim_GVG_098();
                case CardDB.cardIDEnum.GVG_092:
                    return new Sim_GVG_092();
                case CardDB.cardIDEnum.GVG_023:
                    return new Sim_GVG_023();
                case CardDB.cardIDEnum.GVG_004:
                    return new Sim_GVG_004();
                case CardDB.cardIDEnum.GVG_095:
                    return new Sim_GVG_095();
                case CardDB.cardIDEnum.GVG_021e:
                    return new Sim_GVG_021e();
                case CardDB.cardIDEnum.GVG_032:
                    return new Sim_GVG_032();
                case CardDB.cardIDEnum.GVG_120:
                    return new Sim_GVG_120();
                case CardDB.cardIDEnum.GVG_104a:
                    return new Sim_GVG_104a();
                case CardDB.cardIDEnum.GVG_104:
                    return new Sim_GVG_104();
                case CardDB.cardIDEnum.GVG_089:
                    return new Sim_GVG_089();
                case CardDB.cardIDEnum.GVG_045t:
                    return new Sim_GVG_045t();
                case CardDB.cardIDEnum.GVG_045:
                    return new Sim_GVG_045();
                case CardDB.cardIDEnum.GVG_056:
                    return new Sim_GVG_056();
                case CardDB.cardIDEnum.GVG_027:
                    return new Sim_GVG_027();
                case CardDB.cardIDEnum.GVG_027e:
                    return new Sim_GVG_027e();
                case CardDB.cardIDEnum.GVG_094:
                    return new Sim_GVG_094();
                case CardDB.cardIDEnum.GVG_106:
                    return new Sim_GVG_106();
                case CardDB.cardIDEnum.GVG_106e:
                    return new Sim_GVG_106e();
                case CardDB.cardIDEnum.GVG_074:
                    return new Sim_GVG_074();
                case CardDB.cardIDEnum.GVG_046:
                    return new Sim_GVG_046();
                case CardDB.cardIDEnum.GVG_012:
                    return new Sim_GVG_012();
                case CardDB.cardIDEnum.GVG_008:
                    return new Sim_GVG_008();
                case CardDB.cardIDEnum.GVG_097:
                    return new Sim_GVG_097();
                case CardDB.cardIDEnum.GVG_071:
                    return new Sim_GVG_071();
                case CardDB.cardIDEnum.GVG_090:
                    return new Sim_GVG_090();
                case CardDB.cardIDEnum.GVG_021:
                    return new Sim_GVG_021();
                case CardDB.cardIDEnum.GVG_035:
                    return new Sim_GVG_035();
                case CardDB.cardIDEnum.GVG_078:
                    return new Sim_GVG_078();
                case CardDB.cardIDEnum.GVG_034:
                    return new Sim_GVG_034();
                case CardDB.cardIDEnum.GVG_006:
                    return new Sim_GVG_006();
                case CardDB.cardIDEnum.GVG_116:
                    return new Sim_GVG_116();
                case CardDB.cardIDEnum.GVG_067a:
                    return new Sim_GVG_067a();
                case CardDB.cardIDEnum.GVG_068a:
                    return new Sim_GVG_068a();
                case CardDB.cardIDEnum.GVG_048e:
                    return new Sim_GVG_048e();
                case CardDB.cardIDEnum.GVG_048:
                    return new Sim_GVG_048();
                case CardDB.cardIDEnum.GVG_103:
                    return new Sim_GVG_103();
                case CardDB.cardIDEnum.GVG_102e:
                    return new Sim_GVG_102e();
                case CardDB.cardIDEnum.GVG_049e:
                    return new Sim_GVG_049e();
                case CardDB.cardIDEnum.GVG_111:
                    return new Sim_GVG_111();
                case CardDB.cardIDEnum.GVG_109:
                    return new Sim_GVG_109();
                case CardDB.cardIDEnum.GVG_112:
                    return new Sim_GVG_112();
                case CardDB.cardIDEnum.GVG_061:
                    return new Sim_GVG_061();
                case CardDB.cardIDEnum.GVG_041b:
                    return new Sim_GVG_041b();
                case CardDB.cardIDEnum.GVG_042:
                    return new Sim_GVG_042();
                case CardDB.cardIDEnum.GVG_065:
                    return new Sim_GVG_065();
                case CardDB.cardIDEnum.GVG_088:
                    return new Sim_GVG_088();
                case CardDB.cardIDEnum.GVG_054:
                    return new Sim_GVG_054();
                case CardDB.cardIDEnum.GVG_025:
                    return new Sim_GVG_025();
                case CardDB.cardIDEnum.GVG_123e:
                    return new Sim_GVG_123e();
                case CardDB.cardIDEnum.GVG_096:
                    return new Sim_GVG_096();
                case CardDB.cardIDEnum.GVG_105:
                    return new Sim_GVG_105();
                case CardDB.cardIDEnum.GVG_076a:
                    return new Sim_GVG_076a();
                case CardDB.cardIDEnum.GVG_036e:
                    return new Sim_GVG_036e();
                case CardDB.cardIDEnum.GVG_036:
                    return new Sim_GVG_036();
                case CardDB.cardIDEnum.GVG_064:
                    return new Sim_GVG_064();
                case CardDB.cardIDEnum.GVG_101e:
                    return new Sim_GVG_101e();
                case CardDB.cardIDEnum.GVG_060:
                    return new Sim_GVG_060();
                case CardDB.cardIDEnum.GVG_018:
                    return new Sim_GVG_018();
                case CardDB.cardIDEnum.GVG_108:
                    return new Sim_GVG_108();
                case CardDB.cardIDEnum.GVG_031:
                    return new Sim_GVG_031();
                case CardDB.cardIDEnum.GVG_069a:
                    return new Sim_GVG_069a();
                case CardDB.cardIDEnum.GVG_063a:
                    return new Sim_GVG_063a();
                case CardDB.cardIDEnum.PART_006:
                    return new Sim_PART_006();
                case CardDB.cardIDEnum.PART_003:
                    return new Sim_PART_003();
                case CardDB.cardIDEnum.GVG_047:
                    return new Sim_GVG_047();
                case CardDB.cardIDEnum.GVG_070:
                    return new Sim_GVG_070();
                case CardDB.cardIDEnum.GVG_101:
                    return new Sim_GVG_101();
                case CardDB.cardIDEnum.GVG_055:
                    return new Sim_GVG_055();
                case CardDB.cardIDEnum.GVG_055e:
                    return new Sim_GVG_055e();
                case CardDB.cardIDEnum.GVG_057:
                    return new Sim_GVG_057();
                case CardDB.cardIDEnum.GVG_057a:
                    return new Sim_GVG_057a();
                case CardDB.cardIDEnum.GVG_009:
                    return new Sim_GVG_009();
                case CardDB.cardIDEnum.GVG_072:
                    return new Sim_GVG_072();
                case CardDB.cardIDEnum.GVG_014a:
                    return new Sim_GVG_014a();
                case CardDB.cardIDEnum.GVG_058:
                    return new Sim_GVG_058();
                case CardDB.cardIDEnum.GVG_053:
                    return new Sim_GVG_053();
                case CardDB.cardIDEnum.GVG_075:
                    return new Sim_GVG_075();
                case CardDB.cardIDEnum.GVG_011:
                    return new Sim_GVG_011();
                case CardDB.cardIDEnum.GVG_011a:
                    return new Sim_GVG_011a();
                case CardDB.cardIDEnum.GVG_086:
                    return new Sim_GVG_086();
                case CardDB.cardIDEnum.GVG_040:
                    return new Sim_GVG_040();
                case CardDB.cardIDEnum.GVG_114:
                    return new Sim_GVG_114();
                case CardDB.cardIDEnum.GVG_002:
                    return new Sim_GVG_002();
                case CardDB.cardIDEnum.GVG_123:
                    return new Sim_GVG_123();
                case CardDB.cardIDEnum.GVG_122e:
                    return new Sim_GVG_122e();
                case CardDB.cardIDEnum.GVG_044:
                    return new Sim_GVG_044();
                case CardDB.cardIDEnum.GVG_087:
                    return new Sim_GVG_087();
                case CardDB.cardIDEnum.GVG_067:
                    return new Sim_GVG_067();
                case CardDB.cardIDEnum.PART_006a:
                    return new Sim_PART_006a();
                case CardDB.cardIDEnum.GVG_030b:
                    return new Sim_GVG_030b();
                case CardDB.cardIDEnum.GVG_030be:
                    return new Sim_GVG_030be();
                case CardDB.cardIDEnum.GVG_093:
                    return new Sim_GVG_093();
                case CardDB.cardIDEnum.GVG_046e:
                    return new Sim_GVG_046e();
                case CardDB.cardIDEnum.PART_002:
                    return new Sim_PART_002();
                case CardDB.cardIDEnum.GVG_022:
                    return new Sim_GVG_022();
                case CardDB.cardIDEnum.GVG_022a:
                    return new Sim_GVG_022a();
                case CardDB.cardIDEnum.GVG_022b:
                    return new Sim_GVG_022b();
                case CardDB.cardIDEnum.GVG_102:
                    return new Sim_GVG_102();
                case CardDB.cardIDEnum.GVG_115:
                    return new Sim_GVG_115();
                case CardDB.cardIDEnum.GVG_028:
                    return new Sim_GVG_028();
                case CardDB.cardIDEnum.GVG_033:
                    return new Sim_GVG_033();
                case CardDB.cardIDEnum.GVG_118:
                    return new Sim_GVG_118();
                case CardDB.cardIDEnum.GVG_003:
                    return new Sim_GVG_003();
                case CardDB.cardIDEnum.GVG_083:
                    return new Sim_GVG_083();
                case CardDB.cardIDEnum.GVG_111t:
                    return new Sim_GVG_111t();
                case CardDB.cardIDEnum.GVG_010:
                    return new Sim_GVG_010();
                case CardDB.cardIDEnum.GVG_010b:
                    return new Sim_GVG_010b();
                case CardDB.cardIDEnum.GVG_039:
                    return new Sim_GVG_039();
                case CardDB.cardIDEnum.GVG_014:
                    return new Sim_GVG_014();
                case CardDB.cardIDEnum.GVG_051:
                    return new Sim_GVG_051();
                case CardDB.cardIDEnum.GVG_006e:
                    return new Sim_GVG_006e();
                case CardDB.cardIDEnum.GVG_122:
                    return new Sim_GVG_122();
                case CardDB.cardIDEnum.GVG_060e:
                    return new Sim_GVG_060e();
                case CardDB.cardIDEnum.PART_007:
                    return new Sim_PART_007();
                case CardDB.cardIDEnum.PART_007e:
                    return new Sim_PART_007e();
                case CardDB.cardIDEnum.GVG_037:
                    return new Sim_GVG_037();
 ///case CardDB.cardIDEnum.///ICECROWN:
                    ///return new Sim_///ICECROWN();
                case CardDB.cardIDEnum.ICCA01_010:
                    return new Sim_ICCA01_010();
                case CardDB.cardIDEnum.ICC_825:
                    return new Sim_ICC_825();
                case CardDB.cardIDEnum.ICC_092:
                    return new Sim_ICC_092();
                case CardDB.cardIDEnum.ICC_212:
                    return new Sim_ICC_212();
                case CardDB.cardIDEnum.ICC_238:
                    return new Sim_ICC_238();
                case CardDB.cardIDEnum.ICC_314t7:
                    return new Sim_ICC_314t7();
                case CardDB.cardIDEnum.ICC_314t7e:
                    return new Sim_ICC_314t7e();
                case CardDB.cardIDEnum.ICC_215:
                    return new Sim_ICC_215();
                case CardDB.cardIDEnum.ICC_854:
                    return new Sim_ICC_854();
                case CardDB.cardIDEnum.ICC_097e:
                    return new Sim_ICC_097e();
                case CardDB.cardIDEnum.ICC_314t2:
                    return new Sim_ICC_314t2();
                case CardDB.cardIDEnum.ICCA01_004:
                    return new Sim_ICCA01_004();
                case CardDB.cardIDEnum.ICC_034:
                    return new Sim_ICC_034();
                case CardDB.cardIDEnum.ICC_210e:
                    return new Sim_ICC_210e();
                case CardDB.cardIDEnum.ICC_078:
                    return new Sim_ICC_078();
                case CardDB.cardIDEnum.ICC_031e:
                    return new Sim_ICC_031e();
                case CardDB.cardIDEnum.ICC_419:
                    return new Sim_ICC_419();
                case CardDB.cardIDEnum.ICCA05_020:
                    return new Sim_ICCA05_020();
                case CardDB.cardIDEnum.ICCA05_002e:
                    return new Sim_ICCA05_002e();
                case CardDB.cardIDEnum.ICC_245:
                    return new Sim_ICC_245();
                case CardDB.cardIDEnum.ICC_834h:
                    return new Sim_ICC_834h();
                case CardDB.cardIDEnum.ICC_028e:
                    return new Sim_ICC_028e();
                case CardDB.cardIDEnum.ICCA04_004:
                    return new Sim_ICCA04_004();
                case CardDB.cardIDEnum.ICCA09_001t1:
                    return new Sim_ICCA09_001t1();
                case CardDB.cardIDEnum.ICCA05_021:
                    return new Sim_ICCA05_021();
                case CardDB.cardIDEnum.ICC_064:
                    return new Sim_ICC_064();
                case CardDB.cardIDEnum.ICCA09_001p:
                    return new Sim_ICCA09_001p();
                case CardDB.cardIDEnum.ICCA01_003:
                    return new Sim_ICCA01_003();
                case CardDB.cardIDEnum.ICC_841:
                    return new Sim_ICC_841();
                case CardDB.cardIDEnum.ICCA05_001:
                    return new Sim_ICCA05_001();
                case CardDB.cardIDEnum.ICC_831:
                    return new Sim_ICC_831();
                case CardDB.cardIDEnum.ICC_903t:
                    return new Sim_ICC_903t();
                case CardDB.cardIDEnum.ICC_450e:
                    return new Sim_ICC_450e();
                case CardDB.cardIDEnum.ICC_810e:
                    return new Sim_ICC_810e();
                case CardDB.cardIDEnum.ICC_905:
                    return new Sim_ICC_905();
                case CardDB.cardIDEnum.ICC_858:
                    return new Sim_ICC_858();
                case CardDB.cardIDEnum.ICC_065:
                    return new Sim_ICC_065();
                case CardDB.cardIDEnum.ICC_027:
                    return new Sim_ICC_027();
                case CardDB.cardIDEnum.ICCA06_005:
                    return new Sim_ICCA06_005();
                case CardDB.cardIDEnum.ICCA06_004:
                    return new Sim_ICCA06_004();
                case CardDB.cardIDEnum.ICC_705:
                    return new Sim_ICC_705();
                case CardDB.cardIDEnum.ICC_705e:
                    return new Sim_ICC_705e();
                case CardDB.cardIDEnum.ICC_836:
                    return new Sim_ICC_836();
                case CardDB.cardIDEnum.ICC_837:
                    return new Sim_ICC_837();
                case CardDB.cardIDEnum.ICC_058:
                    return new Sim_ICC_058();
                case CardDB.cardIDEnum.ICCA06_003:
                    return new Sim_ICCA06_003();
                case CardDB.cardIDEnum.ICC_828p:
                    return new Sim_ICC_828p();
                case CardDB.cardIDEnum.ICC_837e:
                    return new Sim_ICC_837e();
                case CardDB.cardIDEnum.ICC_820:
                    return new Sim_ICC_820();
                case CardDB.cardIDEnum.ICC_094e:
                    return new Sim_ICC_094e();
                case CardDB.cardIDEnum.ICC_029:
                    return new Sim_ICC_029();
                case CardDB.cardIDEnum.ICC_252:
                    return new Sim_ICC_252();
                case CardDB.cardIDEnum.ICC_039e:
                    return new Sim_ICC_039e();
                case CardDB.cardIDEnum.ICC_257:
                    return new Sim_ICC_257();
                case CardDB.cardIDEnum.ICC_243:
                    return new Sim_ICC_243();
                case CardDB.cardIDEnum.ICC_912:
                    return new Sim_ICC_912();
                case CardDB.cardIDEnum.ICC_056:
                    return new Sim_ICC_056();
                case CardDB.cardIDEnum.ICC_808:
                    return new Sim_ICC_808();
                case CardDB.cardIDEnum.ICC_829t5:
                    return new Sim_ICC_829t5();
                case CardDB.cardIDEnum.ICC_039:
                    return new Sim_ICC_039();
                case CardDB.cardIDEnum.ICC_091:
                    return new Sim_ICC_091();
                case CardDB.cardIDEnum.ICC_220:
                    return new Sim_ICC_220();
                case CardDB.cardIDEnum.ICC_314t8:
                    return new Sim_ICC_314t8();
                case CardDB.cardIDEnum.ICC_314t5:
                    return new Sim_ICC_314t5();
                case CardDB.cardIDEnum.ICC_314t4:
                    return new Sim_ICC_314t4();
                case CardDB.cardIDEnum.ICC_450:
                    return new Sim_ICC_450();
                case CardDB.cardIDEnum.ICC_810:
                    return new Sim_ICC_810();
                case CardDB.cardIDEnum.ICCA09_002:
                    return new Sim_ICCA09_002();
                case CardDB.cardIDEnum.ICC_829t2:
                    return new Sim_ICC_829t2();
                case CardDB.cardIDEnum.ICC_827p:
                    return new Sim_ICC_827p();
                case CardDB.cardIDEnum.ICC_467:
                    return new Sim_ICC_467();
                case CardDB.cardIDEnum.ICC_828:
                    return new Sim_ICC_828();
                case CardDB.cardIDEnum.ICC_467e:
                    return new Sim_ICC_467e();
                case CardDB.cardIDEnum.ICC_047b:
                    return new Sim_ICC_047b();
                case CardDB.cardIDEnum.ICC_041:
                    return new Sim_ICC_041();
                case CardDB.cardIDEnum.ICC_244:
                    return new Sim_ICC_244();
                case CardDB.cardIDEnum.ICC_075:
                    return new Sim_ICC_075();
                case CardDB.cardIDEnum.ICC_207:
                    return new Sim_ICC_207();
                case CardDB.cardIDEnum.ICC_314t3:
                    return new Sim_ICC_314t3();
                case CardDB.cardIDEnum.ICC_083:
                    return new Sim_ICC_083();
                case CardDB.cardIDEnum.ICC_233:
                    return new Sim_ICC_233();
                case CardDB.cardIDEnum.ICC_083e:
                    return new Sim_ICC_083e();
                case CardDB.cardIDEnum.ICC_029e:
                    return new Sim_ICC_029e();
                case CardDB.cardIDEnum.ICC_055:
                    return new Sim_ICC_055();
                case CardDB.cardIDEnum.ICC_081:
                    return new Sim_ICC_081();
                case CardDB.cardIDEnum.ICC_901:
                    return new Sim_ICC_901();
                case CardDB.cardIDEnum.ICC_051:
                    return new Sim_ICC_051();
                case CardDB.cardIDEnum.ICC_051t:
                    return new Sim_ICC_051t();
                case CardDB.cardIDEnum.ICC_051t2:
                    return new Sim_ICC_051t2();
                case CardDB.cardIDEnum.ICC_051t3:
                    return new Sim_ICC_051t3();
                case CardDB.cardIDEnum.ICC_071e:
                    return new Sim_ICC_071e();
                case CardDB.cardIDEnum.ICCA01_007:
                    return new Sim_ICCA01_007();
                case CardDB.cardIDEnum.ICC_849:
                    return new Sim_ICC_849();
                case CardDB.cardIDEnum.ICC_849e:
                    return new Sim_ICC_849e();
                case CardDB.cardIDEnum.ICC_213:
                    return new Sim_ICC_213();
                case CardDB.cardIDEnum.ICC_243e:
                    return new Sim_ICC_243e();
                case CardDB.cardIDEnum.ICC_021:
                    return new Sim_ICC_021();
                case CardDB.cardIDEnum.ICC_904e:
                    return new Sim_ICC_904e();
                case CardDB.cardIDEnum.ICC_858e:
                    return new Sim_ICC_858e();
                case CardDB.cardIDEnum.ICCA08_022:
                    return new Sim_ICCA08_022();
                case CardDB.cardIDEnum.ICC_094:
                    return new Sim_ICC_094();
                case CardDB.cardIDEnum.ICC_832e:
                    return new Sim_ICC_832e();
                case CardDB.cardIDEnum.ICC_047:
                    return new Sim_ICC_047();
                case CardDB.cardIDEnum.ICC_047t:
                    return new Sim_ICC_047t();
                case CardDB.cardIDEnum.ICC_047t2:
                    return new Sim_ICC_047t2();
                case CardDB.cardIDEnum.ICCA07_008:
                    return new Sim_ICCA07_008();
                case CardDB.cardIDEnum.ICC_281:
                    return new Sim_ICC_281();
                case CardDB.cardIDEnum.ICC_093e:
                    return new Sim_ICC_093e();
                case CardDB.cardIDEnum.ICCA04_008p:
                    return new Sim_ICCA04_008p();
                case CardDB.cardIDEnum.ICCA04_009p:
                    return new Sim_ICCA04_009p();
                case CardDB.cardIDEnum.ICCA04_010p:
                    return new Sim_ICCA04_010p();
                case CardDB.cardIDEnum.ICC_833e:
                    return new Sim_ICC_833e();
                case CardDB.cardIDEnum.ICC_833:
                    return new Sim_ICC_833();
                case CardDB.cardIDEnum.ICC_901e:
                    return new Sim_ICC_901e();
                case CardDB.cardIDEnum.ICC_832t3:
                    return new Sim_ICC_832t3();
                case CardDB.cardIDEnum.ICC_314t1:
                    return new Sim_ICC_314t1();
                case CardDB.cardIDEnum.ICCA01_005:
                    return new Sim_ICCA01_005();
                case CardDB.cardIDEnum.ICCA08_020:
                    return new Sim_ICCA08_020();
                case CardDB.cardIDEnum.ICC_483e:
                    return new Sim_ICC_483e();
                case CardDB.cardIDEnum.ICC_056e:
                    return new Sim_ICC_056e();
                case CardDB.cardIDEnum.ICC_838t:
                    return new Sim_ICC_838t();
                case CardDB.cardIDEnum.ICC_082:
                    return new Sim_ICC_082();
                case CardDB.cardIDEnum.ICC_096:
                    return new Sim_ICC_096();
                case CardDB.cardIDEnum.ICC_069:
                    return new Sim_ICC_069();
                case CardDB.cardIDEnum.ICC_900t:
                    return new Sim_ICC_900t();
                case CardDB.cardIDEnum.ICCA01_004t:
                    return new Sim_ICCA01_004t();
                case CardDB.cardIDEnum.ICCA08_002t:
                    return new Sim_ICCA08_002t();
                case CardDB.cardIDEnum.ICC_085t:
                    return new Sim_ICC_085t();
                case CardDB.cardIDEnum.ICC_086:
                    return new Sim_ICC_086();
                case CardDB.cardIDEnum.ICC_079:
                    return new Sim_ICC_079();
                case CardDB.cardIDEnum.ICC_079e:
                    return new Sim_ICC_079e();
                case CardDB.cardIDEnum.ICC_407:
                    return new Sim_ICC_407();
                case CardDB.cardIDEnum.ICC_097:
                    return new Sim_ICC_097();
                case CardDB.cardIDEnum.ICC_829t:
                    return new Sim_ICC_829t();
                case CardDB.cardIDEnum.ICC_026:
                    return new Sim_ICC_026();
                case CardDB.cardIDEnum.ICCA07_004e:
                    return new Sim_ICCA07_004e();
                case CardDB.cardIDEnum.ICCA07_004:
                    return new Sim_ICCA07_004();
                case CardDB.cardIDEnum.ICC_047a:
                    return new Sim_ICC_047a();
                case CardDB.cardIDEnum.ICC_047e:
                    return new Sim_ICC_047e();
                case CardDB.cardIDEnum.ICC_835:
                    return new Sim_ICC_835();
                case CardDB.cardIDEnum.ICC_700:
                    return new Sim_ICC_700();
                case CardDB.cardIDEnum.ICCA08_032p:
                    return new Sim_ICCA08_032p();
                case CardDB.cardIDEnum.ICC_218:
                    return new Sim_ICC_218();
                case CardDB.cardIDEnum.ICC_801:
                    return new Sim_ICC_801();
                case CardDB.cardIDEnum.ICC_855:
                    return new Sim_ICC_855();
                case CardDB.cardIDEnum.ICC_236:
                    return new Sim_ICC_236();
                case CardDB.cardIDEnum.ICCA04_011p:
                    return new Sim_ICCA04_011p();
                case CardDB.cardIDEnum.ICC_089:
                    return new Sim_ICC_089();
                case CardDB.cardIDEnum.ICC_068:
                    return new Sim_ICC_068();
                case CardDB.cardIDEnum.ICC_833h:
                    return new Sim_ICC_833h();
                case CardDB.cardIDEnum.ICC_833e2:
                    return new Sim_ICC_833e2();
                case CardDB.cardIDEnum.ICC_829t4:
                    return new Sim_ICC_829t4();
                case CardDB.cardIDEnum.ICCA08_022e2:
                    return new Sim_ICCA08_022e2();
                case CardDB.cardIDEnum.ICCA08_022e:
                    return new Sim_ICCA08_022e();
                case CardDB.cardIDEnum.ICC_911:
                    return new Sim_ICC_911();
                case CardDB.cardIDEnum.ICC_851e:
                    return new Sim_ICC_851e();
                case CardDB.cardIDEnum.ICCA10_009:
                    return new Sim_ICCA10_009();
                case CardDB.cardIDEnum.ICC_221:
                    return new Sim_ICC_221();
                case CardDB.cardIDEnum.ICC_221e:
                    return new Sim_ICC_221e();
                case CardDB.cardIDEnum.ICC_071:
                    return new Sim_ICC_071();
                case CardDB.cardIDEnum.ICC_811:
                    return new Sim_ICC_811();
                case CardDB.cardIDEnum.ICCA06_001:
                    return new Sim_ICCA06_001();
                case CardDB.cardIDEnum.ICCA07_002p:
                    return new Sim_ICCA07_002p();
                case CardDB.cardIDEnum.ICCA07_003p:
                    return new Sim_ICCA07_003p();
                case CardDB.cardIDEnum.ICCA07_005p:
                    return new Sim_ICCA07_005p();
                case CardDB.cardIDEnum.ICC_832:
                    return new Sim_ICC_832();
                case CardDB.cardIDEnum.ICC_096e:
                    return new Sim_ICC_096e();
                case CardDB.cardIDEnum.ICC_812:
                    return new Sim_ICC_812();
                case CardDB.cardIDEnum.ICC_808e:
                    return new Sim_ICC_808e();
                case CardDB.cardIDEnum.ICC_902:
                    return new Sim_ICC_902();
                case CardDB.cardIDEnum.ICC_289:
                    return new Sim_ICC_289();
                case CardDB.cardIDEnum.ICC_062:
                    return new Sim_ICC_062();
                case CardDB.cardIDEnum.ICC_900:
                    return new Sim_ICC_900();
                case CardDB.cardIDEnum.ICCA08_023:
                    return new Sim_ICCA08_023();
                case CardDB.cardIDEnum.ICCA01_009:
                    return new Sim_ICCA01_009();
                case CardDB.cardIDEnum.ICC_706:
                    return new Sim_ICC_706();
                case CardDB.cardIDEnum.ICC_031:
                    return new Sim_ICC_031();
                case CardDB.cardIDEnum.ICC_314t6:
                    return new Sim_ICC_314t6();
                case CardDB.cardIDEnum.ICC_214:
                    return new Sim_ICC_214();
                case CardDB.cardIDEnum.ICC_018:
                    return new Sim_ICC_018();
                case CardDB.cardIDEnum.ICC_832p:
                    return new Sim_ICC_832p();
                case CardDB.cardIDEnum.ICC_809:
                    return new Sim_ICC_809();
                case CardDB.cardIDEnum.ICCA08_023e:
                    return new Sim_ICCA08_023e();
                case CardDB.cardIDEnum.ICC_052:
                    return new Sim_ICC_052();
                case CardDB.cardIDEnum.ICC_851:
                    return new Sim_ICC_851();
                case CardDB.cardIDEnum.ICC_852:
                    return new Sim_ICC_852();
                case CardDB.cardIDEnum.ICC_853:
                    return new Sim_ICC_853();
                case CardDB.cardIDEnum.ICC_204:
                    return new Sim_ICC_204();
                case CardDB.cardIDEnum.ICCA07_001:
                    return new Sim_ICCA07_001();
                case CardDB.cardIDEnum.ICCA07_001h2:
                    return new Sim_ICCA07_001h2();
                case CardDB.cardIDEnum.ICCA07_001h3:
                    return new Sim_ICCA07_001h3();
                case CardDB.cardIDEnum.ICCA08_025:
                    return new Sim_ICCA08_025();
                case CardDB.cardIDEnum.ICC_025:
                    return new Sim_ICC_025();
                case CardDB.cardIDEnum.ICC_257e:
                    return new Sim_ICC_257e();
                case CardDB.cardIDEnum.ICC_244e:
                    return new Sim_ICC_244e();
                case CardDB.cardIDEnum.ICCA08_030p:
                    return new Sim_ICCA08_030p();
                case CardDB.cardIDEnum.ICC_240e:
                    return new Sim_ICC_240e();
                case CardDB.cardIDEnum.ICC_038:
                    return new Sim_ICC_038();
                case CardDB.cardIDEnum.ICC_201:
                    return new Sim_ICC_201();
                case CardDB.cardIDEnum.ICC_405:
                    return new Sim_ICC_405();
                case CardDB.cardIDEnum.ICC_240:
                    return new Sim_ICC_240();
                case CardDB.cardIDEnum.ICC_903:
                    return new Sim_ICC_903();
                case CardDB.cardIDEnum.ICC_466:
                    return new Sim_ICC_466();
                case CardDB.cardIDEnum.ICC_832t4:
                    return new Sim_ICC_832t4();
                case CardDB.cardIDEnum.ICC_051b:
                    return new Sim_ICC_051b();
                case CardDB.cardIDEnum.ICC_832a:
                    return new Sim_ICC_832a();
                case CardDB.cardIDEnum.ICC_832pa:
                    return new Sim_ICC_832pa();
                case CardDB.cardIDEnum.ICC_834:
                    return new Sim_ICC_834();
                case CardDB.cardIDEnum.ICC_850e:
                    return new Sim_ICC_850e();
                case CardDB.cardIDEnum.ICC_210:
                    return new Sim_ICC_210();
                case CardDB.cardIDEnum.ICC_235:
                    return new Sim_ICC_235();
                case CardDB.cardIDEnum.ICC_235e:
                    return new Sim_ICC_235e();
                case CardDB.cardIDEnum.ICC_827e:
                    return new Sim_ICC_827e();
                case CardDB.cardIDEnum.ICC_827t:
                    return new Sim_ICC_827t();
                case CardDB.cardIDEnum.ICC_850:
                    return new Sim_ICC_850();
                case CardDB.cardIDEnum.ICC_834w:
                    return new Sim_ICC_834w();
                case CardDB.cardIDEnum.ICC_830:
                    return new Sim_ICC_830();
                case CardDB.cardIDEnum.ICC_702:
                    return new Sim_ICC_702();
                case CardDB.cardIDEnum.ICCA08_029:
                    return new Sim_ICCA08_029();
                case CardDB.cardIDEnum.ICC_823:
                    return new Sim_ICC_823();
                case CardDB.cardIDEnum.ICC_838:
                    return new Sim_ICC_838();
                case CardDB.cardIDEnum.ICCA04_001:
                    return new Sim_ICCA04_001();
                case CardDB.cardIDEnum.ICC_831p:
                    return new Sim_ICC_831p();
                case CardDB.cardIDEnum.ICC_019:
                    return new Sim_ICC_019();
                case CardDB.cardIDEnum.ICC_025t:
                    return new Sim_ICC_025t();
                case CardDB.cardIDEnum.ICC_019t:
                    return new Sim_ICC_019t();
                case CardDB.cardIDEnum.ICCA11_001:
                    return new Sim_ICCA11_001();
                case CardDB.cardIDEnum.ICCA06_002p:
                    return new Sim_ICCA06_002p();
                case CardDB.cardIDEnum.ICC_026t:
                    return new Sim_ICC_026t();
                case CardDB.cardIDEnum.ICC_701:
                    return new Sim_ICC_701();
                case CardDB.cardIDEnum.ICCA05_003:
                    return new Sim_ICCA05_003();
                case CardDB.cardIDEnum.ICC_023:
                    return new Sim_ICC_023();
                case CardDB.cardIDEnum.ICC_090:
                    return new Sim_ICC_090();
                case CardDB.cardIDEnum.ICCA08_026:
                    return new Sim_ICCA08_026();
                case CardDB.cardIDEnum.ICC_910:
                    return new Sim_ICC_910();
                case CardDB.cardIDEnum.ICC_856:
                    return new Sim_ICC_856();
                case CardDB.cardIDEnum.ICC_832pb:
                    return new Sim_ICC_832pb();
                case CardDB.cardIDEnum.ICC_051a:
                    return new Sim_ICC_051a();
                case CardDB.cardIDEnum.ICC_832b:
                    return new Sim_ICC_832b();
                case CardDB.cardIDEnum.ICC_802:
                    return new Sim_ICC_802();
                case CardDB.cardIDEnum.ICC_054:
                    return new Sim_ICC_054();
                case CardDB.cardIDEnum.ICC_828e:
                    return new Sim_ICC_828e();
                case CardDB.cardIDEnum.ICC_415:
                    return new Sim_ICC_415();
                case CardDB.cardIDEnum.ICC_807e:
                    return new Sim_ICC_807e();
                case CardDB.cardIDEnum.ICC_807:
                    return new Sim_ICC_807();
                case CardDB.cardIDEnum.ICC_028:
                    return new Sim_ICC_028();
                case CardDB.cardIDEnum.ICC_913:
                    return new Sim_ICC_913();
                case CardDB.cardIDEnum.ICC_852e:
                    return new Sim_ICC_852e();
                case CardDB.cardIDEnum.ICCA07_020:
                    return new Sim_ICCA07_020();
                case CardDB.cardIDEnum.ICCA01_008:
                    return new Sim_ICCA01_008();
                case CardDB.cardIDEnum.ICC_809e:
                    return new Sim_ICC_809e();
                case CardDB.cardIDEnum.ICC_829p:
                    return new Sim_ICC_829p();
                case CardDB.cardIDEnum.ICCA08_024:
                    return new Sim_ICCA08_024();
                case CardDB.cardIDEnum.ICC_314:
                    return new Sim_ICC_314();
                case CardDB.cardIDEnum.ICCA01_001:
                    return new Sim_ICCA01_001();
                case CardDB.cardIDEnum.ICCA08_001:
                    return new Sim_ICCA08_001();
                case CardDB.cardIDEnum.ICCA08_028:
                    return new Sim_ICCA08_028();
                case CardDB.cardIDEnum.ICCA08_002p:
                    return new Sim_ICCA08_002p();
                case CardDB.cardIDEnum.ICCA08_027:
                    return new Sim_ICCA08_027();
                case CardDB.cardIDEnum.ICCA08_021:
                    return new Sim_ICCA08_021();
                case CardDB.cardIDEnum.ICC_829t3:
                    return new Sim_ICC_829t3();
                case CardDB.cardIDEnum.ICC_481:
                    return new Sim_ICC_481();
                case CardDB.cardIDEnum.ICC_099:
                    return new Sim_ICC_099();
                case CardDB.cardIDEnum.ICCA01_013:
                    return new Sim_ICCA01_013();
                case CardDB.cardIDEnum.ICC_098:
                    return new Sim_ICC_098();
                case CardDB.cardIDEnum.ICC_049:
                    return new Sim_ICC_049();
                case CardDB.cardIDEnum.ICC_049e:
                    return new Sim_ICC_049e();
                case CardDB.cardIDEnum.ICC_481p:
                    return new Sim_ICC_481p();
                case CardDB.cardIDEnum.ICC_314t1e:
                    return new Sim_ICC_314t1e();
                case CardDB.cardIDEnum.ICCA08_033:
                    return new Sim_ICCA08_033();
                case CardDB.cardIDEnum.ICC_206:
                    return new Sim_ICC_206();
                case CardDB.cardIDEnum.ICC_093:
                    return new Sim_ICC_093();
                case CardDB.cardIDEnum.ICC_085:
                    return new Sim_ICC_085();
                case CardDB.cardIDEnum.ICCA04_002:
                    return new Sim_ICCA04_002();
                case CardDB.cardIDEnum.ICC_706e:
                    return new Sim_ICC_706e();
                case CardDB.cardIDEnum.ICC_469:
                    return new Sim_ICC_469();
                case CardDB.cardIDEnum.ICC_829:
                    return new Sim_ICC_829();
                case CardDB.cardIDEnum.ICC_827:
                    return new Sim_ICC_827();
                case CardDB.cardIDEnum.ICCA10_001:
                    return new Sim_ICCA10_001();
                case CardDB.cardIDEnum.ICCA08_017:
                    return new Sim_ICCA08_017();
                case CardDB.cardIDEnum.ICC_408:
                    return new Sim_ICC_408();
                case CardDB.cardIDEnum.ICC_841e:
                    return new Sim_ICC_841e();
                case CardDB.cardIDEnum.ICCA05_002p:
                    return new Sim_ICCA05_002p();
                case CardDB.cardIDEnum.ICCA05_004p:
                    return new Sim_ICCA05_004p();
                case CardDB.cardIDEnum.ICC_827e3:
                    return new Sim_ICC_827e3();
                case CardDB.cardIDEnum.ICC_032:
                    return new Sim_ICC_032();
                case CardDB.cardIDEnum.ICC_200:
                    return new Sim_ICC_200();
                case CardDB.cardIDEnum.ICC_092e:
                    return new Sim_ICC_092e();
                case CardDB.cardIDEnum.ICC_830p:
                    return new Sim_ICC_830p();
                case CardDB.cardIDEnum.ICC_088:
                    return new Sim_ICC_088();
                case CardDB.cardIDEnum.ICC_067:
                    return new Sim_ICC_067();
                case CardDB.cardIDEnum.ICCA01_011:
                    return new Sim_ICCA01_011();
                case CardDB.cardIDEnum.ICC_833t:
                    return new Sim_ICC_833t();
                case CardDB.cardIDEnum.ICC_050:
                    return new Sim_ICC_050();
                case CardDB.cardIDEnum.ICCA10_009p:
                    return new Sim_ICCA10_009p();
                case CardDB.cardIDEnum.ICC_904:
                    return new Sim_ICC_904();
                case CardDB.cardIDEnum.ICC_018e:
                    return new Sim_ICC_018e();
                case CardDB.cardIDEnum.ICC_468:
                    return new Sim_ICC_468();
                case CardDB.cardIDEnum.ICC_800h3t:
                    return new Sim_ICC_800h3t();
                case CardDB.cardIDEnum.ICC_828t:
                    return new Sim_ICC_828t();
 ///case CardDB.cardIDEnum.///UNGORO:
                    ///return new Sim_///UNGORO();
                case CardDB.cardIDEnum.UNG_961:
                    return new Sim_UNG_961();
                case CardDB.cardIDEnum.UNG_019:
                    return new Sim_UNG_019();
                case CardDB.cardIDEnum.UNG_940t8:
                    return new Sim_UNG_940t8();
                case CardDB.cardIDEnum.UNG_020:
                    return new Sim_UNG_020();
                case CardDB.cardIDEnum.UNG_940:
                    return new Sim_UNG_940();
                case CardDB.cardIDEnum.UNG_116t:
                    return new Sim_UNG_116t();
                case CardDB.cardIDEnum.UNG_030:
                    return new Sim_UNG_030();
                case CardDB.cardIDEnum.UNG_063:
                    return new Sim_UNG_063();
                case CardDB.cardIDEnum.UNG_087:
                    return new Sim_UNG_087();
                case CardDB.cardIDEnum.UNG_847:
                    return new Sim_UNG_847();
                case CardDB.cardIDEnum.UNG_832:
                    return new Sim_UNG_832();
                case CardDB.cardIDEnum.UNG_113:
                    return new Sim_UNG_113();
                case CardDB.cardIDEnum.UNG_920t2:
                    return new Sim_UNG_920t2();
                case CardDB.cardIDEnum.UNG_099:
                    return new Sim_UNG_099();
                case CardDB.cardIDEnum.UNG_835:
                    return new Sim_UNG_835();
                case CardDB.cardIDEnum.UNG_922t1:
                    return new Sim_UNG_922t1();
                case CardDB.cardIDEnum.UNG_836:
                    return new Sim_UNG_836();
                case CardDB.cardIDEnum.UNG_926:
                    return new Sim_UNG_926();
                case CardDB.cardIDEnum.UNG_831:
                    return new Sim_UNG_831();
                case CardDB.cardIDEnum.UNG_831e:
                    return new Sim_UNG_831e();
                case CardDB.cardIDEnum.UNG_915:
                    return new Sim_UNG_915();
                case CardDB.cardIDEnum.UNG_999t8:
                    return new Sim_UNG_999t8();
                case CardDB.cardIDEnum.UNG_999t8e:
                    return new Sim_UNG_999t8e();
                case CardDB.cardIDEnum.UNG_830:
                    return new Sim_UNG_830();
                case CardDB.cardIDEnum.UNG_067t1:
                    return new Sim_UNG_067t1();
                case CardDB.cardIDEnum.UNG_032:
                    return new Sim_UNG_032();
                case CardDB.cardIDEnum.UNG_067t1e:
                    return new Sim_UNG_067t1e();
                case CardDB.cardIDEnum.UNG_067t1e2:
                    return new Sim_UNG_067t1e2();
                case CardDB.cardIDEnum.UNG_067t1e3:
                    return new Sim_UNG_067t1e3();
                case CardDB.cardIDEnum.UNG_035:
                    return new Sim_UNG_035();
                case CardDB.cardIDEnum.UNG_832e:
                    return new Sim_UNG_832e();
                case CardDB.cardIDEnum.UNG_083t1:
                    return new Sim_UNG_083t1();
                case CardDB.cardIDEnum.UNG_083:
                    return new Sim_UNG_083();
                case CardDB.cardIDEnum.UNG_934t2:
                    return new Sim_UNG_934t2();
                case CardDB.cardIDEnum.UNG_917:
                    return new Sim_UNG_917();
                case CardDB.cardIDEnum.UNG_917t1:
                    return new Sim_UNG_917t1();
                case CardDB.cardIDEnum.UNG_004:
                    return new Sim_UNG_004();
                case CardDB.cardIDEnum.UNG_101b:
                    return new Sim_UNG_101b();
                case CardDB.cardIDEnum.UNG_957:
                    return new Sim_UNG_957();
                case CardDB.cardIDEnum.UNG_957t1:
                    return new Sim_UNG_957t1();
                case CardDB.cardIDEnum.UNG_108:
                    return new Sim_UNG_108();
                case CardDB.cardIDEnum.UNG_956e:
                    return new Sim_UNG_956e();
                case CardDB.cardIDEnum.UNG_076:
                    return new Sim_UNG_076();
                case CardDB.cardIDEnum.UNG_109:
                    return new Sim_UNG_109();
                case CardDB.cardIDEnum.UNG_851:
                    return new Sim_UNG_851();
                case CardDB.cardIDEnum.UNG_085e:
                    return new Sim_UNG_085e();
                case CardDB.cardIDEnum.UNG_085:
                    return new Sim_UNG_085();
                case CardDB.cardIDEnum.UNG_803:
                    return new Sim_UNG_803();
                case CardDB.cardIDEnum.UNG_823:
                    return new Sim_UNG_823();
                case CardDB.cardIDEnum.UNG_823e:
                    return new Sim_UNG_823e();
                case CardDB.cardIDEnum.UNG_823ed:
                    return new Sim_UNG_823ed();
                case CardDB.cardIDEnum.UNG_103:
                    return new Sim_UNG_103();
                case CardDB.cardIDEnum.UNG_922:
                    return new Sim_UNG_922();
                case CardDB.cardIDEnum.OG_044e:
                    return new Sim_OG_044e();
                case CardDB.cardIDEnum.UNG_834:
                    return new Sim_UNG_834();
                case CardDB.cardIDEnum.UNG_202e:
                    return new Sim_UNG_202e();
                case CardDB.cardIDEnum.UNG_809:
                    return new Sim_UNG_809();
                case CardDB.cardIDEnum.UNG_202:
                    return new Sim_UNG_202();
                case CardDB.cardIDEnum.UNG_084:
                    return new Sim_UNG_084();
                case CardDB.cardIDEnum.UNG_934:
                    return new Sim_UNG_934();
                case CardDB.cardIDEnum.UNG_809t1:
                    return new Sim_UNG_809t1();
                case CardDB.cardIDEnum.UNG_018:
                    return new Sim_UNG_018();
                case CardDB.cardIDEnum.UNG_999t3:
                    return new Sim_UNG_999t3();
                case CardDB.cardIDEnum.UNG_999t3e:
                    return new Sim_UNG_999t3e();
                case CardDB.cardIDEnum.UNG_854:
                    return new Sim_UNG_854();
                case CardDB.cardIDEnum.UNG_079:
                    return new Sim_UNG_079();
                case CardDB.cardIDEnum.UNG_954t1:
                    return new Sim_UNG_954t1();
                case CardDB.cardIDEnum.UNG_089:
                    return new Sim_UNG_089();
                case CardDB.cardIDEnum.UNG_086:
                    return new Sim_UNG_086();
                case CardDB.cardIDEnum.UNG_071:
                    return new Sim_UNG_071();
                case CardDB.cardIDEnum.ICC_828t3:
                    return new Sim_ICC_828t3();
                case CardDB.cardIDEnum.UNG_814:
                    return new Sim_UNG_814();
                case CardDB.cardIDEnum.UNG_205:
                    return new Sim_UNG_205();
                case CardDB.cardIDEnum.UNG_946:
                    return new Sim_UNG_946();
                case CardDB.cardIDEnum.UNG_807:
                    return new Sim_UNG_807();
                case CardDB.cardIDEnum.UNG_910:
                    return new Sim_UNG_910();
                case CardDB.cardIDEnum.UNG_856:
                    return new Sim_UNG_856();
                case CardDB.cardIDEnum.UNG_840:
                    return new Sim_UNG_840();
                case CardDB.cardIDEnum.UNG_938:
                    return new Sim_UNG_938();
                case CardDB.cardIDEnum.UNG_844:
                    return new Sim_UNG_844();
                case CardDB.cardIDEnum.UNG_011:
                    return new Sim_UNG_011();
                case CardDB.cardIDEnum.UNG_845:
                    return new Sim_UNG_845();
                case CardDB.cardIDEnum.UNG_953e:
                    return new Sim_UNG_953e();
                case CardDB.cardIDEnum.UNG_211d:
                    return new Sim_UNG_211d();
                case CardDB.cardIDEnum.UNG_211a:
                    return new Sim_UNG_211a();
                case CardDB.cardIDEnum.UNG_211c:
                    return new Sim_UNG_211c();
                case CardDB.cardIDEnum.UNG_211b:
                    return new Sim_UNG_211b();
                case CardDB.cardIDEnum.UNG_923:
                    return new Sim_UNG_923();
                case CardDB.cardIDEnum.UNG_108e:
                    return new Sim_UNG_108e();
                case CardDB.cardIDEnum.UNG_912:
                    return new Sim_UNG_912();
                case CardDB.cardIDEnum.UNG_116:
                    return new Sim_UNG_116();
                case CardDB.cardIDEnum.UNG_907e:
                    return new Sim_UNG_907e();
                case CardDB.cardIDEnum.UNG_211:
                    return new Sim_UNG_211();
                case CardDB.cardIDEnum.UNG_933:
                    return new Sim_UNG_933();
                case CardDB.cardIDEnum.UNG_833:
                    return new Sim_UNG_833();
                case CardDB.cardIDEnum.UNG_829:
                    return new Sim_UNG_829();
                case CardDB.cardIDEnum.UNG_962:
                    return new Sim_UNG_962();
                case CardDB.cardIDEnum.UNG_999t7:
                    return new Sim_UNG_999t7();
                case CardDB.cardIDEnum.UNG_999t7e:
                    return new Sim_UNG_999t7e();
                case CardDB.cardIDEnum.UNG_999t5:
                    return new Sim_UNG_999t5();
                case CardDB.cardIDEnum.UNG_999t5e:
                    return new Sim_UNG_999t5e();
                case CardDB.cardIDEnum.UNG_111:
                    return new Sim_UNG_111();
                case CardDB.cardIDEnum.UNG_999t2:
                    return new Sim_UNG_999t2();
                case CardDB.cardIDEnum.UNG_999t2e:
                    return new Sim_UNG_999t2e();
                case CardDB.cardIDEnum.UNG_960:
                    return new Sim_UNG_960();
                case CardDB.cardIDEnum.UNG_963:
                    return new Sim_UNG_963();
                case CardDB.cardIDEnum.UNG_929e:
                    return new Sim_UNG_929e();
                case CardDB.cardIDEnum.UNG_024:
                    return new Sim_UNG_024();
                case CardDB.cardIDEnum.UNG_111t1:
                    return new Sim_UNG_111t1();
                case CardDB.cardIDEnum.UNG_999t6:
                    return new Sim_UNG_999t6();
                case CardDB.cardIDEnum.UNG_999t6e:
                    return new Sim_UNG_999t6e();
                case CardDB.cardIDEnum.UNG_942t:
                    return new Sim_UNG_942t();
                case CardDB.cardIDEnum.UNG_955:
                    return new Sim_UNG_955();
                case CardDB.cardIDEnum.UNG_060:
                    return new Sim_UNG_060();
                case CardDB.cardIDEnum.UNG_022e:
                    return new Sim_UNG_022e();
                case CardDB.cardIDEnum.UNG_022:
                    return new Sim_UNG_022();
                case CardDB.cardIDEnum.UNG_929:
                    return new Sim_UNG_929();
                case CardDB.cardIDEnum.UNG_948:
                    return new Sim_UNG_948();
                case CardDB.cardIDEnum.UNG_801:
                    return new Sim_UNG_801();
                case CardDB.cardIDEnum.UNG_829t3:
                    return new Sim_UNG_829t3();
                case CardDB.cardIDEnum.UNG_829t1:
                    return new Sim_UNG_829t1();
                case CardDB.cardIDEnum.UNG_829t2:
                    return new Sim_UNG_829t2();
                case CardDB.cardIDEnum.UNG_061:
                    return new Sim_UNG_061();
                case CardDB.cardIDEnum.UNG_952e:
                    return new Sim_UNG_952e();
                case CardDB.cardIDEnum.UNG_028:
                    return new Sim_UNG_028();
                case CardDB.cardIDEnum.UNG_925:
                    return new Sim_UNG_925();
                case CardDB.cardIDEnum.UNG_807e:
                    return new Sim_UNG_807e();
                case CardDB.cardIDEnum.UNG_907:
                    return new Sim_UNG_907();
                case CardDB.cardIDEnum.UNG_999t2t1:
                    return new Sim_UNG_999t2t1();
                case CardDB.cardIDEnum.UNG_999t13:
                    return new Sim_UNG_999t13();
                case CardDB.cardIDEnum.UNG_999t13e:
                    return new Sim_UNG_999t13e();
                case CardDB.cardIDEnum.UNG_941e:
                    return new Sim_UNG_941e();
                case CardDB.cardIDEnum.UNG_201t:
                    return new Sim_UNG_201t();
                case CardDB.cardIDEnum.UNG_953:
                    return new Sim_UNG_953();
                case CardDB.cardIDEnum.UNG_937:
                    return new Sim_UNG_937();
                case CardDB.cardIDEnum.UNG_201:
                    return new Sim_UNG_201();
                case CardDB.cardIDEnum.UNG_848:
                    return new Sim_UNG_848();
                case CardDB.cardIDEnum.UNG_941:
                    return new Sim_UNG_941();
                case CardDB.cardIDEnum.UNG_834t1:
                    return new Sim_UNG_834t1();
                case CardDB.cardIDEnum.UNG_001:
                    return new Sim_UNG_001();
                case CardDB.cardIDEnum.UNG_027:
                    return new Sim_UNG_027();
                case CardDB.cardIDEnum.UNG_027t2:
                    return new Sim_UNG_027t2();
                case CardDB.cardIDEnum.UNG_027t4:
                    return new Sim_UNG_027t4();
                case CardDB.cardIDEnum.UNG_920t1:
                    return new Sim_UNG_920t1();
                case CardDB.cardIDEnum.UNG_004e:
                    return new Sim_UNG_004e();
                case CardDB.cardIDEnum.UNG_034:
                    return new Sim_UNG_034();
                case CardDB.cardIDEnum.UNG_034e:
                    return new Sim_UNG_034e();
                case CardDB.cardIDEnum.UNG_076t1:
                    return new Sim_UNG_076t1();
                case CardDB.cardIDEnum.UNG_101a:
                    return new Sim_UNG_101a();
                case CardDB.cardIDEnum.UNG_914:
                    return new Sim_UNG_914();
                case CardDB.cardIDEnum.UNG_914t1:
                    return new Sim_UNG_914t1();
                case CardDB.cardIDEnum.UNG_009:
                    return new Sim_UNG_009();
                case CardDB.cardIDEnum.UNG_047:
                    return new Sim_UNG_047();
                case CardDB.cardIDEnum.UNG_057t1:
                    return new Sim_UNG_057t1();
                case CardDB.cardIDEnum.UNG_058:
                    return new Sim_UNG_058();
                case CardDB.cardIDEnum.UNG_057:
                    return new Sim_UNG_057();
                case CardDB.cardIDEnum.UNG_836e:
                    return new Sim_UNG_836e();
                case CardDB.cardIDEnum.UNG_208t:
                    return new Sim_UNG_208t();
                case CardDB.cardIDEnum.UNG_073:
                    return new Sim_UNG_073();
                case CardDB.cardIDEnum.UNG_999t4:
                    return new Sim_UNG_999t4();
                case CardDB.cardIDEnum.UNG_999t4e:
                    return new Sim_UNG_999t4e();
                case CardDB.cardIDEnum.UNG_116te:
                    return new Sim_UNG_116te();
                case CardDB.cardIDEnum.UNG_812:
                    return new Sim_UNG_812();
                case CardDB.cardIDEnum.UNG_010:
                    return new Sim_UNG_010();
                case CardDB.cardIDEnum.UNG_113e:
                    return new Sim_UNG_113e();
                case CardDB.cardIDEnum.UNG_816:
                    return new Sim_UNG_816();
                case CardDB.cardIDEnum.UNG_029:
                    return new Sim_UNG_029();
                case CardDB.cardIDEnum.UNG_037e:
                    return new Sim_UNG_037e();
                case CardDB.cardIDEnum.UNG_101:
                    return new Sim_UNG_101();
                case CardDB.cardIDEnum.UNG_101t:
                    return new Sim_UNG_101t();
                case CardDB.cardIDEnum.UNG_101t2:
                    return new Sim_UNG_101t2();
                case CardDB.cardIDEnum.UNG_101t3:
                    return new Sim_UNG_101t3();
                case CardDB.cardIDEnum.UNG_065:
                    return new Sim_UNG_065();
                case CardDB.cardIDEnum.UNG_065t:
                    return new Sim_UNG_065t();
                case CardDB.cardIDEnum.UNG_846:
                    return new Sim_UNG_846();
                case CardDB.cardIDEnum.UNG_999t10:
                    return new Sim_UNG_999t10();
                case CardDB.cardIDEnum.UNG_999t10e:
                    return new Sim_UNG_999t10e();
                case CardDB.cardIDEnum.UNG_952:
                    return new Sim_UNG_952();
                case CardDB.cardIDEnum.UNG_956:
                    return new Sim_UNG_956();
                case CardDB.cardIDEnum.UNG_900:
                    return new Sim_UNG_900();
                case CardDB.cardIDEnum.UNG_063e:
                    return new Sim_UNG_063e();
                case CardDB.cardIDEnum.UNG_916:
                    return new Sim_UNG_916();
                case CardDB.cardIDEnum.UNG_916e:
                    return new Sim_UNG_916e();
                case CardDB.cardIDEnum.UNG_021:
                    return new Sim_UNG_021();
                case CardDB.cardIDEnum.UNG_810:
                    return new Sim_UNG_810();
                case CardDB.cardIDEnum.UNG_211aa:
                    return new Sim_UNG_211aa();
                case CardDB.cardIDEnum.UNG_208:
                    return new Sim_UNG_208();
                case CardDB.cardIDEnum.UNG_072:
                    return new Sim_UNG_072();
                case CardDB.cardIDEnum.UNG_070e:
                    return new Sim_UNG_070e();
                case CardDB.cardIDEnum.UNG_813:
                    return new Sim_UNG_813();
                case CardDB.cardIDEnum.ICC_828t2:
                    return new Sim_ICC_828t2();
                case CardDB.cardIDEnum.UNG_808:
                    return new Sim_UNG_808();
                case CardDB.cardIDEnum.UNG_927:
                    return new Sim_UNG_927();
                case CardDB.cardIDEnum.UNG_934t1:
                    return new Sim_UNG_934t1();
                case CardDB.cardIDEnum.UNG_015:
                    return new Sim_UNG_015();
                case CardDB.cardIDEnum.UNG_919:
                    return new Sim_UNG_919();
                case CardDB.cardIDEnum.UNG_928:
                    return new Sim_UNG_928();
                case CardDB.cardIDEnum.UNG_838:
                    return new Sim_UNG_838();
                case CardDB.cardIDEnum.UNG_049:
                    return new Sim_UNG_049();
                case CardDB.cardIDEnum.UNG_800:
                    return new Sim_UNG_800();
                case CardDB.cardIDEnum.UNG_067:
                    return new Sim_UNG_067();
                case CardDB.cardIDEnum.UNG_954:
                    return new Sim_UNG_954();
                case CardDB.cardIDEnum.UNG_920:
                    return new Sim_UNG_920();
                case CardDB.cardIDEnum.UNG_843:
                    return new Sim_UNG_843();
                case CardDB.cardIDEnum.UNG_082:
                    return new Sim_UNG_082();
                case CardDB.cardIDEnum.UNG_817:
                    return new Sim_UNG_817();
                case CardDB.cardIDEnum.UNG_028t:
                    return new Sim_UNG_028t();
                case CardDB.cardIDEnum.UNG_070:
                    return new Sim_UNG_070();
                case CardDB.cardIDEnum.UNG_913:
                    return new Sim_UNG_913();
                case CardDB.cardIDEnum.UNG_078:
                    return new Sim_UNG_078();
                case CardDB.cardIDEnum.UNG_088:
                    return new Sim_UNG_088();
                case CardDB.cardIDEnum.UNG_037:
                    return new Sim_UNG_037();
                case CardDB.cardIDEnum.UNG_073e:
                    return new Sim_UNG_073e();
                case CardDB.cardIDEnum.UNG_852:
                    return new Sim_UNG_852();
                case CardDB.cardIDEnum.UNG_806:
                    return new Sim_UNG_806();
                case CardDB.cardIDEnum.UNG_851t1:
                    return new Sim_UNG_851t1();
                case CardDB.cardIDEnum.UNG_942:
                    return new Sim_UNG_942();
                case CardDB.cardIDEnum.UNG_100:
                    return new Sim_UNG_100();
                case CardDB.cardIDEnum.UNG_075:
                    return new Sim_UNG_075();
                case CardDB.cardIDEnum.UNG_064:
                    return new Sim_UNG_064();
                case CardDB.cardIDEnum.UNG_950:
                    return new Sim_UNG_950();
                case CardDB.cardIDEnum.UNG_818:
                    return new Sim_UNG_818();
                case CardDB.cardIDEnum.UNG_999t14:
                    return new Sim_UNG_999t14();
                case CardDB.cardIDEnum.UNG_999t14e:
                    return new Sim_UNG_999t14e();
                case CardDB.cardIDEnum.UNG_025:
                    return new Sim_UNG_025();
                case CardDB.cardIDEnum.UNG_002:
                    return new Sim_UNG_002();
                case CardDB.cardIDEnum.UNG_015e:
                    return new Sim_UNG_015e();
                case CardDB.cardIDEnum.UNG_917e:
                    return new Sim_UNG_917e();
 ///case CardDB.cardIDEnum.///LOOTAPALOOZA:
                    ///return new Sim_///LOOTAPALOOZA();
                case CardDB.cardIDEnum.LOOT_333e:
                    return new Sim_LOOT_333e();
                case CardDB.cardIDEnum.LOOTA_BOSS_54h:
                    return new Sim_LOOTA_BOSS_54h();
                case CardDB.cardIDEnum.LOOTA_Rogue_01:
                    return new Sim_LOOTA_Rogue_01();
                case CardDB.cardIDEnum.LOOTA_BOSS_48p:
                    return new Sim_LOOTA_BOSS_48p();
                case CardDB.cardIDEnum.LOOT_520e:
                    return new Sim_LOOT_520e();
                case CardDB.cardIDEnum.LOOTA_820:
                    return new Sim_LOOTA_820();
                case CardDB.cardIDEnum.LOOTA_BOSS_51p:
                    return new Sim_LOOTA_BOSS_51p();
                case CardDB.cardIDEnum.LOOT_108:
                    return new Sim_LOOT_108();
                case CardDB.cardIDEnum.LOOT_043t2:
                    return new Sim_LOOT_043t2();
                case CardDB.cardIDEnum.LOOTA_805:
                    return new Sim_LOOTA_805();
                case CardDB.cardIDEnum.LOOTA_Mage_28:
                    return new Sim_LOOTA_Mage_28();
                case CardDB.cardIDEnum.LOOT_231:
                    return new Sim_LOOT_231();
                case CardDB.cardIDEnum.LOOTA_BOSS_37p:
                    return new Sim_LOOTA_BOSS_37p();
                case CardDB.cardIDEnum.LOOT_130:
                    return new Sim_LOOT_130();
                case CardDB.cardIDEnum.LOOTA_819:
                    return new Sim_LOOTA_819();
                case CardDB.cardIDEnum.LOOTA_842be:
                    return new Sim_LOOTA_842be();
                case CardDB.cardIDEnum.LOOTA_Warrior_05:
                    return new Sim_LOOTA_Warrior_05();
                case CardDB.cardIDEnum.LOOTA_Rogue_10:
                    return new Sim_LOOTA_Rogue_10();
                case CardDB.cardIDEnum.LOOT_056:
                    return new Sim_LOOT_056();
                case CardDB.cardIDEnum.LOOT_415t6:
                    return new Sim_LOOT_415t6();
                case CardDB.cardIDEnum.LOOTA_BOSS_34h:
                    return new Sim_LOOTA_BOSS_34h();
                case CardDB.cardIDEnum.LOOTA_BOSS_44p:
                    return new Sim_LOOTA_BOSS_44p();
                case CardDB.cardIDEnum.LOOTA_836:
                    return new Sim_LOOTA_836();
                case CardDB.cardIDEnum.LOOTA_823:
                    return new Sim_LOOTA_823();
                case CardDB.cardIDEnum.LOOTA_Priest_05:
                    return new Sim_LOOTA_Priest_05();
                case CardDB.cardIDEnum.LOOTA_Rogue_13:
                    return new Sim_LOOTA_Rogue_13();
                case CardDB.cardIDEnum.LOOTA_Druid_09:
                    return new Sim_LOOTA_Druid_09();
                case CardDB.cardIDEnum.LOOTA_828e:
                    return new Sim_LOOTA_828e();
                case CardDB.cardIDEnum.LOOTA_828e3:
                    return new Sim_LOOTA_828e3();
                case CardDB.cardIDEnum.LOOTA_828e2:
                    return new Sim_LOOTA_828e2();
                case CardDB.cardIDEnum.LOOT_047:
                    return new Sim_LOOT_047();
                case CardDB.cardIDEnum.LOOT_047e:
                    return new Sim_LOOT_047e();
                case CardDB.cardIDEnum.LOOTA_846:
                    return new Sim_LOOTA_846();
                case CardDB.cardIDEnum.LOOTA_BOSS_17p:
                    return new Sim_LOOTA_BOSS_17p();
                case CardDB.cardIDEnum.LOOTA_Shaman_05:
                    return new Sim_LOOTA_Shaman_05();
                case CardDB.cardIDEnum.LOOTA_BOSS_17h:
                    return new Sim_LOOTA_BOSS_17h();
                case CardDB.cardIDEnum.LOOTA_BOSS_26p8:
                    return new Sim_LOOTA_BOSS_26p8();
                case CardDB.cardIDEnum.LOOTA_BOSS_26p4:
                    return new Sim_LOOTA_BOSS_26p4();
                case CardDB.cardIDEnum.LOOTA_BOSS_26p3:
                    return new Sim_LOOTA_BOSS_26p3();
                case CardDB.cardIDEnum.LOOTA_BOSS_26p7:
                    return new Sim_LOOTA_BOSS_26p7();
                case CardDB.cardIDEnum.LOOTA_BOSS_26p5:
                    return new Sim_LOOTA_BOSS_26p5();
                case CardDB.cardIDEnum.LOOTA_BOSS_26p6:
                    return new Sim_LOOTA_BOSS_26p6();
                case CardDB.cardIDEnum.LOOTA_BOSS_26p2:
                    return new Sim_LOOTA_BOSS_26p2();
                case CardDB.cardIDEnum.LOOTA_Hunter_06:
                    return new Sim_LOOTA_Hunter_06();
                case CardDB.cardIDEnum.LOOT_398:
                    return new Sim_LOOT_398();
                case CardDB.cardIDEnum.LOOTA_Warrior_01:
                    return new Sim_LOOTA_Warrior_01();
                case CardDB.cardIDEnum.LOOTA_Hunter_02:
                    return new Sim_LOOTA_Hunter_02();
                case CardDB.cardIDEnum.LOOTA_Mage_27:
                    return new Sim_LOOTA_Mage_27();
                case CardDB.cardIDEnum.LOOTA_BOSS_45h:
                    return new Sim_LOOTA_BOSS_45h();
                case CardDB.cardIDEnum.LOOTA_BOSS_06h:
                    return new Sim_LOOTA_BOSS_06h();
                case CardDB.cardIDEnum.LOOTA_BOSS_29h:
                    return new Sim_LOOTA_BOSS_29h();
                case CardDB.cardIDEnum.LOOTA_842a:
                    return new Sim_LOOTA_842a();
                case CardDB.cardIDEnum.LOOT_044:
                    return new Sim_LOOT_044();
                case CardDB.cardIDEnum.LOOTA_Rogue_03:
                    return new Sim_LOOTA_Rogue_03();
                case CardDB.cardIDEnum.LOOT_286t3:
                    return new Sim_LOOT_286t3();
                case CardDB.cardIDEnum.LOOTA_Warlock_10:
                    return new Sim_LOOTA_Warlock_10();
                case CardDB.cardIDEnum.LOOT_152:
                    return new Sim_LOOT_152();
                case CardDB.cardIDEnum.LOOTA_812:
                    return new Sim_LOOTA_812();
                case CardDB.cardIDEnum.LOOTA_812e:
                    return new Sim_LOOTA_812e();
                case CardDB.cardIDEnum.LOOT_054:
                    return new Sim_LOOT_054();
                case CardDB.cardIDEnum.LOOTA_BOSS_20h:
                    return new Sim_LOOTA_BOSS_20h();
                case CardDB.cardIDEnum.LOOTA_BOSS_23h:
                    return new Sim_LOOTA_BOSS_23h();
                case CardDB.cardIDEnum.LOOT_093:
                    return new Sim_LOOT_093();
                case CardDB.cardIDEnum.LOOTA_BOSS_12h:
                    return new Sim_LOOTA_BOSS_12h();
                case CardDB.cardIDEnum.LOOTA_BOSS_31h:
                    return new Sim_LOOTA_BOSS_31h();
                case CardDB.cardIDEnum.LOOT_222:
                    return new Sim_LOOT_222();
                case CardDB.cardIDEnum.LOOTA_828:
                    return new Sim_LOOTA_828();
                case CardDB.cardIDEnum.LOOT_161:
                    return new Sim_LOOT_161();
                case CardDB.cardIDEnum.LOOT_161e:
                    return new Sim_LOOT_161e();
                case CardDB.cardIDEnum.LOOT_417:
                    return new Sim_LOOT_417();
                case CardDB.cardIDEnum.LOOTA_BOSS_22p:
                    return new Sim_LOOTA_BOSS_22p();
                case CardDB.cardIDEnum.LOOT_078:
                    return new Sim_LOOT_078();
                case CardDB.cardIDEnum.LOOT_033:
                    return new Sim_LOOT_033();
                case CardDB.cardIDEnum.LOOT_286t1:
                    return new Sim_LOOT_286t1();
                case CardDB.cardIDEnum.LOOTA_Mage_20:
                    return new Sim_LOOTA_Mage_20();
                case CardDB.cardIDEnum.LOOTA_BOSS_12e:
                    return new Sim_LOOTA_BOSS_12e();
                case CardDB.cardIDEnum.LOOTA_BOSS_12p:
                    return new Sim_LOOTA_BOSS_12p();
                case CardDB.cardIDEnum.LOOTA_Warrior_03:
                    return new Sim_LOOTA_Warrior_03();
                case CardDB.cardIDEnum.LOOTA_BOSS_31p:
                    return new Sim_LOOTA_BOSS_31p();
                case CardDB.cardIDEnum.LOOT_204:
                    return new Sim_LOOT_204();
                case CardDB.cardIDEnum.LOOTA_BOSS_53h:
                    return new Sim_LOOTA_BOSS_53h();
                case CardDB.cardIDEnum.LOOTA_832:
                    return new Sim_LOOTA_832();
                case CardDB.cardIDEnum.LOOTA_832e2:
                    return new Sim_LOOTA_832e2();
                case CardDB.cardIDEnum.LOOT_204e:
                    return new Sim_LOOT_204e();
                case CardDB.cardIDEnum.LOOTA_BOSS_45p:
                    return new Sim_LOOTA_BOSS_45p();
                case CardDB.cardIDEnum.LOOTA_Priest_9:
                    return new Sim_LOOTA_Priest_9();
                case CardDB.cardIDEnum.LOOT_149:
                    return new Sim_LOOT_149();
                case CardDB.cardIDEnum.LOOT_122:
                    return new Sim_LOOT_122();
                case CardDB.cardIDEnum.LOOT_149e:
                    return new Sim_LOOT_149e();
                case CardDB.cardIDEnum.LOOTA_BOSS_11p:
                    return new Sim_LOOTA_BOSS_11p();
                case CardDB.cardIDEnum.LOOT_060:
                    return new Sim_LOOT_060();
                case CardDB.cardIDEnum.LOOT_522:
                    return new Sim_LOOT_522();
                case CardDB.cardIDEnum.LOOTA_801:
                    return new Sim_LOOTA_801();
                case CardDB.cardIDEnum.LOOT_313:
                    return new Sim_LOOT_313();
                case CardDB.cardIDEnum.LOOTA_Druid_07:
                    return new Sim_LOOTA_Druid_07();
                case CardDB.cardIDEnum.LOOTA_Priest_13:
                    return new Sim_LOOTA_Priest_13();
                case CardDB.cardIDEnum.LOOTA_Rogue_15:
                    return new Sim_LOOTA_Rogue_15();
                case CardDB.cardIDEnum.LOOTA_Warlock_02:
                    return new Sim_LOOTA_Warlock_02();
                case CardDB.cardIDEnum.LOOT_233:
                    return new Sim_LOOT_233();
                case CardDB.cardIDEnum.LOOT_233t:
                    return new Sim_LOOT_233t();
                case CardDB.cardIDEnum.LOOTA_BOSS_35p:
                    return new Sim_LOOTA_BOSS_35p();
                case CardDB.cardIDEnum.LOOT_017:
                    return new Sim_LOOT_017();
                case CardDB.cardIDEnum.LOOT_526t:
                    return new Sim_LOOT_526t();
                case CardDB.cardIDEnum.LOOT_526et:
                    return new Sim_LOOT_526et();
                case CardDB.cardIDEnum.LOOTA_BOSS_49t:
                    return new Sim_LOOTA_BOSS_49t();
                case CardDB.cardIDEnum.LOOTA_105:
                    return new Sim_LOOTA_105();
                case CardDB.cardIDEnum.LOOTA_Rogue_04:
                    return new Sim_LOOTA_Rogue_04();
                case CardDB.cardIDEnum.LOOTA_Hunter_09:
                    return new Sim_LOOTA_Hunter_09();
                case CardDB.cardIDEnum.LOOT_106:
                    return new Sim_LOOT_106();
                case CardDB.cardIDEnum.LOOTA_Hunter_11:
                    return new Sim_LOOTA_Hunter_11();
                case CardDB.cardIDEnum.LOOTA_Mage_31:
                    return new Sim_LOOTA_Mage_31();
                case CardDB.cardIDEnum.LOOTA_109e:
                    return new Sim_LOOTA_109e();
                case CardDB.cardIDEnum.LOOTA_Shaman_01:
                    return new Sim_LOOTA_Shaman_01();
                case CardDB.cardIDEnum.LOOTA_Warlock_08:
                    return new Sim_LOOTA_Warlock_08();
                case CardDB.cardIDEnum.LOOT_136e:
                    return new Sim_LOOT_136e();
                case CardDB.cardIDEnum.LOOTA_BOSS_34p:
                    return new Sim_LOOTA_BOSS_34p();
                case CardDB.cardIDEnum.LOOT_507t:
                    return new Sim_LOOT_507t();
                case CardDB.cardIDEnum.LOOTA_BOSS_19p:
                    return new Sim_LOOTA_BOSS_19p();
                case CardDB.cardIDEnum.LOOTA_Warlock_11:
                    return new Sim_LOOTA_Warlock_11();
                case CardDB.cardIDEnum.LOOT_258:
                    return new Sim_LOOT_258();
                case CardDB.cardIDEnum.LOOTA_Warlock_04:
                    return new Sim_LOOTA_Warlock_04();
                case CardDB.cardIDEnum.LOOTA_Priest_08:
                    return new Sim_LOOTA_Priest_08();
                case CardDB.cardIDEnum.LOOTA_BOSS_20p:
                    return new Sim_LOOTA_BOSS_20p();
                case CardDB.cardIDEnum.LOOTA_Paladin_05:
                    return new Sim_LOOTA_Paladin_05();
                case CardDB.cardIDEnum.LOOTA_BOSS_15p:
                    return new Sim_LOOTA_BOSS_15p();
                case CardDB.cardIDEnum.LOOTA_Priest_03:
                    return new Sim_LOOTA_Priest_03();
                case CardDB.cardIDEnum.LOOTA_BOSS_52p:
                    return new Sim_LOOTA_BOSS_52p();
                case CardDB.cardIDEnum.LOOTA_838:
                    return new Sim_LOOTA_838();
                case CardDB.cardIDEnum.LOOTA_Warrior_12:
                    return new Sim_LOOTA_Warrior_12();
                case CardDB.cardIDEnum.LOOTA_Priest_07:
                    return new Sim_LOOTA_Priest_07();
                case CardDB.cardIDEnum.LOOT_209:
                    return new Sim_LOOT_209();
                case CardDB.cardIDEnum.LOOT_209t:
                    return new Sim_LOOT_209t();
                case CardDB.cardIDEnum.LOOT_535:
                    return new Sim_LOOT_535();
                case CardDB.cardIDEnum.LOOT_540:
                    return new Sim_LOOT_540();
                case CardDB.cardIDEnum.LOOTA_Paladin_12:
                    return new Sim_LOOTA_Paladin_12();
                case CardDB.cardIDEnum.LOOT_172:
                    return new Sim_LOOT_172();
                case CardDB.cardIDEnum.LOOT_132:
                    return new Sim_LOOT_132();
                case CardDB.cardIDEnum.LOOT_363:
                    return new Sim_LOOT_363();
                case CardDB.cardIDEnum.LOOT_367:
                    return new Sim_LOOT_367();
                case CardDB.cardIDEnum.LOOT_410:
                    return new Sim_LOOT_410();
                case CardDB.cardIDEnum.LOOT_054d:
                    return new Sim_LOOT_054d();
                case CardDB.cardIDEnum.LOOT_118:
                    return new Sim_LOOT_118();
                case CardDB.cardIDEnum.LOOTA_BOSS_35h:
                    return new Sim_LOOTA_BOSS_35h();
                case CardDB.cardIDEnum.LOOTA_BOSS_42h:
                    return new Sim_LOOTA_BOSS_42h();
                case CardDB.cardIDEnum.LOOTA_Mage_21:
                    return new Sim_LOOTA_Mage_21();
                case CardDB.cardIDEnum.LOOTA_Priest_12:
                    return new Sim_LOOTA_Priest_12();
                case CardDB.cardIDEnum.LOOTA_Shaman_06:
                    return new Sim_LOOTA_Shaman_06();
                case CardDB.cardIDEnum.LOOT_278t4:
                    return new Sim_LOOT_278t4();
                case CardDB.cardIDEnum.LOOT_278t1:
                    return new Sim_LOOT_278t1();
                case CardDB.cardIDEnum.LOOT_278t2:
                    return new Sim_LOOT_278t2();
                case CardDB.cardIDEnum.LOOT_278t3:
                    return new Sim_LOOT_278t3();
                case CardDB.cardIDEnum.LOOT_211:
                    return new Sim_LOOT_211();
                case CardDB.cardIDEnum.LOOTA_827:
                    return new Sim_LOOTA_827();
                case CardDB.cardIDEnum.LOOT_080t2:
                    return new Sim_LOOT_080t2();
                case CardDB.cardIDEnum.LOOTA_BOSS_49p:
                    return new Sim_LOOTA_BOSS_49p();
                case CardDB.cardIDEnum.LOOT_214:
                    return new Sim_LOOT_214();
                case CardDB.cardIDEnum.LOOT_214e:
                    return new Sim_LOOT_214e();
                case CardDB.cardIDEnum.LOOTA_Rogue_02:
                    return new Sim_LOOTA_Rogue_02();
                case CardDB.cardIDEnum.LOOTA_Warrior_02:
                    return new Sim_LOOTA_Warrior_02();
                case CardDB.cardIDEnum.LOOTA_BOSS_06p:
                    return new Sim_LOOTA_BOSS_06p();
                case CardDB.cardIDEnum.LOOTA_Rogue_16:
                    return new Sim_LOOTA_Rogue_16();
                case CardDB.cardIDEnum.LOOT_054b:
                    return new Sim_LOOT_054b();
                case CardDB.cardIDEnum.LOOT_440e:
                    return new Sim_LOOT_440e();
                case CardDB.cardIDEnum.LOOT_101:
                    return new Sim_LOOT_101();
                case CardDB.cardIDEnum.LOOTA_BOSS_40pe:
                    return new Sim_LOOTA_BOSS_40pe();
                case CardDB.cardIDEnum.LOOTA_BOSS_40p:
                    return new Sim_LOOTA_BOSS_40p();
                case CardDB.cardIDEnum.LOOT_026:
                    return new Sim_LOOT_026();
                case CardDB.cardIDEnum.LOOTA_Shaman_12:
                    return new Sim_LOOTA_Shaman_12();
                case CardDB.cardIDEnum.LOOT_054be:
                    return new Sim_LOOT_054be();
                case CardDB.cardIDEnum.LOOT_415t1t:
                    return new Sim_LOOT_415t1t();
                case CardDB.cardIDEnum.LOOT_415t2t:
                    return new Sim_LOOT_415t2t();
                case CardDB.cardIDEnum.LOOT_415t3t:
                    return new Sim_LOOT_415t3t();
                case CardDB.cardIDEnum.LOOT_415t4t:
                    return new Sim_LOOT_415t4t();
                case CardDB.cardIDEnum.LOOT_415t5t:
                    return new Sim_LOOT_415t5t();
                case CardDB.cardIDEnum.LOOT_218:
                    return new Sim_LOOT_218();
                case CardDB.cardIDEnum.LOOTA_Mage_24:
                    return new Sim_LOOTA_Mage_24();
                case CardDB.cardIDEnum.LOOT_535t:
                    return new Sim_LOOT_535t();
                case CardDB.cardIDEnum.LOOT_077:
                    return new Sim_LOOT_077();
                case CardDB.cardIDEnum.LOOTA_842t:
                    return new Sim_LOOTA_842t();
                case CardDB.cardIDEnum.LOOTA_BOSS_09p:
                    return new Sim_LOOTA_BOSS_09p();
                case CardDB.cardIDEnum.LOOTA_Mage_23:
                    return new Sim_LOOTA_Mage_23();
                case CardDB.cardIDEnum.LOOTA_Shaman_02:
                    return new Sim_LOOTA_Shaman_02();
                case CardDB.cardIDEnum.LOOTA_BOSS_09h:
                    return new Sim_LOOTA_BOSS_09h();
                case CardDB.cardIDEnum.LOOT_388:
                    return new Sim_LOOT_388();
                case CardDB.cardIDEnum.LOOTA_BOSS_46p:
                    return new Sim_LOOTA_BOSS_46p();
                case CardDB.cardIDEnum.LOOT_167:
                    return new Sim_LOOT_167();
                case CardDB.cardIDEnum.LOOTA_BOSS_46h:
                    return new Sim_LOOTA_BOSS_46h();
                case CardDB.cardIDEnum.LOOT_150:
                    return new Sim_LOOT_150();
                case CardDB.cardIDEnum.LOOT_370:
                    return new Sim_LOOT_370();
                case CardDB.cardIDEnum.LOOT_365:
                    return new Sim_LOOT_365();
                case CardDB.cardIDEnum.LOOTA_BOSS_15h:
                    return new Sim_LOOTA_BOSS_15h();
                case CardDB.cardIDEnum.LOOTA_BOSS_15e:
                    return new Sim_LOOTA_BOSS_15e();
                case CardDB.cardIDEnum.LOOT_519:
                    return new Sim_LOOT_519();
                case CardDB.cardIDEnum.LOOTA_Mage_30:
                    return new Sim_LOOTA_Mage_30();
                case CardDB.cardIDEnum.LOOT_069t:
                    return new Sim_LOOT_069t();
                case CardDB.cardIDEnum.LOOTA_BOSS_18h:
                    return new Sim_LOOTA_BOSS_18h();
                case CardDB.cardIDEnum.LOOTA_BOSS_39p:
                    return new Sim_LOOTA_BOSS_39p();
                case CardDB.cardIDEnum.LOOT_534:
                    return new Sim_LOOT_534();
                case CardDB.cardIDEnum.LOOTA_BOSS_24p:
                    return new Sim_LOOTA_BOSS_24p();
                case CardDB.cardIDEnum.LOOTA_BOSS_24e:
                    return new Sim_LOOTA_BOSS_24e();
                case CardDB.cardIDEnum.LOOTA_834:
                    return new Sim_LOOTA_834();
                case CardDB.cardIDEnum.LOOTA_109:
                    return new Sim_LOOTA_109();
                case CardDB.cardIDEnum.LOOTA_831:
                    return new Sim_LOOTA_831();
                case CardDB.cardIDEnum.LOOTA_831e:
                    return new Sim_LOOTA_831e();
                case CardDB.cardIDEnum.LOOTA_BOSS_21h:
                    return new Sim_LOOTA_BOSS_21h();
                case CardDB.cardIDEnum.LOOT_998k:
                    return new Sim_LOOT_998k();
                case CardDB.cardIDEnum.LOOT_414:
                    return new Sim_LOOT_414();
                case CardDB.cardIDEnum.LOOT_154:
                    return new Sim_LOOT_154();
                case CardDB.cardIDEnum.LOOTA_BOSS_10h:
                    return new Sim_LOOTA_BOSS_10h();
                case CardDB.cardIDEnum.LOOT_043t3:
                    return new Sim_LOOT_043t3();
                case CardDB.cardIDEnum.LOOT_507t2:
                    return new Sim_LOOT_507t2();
                case CardDB.cardIDEnum.LOOT_080t3:
                    return new Sim_LOOT_080t3();
                case CardDB.cardIDEnum.LOOTA_BOSS_29p:
                    return new Sim_LOOTA_BOSS_29p();
                case CardDB.cardIDEnum.LOOT_051t2:
                    return new Sim_LOOT_051t2();
                case CardDB.cardIDEnum.LOOT_203t3:
                    return new Sim_LOOT_203t3();
                case CardDB.cardIDEnum.LOOT_503t2:
                    return new Sim_LOOT_503t2();
                case CardDB.cardIDEnum.LOOT_091t2:
                    return new Sim_LOOT_091t2();
                case CardDB.cardIDEnum.LOOT_103t2:
                    return new Sim_LOOT_103t2();
                case CardDB.cardIDEnum.LOOT_064t2:
                    return new Sim_LOOT_064t2();
                case CardDB.cardIDEnum.LOOTA_Rogue_07:
                    return new Sim_LOOTA_Rogue_07();
                case CardDB.cardIDEnum.LOOTA_835:
                    return new Sim_LOOTA_835();
                case CardDB.cardIDEnum.LOOT_351:
                    return new Sim_LOOT_351();
                case CardDB.cardIDEnum.LOOT_131:
                    return new Sim_LOOT_131();
                case CardDB.cardIDEnum.LOOT_131t1:
                    return new Sim_LOOT_131t1();
                case CardDB.cardIDEnum.LOOT_314:
                    return new Sim_LOOT_314();
                case CardDB.cardIDEnum.LOOTA_818:
                    return new Sim_LOOTA_818();
                case CardDB.cardIDEnum.LOOTA_818e:
                    return new Sim_LOOTA_818e();
                case CardDB.cardIDEnum.LOOT_153t1:
                    return new Sim_LOOT_153t1();
                case CardDB.cardIDEnum.LOOT_358:
                    return new Sim_LOOT_358();
                case CardDB.cardIDEnum.LOOT_358e:
                    return new Sim_LOOT_358e();
                case CardDB.cardIDEnum.LOOT_091t:
                    return new Sim_LOOT_091t();
                case CardDB.cardIDEnum.LOOT_091t1t:
                    return new Sim_LOOT_091t1t();
                case CardDB.cardIDEnum.LOOT_091t2t:
                    return new Sim_LOOT_091t2t();
                case CardDB.cardIDEnum.LOOT_375:
                    return new Sim_LOOT_375();
                case CardDB.cardIDEnum.LOOTA_BOSS_19h:
                    return new Sim_LOOTA_BOSS_19h();
                case CardDB.cardIDEnum.LOOTA_BOSS_33h:
                    return new Sim_LOOTA_BOSS_33h();
                case CardDB.cardIDEnum.LOOTA_BOSS_27p:
                    return new Sim_LOOTA_BOSS_27p();
                case CardDB.cardIDEnum.LOOTA_Paladin_04:
                    return new Sim_LOOTA_Paladin_04();
                case CardDB.cardIDEnum.LOOT_373:
                    return new Sim_LOOT_373();
                case CardDB.cardIDEnum.LOOTA_Paladin_11:
                    return new Sim_LOOTA_Paladin_11();
                case CardDB.cardIDEnum.LOOTA_Mage_25:
                    return new Sim_LOOTA_Mage_25();
                case CardDB.cardIDEnum.LOOTA_842b:
                    return new Sim_LOOTA_842b();
                case CardDB.cardIDEnum.LOOT_144:
                    return new Sim_LOOT_144();
                case CardDB.cardIDEnum.LOOTA_Priest_01:
                    return new Sim_LOOTA_Priest_01();
                case CardDB.cardIDEnum.LOOT_286t3e:
                    return new Sim_LOOT_286t3e();
                case CardDB.cardIDEnum.LOOT_018e:
                    return new Sim_LOOT_018e();
                case CardDB.cardIDEnum.LOOT_018:
                    return new Sim_LOOT_018();
                case CardDB.cardIDEnum.LOOT_278t4e:
                    return new Sim_LOOT_278t4e();
                case CardDB.cardIDEnum.LOOTA_837:
                    return new Sim_LOOTA_837();
                case CardDB.cardIDEnum.LOOTA_Warlock_12:
                    return new Sim_LOOTA_Warlock_12();
                case CardDB.cardIDEnum.LOOT_383:
                    return new Sim_LOOT_383();
                case CardDB.cardIDEnum.LOOTA_BOSS_23p:
                    return new Sim_LOOTA_BOSS_23p();
                case CardDB.cardIDEnum.LOOTA_BOSS_54p:
                    return new Sim_LOOTA_BOSS_54p();
                case CardDB.cardIDEnum.LOOTA_BOSS_53h2:
                    return new Sim_LOOTA_BOSS_53h2();
                case CardDB.cardIDEnum.LOOTA_BOSS_46pe:
                    return new Sim_LOOTA_BOSS_46pe();
                case CardDB.cardIDEnum.LOOT_152e:
                    return new Sim_LOOT_152e();
                case CardDB.cardIDEnum.LOOTA_832e:
                    return new Sim_LOOTA_832e();
                case CardDB.cardIDEnum.LOOT_285t3t:
                    return new Sim_LOOT_285t3t();
                case CardDB.cardIDEnum.LOOT_048:
                    return new Sim_LOOT_048();
                case CardDB.cardIDEnum.LOOTA_BOSS_36h:
                    return new Sim_LOOTA_BOSS_36h();
                case CardDB.cardIDEnum.LOOT_329:
                    return new Sim_LOOT_329();
                case CardDB.cardIDEnum.LOOTA_Druid_04:
                    return new Sim_LOOTA_Druid_04();
                case CardDB.cardIDEnum.LOOTA_Rogue_05:
                    return new Sim_LOOTA_Rogue_05();
                case CardDB.cardIDEnum.LOOTA_Shaman_11:
                    return new Sim_LOOTA_Shaman_11();
                case CardDB.cardIDEnum.LOOT_051t1:
                    return new Sim_LOOT_051t1();
                case CardDB.cardIDEnum.LOOTA_BOSS_43h:
                    return new Sim_LOOTA_BOSS_43h();
                case CardDB.cardIDEnum.LOOTA_BOSS_41p:
                    return new Sim_LOOTA_BOSS_41p();
                case CardDB.cardIDEnum.LOOTA_Druid_02:
                    return new Sim_LOOTA_Druid_02();
                case CardDB.cardIDEnum.LOOTA_Druid_06:
                    return new Sim_LOOTA_Druid_06();
                case CardDB.cardIDEnum.LOOTA_802:
                    return new Sim_LOOTA_802();
                case CardDB.cardIDEnum.LOOTA_802e:
                    return new Sim_LOOTA_802e();
                case CardDB.cardIDEnum.LOOTA_Paladin_09:
                    return new Sim_LOOTA_Paladin_09();
                case CardDB.cardIDEnum.LOOTA_BOSS_32h:
                    return new Sim_LOOTA_BOSS_32h();
                case CardDB.cardIDEnum.LOOT_511:
                    return new Sim_LOOT_511();
                case CardDB.cardIDEnum.LOOTA_824:
                    return new Sim_LOOTA_824();
                case CardDB.cardIDEnum.LOOTA_824e:
                    return new Sim_LOOTA_824e();
                case CardDB.cardIDEnum.LOOT_541:
                    return new Sim_LOOT_541();
                case CardDB.cardIDEnum.LOOTA_BOSS_99h:
                    return new Sim_LOOTA_BOSS_99h();
                case CardDB.cardIDEnum.LOOT_541t:
                    return new Sim_LOOT_541t();
                case CardDB.cardIDEnum.LOOT_542:
                    return new Sim_LOOT_542();
                case CardDB.cardIDEnum.LOOT_542e:
                    return new Sim_LOOT_542e();
                case CardDB.cardIDEnum.LOOT_347:
                    return new Sim_LOOT_347();
                case CardDB.cardIDEnum.LOOT_041:
                    return new Sim_LOOT_041();
                case CardDB.cardIDEnum.LOOT_062:
                    return new Sim_LOOT_062();
                case CardDB.cardIDEnum.LOOT_412:
                    return new Sim_LOOT_412();
                case CardDB.cardIDEnum.LOOT_014:
                    return new Sim_LOOT_014();
                case CardDB.cardIDEnum.LOOT_382:
                    return new Sim_LOOT_382();
                case CardDB.cardIDEnum.LOOTA_BOSS_39h:
                    return new Sim_LOOTA_BOSS_39h();
                case CardDB.cardIDEnum.LOOTA_Priest_02:
                    return new Sim_LOOTA_Priest_02();
                case CardDB.cardIDEnum.LOOTA_BOSS_47h:
                    return new Sim_LOOTA_BOSS_47h();
                case CardDB.cardIDEnum.LOOTA_Hunter_10:
                    return new Sim_LOOTA_Hunter_10();
                case CardDB.cardIDEnum.LOOTA_Paladin_16:
                    return new Sim_LOOTA_Paladin_16();
                case CardDB.cardIDEnum.LOOTA_Warrior_10:
                    return new Sim_LOOTA_Warrior_10();
                case CardDB.cardIDEnum.LOOT_043:
                    return new Sim_LOOT_043();
                case CardDB.cardIDEnum.LOOT_507:
                    return new Sim_LOOT_507();
                case CardDB.cardIDEnum.LOOT_080:
                    return new Sim_LOOT_080();
                case CardDB.cardIDEnum.LOOT_051:
                    return new Sim_LOOT_051();
                case CardDB.cardIDEnum.LOOT_203:
                    return new Sim_LOOT_203();
                case CardDB.cardIDEnum.LOOT_503:
                    return new Sim_LOOT_503();
                case CardDB.cardIDEnum.LOOT_091:
                    return new Sim_LOOT_091();
                case CardDB.cardIDEnum.LOOT_103:
                    return new Sim_LOOT_103();
                case CardDB.cardIDEnum.LOOT_064:
                    return new Sim_LOOT_064();
                case CardDB.cardIDEnum.LOOT_333:
                    return new Sim_LOOT_333();
                case CardDB.cardIDEnum.LOOT_537:
                    return new Sim_LOOT_537();
                case CardDB.cardIDEnum.LOOT_026t:
                    return new Sim_LOOT_026t();
                case CardDB.cardIDEnum.LOOTA_Warlock_05:
                    return new Sim_LOOTA_Warlock_05();
                case CardDB.cardIDEnum.LOOT_216e:
                    return new Sim_LOOT_216e();
                case CardDB.cardIDEnum.LOOTA_BOSS_10p:
                    return new Sim_LOOTA_BOSS_10p();
                case CardDB.cardIDEnum.LOOTA_Warlock_01:
                    return new Sim_LOOTA_Warlock_01();
                case CardDB.cardIDEnum.LOOT_124:
                    return new Sim_LOOT_124();
                case CardDB.cardIDEnum.LOOT_124e:
                    return new Sim_LOOT_124e();
                case CardDB.cardIDEnum.LOOT_054c:
                    return new Sim_LOOT_054c();
                case CardDB.cardIDEnum.LOOTA_Mage_29:
                    return new Sim_LOOTA_Mage_29();
                case CardDB.cardIDEnum.LOOTA_829:
                    return new Sim_LOOTA_829();
                case CardDB.cardIDEnum.LOOTA_BOSS_49t2:
                    return new Sim_LOOTA_BOSS_49t2();
                case CardDB.cardIDEnum.LOOT_216:
                    return new Sim_LOOT_216();
                case CardDB.cardIDEnum.LOOTA_BOSS_37h:
                    return new Sim_LOOTA_BOSS_37h();
                case CardDB.cardIDEnum.LOOTA_BOSS_99p:
                    return new Sim_LOOTA_BOSS_99p();
                case CardDB.cardIDEnum.LOOTA_813:
                    return new Sim_LOOTA_813();
                case CardDB.cardIDEnum.LOOT_167e:
                    return new Sim_LOOT_167e();
                case CardDB.cardIDEnum.LOOTA_Mage_22:
                    return new Sim_LOOTA_Mage_22();
                case CardDB.cardIDEnum.LOOTA_Druid_01:
                    return new Sim_LOOTA_Druid_01();
                case CardDB.cardIDEnum.LOOTA_Paladin_22:
                    return new Sim_LOOTA_Paladin_22();
                case CardDB.cardIDEnum.LOOT_357:
                    return new Sim_LOOT_357();
                case CardDB.cardIDEnum.LOOTA_847:
                    return new Sim_LOOTA_847();
                case CardDB.cardIDEnum.LOOT_357l:
                    return new Sim_LOOT_357l();
                case CardDB.cardIDEnum.LOOT_521:
                    return new Sim_LOOT_521();
                case CardDB.cardIDEnum.LOOTA_Shaman_13:
                    return new Sim_LOOTA_Shaman_13();
                case CardDB.cardIDEnum.LOOTA_BOSS_33p:
                    return new Sim_LOOTA_BOSS_33p();
                case CardDB.cardIDEnum.LOOT_203t4:
                    return new Sim_LOOT_203t4();
                case CardDB.cardIDEnum.LOOT_203t2:
                    return new Sim_LOOT_203t2();
                case CardDB.cardIDEnum.LOOT_150t1:
                    return new Sim_LOOT_150t1();
                case CardDB.cardIDEnum.LOOTA_Paladin_21:
                    return new Sim_LOOTA_Paladin_21();
                case CardDB.cardIDEnum.LOOTA_Shaman_07:
                    return new Sim_LOOTA_Shaman_07();
                case CardDB.cardIDEnum.LOOT_517e2:
                    return new Sim_LOOT_517e2();
                case CardDB.cardIDEnum.LOOT_517:
                    return new Sim_LOOT_517();
                case CardDB.cardIDEnum.LOOT_517e:
                    return new Sim_LOOT_517e();
                case CardDB.cardIDEnum.LOOTA_BOSS_50h:
                    return new Sim_LOOTA_BOSS_50h();
                case CardDB.cardIDEnum.LOOTA_BOSS_50p:
                    return new Sim_LOOTA_BOSS_50p();
                case CardDB.cardIDEnum.LOOTA_BOSS_50t:
                    return new Sim_LOOTA_BOSS_50t();
                case CardDB.cardIDEnum.LOOTA_Shaman_04:
                    return new Sim_LOOTA_Shaman_04();
                case CardDB.cardIDEnum.LOOTA_820e:
                    return new Sim_LOOTA_820e();
                case CardDB.cardIDEnum.LOOTA_833:
                    return new Sim_LOOTA_833();
                case CardDB.cardIDEnum.LOOTA_BOSS_42p:
                    return new Sim_LOOTA_BOSS_42p();
                case CardDB.cardIDEnum.LOOTA_Druid_03:
                    return new Sim_LOOTA_Druid_03();
                case CardDB.cardIDEnum.LOOT_309:
                    return new Sim_LOOT_309();
                case CardDB.cardIDEnum.LOOT_503t:
                    return new Sim_LOOT_503t();
                case CardDB.cardIDEnum.LOOTA_811:
                    return new Sim_LOOTA_811();
                case CardDB.cardIDEnum.LOOTA_Rogue_11:
                    return new Sim_LOOTA_Rogue_11();
                case CardDB.cardIDEnum.LOOTA_Shaman_08:
                    return new Sim_LOOTA_Shaman_08();
                case CardDB.cardIDEnum.LOOTA_BOSS_11h:
                    return new Sim_LOOTA_BOSS_11h();
                case CardDB.cardIDEnum.LOOTA_BOSS_30h:
                    return new Sim_LOOTA_BOSS_30h();
                case CardDB.cardIDEnum.LOOTA_816:
                    return new Sim_LOOTA_816();
                case CardDB.cardIDEnum.LOOTA_BOSS_05h:
                    return new Sim_LOOTA_BOSS_05h();
                case CardDB.cardIDEnum.LOOTA_BOSS_28h:
                    return new Sim_LOOTA_BOSS_28h();
                case CardDB.cardIDEnum.LOOT_091t1:
                    return new Sim_LOOT_091t1();
                case CardDB.cardIDEnum.LOOTA_Warrior_06:
                    return new Sim_LOOTA_Warrior_06();
                case CardDB.cardIDEnum.LOOT_413:
                    return new Sim_LOOT_413();
                case CardDB.cardIDEnum.LOOTA_841:
                    return new Sim_LOOTA_841();
                case CardDB.cardIDEnum.LOOTA_826:
                    return new Sim_LOOTA_826();
                case CardDB.cardIDEnum.LOOT_306:
                    return new Sim_LOOT_306();
                case CardDB.cardIDEnum.LOOT_088:
                    return new Sim_LOOT_088();
                case CardDB.cardIDEnum.LOOTA_800:
                    return new Sim_LOOTA_800();
                case CardDB.cardIDEnum.LOOT_344e:
                    return new Sim_LOOT_344e();
                case CardDB.cardIDEnum.LOOT_344:
                    return new Sim_LOOT_344();
                case CardDB.cardIDEnum.LOOTA_817:
                    return new Sim_LOOTA_817();
                case CardDB.cardIDEnum.LOOT_353:
                    return new Sim_LOOT_353();
                case CardDB.cardIDEnum.LOOT_008:
                    return new Sim_LOOT_008();
                case CardDB.cardIDEnum.LOOT_278t2e:
                    return new Sim_LOOT_278t2e();
                case CardDB.cardIDEnum.LOOT_286t4:
                    return new Sim_LOOT_286t4();
                case CardDB.cardIDEnum.LOOTA_842:
                    return new Sim_LOOTA_842();
                case CardDB.cardIDEnum.LOOTA_BOSS_99t:
                    return new Sim_LOOTA_BOSS_99t();
                case CardDB.cardIDEnum.LOOTA_BOSS_18t:
                    return new Sim_LOOTA_BOSS_18t();
                case CardDB.cardIDEnum.LOOTA_BOSS_18p:
                    return new Sim_LOOTA_BOSS_18p();
                case CardDB.cardIDEnum.LOOT_170:
                    return new Sim_LOOT_170();
                case CardDB.cardIDEnum.LOOT_364:
                    return new Sim_LOOT_364();
                case CardDB.cardIDEnum.LOOTA_Warrior_13:
                    return new Sim_LOOTA_Warrior_13();
                case CardDB.cardIDEnum.LOOTA_Warrior_09:
                    return new Sim_LOOTA_Warrior_09();
                case CardDB.cardIDEnum.LOOTA_Druid_10:
                    return new Sim_LOOTA_Druid_10();
                case CardDB.cardIDEnum.LOOTA_Shaman_03:
                    return new Sim_LOOTA_Shaman_03();
                case CardDB.cardIDEnum.LOOTA_Priest_04:
                    return new Sim_LOOTA_Priest_04();
                case CardDB.cardIDEnum.LOOTA_104:
                    return new Sim_LOOTA_104();
                case CardDB.cardIDEnum.LOOT_085:
                    return new Sim_LOOT_085();
                case CardDB.cardIDEnum.LOOT_415:
                    return new Sim_LOOT_415();
                case CardDB.cardIDEnum.LOOTA_825:
                    return new Sim_LOOTA_825();
                case CardDB.cardIDEnum.LOOTA_825e:
                    return new Sim_LOOTA_825e();
                case CardDB.cardIDEnum.LOOTA_822:
                    return new Sim_LOOTA_822();
                case CardDB.cardIDEnum.LOOT_103t1:
                    return new Sim_LOOT_103t1();
                case CardDB.cardIDEnum.LOOT_389:
                    return new Sim_LOOT_389();
                case CardDB.cardIDEnum.LOOT_285t3:
                    return new Sim_LOOT_285t3();
                case CardDB.cardIDEnum.LOOTA_BOSS_51h:
                    return new Sim_LOOTA_BOSS_51h();
                case CardDB.cardIDEnum.LOOTA_Paladin_20:
                    return new Sim_LOOTA_Paladin_20();
                case CardDB.cardIDEnum.LOOT_286t2e:
                    return new Sim_LOOT_286t2e();
                case CardDB.cardIDEnum.LOOT_286t2:
                    return new Sim_LOOT_286t2();
                case CardDB.cardIDEnum.LOOTA_Warlock_09:
                    return new Sim_LOOTA_Warlock_09();
                case CardDB.cardIDEnum.LOOT_278t1e:
                    return new Sim_LOOT_278t1e();
                case CardDB.cardIDEnum.LOOT_064t1:
                    return new Sim_LOOT_064t1();
                case CardDB.cardIDEnum.LOOTA_BOSS_48t:
                    return new Sim_LOOTA_BOSS_48t();
                case CardDB.cardIDEnum.LOOTA_803:
                    return new Sim_LOOTA_803();
                case CardDB.cardIDEnum.LOOTA_803e:
                    return new Sim_LOOTA_803e();
                case CardDB.cardIDEnum.LOOT_111:
                    return new Sim_LOOT_111();
                case CardDB.cardIDEnum.LOOTA_839:
                    return new Sim_LOOTA_839();
                case CardDB.cardIDEnum.LOOT_106t:
                    return new Sim_LOOT_106t();
                case CardDB.cardIDEnum.LOOTA_BOSS_04p:
                    return new Sim_LOOTA_BOSS_04p();
                case CardDB.cardIDEnum.LOOTA_BOSS_30p:
                    return new Sim_LOOTA_BOSS_30p();
                case CardDB.cardIDEnum.LOOTA_Hunter_05:
                    return new Sim_LOOTA_Hunter_05();
                case CardDB.cardIDEnum.LOOTA_Paladin_01:
                    return new Sim_LOOTA_Paladin_01();
                case CardDB.cardIDEnum.LOOT_520:
                    return new Sim_LOOT_520();
                case CardDB.cardIDEnum.LOOTA_BOSS_40h:
                    return new Sim_LOOTA_BOSS_40h();
                case CardDB.cardIDEnum.LOOT_285t2:
                    return new Sim_LOOT_285t2();
                case CardDB.cardIDEnum.LOOT_069:
                    return new Sim_LOOT_069();
                case CardDB.cardIDEnum.LOOTA_Priest_06:
                    return new Sim_LOOTA_Priest_06();
                case CardDB.cardIDEnum.LOOT_278t3e:
                    return new Sim_LOOT_278t3e();
                case CardDB.cardIDEnum.LOOT_187e:
                    return new Sim_LOOT_187e();
                case CardDB.cardIDEnum.LOOT_278t3e2:
                    return new Sim_LOOT_278t3e2();
                case CardDB.cardIDEnum.LOOT_412e:
                    return new Sim_LOOT_412e();
                case CardDB.cardIDEnum.LOOT_104e:
                    return new Sim_LOOT_104e();
                case CardDB.cardIDEnum.LOOTA_830:
                    return new Sim_LOOTA_830();
                case CardDB.cardIDEnum.LOOT_104:
                    return new Sim_LOOT_104();
                case CardDB.cardIDEnum.LOOT_193:
                    return new Sim_LOOT_193();
                case CardDB.cardIDEnum.LOOTA_Hunter_03:
                    return new Sim_LOOTA_Hunter_03();
                case CardDB.cardIDEnum.LOOT_394:
                    return new Sim_LOOT_394();
                case CardDB.cardIDEnum.LOOT_291:
                    return new Sim_LOOT_291();
                case CardDB.cardIDEnum.LOOTA_107:
                    return new Sim_LOOTA_107();
                case CardDB.cardIDEnum.LOOTA_Paladin_14:
                    return new Sim_LOOTA_Paladin_14();
                case CardDB.cardIDEnum.LOOT_184:
                    return new Sim_LOOT_184();
                case CardDB.cardIDEnum.LOOT_420:
                    return new Sim_LOOT_420();
                case CardDB.cardIDEnum.LOOT_137:
                    return new Sim_LOOT_137();
                case CardDB.cardIDEnum.LOOTA_804:
                    return new Sim_LOOTA_804();
                case CardDB.cardIDEnum.LOOTA_Warrior_08:
                    return new Sim_LOOTA_Warrior_08();
                case CardDB.cardIDEnum.LOOT_118e:
                    return new Sim_LOOT_118e();
                case CardDB.cardIDEnum.LOOTA_Hunter_12:
                    return new Sim_LOOTA_Hunter_12();
                case CardDB.cardIDEnum.LOOT_136:
                    return new Sim_LOOT_136();
                case CardDB.cardIDEnum.LOOT_165:
                    return new Sim_LOOT_165();
                case CardDB.cardIDEnum.LOOT_165e:
                    return new Sim_LOOT_165e();
                case CardDB.cardIDEnum.LOOT_026e:
                    return new Sim_LOOT_026e();
                case CardDB.cardIDEnum.LOOT_285t4:
                    return new Sim_LOOT_285t4();
                case CardDB.cardIDEnum.LOOT_285t4t:
                    return new Sim_LOOT_285t4t();
                case CardDB.cardIDEnum.LOOTA_BOSS_16h:
                    return new Sim_LOOTA_BOSS_16h();
                case CardDB.cardIDEnum.LOOT_539:
                    return new Sim_LOOT_539();
                case CardDB.cardIDEnum.LOOTA_BOSS_36p:
                    return new Sim_LOOTA_BOSS_36p();
                case CardDB.cardIDEnum.LOOTA_Druid_05:
                    return new Sim_LOOTA_Druid_05();
                case CardDB.cardIDEnum.LOOTA_102:
                    return new Sim_LOOTA_102();
                case CardDB.cardIDEnum.LOOTA_BOSS_53p:
                    return new Sim_LOOTA_BOSS_53p();
                case CardDB.cardIDEnum.LOOTA_Druid_12:
                    return new Sim_LOOTA_Druid_12();
                case CardDB.cardIDEnum.LOOTA_BOSS_20t:
                    return new Sim_LOOTA_BOSS_20t();
                case CardDB.cardIDEnum.ICC_828t4:
                    return new Sim_ICC_828t4();
                case CardDB.cardIDEnum.LOOT_125:
                    return new Sim_LOOT_125();
                case CardDB.cardIDEnum.LOOT_210:
                    return new Sim_LOOT_210();
                case CardDB.cardIDEnum.LOOTA_Hunter_04:
                    return new Sim_LOOTA_Hunter_04();
                case CardDB.cardIDEnum.LOOTA_103:
                    return new Sim_LOOTA_103();
                case CardDB.cardIDEnum.LOOTA_BOSS_21p:
                    return new Sim_LOOTA_BOSS_21p();
                case CardDB.cardIDEnum.LOOTA_Warlock_07:
                    return new Sim_LOOTA_Warlock_07();
                case CardDB.cardIDEnum.LOOTA_BOSS_13p:
                    return new Sim_LOOTA_BOSS_13p();
                case CardDB.cardIDEnum.LOOTA_BOSS_22h:
                    return new Sim_LOOTA_BOSS_22h();
                case CardDB.cardIDEnum.LOOTA_BOSS_22t:
                    return new Sim_LOOTA_BOSS_22t();
                case CardDB.cardIDEnum.LOOTA_BOSS_110:
                    return new Sim_LOOTA_BOSS_110();
                case CardDB.cardIDEnum.LOOT_278e:
                    return new Sim_LOOT_278e();
                case CardDB.cardIDEnum.LOOTA_Druid_11:
                    return new Sim_LOOTA_Druid_11();
                case CardDB.cardIDEnum.LOOTA_Paladin_19:
                    return new Sim_LOOTA_Paladin_19();
                case CardDB.cardIDEnum.LOOTA_Warlock_06:
                    return new Sim_LOOTA_Warlock_06();
                case CardDB.cardIDEnum.LOOTA_Warrior_07:
                    return new Sim_LOOTA_Warrior_07();
                case CardDB.cardIDEnum.LOOT_538:
                    return new Sim_LOOT_538();
                case CardDB.cardIDEnum.LOOTA_BOSS_13h:
                    return new Sim_LOOTA_BOSS_13h();
                case CardDB.cardIDEnum.LOOTA_843:
                    return new Sim_LOOTA_843();
                case CardDB.cardIDEnum.LOOT_526:
                    return new Sim_LOOT_526();
                case CardDB.cardIDEnum.LOOT_526d:
                    return new Sim_LOOT_526d();
                case CardDB.cardIDEnum.LOOTA_BOSS_49h:
                    return new Sim_LOOTA_BOSS_49h();
                case CardDB.cardIDEnum.LOOT_415t5:
                    return new Sim_LOOT_415t5();
                case CardDB.cardIDEnum.LOOT_415t1:
                    return new Sim_LOOT_415t1();
                case CardDB.cardIDEnum.LOOTA_BOSS_47p:
                    return new Sim_LOOTA_BOSS_47p();
                case CardDB.cardIDEnum.LOOT_415t4:
                    return new Sim_LOOT_415t4();
                case CardDB.cardIDEnum.LOOTA_BOSS_24h:
                    return new Sim_LOOTA_BOSS_24h();
                case CardDB.cardIDEnum.LOOT_506:
                    return new Sim_LOOT_506();
                case CardDB.cardIDEnum.LOOT_415t2:
                    return new Sim_LOOT_415t2();
                case CardDB.cardIDEnum.LOOT_415t3:
                    return new Sim_LOOT_415t3();
                case CardDB.cardIDEnum.LOOTA_Rogue_09:
                    return new Sim_LOOTA_Rogue_09();
                case CardDB.cardIDEnum.LOOTA_BOSS_43p:
                    return new Sim_LOOTA_BOSS_43p();
                case CardDB.cardIDEnum.LOOT_217:
                    return new Sim_LOOT_217();
                case CardDB.cardIDEnum.LOOT_998h:
                    return new Sim_LOOT_998h();
                case CardDB.cardIDEnum.LOOT_134e:
                    return new Sim_LOOT_134e();
                case CardDB.cardIDEnum.LOOT_134:
                    return new Sim_LOOT_134();
                case CardDB.cardIDEnum.LOOTA_BOSS_38p:
                    return new Sim_LOOTA_BOSS_38p();
                case CardDB.cardIDEnum.LOOTA_845:
                    return new Sim_LOOTA_845();
                case CardDB.cardIDEnum.LOOTA_BOSS_16p:
                    return new Sim_LOOTA_BOSS_16p();
                case CardDB.cardIDEnum.LOOTA_Shaman_09:
                    return new Sim_LOOTA_Shaman_09();
                case CardDB.cardIDEnum.LOOT_285t:
                    return new Sim_LOOT_285t();
                case CardDB.cardIDEnum.LOOTA_Hunter_08:
                    return new Sim_LOOTA_Hunter_08();
                case CardDB.cardIDEnum.LOOTA_BOSS_48h:
                    return new Sim_LOOTA_BOSS_48h();
                case CardDB.cardIDEnum.LOOTA_BOSS_52t:
                    return new Sim_LOOTA_BOSS_52t();
                case CardDB.cardIDEnum.LOOTA_BOSS_52h:
                    return new Sim_LOOTA_BOSS_52h();
                case CardDB.cardIDEnum.LOOT_315:
                    return new Sim_LOOT_315();
                case CardDB.cardIDEnum.LOOT_392:
                    return new Sim_LOOT_392();
                case CardDB.cardIDEnum.LOOT_528:
                    return new Sim_LOOT_528();
                case CardDB.cardIDEnum.LOOT_528e:
                    return new Sim_LOOT_528e();
                case CardDB.cardIDEnum.LOOT_187:
                    return new Sim_LOOT_187();
                case CardDB.cardIDEnum.LOOT_278:
                    return new Sim_LOOT_278();
                case CardDB.cardIDEnum.LOOT_286:
                    return new Sim_LOOT_286();
                case CardDB.cardIDEnum.LOOT_285:
                    return new Sim_LOOT_285();
                case CardDB.cardIDEnum.LOOTA_Mage_32:
                    return new Sim_LOOTA_Mage_32();
                case CardDB.cardIDEnum.LOOTA_Priest_10:
                    return new Sim_LOOTA_Priest_10();
                case CardDB.cardIDEnum.LOOTA_Warlock_03:
                    return new Sim_LOOTA_Warlock_03();
                case CardDB.cardIDEnum.LOOTA_BOSS_28p:
                    return new Sim_LOOTA_BOSS_28p();
                case CardDB.cardIDEnum.LOOT_504:
                    return new Sim_LOOT_504();
                case CardDB.cardIDEnum.LOOT_504t:
                    return new Sim_LOOT_504t();
                case CardDB.cardIDEnum.LOOTA_BOSS_05p:
                    return new Sim_LOOTA_BOSS_05p();
                case CardDB.cardIDEnum.LOOT_500:
                    return new Sim_LOOT_500();
                case CardDB.cardIDEnum.LOOT_500d:
                    return new Sim_LOOT_500d();
                case CardDB.cardIDEnum.LOOTA_BOSS_25p:
                    return new Sim_LOOTA_BOSS_25p();
                case CardDB.cardIDEnum.LOOT_153:
                    return new Sim_LOOT_153();
                case CardDB.cardIDEnum.LOOT_529:
                    return new Sim_LOOT_529();
                case CardDB.cardIDEnum.LOOT_529e:
                    return new Sim_LOOT_529e();
                case CardDB.cardIDEnum.LOOT_368:
                    return new Sim_LOOT_368();
                case CardDB.cardIDEnum.LOOTA_BOSS_38h:
                    return new Sim_LOOTA_BOSS_38h();
                case CardDB.cardIDEnum.LOOTA_821:
                    return new Sim_LOOTA_821();
                case CardDB.cardIDEnum.LOOT_013:
                    return new Sim_LOOT_013();
                case CardDB.cardIDEnum.LOOTA_BOSS_25h:
                    return new Sim_LOOTA_BOSS_25h();
                case CardDB.cardIDEnum.LOOTA_806:
                    return new Sim_LOOTA_806();
                case CardDB.cardIDEnum.LOOT_079:
                    return new Sim_LOOT_079();
                case CardDB.cardIDEnum.LOOT_998le:
                    return new Sim_LOOT_998le();
                case CardDB.cardIDEnum.LOOT_117:
                    return new Sim_LOOT_117();
                case CardDB.cardIDEnum.LOOTA_840:
                    return new Sim_LOOTA_840();
                case CardDB.cardIDEnum.LOOTA_BOSS_04e:
                    return new Sim_LOOTA_BOSS_04e();
                case CardDB.cardIDEnum.LOOTA_BOSS_04h:
                    return new Sim_LOOTA_BOSS_04h();
                case CardDB.cardIDEnum.LOOTA_BOSS_27h:
                    return new Sim_LOOTA_BOSS_27h();
                case CardDB.cardIDEnum.LOOTA_Hunter_07:
                    return new Sim_LOOTA_Hunter_07();
                case CardDB.cardIDEnum.LOOTA_Warrior_04:
                    return new Sim_LOOTA_Warrior_04();
                case CardDB.cardIDEnum.LOOTA_Hunter_01:
                    return new Sim_LOOTA_Hunter_01();
                case CardDB.cardIDEnum.LOOTA_BOSS_44h:
                    return new Sim_LOOTA_BOSS_44h();
                case CardDB.cardIDEnum.LOOTA_BOSS_30e:
                    return new Sim_LOOTA_BOSS_30e();
                case CardDB.cardIDEnum.LOOTA_BOSS_11e:
                    return new Sim_LOOTA_BOSS_11e();
                case CardDB.cardIDEnum.LOOTA_BOSS_41h:
                    return new Sim_LOOTA_BOSS_41h();
                case CardDB.cardIDEnum.LOOT_500e:
                    return new Sim_LOOT_500e();
                case CardDB.cardIDEnum.LOOT_518:
                    return new Sim_LOOT_518();
                case CardDB.cardIDEnum.LOOTA_Druid_08:
                    return new Sim_LOOTA_Druid_08();
                case CardDB.cardIDEnum.LOOTA_814:
                    return new Sim_LOOTA_814();
                case CardDB.cardIDEnum.LOOT_380:
                    return new Sim_LOOT_380();
                case CardDB.cardIDEnum.LOOT_077t:
                    return new Sim_LOOT_077t();
                case CardDB.cardIDEnum.LOOT_998l:
                    return new Sim_LOOT_998l();
                case CardDB.cardIDEnum.LOOTA_BOSS_26h:
                    return new Sim_LOOTA_BOSS_26h();
                case CardDB.cardIDEnum.LOOT_998j:
                    return new Sim_LOOT_998j();
                case CardDB.cardIDEnum.LOOT_516:
                    return new Sim_LOOT_516();
 ///case CardDB.cardIDEnum.///KARA:
                    ///return new Sim_///KARA();
                case CardDB.cardIDEnum.KAR_A02_04e:
                    return new Sim_KAR_A02_04e();
                case CardDB.cardIDEnum.KAR_702e:
                    return new Sim_KAR_702e();
                case CardDB.cardIDEnum.KARA_00_02a:
                    return new Sim_KARA_00_02a();
                case CardDB.cardIDEnum.KAR_710m:
                    return new Sim_KAR_710m();
                case CardDB.cardIDEnum.KAR_036:
                    return new Sim_KAR_036();
                case CardDB.cardIDEnum.KAR_711:
                    return new Sim_KAR_711();
                case CardDB.cardIDEnum.KARA_00_06:
                    return new Sim_KARA_00_06();
                case CardDB.cardIDEnum.KARA_00_06e:
                    return new Sim_KARA_00_06e();
                case CardDB.cardIDEnum.KAR_710:
                    return new Sim_KAR_710();
                case CardDB.cardIDEnum.KARA_00_08:
                    return new Sim_KARA_00_08();
                case CardDB.cardIDEnum.KARA_00_05:
                    return new Sim_KARA_00_05();
                case CardDB.cardIDEnum.KARA_00_07:
                    return new Sim_KARA_00_07();
                case CardDB.cardIDEnum.KAR_097t:
                    return new Sim_KAR_097t();
                case CardDB.cardIDEnum.KARA_13_26:
                    return new Sim_KARA_13_26();
                case CardDB.cardIDEnum.KAR_037:
                    return new Sim_KAR_037();
                case CardDB.cardIDEnum.KAR_009:
                    return new Sim_KAR_009();
                case CardDB.cardIDEnum.KAR_114:
                    return new Sim_KAR_114();
                case CardDB.cardIDEnum.KAR_A02_13:
                    return new Sim_KAR_A02_13();
                case CardDB.cardIDEnum.KAR_A02_13H:
                    return new Sim_KAR_A02_13H();
                case CardDB.cardIDEnum.KARA_05_02:
                    return new Sim_KARA_05_02();
                case CardDB.cardIDEnum.KARA_05_02heroic:
                    return new Sim_KARA_05_02heroic();
                case CardDB.cardIDEnum.KAR_005a:
                    return new Sim_KAR_005a();
                case CardDB.cardIDEnum.KARA_05_01h:
                    return new Sim_KARA_05_01h();
                case CardDB.cardIDEnum.KARA_05_01hheroic:
                    return new Sim_KARA_05_01hheroic();
                case CardDB.cardIDEnum.KAR_A10_06:
                    return new Sim_KAR_A10_06();
                case CardDB.cardIDEnum.KAR_a10_Boss2:
                    return new Sim_KAR_a10_Boss2();
                case CardDB.cardIDEnum.KAR_a10_Boss2H:
                    return new Sim_KAR_a10_Boss2H();
                case CardDB.cardIDEnum.KAR_A10_07:
                    return new Sim_KAR_A10_07();
                case CardDB.cardIDEnum.KAR_A10_01:
                    return new Sim_KAR_A10_01();
                case CardDB.cardIDEnum.KAR_A10_10:
                    return new Sim_KAR_A10_10();
                case CardDB.cardIDEnum.KAR_A10_03:
                    return new Sim_KAR_A10_03();
                case CardDB.cardIDEnum.KARA_08_06e2:
                    return new Sim_KARA_08_06e2();
                case CardDB.cardIDEnum.KARA_08_06:
                    return new Sim_KARA_08_06();
                case CardDB.cardIDEnum.KAR_033:
                    return new Sim_KAR_033();
                case CardDB.cardIDEnum.KARA_00_04:
                    return new Sim_KARA_00_04();
                case CardDB.cardIDEnum.KARA_00_04H:
                    return new Sim_KARA_00_04H();
                case CardDB.cardIDEnum.KAR_025b:
                    return new Sim_KAR_025b();
                case CardDB.cardIDEnum.KAR_025a:
                    return new Sim_KAR_025a();
                case CardDB.cardIDEnum.KAR_A10_22:
                    return new Sim_KAR_A10_22();
                case CardDB.cardIDEnum.KAR_A10_22H:
                    return new Sim_KAR_A10_22H();
                case CardDB.cardIDEnum.KAR_004a:
                    return new Sim_KAR_004a();
                case CardDB.cardIDEnum.KAR_004:
                    return new Sim_KAR_004();
                case CardDB.cardIDEnum.KAR_030:
                    return new Sim_KAR_030();
                case CardDB.cardIDEnum.KAR_A10_33:
                    return new Sim_KAR_A10_33();
                case CardDB.cardIDEnum.KAR_006:
                    return new Sim_KAR_006();
                case CardDB.cardIDEnum.KAR_A02_05:
                    return new Sim_KAR_A02_05();
                case CardDB.cardIDEnum.KAR_A02_05H:
                    return new Sim_KAR_A02_05H();
                case CardDB.cardIDEnum.KAR_A02_05e:
                    return new Sim_KAR_A02_05e();
                case CardDB.cardIDEnum.KAR_A02_05e2:
                    return new Sim_KAR_A02_05e2();
                case CardDB.cardIDEnum.KARA_07_01:
                    return new Sim_KARA_07_01();
                case CardDB.cardIDEnum.KARA_07_01heroic:
                    return new Sim_KARA_07_01heroic();
                case CardDB.cardIDEnum.KARA_09_02:
                    return new Sim_KARA_09_02();
                case CardDB.cardIDEnum.KARA_09_04:
                    return new Sim_KARA_09_04();
                case CardDB.cardIDEnum.KAR_094:
                    return new Sim_KAR_094();
                case CardDB.cardIDEnum.KARA_06_01e:
                    return new Sim_KARA_06_01e();
                case CardDB.cardIDEnum.KARA_13_12:
                    return new Sim_KARA_13_12();
                case CardDB.cardIDEnum.KARA_13_12H:
                    return new Sim_KARA_13_12H();
                case CardDB.cardIDEnum.KARA_07_06:
                    return new Sim_KARA_07_06();
                case CardDB.cardIDEnum.KARA_07_06heroic:
                    return new Sim_KARA_07_06heroic();
                case CardDB.cardIDEnum.KARA_04_01:
                    return new Sim_KARA_04_01();
                case CardDB.cardIDEnum.KARA_07_08:
                    return new Sim_KARA_07_08();
                case CardDB.cardIDEnum.KARA_07_08heroic:
                    return new Sim_KARA_07_08heroic();
                case CardDB.cardIDEnum.KAR_036e:
                    return new Sim_KAR_036e();
                case CardDB.cardIDEnum.KARA_08_04:
                    return new Sim_KARA_08_04();
                case CardDB.cardIDEnum.KAR_300:
                    return new Sim_KAR_300();
                case CardDB.cardIDEnum.KARA_13_11e:
                    return new Sim_KARA_13_11e();
                case CardDB.cardIDEnum.KAR_070:
                    return new Sim_KAR_070();
                case CardDB.cardIDEnum.KARA_00_11:
                    return new Sim_KARA_00_11();
                case CardDB.cardIDEnum.KAR_A02_06e2:
                    return new Sim_KAR_A02_06e2();
                case CardDB.cardIDEnum.KAR_A02_06He:
                    return new Sim_KAR_A02_06He();
                case CardDB.cardIDEnum.KAR_076:
                    return new Sim_KAR_076();
                case CardDB.cardIDEnum.KARA_12_03:
                    return new Sim_KARA_12_03();
                case CardDB.cardIDEnum.KARA_12_03H:
                    return new Sim_KARA_12_03H();
                case CardDB.cardIDEnum.KARA_04_05:
                    return new Sim_KARA_04_05();
                case CardDB.cardIDEnum.KARA_04_05h:
                    return new Sim_KARA_04_05h();
                case CardDB.cardIDEnum.KAR_028:
                    return new Sim_KAR_028();
                case CardDB.cardIDEnum.KAR_A02_03:
                    return new Sim_KAR_A02_03();
                case CardDB.cardIDEnum.KAR_A02_03H:
                    return new Sim_KAR_A02_03H();
                case CardDB.cardIDEnum.KAR_A02_03e:
                    return new Sim_KAR_A02_03e();
                case CardDB.cardIDEnum.KARA_07_02:
                    return new Sim_KARA_07_02();
                case CardDB.cardIDEnum.KARA_07_07:
                    return new Sim_KARA_07_07();
                case CardDB.cardIDEnum.KARA_07_07heroic:
                    return new Sim_KARA_07_07heroic();
                case CardDB.cardIDEnum.KARA_09_03a:
                    return new Sim_KARA_09_03a();
                case CardDB.cardIDEnum.KARA_09_03a_heroic:
                    return new Sim_KARA_09_03a_heroic();
                case CardDB.cardIDEnum.KAR_114e:
                    return new Sim_KAR_114e();
                case CardDB.cardIDEnum.KARA_00_05e:
                    return new Sim_KARA_00_05e();
                case CardDB.cardIDEnum.KAR_091:
                    return new Sim_KAR_091();
                case CardDB.cardIDEnum.KAR_057:
                    return new Sim_KAR_057();
                case CardDB.cardIDEnum.KARA_06_02:
                    return new Sim_KARA_06_02();
                case CardDB.cardIDEnum.KARA_06_02heroic:
                    return new Sim_KARA_06_02heroic();
                case CardDB.cardIDEnum.KAR_025:
                    return new Sim_KAR_025();
                case CardDB.cardIDEnum.KARA_09_08:
                    return new Sim_KARA_09_08();
                case CardDB.cardIDEnum.KARA_09_08_heroic:
                    return new Sim_KARA_09_08_heroic();
                case CardDB.cardIDEnum.KAR_005:
                    return new Sim_KAR_005();
                case CardDB.cardIDEnum.KARA_05_01b:
                    return new Sim_KARA_05_01b();
                case CardDB.cardIDEnum.KAR_A02_04:
                    return new Sim_KAR_A02_04();
                case CardDB.cardIDEnum.KAR_A02_04H:
                    return new Sim_KAR_A02_04H();
                case CardDB.cardIDEnum.KARA_00_02:
                    return new Sim_KARA_00_02();
                case CardDB.cardIDEnum.KARA_00_02H:
                    return new Sim_KARA_00_02H();
                case CardDB.cardIDEnum.KARA_13_13:
                    return new Sim_KARA_13_13();
                case CardDB.cardIDEnum.KARA_13_13H:
                    return new Sim_KARA_13_13H();
                case CardDB.cardIDEnum.KARA_12_02:
                    return new Sim_KARA_12_02();
                case CardDB.cardIDEnum.KARA_12_02H:
                    return new Sim_KARA_12_02H();
                case CardDB.cardIDEnum.KAR_073:
                    return new Sim_KAR_073();
                case CardDB.cardIDEnum.KARA_00_09:
                    return new Sim_KARA_00_09();
                case CardDB.cardIDEnum.KAR_A01_01:
                    return new Sim_KAR_A01_01();
                case CardDB.cardIDEnum.KAR_A01_01H:
                    return new Sim_KAR_A01_01H();
                case CardDB.cardIDEnum.KAR_089:
                    return new Sim_KAR_089();
                case CardDB.cardIDEnum.KARA_11_02:
                    return new Sim_KARA_11_02();
                case CardDB.cardIDEnum.KARA_09_03:
                    return new Sim_KARA_09_03();
                case CardDB.cardIDEnum.KARA_09_03heroic:
                    return new Sim_KARA_09_03heroic();
                case CardDB.cardIDEnum.KARA_00_03:
                    return new Sim_KARA_00_03();
                case CardDB.cardIDEnum.KARA_00_03c:
                    return new Sim_KARA_00_03c();
                case CardDB.cardIDEnum.KARA_00_03H:
                    return new Sim_KARA_00_03H();
                case CardDB.cardIDEnum.KAR_097:
                    return new Sim_KAR_097();
                case CardDB.cardIDEnum.KAR_092:
                    return new Sim_KAR_092();
                case CardDB.cardIDEnum.KAR_702:
                    return new Sim_KAR_702();
                case CardDB.cardIDEnum.KAR_065:
                    return new Sim_KAR_065();
                case CardDB.cardIDEnum.KAR_041:
                    return new Sim_KAR_041();
                case CardDB.cardIDEnum.KAR_041e:
                    return new Sim_KAR_041e();
                case CardDB.cardIDEnum.KAR_075:
                    return new Sim_KAR_075();
                case CardDB.cardIDEnum.KAR_044:
                    return new Sim_KAR_044();
                case CardDB.cardIDEnum.KARA_07_03:
                    return new Sim_KARA_07_03();
                case CardDB.cardIDEnum.KARA_07_03heroic:
                    return new Sim_KARA_07_03heroic();
                case CardDB.cardIDEnum.KARA_00_10:
                    return new Sim_KARA_00_10();
                case CardDB.cardIDEnum.KARA_13_01:
                    return new Sim_KARA_13_01();
                case CardDB.cardIDEnum.KARA_13_01H:
                    return new Sim_KARA_13_01H();
                case CardDB.cardIDEnum.KARA_08_03:
                    return new Sim_KARA_08_03();
                case CardDB.cardIDEnum.KARA_08_03e:
                    return new Sim_KARA_08_03e();
                case CardDB.cardIDEnum.KARA_08_03H:
                    return new Sim_KARA_08_03H();
                case CardDB.cardIDEnum.KARA_08_02:
                    return new Sim_KARA_08_02();
                case CardDB.cardIDEnum.KARA_08_02e:
                    return new Sim_KARA_08_02e();
                case CardDB.cardIDEnum.KARA_08_02eH:
                    return new Sim_KARA_08_02eH();
                case CardDB.cardIDEnum.KARA_08_02H:
                    return new Sim_KARA_08_02H();
                case CardDB.cardIDEnum.KARA_08_01:
                    return new Sim_KARA_08_01();
                case CardDB.cardIDEnum.KARA_08_01H:
                    return new Sim_KARA_08_01H();
                case CardDB.cardIDEnum.KAR_062:
                    return new Sim_KAR_062();
                case CardDB.cardIDEnum.KARA_11_01:
                    return new Sim_KARA_11_01();
                case CardDB.cardIDEnum.KARA_11_01heroic:
                    return new Sim_KARA_11_01heroic();
                case CardDB.cardIDEnum.KAR_010:
                    return new Sim_KAR_010();
                case CardDB.cardIDEnum.KAR_204:
                    return new Sim_KAR_204();
                case CardDB.cardIDEnum.KARA_13_03:
                    return new Sim_KARA_13_03();
                case CardDB.cardIDEnum.KARA_13_03H:
                    return new Sim_KARA_13_03H();
                case CardDB.cardIDEnum.KAR_030a:
                    return new Sim_KAR_030a();
                case CardDB.cardIDEnum.KAR_026t:
                    return new Sim_KAR_026t();
                case CardDB.cardIDEnum.KAR_A02_06:
                    return new Sim_KAR_A02_06();
                case CardDB.cardIDEnum.KAR_A02_06H:
                    return new Sim_KAR_A02_06H();
                case CardDB.cardIDEnum.KAR_A02_01:
                    return new Sim_KAR_A02_01();
                case CardDB.cardIDEnum.KAR_A02_01H:
                    return new Sim_KAR_A02_01H();
                case CardDB.cardIDEnum.KAR_011:
                    return new Sim_KAR_011();
                case CardDB.cardIDEnum.KAR_A02_10:
                    return new Sim_KAR_A02_10();
                case CardDB.cardIDEnum.KAR_035:
                    return new Sim_KAR_035();
                case CardDB.cardIDEnum.KAR_096:
                    return new Sim_KAR_096();
                case CardDB.cardIDEnum.KARA_00_01:
                    return new Sim_KARA_00_01();
                case CardDB.cardIDEnum.KARA_00_01H:
                    return new Sim_KARA_00_01H();
                case CardDB.cardIDEnum.KARA_13_06:
                    return new Sim_KARA_13_06();
                case CardDB.cardIDEnum.KARA_13_06H:
                    return new Sim_KARA_13_06H();
                case CardDB.cardIDEnum.KAR_026:
                    return new Sim_KAR_026();
                case CardDB.cardIDEnum.KARA_07_02e:
                    return new Sim_KARA_07_02e();
                case CardDB.cardIDEnum.KAR_013:
                    return new Sim_KAR_013();
                case CardDB.cardIDEnum.KARA_08_08e2:
                    return new Sim_KARA_08_08e2();
                case CardDB.cardIDEnum.KARA_08_08:
                    return new Sim_KARA_08_08();
                case CardDB.cardIDEnum.KAR_A01_02e:
                    return new Sim_KAR_A01_02e();
                case CardDB.cardIDEnum.KAR_A01_02:
                    return new Sim_KAR_A01_02();
                case CardDB.cardIDEnum.KAR_A01_02H:
                    return new Sim_KAR_A01_02H();
                case CardDB.cardIDEnum.KARA_06_01:
                    return new Sim_KARA_06_01();
                case CardDB.cardIDEnum.KARA_06_01heroic:
                    return new Sim_KARA_06_01heroic();
                case CardDB.cardIDEnum.KAR_029:
                    return new Sim_KAR_029();
                case CardDB.cardIDEnum.KAR_037t:
                    return new Sim_KAR_037t();
                case CardDB.cardIDEnum.KAR_A02_09:
                    return new Sim_KAR_A02_09();
                case CardDB.cardIDEnum.KAR_A02_09H:
                    return new Sim_KAR_A02_09H();
                case CardDB.cardIDEnum.KARA_12_01:
                    return new Sim_KARA_12_01();
                case CardDB.cardIDEnum.KARA_12_01H:
                    return new Sim_KARA_12_01H();
                case CardDB.cardIDEnum.KARA_13_11:
                    return new Sim_KARA_13_11();
                case CardDB.cardIDEnum.KARA_09_06:
                    return new Sim_KARA_09_06();
                case CardDB.cardIDEnum.KARA_09_06heroic:
                    return new Sim_KARA_09_06heroic();
                case CardDB.cardIDEnum.KAR_094a:
                    return new Sim_KAR_094a();
                case CardDB.cardIDEnum.KAR_077e:
                    return new Sim_KAR_077e();
                case CardDB.cardIDEnum.KAR_077:
                    return new Sim_KAR_077();
                case CardDB.cardIDEnum.KAR_205:
                    return new Sim_KAR_205();
                case CardDB.cardIDEnum.KAR_A02_12:
                    return new Sim_KAR_A02_12();
                case CardDB.cardIDEnum.KAR_A02_12H:
                    return new Sim_KAR_A02_12H();
                case CardDB.cardIDEnum.KAR_063:
                    return new Sim_KAR_063();
                case CardDB.cardIDEnum.KAR_A02_02:
                    return new Sim_KAR_A02_02();
                case CardDB.cardIDEnum.KAR_A02_02H:
                    return new Sim_KAR_A02_02H();
                case CardDB.cardIDEnum.KARA_07_05:
                    return new Sim_KARA_07_05();
                case CardDB.cardIDEnum.KARA_07_05heroic:
                    return new Sim_KARA_07_05heroic();
                case CardDB.cardIDEnum.KARA_09_07:
                    return new Sim_KARA_09_07();
                case CardDB.cardIDEnum.KARA_09_07heroic:
                    return new Sim_KARA_09_07heroic();
                case CardDB.cardIDEnum.KAR_044a:
                    return new Sim_KAR_044a();
                case CardDB.cardIDEnum.KARA_09_05:
                    return new Sim_KARA_09_05();
                case CardDB.cardIDEnum.KARA_09_05heroic:
                    return new Sim_KARA_09_05heroic();
                case CardDB.cardIDEnum.KAR_069:
                    return new Sim_KAR_069();
                case CardDB.cardIDEnum.KAR_A02_09e:
                    return new Sim_KAR_A02_09e();
                case CardDB.cardIDEnum.KAR_A02_09eH:
                    return new Sim_KAR_A02_09eH();
                case CardDB.cardIDEnum.KAR_025c:
                    return new Sim_KAR_025c();
                case CardDB.cardIDEnum.KARA_09_01:
                    return new Sim_KARA_09_01();
                case CardDB.cardIDEnum.KARA_09_01heroic:
                    return new Sim_KARA_09_01heroic();
                case CardDB.cardIDEnum.KARA_08_05:
                    return new Sim_KARA_08_05();
                case CardDB.cardIDEnum.KARA_08_05H:
                    return new Sim_KARA_08_05H();
                case CardDB.cardIDEnum.KARA_04_01h:
                    return new Sim_KARA_04_01h();
                case CardDB.cardIDEnum.KARA_04_01heroic:
                    return new Sim_KARA_04_01heroic();
                case CardDB.cardIDEnum.KAR_061:
                    return new Sim_KAR_061();
                case CardDB.cardIDEnum.KARA_13_02:
                    return new Sim_KARA_13_02();
                case CardDB.cardIDEnum.KARA_13_02H:
                    return new Sim_KARA_13_02H();
                case CardDB.cardIDEnum.KAR_A02_11:
                    return new Sim_KAR_A02_11();
                case CardDB.cardIDEnum.KARA_05_01hp:
                    return new Sim_KARA_05_01hp();
                case CardDB.cardIDEnum.KARA_05_01hpheroic:
                    return new Sim_KARA_05_01hpheroic();
                case CardDB.cardIDEnum.KARA_05_01e:
                    return new Sim_KARA_05_01e();
                case CardDB.cardIDEnum.KARA_06_03hp:
                    return new Sim_KARA_06_03hp();
                case CardDB.cardIDEnum.KARA_06_03hpheroic:
                    return new Sim_KARA_06_03hpheroic();
                case CardDB.cardIDEnum.KARA_04_02hp:
                    return new Sim_KARA_04_02hp();
                case CardDB.cardIDEnum.KAR_712:
                    return new Sim_KAR_712();
                case CardDB.cardIDEnum.KAR_712e:
                    return new Sim_KAR_712e();
                case CardDB.cardIDEnum.KAR_095e:
                    return new Sim_KAR_095e();
                case CardDB.cardIDEnum.KAR_010a:
                    return new Sim_KAR_010a();
                case CardDB.cardIDEnum.KAR_A10_05:
                    return new Sim_KAR_A10_05();
                case CardDB.cardIDEnum.KAR_a10_Boss1:
                    return new Sim_KAR_a10_Boss1();
                case CardDB.cardIDEnum.KAR_a10_Boss1H:
                    return new Sim_KAR_a10_Boss1H();
                case CardDB.cardIDEnum.KAR_A10_08:
                    return new Sim_KAR_A10_08();
                case CardDB.cardIDEnum.KAR_A10_02:
                    return new Sim_KAR_A10_02();
                case CardDB.cardIDEnum.KAR_A10_09:
                    return new Sim_KAR_A10_09();
                case CardDB.cardIDEnum.KAR_A10_04:
                    return new Sim_KAR_A10_04();
                case CardDB.cardIDEnum.KAR_021:
                    return new Sim_KAR_021();
                case CardDB.cardIDEnum.KAR_095:
                    return new Sim_KAR_095();
 ///case CardDB.cardIDEnum.///LOE:
                    ///return new Sim_///LOE();
                case CardDB.cardIDEnum.LOEA04_28:
                    return new Sim_LOEA04_28();
                case CardDB.cardIDEnum.LOE_110t:
                    return new Sim_LOE_110t();
                case CardDB.cardIDEnum.LOEA13_2:
                    return new Sim_LOEA13_2();
                case CardDB.cardIDEnum.LOEA13_2H:
                    return new Sim_LOEA13_2H();
                case CardDB.cardIDEnum.LOE_110:
                    return new Sim_LOE_110();
                case CardDB.cardIDEnum.LOEA06_03:
                    return new Sim_LOEA06_03();
                case CardDB.cardIDEnum.LOEA06_03h:
                    return new Sim_LOEA06_03h();
                case CardDB.cardIDEnum.LOEA06_03e:
                    return new Sim_LOEA06_03e();
                case CardDB.cardIDEnum.LOEA06_03eh:
                    return new Sim_LOEA06_03eh();
                case CardDB.cardIDEnum.LOE_119:
                    return new Sim_LOE_119();
                case CardDB.cardIDEnum.LOEA04_27:
                    return new Sim_LOEA04_27();
                case CardDB.cardIDEnum.LOEA16_17:
                    return new Sim_LOEA16_17();
                case CardDB.cardIDEnum.LOE_061:
                    return new Sim_LOE_061();
                case CardDB.cardIDEnum.LOEA04_24:
                    return new Sim_LOEA04_24();
                case CardDB.cardIDEnum.LOEA04_24h:
                    return new Sim_LOEA04_24h();
                case CardDB.cardIDEnum.LOE_026:
                    return new Sim_LOE_026();
                case CardDB.cardIDEnum.LOEA08_01:
                    return new Sim_LOEA08_01();
                case CardDB.cardIDEnum.LOEA08_01h:
                    return new Sim_LOEA08_01h();
                case CardDB.cardIDEnum.LOEA16_22:
                    return new Sim_LOEA16_22();
                case CardDB.cardIDEnum.LOEA16_22H:
                    return new Sim_LOEA16_22H();
                case CardDB.cardIDEnum.LOE_092:
                    return new Sim_LOE_092();
                case CardDB.cardIDEnum.LOE_115b:
                    return new Sim_LOE_115b();
                case CardDB.cardIDEnum.LOEA07_21:
                    return new Sim_LOEA07_21();
                case CardDB.cardIDEnum.LOEA16_7:
                    return new Sim_LOEA16_7();
                case CardDB.cardIDEnum.LOEA16_20e:
                    return new Sim_LOEA16_20e();
                case CardDB.cardIDEnum.LOEA16_20:
                    return new Sim_LOEA16_20();
                case CardDB.cardIDEnum.LOEA16_20H:
                    return new Sim_LOEA16_20H();
                case CardDB.cardIDEnum.LOEA01_02:
                    return new Sim_LOEA01_02();
                case CardDB.cardIDEnum.LOEA01_02h:
                    return new Sim_LOEA01_02h();
                case CardDB.cardIDEnum.LOEA15_3:
                    return new Sim_LOEA15_3();
                case CardDB.cardIDEnum.LOEA15_3H:
                    return new Sim_LOEA15_3H();
                case CardDB.cardIDEnum.LOEA07_20:
                    return new Sim_LOEA07_20();
                case CardDB.cardIDEnum.LOE_077:
                    return new Sim_LOE_077();
                case CardDB.cardIDEnum.LOE_115a:
                    return new Sim_LOE_115a();
                case CardDB.cardIDEnum.LOE_077e:
                    return new Sim_LOE_077e();
                case CardDB.cardIDEnum.LOEA09_7:
                    return new Sim_LOEA09_7();
                case CardDB.cardIDEnum.LOEA09_7e:
                    return new Sim_LOEA09_7e();
                case CardDB.cardIDEnum.LOEA09_7H:
                    return new Sim_LOEA09_7H();
                case CardDB.cardIDEnum.LOEA07_09:
                    return new Sim_LOEA07_09();
                case CardDB.cardIDEnum.LOEA05_01:
                    return new Sim_LOEA05_01();
                case CardDB.cardIDEnum.LOEA05_01h:
                    return new Sim_LOEA05_01h();
                case CardDB.cardIDEnum.LOEA16_21:
                    return new Sim_LOEA16_21();
                case CardDB.cardIDEnum.LOEA16_21H:
                    return new Sim_LOEA16_21H();
                case CardDB.cardIDEnum.LOEA07_26:
                    return new Sim_LOEA07_26();
                case CardDB.cardIDEnum.LOEA16_11:
                    return new Sim_LOEA16_11();
                case CardDB.cardIDEnum.LOE_007:
                    return new Sim_LOE_007();
                case CardDB.cardIDEnum.LOE_007t:
                    return new Sim_LOE_007t();
                case CardDB.cardIDEnum.LOE_118:
                    return new Sim_LOE_118();
                case CardDB.cardIDEnum.LOE_118e:
                    return new Sim_LOE_118e();
                case CardDB.cardIDEnum.LOE_023:
                    return new Sim_LOE_023();
                case CardDB.cardIDEnum.LOE_021:
                    return new Sim_LOE_021();
                case CardDB.cardIDEnum.LOEA07_11:
                    return new Sim_LOEA07_11();
                case CardDB.cardIDEnum.LOE_020:
                    return new Sim_LOE_020();
                case CardDB.cardIDEnum.LOE_053:
                    return new Sim_LOE_053();
                case CardDB.cardIDEnum.LOEA02_02:
                    return new Sim_LOEA02_02();
                case CardDB.cardIDEnum.LOEA02_02h:
                    return new Sim_LOEA02_02h();
                case CardDB.cardIDEnum.LOEA04_28a:
                    return new Sim_LOEA04_28a();
                case CardDB.cardIDEnum.LOEA07_18:
                    return new Sim_LOEA07_18();
                case CardDB.cardIDEnum.LOEA07_12:
                    return new Sim_LOEA07_12();
                case CardDB.cardIDEnum.LOEA06_02t:
                    return new Sim_LOEA06_02t();
                case CardDB.cardIDEnum.LOEA06_02th:
                    return new Sim_LOEA06_02th();
                case CardDB.cardIDEnum.LOE_107:
                    return new Sim_LOE_107();
                case CardDB.cardIDEnum.LOE_079:
                    return new Sim_LOE_079();
                case CardDB.cardIDEnum.LOEA09_3H:
                    return new Sim_LOEA09_3H();
                case CardDB.cardIDEnum.LOEA09_2:
                    return new Sim_LOEA09_2();
                case CardDB.cardIDEnum.LOEA09_2e:
                    return new Sim_LOEA09_2e();
                case CardDB.cardIDEnum.LOEA09_2eH:
                    return new Sim_LOEA09_2eH();
                case CardDB.cardIDEnum.LOEA09_2H:
                    return new Sim_LOEA09_2H();
                case CardDB.cardIDEnum.LOE_104:
                    return new Sim_LOE_104();
                case CardDB.cardIDEnum.LOEA04_02:
                    return new Sim_LOEA04_02();
                case CardDB.cardIDEnum.LOEA04_02h:
                    return new Sim_LOEA04_02h();
                case CardDB.cardIDEnum.LOE_003:
                    return new Sim_LOE_003();
                case CardDB.cardIDEnum.LOE_113:
                    return new Sim_LOE_113();
                case CardDB.cardIDEnum.LOE_111:
                    return new Sim_LOE_111();
                case CardDB.cardIDEnum.LOE_105:
                    return new Sim_LOE_105();
                case CardDB.cardIDEnum.LOE_105e:
                    return new Sim_LOE_105e();
                case CardDB.cardIDEnum.LOE_008:
                    return new Sim_LOE_008();
                case CardDB.cardIDEnum.LOE_008H:
                    return new Sim_LOE_008H();
                case CardDB.cardIDEnum.LOEA16_13:
                    return new Sim_LOEA16_13();
                case CardDB.cardIDEnum.LOEA09_3a:
                    return new Sim_LOEA09_3a();
                case CardDB.cardIDEnum.LOEA09_3aH:
                    return new Sim_LOEA09_3aH();
                case CardDB.cardIDEnum.LOE_022:
                    return new Sim_LOE_022();
                case CardDB.cardIDEnum.LOEA07_03:
                    return new Sim_LOEA07_03();
                case CardDB.cardIDEnum.LOEA07_03h:
                    return new Sim_LOEA07_03h();
                case CardDB.cardIDEnum.LOE_002:
                    return new Sim_LOE_002();
                case CardDB.cardIDEnum.LOE_073e:
                    return new Sim_LOE_073e();
                case CardDB.cardIDEnum.LOE_073:
                    return new Sim_LOE_073();
                case CardDB.cardIDEnum.LOEA09_3:
                    return new Sim_LOEA09_3();
                case CardDB.cardIDEnum.LOEA09_3b:
                    return new Sim_LOEA09_3b();
                case CardDB.cardIDEnum.LOEA09_3c:
                    return new Sim_LOEA09_3c();
                case CardDB.cardIDEnum.LOEA09_3d:
                    return new Sim_LOEA09_3d();
                case CardDB.cardIDEnum.LOEA04_23:
                    return new Sim_LOEA04_23();
                case CardDB.cardIDEnum.LOEA04_23h:
                    return new Sim_LOEA04_23h();
                case CardDB.cardIDEnum.LOEA10_1:
                    return new Sim_LOEA10_1();
                case CardDB.cardIDEnum.LOEA10_1H:
                    return new Sim_LOEA10_1H();
                case CardDB.cardIDEnum.LOEA16_24:
                    return new Sim_LOEA16_24();
                case CardDB.cardIDEnum.LOEA16_24H:
                    return new Sim_LOEA16_24H();
                case CardDB.cardIDEnum.LOE_019t2:
                    return new Sim_LOE_019t2();
                case CardDB.cardIDEnum.LOE_039:
                    return new Sim_LOE_039();
                case CardDB.cardIDEnum.LOE_089t3:
                    return new Sim_LOE_089t3();
                case CardDB.cardIDEnum.LOEA16_10:
                    return new Sim_LOEA16_10();
                case CardDB.cardIDEnum.LOEA01_11he:
                    return new Sim_LOEA01_11he();
                case CardDB.cardIDEnum.LOEA16_21He:
                    return new Sim_LOEA16_21He();
                case CardDB.cardIDEnum.LOE_030e:
                    return new Sim_LOE_030e();
                case CardDB.cardIDEnum.LOE_046:
                    return new Sim_LOE_046();
                case CardDB.cardIDEnum.LOEA09_10:
                    return new Sim_LOEA09_10();
                case CardDB.cardIDEnum.LOEA09_11:
                    return new Sim_LOEA09_11();
                case CardDB.cardIDEnum.LOEA09_12:
                    return new Sim_LOEA09_12();
                case CardDB.cardIDEnum.LOEA09_13:
                    return new Sim_LOEA09_13();
                case CardDB.cardIDEnum.LOEA09_5:
                    return new Sim_LOEA09_5();
                case CardDB.cardIDEnum.LOEA09_5H:
                    return new Sim_LOEA09_5H();
                case CardDB.cardIDEnum.LOEA04_29b:
                    return new Sim_LOEA04_29b();
                case CardDB.cardIDEnum.LOE_029:
                    return new Sim_LOE_029();
                case CardDB.cardIDEnum.LOE_051:
                    return new Sim_LOE_051();
                case CardDB.cardIDEnum.LOE_017:
                    return new Sim_LOE_017();
                case CardDB.cardIDEnum.LOEA16_14:
                    return new Sim_LOEA16_14();
                case CardDB.cardIDEnum.LOEA12_1:
                    return new Sim_LOEA12_1();
                case CardDB.cardIDEnum.LOEA12_1H:
                    return new Sim_LOEA12_1H();
                case CardDB.cardIDEnum.LOEA16_25:
                    return new Sim_LOEA16_25();
                case CardDB.cardIDEnum.LOEA16_25H:
                    return new Sim_LOEA16_25H();
                case CardDB.cardIDEnum.LOEA16_3:
                    return new Sim_LOEA16_3();
                case CardDB.cardIDEnum.LOEA16_3e:
                    return new Sim_LOEA16_3e();
                case CardDB.cardIDEnum.LOEA02_10a:
                    return new Sim_LOEA02_10a();
                case CardDB.cardIDEnum.LOEA_01:
                    return new Sim_LOEA_01();
                case CardDB.cardIDEnum.LOEA_01H:
                    return new Sim_LOEA_01H();
                case CardDB.cardIDEnum.LOEA09_1:
                    return new Sim_LOEA09_1();
                case CardDB.cardIDEnum.LOEA09_1H:
                    return new Sim_LOEA09_1H();
                case CardDB.cardIDEnum.LOEA16_23:
                    return new Sim_LOEA16_23();
                case CardDB.cardIDEnum.LOEA16_23H:
                    return new Sim_LOEA16_23H();
                case CardDB.cardIDEnum.LOEA16_9:
                    return new Sim_LOEA16_9();
                case CardDB.cardIDEnum.LOEA07_14:
                    return new Sim_LOEA07_14();
                case CardDB.cardIDEnum.LOE_019t:
                    return new Sim_LOE_019t();
                case CardDB.cardIDEnum.LOEA07_25:
                    return new Sim_LOEA07_25();
                case CardDB.cardIDEnum.LOEA16_12:
                    return new Sim_LOEA16_12();
                case CardDB.cardIDEnum.LOEA07_01:
                    return new Sim_LOEA07_01();
                case CardDB.cardIDEnum.LOEA07_02:
                    return new Sim_LOEA07_02();
                case CardDB.cardIDEnum.LOEA07_02h:
                    return new Sim_LOEA07_02h();
                case CardDB.cardIDEnum.LOEA16_5:
                    return new Sim_LOEA16_5();
                case CardDB.cardIDEnum.LOEA02_10c:
                    return new Sim_LOEA02_10c();
                case CardDB.cardIDEnum.LOE_050:
                    return new Sim_LOE_050();
                case CardDB.cardIDEnum.LOEA10_5:
                    return new Sim_LOEA10_5();
                case CardDB.cardIDEnum.LOEA10_5H:
                    return new Sim_LOEA10_5H();
                case CardDB.cardIDEnum.LOE_113e:
                    return new Sim_LOE_113e();
                case CardDB.cardIDEnum.LOEA10_2:
                    return new Sim_LOEA10_2();
                case CardDB.cardIDEnum.LOEA10_2H:
                    return new Sim_LOEA10_2H();
                case CardDB.cardIDEnum.LOEA16_5t:
                    return new Sim_LOEA16_5t();
                case CardDB.cardIDEnum.LOEA10_3:
                    return new Sim_LOEA10_3();
                case CardDB.cardIDEnum.LOE_006:
                    return new Sim_LOE_006();
                case CardDB.cardIDEnum.LOEA09_9:
                    return new Sim_LOEA09_9();
                case CardDB.cardIDEnum.LOEA09_9H:
                    return new Sim_LOEA09_9H();
                case CardDB.cardIDEnum.LOE_038:
                    return new Sim_LOE_038();
                case CardDB.cardIDEnum.LOEA04_31b:
                    return new Sim_LOEA04_31b();
                case CardDB.cardIDEnum.LOE_009:
                    return new Sim_LOE_009();
                case CardDB.cardIDEnum.LOEA04_13bt:
                    return new Sim_LOEA04_13bt();
                case CardDB.cardIDEnum.LOEA04_13bth:
                    return new Sim_LOEA04_13bth();
                case CardDB.cardIDEnum.LOEA12_2:
                    return new Sim_LOEA12_2();
                case CardDB.cardIDEnum.LOEA12_2H:
                    return new Sim_LOEA12_2H();
                case CardDB.cardIDEnum.LOEA04_06:
                    return new Sim_LOEA04_06();
                case CardDB.cardIDEnum.LOE_010:
                    return new Sim_LOE_010();
                case CardDB.cardIDEnum.LOEA14_2:
                    return new Sim_LOEA14_2();
                case CardDB.cardIDEnum.LOEA14_2H:
                    return new Sim_LOEA14_2H();
                case CardDB.cardIDEnum.LOE_061e:
                    return new Sim_LOE_061e();
                case CardDB.cardIDEnum.LOEA16_8:
                    return new Sim_LOEA16_8();
                case CardDB.cardIDEnum.LOEA16_8a:
                    return new Sim_LOEA16_8a();
                case CardDB.cardIDEnum.LOEA15_1:
                    return new Sim_LOEA15_1();
                case CardDB.cardIDEnum.LOEA15_1H:
                    return new Sim_LOEA15_1H();
                case CardDB.cardIDEnum.LOEA16_1:
                    return new Sim_LOEA16_1();
                case CardDB.cardIDEnum.LOEA16_1H:
                    return new Sim_LOEA16_1H();
                case CardDB.cardIDEnum.LOEA09_4:
                    return new Sim_LOEA09_4();
                case CardDB.cardIDEnum.LOEA09_4H:
                    return new Sim_LOEA09_4H();
                case CardDB.cardIDEnum.LOE_089t:
                    return new Sim_LOE_089t();
                case CardDB.cardIDEnum.LOE_115:
                    return new Sim_LOE_115();
                case CardDB.cardIDEnum.LOE_116:
                    return new Sim_LOE_116();
                case CardDB.cardIDEnum.LOE_011:
                    return new Sim_LOE_011();
                case CardDB.cardIDEnum.LOEA07_28:
                    return new Sim_LOEA07_28();
                case CardDB.cardIDEnum.LOE_002t:
                    return new Sim_LOE_002t();
                case CardDB.cardIDEnum.LOE_016t:
                    return new Sim_LOE_016t();
                case CardDB.cardIDEnum.LOEA01_11:
                    return new Sim_LOEA01_11();
                case CardDB.cardIDEnum.LOEA01_11h:
                    return new Sim_LOEA01_11h();
                case CardDB.cardIDEnum.LOE_024t:
                    return new Sim_LOE_024t();
                case CardDB.cardIDEnum.LOE_016:
                    return new Sim_LOE_016();
                case CardDB.cardIDEnum.LOEA16_16:
                    return new Sim_LOEA16_16();
                case CardDB.cardIDEnum.LOEA16_16H:
                    return new Sim_LOEA16_16H();
                case CardDB.cardIDEnum.LOE_027:
                    return new Sim_LOE_027();
                case CardDB.cardIDEnum.LOE_009t:
                    return new Sim_LOE_009t();
                case CardDB.cardIDEnum.LOEA16_21e:
                    return new Sim_LOEA16_21e();
                case CardDB.cardIDEnum.LOE_038e:
                    return new Sim_LOE_038e();
                case CardDB.cardIDEnum.LOEA04_25:
                    return new Sim_LOEA04_25();
                case CardDB.cardIDEnum.LOEA04_25h:
                    return new Sim_LOEA04_25h();
                case CardDB.cardIDEnum.LOEA16_6:
                    return new Sim_LOEA16_6();
                case CardDB.cardIDEnum.LOEA06_04:
                    return new Sim_LOEA06_04();
                case CardDB.cardIDEnum.LOEA06_04h:
                    return new Sim_LOEA06_04h();
                case CardDB.cardIDEnum.LOE_009e:
                    return new Sim_LOE_009e();
                case CardDB.cardIDEnum.LOE_076:
                    return new Sim_LOE_076();
                case CardDB.cardIDEnum.LOEA13_1:
                    return new Sim_LOEA13_1();
                case CardDB.cardIDEnum.LOEA13_1h:
                    return new Sim_LOEA13_1h();
                case CardDB.cardIDEnum.LOEA16_26:
                    return new Sim_LOEA16_26();
                case CardDB.cardIDEnum.LOEA16_26H:
                    return new Sim_LOEA16_26H();
                case CardDB.cardIDEnum.LOEA09_6:
                    return new Sim_LOEA09_6();
                case CardDB.cardIDEnum.LOEA09_6H:
                    return new Sim_LOEA09_6H();
                case CardDB.cardIDEnum.LOEA09_8:
                    return new Sim_LOEA09_8();
                case CardDB.cardIDEnum.LOEA09_8H:
                    return new Sim_LOEA09_8H();
                case CardDB.cardIDEnum.LOEA07_24:
                    return new Sim_LOEA07_24();
                case CardDB.cardIDEnum.LOEA16_2:
                    return new Sim_LOEA16_2();
                case CardDB.cardIDEnum.LOEA16_2H:
                    return new Sim_LOEA16_2H();
                case CardDB.cardIDEnum.LOEA06_02:
                    return new Sim_LOEA06_02();
                case CardDB.cardIDEnum.LOEA06_02h:
                    return new Sim_LOEA06_02h();
                case CardDB.cardIDEnum.LOE_086:
                    return new Sim_LOE_086();
                case CardDB.cardIDEnum.LOEA01_01:
                    return new Sim_LOEA01_01();
                case CardDB.cardIDEnum.LOEA01_01h:
                    return new Sim_LOEA01_01h();
                case CardDB.cardIDEnum.LOEA16_19:
                    return new Sim_LOEA16_19();
                case CardDB.cardIDEnum.LOEA16_19H:
                    return new Sim_LOEA16_19H();
                case CardDB.cardIDEnum.LOEA04_06a:
                    return new Sim_LOEA04_06a();
                case CardDB.cardIDEnum.LOEA04_30a:
                    return new Sim_LOEA04_30a();
                case CardDB.cardIDEnum.LOEA04_01:
                    return new Sim_LOEA04_01();
                case CardDB.cardIDEnum.LOEA04_01h:
                    return new Sim_LOEA04_01h();
                case CardDB.cardIDEnum.LOEA04_01e:
                    return new Sim_LOEA04_01e();
                case CardDB.cardIDEnum.LOEA04_01eh:
                    return new Sim_LOEA04_01eh();
                case CardDB.cardIDEnum.LOEA04_30:
                    return new Sim_LOEA04_30();
                case CardDB.cardIDEnum.LOEA04_29:
                    return new Sim_LOEA04_29();
                case CardDB.cardIDEnum.LOEA14_1:
                    return new Sim_LOEA14_1();
                case CardDB.cardIDEnum.LOEA14_1H:
                    return new Sim_LOEA14_1H();
                case CardDB.cardIDEnum.LOEA16_27:
                    return new Sim_LOEA16_27();
                case CardDB.cardIDEnum.LOEA16_27H:
                    return new Sim_LOEA16_27H();
                case CardDB.cardIDEnum.LOEA07_29:
                    return new Sim_LOEA07_29();
                case CardDB.cardIDEnum.LOEA16_4:
                    return new Sim_LOEA16_4();
                case CardDB.cardIDEnum.LOEA01_12:
                    return new Sim_LOEA01_12();
                case CardDB.cardIDEnum.LOEA01_12h:
                    return new Sim_LOEA01_12h();
                case CardDB.cardIDEnum.LOE_012:
                    return new Sim_LOE_012();
                case CardDB.cardIDEnum.LOE_047:
                    return new Sim_LOE_047();
                case CardDB.cardIDEnum.LOEA04_29a:
                    return new Sim_LOEA04_29a();
                case CardDB.cardIDEnum.LOEA05_02:
                    return new Sim_LOEA05_02();
                case CardDB.cardIDEnum.LOEA05_02a:
                    return new Sim_LOEA05_02a();
                case CardDB.cardIDEnum.LOEA05_02h:
                    return new Sim_LOEA05_02h();
                case CardDB.cardIDEnum.LOEA05_02ha:
                    return new Sim_LOEA05_02ha();
                case CardDB.cardIDEnum.LOEA05_03:
                    return new Sim_LOEA05_03();
                case CardDB.cardIDEnum.LOEA05_03h:
                    return new Sim_LOEA05_03h();
                case CardDB.cardIDEnum.LOE_018e:
                    return new Sim_LOE_018e();
                case CardDB.cardIDEnum.LOE_018:
                    return new Sim_LOE_018();
                case CardDB.cardIDEnum.LOE_019:
                    return new Sim_LOE_019();
                case CardDB.cardIDEnum.LOE_019e:
                    return new Sim_LOE_019e();
                case CardDB.cardIDEnum.LOEA15_2:
                    return new Sim_LOEA15_2();
                case CardDB.cardIDEnum.LOEA15_2H:
                    return new Sim_LOEA15_2H();
                case CardDB.cardIDEnum.LOEA04_28b:
                    return new Sim_LOEA04_28b();
                case CardDB.cardIDEnum.LOEA04_06b:
                    return new Sim_LOEA04_06b();
                case CardDB.cardIDEnum.LOE_017e:
                    return new Sim_LOE_017e();
                case CardDB.cardIDEnum.LOE_089t2:
                    return new Sim_LOE_089t2();
                case CardDB.cardIDEnum.LOEA02_10:
                    return new Sim_LOEA02_10();
                case CardDB.cardIDEnum.LOEA02_05:
                    return new Sim_LOEA02_05();
                case CardDB.cardIDEnum.LOEA02_06:
                    return new Sim_LOEA02_06();
                case CardDB.cardIDEnum.LOEA02_03:
                    return new Sim_LOEA02_03();
                case CardDB.cardIDEnum.LOEA02_04:
                    return new Sim_LOEA02_04();
                case CardDB.cardIDEnum.LOE_089:
                    return new Sim_LOE_089();
                case CardDB.cardIDEnum.LOEA16_15:
                    return new Sim_LOEA16_15();
                case CardDB.cardIDEnum.LOEA02_01:
                    return new Sim_LOEA02_01();
                case CardDB.cardIDEnum.LOEA02_01h:
                    return new Sim_LOEA02_01h();
                case CardDB.cardIDEnum.LOEA16_18:
                    return new Sim_LOEA16_18();
                case CardDB.cardIDEnum.LOEA16_18H:
                    return new Sim_LOEA16_18H();
 ///case CardDB.cardIDEnum.///OG:
                    ///return new Sim_///OG();
                case CardDB.cardIDEnum.OG_311:
                    return new Sim_OG_311();
                case CardDB.cardIDEnum.OG_150:
                    return new Sim_OG_150();
                case CardDB.cardIDEnum.OG_313e:
                    return new Sim_OG_313e();
                case CardDB.cardIDEnum.OG_313:
                    return new Sim_OG_313();
                case CardDB.cardIDEnum.OG_188e:
                    return new Sim_OG_188e();
                case CardDB.cardIDEnum.OG_248:
                    return new Sim_OG_248();
                case CardDB.cardIDEnum.OG_290:
                    return new Sim_OG_290();
                case CardDB.cardIDEnum.OG_301:
                    return new Sim_OG_301();
                case CardDB.cardIDEnum.OG_120:
                    return new Sim_OG_120();
                case CardDB.cardIDEnum.OG_293e:
                    return new Sim_OG_293e();
                case CardDB.cardIDEnum.OG_311e:
                    return new Sim_OG_311e();
                case CardDB.cardIDEnum.OG_281:
                    return new Sim_OG_281();
                case CardDB.cardIDEnum.OG_195b:
                    return new Sim_OG_195b();
                case CardDB.cardIDEnum.OG_156:
                    return new Sim_OG_156();
                case CardDB.cardIDEnum.OG_322:
                    return new Sim_OG_322();
                case CardDB.cardIDEnum.OG_282:
                    return new Sim_OG_282();
                case CardDB.cardIDEnum.OG_070:
                    return new Sim_OG_070();
                case CardDB.cardIDEnum.OG_173:
                    return new Sim_OG_173();
                case CardDB.cardIDEnum.OG_314:
                    return new Sim_OG_314();
                case CardDB.cardIDEnum.OG_276:
                    return new Sim_OG_276();
                case CardDB.cardIDEnum.OG_218:
                    return new Sim_OG_218();
                case CardDB.cardIDEnum.OG_315:
                    return new Sim_OG_315();
                case CardDB.cardIDEnum.OG_080ae:
                    return new Sim_OG_080ae();
                case CardDB.cardIDEnum.OG_080c:
                    return new Sim_OG_080c();
                case CardDB.cardIDEnum.OG_153:
                    return new Sim_OG_153();
                case CardDB.cardIDEnum.OG_080ee:
                    return new Sim_OG_080ee();
                case CardDB.cardIDEnum.OG_080d:
                    return new Sim_OG_080d();
                case CardDB.cardIDEnum.OG_090:
                    return new Sim_OG_090();
                case CardDB.cardIDEnum.OG_211:
                    return new Sim_OG_211();
                case CardDB.cardIDEnum.OG_290e:
                    return new Sim_OG_290e();
                case CardDB.cardIDEnum.OG_325:
                    return new Sim_OG_325();
                case CardDB.cardIDEnum.OG_121:
                    return new Sim_OG_121();
                case CardDB.cardIDEnum.OG_147:
                    return new Sim_OG_147();
                case CardDB.cardIDEnum.OG_161:
                    return new Sim_OG_161();
                case CardDB.cardIDEnum.OG_321:
                    return new Sim_OG_321();
                case CardDB.cardIDEnum.OG_279:
                    return new Sim_OG_279();
                case CardDB.cardIDEnum.OG_280:
                    return new Sim_OG_280();
                case CardDB.cardIDEnum.OG_283:
                    return new Sim_OG_283();
                case CardDB.cardIDEnum.OG_295:
                    return new Sim_OG_295();
                case CardDB.cardIDEnum.OG_303:
                    return new Sim_OG_303();
                case CardDB.cardIDEnum.OG_337:
                    return new Sim_OG_337();
                case CardDB.cardIDEnum.OG_293:
                    return new Sim_OG_293();
                case CardDB.cardIDEnum.OG_293f:
                    return new Sim_OG_293f();
                case CardDB.cardIDEnum.OG_121e:
                    return new Sim_OG_121e();
                case CardDB.cardIDEnum.OG_234:
                    return new Sim_OG_234();
                case CardDB.cardIDEnum.OG_113:
                    return new Sim_OG_113();
                case CardDB.cardIDEnum.OG_109:
                    return new Sim_OG_109();
                case CardDB.cardIDEnum.OG_102:
                    return new Sim_OG_102();
                case CardDB.cardIDEnum.OG_317:
                    return new Sim_OG_317();
                case CardDB.cardIDEnum.OG_085:
                    return new Sim_OG_085();
                case CardDB.cardIDEnum.OG_282e:
                    return new Sim_OG_282e();
                case CardDB.cardIDEnum.OG_162:
                    return new Sim_OG_162();
                case CardDB.cardIDEnum.OG_223:
                    return new Sim_OG_223();
                case CardDB.cardIDEnum.OG_239:
                    return new Sim_OG_239();
                case CardDB.cardIDEnum.OG_200e:
                    return new Sim_OG_200e();
                case CardDB.cardIDEnum.OG_255:
                    return new Sim_OG_255();
                case CardDB.cardIDEnum.OG_326:
                    return new Sim_OG_326();
                case CardDB.cardIDEnum.OG_254:
                    return new Sim_OG_254();
                case CardDB.cardIDEnum.OG_142:
                    return new Sim_OG_142();
                case CardDB.cardIDEnum.OG_104:
                    return new Sim_OG_104();
                case CardDB.cardIDEnum.OG_104e:
                    return new Sim_OG_104e();
                case CardDB.cardIDEnum.OG_195e:
                    return new Sim_OG_195e();
                case CardDB.cardIDEnum.OG_150e:
                    return new Sim_OG_150e();
                case CardDB.cardIDEnum.OG_218e:
                    return new Sim_OG_218e();
                case CardDB.cardIDEnum.OG_026:
                    return new Sim_OG_026();
                case CardDB.cardIDEnum.OG_337e:
                    return new Sim_OG_337e();
                case CardDB.cardIDEnum.OG_027:
                    return new Sim_OG_027();
                case CardDB.cardIDEnum.TB_OG_027:
                    return new Sim_TB_OG_027();
                case CardDB.cardIDEnum.OG_047b:
                    return new Sim_OG_047b();
                case CardDB.cardIDEnum.OG_047a:
                    return new Sim_OG_047a();
                case CardDB.cardIDEnum.OG_082:
                    return new Sim_OG_082();
                case CardDB.cardIDEnum.OG_174e:
                    return new Sim_OG_174e();
                case CardDB.cardIDEnum.OG_141:
                    return new Sim_OG_141();
                case CardDB.cardIDEnum.OG_272t:
                    return new Sim_OG_272t();
                case CardDB.cardIDEnum.OG_174:
                    return new Sim_OG_174();
                case CardDB.cardIDEnum.OG_207:
                    return new Sim_OG_207();
                case CardDB.cardIDEnum.OG_080de:
                    return new Sim_OG_080de();
                case CardDB.cardIDEnum.OG_080e:
                    return new Sim_OG_080e();
                case CardDB.cardIDEnum.OG_281e:
                    return new Sim_OG_281e();
                case CardDB.cardIDEnum.OG_044:
                    return new Sim_OG_044();
                case CardDB.cardIDEnum.OG_047:
                    return new Sim_OG_047();
                case CardDB.cardIDEnum.OG_179:
                    return new Sim_OG_179();
                case CardDB.cardIDEnum.OG_080f:
                    return new Sim_OG_080f();
                case CardDB.cardIDEnum.OG_024:
                    return new Sim_OG_024();
                case CardDB.cardIDEnum.OG_291e:
                    return new Sim_OG_291e();
                case CardDB.cardIDEnum.OG_051:
                    return new Sim_OG_051();
                case CardDB.cardIDEnum.OG_086:
                    return new Sim_OG_086();
                case CardDB.cardIDEnum.OG_198:
                    return new Sim_OG_198();
                case CardDB.cardIDEnum.OG_051e:
                    return new Sim_OG_051e();
                case CardDB.cardIDEnum.OG_114:
                    return new Sim_OG_114();
                case CardDB.cardIDEnum.OG_101:
                    return new Sim_OG_101();
                case CardDB.cardIDEnum.OG_292:
                    return new Sim_OG_292();
                case CardDB.cardIDEnum.OG_284e:
                    return new Sim_OG_284e();
                case CardDB.cardIDEnum.OG_308:
                    return new Sim_OG_308();
                case CardDB.cardIDEnum.OG_318t:
                    return new Sim_OG_318t();
                case CardDB.cardIDEnum.OG_152:
                    return new Sim_OG_152();
                case CardDB.cardIDEnum.OG_209:
                    return new Sim_OG_209();
                case CardDB.cardIDEnum.OG_031:
                    return new Sim_OG_031();
                case CardDB.cardIDEnum.OG_316:
                    return new Sim_OG_316();
                case CardDB.cardIDEnum.OG_318:
                    return new Sim_OG_318();
                case CardDB.cardIDEnum.OG_334:
                    return new Sim_OG_334();
                case CardDB.cardIDEnum.OG_320e:
                    return new Sim_OG_320e();
                case CardDB.cardIDEnum.OG_114a:
                    return new Sim_OG_114a();
                case CardDB.cardIDEnum.OG_045:
                    return new Sim_OG_045();
                case CardDB.cardIDEnum.OG_249:
                    return new Sim_OG_249();
                case CardDB.cardIDEnum.OG_216:
                    return new Sim_OG_216();
                case CardDB.cardIDEnum.OG_072:
                    return new Sim_OG_072();
                case CardDB.cardIDEnum.OG_080b:
                    return new Sim_OG_080b();
                case CardDB.cardIDEnum.OG_188:
                    return new Sim_OG_188();
                case CardDB.cardIDEnum.OG_220:
                    return new Sim_OG_220();
                case CardDB.cardIDEnum.OG_195a:
                    return new Sim_OG_195a();
                case CardDB.cardIDEnum.OG_048:
                    return new Sim_OG_048();
                case CardDB.cardIDEnum.OG_048e:
                    return new Sim_OG_048e();
                case CardDB.cardIDEnum.OG_328:
                    return new Sim_OG_328();
                case CardDB.cardIDEnum.OG_061t:
                    return new Sim_OG_061t();
                case CardDB.cardIDEnum.OG_320:
                    return new Sim_OG_320();
                case CardDB.cardIDEnum.OG_202:
                    return new Sim_OG_202();
                case CardDB.cardIDEnum.OG_122:
                    return new Sim_OG_122();
                case CardDB.cardIDEnum.OG_338:
                    return new Sim_OG_338();
                case CardDB.cardIDEnum.OG_138:
                    return new Sim_OG_138();
                case CardDB.cardIDEnum.OG_270a:
                    return new Sim_OG_270a();
                case CardDB.cardIDEnum.OG_045a:
                    return new Sim_OG_045a();
                case CardDB.cardIDEnum.OG_118f:
                    return new Sim_OG_118f();
                case CardDB.cardIDEnum.OG_292e:
                    return new Sim_OG_292e();
                case CardDB.cardIDEnum.OG_133:
                    return new Sim_OG_133();
                case CardDB.cardIDEnum.OG_312:
                    return new Sim_OG_312();
                case CardDB.cardIDEnum.OG_061:
                    return new Sim_OG_061();
                case CardDB.cardIDEnum.OG_156a:
                    return new Sim_OG_156a();
                case CardDB.cardIDEnum.OG_223e:
                    return new Sim_OG_223e();
                case CardDB.cardIDEnum.OG_323:
                    return new Sim_OG_323();
                case CardDB.cardIDEnum.OG_241:
                    return new Sim_OG_241();
                case CardDB.cardIDEnum.OG_321e:
                    return new Sim_OG_321e();
                case CardDB.cardIDEnum.OG_113e:
                    return new Sim_OG_113e();
                case CardDB.cardIDEnum.OG_102e:
                    return new Sim_OG_102e();
                case CardDB.cardIDEnum.OG_094:
                    return new Sim_OG_094();
                case CardDB.cardIDEnum.OG_023:
                    return new Sim_OG_023();
                case CardDB.cardIDEnum.OG_023t:
                    return new Sim_OG_023t();
                case CardDB.cardIDEnum.OG_309:
                    return new Sim_OG_309();
                case CardDB.cardIDEnum.OG_145:
                    return new Sim_OG_145();
                case CardDB.cardIDEnum.OG_229:
                    return new Sim_OG_229();
                case CardDB.cardIDEnum.OG_222e:
                    return new Sim_OG_222e();
                case CardDB.cardIDEnum.OG_222:
                    return new Sim_OG_222();
                case CardDB.cardIDEnum.OG_149:
                    return new Sim_OG_149();
                case CardDB.cardIDEnum.OG_315e:
                    return new Sim_OG_315e();
                case CardDB.cardIDEnum.OG_118:
                    return new Sim_OG_118();
                case CardDB.cardIDEnum.OG_118e:
                    return new Sim_OG_118e();
                case CardDB.cardIDEnum.OG_058:
                    return new Sim_OG_058();
                case CardDB.cardIDEnum.OG_271:
                    return new Sim_OG_271();
                case CardDB.cardIDEnum.OG_254e:
                    return new Sim_OG_254e();
                case CardDB.cardIDEnum.OG_158e:
                    return new Sim_OG_158e();
                case CardDB.cardIDEnum.OG_221:
                    return new Sim_OG_221();
                case CardDB.cardIDEnum.OG_087:
                    return new Sim_OG_087();
                case CardDB.cardIDEnum.OG_176:
                    return new Sim_OG_176();
                case CardDB.cardIDEnum.OG_100:
                    return new Sim_OG_100();
                case CardDB.cardIDEnum.OG_241a:
                    return new Sim_OG_241a();
                case CardDB.cardIDEnum.OG_291:
                    return new Sim_OG_291();
                case CardDB.cardIDEnum.LOOT_010e:
                    return new Sim_LOOT_010e();
                case CardDB.cardIDEnum.OG_316k:
                    return new Sim_OG_316k();
                case CardDB.cardIDEnum.OG_081:
                    return new Sim_OG_081();
                case CardDB.cardIDEnum.OG_123:
                    return new Sim_OG_123();
                case CardDB.cardIDEnum.OG_123e:
                    return new Sim_OG_123e();
                case CardDB.cardIDEnum.OG_335:
                    return new Sim_OG_335();
                case CardDB.cardIDEnum.OG_034:
                    return new Sim_OG_034();
                case CardDB.cardIDEnum.OG_006a:
                    return new Sim_OG_006a();
                case CardDB.cardIDEnum.OG_339:
                    return new Sim_OG_339();
                case CardDB.cardIDEnum.OG_202c:
                    return new Sim_OG_202c();
                case CardDB.cardIDEnum.OG_249a:
                    return new Sim_OG_249a();
                case CardDB.cardIDEnum.OG_314b:
                    return new Sim_OG_314b();
                case CardDB.cardIDEnum.OG_256e:
                    return new Sim_OG_256e();
                case CardDB.cardIDEnum.OG_340:
                    return new Sim_OG_340();
                case CardDB.cardIDEnum.OG_303e:
                    return new Sim_OG_303e();
                case CardDB.cardIDEnum.OG_302e:
                    return new Sim_OG_302e();
                case CardDB.cardIDEnum.OG_267:
                    return new Sim_OG_267();
                case CardDB.cardIDEnum.OG_256:
                    return new Sim_OG_256();
                case CardDB.cardIDEnum.OG_216a:
                    return new Sim_OG_216a();
                case CardDB.cardIDEnum.OG_047e:
                    return new Sim_OG_047e();
                case CardDB.cardIDEnum.OG_116:
                    return new Sim_OG_116();
                case CardDB.cardIDEnum.OG_267e:
                    return new Sim_OG_267e();
                case CardDB.cardIDEnum.OG_327:
                    return new Sim_OG_327();
                case CardDB.cardIDEnum.OG_273:
                    return new Sim_OG_273();
                case CardDB.cardIDEnum.OG_310:
                    return new Sim_OG_310();
                case CardDB.cardIDEnum.OG_206:
                    return new Sim_OG_206();
                case CardDB.cardIDEnum.OG_300e:
                    return new Sim_OG_300e();
                case CardDB.cardIDEnum.OG_151:
                    return new Sim_OG_151();
                case CardDB.cardIDEnum.OG_094e:
                    return new Sim_OG_094e();
                case CardDB.cardIDEnum.OG_033:
                    return new Sim_OG_033();
                case CardDB.cardIDEnum.OG_271e:
                    return new Sim_OG_271e();
                case CardDB.cardIDEnum.OG_173a:
                    return new Sim_OG_173a();
                case CardDB.cardIDEnum.OG_300:
                    return new Sim_OG_300();
                case CardDB.cardIDEnum.OG_006b:
                    return new Sim_OG_006b();
                case CardDB.cardIDEnum.OG_028:
                    return new Sim_OG_028();
                case CardDB.cardIDEnum.OG_070e:
                    return new Sim_OG_070e();
                case CardDB.cardIDEnum.OG_073:
                    return new Sim_OG_073();
                case CardDB.cardIDEnum.OG_096:
                    return new Sim_OG_096();
                case CardDB.cardIDEnum.OG_286:
                    return new Sim_OG_286();
                case CardDB.cardIDEnum.OG_031a:
                    return new Sim_OG_031a();
                case CardDB.cardIDEnum.OG_083:
                    return new Sim_OG_083();
                case CardDB.cardIDEnum.OG_284:
                    return new Sim_OG_284();
                case CardDB.cardIDEnum.OG_272:
                    return new Sim_OG_272();
                case CardDB.cardIDEnum.OG_131:
                    return new Sim_OG_131();
                case CardDB.cardIDEnum.OG_319:
                    return new Sim_OG_319();
                case CardDB.cardIDEnum.OG_247:
                    return new Sim_OG_247();
                case CardDB.cardIDEnum.OG_330:
                    return new Sim_OG_330();
                case CardDB.cardIDEnum.OG_312e:
                    return new Sim_OG_312e();
                case CardDB.cardIDEnum.OG_302:
                    return new Sim_OG_302();
                case CardDB.cardIDEnum.OG_200:
                    return new Sim_OG_200();
                case CardDB.cardIDEnum.OG_339e:
                    return new Sim_OG_339e();
                case CardDB.cardIDEnum.OG_006:
                    return new Sim_OG_006();
                case CardDB.cardIDEnum.OG_138e:
                    return new Sim_OG_138e();
                case CardDB.cardIDEnum.OG_195c:
                    return new Sim_OG_195c();
                case CardDB.cardIDEnum.OG_195:
                    return new Sim_OG_195();
                case CardDB.cardIDEnum.OG_080:
                    return new Sim_OG_080();
                case CardDB.cardIDEnum.OG_134:
                    return new Sim_OG_134();
                case CardDB.cardIDEnum.OG_202b:
                    return new Sim_OG_202b();
                case CardDB.cardIDEnum.OG_042:
                    return new Sim_OG_042();
                case CardDB.cardIDEnum.OG_202a:
                    return new Sim_OG_202a();
                case CardDB.cardIDEnum.OG_202ae:
                    return new Sim_OG_202ae();
                case CardDB.cardIDEnum.OG_158:
                    return new Sim_OG_158();
 ///case CardDB.cardIDEnum.///TAVERNS_OF_TIME:
                    ///return new Sim_///TAVERNS_OF_TIME();
                case CardDB.cardIDEnum.TOT_030t2e:
                    return new Sim_TOT_030t2e();
                case CardDB.cardIDEnum.TOT_030t2:
                    return new Sim_TOT_030t2();
                case CardDB.cardIDEnum.TOT_069:
                    return new Sim_TOT_069();
                case CardDB.cardIDEnum.TOT_330:
                    return new Sim_TOT_330();
                case CardDB.cardIDEnum.TOT_308:
                    return new Sim_TOT_308();
                case CardDB.cardIDEnum.TOT_112e:
                    return new Sim_TOT_112e();
                case CardDB.cardIDEnum.TOT_030:
                    return new Sim_TOT_030();
                case CardDB.cardIDEnum.TOT_111e:
                    return new Sim_TOT_111e();
                case CardDB.cardIDEnum.TOT_340:
                    return new Sim_TOT_340();
                case CardDB.cardIDEnum.TOT_116e:
                    return new Sim_TOT_116e();
                case CardDB.cardIDEnum.TOT_341:
                    return new Sim_TOT_341();
                case CardDB.cardIDEnum.TOT_030t4:
                    return new Sim_TOT_030t4();
                case CardDB.cardIDEnum.TOT_108:
                    return new Sim_TOT_108();
                case CardDB.cardIDEnum.TOT_316:
                    return new Sim_TOT_316();
                case CardDB.cardIDEnum.TOT_030t3:
                    return new Sim_TOT_030t3();
                case CardDB.cardIDEnum.TOT_342:
                    return new Sim_TOT_342();
                case CardDB.cardIDEnum.TOT_105:
                    return new Sim_TOT_105();
                case CardDB.cardIDEnum.TOT_103:
                    return new Sim_TOT_103();
                case CardDB.cardIDEnum.TOT_320:
                    return new Sim_TOT_320();
                case CardDB.cardIDEnum.TOT_067:
                    return new Sim_TOT_067();
                case CardDB.cardIDEnum.TOT_117:
                    return new Sim_TOT_117();
                case CardDB.cardIDEnum.TOT_069ee:
                    return new Sim_TOT_069ee();
                case CardDB.cardIDEnum.TOT_067ee:
                    return new Sim_TOT_067ee();
                case CardDB.cardIDEnum.TOT_067e:
                    return new Sim_TOT_067e();
                case CardDB.cardIDEnum.TOT_313:
                    return new Sim_TOT_313();
                case CardDB.cardIDEnum.TOT_332:
                    return new Sim_TOT_332();
                case CardDB.cardIDEnum.TOT_030t1:
                    return new Sim_TOT_030t1();
                case CardDB.cardIDEnum.TOT_112:
                    return new Sim_TOT_112();
                case CardDB.cardIDEnum.TOT_316e:
                    return new Sim_TOT_316e();
                case CardDB.cardIDEnum.TOT_343:
                    return new Sim_TOT_343();
                case CardDB.cardIDEnum.TOT_117e:
                    return new Sim_TOT_117e();
                case CardDB.cardIDEnum.TOT_102:
                    return new Sim_TOT_102();
                case CardDB.cardIDEnum.TOT_345:
                    return new Sim_TOT_345();
                case CardDB.cardIDEnum.TOT_118e:
                    return new Sim_TOT_118e();
                case CardDB.cardIDEnum.TOT_109:
                    return new Sim_TOT_109();
                case CardDB.cardIDEnum.TOT_109t:
                    return new Sim_TOT_109t();
                case CardDB.cardIDEnum.TOT_118:
                    return new Sim_TOT_118();
                case CardDB.cardIDEnum.TOT_103e:
                    return new Sim_TOT_103e();
                case CardDB.cardIDEnum.TOT_334:
                    return new Sim_TOT_334();
                case CardDB.cardIDEnum.TOT_107:
                    return new Sim_TOT_107();
                case CardDB.cardIDEnum.TOT_345e:
                    return new Sim_TOT_345e();
                case CardDB.cardIDEnum.TOT_345e2:
                    return new Sim_TOT_345e2();
                case CardDB.cardIDEnum.TOT_332e:
                    return new Sim_TOT_332e();
                case CardDB.cardIDEnum.TOT_110:
                    return new Sim_TOT_110();
                case CardDB.cardIDEnum.TOT_111:
                    return new Sim_TOT_111();
                case CardDB.cardIDEnum.TOT_116:
                    return new Sim_TOT_116();
                case CardDB.cardIDEnum.TOT_303t:
                    return new Sim_TOT_303t();
                case CardDB.cardIDEnum.TOT_056:
                    return new Sim_TOT_056();
                case CardDB.cardIDEnum.TOT_069e:
                    return new Sim_TOT_069e();
 ///case CardDB.cardIDEnum.///TROLL:
                    ///return new Sim_///TROLL();
                case CardDB.cardIDEnum.TRLA_Warlock_10:
                    return new Sim_TRLA_Warlock_10();
                case CardDB.cardIDEnum.TRL_305:
                    return new Sim_TRL_305();
                case CardDB.cardIDEnum.TRL_500e:
                    return new Sim_TRL_500e();
                case CardDB.cardIDEnum.TRLA_Rogue_04:
                    return new Sim_TRLA_Rogue_04();
                case CardDB.cardIDEnum.TRL_329:
                    return new Sim_TRL_329();
                case CardDB.cardIDEnum.TRLA_104:
                    return new Sim_TRLA_104();
                case CardDB.cardIDEnum.TRLA_104t:
                    return new Sim_TRLA_104t();
                case CardDB.cardIDEnum.TRLA_171:
                    return new Sim_TRLA_171();
                case CardDB.cardIDEnum.TRLA_171t:
                    return new Sim_TRLA_171t();
                case CardDB.cardIDEnum.TRLA_170:
                    return new Sim_TRLA_170();
                case CardDB.cardIDEnum.TRLA_170t:
                    return new Sim_TRLA_170t();
                case CardDB.cardIDEnum.TRL_550:
                    return new Sim_TRL_550();
                case CardDB.cardIDEnum.TRL_341t:
                    return new Sim_TRL_341t();
                case CardDB.cardIDEnum.TRL_343at1:
                    return new Sim_TRL_343at1();
                case CardDB.cardIDEnum.TRL_311:
                    return new Sim_TRL_311();
                case CardDB.cardIDEnum.TRL_517:
                    return new Sim_TRL_517();
                case CardDB.cardIDEnum.TRL_521:
                    return new Sim_TRL_521();
                case CardDB.cardIDEnum.TRL_525:
                    return new Sim_TRL_525();
                case CardDB.cardIDEnum.TRLA_Priest_08:
                    return new Sim_TRLA_Priest_08();
                case CardDB.cardIDEnum.TRLA_127:
                    return new Sim_TRLA_127();
                case CardDB.cardIDEnum.TRLA_153e:
                    return new Sim_TRLA_153e();
                case CardDB.cardIDEnum.TRL_501:
                    return new Sim_TRL_501();
                case CardDB.cardIDEnum.TRL_505e:
                    return new Sim_TRL_505e();
                case CardDB.cardIDEnum.TRL_347:
                    return new Sim_TRL_347();
                case CardDB.cardIDEnum.TRL_509:
                    return new Sim_TRL_509();
                case CardDB.cardIDEnum.TRL_509t:
                    return new Sim_TRL_509t();
                case CardDB.cardIDEnum.TRL_509te:
                    return new Sim_TRL_509te();
                case CardDB.cardIDEnum.TRL_020t:
                    return new Sim_TRL_020t();
                case CardDB.cardIDEnum.TRL_304e:
                    return new Sim_TRL_304e();
                case CardDB.cardIDEnum.TRLA_Shaman_05:
                    return new Sim_TRLA_Shaman_05();
                case CardDB.cardIDEnum.TRLA_Rogue_03:
                    return new Sim_TRLA_Rogue_03();
                case CardDB.cardIDEnum.TRLA_165:
                    return new Sim_TRLA_165();
                case CardDB.cardIDEnum.TRLA_Hunter_04:
                    return new Sim_TRLA_Hunter_04();
                case CardDB.cardIDEnum.TRLA_Hunter_06:
                    return new Sim_TRLA_Hunter_06();
                case CardDB.cardIDEnum.TRLA_Druid_07:
                    return new Sim_TRLA_Druid_07();
                case CardDB.cardIDEnum.TRL_514e:
                    return new Sim_TRL_514e();
                case CardDB.cardIDEnum.TRL_514:
                    return new Sim_TRL_514();
                case CardDB.cardIDEnum.TRLA_Warrior_02:
                    return new Sim_TRLA_Warrior_02();
                case CardDB.cardIDEnum.TRL_065h:
                    return new Sim_TRL_065h();
                case CardDB.cardIDEnum.TRL_082:
                    return new Sim_TRL_082();
                case CardDB.cardIDEnum.TRLA_Hunter_02:
                    return new Sim_TRLA_Hunter_02();
                case CardDB.cardIDEnum.TRLA_Druid_05:
                    return new Sim_TRLA_Druid_05();
                case CardDB.cardIDEnum.TRLA_Mage_03:
                    return new Sim_TRLA_Mage_03();
                case CardDB.cardIDEnum.TRL_317:
                    return new Sim_TRL_317();
                case CardDB.cardIDEnum.TRLA_140:
                    return new Sim_TRLA_140();
                case CardDB.cardIDEnum.TRL_901e:
                    return new Sim_TRL_901e();
                case CardDB.cardIDEnum.TRLA_Shaman_03:
                    return new Sim_TRLA_Shaman_03();
                case CardDB.cardIDEnum.TRLA_Warlock_08:
                    return new Sim_TRLA_Warlock_08();
                case CardDB.cardIDEnum.TRL_409e:
                    return new Sim_TRL_409e();
                case CardDB.cardIDEnum.TRLA_113:
                    return new Sim_TRLA_113();
                case CardDB.cardIDEnum.TRLA_113t:
                    return new Sim_TRLA_113t();
                case CardDB.cardIDEnum.TRLA_113e:
                    return new Sim_TRLA_113e();
                case CardDB.cardIDEnum.TRLA_185:
                    return new Sim_TRLA_185();
                case CardDB.cardIDEnum.TRL_257:
                    return new Sim_TRL_257();
                case CardDB.cardIDEnum.TRL_543:
                    return new Sim_TRL_543();
                case CardDB.cardIDEnum.TRL_071:
                    return new Sim_TRL_071();
                case CardDB.cardIDEnum.TRL_349:
                    return new Sim_TRL_349();
                case CardDB.cardIDEnum.TRLA_150:
                    return new Sim_TRLA_150();
                case CardDB.cardIDEnum.TRL_071e:
                    return new Sim_TRL_071e();
                case CardDB.cardIDEnum.TRL_059:
                    return new Sim_TRL_059();
                case CardDB.cardIDEnum.TRLA_116:
                    return new Sim_TRLA_116();
                case CardDB.cardIDEnum.TRLA_116t:
                    return new Sim_TRLA_116t();
                case CardDB.cardIDEnum.TRLA_807:
                    return new Sim_TRLA_807();
                case CardDB.cardIDEnum.TRLA_807e2:
                    return new Sim_TRLA_807e2();
                case CardDB.cardIDEnum.TRLA_807e:
                    return new Sim_TRLA_807e();
                case CardDB.cardIDEnum.TRL_504:
                    return new Sim_TRL_504();
                case CardDB.cardIDEnum.TRLA_106:
                    return new Sim_TRLA_106();
                case CardDB.cardIDEnum.TRLA_106e:
                    return new Sim_TRLA_106e();
                case CardDB.cardIDEnum.TRLA_106t:
                    return new Sim_TRLA_106t();
                case CardDB.cardIDEnum.TRLA_Rogue_09:
                    return new Sim_TRLA_Rogue_09();
                case CardDB.cardIDEnum.TRLA_Rogue_01:
                    return new Sim_TRLA_Rogue_01();
                case CardDB.cardIDEnum.TRL_260:
                    return new Sim_TRL_260();
                case CardDB.cardIDEnum.TRLA_147:
                    return new Sim_TRLA_147();
                case CardDB.cardIDEnum.TRLA_147e:
                    return new Sim_TRLA_147e();
                case CardDB.cardIDEnum.TRLA_147t:
                    return new Sim_TRLA_147t();
                case CardDB.cardIDEnum.TRLA_151:
                    return new Sim_TRLA_151();
                case CardDB.cardIDEnum.TRLA_114:
                    return new Sim_TRLA_114();
                case CardDB.cardIDEnum.TRLA_114t:
                    return new Sim_TRLA_114t();
                case CardDB.cardIDEnum.TRLA_114e:
                    return new Sim_TRLA_114e();
                case CardDB.cardIDEnum.TRLA_146:
                    return new Sim_TRLA_146();
                case CardDB.cardIDEnum.TRLA_146t:
                    return new Sim_TRLA_146t();
                case CardDB.cardIDEnum.TRL_127:
                    return new Sim_TRL_127();
                case CardDB.cardIDEnum.TRL_126:
                    return new Sim_TRL_126();
                case CardDB.cardIDEnum.TRLA_202h:
                    return new Sim_TRLA_202h();
                case CardDB.cardIDEnum.TRL_074e:
                    return new Sim_TRL_074e();
                case CardDB.cardIDEnum.TRLA_Mage_10:
                    return new Sim_TRLA_Mage_10();
                case CardDB.cardIDEnum.TRL_512:
                    return new Sim_TRL_512();
                case CardDB.cardIDEnum.TRLA_153:
                    return new Sim_TRLA_153();
                case CardDB.cardIDEnum.TRL_541t:
                    return new Sim_TRL_541t();
                case CardDB.cardIDEnum.TRL_528e:
                    return new Sim_TRL_528e();
                case CardDB.cardIDEnum.TRLA_159:
                    return new Sim_TRLA_159();
                case CardDB.cardIDEnum.TRL_569:
                    return new Sim_TRL_569();
                case CardDB.cardIDEnum.TRL_537:
                    return new Sim_TRL_537();
                case CardDB.cardIDEnum.TRL_390:
                    return new Sim_TRL_390();
                case CardDB.cardIDEnum.TRLA_184:
                    return new Sim_TRLA_184();
                case CardDB.cardIDEnum.TRLA_178:
                    return new Sim_TRLA_178();
                case CardDB.cardIDEnum.TRLA_178t:
                    return new Sim_TRLA_178t();
                case CardDB.cardIDEnum.TRL_501e:
                    return new Sim_TRL_501e();
                case CardDB.cardIDEnum.TRLA_Hunter_09:
                    return new Sim_TRLA_Hunter_09();
                case CardDB.cardIDEnum.TRLA_Rogue_07:
                    return new Sim_TRLA_Rogue_07();
                case CardDB.cardIDEnum.TRLA_156:
                    return new Sim_TRLA_156();
                case CardDB.cardIDEnum.TRL_555:
                    return new Sim_TRL_555();
                case CardDB.cardIDEnum.TRL_321:
                    return new Sim_TRL_321();
                case CardDB.cardIDEnum.TRL_347t:
                    return new Sim_TRL_347t();
                case CardDB.cardIDEnum.TRLA_Warlock_09:
                    return new Sim_TRLA_Warlock_09();
                case CardDB.cardIDEnum.TRLA_122:
                    return new Sim_TRLA_122();
                case CardDB.cardIDEnum.TRLA_Warlock_02:
                    return new Sim_TRLA_Warlock_02();
                case CardDB.cardIDEnum.TRLA_Paladin_10:
                    return new Sim_TRLA_Paladin_10();
                case CardDB.cardIDEnum.TRLA_Priest_04:
                    return new Sim_TRLA_Priest_04();
                case CardDB.cardIDEnum.TRL_406:
                    return new Sim_TRL_406();
                case CardDB.cardIDEnum.TRLA_Warrior_09:
                    return new Sim_TRLA_Warrior_09();
                case CardDB.cardIDEnum.TRL_362:
                    return new Sim_TRL_362();
                case CardDB.cardIDEnum.TRL_526:
                    return new Sim_TRL_526();
                case CardDB.cardIDEnum.TRLA_Paladin_09:
                    return new Sim_TRLA_Paladin_09();
                case CardDB.cardIDEnum.TRL_527:
                    return new Sim_TRL_527();
                case CardDB.cardIDEnum.TRLA_Priest_01:
                    return new Sim_TRLA_Priest_01();
                case CardDB.cardIDEnum.TRL_310:
                    return new Sim_TRL_310();
                case CardDB.cardIDEnum.TRL_310e:
                    return new Sim_TRL_310e();
                case CardDB.cardIDEnum.TRLA_Shaman_01:
                    return new Sim_TRLA_Shaman_01();
                case CardDB.cardIDEnum.TRLA_Mage_02:
                    return new Sim_TRLA_Mage_02();
                case CardDB.cardIDEnum.TRLA_Priest_05:
                    return new Sim_TRLA_Priest_05();
                case CardDB.cardIDEnum.TRLA_Shaman_06:
                    return new Sim_TRLA_Shaman_06();
                case CardDB.cardIDEnum.TRL_323:
                    return new Sim_TRL_323();
                case CardDB.cardIDEnum.TRLA_124e:
                    return new Sim_TRLA_124e();
                case CardDB.cardIDEnum.TRLA_131e:
                    return new Sim_TRLA_131e();
                case CardDB.cardIDEnum.TRLA_804:
                    return new Sim_TRLA_804();
                case CardDB.cardIDEnum.TRLA_144:
                    return new Sim_TRLA_144();
                case CardDB.cardIDEnum.TRLA_135:
                    return new Sim_TRLA_135();
                case CardDB.cardIDEnum.TRL_304:
                    return new Sim_TRL_304();
                case CardDB.cardIDEnum.TRLA_Shaman_12:
                    return new Sim_TRLA_Shaman_12();
                case CardDB.cardIDEnum.TRLA_802:
                    return new Sim_TRLA_802();
                case CardDB.cardIDEnum.TRLA_802e2:
                    return new Sim_TRLA_802e2();
                case CardDB.cardIDEnum.TRLA_802e:
                    return new Sim_TRLA_802e();
                case CardDB.cardIDEnum.TRLA_Druid_02:
                    return new Sim_TRLA_Druid_02();
                case CardDB.cardIDEnum.TRLA_Warrior_07:
                    return new Sim_TRLA_Warrior_07();
                case CardDB.cardIDEnum.TRLA_Mage_04:
                    return new Sim_TRLA_Mage_04();
                case CardDB.cardIDEnum.TRLA_133:
                    return new Sim_TRLA_133();
                case CardDB.cardIDEnum.TRL_523:
                    return new Sim_TRL_523();
                case CardDB.cardIDEnum.TRLA_176e:
                    return new Sim_TRLA_176e();
                case CardDB.cardIDEnum.TRL_390e:
                    return new Sim_TRL_390e();
                case CardDB.cardIDEnum.TRL_390e2:
                    return new Sim_TRL_390e2();
                case CardDB.cardIDEnum.TRL_307:
                    return new Sim_TRL_307();
                case CardDB.cardIDEnum.TRLA_Rogue_08:
                    return new Sim_TRLA_Rogue_08();
                case CardDB.cardIDEnum.TRL_151:
                    return new Sim_TRL_151();
                case CardDB.cardIDEnum.TRLA_803e:
                    return new Sim_TRLA_803e();
                case CardDB.cardIDEnum.TRLA_803:
                    return new Sim_TRLA_803();
                case CardDB.cardIDEnum.TRLA_803e2:
                    return new Sim_TRLA_803e2();
                case CardDB.cardIDEnum.TRL_363t:
                    return new Sim_TRL_363t();
                case CardDB.cardIDEnum.TRLA_Hunter_01:
                    return new Sim_TRLA_Hunter_01();
                case CardDB.cardIDEnum.TRLA_Mage_05:
                    return new Sim_TRLA_Mage_05();
                case CardDB.cardIDEnum.TRLA_129s:
                    return new Sim_TRLA_129s();
                case CardDB.cardIDEnum.TRLA_132:
                    return new Sim_TRLA_132();
                case CardDB.cardIDEnum.TRLA_171e:
                    return new Sim_TRLA_171e();
                case CardDB.cardIDEnum.TRLA_149:
                    return new Sim_TRLA_149();
                case CardDB.cardIDEnum.TRLA_143:
                    return new Sim_TRLA_143();
                case CardDB.cardIDEnum.TRLA_131:
                    return new Sim_TRLA_131();
                case CardDB.cardIDEnum.TRLA_Druid_14:
                    return new Sim_TRLA_Druid_14();
                case CardDB.cardIDEnum.TRL_241:
                    return new Sim_TRL_241();
                case CardDB.cardIDEnum.TRLA_112:
                    return new Sim_TRLA_112();
                case CardDB.cardIDEnum.TRLA_112t:
                    return new Sim_TRLA_112t();
                case CardDB.cardIDEnum.TRLA_116e:
                    return new Sim_TRLA_116e();
                case CardDB.cardIDEnum.TRLA_115:
                    return new Sim_TRLA_115();
                case CardDB.cardIDEnum.TRLA_115e:
                    return new Sim_TRLA_115e();
                case CardDB.cardIDEnum.TRLA_115t:
                    return new Sim_TRLA_115t();
                case CardDB.cardIDEnum.TRL_254a:
                    return new Sim_TRL_254a();
                case CardDB.cardIDEnum.TRL_409:
                    return new Sim_TRL_409();
                case CardDB.cardIDEnum.TRL_408:
                    return new Sim_TRL_408();
                case CardDB.cardIDEnum.TRL_096:
                    return new Sim_TRL_096();
                case CardDB.cardIDEnum.TRL_249:
                    return new Sim_TRL_249();
                case CardDB.cardIDEnum.TRL_249e:
                    return new Sim_TRL_249e();
                case CardDB.cardIDEnum.TRL_096e:
                    return new Sim_TRL_096e();
                case CardDB.cardIDEnum.TRL_506:
                    return new Sim_TRL_506();
                case CardDB.cardIDEnum.TRL_077:
                    return new Sim_TRL_077();
                case CardDB.cardIDEnum.TRLA_Mage_09:
                    return new Sim_TRLA_Mage_09();
                case CardDB.cardIDEnum.TRL_516:
                    return new Sim_TRL_516();
                case CardDB.cardIDEnum.TRL_541:
                    return new Sim_TRL_541();
                case CardDB.cardIDEnum.TRL_900:
                    return new Sim_TRL_900();
                case CardDB.cardIDEnum.TRLA_163:
                    return new Sim_TRLA_163();
                case CardDB.cardIDEnum.TRLA_163t:
                    return new Sim_TRLA_163t();
                case CardDB.cardIDEnum.TRLA_163e:
                    return new Sim_TRLA_163e();
                case CardDB.cardIDEnum.TRLA_162:
                    return new Sim_TRLA_162();
                case CardDB.cardIDEnum.TRLA_162e:
                    return new Sim_TRLA_162e();
                case CardDB.cardIDEnum.TRLA_162t:
                    return new Sim_TRLA_162t();
                case CardDB.cardIDEnum.TRLA_162e2:
                    return new Sim_TRLA_162e2();
                case CardDB.cardIDEnum.TRLA_163e3:
                    return new Sim_TRLA_163e3();
                case CardDB.cardIDEnum.TRLA_110:
                    return new Sim_TRLA_110();
                case CardDB.cardIDEnum.TRLA_110t:
                    return new Sim_TRLA_110t();
                case CardDB.cardIDEnum.TRLA_163e4:
                    return new Sim_TRLA_163e4();
                case CardDB.cardIDEnum.TRL_010:
                    return new Sim_TRL_010();
                case CardDB.cardIDEnum.TRLA_Mage_08:
                    return new Sim_TRLA_Mage_08();
                case CardDB.cardIDEnum.TRL_058:
                    return new Sim_TRL_058();
                case CardDB.cardIDEnum.TRL_111:
                    return new Sim_TRL_111();
                case CardDB.cardIDEnum.TRL_111e1:
                    return new Sim_TRL_111e1();
                case CardDB.cardIDEnum.TRLA_Paladin_02:
                    return new Sim_TRLA_Paladin_02();
                case CardDB.cardIDEnum.TRLA_Priest_02:
                    return new Sim_TRLA_Priest_02();
                case CardDB.cardIDEnum.TRL_324:
                    return new Sim_TRL_324();
                case CardDB.cardIDEnum.TRL_505:
                    return new Sim_TRL_505();
                case CardDB.cardIDEnum.TRLA_176:
                    return new Sim_TRLA_176();
                case CardDB.cardIDEnum.TRLA_Mage_01:
                    return new Sim_TRLA_Mage_01();
                case CardDB.cardIDEnum.TRL_318:
                    return new Sim_TRL_318();
                case CardDB.cardIDEnum.TRLA_207h:
                    return new Sim_TRLA_207h();
                case CardDB.cardIDEnum.TRL_308:
                    return new Sim_TRL_308();
                case CardDB.cardIDEnum.TRLA_203h:
                    return new Sim_TRLA_203h();
                case CardDB.cardIDEnum.TRL_252:
                    return new Sim_TRL_252();
                case CardDB.cardIDEnum.TRLA_206h:
                    return new Sim_TRLA_206h();
                case CardDB.cardIDEnum.TRL_407e:
                    return new Sim_TRL_407e();
                case CardDB.cardIDEnum.TRL_253:
                    return new Sim_TRL_253();
                case CardDB.cardIDEnum.TRLA_179:
                    return new Sim_TRLA_179();
                case CardDB.cardIDEnum.TRLA_179t:
                    return new Sim_TRLA_179t();
                case CardDB.cardIDEnum.TRLA_Warlock_01:
                    return new Sim_TRLA_Warlock_01();
                case CardDB.cardIDEnum.TRL_251e:
                    return new Sim_TRL_251e();
                case CardDB.cardIDEnum.TRLA_Paladin_07:
                    return new Sim_TRLA_Paladin_07();
                case CardDB.cardIDEnum.TRL_151t:
                    return new Sim_TRL_151t();
                case CardDB.cardIDEnum.TRL_077e:
                    return new Sim_TRL_077e();
                case CardDB.cardIDEnum.TRL_533:
                    return new Sim_TRL_533();
                case CardDB.cardIDEnum.TRL_306:
                    return new Sim_TRL_306();
                case CardDB.cardIDEnum.TRLA_Priest_06:
                    return new Sim_TRLA_Priest_06();
                case CardDB.cardIDEnum.TRLA_Priest_03:
                    return new Sim_TRLA_Priest_03();
                case CardDB.cardIDEnum.TRL_232:
                    return new Sim_TRL_232();
                case CardDB.cardIDEnum.TRL_232t:
                    return new Sim_TRL_232t();
                case CardDB.cardIDEnum.TRLA_174:
                    return new Sim_TRLA_174();
                case CardDB.cardIDEnum.TRLA_Shaman_11:
                    return new Sim_TRLA_Shaman_11();
                case CardDB.cardIDEnum.TRL_316:
                    return new Sim_TRL_316();
                case CardDB.cardIDEnum.TRLA_128:
                    return new Sim_TRLA_128();
                case CardDB.cardIDEnum.TRLA_128t:
                    return new Sim_TRLA_128t();
                case CardDB.cardIDEnum.TRLA_128e:
                    return new Sim_TRLA_128e();
                case CardDB.cardIDEnum.TRLA_108:
                    return new Sim_TRLA_108();
                case CardDB.cardIDEnum.TRLA_108t:
                    return new Sim_TRLA_108t();
                case CardDB.cardIDEnum.TRLA_129:
                    return new Sim_TRLA_129();
                case CardDB.cardIDEnum.TRLA_129t:
                    return new Sim_TRLA_129t();
                case CardDB.cardIDEnum.TRLA_Warlock_11:
                    return new Sim_TRLA_Warlock_11();
                case CardDB.cardIDEnum.TRL_345:
                    return new Sim_TRL_345();
                case CardDB.cardIDEnum.TRLA_155:
                    return new Sim_TRLA_155();
                case CardDB.cardIDEnum.TRLA_155t:
                    return new Sim_TRLA_155t();
                case CardDB.cardIDEnum.TRLA_109:
                    return new Sim_TRLA_109();
                case CardDB.cardIDEnum.TRLA_109t:
                    return new Sim_TRLA_109t();
                case CardDB.cardIDEnum.TRLA_157:
                    return new Sim_TRLA_157();
                case CardDB.cardIDEnum.TRLA_180e:
                    return new Sim_TRLA_180e();
                case CardDB.cardIDEnum.TRLA_180:
                    return new Sim_TRLA_180();
                case CardDB.cardIDEnum.TRLA_Hunter_10:
                    return new Sim_TRLA_Hunter_10();
                case CardDB.cardIDEnum.TRLA_Warrior_03:
                    return new Sim_TRLA_Warrior_03();
                case CardDB.cardIDEnum.TRLA_Priest_10:
                    return new Sim_TRLA_Priest_10();
                case CardDB.cardIDEnum.TRLA_Warlock_03:
                    return new Sim_TRLA_Warlock_03();
                case CardDB.cardIDEnum.TRLA_141:
                    return new Sim_TRLA_141();
                case CardDB.cardIDEnum.TRL_352:
                    return new Sim_TRL_352();
                case CardDB.cardIDEnum.TRL_528:
                    return new Sim_TRL_528();
                case CardDB.cardIDEnum.TRLA_192:
                    return new Sim_TRLA_192();
                case CardDB.cardIDEnum.TRL_348t:
                    return new Sim_TRL_348t();
                case CardDB.cardIDEnum.TRLA_Mage_06:
                    return new Sim_TRLA_Mage_06();
                case CardDB.cardIDEnum.TRLA_Paladin_01:
                    return new Sim_TRLA_Paladin_01();
                case CardDB.cardIDEnum.TRL_254:
                    return new Sim_TRL_254();
                case CardDB.cardIDEnum.TRL_254ae:
                    return new Sim_TRL_254ae();
                case CardDB.cardIDEnum.TRL_530:
                    return new Sim_TRL_530();
                case CardDB.cardIDEnum.TRL_258:
                    return new Sim_TRL_258();
                case CardDB.cardIDEnum.TRL_339:
                    return new Sim_TRL_339();
                case CardDB.cardIDEnum.TRLA_Shaman_13:
                    return new Sim_TRLA_Shaman_13();
                case CardDB.cardIDEnum.TRLA_Warrior_05:
                    return new Sim_TRLA_Warrior_05();
                case CardDB.cardIDEnum.TRLA_Rogue_10:
                    return new Sim_TRLA_Rogue_10();
                case CardDB.cardIDEnum.TRL_564:
                    return new Sim_TRL_564();
                case CardDB.cardIDEnum.TRL_532:
                    return new Sim_TRL_532();
                case CardDB.cardIDEnum.TRL_513:
                    return new Sim_TRL_513();
                case CardDB.cardIDEnum.TRL_520:
                    return new Sim_TRL_520();
                case CardDB.cardIDEnum.TRLA_Shaman_07:
                    return new Sim_TRLA_Shaman_07();
                case CardDB.cardIDEnum.TRLA_Shaman_04:
                    return new Sim_TRLA_Shaman_04();
                case CardDB.cardIDEnum.TRLA_160:
                    return new Sim_TRLA_160();
                case CardDB.cardIDEnum.TRLA_Druid_01:
                    return new Sim_TRLA_Druid_01();
                case CardDB.cardIDEnum.TRLA_Druid_03:
                    return new Sim_TRLA_Druid_03();
                case CardDB.cardIDEnum.TRLA_Druid_10:
                    return new Sim_TRLA_Druid_10();
                case CardDB.cardIDEnum.TRL_542:
                    return new Sim_TRL_542();
                case CardDB.cardIDEnum.TRL_546:
                    return new Sim_TRL_546();
                case CardDB.cardIDEnum.TRLA_109e:
                    return new Sim_TRLA_109e();
                case CardDB.cardIDEnum.TRLA_158:
                    return new Sim_TRLA_158();
                case CardDB.cardIDEnum.TRLA_Warrior_10:
                    return new Sim_TRLA_Warrior_10();
                case CardDB.cardIDEnum.TRLA_Shaman_08:
                    return new Sim_TRLA_Shaman_08();
                case CardDB.cardIDEnum.TRL_360:
                    return new Sim_TRL_360();
                case CardDB.cardIDEnum.TRLA_805:
                    return new Sim_TRLA_805();
                case CardDB.cardIDEnum.TRLA_805e:
                    return new Sim_TRLA_805e();
                case CardDB.cardIDEnum.TRLA_164e:
                    return new Sim_TRLA_164e();
                case CardDB.cardIDEnum.TRLA_139:
                    return new Sim_TRLA_139();
                case CardDB.cardIDEnum.TRLA_189:
                    return new Sim_TRLA_189();
                case CardDB.cardIDEnum.TRLA_188:
                    return new Sim_TRLA_188();
                case CardDB.cardIDEnum.TRLA_Rogue_02:
                    return new Sim_TRLA_Rogue_02();
                case CardDB.cardIDEnum.TRLA_187:
                    return new Sim_TRLA_187();
                case CardDB.cardIDEnum.TRLA_187t:
                    return new Sim_TRLA_187t();
                case CardDB.cardIDEnum.TRL_243:
                    return new Sim_TRL_243();
                case CardDB.cardIDEnum.TRL_243e:
                    return new Sim_TRL_243e();
                case CardDB.cardIDEnum.TRL_312e:
                    return new Sim_TRL_312e();
                case CardDB.cardIDEnum.TRL_319e:
                    return new Sim_TRL_319e();
                case CardDB.cardIDEnum.TRL_092e:
                    return new Sim_TRL_092e();
                case CardDB.cardIDEnum.TRL_502e:
                    return new Sim_TRL_502e();
                case CardDB.cardIDEnum.TRL_244:
                    return new Sim_TRL_244();
                case CardDB.cardIDEnum.TRL_244e:
                    return new Sim_TRL_244e();
                case CardDB.cardIDEnum.TRL_259:
                    return new Sim_TRL_259();
                case CardDB.cardIDEnum.TRLA_208h:
                    return new Sim_TRLA_208h();
                case CardDB.cardIDEnum.TRL_327e:
                    return new Sim_TRL_327e();
                case CardDB.cardIDEnum.TRLA_Warrior_08:
                    return new Sim_TRLA_Warrior_08();
                case CardDB.cardIDEnum.TRL_343ct1:
                    return new Sim_TRL_343ct1();
                case CardDB.cardIDEnum.TRL_315:
                    return new Sim_TRL_315();
                case CardDB.cardIDEnum.TRLA_172e:
                    return new Sim_TRLA_172e();
                case CardDB.cardIDEnum.TRL_515:
                    return new Sim_TRL_515();
                case CardDB.cardIDEnum.TRLA_167:
                    return new Sim_TRLA_167();
                case CardDB.cardIDEnum.TRLA_193:
                    return new Sim_TRLA_193();
                case CardDB.cardIDEnum.TRL_316t:
                    return new Sim_TRL_316t();
                case CardDB.cardIDEnum.TRL_124:
                    return new Sim_TRL_124();
                case CardDB.cardIDEnum.TRL_351:
                    return new Sim_TRL_351();
                case CardDB.cardIDEnum.TRLA_172:
                    return new Sim_TRLA_172();
                case CardDB.cardIDEnum.TRL_254t:
                    return new Sim_TRL_254t();
                case CardDB.cardIDEnum.TRL_254b:
                    return new Sim_TRL_254b();
                case CardDB.cardIDEnum.TRL_343dt1:
                    return new Sim_TRL_343dt1();
                case CardDB.cardIDEnum.TRLA_181:
                    return new Sim_TRLA_181();
                case CardDB.cardIDEnum.TRLA_130:
                    return new Sim_TRLA_130();
                case CardDB.cardIDEnum.TRL_506e:
                    return new Sim_TRL_506e();
                case CardDB.cardIDEnum.TRL_551:
                    return new Sim_TRL_551();
                case CardDB.cardIDEnum.TRLA_Paladin_03:
                    return new Sim_TRLA_Paladin_03();
                case CardDB.cardIDEnum.TRLA_173:
                    return new Sim_TRLA_173();
                case CardDB.cardIDEnum.TRL_128:
                    return new Sim_TRL_128();
                case CardDB.cardIDEnum.TRL_508:
                    return new Sim_TRL_508();
                case CardDB.cardIDEnum.TRLA_Paladin_06:
                    return new Sim_TRLA_Paladin_06();
                case CardDB.cardIDEnum.TRL_545e:
                    return new Sim_TRL_545e();
                case CardDB.cardIDEnum.TRLA_148e:
                    return new Sim_TRLA_148e();
                case CardDB.cardIDEnum.TRLA_Priest_07:
                    return new Sim_TRLA_Priest_07();
                case CardDB.cardIDEnum.TRL_566:
                    return new Sim_TRL_566();
                case CardDB.cardIDEnum.TRL_329e:
                    return new Sim_TRL_329e();
                case CardDB.cardIDEnum.TRLA_209h:
                    return new Sim_TRLA_209h();
                case CardDB.cardIDEnum.TRLA_209h_Druid:
                    return new Sim_TRLA_209h_Druid();
                case CardDB.cardIDEnum.TRLA_209h_Hunter:
                    return new Sim_TRLA_209h_Hunter();
                case CardDB.cardIDEnum.TRLA_209h_Mage:
                    return new Sim_TRLA_209h_Mage();
                case CardDB.cardIDEnum.TRLA_209h_Paladin:
                    return new Sim_TRLA_209h_Paladin();
                case CardDB.cardIDEnum.TRLA_209h_Priest:
                    return new Sim_TRLA_209h_Priest();
                case CardDB.cardIDEnum.TRLA_209h_Rogue:
                    return new Sim_TRLA_209h_Rogue();
                case CardDB.cardIDEnum.TRLA_209h_Shaman:
                    return new Sim_TRLA_209h_Shaman();
                case CardDB.cardIDEnum.TRLA_209h_Warlock:
                    return new Sim_TRLA_209h_Warlock();
                case CardDB.cardIDEnum.TRLA_209h_Warrior:
                    return new Sim_TRLA_209h_Warrior();
                case CardDB.cardIDEnum.TRLA_808:
                    return new Sim_TRLA_808();
                case CardDB.cardIDEnum.TRLA_808e2:
                    return new Sim_TRLA_808e2();
                case CardDB.cardIDEnum.TRLA_808e:
                    return new Sim_TRLA_808e();
                case CardDB.cardIDEnum.TRLA_174e:
                    return new Sim_TRLA_174e();
                case CardDB.cardIDEnum.TRLA_Druid_13:
                    return new Sim_TRLA_Druid_13();
                case CardDB.cardIDEnum.TRL_531t:
                    return new Sim_TRL_531t();
                case CardDB.cardIDEnum.TRL_531:
                    return new Sim_TRL_531();
                case CardDB.cardIDEnum.TRLA_Warrior_06:
                    return new Sim_TRLA_Warrior_06();
                case CardDB.cardIDEnum.TRL_343bt1:
                    return new Sim_TRL_343bt1();
                case CardDB.cardIDEnum.TRLA_801e:
                    return new Sim_TRLA_801e();
                case CardDB.cardIDEnum.TRLA_801:
                    return new Sim_TRLA_801();
                case CardDB.cardIDEnum.TRLA_801e2:
                    return new Sim_TRLA_801e2();
                case CardDB.cardIDEnum.TRLA_Warlock_07:
                    return new Sim_TRLA_Warlock_07();
                case CardDB.cardIDEnum.TRLA_190:
                    return new Sim_TRLA_190();
                case CardDB.cardIDEnum.TRL_131:
                    return new Sim_TRL_131();
                case CardDB.cardIDEnum.TRLA_Druid_04:
                    return new Sim_TRLA_Druid_04();
                case CardDB.cardIDEnum.TRL_363:
                    return new Sim_TRL_363();
                case CardDB.cardIDEnum.TRL_240:
                    return new Sim_TRL_240();
                case CardDB.cardIDEnum.TRL_503t:
                    return new Sim_TRL_503t();
                case CardDB.cardIDEnum.TRL_503:
                    return new Sim_TRL_503();
                case CardDB.cardIDEnum.TRL_313:
                    return new Sim_TRL_313();
                case CardDB.cardIDEnum.TRLA_Hunter_12:
                    return new Sim_TRLA_Hunter_12();
                case CardDB.cardIDEnum.TRL_097:
                    return new Sim_TRL_097();
                case CardDB.cardIDEnum.TRLA_175:
                    return new Sim_TRLA_175();
                case CardDB.cardIDEnum.TRLA_Hunter_05:
                    return new Sim_TRLA_Hunter_05();
                case CardDB.cardIDEnum.TRLA_Paladin_08:
                    return new Sim_TRLA_Paladin_08();
                case CardDB.cardIDEnum.TRLA_Paladin_04:
                    return new Sim_TRLA_Paladin_04();
                case CardDB.cardIDEnum.TRL_057:
                    return new Sim_TRL_057();
                case CardDB.cardIDEnum.TRL_074:
                    return new Sim_TRL_074();
                case CardDB.cardIDEnum.TRLA_164:
                    return new Sim_TRLA_164();
                case CardDB.cardIDEnum.TRL_507:
                    return new Sim_TRL_507();
                case CardDB.cardIDEnum.TRLA_191:
                    return new Sim_TRLA_191();
                case CardDB.cardIDEnum.TRL_524:
                    return new Sim_TRL_524();
                case CardDB.cardIDEnum.TRL_300:
                    return new Sim_TRL_300();
                case CardDB.cardIDEnum.TRLA_138:
                    return new Sim_TRLA_138();
                case CardDB.cardIDEnum.TRLA_138t:
                    return new Sim_TRLA_138t();
                case CardDB.cardIDEnum.TRLA_105:
                    return new Sim_TRLA_105();
                case CardDB.cardIDEnum.TRLA_105t:
                    return new Sim_TRLA_105t();
                case CardDB.cardIDEnum.TRLA_137:
                    return new Sim_TRLA_137();
                case CardDB.cardIDEnum.TRLA_137t:
                    return new Sim_TRLA_137t();
                case CardDB.cardIDEnum.TRLA_134:
                    return new Sim_TRLA_134();
                case CardDB.cardIDEnum.TRL_245:
                    return new Sim_TRL_245();
                case CardDB.cardIDEnum.TRL_020:
                    return new Sim_TRL_020();
                case CardDB.cardIDEnum.TRLA_169:
                    return new Sim_TRLA_169();
                case CardDB.cardIDEnum.TRLA_169e:
                    return new Sim_TRLA_169e();
                case CardDB.cardIDEnum.TRL_059e:
                    return new Sim_TRL_059e();
                case CardDB.cardIDEnum.TRLA_Warrior_04:
                    return new Sim_TRLA_Warrior_04();
                case CardDB.cardIDEnum.TRL_326:
                    return new Sim_TRL_326();
                case CardDB.cardIDEnum.TRL_535:
                    return new Sim_TRL_535();
                case CardDB.cardIDEnum.TRLA_152:
                    return new Sim_TRLA_152();
                case CardDB.cardIDEnum.TRL_247:
                    return new Sim_TRL_247();
                case CardDB.cardIDEnum.TRL_570:
                    return new Sim_TRL_570();
                case CardDB.cardIDEnum.TRLA_Mage_07:
                    return new Sim_TRLA_Mage_07();
                case CardDB.cardIDEnum.TRLA_Shaman_02:
                    return new Sim_TRLA_Shaman_02();
                case CardDB.cardIDEnum.TRL_312:
                    return new Sim_TRL_312();
                case CardDB.cardIDEnum.TRL_251:
                    return new Sim_TRL_251();
                case CardDB.cardIDEnum.TRL_502:
                    return new Sim_TRL_502();
                case CardDB.cardIDEnum.TRL_319:
                    return new Sim_TRL_319();
                case CardDB.cardIDEnum.TRL_060:
                    return new Sim_TRL_060();
                case CardDB.cardIDEnum.TRL_901:
                    return new Sim_TRL_901();
                case CardDB.cardIDEnum.TRL_223:
                    return new Sim_TRL_223();
                case CardDB.cardIDEnum.TRL_327:
                    return new Sim_TRL_327();
                case CardDB.cardIDEnum.TRL_092:
                    return new Sim_TRL_092();
                case CardDB.cardIDEnum.TRL_309:
                    return new Sim_TRL_309();
                case CardDB.cardIDEnum.TRL_400:
                    return new Sim_TRL_400();
                case CardDB.cardIDEnum.TRL_348:
                    return new Sim_TRL_348();
                case CardDB.cardIDEnum.TRL_255e:
                    return new Sim_TRL_255e();
                case CardDB.cardIDEnum.TRL_255:
                    return new Sim_TRL_255();
                case CardDB.cardIDEnum.TRLA_065p:
                    return new Sim_TRLA_065p();
                case CardDB.cardIDEnum.TRL_156:
                    return new Sim_TRL_156();
                case CardDB.cardIDEnum.TRLA_168:
                    return new Sim_TRLA_168();
                case CardDB.cardIDEnum.TRLA_123:
                    return new Sim_TRLA_123();
                case CardDB.cardIDEnum.TRL_325:
                    return new Sim_TRL_325();
                case CardDB.cardIDEnum.TRL_500:
                    return new Sim_TRL_500();
                case CardDB.cardIDEnum.TRLA_Hunter_11:
                    return new Sim_TRLA_Hunter_11();
                case CardDB.cardIDEnum.TRL_507t:
                    return new Sim_TRL_507t();
                case CardDB.cardIDEnum.TRLA_Warrior_01:
                    return new Sim_TRLA_Warrior_01();
                case CardDB.cardIDEnum.TRLA_Warlock_04:
                    return new Sim_TRLA_Warlock_04();
                case CardDB.cardIDEnum.TRLA_Paladin_05:
                    return new Sim_TRLA_Paladin_05();
                case CardDB.cardIDEnum.TRL_119:
                    return new Sim_TRL_119();
                case CardDB.cardIDEnum.TRL_119e:
                    return new Sim_TRL_119e();
                case CardDB.cardIDEnum.TRLA_125:
                    return new Sim_TRLA_125();
                case CardDB.cardIDEnum.TRLA_125e:
                    return new Sim_TRLA_125e();
                case CardDB.cardIDEnum.TRLA_142:
                    return new Sim_TRLA_142();
                case CardDB.cardIDEnum.TRL_015:
                    return new Sim_TRL_015();
                case CardDB.cardIDEnum.TRL_309t:
                    return new Sim_TRL_309t();
                case CardDB.cardIDEnum.TRL_302:
                    return new Sim_TRL_302();
                case CardDB.cardIDEnum.TRL_302e:
                    return new Sim_TRL_302e();
                case CardDB.cardIDEnum.TRL_351t:
                    return new Sim_TRL_351t();
                case CardDB.cardIDEnum.TRL_012:
                    return new Sim_TRL_012();
                case CardDB.cardIDEnum.TRLA_Shaman_09:
                    return new Sim_TRLA_Shaman_09();
                case CardDB.cardIDEnum.TRLA_186:
                    return new Sim_TRLA_186();
                case CardDB.cardIDEnum.TRLA_186t:
                    return new Sim_TRLA_186t();
                case CardDB.cardIDEnum.TRL_341:
                    return new Sim_TRL_341();
                case CardDB.cardIDEnum.TRLA_107:
                    return new Sim_TRLA_107();
                case CardDB.cardIDEnum.TRLA_107t:
                    return new Sim_TRLA_107t();
                case CardDB.cardIDEnum.TRLA_154:
                    return new Sim_TRLA_154();
                case CardDB.cardIDEnum.TRLA_154t:
                    return new Sim_TRLA_154t();
                case CardDB.cardIDEnum.TRLA_Hunter_03:
                    return new Sim_TRLA_Hunter_03();
                case CardDB.cardIDEnum.TRLA_Rogue_05:
                    return new Sim_TRLA_Rogue_05();
                case CardDB.cardIDEnum.TRLA_166:
                    return new Sim_TRLA_166();
                case CardDB.cardIDEnum.TRLA_177:
                    return new Sim_TRLA_177();
                case CardDB.cardIDEnum.TRL_537e:
                    return new Sim_TRL_537e();
                case CardDB.cardIDEnum.TRL_405:
                    return new Sim_TRL_405();
                case CardDB.cardIDEnum.TRLA_182:
                    return new Sim_TRLA_182();
                case CardDB.cardIDEnum.TRL_058e:
                    return new Sim_TRL_058e();
                case CardDB.cardIDEnum.TRL_246:
                    return new Sim_TRL_246();
                case CardDB.cardIDEnum.TRL_082e:
                    return new Sim_TRL_082e();
                case CardDB.cardIDEnum.TRL_157:
                    return new Sim_TRL_157();
                case CardDB.cardIDEnum.TRLA_161:
                    return new Sim_TRLA_161();
                case CardDB.cardIDEnum.TRL_328:
                    return new Sim_TRL_328();
                case CardDB.cardIDEnum.TRLA_200h:
                    return new Sim_TRLA_200h();
                case CardDB.cardIDEnum.TRL_343:
                    return new Sim_TRL_343();
                case CardDB.cardIDEnum.TRL_343at2:
                    return new Sim_TRL_343at2();
                case CardDB.cardIDEnum.TRL_343bt2:
                    return new Sim_TRL_343bt2();
                case CardDB.cardIDEnum.TRL_343ct2:
                    return new Sim_TRL_343ct2();
                case CardDB.cardIDEnum.TRL_343dt2:
                    return new Sim_TRL_343dt2();
                case CardDB.cardIDEnum.TRL_343et1:
                    return new Sim_TRL_343et1();
                case CardDB.cardIDEnum.TRLA_205h:
                    return new Sim_TRLA_205h();
                case CardDB.cardIDEnum.TRLA_183:
                    return new Sim_TRLA_183();
                case CardDB.cardIDEnum.TRL_405e:
                    return new Sim_TRL_405e();
                case CardDB.cardIDEnum.TRL_522:
                    return new Sim_TRL_522();
                case CardDB.cardIDEnum.TRLA_121:
                    return new Sim_TRLA_121();
                case CardDB.cardIDEnum.TRL_407:
                    return new Sim_TRL_407();
                case CardDB.cardIDEnum.TRLA_148:
                    return new Sim_TRLA_148();
                case CardDB.cardIDEnum.TRLA_Rogue_06:
                    return new Sim_TRLA_Rogue_06();
                case CardDB.cardIDEnum.TRL_517e2:
                    return new Sim_TRL_517e2();
                case CardDB.cardIDEnum.TRLA_809:
                    return new Sim_TRLA_809();
                case CardDB.cardIDEnum.TRLA_809e3:
                    return new Sim_TRLA_809e3();
                case CardDB.cardIDEnum.TRLA_809e:
                    return new Sim_TRLA_809e();
                case CardDB.cardIDEnum.TRLA_809e2:
                    return new Sim_TRLA_809e2();
                case CardDB.cardIDEnum.TRLA_Druid_06:
                    return new Sim_TRLA_Druid_06();
                case CardDB.cardIDEnum.TRLA_Priest_09:
                    return new Sim_TRLA_Priest_09();
                case CardDB.cardIDEnum.TRLA_Warlock_06:
                    return new Sim_TRLA_Warlock_06();
                case CardDB.cardIDEnum.TRLA_806e:
                    return new Sim_TRLA_806e();
                case CardDB.cardIDEnum.TRLA_806:
                    return new Sim_TRLA_806();
                case CardDB.cardIDEnum.TRLA_806e2:
                    return new Sim_TRLA_806e2();
                case CardDB.cardIDEnum.TRL_406e:
                    return new Sim_TRL_406e();
                case CardDB.cardIDEnum.TRLA_124:
                    return new Sim_TRLA_124();
                case CardDB.cardIDEnum.TRL_545:
                    return new Sim_TRL_545();
                case CardDB.cardIDEnum.TRL_085:
                    return new Sim_TRL_085();
                case CardDB.cardIDEnum.TRLA_201h:
                    return new Sim_TRLA_201h();
                case CardDB.cardIDEnum.TRL_085e:
                    return new Sim_TRL_085e();
                case CardDB.cardIDEnum.TRL_131t:
                    return new Sim_TRL_131t();
                case CardDB.cardIDEnum.TRL_065:
                    return new Sim_TRL_065();
                case CardDB.cardIDEnum.TRLA_204h:
                    return new Sim_TRLA_204h();
 ///case CardDB.cardIDEnum.///MISSIONS:
                    ///return new Sim_///MISSIONS();
                case CardDB.cardIDEnum.TU4c_006:
                    return new Sim_TU4c_006();
                case CardDB.cardIDEnum.TU4c_006e:
                    return new Sim_TU4c_006e();
                case CardDB.cardIDEnum.TU4c_003:
                    return new Sim_TU4c_003();
                case CardDB.cardIDEnum.TU4c_002:
                    return new Sim_TU4c_002();
                case CardDB.cardIDEnum.TU4f_005:
                    return new Sim_TU4f_005();
                case CardDB.cardIDEnum.TU4d_002:
                    return new Sim_TU4d_002();
                case CardDB.cardIDEnum.TU4f_007:
                    return new Sim_TU4f_007();
                case CardDB.cardIDEnum.TU4e_007:
                    return new Sim_TU4e_007();
                case CardDB.cardIDEnum.TU4e_005:
                    return new Sim_TU4e_005();
                case CardDB.cardIDEnum.TU4e_002t:
                    return new Sim_TU4e_002t();
                case CardDB.cardIDEnum.TU4e_002:
                    return new Sim_TU4e_002();
                case CardDB.cardIDEnum.TU4a_003:
                    return new Sim_TU4a_003();
                case CardDB.cardIDEnum.TU4d_001:
                    return new Sim_TU4d_001();
                case CardDB.cardIDEnum.TU4c_005:
                    return new Sim_TU4c_005();
                case CardDB.cardIDEnum.TU4a_001:
                    return new Sim_TU4a_001();
                case CardDB.cardIDEnum.TU4a_004:
                    return new Sim_TU4a_004();
                case CardDB.cardIDEnum.TU4e_001:
                    return new Sim_TU4e_001();
                case CardDB.cardIDEnum.TU4a_006:
                    return new Sim_TU4a_006();
                case CardDB.cardIDEnum.TU4c_001:
                    return new Sim_TU4c_001();
                case CardDB.cardIDEnum.TU4f_004:
                    return new Sim_TU4f_004();
                case CardDB.cardIDEnum.TU4f_004o:
                    return new Sim_TU4f_004o();
                case CardDB.cardIDEnum.TU4f_001:
                    return new Sim_TU4f_001();
                case CardDB.cardIDEnum.TU4a_005:
                    return new Sim_TU4a_005();
                case CardDB.cardIDEnum.TU4c_008e:
                    return new Sim_TU4c_008e();
                case CardDB.cardIDEnum.TU4b_001:
                    return new Sim_TU4b_001();
                case CardDB.cardIDEnum.TU4c_007:
                    return new Sim_TU4c_007();
                case CardDB.cardIDEnum.TU4e_003:
                    return new Sim_TU4e_003();
                case CardDB.cardIDEnum.TU4f_002:
                    return new Sim_TU4f_002();
                case CardDB.cardIDEnum.TU4a_002:
                    return new Sim_TU4a_002();
                case CardDB.cardIDEnum.TU4f_003:
                    return new Sim_TU4f_003();
                case CardDB.cardIDEnum.TU4d_003:
                    return new Sim_TU4d_003();
                case CardDB.cardIDEnum.TU4c_004:
                    return new Sim_TU4c_004();
                case CardDB.cardIDEnum.TU4f_006:
                    return new Sim_TU4f_006();
                case CardDB.cardIDEnum.TU4f_006o:
                    return new Sim_TU4f_006o();
                case CardDB.cardIDEnum.TU4e_004:
                    return new Sim_TU4e_004();
                case CardDB.cardIDEnum.TU4c_008:
                    return new Sim_TU4c_008();
 ///case CardDB.cardIDEnum.///ULDUM:
                    ///return new Sim_///ULDUM();
                case CardDB.cardIDEnum.ULD_724:
                    return new Sim_ULD_724();
                case CardDB.cardIDEnum.ULD_262e:
                    return new Sim_ULD_262e();
                case CardDB.cardIDEnum.ULD_207:
                    return new Sim_ULD_207();
                case CardDB.cardIDEnum.ULD_326p:
                    return new Sim_ULD_326p();
                case CardDB.cardIDEnum.ULD_726:
                    return new Sim_ULD_726();
                case CardDB.cardIDEnum.ULD_288:
                    return new Sim_ULD_288();
                case CardDB.cardIDEnum.ULD_711p3:
                    return new Sim_ULD_711p3();
                case CardDB.cardIDEnum.ULD_138:
                    return new Sim_ULD_138();
                case CardDB.cardIDEnum.ULD_183e:
                    return new Sim_ULD_183e();
                case CardDB.cardIDEnum.ULD_183:
                    return new Sim_ULD_183();
                case CardDB.cardIDEnum.ULD_240:
                    return new Sim_ULD_240();
                case CardDB.cardIDEnum.ULD_309e:
                    return new Sim_ULD_309e();
                case CardDB.cardIDEnum.ULD_258:
                    return new Sim_ULD_258();
                case CardDB.cardIDEnum.ULD_709:
                    return new Sim_ULD_709();
                case CardDB.cardIDEnum.ULD_433p:
                    return new Sim_ULD_433p();
                case CardDB.cardIDEnum.ULD_191e:
                    return new Sim_ULD_191e();
                case CardDB.cardIDEnum.ULD_326:
                    return new Sim_ULD_326();
                case CardDB.cardIDEnum.ULD_327:
                    return new Sim_ULD_327();
                case CardDB.cardIDEnum.ULD_191:
                    return new Sim_ULD_191();
                case CardDB.cardIDEnum.ULD_134t:
                    return new Sim_ULD_134t();
                case CardDB.cardIDEnum.ULD_134:
                    return new Sim_ULD_134();
                case CardDB.cardIDEnum.ULD_135a:
                    return new Sim_ULD_135a();
                case CardDB.cardIDEnum.ULD_171e:
                    return new Sim_ULD_171e();
                case CardDB.cardIDEnum.ULD_706:
                    return new Sim_ULD_706();
                case CardDB.cardIDEnum.ULD_720:
                    return new Sim_ULD_720();
                case CardDB.cardIDEnum.ULD_727:
                    return new Sim_ULD_727();
                case CardDB.cardIDEnum.ULD_275:
                    return new Sim_ULD_275();
                case CardDB.cardIDEnum.ULD_189e:
                    return new Sim_ULD_189e();
                case CardDB.cardIDEnum.ULD_145:
                    return new Sim_ULD_145();
                case CardDB.cardIDEnum.ULD_712:
                    return new Sim_ULD_712();
                case CardDB.cardIDEnum.ULD_288e:
                    return new Sim_ULD_288e();
                case CardDB.cardIDEnum.ULD_205:
                    return new Sim_ULD_205();
                case CardDB.cardIDEnum.ULD_214e:
                    return new Sim_ULD_214e();
                case CardDB.cardIDEnum.ULD_433e:
                    return new Sim_ULD_433e();
                case CardDB.cardIDEnum.ULD_328:
                    return new Sim_ULD_328();
                case CardDB.cardIDEnum.ULD_293:
                    return new Sim_ULD_293();
                case CardDB.cardIDEnum.ULD_721:
                    return new Sim_ULD_721();
                case CardDB.cardIDEnum.ULD_179e:
                    return new Sim_ULD_179e();
                case CardDB.cardIDEnum.ULD_198:
                    return new Sim_ULD_198();
                case CardDB.cardIDEnum.ULD_291:
                    return new Sim_ULD_291();
                case CardDB.cardIDEnum.ULD_133:
                    return new Sim_ULD_133();
                case CardDB.cardIDEnum.ULD_168:
                    return new Sim_ULD_168();
                case CardDB.cardIDEnum.ULD_719:
                    return new Sim_ULD_719();
                case CardDB.cardIDEnum.ULD_703:
                    return new Sim_ULD_703();
                case CardDB.cardIDEnum.ULD_430:
                    return new Sim_ULD_430();
                case CardDB.cardIDEnum.ULD_156:
                    return new Sim_ULD_156();
                case CardDB.cardIDEnum.ULD_167:
                    return new Sim_ULD_167();
                case CardDB.cardIDEnum.ULD_292b:
                    return new Sim_ULD_292b();
                case CardDB.cardIDEnum.ULD_135b:
                    return new Sim_ULD_135b();
                case CardDB.cardIDEnum.ULD_156t2:
                    return new Sim_ULD_156t2();
                case CardDB.cardIDEnum.ULD_156t:
                    return new Sim_ULD_156t();
                case CardDB.cardIDEnum.ULD_329:
                    return new Sim_ULD_329();
                case CardDB.cardIDEnum.ULD_309:
                    return new Sim_ULD_309();
                case CardDB.cardIDEnum.ULD_181:
                    return new Sim_ULD_181();
                case CardDB.cardIDEnum.ULD_139:
                    return new Sim_ULD_139();
                case CardDB.cardIDEnum.ULD_265:
                    return new Sim_ULD_265();
                case CardDB.cardIDEnum.ULD_431e:
                    return new Sim_ULD_431e();
                case CardDB.cardIDEnum.ULD_431p:
                    return new Sim_ULD_431p();
                case CardDB.cardIDEnum.ULD_185e:
                    return new Sim_ULD_185e();
                case CardDB.cardIDEnum.ULD_290e:
                    return new Sim_ULD_290e();
                case CardDB.cardIDEnum.ULD_162t:
                    return new Sim_ULD_162t();
                case CardDB.cardIDEnum.ULD_162:
                    return new Sim_ULD_162();
                case CardDB.cardIDEnum.ULD_276:
                    return new Sim_ULD_276();
                case CardDB.cardIDEnum.ULD_163e:
                    return new Sim_ULD_163e();
                case CardDB.cardIDEnum.ULD_163:
                    return new Sim_ULD_163();
                case CardDB.cardIDEnum.ULD_189:
                    return new Sim_ULD_189();
                case CardDB.cardIDEnum.ULD_289:
                    return new Sim_ULD_289();
                case CardDB.cardIDEnum.ULD_239:
                    return new Sim_ULD_239();
                case CardDB.cardIDEnum.ULD_292ae:
                    return new Sim_ULD_292ae();
                case CardDB.cardIDEnum.ULD_292a:
                    return new Sim_ULD_292a();
                case CardDB.cardIDEnum.ULD_256e:
                    return new Sim_ULD_256e();
                case CardDB.cardIDEnum.ULD_195:
                    return new Sim_ULD_195();
                case CardDB.cardIDEnum.ULD_137:
                    return new Sim_ULD_137();
                case CardDB.cardIDEnum.ULD_214:
                    return new Sim_ULD_214();
                case CardDB.cardIDEnum.ULD_188:
                    return new Sim_ULD_188();
                case CardDB.cardIDEnum.ULD_266:
                    return new Sim_ULD_266();
                case CardDB.cardIDEnum.ULD_266e:
                    return new Sim_ULD_266e();
                case CardDB.cardIDEnum.ULD_711:
                    return new Sim_ULD_711();
                case CardDB.cardIDEnum.ULD_616e:
                    return new Sim_ULD_616e();
                case CardDB.cardIDEnum.ULD_291p:
                    return new Sim_ULD_291p();
                case CardDB.cardIDEnum.ULD_291pe:
                    return new Sim_ULD_291pe();
                case CardDB.cardIDEnum.ULD_135:
                    return new Sim_ULD_135();
                case CardDB.cardIDEnum.ULD_262:
                    return new Sim_ULD_262();
                case CardDB.cardIDEnum.ULD_705t:
                    return new Sim_ULD_705t();
                case CardDB.cardIDEnum.ULD_290:
                    return new Sim_ULD_290();
                case CardDB.cardIDEnum.ULD_272:
                    return new Sim_ULD_272();
                case CardDB.cardIDEnum.ULD_285:
                    return new Sim_ULD_285();
                case CardDB.cardIDEnum.ULD_429:
                    return new Sim_ULD_429();
                case CardDB.cardIDEnum.ULD_154t:
                    return new Sim_ULD_154t();
                case CardDB.cardIDEnum.ULD_154:
                    return new Sim_ULD_154();
                case CardDB.cardIDEnum.ULD_324:
                    return new Sim_ULD_324();
                case CardDB.cardIDEnum.ULD_250:
                    return new Sim_ULD_250();
                case CardDB.cardIDEnum.ULD_271:
                    return new Sim_ULD_271();
                case CardDB.cardIDEnum.ULD_256:
                    return new Sim_ULD_256();
                case CardDB.cardIDEnum.ULD_282:
                    return new Sim_ULD_282();
                case CardDB.cardIDEnum.ULD_208:
                    return new Sim_ULD_208();
                case CardDB.cardIDEnum.ULD_156t3:
                    return new Sim_ULD_156t3();
                case CardDB.cardIDEnum.ULD_304:
                    return new Sim_ULD_304();
                case CardDB.cardIDEnum.ULD_184:
                    return new Sim_ULD_184();
                case CardDB.cardIDEnum.ULD_168e:
                    return new Sim_ULD_168e();
                case CardDB.cardIDEnum.ULD_168e2:
                    return new Sim_ULD_168e2();
                case CardDB.cardIDEnum.ULD_168e3:
                    return new Sim_ULD_168e3();
                case CardDB.cardIDEnum.ULD_708:
                    return new Sim_ULD_708();
                case CardDB.cardIDEnum.ULD_193:
                    return new Sim_ULD_193();
                case CardDB.cardIDEnum.ULD_430t:
                    return new Sim_ULD_430t();
                case CardDB.cardIDEnum.ULD_431:
                    return new Sim_ULD_431();
                case CardDB.cardIDEnum.ULD_217:
                    return new Sim_ULD_217();
                case CardDB.cardIDEnum.ULD_217e:
                    return new Sim_ULD_217e();
                case CardDB.cardIDEnum.ULD_326t:
                    return new Sim_ULD_326t();
                case CardDB.cardIDEnum.ULD_229:
                    return new Sim_ULD_229();
                case CardDB.cardIDEnum.ULD_705:
                    return new Sim_ULD_705();
                case CardDB.cardIDEnum.ULD_169:
                    return new Sim_ULD_169();
                case CardDB.cardIDEnum.ULD_702:
                    return new Sim_ULD_702();
                case CardDB.cardIDEnum.ULD_723:
                    return new Sim_ULD_723();
                case CardDB.cardIDEnum.ULD_209t:
                    return new Sim_ULD_209t();
                case CardDB.cardIDEnum.ULD_435:
                    return new Sim_ULD_435();
                case CardDB.cardIDEnum.ULD_196:
                    return new Sim_ULD_196();
                case CardDB.cardIDEnum.ULD_161:
                    return new Sim_ULD_161();
                case CardDB.cardIDEnum.ULD_292:
                    return new Sim_ULD_292();
                case CardDB.cardIDEnum.ULD_724p:
                    return new Sim_ULD_724p();
                case CardDB.cardIDEnum.ULD_724e:
                    return new Sim_ULD_724e();
                case CardDB.cardIDEnum.ULD_177:
                    return new Sim_ULD_177();
                case CardDB.cardIDEnum.ULD_140e:
                    return new Sim_ULD_140e();
                case CardDB.cardIDEnum.ULD_131p:
                    return new Sim_ULD_131p();
                case CardDB.cardIDEnum.ULD_273:
                    return new Sim_ULD_273();
                case CardDB.cardIDEnum.ULD_714:
                    return new Sim_ULD_714();
                case CardDB.cardIDEnum.ULD_179:
                    return new Sim_ULD_179();
                case CardDB.cardIDEnum.ULD_186:
                    return new Sim_ULD_186();
                case CardDB.cardIDEnum.ULD_143:
                    return new Sim_ULD_143();
                case CardDB.cardIDEnum.ULD_143e:
                    return new Sim_ULD_143e();
                case CardDB.cardIDEnum.ULD_190:
                    return new Sim_ULD_190();
                case CardDB.cardIDEnum.ULD_718:
                    return new Sim_ULD_718();
                case CardDB.cardIDEnum.ULD_717:
                    return new Sim_ULD_717();
                case CardDB.cardIDEnum.ULD_715:
                    return new Sim_ULD_715();
                case CardDB.cardIDEnum.ULD_172:
                    return new Sim_ULD_172();
                case CardDB.cardIDEnum.ULD_707:
                    return new Sim_ULD_707();
                case CardDB.cardIDEnum.ULD_715t:
                    return new Sim_ULD_715t();
                case CardDB.cardIDEnum.ULD_285e:
                    return new Sim_ULD_285e();
                case CardDB.cardIDEnum.ULD_152:
                    return new Sim_ULD_152();
                case CardDB.cardIDEnum.ULD_268:
                    return new Sim_ULD_268();
                case CardDB.cardIDEnum.ULD_216:
                    return new Sim_ULD_216();
                case CardDB.cardIDEnum.ULD_157:
                    return new Sim_ULD_157();
                case CardDB.cardIDEnum.ULD_197:
                    return new Sim_ULD_197();
                case CardDB.cardIDEnum.ULD_433:
                    return new Sim_ULD_433();
                case CardDB.cardIDEnum.ULD_155p:
                    return new Sim_ULD_155p();
                case CardDB.cardIDEnum.ULD_151:
                    return new Sim_ULD_151();
                case CardDB.cardIDEnum.ULD_238:
                    return new Sim_ULD_238();
                case CardDB.cardIDEnum.ULD_206:
                    return new Sim_ULD_206();
                case CardDB.cardIDEnum.ULD_165:
                    return new Sim_ULD_165();
                case CardDB.cardIDEnum.ULD_155e:
                    return new Sim_ULD_155e();
                case CardDB.cardIDEnum.ULD_280:
                    return new Sim_ULD_280();
                case CardDB.cardIDEnum.ULD_438:
                    return new Sim_ULD_438();
                case CardDB.cardIDEnum.ULD_270:
                    return new Sim_ULD_270();
                case CardDB.cardIDEnum.ULD_158:
                    return new Sim_ULD_158();
                case CardDB.cardIDEnum.ULD_439t:
                    return new Sim_ULD_439t();
                case CardDB.cardIDEnum.ULD_439:
                    return new Sim_ULD_439();
                case CardDB.cardIDEnum.ULD_435e:
                    return new Sim_ULD_435e();
                case CardDB.cardIDEnum.ULD_215t:
                    return new Sim_ULD_215t();
                case CardDB.cardIDEnum.ULD_410:
                    return new Sim_ULD_410();
                case CardDB.cardIDEnum.ULD_174t:
                    return new Sim_ULD_174t();
                case CardDB.cardIDEnum.ULD_174:
                    return new Sim_ULD_174();
                case CardDB.cardIDEnum.ULD_286t:
                    return new Sim_ULD_286t();
                case CardDB.cardIDEnum.ULD_286:
                    return new Sim_ULD_286();
                case CardDB.cardIDEnum.ULD_178:
                    return new Sim_ULD_178();
                case CardDB.cardIDEnum.ULD_178a3:
                    return new Sim_ULD_178a3();
                case CardDB.cardIDEnum.ULD_178a2:
                    return new Sim_ULD_178a2();
                case CardDB.cardIDEnum.ULD_178a4:
                    return new Sim_ULD_178a4();
                case CardDB.cardIDEnum.ULD_178a:
                    return new Sim_ULD_178a();
                case CardDB.cardIDEnum.ULD_160:
                    return new Sim_ULD_160();
                case CardDB.cardIDEnum.ULD_500:
                    return new Sim_ULD_500();
                case CardDB.cardIDEnum.ULD_182:
                    return new Sim_ULD_182();
                case CardDB.cardIDEnum.ULD_413:
                    return new Sim_ULD_413();
                case CardDB.cardIDEnum.ULD_711t:
                    return new Sim_ULD_711t();
                case CardDB.cardIDEnum.ULD_197e:
                    return new Sim_ULD_197e();
                case CardDB.cardIDEnum.ULD_728:
                    return new Sim_ULD_728();
                case CardDB.cardIDEnum.ULD_728e:
                    return new Sim_ULD_728e();
                case CardDB.cardIDEnum.ULD_180:
                    return new Sim_ULD_180();
                case CardDB.cardIDEnum.ULD_140:
                    return new Sim_ULD_140();
                case CardDB.cardIDEnum.ULD_713:
                    return new Sim_ULD_713();
                case CardDB.cardIDEnum.ULD_185:
                    return new Sim_ULD_185();
                case CardDB.cardIDEnum.ULD_716:
                    return new Sim_ULD_716();
                case CardDB.cardIDEnum.ULD_616:
                    return new Sim_ULD_616();
                case CardDB.cardIDEnum.ULD_253:
                    return new Sim_ULD_253();
                case CardDB.cardIDEnum.ULD_140p:
                    return new Sim_ULD_140p();
                case CardDB.cardIDEnum.ULD_236:
                    return new Sim_ULD_236();
                case CardDB.cardIDEnum.ULD_171:
                    return new Sim_ULD_171();
                case CardDB.cardIDEnum.ULD_258e:
                    return new Sim_ULD_258e();
                case CardDB.cardIDEnum.ULD_726e:
                    return new Sim_ULD_726e();
                case CardDB.cardIDEnum.ULD_137t:
                    return new Sim_ULD_137t();
                case CardDB.cardIDEnum.ULD_155:
                    return new Sim_ULD_155();
                case CardDB.cardIDEnum.ULD_131:
                    return new Sim_ULD_131();
                case CardDB.cardIDEnum.ULD_173:
                    return new Sim_ULD_173();
                case CardDB.cardIDEnum.ULD_173e:
                    return new Sim_ULD_173e();
                case CardDB.cardIDEnum.ULD_450:
                    return new Sim_ULD_450();
                case CardDB.cardIDEnum.ULD_135at:
                    return new Sim_ULD_135at();
                case CardDB.cardIDEnum.ULD_209:
                    return new Sim_ULD_209();
                case CardDB.cardIDEnum.ULD_274:
                    return new Sim_ULD_274();
                case CardDB.cardIDEnum.ULD_194:
                    return new Sim_ULD_194();
                case CardDB.cardIDEnum.ULD_716e2:
                    return new Sim_ULD_716e2();
                case CardDB.cardIDEnum.ULD_170:
                    return new Sim_ULD_170();
                case CardDB.cardIDEnum.ULD_410e:
                    return new Sim_ULD_410e();
                case CardDB.cardIDEnum.ULD_231:
                    return new Sim_ULD_231();
                case CardDB.cardIDEnum.ULD_212:
                    return new Sim_ULD_212();
                case CardDB.cardIDEnum.ULD_324t:
                    return new Sim_ULD_324t();
                case CardDB.cardIDEnum.ULD_136:
                    return new Sim_ULD_136();
                case CardDB.cardIDEnum.ULD_215:
                    return new Sim_ULD_215();
                case CardDB.cardIDEnum.ULD_269:
                    return new Sim_ULD_269();
                case CardDB.cardIDEnum.ULD_145e:
                    return new Sim_ULD_145e();
                case CardDB.cardIDEnum.ULD_003:
                    return new Sim_ULD_003();

case CardDB.cardIDEnum.AT_132_DRUIDc:
  return new Sim_AT_132_DRUIDc();
case CardDB.cardIDEnum.AT_132_HUNTER_H1:
  return new Sim_AT_132_HUNTER_H1();
case CardDB.cardIDEnum.BGS_001:
  return new Sim_BGS_001();
case CardDB.cardIDEnum.BGS_001e:
  return new Sim_BGS_001e();
case CardDB.cardIDEnum.BGS_002:
  return new Sim_BGS_002();
case CardDB.cardIDEnum.BGS_004:
  return new Sim_BGS_004();
case CardDB.cardIDEnum.BGS_004e:
  return new Sim_BGS_004e();
case CardDB.cardIDEnum.BGS_006:
  return new Sim_BGS_006();
case CardDB.cardIDEnum.BGS_008:
  return new Sim_BGS_008();
case CardDB.cardIDEnum.BGS_009:
  return new Sim_BGS_009();
case CardDB.cardIDEnum.BGS_009e:
  return new Sim_BGS_009e();
case CardDB.cardIDEnum.BGS_010:
  return new Sim_BGS_010();
case CardDB.cardIDEnum.BGS_010e:
  return new Sim_BGS_010e();
case CardDB.cardIDEnum.BGS_012:
  return new Sim_BGS_012();
case CardDB.cardIDEnum.BGS_017:
  return new Sim_BGS_017();
case CardDB.cardIDEnum.BGS_017e:
  return new Sim_BGS_017e();
case CardDB.cardIDEnum.BGS_018:
  return new Sim_BGS_018();
case CardDB.cardIDEnum.BGS_018e:
  return new Sim_BGS_018e();
case CardDB.cardIDEnum.BGS_020:
  return new Sim_BGS_020();
case CardDB.cardIDEnum.BGS_021:
  return new Sim_BGS_021();
case CardDB.cardIDEnum.BGS_021e:
  return new Sim_BGS_021e();
case CardDB.cardIDEnum.BGS_022:
  return new Sim_BGS_022();
case CardDB.cardIDEnum.BGS_023:
  return new Sim_BGS_023();
case CardDB.cardIDEnum.BGS_024:
  return new Sim_BGS_024();
case CardDB.cardIDEnum.BGS_025:
  return new Sim_BGS_025();
case CardDB.cardIDEnum.BGS_027:
  return new Sim_BGS_027();
case CardDB.cardIDEnum.BGS_028:
  return new Sim_BGS_028();
case CardDB.cardIDEnum.BGS_028pe:
  return new Sim_BGS_028pe();
case CardDB.cardIDEnum.BGS_029:
  return new Sim_BGS_029();
case CardDB.cardIDEnum.BGS_029e:
  return new Sim_BGS_029e();
case CardDB.cardIDEnum.BGS_030:
  return new Sim_BGS_030();
case CardDB.cardIDEnum.BGS_030e:
  return new Sim_BGS_030e();
case CardDB.cardIDEnum.BGS_031:
  return new Sim_BGS_031();
case CardDB.cardIDEnum.CS1h_001_H3:
  return new Sim_CS1h_001_H3();
case CardDB.cardIDEnum.CS2_017_HS3:
  return new Sim_CS2_017_HS3();
case CardDB.cardIDEnum.CS2_017_HS4:
  return new Sim_CS2_017_HS4();
case CardDB.cardIDEnum.CS2_034_H3:
  return new Sim_CS2_034_H3();
case CardDB.cardIDEnum.CS2_049_H4:
  return new Sim_CS2_049_H4();
case CardDB.cardIDEnum.CS2_056_H3:
  return new Sim_CS2_056_H3();
case CardDB.cardIDEnum.CS2_083b_H2:
  return new Sim_CS2_083b_H2();
case CardDB.cardIDEnum.CS2_101_H4:
  return new Sim_CS2_101_H4();
case CardDB.cardIDEnum.CS2_102_H2:
  return new Sim_CS2_102_H2();
case CardDB.cardIDEnum.CS2_102_H2_AT_132:
  return new Sim_CS2_102_H2_AT_132();
case CardDB.cardIDEnum.CS2_102_H3:
  return new Sim_CS2_102_H3();
case CardDB.cardIDEnum.CS2_102_H3_AT_132:
  return new Sim_CS2_102_H3_AT_132();
case CardDB.cardIDEnum.DRG_006:
  return new Sim_DRG_006();
case CardDB.cardIDEnum.DRG_007:
  return new Sim_DRG_007();
case CardDB.cardIDEnum.DRG_007e:
  return new Sim_DRG_007e();
case CardDB.cardIDEnum.DRG_008:
  return new Sim_DRG_008();
case CardDB.cardIDEnum.DRG_008e:
  return new Sim_DRG_008e();
case CardDB.cardIDEnum.DRG_010:
  return new Sim_DRG_010();
case CardDB.cardIDEnum.DRG_019:
  return new Sim_DRG_019();
case CardDB.cardIDEnum.DRG_020:
  return new Sim_DRG_020();
case CardDB.cardIDEnum.DRG_021:
  return new Sim_DRG_021();
case CardDB.cardIDEnum.DRG_022:
  return new Sim_DRG_022();
case CardDB.cardIDEnum.DRG_023:
  return new Sim_DRG_023();
case CardDB.cardIDEnum.DRG_024:
  return new Sim_DRG_024();
case CardDB.cardIDEnum.DRG_025:
  return new Sim_DRG_025();
case CardDB.cardIDEnum.DRG_026:
  return new Sim_DRG_026();
case CardDB.cardIDEnum.DRG_027:
  return new Sim_DRG_027();
case CardDB.cardIDEnum.DRG_028:
  return new Sim_DRG_028();
case CardDB.cardIDEnum.DRG_030:
  return new Sim_DRG_030();
case CardDB.cardIDEnum.DRG_030e:
  return new Sim_DRG_030e();
case CardDB.cardIDEnum.DRG_031:
  return new Sim_DRG_031();
case CardDB.cardIDEnum.DRG_031e:
  return new Sim_DRG_031e();
case CardDB.cardIDEnum.DRG_033:
  return new Sim_DRG_033();
case CardDB.cardIDEnum.DRG_034:
  return new Sim_DRG_034();
case CardDB.cardIDEnum.DRG_035:
  return new Sim_DRG_035();
case CardDB.cardIDEnum.DRG_035t:
  return new Sim_DRG_035t();
case CardDB.cardIDEnum.DRG_036:
  return new Sim_DRG_036();
case CardDB.cardIDEnum.DRG_036t:
  return new Sim_DRG_036t();
case CardDB.cardIDEnum.DRG_037:
  return new Sim_DRG_037();
case CardDB.cardIDEnum.DRG_049:
  return new Sim_DRG_049();
case CardDB.cardIDEnum.DRG_049e:
  return new Sim_DRG_049e();
case CardDB.cardIDEnum.DRG_050:
  return new Sim_DRG_050();
case CardDB.cardIDEnum.DRG_051:
  return new Sim_DRG_051();
case CardDB.cardIDEnum.DRG_052:
  return new Sim_DRG_052();
case CardDB.cardIDEnum.DRG_054:
  return new Sim_DRG_054();
case CardDB.cardIDEnum.DRG_055:
  return new Sim_DRG_055();
case CardDB.cardIDEnum.DRG_056:
  return new Sim_DRG_056();
case CardDB.cardIDEnum.DRG_057:
  return new Sim_DRG_057();
case CardDB.cardIDEnum.DRG_057e:
  return new Sim_DRG_057e();
case CardDB.cardIDEnum.DRG_058:
  return new Sim_DRG_058();
case CardDB.cardIDEnum.DRG_058e:
  return new Sim_DRG_058e();
case CardDB.cardIDEnum.DRG_059:
  return new Sim_DRG_059();
case CardDB.cardIDEnum.DRG_059e:
  return new Sim_DRG_059e();
case CardDB.cardIDEnum.DRG_060:
  return new Sim_DRG_060();
case CardDB.cardIDEnum.DRG_060e:
  return new Sim_DRG_060e();
case CardDB.cardIDEnum.DRG_061:
  return new Sim_DRG_061();
case CardDB.cardIDEnum.DRG_062:
  return new Sim_DRG_062();
case CardDB.cardIDEnum.DRG_063:
  return new Sim_DRG_063();
case CardDB.cardIDEnum.DRG_063e:
  return new Sim_DRG_063e();
case CardDB.cardIDEnum.DRG_064:
  return new Sim_DRG_064();
case CardDB.cardIDEnum.DRG_065:
  return new Sim_DRG_065();
case CardDB.cardIDEnum.DRG_066:
  return new Sim_DRG_066();
case CardDB.cardIDEnum.DRG_067:
  return new Sim_DRG_067();
case CardDB.cardIDEnum.DRG_068:
  return new Sim_DRG_068();
case CardDB.cardIDEnum.DRG_068e:
  return new Sim_DRG_068e();
case CardDB.cardIDEnum.DRG_069:
  return new Sim_DRG_069();
case CardDB.cardIDEnum.DRG_070:
  return new Sim_DRG_070();
case CardDB.cardIDEnum.DRG_071:
  return new Sim_DRG_071();
case CardDB.cardIDEnum.DRG_071t:
  return new Sim_DRG_071t();
case CardDB.cardIDEnum.DRG_072:
  return new Sim_DRG_072();
case CardDB.cardIDEnum.DRG_073:
  return new Sim_DRG_073();
case CardDB.cardIDEnum.DRG_074:
  return new Sim_DRG_074();
case CardDB.cardIDEnum.DRG_074e:
  return new Sim_DRG_074e();
case CardDB.cardIDEnum.DRG_075:
  return new Sim_DRG_075();
case CardDB.cardIDEnum.DRG_076:
  return new Sim_DRG_076();
case CardDB.cardIDEnum.DRG_077:
  return new Sim_DRG_077();
case CardDB.cardIDEnum.DRG_078:
  return new Sim_DRG_078();
case CardDB.cardIDEnum.DRG_079:
  return new Sim_DRG_079();
case CardDB.cardIDEnum.DRG_081:
  return new Sim_DRG_081();
case CardDB.cardIDEnum.DRG_082:
  return new Sim_DRG_082();
case CardDB.cardIDEnum.DRG_084:
  return new Sim_DRG_084();
case CardDB.cardIDEnum.DRG_084e:
  return new Sim_DRG_084e();
case CardDB.cardIDEnum.DRG_086:
  return new Sim_DRG_086();
case CardDB.cardIDEnum.DRG_086e:
  return new Sim_DRG_086e();
case CardDB.cardIDEnum.DRG_088:
  return new Sim_DRG_088();
case CardDB.cardIDEnum.DRG_088e:
  return new Sim_DRG_088e();
case CardDB.cardIDEnum.DRG_089:
  return new Sim_DRG_089();
case CardDB.cardIDEnum.DRG_089e:
  return new Sim_DRG_089e();
case CardDB.cardIDEnum.DRG_090:
  return new Sim_DRG_090();
case CardDB.cardIDEnum.DRG_091:
  return new Sim_DRG_091();
case CardDB.cardIDEnum.DRG_091t:
  return new Sim_DRG_091t();
case CardDB.cardIDEnum.DRG_092:
  return new Sim_DRG_092();
case CardDB.cardIDEnum.DRG_095:
  return new Sim_DRG_095();
case CardDB.cardIDEnum.DRG_095e:
  return new Sim_DRG_095e();
case CardDB.cardIDEnum.DRG_096:
  return new Sim_DRG_096();
case CardDB.cardIDEnum.DRG_096e:
  return new Sim_DRG_096e();
case CardDB.cardIDEnum.DRG_096e2:
  return new Sim_DRG_096e2();
case CardDB.cardIDEnum.DRG_099:
  return new Sim_DRG_099();
case CardDB.cardIDEnum.DRG_099t1:
  return new Sim_DRG_099t1();
case CardDB.cardIDEnum.DRG_099t2:
  return new Sim_DRG_099t2();
case CardDB.cardIDEnum.DRG_099t2t:
  return new Sim_DRG_099t2t();
case CardDB.cardIDEnum.DRG_099t3:
  return new Sim_DRG_099t3();
case CardDB.cardIDEnum.DRG_099t3e:
  return new Sim_DRG_099t3e();
case CardDB.cardIDEnum.DRG_099t4:
  return new Sim_DRG_099t4();
case CardDB.cardIDEnum.DRG_102:
  return new Sim_DRG_102();
case CardDB.cardIDEnum.DRG_104:
  return new Sim_DRG_104();
case CardDB.cardIDEnum.DRG_104t2:
  return new Sim_DRG_104t2();
case CardDB.cardIDEnum.DRG_106:
  return new Sim_DRG_106();
case CardDB.cardIDEnum.DRG_107:
  return new Sim_DRG_107();
case CardDB.cardIDEnum.DRG_109:
  return new Sim_DRG_109();
case CardDB.cardIDEnum.DRG_201:
  return new Sim_DRG_201();
case CardDB.cardIDEnum.DRG_202:
  return new Sim_DRG_202();
case CardDB.cardIDEnum.DRG_202e:
  return new Sim_DRG_202e();
case CardDB.cardIDEnum.DRG_203:
  return new Sim_DRG_203();
case CardDB.cardIDEnum.DRG_204:
  return new Sim_DRG_204();
case CardDB.cardIDEnum.DRG_205:
  return new Sim_DRG_205();
case CardDB.cardIDEnum.DRG_206:
  return new Sim_DRG_206();
case CardDB.cardIDEnum.DRG_207:
  return new Sim_DRG_207();
case CardDB.cardIDEnum.DRG_207t:
  return new Sim_DRG_207t();
case CardDB.cardIDEnum.DRG_208:
  return new Sim_DRG_208();
case CardDB.cardIDEnum.DRG_209:
  return new Sim_DRG_209();
case CardDB.cardIDEnum.DRG_209t:
  return new Sim_DRG_209t();
case CardDB.cardIDEnum.DRG_211:
  return new Sim_DRG_211();
case CardDB.cardIDEnum.DRG_213:
  return new Sim_DRG_213();
case CardDB.cardIDEnum.DRG_215:
  return new Sim_DRG_215();
case CardDB.cardIDEnum.DRG_215e:
  return new Sim_DRG_215e();
case CardDB.cardIDEnum.DRG_216:
  return new Sim_DRG_216();
case CardDB.cardIDEnum.DRG_216e:
  return new Sim_DRG_216e();
case CardDB.cardIDEnum.DRG_217:
  return new Sim_DRG_217();
case CardDB.cardIDEnum.DRG_217e:
  return new Sim_DRG_217e();
case CardDB.cardIDEnum.DRG_217t:
  return new Sim_DRG_217t();
case CardDB.cardIDEnum.DRG_218:
  return new Sim_DRG_218();
case CardDB.cardIDEnum.DRG_219:
  return new Sim_DRG_219();
case CardDB.cardIDEnum.DRG_223:
  return new Sim_DRG_223();
case CardDB.cardIDEnum.DRG_224:
  return new Sim_DRG_224();
case CardDB.cardIDEnum.DRG_224t:
  return new Sim_DRG_224t();
case CardDB.cardIDEnum.DRG_224t2:
  return new Sim_DRG_224t2();
case CardDB.cardIDEnum.DRG_225:
  return new Sim_DRG_225();
case CardDB.cardIDEnum.DRG_225e:
  return new Sim_DRG_225e();
case CardDB.cardIDEnum.DRG_225t:
  return new Sim_DRG_225t();
case CardDB.cardIDEnum.DRG_226:
  return new Sim_DRG_226();
case CardDB.cardIDEnum.DRG_229:
  return new Sim_DRG_229();
case CardDB.cardIDEnum.DRG_231:
  return new Sim_DRG_231();
case CardDB.cardIDEnum.DRG_232:
  return new Sim_DRG_232();
case CardDB.cardIDEnum.DRG_232t:
  return new Sim_DRG_232t();
case CardDB.cardIDEnum.DRG_233:
  return new Sim_DRG_233();
case CardDB.cardIDEnum.DRG_233e:
  return new Sim_DRG_233e();
case CardDB.cardIDEnum.DRG_235:
  return new Sim_DRG_235();
case CardDB.cardIDEnum.DRG_235d:
  return new Sim_DRG_235d();
case CardDB.cardIDEnum.DRG_235e:
  return new Sim_DRG_235e();
case CardDB.cardIDEnum.DRG_238ht:
  return new Sim_DRG_238ht();
case CardDB.cardIDEnum.DRG_238p:
  return new Sim_DRG_238p();
case CardDB.cardIDEnum.DRG_238p2:
  return new Sim_DRG_238p2();
case CardDB.cardIDEnum.DRG_238p3:
  return new Sim_DRG_238p3();
case CardDB.cardIDEnum.DRG_238p4:
  return new Sim_DRG_238p4();
case CardDB.cardIDEnum.DRG_238p5:
  return new Sim_DRG_238p5();
case CardDB.cardIDEnum.DRG_238t10e:
  return new Sim_DRG_238t10e();
case CardDB.cardIDEnum.DRG_238t12t2:
  return new Sim_DRG_238t12t2();
case CardDB.cardIDEnum.DRG_238t14t3:
  return new Sim_DRG_238t14t3();
case CardDB.cardIDEnum.DRG_239:
  return new Sim_DRG_239();
case CardDB.cardIDEnum.DRG_242:
  return new Sim_DRG_242();
case CardDB.cardIDEnum.DRG_246:
  return new Sim_DRG_246();
case CardDB.cardIDEnum.DRG_247:
  return new Sim_DRG_247();
case CardDB.cardIDEnum.DRG_248:
  return new Sim_DRG_248();
case CardDB.cardIDEnum.DRG_249:
  return new Sim_DRG_249();
case CardDB.cardIDEnum.DRG_250:
  return new Sim_DRG_250();
case CardDB.cardIDEnum.DRG_250e:
  return new Sim_DRG_250e();
case CardDB.cardIDEnum.DRG_251:
  return new Sim_DRG_251();
case CardDB.cardIDEnum.DRG_251t:
  return new Sim_DRG_251t();
case CardDB.cardIDEnum.DRG_252:
  return new Sim_DRG_252();
case CardDB.cardIDEnum.DRG_253:
  return new Sim_DRG_253();
case CardDB.cardIDEnum.DRG_254:
  return new Sim_DRG_254();
case CardDB.cardIDEnum.DRG_255:
  return new Sim_DRG_255();
case CardDB.cardIDEnum.DRG_255t2:
  return new Sim_DRG_255t2();
case CardDB.cardIDEnum.DRG_256:
  return new Sim_DRG_256();
case CardDB.cardIDEnum.DRG_257:
  return new Sim_DRG_257();
case CardDB.cardIDEnum.DRG_257e3:
  return new Sim_DRG_257e3();
case CardDB.cardIDEnum.DRG_258:
  return new Sim_DRG_258();
case CardDB.cardIDEnum.DRG_258t:
  return new Sim_DRG_258t();
case CardDB.cardIDEnum.DRG_270:
  return new Sim_DRG_270();
case CardDB.cardIDEnum.DRG_270t1:
  return new Sim_DRG_270t1();
case CardDB.cardIDEnum.DRG_270t11:
  return new Sim_DRG_270t11();
case CardDB.cardIDEnum.DRG_270t2:
  return new Sim_DRG_270t2();
case CardDB.cardIDEnum.DRG_270t4:
  return new Sim_DRG_270t4();
case CardDB.cardIDEnum.DRG_270t5:
  return new Sim_DRG_270t5();
case CardDB.cardIDEnum.DRG_270t6:
  return new Sim_DRG_270t6();
case CardDB.cardIDEnum.DRG_270t6t:
  return new Sim_DRG_270t6t();
case CardDB.cardIDEnum.DRG_270t7:
  return new Sim_DRG_270t7();
case CardDB.cardIDEnum.DRG_270t8:
  return new Sim_DRG_270t8();
case CardDB.cardIDEnum.DRG_270t9:
  return new Sim_DRG_270t9();
case CardDB.cardIDEnum.DRG_300:
  return new Sim_DRG_300();
case CardDB.cardIDEnum.DRG_300e:
  return new Sim_DRG_300e();
case CardDB.cardIDEnum.DRG_301:
  return new Sim_DRG_301();
case CardDB.cardIDEnum.DRG_302:
  return new Sim_DRG_302();
case CardDB.cardIDEnum.DRG_302e:
  return new Sim_DRG_302e();
case CardDB.cardIDEnum.DRG_303:
  return new Sim_DRG_303();
case CardDB.cardIDEnum.DRG_304:
  return new Sim_DRG_304();
case CardDB.cardIDEnum.DRG_306:
  return new Sim_DRG_306();
case CardDB.cardIDEnum.DRG_307:
  return new Sim_DRG_307();
case CardDB.cardIDEnum.DRG_308:
  return new Sim_DRG_308();
case CardDB.cardIDEnum.DRG_308e:
  return new Sim_DRG_308e();
case CardDB.cardIDEnum.DRG_309:
  return new Sim_DRG_309();
case CardDB.cardIDEnum.DRG_310:
  return new Sim_DRG_310();
case CardDB.cardIDEnum.DRG_311:
  return new Sim_DRG_311();
case CardDB.cardIDEnum.DRG_311a:
  return new Sim_DRG_311a();
case CardDB.cardIDEnum.DRG_311b:
  return new Sim_DRG_311b();
case CardDB.cardIDEnum.DRG_311e:
  return new Sim_DRG_311e();
case CardDB.cardIDEnum.DRG_311t:
  return new Sim_DRG_311t();
case CardDB.cardIDEnum.DRG_312:
  return new Sim_DRG_312();
case CardDB.cardIDEnum.DRG_313:
  return new Sim_DRG_313();
case CardDB.cardIDEnum.DRG_314:
  return new Sim_DRG_314();
case CardDB.cardIDEnum.DRG_315:
  return new Sim_DRG_315();
case CardDB.cardIDEnum.DRG_315e:
  return new Sim_DRG_315e();
case CardDB.cardIDEnum.DRG_315e2:
  return new Sim_DRG_315e2();
case CardDB.cardIDEnum.DRG_317:
  return new Sim_DRG_317();
case CardDB.cardIDEnum.DRG_318:
  return new Sim_DRG_318();
case CardDB.cardIDEnum.DRG_319:
  return new Sim_DRG_319();
case CardDB.cardIDEnum.DRG_319e4:
  return new Sim_DRG_319e4();
case CardDB.cardIDEnum.DRG_319e5:
  return new Sim_DRG_319e5();
case CardDB.cardIDEnum.DRG_320:
  return new Sim_DRG_320();
case CardDB.cardIDEnum.DRG_320t:
  return new Sim_DRG_320t();
case CardDB.cardIDEnum.DRG_321:
  return new Sim_DRG_321();
case CardDB.cardIDEnum.DRG_322:
  return new Sim_DRG_322();
case CardDB.cardIDEnum.DRG_322e:
  return new Sim_DRG_322e();
case CardDB.cardIDEnum.DRG_323:
  return new Sim_DRG_323();
case CardDB.cardIDEnum.DRG_323t:
  return new Sim_DRG_323t();
case CardDB.cardIDEnum.DRG_324:
  return new Sim_DRG_324();
case CardDB.cardIDEnum.DRG_401:
  return new Sim_DRG_401();
case CardDB.cardIDEnum.DRG_401d:
  return new Sim_DRG_401d();
case CardDB.cardIDEnum.DRG_401e:
  return new Sim_DRG_401e();
case CardDB.cardIDEnum.DRG_402:
  return new Sim_DRG_402();
case CardDB.cardIDEnum.DRG_403:
  return new Sim_DRG_403();
case CardDB.cardIDEnum.DRG_403e:
  return new Sim_DRG_403e();
case CardDB.cardIDEnum.DRG_500:
  return new Sim_DRG_500();
case CardDB.cardIDEnum.DRG_600:
  return new Sim_DRG_600();
case CardDB.cardIDEnum.DRG_600t2:
  return new Sim_DRG_600t2();
case CardDB.cardIDEnum.DRG_600t3:
  return new Sim_DRG_600t3();
case CardDB.cardIDEnum.DRG_610:
  return new Sim_DRG_610();
case CardDB.cardIDEnum.DRG_610e:
  return new Sim_DRG_610e();
case CardDB.cardIDEnum.DRG_610t2:
  return new Sim_DRG_610t2();
case CardDB.cardIDEnum.DRG_610t3:
  return new Sim_DRG_610t3();
case CardDB.cardIDEnum.DRG_620:
  return new Sim_DRG_620();
case CardDB.cardIDEnum.DRG_620t2:
  return new Sim_DRG_620t2();
case CardDB.cardIDEnum.DRG_620t3:
  return new Sim_DRG_620t3();
case CardDB.cardIDEnum.DRG_620t4:
  return new Sim_DRG_620t4();
case CardDB.cardIDEnum.DRG_620t5:
  return new Sim_DRG_620t5();
case CardDB.cardIDEnum.DRG_620t6:
  return new Sim_DRG_620t6();
case CardDB.cardIDEnum.DRG_650:
  return new Sim_DRG_650();
case CardDB.cardIDEnum.DRG_650e:
  return new Sim_DRG_650e();
case CardDB.cardIDEnum.DRG_650e2:
  return new Sim_DRG_650e2();
case CardDB.cardIDEnum.DRG_650e3:
  return new Sim_DRG_650e3();
case CardDB.cardIDEnum.DRG_650t2:
  return new Sim_DRG_650t2();
case CardDB.cardIDEnum.DRG_650t3:
  return new Sim_DRG_650t3();
case CardDB.cardIDEnum.DRG_660:
  return new Sim_DRG_660();
case CardDB.cardIDEnum.DRG_660t2:
  return new Sim_DRG_660t2();
case CardDB.cardIDEnum.DRG_660t3:
  return new Sim_DRG_660t3();
case CardDB.cardIDEnum.DS1h_292_H2:
  return new Sim_DS1h_292_H2();
case CardDB.cardIDEnum.DS1h_292_H3:
  return new Sim_DS1h_292_H3();
case CardDB.cardIDEnum.DS1h_292_H3_AT_132:
  return new Sim_DS1h_292_H3_AT_132();
case CardDB.cardIDEnum.HERO_01b:
  return new Sim_HERO_01b();
case CardDB.cardIDEnum.HERO_01c:
  return new Sim_HERO_01c();
case CardDB.cardIDEnum.HERO_02d:
  return new Sim_HERO_02d();
case CardDB.cardIDEnum.HERO_03b:
  return new Sim_HERO_03b();
case CardDB.cardIDEnum.HERO_04d:
  return new Sim_HERO_04d();
case CardDB.cardIDEnum.HERO_05b:
  return new Sim_HERO_05b();
case CardDB.cardIDEnum.HERO_05c:
  return new Sim_HERO_05c();
case CardDB.cardIDEnum.HERO_06c:
  return new Sim_HERO_06c();
case CardDB.cardIDEnum.HERO_06d:
  return new Sim_HERO_06d();
case CardDB.cardIDEnum.HERO_07c:
  return new Sim_HERO_07c();
case CardDB.cardIDEnum.HERO_08c:
  return new Sim_HERO_08c();
case CardDB.cardIDEnum.HERO_09c:
  return new Sim_HERO_09c();
case CardDB.cardIDEnum.TB_ArchivistEnch:
  return new Sim_TB_ArchivistEnch();
case CardDB.cardIDEnum.TB_ArchivistSpell:
  return new Sim_TB_ArchivistSpell();
case CardDB.cardIDEnum.TB_Bacon_Secrets_01:
  return new Sim_TB_Bacon_Secrets_01();
case CardDB.cardIDEnum.TB_Bacon_Secrets_02:
  return new Sim_TB_Bacon_Secrets_02();
case CardDB.cardIDEnum.TB_Bacon_Secrets_04:
  return new Sim_TB_Bacon_Secrets_04();
case CardDB.cardIDEnum.TB_Bacon_Secrets_05:
  return new Sim_TB_Bacon_Secrets_05();
case CardDB.cardIDEnum.TB_Bacon_Secrets_07:
  return new Sim_TB_Bacon_Secrets_07();
case CardDB.cardIDEnum.TB_Bacon_Secrets_08:
  return new Sim_TB_Bacon_Secrets_08();
case CardDB.cardIDEnum.TB_Bacon_Secrets_10:
  return new Sim_TB_Bacon_Secrets_10();
case CardDB.cardIDEnum.TB_Bacon_Secrets_11:
  return new Sim_TB_Bacon_Secrets_11();
case CardDB.cardIDEnum.TB_Bacon_Secrets_12:
  return new Sim_TB_Bacon_Secrets_12();
case CardDB.cardIDEnum.TB_BaconShop_1P_PlayerE:
  return new Sim_TB_BaconShop_1P_PlayerE();
case CardDB.cardIDEnum.TB_BaconShop_1p_Reroll_Button:
  return new Sim_TB_BaconShop_1p_Reroll_Button();
case CardDB.cardIDEnum.TB_BaconShop_3ofKindChecke:
  return new Sim_TB_BaconShop_3ofKindChecke();
case CardDB.cardIDEnum.TB_BaconShop_8P_PlayerE:
  return new Sim_TB_BaconShop_8P_PlayerE();
case CardDB.cardIDEnum.TB_BaconShop_8p_Reroll_Button:
  return new Sim_TB_BaconShop_8p_Reroll_Button();
case CardDB.cardIDEnum.TB_BaconShop_DragBuy:
  return new Sim_TB_BaconShop_DragBuy();
case CardDB.cardIDEnum.TB_BaconShop_DragSell:
  return new Sim_TB_BaconShop_DragSell();
case CardDB.cardIDEnum.TB_BaconShop_HERO_01:
  return new Sim_TB_BaconShop_HERO_01();
case CardDB.cardIDEnum.TB_BaconShop_HERO_10:
  return new Sim_TB_BaconShop_HERO_10();
case CardDB.cardIDEnum.TB_BaconShop_HERO_11:
  return new Sim_TB_BaconShop_HERO_11();
case CardDB.cardIDEnum.TB_BaconShop_HERO_12:
  return new Sim_TB_BaconShop_HERO_12();
case CardDB.cardIDEnum.TB_BaconShop_HERO_14:
  return new Sim_TB_BaconShop_HERO_14();
case CardDB.cardIDEnum.TB_BaconShop_HERO_15:
  return new Sim_TB_BaconShop_HERO_15();
case CardDB.cardIDEnum.TB_BaconShop_HERO_16:
  return new Sim_TB_BaconShop_HERO_16();
case CardDB.cardIDEnum.TB_BaconShop_HERO_17:
  return new Sim_TB_BaconShop_HERO_17();
case CardDB.cardIDEnum.TB_BaconShop_HERO_18:
  return new Sim_TB_BaconShop_HERO_18();
case CardDB.cardIDEnum.TB_BaconShop_HERO_19:
  return new Sim_TB_BaconShop_HERO_19();
case CardDB.cardIDEnum.TB_BaconShop_HERO_20:
  return new Sim_TB_BaconShop_HERO_20();
case CardDB.cardIDEnum.TB_BaconShop_HERO_21:
  return new Sim_TB_BaconShop_HERO_21();
case CardDB.cardIDEnum.TB_BaconShop_HERO_22:
  return new Sim_TB_BaconShop_HERO_22();
case CardDB.cardIDEnum.TB_BaconShop_HERO_23:
  return new Sim_TB_BaconShop_HERO_23();
case CardDB.cardIDEnum.TB_BaconShop_HERO_25:
  return new Sim_TB_BaconShop_HERO_25();
case CardDB.cardIDEnum.TB_BaconShop_HERO_27:
  return new Sim_TB_BaconShop_HERO_27();
case CardDB.cardIDEnum.TB_BaconShop_HERO_28:
  return new Sim_TB_BaconShop_HERO_28();
case CardDB.cardIDEnum.TB_BaconShop_HERO_30:
  return new Sim_TB_BaconShop_HERO_30();
case CardDB.cardIDEnum.TB_BaconShop_HERO_31:
  return new Sim_TB_BaconShop_HERO_31();
case CardDB.cardIDEnum.TB_BaconShop_HERO_33:
  return new Sim_TB_BaconShop_HERO_33();
case CardDB.cardIDEnum.TB_BaconShop_HERO_34:
  return new Sim_TB_BaconShop_HERO_34();
case CardDB.cardIDEnum.TB_BaconShop_HERO_35:
  return new Sim_TB_BaconShop_HERO_35();
case CardDB.cardIDEnum.TB_BaconShop_HERO_36:
  return new Sim_TB_BaconShop_HERO_36();
case CardDB.cardIDEnum.TB_BaconShop_HERO_37:
  return new Sim_TB_BaconShop_HERO_37();
case CardDB.cardIDEnum.TB_BaconShop_HERO_38:
  return new Sim_TB_BaconShop_HERO_38();
case CardDB.cardIDEnum.TB_BaconShop_HERO_39:
  return new Sim_TB_BaconShop_HERO_39();
case CardDB.cardIDEnum.TB_BaconShop_HERO_40:
  return new Sim_TB_BaconShop_HERO_40();
case CardDB.cardIDEnum.TB_BaconShop_HERO_42:
  return new Sim_TB_BaconShop_HERO_42();
case CardDB.cardIDEnum.TB_BaconShop_HERO_43:
  return new Sim_TB_BaconShop_HERO_43();
case CardDB.cardIDEnum.TB_BaconShop_HERO_44:
  return new Sim_TB_BaconShop_HERO_44();
case CardDB.cardIDEnum.TB_BaconShop_HERO_45:
  return new Sim_TB_BaconShop_HERO_45();
case CardDB.cardIDEnum.TB_BaconShop_HERO_KelThuzad:
  return new Sim_TB_BaconShop_HERO_KelThuzad();
case CardDB.cardIDEnum.TB_BaconShop_HERO_PH:
  return new Sim_TB_BaconShop_HERO_PH();
case CardDB.cardIDEnum.TB_BaconShop_HP_001:
  return new Sim_TB_BaconShop_HP_001();
case CardDB.cardIDEnum.TB_BaconShop_HP_001e:
  return new Sim_TB_BaconShop_HP_001e();
case CardDB.cardIDEnum.TB_BaconShop_HP_008:
  return new Sim_TB_BaconShop_HP_008();
case CardDB.cardIDEnum.TB_BaconShop_HP_008a:
  return new Sim_TB_BaconShop_HP_008a();
case CardDB.cardIDEnum.TB_BaconShop_HP_009:
  return new Sim_TB_BaconShop_HP_009();
case CardDB.cardIDEnum.TB_BaconShop_HP_010:
  return new Sim_TB_BaconShop_HP_010();
case CardDB.cardIDEnum.TB_BaconShop_HP_014:
  return new Sim_TB_BaconShop_HP_014();
case CardDB.cardIDEnum.TB_BaconShop_HP_014e:
  return new Sim_TB_BaconShop_HP_014e();
case CardDB.cardIDEnum.TB_BaconShop_HP_015:
  return new Sim_TB_BaconShop_HP_015();
case CardDB.cardIDEnum.TB_BaconShop_HP_015e:
  return new Sim_TB_BaconShop_HP_015e();
case CardDB.cardIDEnum.TB_BaconShop_HP_017:
  return new Sim_TB_BaconShop_HP_017();
case CardDB.cardIDEnum.TB_BaconShop_HP_017e:
  return new Sim_TB_BaconShop_HP_017e();
case CardDB.cardIDEnum.TB_BaconShop_HP_018:
  return new Sim_TB_BaconShop_HP_018();
case CardDB.cardIDEnum.TB_BaconShop_HP_018e2:
  return new Sim_TB_BaconShop_HP_018e2();
case CardDB.cardIDEnum.TB_BaconShop_HP_019:
  return new Sim_TB_BaconShop_HP_019();
case CardDB.cardIDEnum.TB_BaconShop_HP_020:
  return new Sim_TB_BaconShop_HP_020();
case CardDB.cardIDEnum.TB_BaconShop_HP_022:
  return new Sim_TB_BaconShop_HP_022();
case CardDB.cardIDEnum.TB_BaconShop_HP_022e:
  return new Sim_TB_BaconShop_HP_022e();
case CardDB.cardIDEnum.TB_BaconShop_HP_024:
  return new Sim_TB_BaconShop_HP_024();
case CardDB.cardIDEnum.TB_BaconShop_HP_024e2:
  return new Sim_TB_BaconShop_HP_024e2();
case CardDB.cardIDEnum.TB_BaconShop_HP_027:
  return new Sim_TB_BaconShop_HP_027();
case CardDB.cardIDEnum.TB_BaconShop_HP_028:
  return new Sim_TB_BaconShop_HP_028();
case CardDB.cardIDEnum.TB_BaconShop_HP_033:
  return new Sim_TB_BaconShop_HP_033();
case CardDB.cardIDEnum.TB_BaconShop_HP_033t:
  return new Sim_TB_BaconShop_HP_033t();
case CardDB.cardIDEnum.TB_BaconShop_HP_035:
  return new Sim_TB_BaconShop_HP_035();
case CardDB.cardIDEnum.TB_BaconShop_HP_036:
  return new Sim_TB_BaconShop_HP_036();
case CardDB.cardIDEnum.TB_BaconShop_HP_036e2:
  return new Sim_TB_BaconShop_HP_036e2();
case CardDB.cardIDEnum.TB_BaconShop_HP_037a:
  return new Sim_TB_BaconShop_HP_037a();
case CardDB.cardIDEnum.TB_BaconShop_HP_037te:
  return new Sim_TB_BaconShop_HP_037te();
case CardDB.cardIDEnum.TB_BaconShop_HP_038:
  return new Sim_TB_BaconShop_HP_038();
case CardDB.cardIDEnum.TB_BaconShop_HP_038t:
  return new Sim_TB_BaconShop_HP_038t();
case CardDB.cardIDEnum.TB_BaconShop_HP_038te:
  return new Sim_TB_BaconShop_HP_038te();
case CardDB.cardIDEnum.TB_BaconShop_HP_039:
  return new Sim_TB_BaconShop_HP_039();
case CardDB.cardIDEnum.TB_BaconShop_HP_039e:
  return new Sim_TB_BaconShop_HP_039e();
case CardDB.cardIDEnum.TB_BaconShop_HP_040:
  return new Sim_TB_BaconShop_HP_040();
case CardDB.cardIDEnum.TB_BaconShop_HP_040e:
  return new Sim_TB_BaconShop_HP_040e();
case CardDB.cardIDEnum.TB_BaconShop_HP_041a:
  return new Sim_TB_BaconShop_HP_041a();
case CardDB.cardIDEnum.TB_BaconShop_HP_041b:
  return new Sim_TB_BaconShop_HP_041b();
case CardDB.cardIDEnum.TB_BaconShop_HP_041c:
  return new Sim_TB_BaconShop_HP_041c();
case CardDB.cardIDEnum.TB_BaconShop_HP_041d:
  return new Sim_TB_BaconShop_HP_041d();
case CardDB.cardIDEnum.TB_BaconShop_HP_041e:
  return new Sim_TB_BaconShop_HP_041e();
case CardDB.cardIDEnum.TB_BaconShop_HP_042:
  return new Sim_TB_BaconShop_HP_042();
case CardDB.cardIDEnum.TB_BaconShop_HP_042e:
  return new Sim_TB_BaconShop_HP_042e();
case CardDB.cardIDEnum.TB_BaconShop_HP_043:
  return new Sim_TB_BaconShop_HP_043();
case CardDB.cardIDEnum.TB_BaconShop_HP_044:
  return new Sim_TB_BaconShop_HP_044();
case CardDB.cardIDEnum.TB_BaconShop_HP_045:
  return new Sim_TB_BaconShop_HP_045();
case CardDB.cardIDEnum.TB_BaconShop_HP_045e:
  return new Sim_TB_BaconShop_HP_045e();
case CardDB.cardIDEnum.TB_BaconShop_HP_047:
  return new Sim_TB_BaconShop_HP_047();
case CardDB.cardIDEnum.TB_BaconShop_HP_047t:
  return new Sim_TB_BaconShop_HP_047t();
case CardDB.cardIDEnum.TB_BaconShop_HP_048:
  return new Sim_TB_BaconShop_HP_048();
case CardDB.cardIDEnum.TB_BaconShop_HP_048e:
  return new Sim_TB_BaconShop_HP_048e();
case CardDB.cardIDEnum.TB_BaconShop_HP_049:
  return new Sim_TB_BaconShop_HP_049();
case CardDB.cardIDEnum.TB_BaconShop_HP_050:
  return new Sim_TB_BaconShop_HP_050();
case CardDB.cardIDEnum.TB_BaconShop_HP_050e:
  return new Sim_TB_BaconShop_HP_050e();
case CardDB.cardIDEnum.TB_BaconShop_HP_053:
  return new Sim_TB_BaconShop_HP_053();
case CardDB.cardIDEnum.TB_BaconShop_Triples_01:
  return new Sim_TB_BaconShop_Triples_01();
case CardDB.cardIDEnum.TB_BaconShopBadsongE:
  return new Sim_TB_BaconShopBadsongE();
case CardDB.cardIDEnum.TB_BaconShopBob:
  return new Sim_TB_BaconShopBob();
case CardDB.cardIDEnum.TB_BaconShopLockAll_Button:
  return new Sim_TB_BaconShopLockAll_Button();
case CardDB.cardIDEnum.TB_BaconShopTechUp02_Button:
  return new Sim_TB_BaconShopTechUp02_Button();
case CardDB.cardIDEnum.TB_BaconShopTechUp03_Button:
  return new Sim_TB_BaconShopTechUp03_Button();
case CardDB.cardIDEnum.TB_BaconShopTechUp04_Button:
  return new Sim_TB_BaconShopTechUp04_Button();
case CardDB.cardIDEnum.TB_BaconShopTechUp05_Button:
  return new Sim_TB_BaconShopTechUp05_Button();
case CardDB.cardIDEnum.TB_BaconShopTechUp06_Button:
  return new Sim_TB_BaconShopTechUp06_Button();
case CardDB.cardIDEnum.TB_BaconUps_002:
  return new Sim_TB_BaconUps_002();
case CardDB.cardIDEnum.TB_BaconUps_002t:
  return new Sim_TB_BaconUps_002t();
case CardDB.cardIDEnum.TB_BaconUps_003:
  return new Sim_TB_BaconUps_003();
case CardDB.cardIDEnum.TB_BaconUps_003t:
  return new Sim_TB_BaconUps_003t();
case CardDB.cardIDEnum.TB_BaconUps_004:
  return new Sim_TB_BaconUps_004();
case CardDB.cardIDEnum.TB_BaconUps_004t:
  return new Sim_TB_BaconUps_004t();
case CardDB.cardIDEnum.TB_BaconUps_006:
  return new Sim_TB_BaconUps_006();
case CardDB.cardIDEnum.TB_BaconUps_006t:
  return new Sim_TB_BaconUps_006t();
case CardDB.cardIDEnum.TB_BaconUps_008:
  return new Sim_TB_BaconUps_008();
case CardDB.cardIDEnum.TB_BaconUps_008e:
  return new Sim_TB_BaconUps_008e();
case CardDB.cardIDEnum.TB_BaconUps_009:
  return new Sim_TB_BaconUps_009();
case CardDB.cardIDEnum.TB_BaconUps_009e:
  return new Sim_TB_BaconUps_009e();
case CardDB.cardIDEnum.TB_BaconUps_011:
  return new Sim_TB_BaconUps_011();
case CardDB.cardIDEnum.TB_BaconUps_011e:
  return new Sim_TB_BaconUps_011e();
case CardDB.cardIDEnum.TB_BaconUps_014:
  return new Sim_TB_BaconUps_014();
case CardDB.cardIDEnum.TB_BaconUps_019:
  return new Sim_TB_BaconUps_019();
case CardDB.cardIDEnum.TB_BaconUps_025:
  return new Sim_TB_BaconUps_025();
case CardDB.cardIDEnum.TB_BaconUps_025e:
  return new Sim_TB_BaconUps_025e();
case CardDB.cardIDEnum.TB_BaconUps_026:
  return new Sim_TB_BaconUps_026();
case CardDB.cardIDEnum.TB_BaconUps_026t:
  return new Sim_TB_BaconUps_026t();
case CardDB.cardIDEnum.TB_BaconUps_027:
  return new Sim_TB_BaconUps_027();
case CardDB.cardIDEnum.TB_BaconUps_027t:
  return new Sim_TB_BaconUps_027t();
case CardDB.cardIDEnum.TB_BaconUps_028:
  return new Sim_TB_BaconUps_028();
case CardDB.cardIDEnum.TB_BaconUps_030:
  return new Sim_TB_BaconUps_030();
case CardDB.cardIDEnum.TB_BaconUps_030t:
  return new Sim_TB_BaconUps_030t();
case CardDB.cardIDEnum.TB_BaconUps_031:
  return new Sim_TB_BaconUps_031();
case CardDB.cardIDEnum.TB_BaconUps_031e:
  return new Sim_TB_BaconUps_031e();
case CardDB.cardIDEnum.TB_BaconUps_032:
  return new Sim_TB_BaconUps_032();
case CardDB.cardIDEnum.TB_BaconUps_032e:
  return new Sim_TB_BaconUps_032e();
case CardDB.cardIDEnum.TB_BaconUps_032t:
  return new Sim_TB_BaconUps_032t();
case CardDB.cardIDEnum.TB_BaconUps_033:
  return new Sim_TB_BaconUps_033();
case CardDB.cardIDEnum.TB_BaconUps_033e:
  return new Sim_TB_BaconUps_033e();
case CardDB.cardIDEnum.TB_BaconUps_034:
  return new Sim_TB_BaconUps_034();
case CardDB.cardIDEnum.TB_BaconUps_035:
  return new Sim_TB_BaconUps_035();
case CardDB.cardIDEnum.TB_BaconUps_036:
  return new Sim_TB_BaconUps_036();
case CardDB.cardIDEnum.TB_BaconUps_037:
  return new Sim_TB_BaconUps_037();
case CardDB.cardIDEnum.TB_BaconUps_037e:
  return new Sim_TB_BaconUps_037e();
case CardDB.cardIDEnum.TB_BaconUps_038:
  return new Sim_TB_BaconUps_038();
case CardDB.cardIDEnum.TB_BaconUps_038e:
  return new Sim_TB_BaconUps_038e();
case CardDB.cardIDEnum.TB_BaconUps_039:
  return new Sim_TB_BaconUps_039();
case CardDB.cardIDEnum.TB_BaconUps_039t:
  return new Sim_TB_BaconUps_039t();
case CardDB.cardIDEnum.TB_BaconUps_040:
  return new Sim_TB_BaconUps_040();
case CardDB.cardIDEnum.TB_BaconUps_040t:
  return new Sim_TB_BaconUps_040t();
case CardDB.cardIDEnum.TB_BaconUps_041:
  return new Sim_TB_BaconUps_041();
case CardDB.cardIDEnum.TB_BaconUps_041t:
  return new Sim_TB_BaconUps_041t();
case CardDB.cardIDEnum.TB_BaconUps_042:
  return new Sim_TB_BaconUps_042();
case CardDB.cardIDEnum.TB_BaconUps_043:
  return new Sim_TB_BaconUps_043();
case CardDB.cardIDEnum.TB_BaconUps_043e:
  return new Sim_TB_BaconUps_043e();
case CardDB.cardIDEnum.TB_BaconUps_044:
  return new Sim_TB_BaconUps_044();
case CardDB.cardIDEnum.TB_BaconUps_044e:
  return new Sim_TB_BaconUps_044e();
case CardDB.cardIDEnum.TB_BaconUps_045:
  return new Sim_TB_BaconUps_045();
case CardDB.cardIDEnum.TB_BaconUps_045e:
  return new Sim_TB_BaconUps_045e();
case CardDB.cardIDEnum.TB_BaconUps_046:
  return new Sim_TB_BaconUps_046();
case CardDB.cardIDEnum.TB_BaconUps_046e:
  return new Sim_TB_BaconUps_046e();
case CardDB.cardIDEnum.TB_BaconUps_047:
  return new Sim_TB_BaconUps_047();
case CardDB.cardIDEnum.TB_BaconUps_047e:
  return new Sim_TB_BaconUps_047e();
case CardDB.cardIDEnum.TB_BaconUps_049:
  return new Sim_TB_BaconUps_049();
case CardDB.cardIDEnum.TB_BaconUps_049t:
  return new Sim_TB_BaconUps_049t();
case CardDB.cardIDEnum.TB_BaconUps_050:
  return new Sim_TB_BaconUps_050();
case CardDB.cardIDEnum.TB_BaconUps_051:
  return new Sim_TB_BaconUps_051();
case CardDB.cardIDEnum.TB_BaconUps_051t:
  return new Sim_TB_BaconUps_051t();
case CardDB.cardIDEnum.TB_BaconUps_052:
  return new Sim_TB_BaconUps_052();
case CardDB.cardIDEnum.TB_BaconUps_052t:
  return new Sim_TB_BaconUps_052t();
case CardDB.cardIDEnum.TB_BaconUps_053:
  return new Sim_TB_BaconUps_053();
case CardDB.cardIDEnum.TB_BaconUps_053e:
  return new Sim_TB_BaconUps_053e();
case CardDB.cardIDEnum.TB_BaconUps_055:
  return new Sim_TB_BaconUps_055();
case CardDB.cardIDEnum.TB_Baconups_055e:
  return new Sim_TB_Baconups_055e();
case CardDB.cardIDEnum.TB_BaconUps_057:
  return new Sim_TB_BaconUps_057();
case CardDB.cardIDEnum.TB_BaconUps_058:
  return new Sim_TB_BaconUps_058();
case CardDB.cardIDEnum.TB_BaconUps_058e:
  return new Sim_TB_BaconUps_058e();
case CardDB.cardIDEnum.TB_BaconUps_059:
  return new Sim_TB_BaconUps_059();
case CardDB.cardIDEnum.TB_BaconUps_059t:
  return new Sim_TB_BaconUps_059t();
case CardDB.cardIDEnum.TB_BaconUps_060:
  return new Sim_TB_BaconUps_060();
case CardDB.cardIDEnum.TB_BaconUps_060e:
  return new Sim_TB_BaconUps_060e();
case CardDB.cardIDEnum.TB_BaconUps_061:
  return new Sim_TB_BaconUps_061();
case CardDB.cardIDEnum.TB_BaconUps_061e:
  return new Sim_TB_BaconUps_061e();
case CardDB.cardIDEnum.TB_BaconUps_062:
  return new Sim_TB_BaconUps_062();
case CardDB.cardIDEnum.TB_BaconUps_062e:
  return new Sim_TB_BaconUps_062e();
case CardDB.cardIDEnum.TB_BaconUps_063:
  return new Sim_TB_BaconUps_063();
case CardDB.cardIDEnum.TB_BaconUps_063e:
  return new Sim_TB_BaconUps_063e();
case CardDB.cardIDEnum.TB_BaconUps_064:
  return new Sim_TB_BaconUps_064();
case CardDB.cardIDEnum.TB_BaconUps_064e:
  return new Sim_TB_BaconUps_064e();
case CardDB.cardIDEnum.TB_BaconUps_066:
  return new Sim_TB_BaconUps_066();
case CardDB.cardIDEnum.TB_BaconUps_066e:
  return new Sim_TB_BaconUps_066e();
case CardDB.cardIDEnum.TB_BaconUps_068:
  return new Sim_TB_BaconUps_068();
case CardDB.cardIDEnum.TB_BaconUps_068e:
  return new Sim_TB_BaconUps_068e();
case CardDB.cardIDEnum.TB_BaconUps_069:
  return new Sim_TB_BaconUps_069();
case CardDB.cardIDEnum.TB_BaconUps_069e:
  return new Sim_TB_BaconUps_069e();
case CardDB.cardIDEnum.TB_BaconUps_070:
  return new Sim_TB_BaconUps_070();
case CardDB.cardIDEnum.TB_BaconUps_070e:
  return new Sim_TB_BaconUps_070e();
case CardDB.cardIDEnum.TB_BaconUps_072:
  return new Sim_TB_BaconUps_072();
case CardDB.cardIDEnum.TB_BaconUps_072e:
  return new Sim_TB_BaconUps_072e();
case CardDB.cardIDEnum.TB_BaconUps_073:
  return new Sim_TB_BaconUps_073();
case CardDB.cardIDEnum.TB_BaconUps_073e:
  return new Sim_TB_BaconUps_073e();
case CardDB.cardIDEnum.TB_BaconUps_074:
  return new Sim_TB_BaconUps_074();
case CardDB.cardIDEnum.TB_BaconUps_074e:
  return new Sim_TB_BaconUps_074e();
case CardDB.cardIDEnum.TB_BaconUps_075:
  return new Sim_TB_BaconUps_075();
case CardDB.cardIDEnum.TB_BaconUps_077:
  return new Sim_TB_BaconUps_077();
case CardDB.cardIDEnum.TB_BaconUps_077e:
  return new Sim_TB_BaconUps_077e();
case CardDB.cardIDEnum.TB_BaconUps_079:
  return new Sim_TB_BaconUps_079();
case CardDB.cardIDEnum.TB_BaconUps_079e:
  return new Sim_TB_BaconUps_079e();
case CardDB.cardIDEnum.TB_BaconUps_080:
  return new Sim_TB_BaconUps_080();
case CardDB.cardIDEnum.TB_BaconUps_082:
  return new Sim_TB_BaconUps_082();
case CardDB.cardIDEnum.TB_BaconUps_082e:
  return new Sim_TB_BaconUps_082e();
case CardDB.cardIDEnum.TB_BaconUps_083:
  return new Sim_TB_BaconUps_083();
case CardDB.cardIDEnum.TB_BaconUps_084:
  return new Sim_TB_BaconUps_084();
case CardDB.cardIDEnum.TB_BaconUps_085:
  return new Sim_TB_BaconUps_085();
case CardDB.cardIDEnum.TB_BaconUps_085e:
  return new Sim_TB_BaconUps_085e();
case CardDB.cardIDEnum.TB_BaconUps_086:
  return new Sim_TB_BaconUps_086();
case CardDB.cardIDEnum.TB_BaconUps_086e:
  return new Sim_TB_BaconUps_086e();
case CardDB.cardIDEnum.TB_BaconUps_087:
  return new Sim_TB_BaconUps_087();
case CardDB.cardIDEnum.TB_BaconUps_088:
  return new Sim_TB_BaconUps_088();
case CardDB.cardIDEnum.TB_BaconUps_088e:
  return new Sim_TB_BaconUps_088e();
case CardDB.cardIDEnum.TB_BaconUps_089:
  return new Sim_TB_BaconUps_089();
case CardDB.cardIDEnum.TB_BaconUps_090:
  return new Sim_TB_BaconUps_090();
case CardDB.cardIDEnum.TB_BaconUps_090e:
  return new Sim_TB_BaconUps_090e();
case CardDB.cardIDEnum.TB_BaconUps_093:
  return new Sim_TB_BaconUps_093();
case CardDB.cardIDEnum.TB_BaconUps_093t:
  return new Sim_TB_BaconUps_093t();
case CardDB.cardIDEnum.TB_BaconUps_094:
  return new Sim_TB_BaconUps_094();
case CardDB.cardIDEnum.TB_BaconUps_094e:
  return new Sim_TB_BaconUps_094e();
case CardDB.cardIDEnum.TB_BaconUps_095:
  return new Sim_TB_BaconUps_095();
case CardDB.cardIDEnum.TB_BaconUps_095e:
  return new Sim_TB_BaconUps_095e();
case CardDB.cardIDEnum.TB_BaconUps_099:
  return new Sim_TB_BaconUps_099();
case CardDB.cardIDEnum.TB_BaconUps_099e:
  return new Sim_TB_BaconUps_099e();
case CardDB.cardIDEnum.TB_BaconUps_100:
  return new Sim_TB_BaconUps_100();
case CardDB.cardIDEnum.TB_BaconUps_100e:
  return new Sim_TB_BaconUps_100e();
case CardDB.cardIDEnum.TB_BaconUps_101:
  return new Sim_TB_BaconUps_101();
case CardDB.cardIDEnum.TB_BaconUps_101e:
  return new Sim_TB_BaconUps_101e();
case CardDB.cardIDEnum.TB_BuildSeededDeck:
  return new Sim_TB_BuildSeededDeck();
case CardDB.cardIDEnum.TB_BuildStarterDeck:
  return new Sim_TB_BuildStarterDeck();
case CardDB.cardIDEnum.TB_Carousel_EnchA:
  return new Sim_TB_Carousel_EnchA();
case CardDB.cardIDEnum.TB_Carousel_EnchB:
  return new Sim_TB_Carousel_EnchB();
case CardDB.cardIDEnum.TB_Carousel_SpawnDreadSteed:
  return new Sim_TB_Carousel_SpawnDreadSteed();
case CardDB.cardIDEnum.TB_Carousel_SpellA:
  return new Sim_TB_Carousel_SpellA();
case CardDB.cardIDEnum.TB_Carousel_SpellB:
  return new Sim_TB_Carousel_SpellB();
case CardDB.cardIDEnum.TB_Champs_EX1_145:
  return new Sim_TB_Champs_EX1_145();
case CardDB.cardIDEnum.TB_Champs_EX1_145e:
  return new Sim_TB_Champs_EX1_145e();
case CardDB.cardIDEnum.TB_Champs_EX1_145o:
  return new Sim_TB_Champs_EX1_145o();
case CardDB.cardIDEnum.TB_DALA_Minion1e:
  return new Sim_TB_DALA_Minion1e();
case CardDB.cardIDEnum.TB_DALA_Minion3e:
  return new Sim_TB_DALA_Minion3e();
case CardDB.cardIDEnum.TB_DeathrattleYog_Copied:
  return new Sim_TB_DeathrattleYog_Copied();
case CardDB.cardIDEnum.TB_EVILBRM_RafaamHeroPower2:
  return new Sim_TB_EVILBRM_RafaamHeroPower2();
case CardDB.cardIDEnum.TB_HeadlessHorseman_H2d:
  return new Sim_TB_HeadlessHorseman_H2d();
case CardDB.cardIDEnum.TB_HeadlessHorseman_HP6:
  return new Sim_TB_HeadlessHorseman_HP6();
case CardDB.cardIDEnum.TB_HeadlessHorseman_s001d:
  return new Sim_TB_HeadlessHorseman_s001d();
case CardDB.cardIDEnum.TB_RoadToNR:
  return new Sim_TB_RoadToNR();
case CardDB.cardIDEnum.TB_RoadToNR_Bob:
  return new Sim_TB_RoadToNR_Bob();
case CardDB.cardIDEnum.TB_RoadToNR_Bookmaster:
  return new Sim_TB_RoadToNR_Bookmaster();
case CardDB.cardIDEnum.TB_RoadToNR_Brann:
  return new Sim_TB_RoadToNR_Brann();
case CardDB.cardIDEnum.TB_RoadToNR_DinoHP:
  return new Sim_TB_RoadToNR_DinoHP();
case CardDB.cardIDEnum.TB_RoadToNR_Elise:
  return new Sim_TB_RoadToNR_Elise();
case CardDB.cardIDEnum.TB_RoadToNR_EliseBoss:
  return new Sim_TB_RoadToNR_EliseBoss();
case CardDB.cardIDEnum.TB_RoadToNR_Finley:
  return new Sim_TB_RoadToNR_Finley();
case CardDB.cardIDEnum.TB_RoadToNR_Finley_HP:
  return new Sim_TB_RoadToNR_Finley_HP();
case CardDB.cardIDEnum.TB_RoadToNR_FinleyBoss:
  return new Sim_TB_RoadToNR_FinleyBoss();
case CardDB.cardIDEnum.TB_RoadToNR_GoHome:
  return new Sim_TB_RoadToNR_GoHome();
case CardDB.cardIDEnum.TB_RoadToNR_JunkHP:
  return new Sim_TB_RoadToNR_JunkHP();
case CardDB.cardIDEnum.TB_RoadToNR_Murgatha:
  return new Sim_TB_RoadToNR_Murgatha();
case CardDB.cardIDEnum.TB_RoadToNR_MurgathaHP:
  return new Sim_TB_RoadToNR_MurgathaHP();
case CardDB.cardIDEnum.TB_RoadToNR_OrgrimmarArmor:
  return new Sim_TB_RoadToNR_OrgrimmarArmor();
case CardDB.cardIDEnum.TB_RoadToNR_OrgrimmarGuard:
  return new Sim_TB_RoadToNR_OrgrimmarGuard();
case CardDB.cardIDEnum.TB_RoadToNR_OrgrimmarHP:
  return new Sim_TB_RoadToNR_OrgrimmarHP();
case CardDB.cardIDEnum.TB_RoadToNR_Reno:
  return new Sim_TB_RoadToNR_Reno();
case CardDB.cardIDEnum.TB_RoadToNR_RenoHP:
  return new Sim_TB_RoadToNR_RenoHP();
case CardDB.cardIDEnum.TB_RoadToNR_RenosJunk:
  return new Sim_TB_RoadToNR_RenosJunk();
case CardDB.cardIDEnum.TB_RoadToNR_TakNozwhisker:
  return new Sim_TB_RoadToNR_TakNozwhisker();
case CardDB.cardIDEnum.TB_RoadToNR_TakNozwhiskerHP:
  return new Sim_TB_RoadToNR_TakNozwhiskerHP();
case CardDB.cardIDEnum.TB_RoadToNR_UngoroDino:
  return new Sim_TB_RoadToNR_UngoroDino();
case CardDB.cardIDEnum.TB_RoadToNR_WhiteKing:
  return new Sim_TB_RoadToNR_WhiteKing();
case CardDB.cardIDEnum.TB_SPT_DALA_Boss0:
  return new Sim_TB_SPT_DALA_Boss0();
case CardDB.cardIDEnum.TB_SPT_DALA_Boss1:
  return new Sim_TB_SPT_DALA_Boss1();
case CardDB.cardIDEnum.TB_SPT_DALA_Boss2:
  return new Sim_TB_SPT_DALA_Boss2();
case CardDB.cardIDEnum.TB_SPT_DALA_BossHeroPower:
  return new Sim_TB_SPT_DALA_BossHeroPower();
case CardDB.cardIDEnum.TB_SPT_DALA_GiftEnch:
  return new Sim_TB_SPT_DALA_GiftEnch();
case CardDB.cardIDEnum.TB_SPT_DALA_GiftSpell:
  return new Sim_TB_SPT_DALA_GiftSpell();
case CardDB.cardIDEnum.TB_SPT_DALA_Minion1:
  return new Sim_TB_SPT_DALA_Minion1();
case CardDB.cardIDEnum.TB_SPT_DALA_Minion3:
  return new Sim_TB_SPT_DALA_Minion3();
case CardDB.cardIDEnum.TB_SPT_GiftMinion:
  return new Sim_TB_SPT_GiftMinion();
case CardDB.cardIDEnum.TB_TempleOutrun_Ammunae:
  return new Sim_TB_TempleOutrun_Ammunae();
case CardDB.cardIDEnum.TB_TempleOutrun_Battrund:
  return new Sim_TB_TempleOutrun_Battrund();
case CardDB.cardIDEnum.TB_TempleOutrun_BoomH:
  return new Sim_TB_TempleOutrun_BoomH();
case CardDB.cardIDEnum.TB_TempleOutrun_Brann:
  return new Sim_TB_TempleOutrun_Brann();
case CardDB.cardIDEnum.TB_TempleOutrun_Bucket1:
  return new Sim_TB_TempleOutrun_Bucket1();
case CardDB.cardIDEnum.TB_TempleOutrun_Colossus:
  return new Sim_TB_TempleOutrun_Colossus();
case CardDB.cardIDEnum.TB_TempleOutrun_DALA_719:
  return new Sim_TB_TempleOutrun_DALA_719();
case CardDB.cardIDEnum.TB_TempleOutrun_EC:
  return new Sim_TB_TempleOutrun_EC();
case CardDB.cardIDEnum.TB_TempleOutrun_ECe:
  return new Sim_TB_TempleOutrun_ECe();
case CardDB.cardIDEnum.TB_TempleOutrun_ECo:
  return new Sim_TB_TempleOutrun_ECo();
case CardDB.cardIDEnum.TB_TempleOutrun_ECov:
  return new Sim_TB_TempleOutrun_ECov();
case CardDB.cardIDEnum.TB_TempleOutrun_ECovo:
  return new Sim_TB_TempleOutrun_ECovo();
case CardDB.cardIDEnum.TB_TempleOutrun_Elise:
  return new Sim_TB_TempleOutrun_Elise();
case CardDB.cardIDEnum.TB_TempleOutrun_Finley:
  return new Sim_TB_TempleOutrun_Finley();
case CardDB.cardIDEnum.TB_TempleOutrun_Hagatha:
  return new Sim_TB_TempleOutrun_Hagatha();
case CardDB.cardIDEnum.TB_TempleOutrun_HHHead:
  return new Sim_TB_TempleOutrun_HHHead();
case CardDB.cardIDEnum.TB_TempleOutrun_HHnoHead:
  return new Sim_TB_TempleOutrun_HHnoHead();
case CardDB.cardIDEnum.TB_TempleOutrun_Ichabod:
  return new Sim_TB_TempleOutrun_Ichabod();
case CardDB.cardIDEnum.TB_TempleOutrun_Isiset:
  return new Sim_TB_TempleOutrun_Isiset();
case CardDB.cardIDEnum.TB_TempleOutrun_Jar:
  return new Sim_TB_TempleOutrun_Jar();
case CardDB.cardIDEnum.TB_TempleOutrun_Jythiros:
  return new Sim_TB_TempleOutrun_Jythiros();
case CardDB.cardIDEnum.TB_TempleOutrun_Kasmut:
  return new Sim_TB_TempleOutrun_Kasmut();
case CardDB.cardIDEnum.TB_TempleOutrun_Kham:
  return new Sim_TB_TempleOutrun_Kham();
case CardDB.cardIDEnum.TB_TempleOutrun_Lazul_HP:
  return new Sim_TB_TempleOutrun_Lazul_HP();
case CardDB.cardIDEnum.TB_TempleOutrun_Lazul_HP3:
  return new Sim_TB_TempleOutrun_Lazul_HP3();
case CardDB.cardIDEnum.TB_TempleOutrun_LazulH:
  return new Sim_TB_TempleOutrun_LazulH();
case CardDB.cardIDEnum.TB_TempleOutrun_Lender:
  return new Sim_TB_TempleOutrun_Lender();
case CardDB.cardIDEnum.TB_TempleOutrun_LichBazhial:
  return new Sim_TB_TempleOutrun_LichBazhial();
case CardDB.cardIDEnum.TB_TempleOutrun_Mirrors:
  return new Sim_TB_TempleOutrun_Mirrors();
case CardDB.cardIDEnum.TB_TempleOutrun_Octosari:
  return new Sim_TB_TempleOutrun_Octosari();
case CardDB.cardIDEnum.TB_TempleOutrun_Pillager:
  return new Sim_TB_TempleOutrun_Pillager();
case CardDB.cardIDEnum.TB_TempleOutrun_RafaamH:
  return new Sim_TB_TempleOutrun_RafaamH();
case CardDB.cardIDEnum.TB_TempleOutrun_Rajh:
  return new Sim_TB_TempleOutrun_Rajh();
case CardDB.cardIDEnum.TB_TempleOutrun_Reno:
  return new Sim_TB_TempleOutrun_Reno();
case CardDB.cardIDEnum.TB_TempleOutrun_Setesh:
  return new Sim_TB_TempleOutrun_Setesh();
case CardDB.cardIDEnum.TB_TempleOutrun_Sothis:
  return new Sim_TB_TempleOutrun_Sothis();
case CardDB.cardIDEnum.TB_TempleOutrun_Toggwaggle_HP:
  return new Sim_TB_TempleOutrun_Toggwaggle_HP();
case CardDB.cardIDEnum.TB_TempleOutrun_TogwaggleH:
  return new Sim_TB_TempleOutrun_TogwaggleH();
case CardDB.cardIDEnum.TB_TempleOutrun_TogwaggleHPe:
  return new Sim_TB_TempleOutrun_TogwaggleHPe();
case CardDB.cardIDEnum.TB_TempleOutrun_Toomba:
  return new Sim_TB_TempleOutrun_Toomba();
case CardDB.cardIDEnum.TB_TempleOutrun_TrapRoom:
  return new Sim_TB_TempleOutrun_TrapRoom();
case CardDB.cardIDEnum.TB_TempleOutrun_Treasure_Reno1:
  return new Sim_TB_TempleOutrun_Treasure_Reno1();
case CardDB.cardIDEnum.TB_TempleOutrun_Warrior_11:
  return new Sim_TB_TempleOutrun_Warrior_11();
case CardDB.cardIDEnum.TB_TempleOutrun_Zafarr:
  return new Sim_TB_TempleOutrun_Zafarr();
case CardDB.cardIDEnum.TB_TempleOutrun_Zaraam:
  return new Sim_TB_TempleOutrun_Zaraam();
case CardDB.cardIDEnum.TB_TempleOutrunHHorsema:
  return new Sim_TB_TempleOutrunHHorsema();
case CardDB.cardIDEnum.TB_TempleRun_BestFriendBuff:
  return new Sim_TB_TempleRun_BestFriendBuff();
case CardDB.cardIDEnum.TOT_204:
  return new Sim_TOT_204();
case CardDB.cardIDEnum.ULDA_001:
  return new Sim_ULDA_001();
case CardDB.cardIDEnum.ULDA_002:
  return new Sim_ULDA_002();
case CardDB.cardIDEnum.ULDA_003:
  return new Sim_ULDA_003();
case CardDB.cardIDEnum.ULDA_004:
  return new Sim_ULDA_004();
case CardDB.cardIDEnum.ULDA_004e:
  return new Sim_ULDA_004e();
case CardDB.cardIDEnum.ULDA_005:
  return new Sim_ULDA_005();
case CardDB.cardIDEnum.ULDA_005e:
  return new Sim_ULDA_005e();
case CardDB.cardIDEnum.ULDA_006:
  return new Sim_ULDA_006();
case CardDB.cardIDEnum.ULDA_007:
  return new Sim_ULDA_007();
case CardDB.cardIDEnum.ULDA_007e2:
  return new Sim_ULDA_007e2();
case CardDB.cardIDEnum.ULDA_008:
  return new Sim_ULDA_008();
case CardDB.cardIDEnum.ULDA_008t:
  return new Sim_ULDA_008t();
case CardDB.cardIDEnum.ULDA_009:
  return new Sim_ULDA_009();
case CardDB.cardIDEnum.ULDA_009e:
  return new Sim_ULDA_009e();
case CardDB.cardIDEnum.ULDA_010:
  return new Sim_ULDA_010();
case CardDB.cardIDEnum.ULDA_011:
  return new Sim_ULDA_011();
case CardDB.cardIDEnum.ULDA_012:
  return new Sim_ULDA_012();
case CardDB.cardIDEnum.ULDA_013:
  return new Sim_ULDA_013();
case CardDB.cardIDEnum.ULDA_014:
  return new Sim_ULDA_014();
case CardDB.cardIDEnum.ULDA_014d:
  return new Sim_ULDA_014d();
case CardDB.cardIDEnum.ULDA_014e:
  return new Sim_ULDA_014e();
case CardDB.cardIDEnum.ULDA_015:
  return new Sim_ULDA_015();
case CardDB.cardIDEnum.ULDA_016:
  return new Sim_ULDA_016();
case CardDB.cardIDEnum.ULDA_017:
  return new Sim_ULDA_017();
case CardDB.cardIDEnum.ULDA_018:
  return new Sim_ULDA_018();
case CardDB.cardIDEnum.ULDA_018e:
  return new Sim_ULDA_018e();
case CardDB.cardIDEnum.ULDA_019:
  return new Sim_ULDA_019();
case CardDB.cardIDEnum.ULDA_019e:
  return new Sim_ULDA_019e();
case CardDB.cardIDEnum.ULDA_020:
  return new Sim_ULDA_020();
case CardDB.cardIDEnum.ULDA_021:
  return new Sim_ULDA_021();
case CardDB.cardIDEnum.ULDA_022:
  return new Sim_ULDA_022();
case CardDB.cardIDEnum.ULDA_023:
  return new Sim_ULDA_023();
case CardDB.cardIDEnum.ULDA_023e:
  return new Sim_ULDA_023e();
case CardDB.cardIDEnum.ULDA_024:
  return new Sim_ULDA_024();
case CardDB.cardIDEnum.ULDA_024e:
  return new Sim_ULDA_024e();
case CardDB.cardIDEnum.ULDA_026:
  return new Sim_ULDA_026();
case CardDB.cardIDEnum.ULDA_030:
  return new Sim_ULDA_030();
case CardDB.cardIDEnum.ULDA_031:
  return new Sim_ULDA_031();
case CardDB.cardIDEnum.ULDA_032:
  return new Sim_ULDA_032();
case CardDB.cardIDEnum.ULDA_033:
  return new Sim_ULDA_033();
case CardDB.cardIDEnum.ULDA_034:
  return new Sim_ULDA_034();
case CardDB.cardIDEnum.ULDA_035:
  return new Sim_ULDA_035();
case CardDB.cardIDEnum.ULDA_035d:
  return new Sim_ULDA_035d();
case CardDB.cardIDEnum.ULDA_035e:
  return new Sim_ULDA_035e();
case CardDB.cardIDEnum.ULDA_035ts:
  return new Sim_ULDA_035ts();
case CardDB.cardIDEnum.ULDA_036:
  return new Sim_ULDA_036();
case CardDB.cardIDEnum.ULDA_036t:
  return new Sim_ULDA_036t();
case CardDB.cardIDEnum.ULDA_036ts:
  return new Sim_ULDA_036ts();
case CardDB.cardIDEnum.ULDA_038:
  return new Sim_ULDA_038();
case CardDB.cardIDEnum.ULDA_039:
  return new Sim_ULDA_039();
case CardDB.cardIDEnum.ULDA_040:
  return new Sim_ULDA_040();
case CardDB.cardIDEnum.ULDA_041:
  return new Sim_ULDA_041();
case CardDB.cardIDEnum.ULDA_041e:
  return new Sim_ULDA_041e();
case CardDB.cardIDEnum.ULDA_041e2:
  return new Sim_ULDA_041e2();
case CardDB.cardIDEnum.ULDA_041ts:
  return new Sim_ULDA_041ts();
case CardDB.cardIDEnum.ULDA_042:
  return new Sim_ULDA_042();
case CardDB.cardIDEnum.ULDA_042e:
  return new Sim_ULDA_042e();
case CardDB.cardIDEnum.ULDA_042e2:
  return new Sim_ULDA_042e2();
case CardDB.cardIDEnum.ULDA_043:
  return new Sim_ULDA_043();
case CardDB.cardIDEnum.ULDA_043e:
  return new Sim_ULDA_043e();
case CardDB.cardIDEnum.ULDA_044:
  return new Sim_ULDA_044();
case CardDB.cardIDEnum.ULDA_044e:
  return new Sim_ULDA_044e();
case CardDB.cardIDEnum.ULDA_045:
  return new Sim_ULDA_045();
case CardDB.cardIDEnum.ULDA_045t:
  return new Sim_ULDA_045t();
case CardDB.cardIDEnum.ULDA_046:
  return new Sim_ULDA_046();
case CardDB.cardIDEnum.ULDA_046e:
  return new Sim_ULDA_046e();
case CardDB.cardIDEnum.ULDA_046e2:
  return new Sim_ULDA_046e2();
case CardDB.cardIDEnum.ULDA_101:
  return new Sim_ULDA_101();
case CardDB.cardIDEnum.ULDA_101e:
  return new Sim_ULDA_101e();
case CardDB.cardIDEnum.ULDA_101e2:
  return new Sim_ULDA_101e2();
case CardDB.cardIDEnum.ULDA_102:
  return new Sim_ULDA_102();
case CardDB.cardIDEnum.ULDA_102e:
  return new Sim_ULDA_102e();
case CardDB.cardIDEnum.ULDA_103:
  return new Sim_ULDA_103();
case CardDB.cardIDEnum.ULDA_103e:
  return new Sim_ULDA_103e();
case CardDB.cardIDEnum.ULDA_103e2:
  return new Sim_ULDA_103e2();
case CardDB.cardIDEnum.ULDA_110:
  return new Sim_ULDA_110();
case CardDB.cardIDEnum.ULDA_111:
  return new Sim_ULDA_111();
case CardDB.cardIDEnum.ULDA_112:
  return new Sim_ULDA_112();
case CardDB.cardIDEnum.ULDA_113:
  return new Sim_ULDA_113();
case CardDB.cardIDEnum.ULDA_113e:
  return new Sim_ULDA_113e();
case CardDB.cardIDEnum.ULDA_114:
  return new Sim_ULDA_114();
case CardDB.cardIDEnum.ULDA_115:
  return new Sim_ULDA_115();
case CardDB.cardIDEnum.ULDA_116:
  return new Sim_ULDA_116();
case CardDB.cardIDEnum.ULDA_116e:
  return new Sim_ULDA_116e();
case CardDB.cardIDEnum.ULDA_117:
  return new Sim_ULDA_117();
case CardDB.cardIDEnum.ULDA_117e:
  return new Sim_ULDA_117e();
case CardDB.cardIDEnum.ULDA_118:
  return new Sim_ULDA_118();
case CardDB.cardIDEnum.ULDA_201:
  return new Sim_ULDA_201();
case CardDB.cardIDEnum.ULDA_202:
  return new Sim_ULDA_202();
case CardDB.cardIDEnum.ULDA_203:
  return new Sim_ULDA_203();
case CardDB.cardIDEnum.ULDA_203e:
  return new Sim_ULDA_203e();
case CardDB.cardIDEnum.ULDA_204:
  return new Sim_ULDA_204();
case CardDB.cardIDEnum.ULDA_205:
  return new Sim_ULDA_205();
case CardDB.cardIDEnum.ULDA_205d:
  return new Sim_ULDA_205d();
case CardDB.cardIDEnum.ULDA_205e:
  return new Sim_ULDA_205e();
case CardDB.cardIDEnum.ULDA_206:
  return new Sim_ULDA_206();
case CardDB.cardIDEnum.ULDA_207:
  return new Sim_ULDA_207();
case CardDB.cardIDEnum.ULDA_208:
  return new Sim_ULDA_208();
case CardDB.cardIDEnum.ULDA_208e:
  return new Sim_ULDA_208e();
case CardDB.cardIDEnum.ULDA_208e2:
  return new Sim_ULDA_208e2();
case CardDB.cardIDEnum.ULDA_208e3:
  return new Sim_ULDA_208e3();
case CardDB.cardIDEnum.ULDA_301:
  return new Sim_ULDA_301();
case CardDB.cardIDEnum.ULDA_302:
  return new Sim_ULDA_302();
case CardDB.cardIDEnum.ULDA_302e:
  return new Sim_ULDA_302e();
case CardDB.cardIDEnum.ULDA_303:
  return new Sim_ULDA_303();
case CardDB.cardIDEnum.ULDA_303e:
  return new Sim_ULDA_303e();
case CardDB.cardIDEnum.ULDA_304:
  return new Sim_ULDA_304();
case CardDB.cardIDEnum.ULDA_305:
  return new Sim_ULDA_305();
case CardDB.cardIDEnum.ULDA_306:
  return new Sim_ULDA_306();
case CardDB.cardIDEnum.ULDA_307:
  return new Sim_ULDA_307();
case CardDB.cardIDEnum.ULDA_307ts:
  return new Sim_ULDA_307ts();
case CardDB.cardIDEnum.ULDA_401:
  return new Sim_ULDA_401();
case CardDB.cardIDEnum.ULDA_402:
  return new Sim_ULDA_402();
case CardDB.cardIDEnum.ULDA_402d:
  return new Sim_ULDA_402d();
case CardDB.cardIDEnum.ULDA_402e:
  return new Sim_ULDA_402e();
case CardDB.cardIDEnum.ULDA_403:
  return new Sim_ULDA_403();
case CardDB.cardIDEnum.ULDA_403e:
  return new Sim_ULDA_403e();
case CardDB.cardIDEnum.ULDA_404:
  return new Sim_ULDA_404();
case CardDB.cardIDEnum.ULDA_405:
  return new Sim_ULDA_405();
case CardDB.cardIDEnum.ULDA_406:
  return new Sim_ULDA_406();
case CardDB.cardIDEnum.ULDA_406d:
  return new Sim_ULDA_406d();
case CardDB.cardIDEnum.ULDA_406e:
  return new Sim_ULDA_406e();
case CardDB.cardIDEnum.ULDA_406e2:
  return new Sim_ULDA_406e2();
case CardDB.cardIDEnum.ULDA_407:
  return new Sim_ULDA_407();
case CardDB.cardIDEnum.ULDA_501:
  return new Sim_ULDA_501();
case CardDB.cardIDEnum.ULDA_502:
  return new Sim_ULDA_502();
case CardDB.cardIDEnum.ULDA_502e:
  return new Sim_ULDA_502e();
case CardDB.cardIDEnum.ULDA_503:
  return new Sim_ULDA_503();
case CardDB.cardIDEnum.ULDA_504:
  return new Sim_ULDA_504();
case CardDB.cardIDEnum.ULDA_505:
  return new Sim_ULDA_505();
case CardDB.cardIDEnum.ULDA_505e:
  return new Sim_ULDA_505e();
case CardDB.cardIDEnum.ULDA_507:
  return new Sim_ULDA_507();
case CardDB.cardIDEnum.ULDA_508:
  return new Sim_ULDA_508();
case CardDB.cardIDEnum.ULDA_508e:
  return new Sim_ULDA_508e();
case CardDB.cardIDEnum.ULDA_508e2:
  return new Sim_ULDA_508e2();
case CardDB.cardIDEnum.ULDA_601:
  return new Sim_ULDA_601();
case CardDB.cardIDEnum.ULDA_602:
  return new Sim_ULDA_602();
case CardDB.cardIDEnum.ULDA_603:
  return new Sim_ULDA_603();
case CardDB.cardIDEnum.ULDA_603e:
  return new Sim_ULDA_603e();
case CardDB.cardIDEnum.ULDA_604:
  return new Sim_ULDA_604();
case CardDB.cardIDEnum.ULDA_605:
  return new Sim_ULDA_605();
case CardDB.cardIDEnum.ULDA_605e:
  return new Sim_ULDA_605e();
case CardDB.cardIDEnum.ULDA_606:
  return new Sim_ULDA_606();
case CardDB.cardIDEnum.ULDA_606e:
  return new Sim_ULDA_606e();
case CardDB.cardIDEnum.ULDA_607:
  return new Sim_ULDA_607();
case CardDB.cardIDEnum.ULDA_608:
  return new Sim_ULDA_608();
case CardDB.cardIDEnum.ULDA_701e2:
  return new Sim_ULDA_701e2();
case CardDB.cardIDEnum.ULDA_702:
  return new Sim_ULDA_702();
case CardDB.cardIDEnum.ULDA_702d:
  return new Sim_ULDA_702d();
case CardDB.cardIDEnum.ULDA_702e:
  return new Sim_ULDA_702e();
case CardDB.cardIDEnum.ULDA_703e2:
  return new Sim_ULDA_703e2();
case CardDB.cardIDEnum.ULDA_705:
  return new Sim_ULDA_705();
case CardDB.cardIDEnum.ULDA_705d:
  return new Sim_ULDA_705d();
case CardDB.cardIDEnum.ULDA_705e:
  return new Sim_ULDA_705e();
case CardDB.cardIDEnum.ULDA_706:
  return new Sim_ULDA_706();
case CardDB.cardIDEnum.ULDA_706e:
  return new Sim_ULDA_706e();
case CardDB.cardIDEnum.ULDA_707:
  return new Sim_ULDA_707();
case CardDB.cardIDEnum.ULDA_707d:
  return new Sim_ULDA_707d();
case CardDB.cardIDEnum.ULDA_707e:
  return new Sim_ULDA_707e();
case CardDB.cardIDEnum.ULDA_708:
  return new Sim_ULDA_708();
case CardDB.cardIDEnum.ULDA_708d:
  return new Sim_ULDA_708d();
case CardDB.cardIDEnum.ULDA_708e:
  return new Sim_ULDA_708e();
case CardDB.cardIDEnum.ULDA_708e2:
  return new Sim_ULDA_708e2();
case CardDB.cardIDEnum.ULDA_709:
  return new Sim_ULDA_709();
case CardDB.cardIDEnum.ULDA_709e:
  return new Sim_ULDA_709e();
case CardDB.cardIDEnum.ULDA_709e2:
  return new Sim_ULDA_709e2();
case CardDB.cardIDEnum.ULDA_710:
  return new Sim_ULDA_710();
case CardDB.cardIDEnum.ULDA_710e:
  return new Sim_ULDA_710e();
case CardDB.cardIDEnum.ULDA_710e2:
  return new Sim_ULDA_710e2();
case CardDB.cardIDEnum.ULDA_711:
  return new Sim_ULDA_711();
case CardDB.cardIDEnum.ULDA_711e:
  return new Sim_ULDA_711e();
case CardDB.cardIDEnum.ULDA_711e2:
  return new Sim_ULDA_711e2();
case CardDB.cardIDEnum.ULDA_712:
  return new Sim_ULDA_712();
case CardDB.cardIDEnum.ULDA_712d:
  return new Sim_ULDA_712d();
case CardDB.cardIDEnum.ULDA_712e:
  return new Sim_ULDA_712e();
case CardDB.cardIDEnum.ULDA_713:
  return new Sim_ULDA_713();
case CardDB.cardIDEnum.ULDA_713d:
  return new Sim_ULDA_713d();
case CardDB.cardIDEnum.ULDA_713e:
  return new Sim_ULDA_713e();
case CardDB.cardIDEnum.ULDA_714:
  return new Sim_ULDA_714();
case CardDB.cardIDEnum.ULDA_714e:
  return new Sim_ULDA_714e();
case CardDB.cardIDEnum.ULDA_715:
  return new Sim_ULDA_715();
case CardDB.cardIDEnum.ULDA_719:
  return new Sim_ULDA_719();
case CardDB.cardIDEnum.ULDA_720:
  return new Sim_ULDA_720();
case CardDB.cardIDEnum.ULDA_721:
  return new Sim_ULDA_721();
case CardDB.cardIDEnum.ULDA_721d:
  return new Sim_ULDA_721d();
case CardDB.cardIDEnum.ULDA_724:
  return new Sim_ULDA_724();
case CardDB.cardIDEnum.ULDA_724d:
  return new Sim_ULDA_724d();
case CardDB.cardIDEnum.ULDA_724e:
  return new Sim_ULDA_724e();
case CardDB.cardIDEnum.ULDA_729:
  return new Sim_ULDA_729();
case CardDB.cardIDEnum.ULDA_801:
  return new Sim_ULDA_801();
case CardDB.cardIDEnum.ULDA_801d:
  return new Sim_ULDA_801d();
case CardDB.cardIDEnum.ULDA_801e:
  return new Sim_ULDA_801e();
case CardDB.cardIDEnum.ULDA_801t:
  return new Sim_ULDA_801t();
case CardDB.cardIDEnum.ULDA_802:
  return new Sim_ULDA_802();
case CardDB.cardIDEnum.ULDA_802e:
  return new Sim_ULDA_802e();
case CardDB.cardIDEnum.ULDA_803:
  return new Sim_ULDA_803();
case CardDB.cardIDEnum.ULDA_803d:
  return new Sim_ULDA_803d();
case CardDB.cardIDEnum.ULDA_803e:
  return new Sim_ULDA_803e();
case CardDB.cardIDEnum.ULDA_803e2:
  return new Sim_ULDA_803e2();
case CardDB.cardIDEnum.ULDA_804:
  return new Sim_ULDA_804();
case CardDB.cardIDEnum.ULDA_804t:
  return new Sim_ULDA_804t();
case CardDB.cardIDEnum.ULDA_900:
  return new Sim_ULDA_900();
case CardDB.cardIDEnum.ULDA_901:
  return new Sim_ULDA_901();
case CardDB.cardIDEnum.ULDA_902:
  return new Sim_ULDA_902();
case CardDB.cardIDEnum.ULDA_903:
  return new Sim_ULDA_903();
case CardDB.cardIDEnum.ULDA_911:
  return new Sim_ULDA_911();
case CardDB.cardIDEnum.ULDA_912:
  return new Sim_ULDA_912();
case CardDB.cardIDEnum.ULDA_999e:
  return new Sim_ULDA_999e();
case CardDB.cardIDEnum.ULDA_BOSS_01e:
  return new Sim_ULDA_BOSS_01e();
case CardDB.cardIDEnum.ULDA_BOSS_01ex:
  return new Sim_ULDA_BOSS_01ex();
case CardDB.cardIDEnum.ULDA_BOSS_01h:
  return new Sim_ULDA_BOSS_01h();
case CardDB.cardIDEnum.ULDA_BOSS_01p:
  return new Sim_ULDA_BOSS_01p();
case CardDB.cardIDEnum.ULDA_BOSS_01px:
  return new Sim_ULDA_BOSS_01px();
case CardDB.cardIDEnum.ULDA_BOSS_02h:
  return new Sim_ULDA_BOSS_02h();
case CardDB.cardIDEnum.ULDA_BOSS_02p:
  return new Sim_ULDA_BOSS_02p();
case CardDB.cardIDEnum.ULDA_BOSS_02px:
  return new Sim_ULDA_BOSS_02px();
case CardDB.cardIDEnum.ULDA_BOSS_03e:
  return new Sim_ULDA_BOSS_03e();
case CardDB.cardIDEnum.ULDA_BOSS_03h:
  return new Sim_ULDA_BOSS_03h();
case CardDB.cardIDEnum.ULDA_BOSS_03p:
  return new Sim_ULDA_BOSS_03p();
case CardDB.cardIDEnum.ULDA_BOSS_04h:
  return new Sim_ULDA_BOSS_04h();
case CardDB.cardIDEnum.ULDA_BOSS_04p:
  return new Sim_ULDA_BOSS_04p();
case CardDB.cardIDEnum.ULDA_BOSS_04px:
  return new Sim_ULDA_BOSS_04px();
case CardDB.cardIDEnum.ULDA_BOSS_05e:
  return new Sim_ULDA_BOSS_05e();
case CardDB.cardIDEnum.ULDA_BOSS_05h:
  return new Sim_ULDA_BOSS_05h();
case CardDB.cardIDEnum.ULDA_BOSS_05p:
  return new Sim_ULDA_BOSS_05p();
case CardDB.cardIDEnum.ULDA_BOSS_06h:
  return new Sim_ULDA_BOSS_06h();
case CardDB.cardIDEnum.ULDA_BOSS_06p:
  return new Sim_ULDA_BOSS_06p();
case CardDB.cardIDEnum.ULDA_BOSS_07e:
  return new Sim_ULDA_BOSS_07e();
case CardDB.cardIDEnum.ULDA_BOSS_07h:
  return new Sim_ULDA_BOSS_07h();
case CardDB.cardIDEnum.ULDA_BOSS_07p:
  return new Sim_ULDA_BOSS_07p();
case CardDB.cardIDEnum.ULDA_BOSS_08h:
  return new Sim_ULDA_BOSS_08h();
case CardDB.cardIDEnum.ULDA_BOSS_08p:
  return new Sim_ULDA_BOSS_08p();
case CardDB.cardIDEnum.ULDA_BOSS_08px:
  return new Sim_ULDA_BOSS_08px();
case CardDB.cardIDEnum.ULDA_BOSS_09h:
  return new Sim_ULDA_BOSS_09h();
case CardDB.cardIDEnum.ULDA_BOSS_09p:
  return new Sim_ULDA_BOSS_09p();
case CardDB.cardIDEnum.ULDA_BOSS_10h:
  return new Sim_ULDA_BOSS_10h();
case CardDB.cardIDEnum.ULDA_BOSS_10p:
  return new Sim_ULDA_BOSS_10p();
case CardDB.cardIDEnum.ULDA_BOSS_11h:
  return new Sim_ULDA_BOSS_11h();
case CardDB.cardIDEnum.ULDA_BOSS_11p:
  return new Sim_ULDA_BOSS_11p();
case CardDB.cardIDEnum.ULDA_BOSS_12e:
  return new Sim_ULDA_BOSS_12e();
case CardDB.cardIDEnum.ULDA_BOSS_12h:
  return new Sim_ULDA_BOSS_12h();
case CardDB.cardIDEnum.ULDA_BOSS_12p:
  return new Sim_ULDA_BOSS_12p();
case CardDB.cardIDEnum.ULDA_BOSS_12px:
  return new Sim_ULDA_BOSS_12px();
case CardDB.cardIDEnum.ULDA_BOSS_13e:
  return new Sim_ULDA_BOSS_13e();
case CardDB.cardIDEnum.ULDA_BOSS_13h:
  return new Sim_ULDA_BOSS_13h();
case CardDB.cardIDEnum.ULDA_BOSS_13p:
  return new Sim_ULDA_BOSS_13p();
case CardDB.cardIDEnum.ULDA_BOSS_14e:
  return new Sim_ULDA_BOSS_14e();
case CardDB.cardIDEnum.ULDA_BOSS_14h:
  return new Sim_ULDA_BOSS_14h();
case CardDB.cardIDEnum.ULDA_BOSS_14p:
  return new Sim_ULDA_BOSS_14p();
case CardDB.cardIDEnum.ULDA_BOSS_15e:
  return new Sim_ULDA_BOSS_15e();
case CardDB.cardIDEnum.ULDA_BOSS_15h:
  return new Sim_ULDA_BOSS_15h();
case CardDB.cardIDEnum.ULDA_BOSS_15p:
  return new Sim_ULDA_BOSS_15p();
case CardDB.cardIDEnum.ULDA_BOSS_15px:
  return new Sim_ULDA_BOSS_15px();
case CardDB.cardIDEnum.ULDA_BOSS_16e:
  return new Sim_ULDA_BOSS_16e();
case CardDB.cardIDEnum.ULDA_BOSS_16h:
  return new Sim_ULDA_BOSS_16h();
case CardDB.cardIDEnum.ULDA_BOSS_16p:
  return new Sim_ULDA_BOSS_16p();
case CardDB.cardIDEnum.ULDA_BOSS_17e:
  return new Sim_ULDA_BOSS_17e();
case CardDB.cardIDEnum.ULDA_BOSS_17h:
  return new Sim_ULDA_BOSS_17h();
case CardDB.cardIDEnum.ULDA_BOSS_17p:
  return new Sim_ULDA_BOSS_17p();
case CardDB.cardIDEnum.ULDA_BOSS_17px:
  return new Sim_ULDA_BOSS_17px();
case CardDB.cardIDEnum.ULDA_BOSS_18e:
  return new Sim_ULDA_BOSS_18e();
case CardDB.cardIDEnum.ULDA_BOSS_18h:
  return new Sim_ULDA_BOSS_18h();
case CardDB.cardIDEnum.ULDA_BOSS_18p:
  return new Sim_ULDA_BOSS_18p();
case CardDB.cardIDEnum.ULDA_BOSS_18px:
  return new Sim_ULDA_BOSS_18px();
case CardDB.cardIDEnum.ULDA_BOSS_19h:
  return new Sim_ULDA_BOSS_19h();
case CardDB.cardIDEnum.ULDA_BOSS_19p:
  return new Sim_ULDA_BOSS_19p();
case CardDB.cardIDEnum.ULDA_BOSS_19px:
  return new Sim_ULDA_BOSS_19px();
case CardDB.cardIDEnum.ULDA_BOSS_20h:
  return new Sim_ULDA_BOSS_20h();
case CardDB.cardIDEnum.ULDA_BOSS_20p:
  return new Sim_ULDA_BOSS_20p();
case CardDB.cardIDEnum.ULDA_BOSS_21e:
  return new Sim_ULDA_BOSS_21e();
case CardDB.cardIDEnum.ULDA_BOSS_21h:
  return new Sim_ULDA_BOSS_21h();
case CardDB.cardIDEnum.ULDA_BOSS_21p:
  return new Sim_ULDA_BOSS_21p();
case CardDB.cardIDEnum.ULDA_BOSS_22h:
  return new Sim_ULDA_BOSS_22h();
case CardDB.cardIDEnum.ULDA_BOSS_22p:
  return new Sim_ULDA_BOSS_22p();
case CardDB.cardIDEnum.ULDA_BOSS_22px:
  return new Sim_ULDA_BOSS_22px();
case CardDB.cardIDEnum.ULDA_BOSS_23e:
  return new Sim_ULDA_BOSS_23e();
case CardDB.cardIDEnum.ULDA_BOSS_23h:
  return new Sim_ULDA_BOSS_23h();
case CardDB.cardIDEnum.ULDA_BOSS_23p:
  return new Sim_ULDA_BOSS_23p();
case CardDB.cardIDEnum.ULDA_BOSS_24h:
  return new Sim_ULDA_BOSS_24h();
case CardDB.cardIDEnum.ULDA_BOSS_24p:
  return new Sim_ULDA_BOSS_24p();
case CardDB.cardIDEnum.ULDA_BOSS_24px:
  return new Sim_ULDA_BOSS_24px();
case CardDB.cardIDEnum.ULDA_BOSS_25h:
  return new Sim_ULDA_BOSS_25h();
case CardDB.cardIDEnum.ULDA_BOSS_25p:
  return new Sim_ULDA_BOSS_25p();
case CardDB.cardIDEnum.ULDA_BOSS_26h:
  return new Sim_ULDA_BOSS_26h();
case CardDB.cardIDEnum.ULDA_BOSS_26p:
  return new Sim_ULDA_BOSS_26p();
case CardDB.cardIDEnum.ULDA_BOSS_27e:
  return new Sim_ULDA_BOSS_27e();
case CardDB.cardIDEnum.ULDA_BOSS_27h:
  return new Sim_ULDA_BOSS_27h();
case CardDB.cardIDEnum.ULDA_BOSS_27p:
  return new Sim_ULDA_BOSS_27p();
case CardDB.cardIDEnum.ULDA_BOSS_27px:
  return new Sim_ULDA_BOSS_27px();
case CardDB.cardIDEnum.ULDA_BOSS_28h:
  return new Sim_ULDA_BOSS_28h();
case CardDB.cardIDEnum.ULDA_BOSS_28p:
  return new Sim_ULDA_BOSS_28p();
case CardDB.cardIDEnum.ULDA_BOSS_29h:
  return new Sim_ULDA_BOSS_29h();
case CardDB.cardIDEnum.ULDA_BOSS_29p:
  return new Sim_ULDA_BOSS_29p();
case CardDB.cardIDEnum.ULDA_BOSS_30h:
  return new Sim_ULDA_BOSS_30h();
case CardDB.cardIDEnum.ULDA_BOSS_30p:
  return new Sim_ULDA_BOSS_30p();
case CardDB.cardIDEnum.ULDA_BOSS_31e1:
  return new Sim_ULDA_BOSS_31e1();
case CardDB.cardIDEnum.ULDA_BOSS_31h:
  return new Sim_ULDA_BOSS_31h();
case CardDB.cardIDEnum.ULDA_BOSS_31p:
  return new Sim_ULDA_BOSS_31p();
case CardDB.cardIDEnum.ULDA_BOSS_31px:
  return new Sim_ULDA_BOSS_31px();
case CardDB.cardIDEnum.ULDA_BOSS_32h:
  return new Sim_ULDA_BOSS_32h();
case CardDB.cardIDEnum.ULDA_BOSS_32p:
  return new Sim_ULDA_BOSS_32p();
case CardDB.cardIDEnum.ULDA_BOSS_33h:
  return new Sim_ULDA_BOSS_33h();
case CardDB.cardIDEnum.ULDA_BOSS_33p:
  return new Sim_ULDA_BOSS_33p();
case CardDB.cardIDEnum.ULDA_BOSS_34h:
  return new Sim_ULDA_BOSS_34h();
case CardDB.cardIDEnum.ULDA_BOSS_34p:
  return new Sim_ULDA_BOSS_34p();
case CardDB.cardIDEnum.ULDA_BOSS_35h:
  return new Sim_ULDA_BOSS_35h();
case CardDB.cardIDEnum.ULDA_BOSS_35p:
  return new Sim_ULDA_BOSS_35p();
case CardDB.cardIDEnum.ULDA_BOSS_36e:
  return new Sim_ULDA_BOSS_36e();
case CardDB.cardIDEnum.ULDA_BOSS_36ex:
  return new Sim_ULDA_BOSS_36ex();
case CardDB.cardIDEnum.ULDA_BOSS_36h:
  return new Sim_ULDA_BOSS_36h();
case CardDB.cardIDEnum.ULDA_BOSS_36p:
  return new Sim_ULDA_BOSS_36p();
case CardDB.cardIDEnum.ULDA_BOSS_36px:
  return new Sim_ULDA_BOSS_36px();
case CardDB.cardIDEnum.ULDA_BOSS_37h:
  return new Sim_ULDA_BOSS_37h();
case CardDB.cardIDEnum.ULDA_BOSS_37h2:
  return new Sim_ULDA_BOSS_37h2();
case CardDB.cardIDEnum.ULDA_BOSS_37h3:
  return new Sim_ULDA_BOSS_37h3();
case CardDB.cardIDEnum.ULDA_BOSS_37p1:
  return new Sim_ULDA_BOSS_37p1();
case CardDB.cardIDEnum.ULDA_BOSS_37p2:
  return new Sim_ULDA_BOSS_37p2();
case CardDB.cardIDEnum.ULDA_BOSS_37p3:
  return new Sim_ULDA_BOSS_37p3();
case CardDB.cardIDEnum.ULDA_BOSS_37px3:
  return new Sim_ULDA_BOSS_37px3();
case CardDB.cardIDEnum.ULDA_BOSS_37t:
  return new Sim_ULDA_BOSS_37t();
case CardDB.cardIDEnum.ULDA_BOSS_38h:
  return new Sim_ULDA_BOSS_38h();
case CardDB.cardIDEnum.ULDA_BOSS_38h2:
  return new Sim_ULDA_BOSS_38h2();
case CardDB.cardIDEnum.ULDA_BOSS_38h3:
  return new Sim_ULDA_BOSS_38h3();
case CardDB.cardIDEnum.ULDA_BOSS_38p1:
  return new Sim_ULDA_BOSS_38p1();
case CardDB.cardIDEnum.ULDA_BOSS_38p2:
  return new Sim_ULDA_BOSS_38p2();
case CardDB.cardIDEnum.ULDA_BOSS_38p2e1:
  return new Sim_ULDA_BOSS_38p2e1();
case CardDB.cardIDEnum.ULDA_BOSS_38p2e2:
  return new Sim_ULDA_BOSS_38p2e2();
case CardDB.cardIDEnum.ULDA_BOSS_38p2e3:
  return new Sim_ULDA_BOSS_38p2e3();
case CardDB.cardIDEnum.ULDA_BOSS_38p3:
  return new Sim_ULDA_BOSS_38p3();
case CardDB.cardIDEnum.ULDA_BOSS_38px1:
  return new Sim_ULDA_BOSS_38px1();
case CardDB.cardIDEnum.ULDA_BOSS_38px3:
  return new Sim_ULDA_BOSS_38px3();
case CardDB.cardIDEnum.ULDA_BOSS_39h:
  return new Sim_ULDA_BOSS_39h();
case CardDB.cardIDEnum.ULDA_BOSS_39h2:
  return new Sim_ULDA_BOSS_39h2();
case CardDB.cardIDEnum.ULDA_BOSS_39h3:
  return new Sim_ULDA_BOSS_39h3();
case CardDB.cardIDEnum.ULDA_BOSS_39m:
  return new Sim_ULDA_BOSS_39m();
case CardDB.cardIDEnum.ULDA_BOSS_39me:
  return new Sim_ULDA_BOSS_39me();
case CardDB.cardIDEnum.ULDA_BOSS_39p1:
  return new Sim_ULDA_BOSS_39p1();
case CardDB.cardIDEnum.ULDA_BOSS_39p2:
  return new Sim_ULDA_BOSS_39p2();
case CardDB.cardIDEnum.ULDA_BOSS_39p3:
  return new Sim_ULDA_BOSS_39p3();
case CardDB.cardIDEnum.ULDA_BOSS_39px2:
  return new Sim_ULDA_BOSS_39px2();
case CardDB.cardIDEnum.ULDA_BOSS_39px3:
  return new Sim_ULDA_BOSS_39px3();
case CardDB.cardIDEnum.ULDA_BOSS_40h:
  return new Sim_ULDA_BOSS_40h();
case CardDB.cardIDEnum.ULDA_BOSS_40h2:
  return new Sim_ULDA_BOSS_40h2();
case CardDB.cardIDEnum.ULDA_BOSS_40h3:
  return new Sim_ULDA_BOSS_40h3();
case CardDB.cardIDEnum.ULDA_BOSS_40p1:
  return new Sim_ULDA_BOSS_40p1();
case CardDB.cardIDEnum.ULDA_BOSS_40p1e1:
  return new Sim_ULDA_BOSS_40p1e1();
case CardDB.cardIDEnum.ULDA_BOSS_40p2:
  return new Sim_ULDA_BOSS_40p2();
case CardDB.cardIDEnum.ULDA_BOSS_40p3:
  return new Sim_ULDA_BOSS_40p3();
case CardDB.cardIDEnum.ULDA_BOSS_40p3e:
  return new Sim_ULDA_BOSS_40p3e();
case CardDB.cardIDEnum.ULDA_BOSS_40px2:
  return new Sim_ULDA_BOSS_40px2();
case CardDB.cardIDEnum.ULDA_BOSS_41h:
  return new Sim_ULDA_BOSS_41h();
case CardDB.cardIDEnum.ULDA_BOSS_41p:
  return new Sim_ULDA_BOSS_41p();
case CardDB.cardIDEnum.ULDA_BOSS_41px:
  return new Sim_ULDA_BOSS_41px();
case CardDB.cardIDEnum.ULDA_BOSS_42d:
  return new Sim_ULDA_BOSS_42d();
case CardDB.cardIDEnum.ULDA_BOSS_42e:
  return new Sim_ULDA_BOSS_42e();
case CardDB.cardIDEnum.ULDA_BOSS_42e2:
  return new Sim_ULDA_BOSS_42e2();
case CardDB.cardIDEnum.ULDA_BOSS_42e3:
  return new Sim_ULDA_BOSS_42e3();
case CardDB.cardIDEnum.ULDA_BOSS_42h:
  return new Sim_ULDA_BOSS_42h();
case CardDB.cardIDEnum.ULDA_BOSS_42p:
  return new Sim_ULDA_BOSS_42p();
case CardDB.cardIDEnum.ULDA_BOSS_42px:
  return new Sim_ULDA_BOSS_42px();
case CardDB.cardIDEnum.ULDA_BOSS_43e1:
  return new Sim_ULDA_BOSS_43e1();
case CardDB.cardIDEnum.ULDA_BOSS_43h:
  return new Sim_ULDA_BOSS_43h();
case CardDB.cardIDEnum.ULDA_BOSS_43p:
  return new Sim_ULDA_BOSS_43p();
case CardDB.cardIDEnum.ULDA_BOSS_43px:
  return new Sim_ULDA_BOSS_43px();
case CardDB.cardIDEnum.ULDA_BOSS_44h:
  return new Sim_ULDA_BOSS_44h();
case CardDB.cardIDEnum.ULDA_BOSS_44p:
  return new Sim_ULDA_BOSS_44p();
case CardDB.cardIDEnum.ULDA_BOSS_44px:
  return new Sim_ULDA_BOSS_44px();
case CardDB.cardIDEnum.ULDA_BOSS_45h:
  return new Sim_ULDA_BOSS_45h();
case CardDB.cardIDEnum.ULDA_BOSS_45p:
  return new Sim_ULDA_BOSS_45p();
case CardDB.cardIDEnum.ULDA_BOSS_46h:
  return new Sim_ULDA_BOSS_46h();
case CardDB.cardIDEnum.ULDA_BOSS_46p:
  return new Sim_ULDA_BOSS_46p();
case CardDB.cardIDEnum.ULDA_BOSS_47e:
  return new Sim_ULDA_BOSS_47e();
case CardDB.cardIDEnum.ULDA_BOSS_47h:
  return new Sim_ULDA_BOSS_47h();
case CardDB.cardIDEnum.ULDA_BOSS_47p:
  return new Sim_ULDA_BOSS_47p();
case CardDB.cardIDEnum.ULDA_BOSS_48h:
  return new Sim_ULDA_BOSS_48h();
case CardDB.cardIDEnum.ULDA_BOSS_48p:
  return new Sim_ULDA_BOSS_48p();
case CardDB.cardIDEnum.ULDA_BOSS_49h:
  return new Sim_ULDA_BOSS_49h();
case CardDB.cardIDEnum.ULDA_BOSS_49p:
  return new Sim_ULDA_BOSS_49p();
case CardDB.cardIDEnum.ULDA_BOSS_49px:
  return new Sim_ULDA_BOSS_49px();
case CardDB.cardIDEnum.ULDA_BOSS_50h:
  return new Sim_ULDA_BOSS_50h();
case CardDB.cardIDEnum.ULDA_BOSS_50p:
  return new Sim_ULDA_BOSS_50p();
case CardDB.cardIDEnum.ULDA_BOSS_51h:
  return new Sim_ULDA_BOSS_51h();
case CardDB.cardIDEnum.ULDA_BOSS_51p:
  return new Sim_ULDA_BOSS_51p();
case CardDB.cardIDEnum.ULDA_BOSS_52h:
  return new Sim_ULDA_BOSS_52h();
case CardDB.cardIDEnum.ULDA_BOSS_52p1:
  return new Sim_ULDA_BOSS_52p1();
case CardDB.cardIDEnum.ULDA_BOSS_52p2:
  return new Sim_ULDA_BOSS_52p2();
case CardDB.cardIDEnum.ULDA_BOSS_53h:
  return new Sim_ULDA_BOSS_53h();
case CardDB.cardIDEnum.ULDA_BOSS_53p:
  return new Sim_ULDA_BOSS_53p();
case CardDB.cardIDEnum.ULDA_BOSS_53px:
  return new Sim_ULDA_BOSS_53px();
case CardDB.cardIDEnum.ULDA_BOSS_54e:
  return new Sim_ULDA_BOSS_54e();
case CardDB.cardIDEnum.ULDA_BOSS_54h:
  return new Sim_ULDA_BOSS_54h();
case CardDB.cardIDEnum.ULDA_BOSS_54p:
  return new Sim_ULDA_BOSS_54p();
case CardDB.cardIDEnum.ULDA_BOSS_55h:
  return new Sim_ULDA_BOSS_55h();
case CardDB.cardIDEnum.ULDA_BOSS_55p:
  return new Sim_ULDA_BOSS_55p();
case CardDB.cardIDEnum.ULDA_BOSS_56e:
  return new Sim_ULDA_BOSS_56e();
case CardDB.cardIDEnum.ULDA_BOSS_56h:
  return new Sim_ULDA_BOSS_56h();
case CardDB.cardIDEnum.ULDA_BOSS_56p:
  return new Sim_ULDA_BOSS_56p();
case CardDB.cardIDEnum.ULDA_BOSS_57e:
  return new Sim_ULDA_BOSS_57e();
case CardDB.cardIDEnum.ULDA_BOSS_57h:
  return new Sim_ULDA_BOSS_57h();
case CardDB.cardIDEnum.ULDA_BOSS_57p:
  return new Sim_ULDA_BOSS_57p();
case CardDB.cardIDEnum.ULDA_BOSS_57px:
  return new Sim_ULDA_BOSS_57px();
case CardDB.cardIDEnum.ULDA_BOSS_58e:
  return new Sim_ULDA_BOSS_58e();
case CardDB.cardIDEnum.ULDA_BOSS_58h:
  return new Sim_ULDA_BOSS_58h();
case CardDB.cardIDEnum.ULDA_BOSS_58p:
  return new Sim_ULDA_BOSS_58p();
case CardDB.cardIDEnum.ULDA_BOSS_59h:
  return new Sim_ULDA_BOSS_59h();
case CardDB.cardIDEnum.ULDA_BOSS_59p:
  return new Sim_ULDA_BOSS_59p();
case CardDB.cardIDEnum.ULDA_BOSS_59px:
  return new Sim_ULDA_BOSS_59px();
case CardDB.cardIDEnum.ULDA_BOSS_60h:
  return new Sim_ULDA_BOSS_60h();
case CardDB.cardIDEnum.ULDA_BOSS_60p:
  return new Sim_ULDA_BOSS_60p();
case CardDB.cardIDEnum.ULDA_BOSS_60px:
  return new Sim_ULDA_BOSS_60px();
case CardDB.cardIDEnum.ULDA_BOSS_61h:
  return new Sim_ULDA_BOSS_61h();
case CardDB.cardIDEnum.ULDA_BOSS_61p:
  return new Sim_ULDA_BOSS_61p();
case CardDB.cardIDEnum.ULDA_BOSS_61px:
  return new Sim_ULDA_BOSS_61px();
case CardDB.cardIDEnum.ULDA_BOSS_62h:
  return new Sim_ULDA_BOSS_62h();
case CardDB.cardIDEnum.ULDA_BOSS_62p:
  return new Sim_ULDA_BOSS_62p();
case CardDB.cardIDEnum.ULDA_BOSS_63h:
  return new Sim_ULDA_BOSS_63h();
case CardDB.cardIDEnum.ULDA_BOSS_63p:
  return new Sim_ULDA_BOSS_63p();
case CardDB.cardIDEnum.ULDA_BOSS_65h:
  return new Sim_ULDA_BOSS_65h();
case CardDB.cardIDEnum.ULDA_BOSS_65p:
  return new Sim_ULDA_BOSS_65p();
case CardDB.cardIDEnum.ULDA_BOSS_65px:
  return new Sim_ULDA_BOSS_65px();
case CardDB.cardIDEnum.ULDA_BOSS_66h:
  return new Sim_ULDA_BOSS_66h();
case CardDB.cardIDEnum.ULDA_BOSS_66p:
  return new Sim_ULDA_BOSS_66p();
case CardDB.cardIDEnum.ULDA_BOSS_66px:
  return new Sim_ULDA_BOSS_66px();
case CardDB.cardIDEnum.ULDA_BOSS_67d:
  return new Sim_ULDA_BOSS_67d();
case CardDB.cardIDEnum.ULDA_BOSS_67e2:
  return new Sim_ULDA_BOSS_67e2();
case CardDB.cardIDEnum.ULDA_BOSS_67e3:
  return new Sim_ULDA_BOSS_67e3();
case CardDB.cardIDEnum.ULDA_BOSS_67h:
  return new Sim_ULDA_BOSS_67h();
case CardDB.cardIDEnum.ULDA_BOSS_67p1:
  return new Sim_ULDA_BOSS_67p1();
case CardDB.cardIDEnum.ULDA_BOSS_67p2:
  return new Sim_ULDA_BOSS_67p2();
case CardDB.cardIDEnum.ULDA_BOSS_67p2e:
  return new Sim_ULDA_BOSS_67p2e();
case CardDB.cardIDEnum.ULDA_BOSS_67p3:
  return new Sim_ULDA_BOSS_67p3();
case CardDB.cardIDEnum.ULDA_BOSS_67t:
  return new Sim_ULDA_BOSS_67t();
case CardDB.cardIDEnum.ULDA_BOSS_68h:
  return new Sim_ULDA_BOSS_68h();
case CardDB.cardIDEnum.ULDA_BOSS_68p:
  return new Sim_ULDA_BOSS_68p();
case CardDB.cardIDEnum.ULDA_BOSS_69h:
  return new Sim_ULDA_BOSS_69h();
case CardDB.cardIDEnum.ULDA_BOSS_69p:
  return new Sim_ULDA_BOSS_69p();
case CardDB.cardIDEnum.ULDA_BOSS_70e:
  return new Sim_ULDA_BOSS_70e();
case CardDB.cardIDEnum.ULDA_BOSS_70h:
  return new Sim_ULDA_BOSS_70h();
case CardDB.cardIDEnum.ULDA_BOSS_70p:
  return new Sim_ULDA_BOSS_70p();
case CardDB.cardIDEnum.ULDA_BOSS_70px:
  return new Sim_ULDA_BOSS_70px();
case CardDB.cardIDEnum.ULDA_BOSS_71e:
  return new Sim_ULDA_BOSS_71e();
case CardDB.cardIDEnum.ULDA_BOSS_71h:
  return new Sim_ULDA_BOSS_71h();
case CardDB.cardIDEnum.ULDA_BOSS_71p:
  return new Sim_ULDA_BOSS_71p();
case CardDB.cardIDEnum.ULDA_BOSS_71px:
  return new Sim_ULDA_BOSS_71px();
case CardDB.cardIDEnum.ULDA_BOSS_72e:
  return new Sim_ULDA_BOSS_72e();
case CardDB.cardIDEnum.ULDA_BOSS_72ex:
  return new Sim_ULDA_BOSS_72ex();
case CardDB.cardIDEnum.ULDA_BOSS_72h:
  return new Sim_ULDA_BOSS_72h();
case CardDB.cardIDEnum.ULDA_BOSS_72p:
  return new Sim_ULDA_BOSS_72p();
case CardDB.cardIDEnum.ULDA_BOSS_73e:
  return new Sim_ULDA_BOSS_73e();
case CardDB.cardIDEnum.ULDA_BOSS_73h:
  return new Sim_ULDA_BOSS_73h();
case CardDB.cardIDEnum.ULDA_BOSS_73p:
  return new Sim_ULDA_BOSS_73p();
case CardDB.cardIDEnum.ULDA_BOSS_74h:
  return new Sim_ULDA_BOSS_74h();
case CardDB.cardIDEnum.ULDA_BOSS_74p:
  return new Sim_ULDA_BOSS_74p();
case CardDB.cardIDEnum.ULDA_BOSS_74px:
  return new Sim_ULDA_BOSS_74px();
case CardDB.cardIDEnum.ULDA_BOSS_75h:
  return new Sim_ULDA_BOSS_75h();
case CardDB.cardIDEnum.ULDA_BOSS_75p:
  return new Sim_ULDA_BOSS_75p();
case CardDB.cardIDEnum.ULDA_BOSS_75px:
  return new Sim_ULDA_BOSS_75px();
case CardDB.cardIDEnum.ULDA_BOSS_76h:
  return new Sim_ULDA_BOSS_76h();
case CardDB.cardIDEnum.ULDA_BOSS_76p:
  return new Sim_ULDA_BOSS_76p();
case CardDB.cardIDEnum.ULDA_BOSS_76px:
  return new Sim_ULDA_BOSS_76px();
case CardDB.cardIDEnum.ULDA_BOSS_77e:
  return new Sim_ULDA_BOSS_77e();
case CardDB.cardIDEnum.ULDA_BOSS_77h:
  return new Sim_ULDA_BOSS_77h();
case CardDB.cardIDEnum.ULDA_BOSS_77p:
  return new Sim_ULDA_BOSS_77p();
case CardDB.cardIDEnum.ULDA_BOSS_77px:
  return new Sim_ULDA_BOSS_77px();
case CardDB.cardIDEnum.ULDA_BOSS_78h:
  return new Sim_ULDA_BOSS_78h();
case CardDB.cardIDEnum.ULDA_BOSS_78p:
  return new Sim_ULDA_BOSS_78p();
case CardDB.cardIDEnum.ULDA_BOSS_79e:
  return new Sim_ULDA_BOSS_79e();
case CardDB.cardIDEnum.ULDA_BOSS_79h:
  return new Sim_ULDA_BOSS_79h();
case CardDB.cardIDEnum.ULDA_BOSS_79p:
  return new Sim_ULDA_BOSS_79p();
case CardDB.cardIDEnum.ULDA_BOSS_99h:
  return new Sim_ULDA_BOSS_99h();
case CardDB.cardIDEnum.ULDA_Brann:
  return new Sim_ULDA_Brann();
case CardDB.cardIDEnum.ULDA_Brann_01:
  return new Sim_ULDA_Brann_01();
case CardDB.cardIDEnum.ULDA_Brann_02:
  return new Sim_ULDA_Brann_02();
case CardDB.cardIDEnum.ULDA_Brann_03:
  return new Sim_ULDA_Brann_03();
case CardDB.cardIDEnum.ULDA_Brann_04:
  return new Sim_ULDA_Brann_04();
case CardDB.cardIDEnum.ULDA_Brann_05:
  return new Sim_ULDA_Brann_05();
case CardDB.cardIDEnum.ULDA_Brann_06:
  return new Sim_ULDA_Brann_06();
case CardDB.cardIDEnum.ULDA_Brann_07:
  return new Sim_ULDA_Brann_07();
case CardDB.cardIDEnum.ULDA_Brann_08:
  return new Sim_ULDA_Brann_08();
case CardDB.cardIDEnum.ULDA_Brann_09:
  return new Sim_ULDA_Brann_09();
case CardDB.cardIDEnum.ULDA_Brann_10:
  return new Sim_ULDA_Brann_10();
case CardDB.cardIDEnum.ULDA_Brann_11:
  return new Sim_ULDA_Brann_11();
case CardDB.cardIDEnum.ULDA_Brann_12:
  return new Sim_ULDA_Brann_12();
case CardDB.cardIDEnum.ULDA_Brann_13:
  return new Sim_ULDA_Brann_13();
case CardDB.cardIDEnum.ULDA_Brann_14:
  return new Sim_ULDA_Brann_14();
case CardDB.cardIDEnum.ULDA_Brann_15:
  return new Sim_ULDA_Brann_15();
case CardDB.cardIDEnum.ULDA_Brann_16:
  return new Sim_ULDA_Brann_16();
case CardDB.cardIDEnum.ULDA_Brann_17:
  return new Sim_ULDA_Brann_17();
case CardDB.cardIDEnum.ULDA_Brann_18:
  return new Sim_ULDA_Brann_18();
case CardDB.cardIDEnum.ULDA_Brann_19:
  return new Sim_ULDA_Brann_19();
case CardDB.cardIDEnum.ULDA_Brann_20:
  return new Sim_ULDA_Brann_20();
case CardDB.cardIDEnum.ULDA_Brann_21:
  return new Sim_ULDA_Brann_21();
case CardDB.cardIDEnum.ULDA_Brann_22:
  return new Sim_ULDA_Brann_22();
case CardDB.cardIDEnum.ULDA_Brann_HP1:
  return new Sim_ULDA_Brann_HP1();
case CardDB.cardIDEnum.ULDA_Brann_HP2:
  return new Sim_ULDA_Brann_HP2();
case CardDB.cardIDEnum.ULDA_Brann_HP3:
  return new Sim_ULDA_Brann_HP3();
case CardDB.cardIDEnum.ULDA_Brann_HPe:
  return new Sim_ULDA_Brann_HPe();
case CardDB.cardIDEnum.ULDA_Brann_PDWatcher:
  return new Sim_ULDA_Brann_PDWatcher();
case CardDB.cardIDEnum.ULDA_Elise:
  return new Sim_ULDA_Elise();
case CardDB.cardIDEnum.ULDA_Elise_01:
  return new Sim_ULDA_Elise_01();
case CardDB.cardIDEnum.ULDA_Elise_02:
  return new Sim_ULDA_Elise_02();
case CardDB.cardIDEnum.ULDA_Elise_03:
  return new Sim_ULDA_Elise_03();
case CardDB.cardIDEnum.ULDA_Elise_04:
  return new Sim_ULDA_Elise_04();
case CardDB.cardIDEnum.ULDA_Elise_05:
  return new Sim_ULDA_Elise_05();
case CardDB.cardIDEnum.ULDA_Elise_06:
  return new Sim_ULDA_Elise_06();
case CardDB.cardIDEnum.ULDA_Elise_07:
  return new Sim_ULDA_Elise_07();
case CardDB.cardIDEnum.ULDA_Elise_08:
  return new Sim_ULDA_Elise_08();
case CardDB.cardIDEnum.ULDA_Elise_09:
  return new Sim_ULDA_Elise_09();
case CardDB.cardIDEnum.ULDA_Elise_10:
  return new Sim_ULDA_Elise_10();
case CardDB.cardIDEnum.ULDA_Elise_11:
  return new Sim_ULDA_Elise_11();
case CardDB.cardIDEnum.ULDA_Elise_12:
  return new Sim_ULDA_Elise_12();
case CardDB.cardIDEnum.ULDA_Elise_13:
  return new Sim_ULDA_Elise_13();
case CardDB.cardIDEnum.ULDA_Elise_14:
  return new Sim_ULDA_Elise_14();
case CardDB.cardIDEnum.ULDA_Elise_15:
  return new Sim_ULDA_Elise_15();
case CardDB.cardIDEnum.ULDA_Elise_16:
  return new Sim_ULDA_Elise_16();
case CardDB.cardIDEnum.ULDA_Elise_17:
  return new Sim_ULDA_Elise_17();
case CardDB.cardIDEnum.ULDA_Elise_18:
  return new Sim_ULDA_Elise_18();
case CardDB.cardIDEnum.ULDA_Elise_19:
  return new Sim_ULDA_Elise_19();
case CardDB.cardIDEnum.ULDA_Elise_20:
  return new Sim_ULDA_Elise_20();
case CardDB.cardIDEnum.ULDA_Elise_22:
  return new Sim_ULDA_Elise_22();
case CardDB.cardIDEnum.ULDA_Elise_23:
  return new Sim_ULDA_Elise_23();
case CardDB.cardIDEnum.ULDA_Elise_HP1:
  return new Sim_ULDA_Elise_HP1();
case CardDB.cardIDEnum.ULDA_Elise_HP1a:
  return new Sim_ULDA_Elise_HP1a();
case CardDB.cardIDEnum.ULDA_Elise_HP1b:
  return new Sim_ULDA_Elise_HP1b();
case CardDB.cardIDEnum.ULDA_Elise_HP2:
  return new Sim_ULDA_Elise_HP2();
case CardDB.cardIDEnum.ULDA_Elise_HP3:
  return new Sim_ULDA_Elise_HP3();
case CardDB.cardIDEnum.ULDA_Elise_HPe:
  return new Sim_ULDA_Elise_HPe();
case CardDB.cardIDEnum.ULDA_Elise_PDWatcher:
  return new Sim_ULDA_Elise_PDWatcher();
case CardDB.cardIDEnum.ULDA_Explorers:
  return new Sim_ULDA_Explorers();
case CardDB.cardIDEnum.ULDA_Finley:
  return new Sim_ULDA_Finley();
case CardDB.cardIDEnum.ULDA_Finley_01:
  return new Sim_ULDA_Finley_01();
case CardDB.cardIDEnum.ULDA_Finley_02:
  return new Sim_ULDA_Finley_02();
case CardDB.cardIDEnum.ULDA_Finley_03:
  return new Sim_ULDA_Finley_03();
case CardDB.cardIDEnum.ULDA_Finley_04:
  return new Sim_ULDA_Finley_04();
case CardDB.cardIDEnum.ULDA_Finley_05:
  return new Sim_ULDA_Finley_05();
case CardDB.cardIDEnum.ULDA_Finley_06:
  return new Sim_ULDA_Finley_06();
case CardDB.cardIDEnum.ULDA_Finley_07:
  return new Sim_ULDA_Finley_07();
case CardDB.cardIDEnum.ULDA_Finley_08:
  return new Sim_ULDA_Finley_08();
case CardDB.cardIDEnum.ULDA_Finley_09:
  return new Sim_ULDA_Finley_09();
case CardDB.cardIDEnum.ULDA_Finley_10:
  return new Sim_ULDA_Finley_10();
case CardDB.cardIDEnum.ULDA_Finley_11:
  return new Sim_ULDA_Finley_11();
case CardDB.cardIDEnum.ULDA_Finley_12:
  return new Sim_ULDA_Finley_12();
case CardDB.cardIDEnum.ULDA_Finley_13:
  return new Sim_ULDA_Finley_13();
case CardDB.cardIDEnum.ULDA_Finley_14:
  return new Sim_ULDA_Finley_14();
case CardDB.cardIDEnum.ULDA_Finley_15:
  return new Sim_ULDA_Finley_15();
case CardDB.cardIDEnum.ULDA_Finley_16:
  return new Sim_ULDA_Finley_16();
case CardDB.cardIDEnum.ULDA_Finley_17:
  return new Sim_ULDA_Finley_17();
case CardDB.cardIDEnum.ULDA_Finley_18:
  return new Sim_ULDA_Finley_18();
case CardDB.cardIDEnum.ULDA_Finley_19:
  return new Sim_ULDA_Finley_19();
case CardDB.cardIDEnum.ULDA_Finley_20:
  return new Sim_ULDA_Finley_20();
case CardDB.cardIDEnum.ULDA_Finley_21:
  return new Sim_ULDA_Finley_21();
case CardDB.cardIDEnum.ULDA_Finley_22:
  return new Sim_ULDA_Finley_22();
case CardDB.cardIDEnum.ULDA_Finley_HP1:
  return new Sim_ULDA_Finley_HP1();
case CardDB.cardIDEnum.ULDA_Finley_HP1t:
  return new Sim_ULDA_Finley_HP1t();
case CardDB.cardIDEnum.ULDA_Finley_HP2:
  return new Sim_ULDA_Finley_HP2();
case CardDB.cardIDEnum.ULDA_Finley_HP3:
  return new Sim_ULDA_Finley_HP3();
case CardDB.cardIDEnum.ULDA_Finley_HP3e:
  return new Sim_ULDA_Finley_HP3e();
case CardDB.cardIDEnum.ULDA_Finley_HPe:
  return new Sim_ULDA_Finley_HPe();
case CardDB.cardIDEnum.ULDA_Finley_PDWatcher:
  return new Sim_ULDA_Finley_PDWatcher();
case CardDB.cardIDEnum.ULDA_Reno:
  return new Sim_ULDA_Reno();
case CardDB.cardIDEnum.ULDA_Reno_01:
  return new Sim_ULDA_Reno_01();
case CardDB.cardIDEnum.ULDA_Reno_02:
  return new Sim_ULDA_Reno_02();
case CardDB.cardIDEnum.ULDA_Reno_03:
  return new Sim_ULDA_Reno_03();
case CardDB.cardIDEnum.ULDA_Reno_04:
  return new Sim_ULDA_Reno_04();
case CardDB.cardIDEnum.ULDA_Reno_05:
  return new Sim_ULDA_Reno_05();
case CardDB.cardIDEnum.ULDA_Reno_06:
  return new Sim_ULDA_Reno_06();
case CardDB.cardIDEnum.ULDA_Reno_07:
  return new Sim_ULDA_Reno_07();
case CardDB.cardIDEnum.ULDA_Reno_08:
  return new Sim_ULDA_Reno_08();
case CardDB.cardIDEnum.ULDA_Reno_09:
  return new Sim_ULDA_Reno_09();
case CardDB.cardIDEnum.ULDA_Reno_10:
  return new Sim_ULDA_Reno_10();
case CardDB.cardIDEnum.ULDA_Reno_11:
  return new Sim_ULDA_Reno_11();
case CardDB.cardIDEnum.ULDA_Reno_12:
  return new Sim_ULDA_Reno_12();
case CardDB.cardIDEnum.ULDA_Reno_13:
  return new Sim_ULDA_Reno_13();
case CardDB.cardIDEnum.ULDA_Reno_14:
  return new Sim_ULDA_Reno_14();
case CardDB.cardIDEnum.ULDA_Reno_15:
  return new Sim_ULDA_Reno_15();
case CardDB.cardIDEnum.ULDA_Reno_16:
  return new Sim_ULDA_Reno_16();
case CardDB.cardIDEnum.ULDA_Reno_17:
  return new Sim_ULDA_Reno_17();
case CardDB.cardIDEnum.ULDA_Reno_18:
  return new Sim_ULDA_Reno_18();
case CardDB.cardIDEnum.ULDA_Reno_19:
  return new Sim_ULDA_Reno_19();
case CardDB.cardIDEnum.ULDA_Reno_20:
  return new Sim_ULDA_Reno_20();
case CardDB.cardIDEnum.ULDA_Reno_21:
  return new Sim_ULDA_Reno_21();
case CardDB.cardIDEnum.ULDA_Reno_22:
  return new Sim_ULDA_Reno_22();
case CardDB.cardIDEnum.ULDA_Reno_HP1:
  return new Sim_ULDA_Reno_HP1();
case CardDB.cardIDEnum.ULDA_Reno_HP2:
  return new Sim_ULDA_Reno_HP2();
case CardDB.cardIDEnum.ULDA_Reno_HP2e:
  return new Sim_ULDA_Reno_HP2e();
case CardDB.cardIDEnum.ULDA_Reno_HP3:
  return new Sim_ULDA_Reno_HP3();
case CardDB.cardIDEnum.ULDA_Reno_HPe:
  return new Sim_ULDA_Reno_HPe();
case CardDB.cardIDEnum.ULDA_Reno_PDWatcher:
  return new Sim_ULDA_Reno_PDWatcher();
case CardDB.cardIDEnum.WE1_006:
  return new Sim_WE1_006();
case CardDB.cardIDEnum.WE1_013:
  return new Sim_WE1_013();
case CardDB.cardIDEnum.WE1_014:
  return new Sim_WE1_014();
case CardDB.cardIDEnum.WE1_015:
  return new Sim_WE1_015();
case CardDB.cardIDEnum.WE1_021:
  return new Sim_WE1_021();
case CardDB.cardIDEnum.WE1_022:
  return new Sim_WE1_022();
case CardDB.cardIDEnum.WE1_023:
  return new Sim_WE1_023();
case CardDB.cardIDEnum.WE1_024:
  return new Sim_WE1_024();
case CardDB.cardIDEnum.WE1_025:
  return new Sim_WE1_025();
case CardDB.cardIDEnum.WE1_026:
  return new Sim_WE1_026();
case CardDB.cardIDEnum.WE1_027:
  return new Sim_WE1_027();
case CardDB.cardIDEnum.WE1_028:
  return new Sim_WE1_028();
case CardDB.cardIDEnum.WE1_029:
  return new Sim_WE1_029();
case CardDB.cardIDEnum.WE1_030:
  return new Sim_WE1_030();
case CardDB.cardIDEnum.WE1_031:
  return new Sim_WE1_031();
case CardDB.cardIDEnum.WE1_032:
  return new Sim_WE1_032();
case CardDB.cardIDEnum.WE1_033:
  return new Sim_WE1_033();
case CardDB.cardIDEnum.WE1_034:
  return new Sim_WE1_034();
case CardDB.cardIDEnum.WE1_035:
  return new Sim_WE1_035();
case CardDB.cardIDEnum.WE1_036:
  return new Sim_WE1_036();
case CardDB.cardIDEnum.WE1_037:
  return new Sim_WE1_037();
case CardDB.cardIDEnum.WE1_038:
  return new Sim_WE1_038();
case CardDB.cardIDEnum.WE1_039:
  return new Sim_WE1_039();


            }
            return new SimTemplate();
        }



    }

}
