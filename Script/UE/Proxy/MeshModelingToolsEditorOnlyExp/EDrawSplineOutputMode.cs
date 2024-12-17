using Script.CoreUObject;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.EDrawSplineOutputMode")]
	public enum EDrawSplineOutputMode : byte
	{
		EmptyActor = 0,
		ExistingActor = 1,
		CreateBlueprint = 2,
	}
}