using Script.CoreUObject;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.EInputDevices")]
	public enum EInputDevices : long
	{
		None = 0,
		Keyboard = 1,
		Mouse = 2,
		Gamepad = 4,
		OculusTouch = 8,
		HTCViveWands = 16,
		AnySpatialDevice = 24,
		TabletFingers = 1024,
	}
}