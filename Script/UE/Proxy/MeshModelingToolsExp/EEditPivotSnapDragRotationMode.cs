using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EEditPivotSnapDragRotationMode")]
	public enum EEditPivotSnapDragRotationMode : byte
	{
		Ignore = 0,
		Align = 1,
		AlignFlipped = 2,
		LastValue = 3,
	}
}