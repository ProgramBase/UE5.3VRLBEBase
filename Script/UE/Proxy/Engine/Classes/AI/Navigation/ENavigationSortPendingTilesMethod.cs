using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ENavigationSortPendingTilesMethod")]
	public enum ENavigationSortPendingTilesMethod : long
	{
		SortWithSeedLocations = 0,
		SortByPriority = 1,
		None = 2,
	}
}