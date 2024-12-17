using Script.CoreUObject;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.EEdgeLoopPositioningMode")]
	public enum EEdgeLoopPositioningMode : int
	{
		Even = 0,
		ProportionOffset = 1,
		DistanceOffset = 2,
	}
}