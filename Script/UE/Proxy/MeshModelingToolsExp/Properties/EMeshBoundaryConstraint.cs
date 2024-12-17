using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EMeshBoundaryConstraint")]
	public enum EMeshBoundaryConstraint : byte
	{
		Fixed = 7,
		Refine = 5,
		Free = 1,
	}
}