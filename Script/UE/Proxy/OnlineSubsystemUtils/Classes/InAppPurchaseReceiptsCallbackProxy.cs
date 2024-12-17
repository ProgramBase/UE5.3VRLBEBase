using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.OnlineSubsystemUtils
{
	[PathName("/Script/OnlineSubsystemUtils.InAppPurchaseReceiptsCallbackProxy")]
	public partial class UInAppPurchaseReceiptsCallbackProxy : UObject, IStaticClass
	{
		public FOnlineProxyInAppReceiptsResult OnSuccess
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnSuccess, __ReturnBuffer);

					return *(FOnlineProxyInAppReceiptsResult*)__ReturnBuffer;
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

		public FOnlineProxyInAppReceiptsResult OnFailure
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnFailure, __ReturnBuffer);

					return *(FOnlineProxyInAppReceiptsResult*)__ReturnBuffer;
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/OnlineSubsystemUtils.InAppPurchaseReceiptsCallbackProxy");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UInAppPurchaseReceiptsCallbackProxy CreateProxyObjectForInAppPurchaseRestoreOwnedProducts(APlayerController PlayerController)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateProxyObjectForInAppPurchaseRestoreOwnedProducts, __InBuffer, __ReturnBuffer);

				return *(UInAppPurchaseReceiptsCallbackProxy*)__ReturnBuffer;
			}
		}

		public static UInAppPurchaseReceiptsCallbackProxy CreateProxyObjectForInAppPurchaseQueryOwnedProducts(APlayerController PlayerController)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateProxyObjectForInAppPurchaseQueryOwnedProducts, __InBuffer, __ReturnBuffer);

				return *(UInAppPurchaseReceiptsCallbackProxy*)__ReturnBuffer;
			}
		}

		public static UInAppPurchaseReceiptsCallbackProxy CreateProxyObjectForInAppPurchaseGetKnownReceipts(APlayerController PlayerController)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateProxyObjectForInAppPurchaseGetKnownReceipts, __InBuffer, __ReturnBuffer);

				return *(UInAppPurchaseReceiptsCallbackProxy*)__ReturnBuffer;
			}
		}

		private static uint __OnSuccess = 0;

		private static uint __OnFailure = 0;

		private static uint __CreateProxyObjectForInAppPurchaseRestoreOwnedProducts = 0;

		private static uint __CreateProxyObjectForInAppPurchaseQueryOwnedProducts = 0;

		private static uint __CreateProxyObjectForInAppPurchaseGetKnownReceipts = 0;
	}
}