using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EMeshInspectorToolDrawIndexMode")]
	public enum EMeshInspectorToolDrawIndexMode : byte
	{
		None = 0,
		VertexID = 1,
		TriangleID = 2,
		GroupID = 3,
		EdgeID = 4,
	}
}