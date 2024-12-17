using Script.CoreUObject;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.ELogTimes")]
	public enum ELogTimes : byte
	{
		None = 0,
		UTC = 1,
		SinceGStartTime = 2,
		Local = 3,
	}
}