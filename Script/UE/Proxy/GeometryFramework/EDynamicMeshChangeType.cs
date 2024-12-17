using Script.CoreUObject;

namespace Script.GeometryFramework
{
	[PathName("/Script/GeometryFramework.EDynamicMeshChangeType")]
	public enum EDynamicMeshChangeType : byte
	{
		GeneralEdit = 0,
		MeshChange = 1,
		MeshReplacementChange = 2,
		MeshVertexChange = 3,
		DeformationEdit = 4,
		AttributeEdit = 5,
	}
}