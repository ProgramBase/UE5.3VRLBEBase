using Script.CoreUObject;

namespace Script.GeometryCollectionEngine
{
	[PathName("/Script/GeometryCollectionEngine.EChaosTrailingSortMethod")]
	public enum EChaosTrailingSortMethod : byte
	{
		SortNone = 0,
		SortByHighestMass = 1,
		SortByHighestSpeed = 2,
		SortByNearestFirst = 3,
		Count = 4,
	}
}