using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.OnlineSubsystem;

namespace Script.OnlineSubsystemUtils
{
	[PathName("/Script/OnlineSubsystemUtils.FindTurnBasedMatchCallbackProxy")]
	public partial class UFindTurnBasedMatchCallbackProxy : UOnlineBlueprintCallProxyBase, IStaticClass
	{
		public FOnlineTurnBasedMatchResult OnSuccess
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnSuccess, __ReturnBuffer);

					return *(FOnlineTurnBasedMatchResult*)__ReturnBuffer;
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

		public FOnlineTurnBasedMatchResult OnFailure
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnFailure, __ReturnBuffer);

					return *(FOnlineTurnBasedMatchResult*)__ReturnBuffer;
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/OnlineSubsystemUtils.FindTurnBasedMatchCallbackProxy");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UFindTurnBasedMatchCallbackProxy FindTurnBasedMatch(UObject WorldContextObject, APlayerController PlayerController, TScriptInterface<ITurnBasedMatchInterface> MatchActor, int MinPlayers, int MaxPlayers, int PlayerGroup, bool ShowExistingMatches)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[37];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = MatchActor?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 24) = MinPlayers;

				*(int*)(__InBuffer + 28) = MaxPlayers;

				*(int*)(__InBuffer + 32) = PlayerGroup;

				*(bool*)(__InBuffer + 36) = ShowExistingMatches;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FindTurnBasedMatch, __InBuffer, __ReturnBuffer);

				return *(UFindTurnBasedMatchCallbackProxy*)__ReturnBuffer;
			}
		}

		private static uint __OnSuccess = 0;

		private static uint __OnFailure = 0;

		private static uint __FindTurnBasedMatch = 0;
	}
}