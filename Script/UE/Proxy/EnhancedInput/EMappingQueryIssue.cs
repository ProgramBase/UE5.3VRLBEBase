using Script.CoreUObject;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.EMappingQueryIssue")]
	public enum EMappingQueryIssue : byte
	{
		NoIssue = 0,
		ReservedByAction = 1,
		HidesExistingMapping = 2,
		HiddenByExistingMapping = 4,
		CollisionWithMappingInSameContext = 8,
		ForcesTypePromotion = 16,
		ForcesTypeDemotion = 32,
	}
}