using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.OnlineSubsystemUtils
{
	[PathName("/Script/OnlineSubsystemUtils.InAppPurchaseCheckoutCallbackProxy")]
	public partial class UInAppPurchaseCheckoutCallbackProxy : UObject, IStaticClass
	{
		public FOnlineProxyInAppCheckoutResult OnSuccess
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnSuccess, __ReturnBuffer);

					return *(FOnlineProxyInAppCheckoutResult*)__ReturnBuffer;
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

		public FOnlineProxyInAppCheckoutResult OnFailure
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnFailure, __ReturnBuffer);

					return *(FOnlineProxyInAppCheckoutResult*)__ReturnBuffer;
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/OnlineSubsystemUtils.InAppPurchaseCheckoutCallbackProxy");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UInAppPurchaseCheckoutCallbackProxy CreateProxyObjectForInAppPurchaseCheckout(APlayerController PlayerController, FInAppPurchaseProductRequest2 ProductRequest)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ProductRequest?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateProxyObjectForInAppPurchaseCheckout, __InBuffer, __ReturnBuffer);

				return *(UInAppPurchaseCheckoutCallbackProxy*)__ReturnBuffer;
			}
		}

		private static uint __OnSuccess = 0;

		private static uint __OnFailure = 0;

		private static uint __CreateProxyObjectForInAppPurchaseCheckout = 0;
	}
}