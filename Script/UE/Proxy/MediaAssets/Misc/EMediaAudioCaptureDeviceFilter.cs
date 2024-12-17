using Script.CoreUObject;

namespace Script.MediaAssets
{
	[PathName("/Script/MediaAssets.EMediaAudioCaptureDeviceFilter")]
	public enum EMediaAudioCaptureDeviceFilter : long
	{
		None = 0,
		Card = 1,
		Microphone = 2,
		Software = 4,
		Unknown = 8,
	}
}