using Script.CoreUObject;

namespace Script.GeometryCollectionEngine
{
	[PathName("/Script/GeometryCollectionEngine.EChaosRemovalSortMethod")]
	public enum EChaosRemovalSortMethod : byte
	{
		SortNone = 0,
		SortByHighestMass = 1,
		SortByNearestFirst = 2,
		Count = 3,
	}
}