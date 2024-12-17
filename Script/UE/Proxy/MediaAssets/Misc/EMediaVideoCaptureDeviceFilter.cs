using Script.CoreUObject;

namespace Script.MediaAssets
{
	[PathName("/Script/MediaAssets.EMediaVideoCaptureDeviceFilter")]
	public enum EMediaVideoCaptureDeviceFilter : long
	{
		None = 0,
		Card = 1,
		Software = 2,
		Unknown = 4,
		Webcam = 8,
	}
}