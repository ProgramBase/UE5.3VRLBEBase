using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EOffsetMeshSelectionDirectionMode")]
	public enum EOffsetMeshSelectionDirectionMode : byte
	{
		VertexNormals = 0,
		FaceNormals = 1,
		ConstantWidth = 2,
	}
}