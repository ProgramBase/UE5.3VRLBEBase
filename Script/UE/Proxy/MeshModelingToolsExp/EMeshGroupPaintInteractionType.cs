using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EMeshGroupPaintInteractionType")]
	public enum EMeshGroupPaintInteractionType : byte
	{
		Brush = 0,
		Fill = 1,
		GroupFill = 2,
		PolyLasso = 3,
		LastValue = 4,
	}
}