using Script.CoreUObject;

namespace Script.VisualGraphUtils
{
	[PathName("/Script/VisualGraphUtils.EVisualGraphEdgeDirection")]
	public enum EVisualGraphEdgeDirection : long
	{
		SourceToTarget = 0,
		TargetToSource = 1,
		BothWays = 2,
	}
}