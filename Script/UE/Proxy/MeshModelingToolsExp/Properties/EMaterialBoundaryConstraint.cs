using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EMaterialBoundaryConstraint")]
	public enum EMaterialBoundaryConstraint : byte
	{
		Fixed = 7,
		Refine = 5,
		Free = 1,
		Ignore = 0,
	}
}