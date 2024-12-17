using Script.CoreUObject;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.EPolyEditExtrudeDirection")]
	public enum EPolyEditExtrudeDirection : int
	{
		SelectionNormal = 0,
		WorldX = 1,
		WorldY = 2,
		WorldZ = 3,
		LocalX = 4,
		LocalY = 5,
		LocalZ = 6,
	}
}