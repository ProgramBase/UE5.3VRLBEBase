using Script.CoreUObject;
using Script.Library;

namespace Script.GameplayTags
{
	[PathName("/Script/GameplayTags.GameplayTagAssetInterface")]
	public partial class UGameplayTagAssetInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameplayTags.GameplayTagAssetInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/GameplayTags.GameplayTagAssetInterface")]
	public interface IGameplayTagAssetInterface : IInterface
	{
		 bool HasMatchingGameplayTag(FGameplayTag TagToCheck);

		 bool HasAnyMatchingGameplayTags(FGameplayTagContainer TagContainer);

		 bool HasAllMatchingGameplayTags(FGameplayTagContainer TagContainer);

		 void GetOwnedGameplayTags(ref FGameplayTagContainer TagContainer);
	}
}