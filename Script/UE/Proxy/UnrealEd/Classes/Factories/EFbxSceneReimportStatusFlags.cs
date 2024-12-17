using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EFbxSceneReimportStatusFlags")]
	public enum EFbxSceneReimportStatusFlags : long
	{
		None = 0,
		Added = 1,
		Removed = 2,
		Same = 4,
		FoundContentBrowserAsset = 8,
		ReimportAsset = 16,
	}
}