using Script.CoreUObject;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.ETriggerState")]
	public enum ETriggerState : byte
	{
		None = 0,
		Ongoing = 1,
		Triggered = 2,
	}
}