using Script.CoreUObject;

namespace Script.GeometryFramework
{
	[PathName("/Script/GeometryFramework.EDynamicMeshAttributeChangeFlags")]
	public enum EDynamicMeshAttributeChangeFlags : byte
	{
		Unknown = 0,
		MeshTopology = 1,
		VertexPositions = 2,
		NormalsTangents = 4,
		VertexColors = 8,
		UVs = 16,
		TriangleGroups = 32,
	}
}