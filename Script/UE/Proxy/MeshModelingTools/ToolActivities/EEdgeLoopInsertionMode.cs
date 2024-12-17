using Script.CoreUObject;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.EEdgeLoopInsertionMode")]
	public enum EEdgeLoopInsertionMode : int
	{
		Retriangulate = 0,
		PlaneCut = 1,
	}
}