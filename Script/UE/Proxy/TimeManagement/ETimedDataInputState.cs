using Script.CoreUObject;

namespace Script.TimeManagement
{
	[PathName("/Script/TimeManagement.ETimedDataInputState")]
	public enum ETimedDataInputState : long
	{
		Connected = 0,
		Unresponsive = 1,
		Disconnected = 2,
	}
}