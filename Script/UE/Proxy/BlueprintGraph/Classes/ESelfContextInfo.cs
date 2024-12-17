using Script.CoreUObject;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.ESelfContextInfo")]
	public enum ESelfContextInfo : byte
	{
		Unspecified = 0,
		NotSelfContext = 1,
	}
}