using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.OnlineSubsystemUtils
{
	[PathName("/Script/OnlineSubsystemUtils.LeaderboardBlueprintLibrary")]
	public partial class ULeaderboardBlueprintLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/OnlineSubsystemUtils.LeaderboardBlueprintLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static bool WriteLeaderboardInteger(APlayerController PlayerController, FName StatName, int StatValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = StatName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = StatValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __WriteLeaderboardInteger, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __WriteLeaderboardInteger = 0;
	}
}