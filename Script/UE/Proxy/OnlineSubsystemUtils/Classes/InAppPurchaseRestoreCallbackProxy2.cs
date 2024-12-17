using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.OnlineSubsystemUtils
{
	[PathName("/Script/OnlineSubsystemUtils.InAppPurchaseRestoreCallbackProxy2")]
	public partial class UInAppPurchaseRestoreCallbackProxy2 : UObject, IStaticClass
	{
		public FInAppPurchaseRestoreResult2 OnSuccess
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnSuccess, __ReturnBuffer);

					return *(FInAppPurchaseRestoreResult2*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnSuccess, __InBuffer);
				}
			}
		}

		public FInAppPurchaseRestoreResult2 OnFailure
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnFailure, __ReturnBuffer);

					return *(FInAppPurchaseRestoreResult2*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnFailure, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/OnlineSubsystemUtils.InAppPurchaseRestoreCallbackProxy2");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UInAppPurchaseRestoreCallbackProxy2 CreateProxyObjectForInAppPurchaseRestore(TArray<FInAppPurchaseProductRequest2> ConsumableProductFlags, APlayerController PlayerController)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ConsumableProductFlags?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateProxyObjectForInAppPurchaseRestore, __InBuffer, __ReturnBuffer);

				return *(UInAppPurchaseRestoreCallbackProxy2*)__ReturnBuffer;
			}
		}

		private static uint __OnSuccess = 0;

		private static uint __OnFailure = 0;

		private static uint __CreateProxyObjectForInAppPurchaseRestore = 0;
	}
}