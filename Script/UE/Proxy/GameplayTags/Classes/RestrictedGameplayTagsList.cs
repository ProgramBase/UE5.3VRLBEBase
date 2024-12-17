using Script.CoreUObject;
using Script.Library;

namespace Script.GameplayTags
{
	[PathName("/Script/GameplayTags.RestrictedGameplayTagsList")]
	public partial class URestrictedGameplayTagsList : UObject, IStaticClass
	{
		public FString ConfigFileName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ConfigFileName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ConfigFileName, __InBuffer);
				}
			}
		}

		public TArray<FRestrictedGameplayTagTableRow> RestrictedGameplayTagList
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RestrictedGameplayTagList, __ReturnBuffer);

					return *(TArray<FRestrictedGameplayTagTableRow>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RestrictedGameplayTagList, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameplayTags.RestrictedGameplayTagsList");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ConfigFileName = 0;

		private static uint __RestrictedGameplayTagList = 0;
	}
}