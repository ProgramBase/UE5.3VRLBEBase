using Script.CoreUObject;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.EMaterialAssignmentTargets")]
	public enum EMaterialAssignmentTargets : int
	{
		OnlyInternalFaces = 0,
		OnlyExternalFaces = 1,
		AllFaces = 2,
	}
}