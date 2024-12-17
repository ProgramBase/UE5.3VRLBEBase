using Script.CoreUObject;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.EAttributeEditorElementType")]
	public enum EAttributeEditorElementType : byte
	{
		Vertex = 0,
		VertexInstance = 1,
		Triangle = 2,
		Polygon = 3,
		Edge = 4,
		PolygonGroup = 5,
	}
}