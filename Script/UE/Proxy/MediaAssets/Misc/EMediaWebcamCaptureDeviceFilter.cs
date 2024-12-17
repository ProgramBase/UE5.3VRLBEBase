using Script.CoreUObject;

namespace Script.MediaAssets
{
	[PathName("/Script/MediaAssets.EMediaWebcamCaptureDeviceFilter")]
	public enum EMediaWebcamCaptureDeviceFilter : long
	{
		None = 0,
		DepthSensor = 1,
		Front = 2,
		Rear = 4,
		Unknown = 8,
	}
}