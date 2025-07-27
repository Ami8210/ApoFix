using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apofix.cards;
using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;


namespace Apofix.cards
{
    class Tiny : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            Dictionary<string, Action<float>> dictionary = new Dictionary<string, Action<float>>();
            dictionary.Add("damage", delegate (float val)
            {
                gun.damage = val;
            });
            dictionary.Add("health", delegate (float val)
            {
                statModifiers.health = val;
            });
            dictionary.Add("reload", delegate (float val)
            {
                gun.reloadTime = val;
            });
            dictionary.Add("ammo", delegate (float val)
            {
                gun.ammo = (int)val;
            });
            dictionary.Add("ammoregeneration", delegate (float val)
            {
                gun.ammoReg = val;
            });
            dictionary.Add("projectiles", delegate (float val)
            {
                gun.numberOfProjectiles = Mathf.Max(1, (int)val);
            });
            dictionary.Add("projectilesize", delegate (float val)
            {
                gun.projectileSize = val;
            });
            dictionary.Add("bursts", delegate (float val)
            {
                gun.bursts = (int)val;
            });
            dictionary.Add("timeBetweenBullets", delegate (float val)
            {
                gun.timeBetweenBullets = val;
            });
            dictionary.Add("knockback", delegate (float val)
            {
                gun.knockback = val;
            });
            dictionary.Add("attackSpeed", delegate (float val)
            {
                gun.attackSpeed = val;
            });
            dictionary.Add("bounces", delegate (float val)
            {
                gun.reflects = (int)val;
            });
            dictionary.Add("bulletSpeed", delegate (float val)
            {
                gun.projectileSpeed = val;
            });
            dictionary.Add("blocksamount", delegate (float val)
            {
                block.additionalBlocks = (int)val;
            });
            dictionary.Add("blockhealamount", delegate (float val)
            {
                block.healing = (float)((int)val);
            });
            dictionary.Add("blockcooldown", delegate (float val)
            {
                block.cdMultiplier = val;
            });
            dictionary.Add("lifesteal", delegate (float val)
            {
                statModifiers.lifeSteal = val;
            });
            dictionary.Add("respawns", delegate (float val)
            {
                statModifiers.respawns = (int)val;
            });
            dictionary.Add("numberofjumps", delegate (float val)
            {
                statModifiers.numberOfJumps = (int)val;
            });
            dictionary.Add("gravity", delegate (float val)
            {
                statModifiers.gravity = val;
            });
            dictionary.Add("size", delegate (float val)
            {
                statModifiers.sizeMultiplier = val;
            });
            dictionary.Add("movementspeed", delegate (float val)
            {
                statModifiers.movementSpeed = val;
            });
            dictionary["size"](0.50f);
            dictionary["blockcooldown"](1.25f);

        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Edits values on player when card is selected
        }
        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Run when the card is removed from the player
        }


        protected override string GetTitle()
        {
            return "Tiny";
        }
        protected override string GetDescription()
        {
            return "Become tiny";
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
                    stat = "Size",
                    amount = "-50%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Block cooldown",
                    amount = "+25%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                }
            };
        }
        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.DefensiveBlue;
        }
        public override string GetModName()
        {
            return Apofix.ModInitials;
        }
    }
}
