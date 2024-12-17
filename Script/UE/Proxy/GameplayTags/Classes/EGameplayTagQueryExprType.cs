using Script.CoreUObject;

namespace Script.GameplayTags
{
	[PathName("/Script/GameplayTags.EGameplayTagQueryExprType")]
	public enum EGameplayTagQueryExprType : long
	{
		Undefined = 0,
		AnyTagsMatch = 1,
		AllTagsMatch = 2,
		NoTagsMatch = 3,
		AnyExprMatch = 4,
		AllExprMatch = 5,
		NoExprMatch = 6,
	}
}