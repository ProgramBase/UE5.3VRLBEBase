using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EPlayOnBuildMode")]
	public enum EPlayOnBuildMode : byte
	{
		PlayOnBuild_Always = 0,
		PlayOnBuild_Never = 1,
		PlayOnBuild_Default = 2,
		PlayOnBuild_IfEditorBuiltLocally = 3,
	}
}