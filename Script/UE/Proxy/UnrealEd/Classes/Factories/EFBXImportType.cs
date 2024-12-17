using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EFBXImportType")]
	public enum EFBXImportType : byte
	{
		FBXIT_StaticMesh = 0,
		FBXIT_SkeletalMesh = 1,
		FBXIT_Animation = 2,
	}
}