using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ELandscapeFoliageEditorControlType")]
	public enum ELandscapeFoliageEditorControlType : byte
	{
		IgnoreCtrl = 0,
		RequireCtrl = 1,
		RequireNoCtrl = 2,
	}
}