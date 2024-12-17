using Script.CoreUObject;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.ESelectedObjectsModificationType")]
	public enum ESelectedObjectsModificationType : long
	{
		Replace = 0,
		Add = 1,
		Remove = 2,
		Clear = 3,
	}
}