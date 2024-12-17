using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EDrawPolyPathExtrudeDirection")]
	public enum EDrawPolyPathExtrudeDirection : int
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