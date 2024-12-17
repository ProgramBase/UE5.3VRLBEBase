using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EVertexColorImportOption")]
	public enum EVertexColorImportOption : byte
	{
		Replace = 0,
		Ignore = 1,
		Override = 2,
	}
}