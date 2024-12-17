using Script.CoreUObject;

namespace Script.GeometryFramework
{
	[PathName("/Script/GeometryFramework.EDynamicMeshComponentTangentsMode")]
	public enum EDynamicMeshComponentTangentsMode : byte
	{
		NoTangents = 0,
		AutoCalculated = 1,
		ExternallyProvided = 2,
		Default = 255,
	}
}