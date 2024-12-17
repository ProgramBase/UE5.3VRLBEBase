using Script.CoreUObject;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.EBlueprintUsage")]
	public enum EBlueprintUsage : byte
	{
		NoProperties = 0,
		DoesNotUseBlueprint = 1,
		UsesBlueprint = 2,
	}
}