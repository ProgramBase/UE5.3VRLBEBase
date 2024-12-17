using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.OnlineSubsystemUtils
{
	[PathName("/Script/OnlineSubsystemUtils.ShowLoginUICallbackProxy")]
	public partial class UShowLoginUICallbackProxy : UBlueprintAsyncActionBase, IStaticClass
	{
		public FOnlineShowLoginUIResult OnSuccess
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnSuccess, __ReturnBuffer);

					return *(FOnlineShowLoginUIResult*)__ReturnBuffer;
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

		public FOnlineShowLoginUIResult OnFailure
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnFailure, __ReturnBuffer);

					return *(FOnlineShowLoginUIResult*)__ReturnBuffer;
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/OnlineSubsystemUtils.ShowLoginUICallbackProxy");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UShowLoginUICallbackProxy ShowExternalLoginUI(UObject WorldContextObject, APlayerController InPlayerController)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InPlayerController?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ShowExternalLoginUI, __InBuffer, __ReturnBuffer);

				return *(UShowLoginUICallbackProxy*)__ReturnBuffer;
			}
		}

		private static uint __OnSuccess = 0;

		private static uint __OnFailure = 0;

		private static uint __ShowExternalLoginUI = 0;
	}
}