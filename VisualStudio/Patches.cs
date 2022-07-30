using Motorways.Views;
using HarmonyLib;
using UnityEngine;
using TMPro;

namespace MiniNumberedHouses
{
	internal static class Patches
	{
		[HarmonyPatch(typeof(HouseView),"Awake")]
		internal static class HousePatch1
		{
			private static void Postfix(HouseView __instance)
			{
				GameObject child = __instance.gameObject.MakeChild(Implementation.numberPrefab);
				child.name = "Number";
			}
		}
		[HarmonyPatch(typeof(HouseView), "Initialize")]
		internal static class HousePatch2
		{
			private static void Postfix(HouseView __instance)
			{
				GameObject child = __instance.gameObject.GetChild("Number");
				TMP_Text tmpText = child.GetComponent<TMP_Text>();
				tmpText.text = (__instance.groupIndex + 1).ToString();
			}
		}
		[HarmonyPatch(typeof(DestinationView), "Awake")]
		internal static class DestinationPatch1
		{
			private static void Postfix(DestinationView __instance)
			{
				GameObject child = __instance.gameObject.MakeChild(Implementation.numberPrefab);
				child.name = "Number";
			}
		}
		[HarmonyPatch(typeof(DestinationView), "Initialize")]
		internal static class DestinationPatch2
		{
			private static void Postfix(DestinationView __instance)
			{
				GameObject child = __instance.gameObject.GetChild("Number");
				TMP_Text tmpText = child.GetComponent<TMP_Text>();
				tmpText.text = (__instance.groupIndex + 1).ToString();
			}
		}
	}
}
