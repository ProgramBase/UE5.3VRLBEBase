using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EMeshVertexPaintVisibilityType")]
	public enum EMeshVertexPaintVisibilityType : byte
	{
		None = 0,
		FrontFacing = 1,
		Unoccluded = 2,
	}
}