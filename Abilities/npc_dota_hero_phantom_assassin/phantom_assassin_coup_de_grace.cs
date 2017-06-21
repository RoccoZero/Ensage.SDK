// <copyright file="phantom_assassin_coup_de_grace.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.Abilities.npc_dota_hero_phantom_assassin
{
    using Ensage.SDK.Extensions;

    public class phantom_assassin_coup_de_grace : PassiveAbility, IHasCritChance
    {
        public phantom_assassin_coup_de_grace(Ability ability)
            : base(ability)
        {
        }

        public float ProcChance
        {
            get
            {
                return this.Ability.GetAbilitySpecialData("crit_chance") / 100.0f;
            }
        }

        public bool IsPseudoCHance { get; } = true;

        public float CritMultiplier
        {
            get
            {
                return this.Ability.GetAbilitySpecialData("crit_bonus") / 100.0f;
            }
        }
    }
}