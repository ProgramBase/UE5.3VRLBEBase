using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.FunctionalTesting
{
	[PathName("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary")]
	public partial class UAutomationBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FunctionalTesting.AutomationBlueprintFunctionLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UAutomationEditorTask TakeHighResScreenshot(int ResX, int ResY, FString Filename, ACameraActor Camera = null, bool bMaskEnabled = false, bool bCaptureHDR = false, EComparisonTolerance ComparisonTolerance = EComparisonTolerance.Low, FString ComparisonNotes = null, float Delay = 0.000000f)
		{
			unsafe
			{
				ComparisonNotes ??= new FString("");

				var __InBuffer = stackalloc byte[39];

				*(int*)(__InBuffer) = ResX;

				*(int*)(__InBuffer + 4) = ResY;

				*(nint*)(__InBuffer + 8) = Filename?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Camera?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bMaskEnabled;

				*(bool*)(__InBuffer + 25) = bCaptureHDR;

				*(byte*)(__InBuffer + 26) = (byte)ComparisonTolerance;

				*(nint*)(__InBuffer + 27) = ComparisonNotes?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 35) = Delay;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __TakeHighResScreenshot, __InBuffer, __ReturnBuffer);

				return *(UAutomationEditorTask*)__ReturnBuffer;
			}
		}

		public static void TakeAutomationScreenshotOfUI(UObject WorldContextObject, FLatentActionInfo LatentInfo, FString Name, FAutomationScreenshotOptions Options)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LatentInfo?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Options?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __TakeAutomationScreenshotOfUI, __InBuffer);
			}
		}

		public static void TakeAutomationScreenshotAtCamera(UObject WorldContextObject, FLatentActionInfo LatentInfo, ACameraActor Camera, FString NameOverride, FString Notes, FAutomationScreenshotOptions Options)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[48];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LatentInfo?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Camera?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = NameOverride?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Notes?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = Options?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __TakeAutomationScreenshotAtCamera, __InBuffer);
			}
		}

		public static void TakeAutomationScreenshot(UObject WorldContextObject, FLatentActionInfo LatentInfo, FString Name, FString Notes, FAutomationScreenshotOptions Options)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[40];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LatentInfo?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Notes?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Options?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __TakeAutomationScreenshot, __InBuffer);
			}
		}

		public static void SetTestTelemetryStorage(FString StorageName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = StorageName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetTestTelemetryStorage, __InBuffer);
			}
		}

		public static void SetScalabilityQualityToLow(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetScalabilityQualityToLow, __InBuffer);
			}
		}

		public static void SetScalabilityQualityToEpic(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetScalabilityQualityToEpic, __InBuffer);
			}
		}

		/// <param name="Value">
		/// 0:Cinematic, 1:Epic...etc.
		/// </param>
		public static void SetScalabilityQualityLevelRelativeToMax(UObject WorldContextObject, int Value = 1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetScalabilityQualityLevelRelativeToMax, __InBuffer);
			}
		}

		public static void SetEditorViewportVisualizeBuffer(FName BufferName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BufferName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetEditorViewportVisualizeBuffer, __InBuffer);
			}
		}

		public static void SetEditorViewportViewMode(EViewModeIndex Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)Index;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetEditorViewportViewMode, __InBuffer);
			}
		}

		public static float GetStatIncMax(FName StatName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = StatName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetStatIncMax, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static float GetStatIncAverage(FName StatName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = StatName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetStatIncAverage, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static float GetStatExcMax(FName StatName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = StatName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetStatExcMax, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static float GetStatExcAverage(FName StatName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = StatName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetStatExcAverage, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static float GetStatCallCount(FName StatName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = StatName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetStatCallCount, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static FAutomationScreenshotOptions GetDefaultScreenshotOptionsForRendering(EComparisonTolerance Tolerance = EComparisonTolerance.Low, float Delay = 0.200000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(byte*)(__InBuffer) = (byte)Tolerance;

				*(float*)(__InBuffer + 1) = Delay;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetDefaultScreenshotOptionsForRendering, __InBuffer, __ReturnBuffer);

				return *(FAutomationScreenshotOptions*)__ReturnBuffer;
			}
		}

		public static FAutomationScreenshotOptions GetDefaultScreenshotOptionsForGameplay(EComparisonTolerance Tolerance = EComparisonTolerance.Low, float Delay = 0.200000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(byte*)(__InBuffer) = (byte)Tolerance;

				*(float*)(__InBuffer + 1) = Delay;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetDefaultScreenshotOptionsForGameplay, __InBuffer, __ReturnBuffer);

				return *(FAutomationScreenshotOptions*)__ReturnBuffer;
			}
		}

		public static void FinishLoadingBeforeScreenshot()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __FinishLoadingBeforeScreenshot);
			}
		}

		public static void EnableStatGroup(UObject WorldContextObject, FName GroupName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = GroupName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __EnableStatGroup, __InBuffer);
			}
		}

		public static void DisableStatGroup(UObject WorldContextObject, FName GroupName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = GroupName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __DisableStatGroup, __InBuffer);
			}
		}

		/// <param name="ImageFilePath">
		/// Absolute path to the image location. All 8bit RGBA channels supported formats by the engine are accepted.
		/// </param>
		/// <param name="ComparisonName">
		/// Optional name for the comparison, by default the basename of ImageFilePath is used
		/// </param>
		/// <returns>
		/// True if comparison was successfully enqueued
		/// </returns>
		public static bool CompareImageAgainstReference(FString ImageFilePath, FString ComparisonName = null, EComparisonTolerance ComparisonTolerance = EComparisonTolerance.Low, FString ComparisonNotes = null, UObject WorldContextObject = null)
		{
			unsafe
			{
				ComparisonName ??= new FString("");

				ComparisonNotes ??= new FString("");

				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = ImageFilePath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ComparisonName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)ComparisonTolerance;

				*(nint*)(__InBuffer + 17) = ComparisonNotes?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 25) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __CompareImageAgainstReference, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void AutomationWaitForLoading(UObject WorldContextObject, FLatentActionInfo LatentInfo, FAutomationWaitForLoadingOptions Options)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LatentInfo?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Options?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __AutomationWaitForLoading, __InBuffer);
			}
		}

		public static bool AreAutomatedTestsRunning()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __AreAutomatedTestsRunning, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void AddTestTelemetryData(FString DataPoint, float Measurement, FString Context = null)
		{
			unsafe
			{
				Context ??= new FString("");

				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = DataPoint?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Measurement;

				*(nint*)(__InBuffer + 12) = Context?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __AddTestTelemetryData, __InBuffer);
			}
		}

		public static void AddExpectedLogError(FString ExpectedPatternString, int Occurrences = 1, bool ExactMatch = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = ExpectedPatternString?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Occurrences;

				*(bool*)(__InBuffer + 12) = ExactMatch;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __AddExpectedLogError, __InBuffer);
			}
		}

		private static uint __TakeHighResScreenshot = 0;

		private static uint __TakeAutomationScreenshotOfUI = 0;

		private static uint __TakeAutomationScreenshotAtCamera = 0;

		private static uint __TakeAutomationScreenshot = 0;

		private static uint __SetTestTelemetryStorage = 0;

		private static uint __SetScalabilityQualityToLow = 0;

		private static uint __SetScalabilityQualityToEpic = 0;

		private static uint __SetScalabilityQualityLevelRelativeToMax = 0;

		private static uint __SetEditorViewportVisualizeBuffer = 0;

		private static uint __SetEditorViewportViewMode = 0;

		private static uint __GetStatIncMax = 0;

		private static uint __GetStatIncAverage = 0;

		private static uint __GetStatExcMax = 0;

		private static uint __GetStatExcAverage = 0;

		private static uint __GetStatCallCount = 0;

		private static uint __GetDefaultScreenshotOptionsForRendering = 0;

		private static uint __GetDefaultScreenshotOptionsForGameplay = 0;

		private static uint __FinishLoadingBeforeScreenshot = 0;

		private static uint __EnableStatGroup = 0;

		private static uint __DisableStatGroup = 0;

		private static uint __CompareImageAgainstReference = 0;

		private static uint __AutomationWaitForLoading = 0;

		private static uint __AreAutomatedTestsRunning = 0;

		private static uint __AddTestTelemetryData = 0;

		private static uint __AddExpectedLogError = 0;
	}
}