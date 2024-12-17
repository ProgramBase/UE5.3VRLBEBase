using Script.CoreUObject;

namespace Script.MediaAssets
{
	[PathName("/Script/MediaAssets.EMediaSoundComponentFFTSize")]
	public enum EMediaSoundComponentFFTSize : byte
	{
		Min_64 = 0,
		Small_256 = 1,
		Medium_512 = 2,
		Large_1024 = 3,
	}
}