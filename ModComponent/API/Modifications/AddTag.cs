﻿using UnityEngine;

namespace ModComponent.API
{
	[MelonLoader.RegisterTypeInIl2Cpp]
	public class AddTag : MonoBehaviour
	{
		public string Tag;

		public void Awake()
		{
			gameObject.tag = Tag;
		}

		public AddTag(System.IntPtr intPtr) : base(intPtr) { }
	}
}