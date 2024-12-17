using Script.CoreUObject;

namespace Script.GeometryFramework
{
	[PathName("/Script/GeometryFramework.EDynamicMeshVertexColorTransformMode")]
	public enum EDynamicMeshVertexColorTransformMode : byte
	{
		NoTransform = 0,
		LinearToSRGB = 1,
		SRGBToLinear = 2,
	}
}