using Script.CoreUObject;

namespace Script.Chaos
{
	[PathName("/Script/Chaos.EConvexOverlapRemoval")]
	public enum EConvexOverlapRemoval : int
	{
		None = 0,
		All = 1,
		OnlyClusters = 2,
		OnlyClustersVsClusters = 3,
	}
}