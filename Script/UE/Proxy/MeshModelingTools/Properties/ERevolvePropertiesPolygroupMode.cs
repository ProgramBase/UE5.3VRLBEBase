using Script.CoreUObject;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.ERevolvePropertiesPolygroupMode")]
	public enum ERevolvePropertiesPolygroupMode : byte
	{
		PerShape = 0,
		PerFace = 1,
		PerRevolveStep = 2,
		PerPathSegment = 3,
	}
}