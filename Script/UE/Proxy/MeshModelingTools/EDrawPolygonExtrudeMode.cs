using Script.CoreUObject;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.EDrawPolygonExtrudeMode")]
	public enum EDrawPolygonExtrudeMode : byte
	{
		Flat = 0,
		Fixed = 1,
		Interactive = 2,
	}
}