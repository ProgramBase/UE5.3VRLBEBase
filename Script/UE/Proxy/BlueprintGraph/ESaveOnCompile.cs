using Script.CoreUObject;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.ESaveOnCompile")]
	public enum ESaveOnCompile : byte
	{
		SoC_Never = 0,
		SoC_SuccessOnly = 1,
		SoC_Always = 2,
	}
}