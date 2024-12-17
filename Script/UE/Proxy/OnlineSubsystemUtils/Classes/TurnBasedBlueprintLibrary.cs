using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.OnlineSubsystemUtils
{
	[PathName("/Script/OnlineSubsystemUtils.TurnBasedBlueprintLibrary")]
	public partial class UTurnBasedBlueprintLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/OnlineSubsystemUtils.TurnBasedBlueprintLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void RegisterTurnBasedMatchInterfaceObject(UObject WorldContextObject, APlayerController PlayerController, UObject Object)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Object?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RegisterTurnBasedMatchInterfaceObject, __InBuffer);
			}
		}

		public static void GetPlayerDisplayName(UObject WorldContextObject, APlayerController PlayerController, FString MatchID, int PlayerIndex, ref FString PlayerDisplayName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[36];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = MatchID?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 24) = PlayerIndex;

				*(nint*)(__InBuffer + 28) = PlayerDisplayName?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetPlayerDisplayName, __InBuffer, __OutBuffer);

				PlayerDisplayName = *(FString*)(__OutBuffer);

			}
		}

		public static void GetMyPlayerIndex(UObject WorldContextObject, APlayerController PlayerController, FString MatchID, ref int PlayerIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = MatchID?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 24) = PlayerIndex;

				var __OutBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetMyPlayerIndex, __InBuffer, __OutBuffer);

				PlayerIndex = *(int*)(__OutBuffer);

			}
		}

		public static void GetIsMyTurn(UObject WorldContextObject, APlayerController PlayerController, FString MatchID, ref bool bIsMyTurn)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = MatchID?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bIsMyTurn;

				var __OutBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetIsMyTurn, __InBuffer, __OutBuffer);

				bIsMyTurn = *(bool*)(__OutBuffer);

			}
		}

		private static uint __RegisterTurnBasedMatchInterfaceObject = 0;

		private static uint __GetPlayerDisplayName = 0;

		private static uint __GetMyPlayerIndex = 0;

		private static uint __GetIsMyTurn = 0;
	}
}