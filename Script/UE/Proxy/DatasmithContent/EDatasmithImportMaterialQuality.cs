using Script.CoreUObject;

namespace Script.DatasmithContent
{
	[PathName("/Script/DatasmithContent.EDatasmithImportMaterialQuality")]
	public enum EDatasmithImportMaterialQuality : byte
	{
		UseNoFresnelCurves = 0,
		UseSimplifierFresnelCurves = 1,
		UseRealFresnelCurves = 2,
	}
}