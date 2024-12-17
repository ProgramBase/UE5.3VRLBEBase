using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EFBXImportContentType")]
	public enum EFBXImportContentType : byte
	{
		FBXICT_All = 0,
		FBXICT_Geometry = 1,
		FBXICT_SkinningWeights = 2,
	}
}