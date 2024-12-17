using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EPlaneBrushSideMode")]
	public enum EPlaneBrushSideMode : byte
	{
		BothSides = 0,
		PushDown = 1,
		PullTowards = 2,
	}
}