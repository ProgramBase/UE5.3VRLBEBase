using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EMeshInspectorMaterialMode")]
	public enum EMeshInspectorMaterialMode : byte
	{
		Original = 0,
		FlatShaded = 1,
		Grey = 2,
		Transparent = 3,
		TangentNormal = 4,
		VertexColor = 5,
		GroupColor = 6,
		Checkerboard = 7,
		Override = 8,
	}
}