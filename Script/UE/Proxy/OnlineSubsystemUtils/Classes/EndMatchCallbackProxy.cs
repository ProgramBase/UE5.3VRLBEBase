using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.OnlineSubsystem;

namespace Script.OnlineSubsystemUtils
{
	[PathName("/Script/OnlineSubsystemUtils.EndMatchCallbackProxy")]
	public partial class UEndMatchCallbackProxy : UOnlineBlueprintCallProxyBase, IStaticClass
	{
		public FEmptyOnlineDelegate OnSuccess
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnSuccess, __ReturnBuffer);

					return *(FEmptyOnlineDelegate*)__ReturnBuffer;
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

		public FEmptyOnlineDelegate OnFailure
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnFailure, __ReturnBuffer);

					return *(FEmptyOnlineDelegate*)__ReturnBuffer;
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/OnlineSubsystemUtils.EndMatchCallbackProxy");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UEndMatchCallbackProxy EndMatch(UObject WorldContextObject, APlayerController PlayerController, TScriptInterface<ITurnBasedMatchInterface> MatchActor, FString MatchID, EMPMatchOutcome LocalPlayerOutcome, EMPMatchOutcome OtherPlayersOutcome)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[34];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = MatchActor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = MatchID?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 32) = (byte)LocalPlayerOutcome;

				*(byte*)(__InBuffer + 33) = (byte)OtherPlayersOutcome;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __EndMatch, __InBuffer, __ReturnBuffer);

				return *(UEndMatchCallbackProxy*)__ReturnBuffer;
			}
		}

		private static uint __OnSuccess = 0;

		private static uint __OnFailure = 0;

		private static uint __EndMatch = 0;
	}
}