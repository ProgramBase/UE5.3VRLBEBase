using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.OnlineSubsystemUtils
{
	[PathName("/Script/OnlineSubsystemUtils.InAppPurchaseCallbackProxy2")]
	public partial class UInAppPurchaseCallbackProxy2 : UObject, IStaticClass
	{
		public FInAppPurchaseResult2 OnSuccess
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnSuccess, __ReturnBuffer);

					return *(FInAppPurchaseResult2*)__ReturnBuffer;
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

		public FInAppPurchaseResult2 OnFailure
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnFailure, __ReturnBuffer);

					return *(FInAppPurchaseResult2*)__ReturnBuffer;
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/OnlineSubsystemUtils.InAppPurchaseCallbackProxy2");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UInAppPurchaseCallbackProxy2 CreateProxyObjectForInAppPurchaseUnprocessedPurchases(APlayerController PlayerController)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateProxyObjectForInAppPurchaseUnprocessedPurchases, __InBuffer, __ReturnBuffer);

				return *(UInAppPurchaseCallbackProxy2*)__ReturnBuffer;
			}
		}

		public static UInAppPurchaseCallbackProxy2 CreateProxyObjectForInAppPurchaseQueryOwned(APlayerController PlayerController)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateProxyObjectForInAppPurchaseQueryOwned, __InBuffer, __ReturnBuffer);

				return *(UInAppPurchaseCallbackProxy2*)__ReturnBuffer;
			}
		}

		public static UInAppPurchaseCallbackProxy2 CreateProxyObjectForInAppPurchase(APlayerController PlayerController, FInAppPurchaseProductRequest2 ProductRequest)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ProductRequest?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateProxyObjectForInAppPurchase, __InBuffer, __ReturnBuffer);

				return *(UInAppPurchaseCallbackProxy2*)__ReturnBuffer;
			}
		}

		private static uint __OnSuccess = 0;

		private static uint __OnFailure = 0;

		private static uint __CreateProxyObjectForInAppPurchaseUnprocessedPurchases = 0;

		private static uint __CreateProxyObjectForInAppPurchaseQueryOwned = 0;

		private static uint __CreateProxyObjectForInAppPurchase = 0;
	}
}