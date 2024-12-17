using Script.CoreUObject;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.ESimpleCollisionEditorToolAction")]
	public enum ESimpleCollisionEditorToolAction : long
	{
		NoAction = 0,
		AddSphere = 1,
		AddBox = 2,
		AddCapsule = 3,
		Duplicate = 4,
		DeleteSelected = 5,
		DeleteAll = 6,
	}
}