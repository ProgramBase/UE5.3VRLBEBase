using Script.CoreUObject;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.EInputMappingRebuildType")]
	public enum EInputMappingRebuildType : byte
	{
		None = 0,
		Rebuild = 1,
		RebuildWithFlush = 2,
	}
}