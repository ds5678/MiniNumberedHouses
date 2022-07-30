using MelonLoader;
using UnityEngine;

namespace MiniNumberedHouses
{
	internal static class Utils
	{
		internal static GameObject MakeChild(this GameObject parent, GameObject prefab)
		{
			if(parent == null)
			{
				MelonLogger.Error("Parent cannot be null");
				return null;
			}
			if(prefab == null)
			{
				MelonLogger.Error("Prefab cannot be null");
				return null;
			}
			GameObject instance = GameObject.Instantiate(prefab);

			instance.transform.parent = parent.transform;

			return instance;
		}

		internal static GameObject GetChild(this GameObject parent, string childName)
		{
			return parent?.transform?.Find(childName)?.gameObject;
		}
	}
}
