using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EFbxSceneVertexColorImportOption")]
	public enum EFbxSceneVertexColorImportOption : byte
	{
		Replace = 0,
		Ignore = 1,
		Override = 2,
	}
}