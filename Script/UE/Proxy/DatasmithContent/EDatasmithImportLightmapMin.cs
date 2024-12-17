using Script.CoreUObject;

namespace Script.DatasmithContent
{
	[PathName("/Script/DatasmithContent.EDatasmithImportLightmapMin")]
	public enum EDatasmithImportLightmapMin : byte
	{
		LIGHTMAP_16 = 0,
		LIGHTMAP_32 = 1,
		LIGHTMAP_64 = 2,
		LIGHTMAP_128 = 3,
		LIGHTMAP_256 = 4,
		LIGHTMAP_512 = 5,
	}
}