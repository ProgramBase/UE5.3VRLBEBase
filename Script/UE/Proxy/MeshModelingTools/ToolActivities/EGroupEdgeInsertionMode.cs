using Script.CoreUObject;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.EGroupEdgeInsertionMode")]
	public enum EGroupEdgeInsertionMode : int
	{
		Retriangulate = 0,
		PlaneCut = 1,
	}
}