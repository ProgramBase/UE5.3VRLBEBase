using Script.CoreUObject;

namespace Script.GeometryFramework
{
	[PathName("/Script/GeometryFramework.EDynamicMeshComponentColorOverrideMode")]
	public enum EDynamicMeshComponentColorOverrideMode : byte
	{
		None = 0,
		VertexColors = 1,
		Polygroups = 2,
		Constant = 3,
	}
}