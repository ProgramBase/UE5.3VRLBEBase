using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.OnlineSubsystemUtils
{
	[PathName("/Script/OnlineSubsystemUtils.InAppPurchaseFinalizeProxy")]
	public partial class UInAppPurchaseFinalizeProxy : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/OnlineSubsystemUtils.InAppPurchaseFinalizeProxy");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UInAppPurchaseFinalizeProxy CreateProxyObjectForInAppPurchaseFinalize(FInAppPurchaseReceiptInfo2 InAppPurchaseReceipt, APlayerController PlayerController)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InAppPurchaseReceipt?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateProxyObjectForInAppPurchaseFinalize, __InBuffer, __ReturnBuffer);

				return *(UInAppPurchaseFinalizeProxy*)__ReturnBuffer;
			}
		}

		private static uint __CreateProxyObjectForInAppPurchaseFinalize = 0;
	}
}