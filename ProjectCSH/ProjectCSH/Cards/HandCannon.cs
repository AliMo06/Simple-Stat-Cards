using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;


namespace SimpleStatCards.Cards
{
    class HandCannon : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            UnityEngine.Debug.Log($"[{SimpleStatCards.ModInitials}][Card] {GetTitle()} has been setup.");
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            UnityEngine.Debug.Log($"[{SimpleStatCards.ModInitials}][Card] {GetTitle()} has been added to player {player.playerID}.");

            gun.damage *= 8.5f; // greatly increases damage
            gun.projectileSpeed *= 3.0f; // doubles bullet speed
            gunAmmo.maxAmmo = 1; // sets ammo to 1
            gunAmmo.reloadTimeAdd = 3.25f; // adds 3.25 seconds of reload time 
        }
        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            UnityEngine.Debug.Log($"[{SimpleStatCards.ModInitials}][Card] {GetTitle()} has been removed from player {player.playerID}.");
        }

             
        protected override string GetTitle()
        {
            return "Hand Cannon";
        }
        protected override string GetDescription()
        {
            return "You now wield a Hand Cannon with 1 ammo";
        }
        protected override GameObject GetCardArt()
        {
            return null;
        }
        protected override CardInfo.Rarity GetRarity()
        {
            return CardInfo.Rarity.Common;
        }
        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Damage",
                    amount = "+850%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat() {
                    positive = true,
                    stat = "Bullet Speed",
                    amount = "+300%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat() {
                    positive = false,
                    stat = "Reload Speed",
                    amount = "+3.25s",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat() {
                    positive = false,
                    stat = "Ammo",
                    amount = "1",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                }
            };
        }
        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.FirepowerYellow;
        }
        public override string GetModName()
        {
            return SimpleStatCards.ModInitials;
        }
    }
}
