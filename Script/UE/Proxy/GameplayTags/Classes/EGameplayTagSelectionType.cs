using Script.CoreUObject;

namespace Script.GameplayTags
{
	[PathName("/Script/GameplayTags.EGameplayTagSelectionType")]
	public enum EGameplayTagSelectionType : long
	{
		None = 0,
		NonRestrictedOnly = 1,
		RestrictedOnly = 2,
		All = 3,
	}
}