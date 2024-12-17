using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EMouseCaptureMode")]
	public enum EMouseCaptureMode : byte
	{
		NoCapture = 0,
		CapturePermanently = 1,
		CapturePermanently_IncludingInitialMouseDown = 2,
		CaptureDuringMouseDown = 3,
		CaptureDuringRightMouseDown = 4,
	}
}