using Script.CoreUObject;

namespace Script.GameplayTags
{
	[PathName("/Script/GameplayTags.EGameplayTagSourceType")]
	public enum EGameplayTagSourceType : byte
	{
		Native = 0,
		DefaultTagList = 1,
		TagList = 2,
		RestrictedTagList = 3,
		DataTable = 4,
		Invalid = 5,
	}
}