using System.Reflection;
using HarmonyLib;
using Verse;

namespace FencesAndFloors;

[StaticConstructorOnStartup]
internal class FencesAndFloors_Initialization
{
    static FencesAndFloors_Initialization()
    {
        new Harmony("mlie.FencesAndFloors").PatchAll(Assembly.GetExecutingAssembly());
    }
}