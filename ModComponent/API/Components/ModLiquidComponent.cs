﻿using ModComponent.Utils;

namespace ModComponent.API.Components
{
	[MelonLoader.RegisterTypeInIl2Cpp]
	public class ModLiquidComponent : ModBaseComponent
	{
		/// <summary>
		/// The type of liquid this item contains.
		/// </summary>
		public LiquidKind LiquidType = LiquidKind.Water;

		/// <summary>
		/// The capacity of this container in liters
		/// </summary>
		public float LiquidCapacityLiters;

		/// <summary>
		/// If true, this container will have a random initial quantity.
		/// </summary>
		public bool RandomizeQuantity = false;

		/// <summary>
		/// If initial quantity not randomized, it will have this amount initially.
		/// </summary>
		public float LiquidLiters = 0f;

		void Awake()
		{
			CopyFieldHandler.UpdateFieldValues<ModLiquidComponent>(this);
		}

		public ModLiquidComponent(System.IntPtr intPtr) : base(intPtr) { }

		public enum LiquidKind
		{
			Water,
			Kerosene
		}
	}
}
