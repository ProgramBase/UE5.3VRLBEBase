using Script.CoreUObject;

namespace Script.GeometryCollectionEngine
{
	[PathName("/Script/GeometryCollectionEngine.EGeometryCollectionDebugDrawActorHideGeometry")]
	public enum EGeometryCollectionDebugDrawActorHideGeometry : byte
	{
		HideNone = 0,
		HideWithCollision = 1,
		HideSelected = 2,
		HideWholeCollection = 3,
		HideAll = 4,
	}
}