using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AsyncActionLoadPrimaryAssetClass")]
	public partial class UAsyncActionLoadPrimaryAssetClass : UAsyncActionLoadPrimaryAssetBase, IStaticClass
	{
		public FOnPrimaryAssetClassLoaded Completed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Completed, __ReturnBuffer);

					return *(FOnPrimaryAssetClassLoaded*)__ReturnBuffer;
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AsyncActionLoadPrimaryAssetClass");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UAsyncActionLoadPrimaryAssetClass AsyncLoadPrimaryAssetClass(UObject WorldContextObject, FPrimaryAssetId PrimaryAsset, TArray<FName> LoadBundles)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PrimaryAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = LoadBundles?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AsyncLoadPrimaryAssetClass, __InBuffer, __ReturnBuffer);

				return *(UAsyncActionLoadPrimaryAssetClass*)__ReturnBuffer;
			}
		}

		private static uint __Completed = 0;

		private static uint __AsyncLoadPrimaryAssetClass = 0;
	}
}