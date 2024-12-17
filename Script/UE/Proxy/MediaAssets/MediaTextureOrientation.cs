using Script.CoreUObject;

namespace Script.MediaAssets
{
	[PathName("/Script/MediaAssets.MediaTextureOrientation")]
	public enum MediaTextureOrientation : byte
	{
		MTORI_Original = 0,
		MTORI_CW90 = 1,
		MTORI_CW180 = 2,
		MTORI_CW270 = 3,
	}
}