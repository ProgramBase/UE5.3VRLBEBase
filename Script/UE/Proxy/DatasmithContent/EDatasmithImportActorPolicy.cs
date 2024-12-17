using Script.CoreUObject;

namespace Script.DatasmithContent
{
	[PathName("/Script/DatasmithContent.EDatasmithImportActorPolicy")]
	public enum EDatasmithImportActorPolicy : byte
	{
		Update = 0,
		Full = 1,
		Ignore = 2,
	}
}