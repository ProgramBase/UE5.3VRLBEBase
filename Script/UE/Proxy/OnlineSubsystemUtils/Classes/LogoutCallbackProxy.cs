using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.OnlineSubsystemUtils
{
	[PathName("/Script/OnlineSubsystemUtils.LogoutCallbackProxy")]
	public partial class ULogoutCallbackProxy : UBlueprintAsyncActionBase, IStaticClass
	{
		public FOnlineLogoutResult OnSuccess
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnSuccess, __ReturnBuffer);

					return *(FOnlineLogoutResult*)__ReturnBuffer;
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

		public FOnlineLogoutResult OnFailure
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnFailure, __ReturnBuffer);

					return *(FOnlineLogoutResult*)__ReturnBuffer;
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/OnlineSubsystemUtils.LogoutCallbackProxy");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static ULogoutCallbackProxy Logout(UObject WorldContextObject, APlayerController PlayerController)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Logout, __InBuffer, __ReturnBuffer);

				return *(ULogoutCallbackProxy*)__ReturnBuffer;
			}
		}

		private static uint __OnSuccess = 0;

		private static uint __OnFailure = 0;

		private static uint __Logout = 0;
	}
}