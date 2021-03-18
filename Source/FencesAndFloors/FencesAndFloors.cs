using System.Collections.Generic;
using HarmonyLib;
using Verse;
using Verse.AI;

namespace FencesAndFloors
{
    [HarmonyPatch(typeof(PathGrid), "CalculatedCostAt")]
    public static class SnowUtilityPatch
    {
        // Token: 0x06000002 RID: 2 RVA: 0x00002078 File Offset: 0x00000278
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instrs)
        {
            instrs = instrs.MethodReplacer(typeof(SnowUtility).GetMethod("MovementTicksAddOn"),
                typeof(SnowUtilityPatch).GetMethod("MovementTicksAddOnIgnoreZero"));
            return instrs;
        }

        public static int MovementTicksAddOnIgnoreZero(SnowCategory category)
        {
            switch (category)
            {
                case SnowCategory.None:
                    return -100;
                case SnowCategory.Dusting:
                    return 0;
                case SnowCategory.Thin:
                    return 4;
                case SnowCategory.Medium:
                    return 8;
                case SnowCategory.Thick:
                    return 12;
                default:
                    return 0;
            }
        }
    }
}