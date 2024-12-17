using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EMeshGroupPaintVisibilityType")]
	public enum EMeshGroupPaintVisibilityType : byte
	{
		None = 0,
		FrontFacing = 1,
		Unoccluded = 2,
	}
}