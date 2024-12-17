using Script.CoreUObject;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.EDrawSplineDrawMode")]
	public enum EDrawSplineDrawMode : byte
	{
		TangentDrag = 0,
		ClickAutoTangent = 1,
		FreeDraw = 2,
	}
}