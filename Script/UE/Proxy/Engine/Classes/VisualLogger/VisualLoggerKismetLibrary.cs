using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.VisualLoggerKismetLibrary")]
	public partial class UVisualLoggerKismetLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.VisualLoggerKismetLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void RedirectVislog(UObject SourceOwner, UObject DestinationOwner)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SourceOwner?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DestinationOwner?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RedirectVislog, __InBuffer);
			}
		}

		public static void LogText(UObject WorldContextObject, FString Text, FName LogCategory = null, bool bAddToMessageLog = false)
		{
			unsafe
			{
				LogCategory ??= new FName("VisLogBP");

				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Text?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = LogCategory?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bAddToMessageLog;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __LogText, __InBuffer);
			}
		}

		public static void LogSegment(UObject WorldContextObject, FVector SegmentStart, FVector SegmentEnd, FString Text, FLinearColor ObjectColor = null, float Thickness = 0.000000f, FName CategoryName = null, bool bAddToMessageLog = false)
		{
			unsafe
			{
				ObjectColor ??= new FLinearColor(0.000000f, 0.000000f, 1.000000f, 1.000000f);

				CategoryName ??= new FName("VisLogBP");

				var __InBuffer = stackalloc byte[53];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SegmentStart?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SegmentEnd?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Text?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = ObjectColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 40) = Thickness;

				*(nint*)(__InBuffer + 44) = CategoryName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 52) = bAddToMessageLog;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __LogSegment, __InBuffer);
			}
		}

		public static void LogLocation(UObject WorldContextObject, FVector Location, FString Text, FLinearColor ObjectColor = null, float Radius = 10.000000f, FName LogCategory = null, bool bAddToMessageLog = false)
		{
			unsafe
			{
				ObjectColor ??= new FLinearColor(0.000000f, 0.000000f, 1.000000f, 1.000000f);

				LogCategory ??= new FName("VisLogBP");

				var __InBuffer = stackalloc byte[45];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Text?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ObjectColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 32) = Radius;

				*(nint*)(__InBuffer + 36) = LogCategory?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 44) = bAddToMessageLog;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __LogLocation, __InBuffer);
			}
		}

		public static void LogBox(UObject WorldContextObject, FBox BoxShape, FString Text, FLinearColor ObjectColor = null, FName LogCategory = null, bool bAddToMessageLog = false)
		{
			unsafe
			{
				ObjectColor ??= new FLinearColor(0.000000f, 0.000000f, 1.000000f, 1.000000f);

				LogCategory ??= new FName("VisLogBP");

				var __InBuffer = stackalloc byte[41];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoxShape?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Text?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ObjectColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = LogCategory?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 40) = bAddToMessageLog;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __LogBox, __InBuffer);
			}
		}

		public static void EnableRecording(bool bEnabled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bEnabled;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __EnableRecording, __InBuffer);
			}
		}

		private static uint __RedirectVislog = 0;

		private static uint __LogText = 0;

		private static uint __LogSegment = 0;

		private static uint __LogLocation = 0;

		private static uint __LogBox = 0;

		private static uint __EnableRecording = 0;
	}
}