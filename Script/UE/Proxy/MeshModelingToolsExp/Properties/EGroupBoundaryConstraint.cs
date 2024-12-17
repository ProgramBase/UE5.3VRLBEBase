using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EGroupBoundaryConstraint")]
	public enum EGroupBoundaryConstraint : byte
	{
		Fixed = 7,
		Refine = 5,
		Free = 1,
		Ignore = 0,
	}
}