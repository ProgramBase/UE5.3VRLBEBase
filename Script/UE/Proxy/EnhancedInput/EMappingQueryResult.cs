using Script.CoreUObject;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.EMappingQueryResult")]
	public enum EMappingQueryResult : byte
	{
		Error_EnhancedInputNotEnabled = 0,
		Error_InputContextNotInActiveContexts = 1,
		Error_InvalidAction = 2,
		NotMappable = 3,
		MappingAvailable = 4,
	}
}