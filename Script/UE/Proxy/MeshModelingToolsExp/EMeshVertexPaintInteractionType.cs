using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EMeshVertexPaintInteractionType")]
	public enum EMeshVertexPaintInteractionType : byte
	{
		Brush = 0,
		TriFill = 1,
		Fill = 2,
		GroupFill = 3,
		PolyLasso = 4,
		LastValue = 5,
	}
}