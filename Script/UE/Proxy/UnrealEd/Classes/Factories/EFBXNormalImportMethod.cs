using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EFBXNormalImportMethod")]
	public enum EFBXNormalImportMethod : byte
	{
		FBXNIM_ComputeNormals = 0,
		FBXNIM_ImportNormals = 1,
		FBXNIM_ImportNormalsAndTangents = 2,
	}
}