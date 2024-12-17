using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EExtrudeMeshSelectionRegionModifierMode")]
	public enum EExtrudeMeshSelectionRegionModifierMode : byte
	{
		OriginalShape = 0,
		FlattenToPlane = 1,
		RaycastToPlane = 2,
	}
}