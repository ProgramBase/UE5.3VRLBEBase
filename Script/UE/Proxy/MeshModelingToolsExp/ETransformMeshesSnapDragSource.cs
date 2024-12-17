using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.ETransformMeshesSnapDragSource")]
	public enum ETransformMeshesSnapDragSource : byte
	{
		ClickPoint = 0,
		Pivot = 1,
		LastValue = 2,
	}
}