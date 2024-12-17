using Script.CoreUObject;

namespace Script.GeometryCollectionEngine
{
	[PathName("/Script/GeometryCollectionEngine.EChaosCollisionSortMethod")]
	public enum EChaosCollisionSortMethod : byte
	{
		SortNone = 0,
		SortByHighestMass = 1,
		SortByHighestSpeed = 2,
		SortByHighestImpulse = 3,
		SortByNearestFirst = 4,
		Count = 5,
	}
}