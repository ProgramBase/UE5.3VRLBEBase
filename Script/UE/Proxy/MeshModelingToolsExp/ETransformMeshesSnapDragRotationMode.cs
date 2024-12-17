using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.ETransformMeshesSnapDragRotationMode")]
	public enum ETransformMeshesSnapDragRotationMode : byte
	{
		Ignore = 0,
		Align = 1,
		AlignFlipped = 2,
		LastValue = 3,
	}
}