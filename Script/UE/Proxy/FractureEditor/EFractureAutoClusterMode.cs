using Script.CoreUObject;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.EFractureAutoClusterMode")]
	public enum EFractureAutoClusterMode : long
	{
		BoundingBox = 0,
		Proximity = 1,
		Distance = 2,
		Voronoi = 3,
	}
}