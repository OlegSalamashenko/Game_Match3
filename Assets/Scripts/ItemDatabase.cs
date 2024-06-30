using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public static class ItemDatabase 
{
   public static Item[] Items {  get; private set; }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]private static void Initialize() => Items = Resources.LoadAll<Item>("Items/");
}
