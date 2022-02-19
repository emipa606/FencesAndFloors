using System.Reflection;
using HarmonyLib;
using Verse;

namespace FencesAndFloors;

[StaticConstructorOnStartup]
internal class FencesAndFloors_Initialization
{
    static FencesAndFloors_Initialization()
    {
        var harmony = new Harmony("mlie.FencesAndFloors");
        var assembly = Assembly.GetExecutingAssembly();
        harmony.PatchAll(assembly);
    }
}