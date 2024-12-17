using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EHardwareDevicePrimaryType")]
	public enum EHardwareDevicePrimaryType : byte
	{
		Unspecified = 0,
		KeyboardAndMouse = 1,
		Gamepad = 2,
		Touch = 3,
		MotionTracking = 4,
		RacingWheel = 5,
		FlightStick = 6,
		Camera = 7,
		Instrument = 8,
		CustomTypeA = 9,
		CustomTypeB = 10,
		CustomTypeC = 11,
		CustomTypeD = 12,
	}
}