using Script.CoreUObject;

namespace Script.UMGEditor
{
	[PathName("/Script/UMGEditor.EPropertyBindingPermissionLevel")]
	public enum EPropertyBindingPermissionLevel : byte
	{
		Allow = 0,
		Prevent = 1,
		PreventAndWarn = 2,
		PreventAndError = 3,
	}
}