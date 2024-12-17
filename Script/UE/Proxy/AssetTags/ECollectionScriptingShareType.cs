using Script.CoreUObject;

namespace Script.AssetTags
{
	[PathName("/Script/AssetTags.ECollectionScriptingShareType")]
	public enum ECollectionScriptingShareType : byte
	{
		Local = 0,
		Private = 1,
		Shared = 2,
	}
}