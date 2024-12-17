using Script.CoreUObject;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.EPolygonType")]
	public enum EPolygonType : int
	{
		Circle = 0,
		Square = 1,
		Rectangle = 2,
		RoundRect = 3,
		Custom = 4,
	}
}