using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EFBXSceneNormalImportMethod")]
	public enum EFBXSceneNormalImportMethod : byte
	{
		FBXSceneNIM_ComputeNormals = 0,
		FBXSceneNIM_ImportNormals = 1,
		FBXSceneNIM_ImportNormalsAndTangents = 2,
	}
}