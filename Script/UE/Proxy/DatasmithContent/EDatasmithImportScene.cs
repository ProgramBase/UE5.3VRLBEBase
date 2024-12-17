using Script.CoreUObject;

namespace Script.DatasmithContent
{
	[PathName("/Script/DatasmithContent.EDatasmithImportScene")]
	public enum EDatasmithImportScene : byte
	{
		NewLevel = 0,
		CurrentLevel = 1,
		AssetsOnly = 2,
	}
}