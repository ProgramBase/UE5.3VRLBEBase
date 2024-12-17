using Script.CoreUObject;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.ETriggerType")]
	public enum ETriggerType : byte
	{
		Explicit = 0,
		Implicit = 1,
		Blocker = 2,
	}
}