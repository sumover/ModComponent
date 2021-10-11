﻿using ModComponent.API.Components;
using UnityEngine;

namespace ModComponent.Utils
{
	public static class ComponentUtils
	{
		public static T GetComponent<T>(Component component) where T : Component
		{
			if (component == null) return default;
			else return GetComponent<T>(GetGameObject(component));
		}

		public static T GetComponent<T>(GameObject gameObject) where T : Component
		{
			if (gameObject == null) return default;
			else return gameObject.GetComponent<T>();
		}

		public static T GetOrCreateComponent<T>(Component component) where T : Component
		{
			if (component == null) return default;
			else return GetOrCreateComponent<T>(GetGameObject(component));
		}

		public static T GetOrCreateComponent<T>(GameObject gameObject) where T : Component
		{
			if (gameObject == null) return default;

			T result = GetComponent<T>(gameObject);

			if (result == null) result = gameObject.AddComponent<T>();

			return result;
		}

		internal static ModBaseEquippableComponent GetEquippableModComponent(Component component)
		{
			return GetComponent<ModBaseEquippableComponent>(component);
		}

		internal static ModBaseEquippableComponent GetEquippableModComponent(GameObject gameObject)
		{
			return GetComponent<ModBaseEquippableComponent>(gameObject);
		}

		internal static ModBaseComponent GetModComponent(Component component)
		{
			return GetComponent<ModBaseComponent>(component);
		}

		internal static ModBaseComponent GetModComponent(GameObject gameObject)
		{
			return GetComponent<ModBaseComponent>(gameObject);
		}

		internal static GameObject GetGameObject(Component component)
		{
			try
			{
				if (component == null) return null;
				else return component.gameObject;
			}
			catch (System.Exception exception)
			{
#if DEBUG
                Logger.LogError("Returning null since this could not obtain a Game Object from the component. Stack trace:\n{0}", exception.Message);
#endif
				return null;
			}
		}
	}
}
