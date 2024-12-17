using Script.CoreUObject;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.EInputDeviceConnectionState")]
	public enum EInputDeviceConnectionState : byte
	{
		Invalid = 0,
		Unknown = 1,
		Disconnected = 2,
		Connected = 3,
	}
}