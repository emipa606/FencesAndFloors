using System.Collections.Generic;
using HarmonyLib;
using Verse;
using Verse.AI;

namespace FencesAndFloors;

[HarmonyPatch(typeof(PathGrid), nameof(PathGrid.CalculatedCostAt))]
public static class PathGrid_CalculatedCostAt
{
    public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instrs)
    {
        instrs = instrs.MethodReplacer(
            typeof(WeatherBuildupUtility).GetMethod(nameof(WeatherBuildupUtility.MovementTicksAddOn)),
            typeof(PathGrid_CalculatedCostAt).GetMethod(nameof(MovementTicksAddOnIgnoreZero)));
        return instrs;
    }

    public static int MovementTicksAddOnIgnoreZero(WeatherBuildupCategory category)
    {
        switch (category)
        {
            case WeatherBuildupCategory.None:
                return -100;
            case WeatherBuildupCategory.Dusting:
                return 0;
            case WeatherBuildupCategory.Thin:
                return 4;
            case WeatherBuildupCategory.Medium:
                return 8;
            case WeatherBuildupCategory.Thick:
                return 12;
            default:
                return 0;
        }
    }
}