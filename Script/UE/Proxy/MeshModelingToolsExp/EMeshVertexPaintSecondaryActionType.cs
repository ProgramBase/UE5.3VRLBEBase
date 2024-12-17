using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EMeshVertexPaintSecondaryActionType")]
	public enum EMeshVertexPaintSecondaryActionType : byte
	{
		Erase = 0,
		Soften = 1,
		Smooth = 2,
	}
}