using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AsyncActionLoadPrimaryAssetClassList")]
	public partial class UAsyncActionLoadPrimaryAssetClassList : UAsyncActionLoadPrimaryAssetBase, IStaticClass
	{
		public FOnPrimaryAssetClassListLoaded Completed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Completed, __ReturnBuffer);

					return *(FOnPrimaryAssetClassListLoaded*)__ReturnBuffer;
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AsyncActionLoadPrimaryAssetClassList");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UAsyncActionLoadPrimaryAssetClassList AsyncLoadPrimaryAssetClassList(UObject WorldContextObject, TArray<FPrimaryAssetId> PrimaryAssetList, TArray<FName> LoadBundles)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PrimaryAssetList?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = LoadBundles?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AsyncLoadPrimaryAssetClassList, __InBuffer, __ReturnBuffer);

				return *(UAsyncActionLoadPrimaryAssetClassList*)__ReturnBuffer;
			}
		}

		private static uint __Completed = 0;

		private static uint __AsyncLoadPrimaryAssetClassList = 0;
	}
}