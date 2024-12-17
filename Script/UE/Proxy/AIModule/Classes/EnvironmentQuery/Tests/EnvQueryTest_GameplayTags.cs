using Script.CoreUObject;
using Script.GameplayTags;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EnvQueryTest_GameplayTags")]
	public partial class UEnvQueryTest_GameplayTags : UEnvQueryTest, IStaticClass
	{
		public FGameplayTagQuery TagQueryToMatch
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TagQueryToMatch, __ReturnBuffer);

					return *(FGameplayTagQuery*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TagQueryToMatch, __InBuffer);
				}
			}
		}

		public bool bRejectIncompatibleItems
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bRejectIncompatibleItems, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bRejectIncompatibleItems, __InBuffer);
				}
			}
		}

		public bool bUpdatedToUseQuery
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUpdatedToUseQuery, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUpdatedToUseQuery, __InBuffer);
				}
			}
		}

		public EGameplayContainerMatchType TagsToMatch
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TagsToMatch, __ReturnBuffer);

					return *(EGameplayContainerMatchType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TagsToMatch, __InBuffer);
				}
			}
		}

		public FGameplayTagContainer GameplayTags
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GameplayTags, __ReturnBuffer);

					return *(FGameplayTagContainer*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GameplayTags, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.EnvQueryTest_GameplayTags");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __TagQueryToMatch = 0;

		private static uint __bRejectIncompatibleItems = 0;

		private static uint __bUpdatedToUseQuery = 0;

		private static uint __TagsToMatch = 0;

		private static uint __GameplayTags = 0;
	}
}