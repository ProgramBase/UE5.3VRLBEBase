using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EFBXAnimationLengthImportType")]
	public enum EFBXAnimationLengthImportType : byte
	{
		FBXALIT_ExportedTime = 0,
		FBXALIT_AnimatedKey = 1,
		FBXALIT_SetRange = 2,
	}
}