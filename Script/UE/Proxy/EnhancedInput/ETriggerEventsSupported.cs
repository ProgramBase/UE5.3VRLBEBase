using Script.CoreUObject;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.ETriggerEventsSupported")]
	public enum ETriggerEventsSupported : long
	{
		None = 0,
		Instant = 1,
		Uninterruptible = 2,
		Ongoing = 4,
		All = 7,
	}
}