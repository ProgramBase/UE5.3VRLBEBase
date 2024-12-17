using Script.CoreUObject;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.EInputActionAccumulationBehavior")]
	public enum EInputActionAccumulationBehavior : byte
	{
		TakeHighestAbsoluteValue = 0,
		Cumulative = 1,
	}
}