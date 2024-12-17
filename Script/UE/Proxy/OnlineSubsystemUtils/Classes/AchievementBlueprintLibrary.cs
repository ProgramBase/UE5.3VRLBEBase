using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.OnlineSubsystemUtils
{
	[PathName("/Script/OnlineSubsystemUtils.AchievementBlueprintLibrary")]
	public partial class UAchievementBlueprintLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/OnlineSubsystemUtils.AchievementBlueprintLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void GetCachedAchievementProgress(UObject WorldContextObject, APlayerController PlayerController, FName AchievementID, ref bool bFoundID, ref float Progress)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[29];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = AchievementID?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bFoundID;

				*(float*)(__InBuffer + 25) = Progress;

				var __OutBuffer = stackalloc byte[5];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetCachedAchievementProgress, __InBuffer, __OutBuffer);

				bFoundID = *(bool*)(__OutBuffer);

				Progress = *(float*)(__OutBuffer + 1);

			}
		}

		public static void GetCachedAchievementDescription(UObject WorldContextObject, APlayerController PlayerController, FName AchievementID, ref bool bFoundID, ref FText Title, ref FText LockedDescription, ref FText UnlockedDescription, ref bool bHidden)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[50];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = AchievementID?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bFoundID;

				*(nint*)(__InBuffer + 25) = Title?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 33) = LockedDescription?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 41) = UnlockedDescription?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 49) = bHidden;

				var __OutBuffer = stackalloc byte[26];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetCachedAchievementDescription, __InBuffer, __OutBuffer);

				bFoundID = *(bool*)(__OutBuffer);

				Title = *(FText*)(__OutBuffer + 1);

				LockedDescription = *(FText*)(__OutBuffer + 9);

				UnlockedDescription = *(FText*)(__OutBuffer + 17);

				bHidden = *(bool*)(__OutBuffer + 25);

			}
		}

		private static uint __GetCachedAchievementProgress = 0;

		private static uint __GetCachedAchievementDescription = 0;
	}
}