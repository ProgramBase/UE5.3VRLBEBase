using Script.CoreUObject;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.ETriggerEvent")]
	public enum ETriggerEvent : byte
	{
		None = 0,
		Triggered = 1,
		Started = 2,
		Ongoing = 4,
		Canceled = 8,
		Completed = 16,
	}
}