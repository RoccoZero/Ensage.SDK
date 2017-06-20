﻿// <copyright file="item_soul_ring.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.Abilities.Items
{
    using Ensage.SDK.Extensions;

    public class item_soul_ring : ActiveAbility, IHasModifier, IHasHealthCost
    {
        public item_soul_ring(Item item)
            : base(item)
        {
        }

        public float HealthCost
        {
            get
            {
                return this.Ability.GetAbilitySpecialData("health_sacrifice");
            }
        }

        public string ModifierName { get; } = "modifier_item_soul_ring_buff";
    }
}