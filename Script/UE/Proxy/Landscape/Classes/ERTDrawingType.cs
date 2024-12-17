using Script.CoreUObject;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.ERTDrawingType")]
	public enum ERTDrawingType : long
	{
		RTAtlas = 0,
		RTAtlasToNonAtlas = 1,
		RTNonAtlasToAtlas = 2,
		RTNonAtlas = 3,
		RTMips = 4,
	}
}