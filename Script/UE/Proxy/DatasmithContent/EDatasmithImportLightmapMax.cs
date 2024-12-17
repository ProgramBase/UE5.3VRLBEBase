using Script.CoreUObject;

namespace Script.DatasmithContent
{
	[PathName("/Script/DatasmithContent.EDatasmithImportLightmapMax")]
	public enum EDatasmithImportLightmapMax : byte
	{
		LIGHTMAP_64 = 0,
		LIGHTMAP_128 = 1,
		LIGHTMAP_256 = 2,
		LIGHTMAP_512 = 3,
		LIGHTMAP_1024 = 4,
		LIGHTMAP_2048 = 5,
		LIGHTMAP_4096 = 6,
	}
}