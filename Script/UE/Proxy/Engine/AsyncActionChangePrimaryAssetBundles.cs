using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AsyncActionChangePrimaryAssetBundles")]
	public partial class UAsyncActionChangePrimaryAssetBundles : UAsyncActionLoadPrimaryAssetBase, IStaticClass
	{
		public FOnPrimaryAssetBundlesChanged Completed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Completed, __ReturnBuffer);

					return *(FOnPrimaryAssetBundlesChanged*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Completed, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AsyncActionChangePrimaryAssetBundles");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UAsyncActionChangePrimaryAssetBundles AsyncChangeBundleStateForPrimaryAssetList(UObject WorldContextObject, TArray<FPrimaryAssetId> PrimaryAssetList, TArray<FName> AddBundles, TArray<FName> RemoveBundles)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PrimaryAssetList?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = AddBundles?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = RemoveBundles?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AsyncChangeBundleStateForPrimaryAssetList, __InBuffer, __ReturnBuffer);

				return *(UAsyncActionChangePrimaryAssetBundles*)__ReturnBuffer;
			}
		}

		public static UAsyncActionChangePrimaryAssetBundles AsyncChangeBundleStateForMatchingPrimaryAssets(UObject WorldContextObject, TArray<FName> NewBundles, TArray<FName> OldBundles)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewBundles?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OldBundles?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AsyncChangeBundleStateForMatchingPrimaryAssets, __InBuffer, __ReturnBuffer);

				return *(UAsyncActionChangePrimaryAssetBundles*)__ReturnBuffer;
			}
		}

		private static uint __Completed = 0;

		private static uint __AsyncChangeBundleStateForPrimaryAssetList = 0;

		private static uint __AsyncChangeBundleStateForMatchingPrimaryAssets = 0;
	}
}