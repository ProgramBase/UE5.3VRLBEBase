using Script.CoreUObject;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.ETunnelBoundaryType")]
	public enum ETunnelBoundaryType : byte
	{
		Unknown = 0,
		EntrySite = 1,
		InputSite = 2,
		OutputSite = 3,
	}
}