using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.ECubeGridToolFaceSelectionMode")]
	public enum ECubeGridToolFaceSelectionMode : int
	{
		OutsideBasedOnNormal = 0,
		InsideBasedOnNormal = 1,
		OutsideBasedOnViewRay = 2,
		InsideBasedOnViewRay = 3,
	}
}