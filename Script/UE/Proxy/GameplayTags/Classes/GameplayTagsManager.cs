using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.GameplayTags
{
	[PathName("/Script/GameplayTags.GameplayTagsManager")]
	public partial class UGameplayTagsManager : UObject, IStaticClass
	{
		public TMap<FName, FGameplayTagSource> TagSources
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TagSources, __ReturnBuffer);

					return *(TMap<FName, FGameplayTagSource>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TagSources, __InBuffer);
				}
			}
		}

		public TArray<UDataTable> GameplayTagTables
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GameplayTagTables, __ReturnBuffer);

					return *(TArray<UDataTable>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GameplayTagTables, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameplayTags.GameplayTagsManager");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __TagSources = 0;

		private static uint __GameplayTagTables = 0;
	}
}