using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EMeshVertexPaintToolActions")]
	public enum EMeshVertexPaintToolActions : long
	{
		NoAction = 0,
		PaintAll = 1,
		EraseAll = 2,
		FillBlack = 3,
		FillWhite = 4,
		ApplyCurrentUtility = 5,
	}
}