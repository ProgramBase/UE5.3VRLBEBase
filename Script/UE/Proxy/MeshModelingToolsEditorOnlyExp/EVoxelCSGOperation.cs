using Script.CoreUObject;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.EVoxelCSGOperation")]
	public enum EVoxelCSGOperation : byte
	{
		DifferenceAB = 0,
		DifferenceBA = 1,
		Intersect = 2,
		Union = 3,
	}
}