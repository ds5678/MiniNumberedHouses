using System.IO;
using MelonLoader;
using UnityEngine;

namespace MiniNumberedHouses
{
	public class Implementation : MelonMod
    {
		public const string BundleName = "MiniNumberedHouses.unity3d";
		public static string bundlePath = Path.Combine(MelonUtils.BaseDirectory, "Mods", BundleName);
		public static AssetBundle assetBundle;
		public static GameObject numberPrefab;
		public override void OnApplicationStart()
		{
			MelonLogger.Msg("Loading from bundle...");
			assetBundle = AssetBundle.LoadFromFile(bundlePath);
			if(assetBundle == null)
			{
				MelonLogger.Error("Could not load asset bundle!");
				return;
			}
			numberPrefab = assetBundle.LoadAllAssets()?[0] as GameObject;
			if (numberPrefab == null)
			{
				MelonLogger.Error("Could not load number prefab.");
			}
			else
			{
				MelonLogger.Msg($"Successfully loaded '{numberPrefab.name}'");
			}
		}
	}
}
