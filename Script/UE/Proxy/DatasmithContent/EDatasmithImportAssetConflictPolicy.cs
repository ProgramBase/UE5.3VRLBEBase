using Script.CoreUObject;

namespace Script.DatasmithContent
{
	[PathName("/Script/DatasmithContent.EDatasmithImportAssetConflictPolicy")]
	public enum EDatasmithImportAssetConflictPolicy : byte
	{
		Replace = 0,
		Update = 1,
		Use = 2,
		Ignore = 3,
	}
}