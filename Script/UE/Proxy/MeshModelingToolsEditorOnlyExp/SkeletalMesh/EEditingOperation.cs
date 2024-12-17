using Script.CoreUObject;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.EEditingOperation")]
	public enum EEditingOperation : byte
	{
		Select = 0,
		Create = 1,
		Remove = 2,
		Transform = 3,
		Parent = 4,
		Rename = 5,
		Mirror = 6,
	}
}