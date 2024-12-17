using Script.CoreUObject;

namespace Script.GeometryFramework
{
	[PathName("/Script/GeometryFramework.EDynamicMeshComponentRenderUpdateMode")]
	public enum EDynamicMeshComponentRenderUpdateMode : long
	{
		NoUpdate = 0,
		FullUpdate = 1,
		FastUpdate = 2,
	}
}