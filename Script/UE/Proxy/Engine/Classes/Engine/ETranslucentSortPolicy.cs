using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETranslucentSortPolicy")]
	public enum ETranslucentSortPolicy : byte
	{
		SortByDistance = 0,
		SortByProjectedZ = 1,
		SortAlongAxis = 2,
	}
}