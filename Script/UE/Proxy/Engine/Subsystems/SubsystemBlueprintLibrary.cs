using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SubsystemBlueprintLibrary")]
	public partial class USubsystemBlueprintLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SubsystemBlueprintLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UWorldSubsystem GetWorldSubsystem(UObject ContextObject, TSubclassOf<UWorldSubsystem> Class)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Class?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetWorldSubsystem, __InBuffer, __ReturnBuffer);

				return *(UWorldSubsystem*)__ReturnBuffer;
			}
		}

		public static ULocalPlayerSubsystem GetLocalPlayerSubSystemFromPlayerController(APlayerController PlayerController, TSubclassOf<ULocalPlayerSubsystem> Class)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PlayerController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Class?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLocalPlayerSubSystemFromPlayerController, __InBuffer, __ReturnBuffer);

				return *(ULocalPlayerSubsystem*)__ReturnBuffer;
			}
		}

		public static ULocalPlayerSubsystem GetLocalPlayerSubsystem(UObject ContextObject, TSubclassOf<ULocalPlayerSubsystem> Class)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Class?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLocalPlayerSubsystem, __InBuffer, __ReturnBuffer);

				return *(ULocalPlayerSubsystem*)__ReturnBuffer;
			}
		}

		public static UGameInstanceSubsystem GetGameInstanceSubsystem(UObject ContextObject, TSubclassOf<UGameInstanceSubsystem> Class)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Class?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetGameInstanceSubsystem, __InBuffer, __ReturnBuffer);

				return *(UGameInstanceSubsystem*)__ReturnBuffer;
			}
		}

		public static UEngineSubsystem GetEngineSubsystem(TSubclassOf<UEngineSubsystem> Class)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Class?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetEngineSubsystem, __InBuffer, __ReturnBuffer);

				return *(UEngineSubsystem*)__ReturnBuffer;
			}
		}

		public static UAudioEngineSubsystem GetAudioEngineSubsystem(UObject ContextObject, TSubclassOf<UAudioEngineSubsystem> Class)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Class?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetAudioEngineSubsystem, __InBuffer, __ReturnBuffer);

				return *(UAudioEngineSubsystem*)__ReturnBuffer;
			}
		}

		private static uint __GetWorldSubsystem = 0;

		private static uint __GetLocalPlayerSubSystemFromPlayerController = 0;

		private static uint __GetLocalPlayerSubsystem = 0;

		private static uint __GetGameInstanceSubsystem = 0;

		private static uint __GetEngineSubsystem = 0;

		private static uint __GetAudioEngineSubsystem = 0;
	}
}