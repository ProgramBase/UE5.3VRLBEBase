using Script.CoreUObject;
using Script.NavigationSystem;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EnvQueryGenerator_PathingGrid")]
	public partial class UEnvQueryGenerator_PathingGrid : UEnvQueryGenerator_SimpleGrid, IStaticClass
	{
		public FAIDataProviderBoolValue PathToItem
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PathToItem, __ReturnBuffer);

					return *(FAIDataProviderBoolValue*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PathToItem, __InBuffer);
				}
			}
		}

		public TSubclassOf<UNavigationQueryFilter> NavigationFilter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NavigationFilter, __ReturnBuffer);

					return *(TSubclassOf<UNavigationQueryFilter>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NavigationFilter, __InBuffer);
				}
			}
		}

		public FAIDataProviderFloatValue ScanRangeMultiplier
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ScanRangeMultiplier, __ReturnBuffer);

					return *(FAIDataProviderFloatValue*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ScanRangeMultiplier, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.EnvQueryGenerator_PathingGrid");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __PathToItem = 0;

		private static uint __NavigationFilter = 0;

		private static uint __ScanRangeMultiplier = 0;
	}
}