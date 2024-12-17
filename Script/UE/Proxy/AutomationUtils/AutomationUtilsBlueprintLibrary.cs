using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AutomationUtils
{
	[PathName("/Script/AutomationUtils.AutomationUtilsBlueprintLibrary")]
	public partial class UAutomationUtilsBlueprintLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AutomationUtils.AutomationUtilsBlueprintLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void TakeGameplayAutomationScreenshot(FString ScreenshotName, float MaxGlobalError = 0.020000f, float MaxLocalError = 0.120000f, FString MapNameOverride = null)
		{
			unsafe
			{
				MapNameOverride ??= new FString("");

				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = ScreenshotName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = MaxGlobalError;

				*(float*)(__InBuffer + 12) = MaxLocalError;

				*(nint*)(__InBuffer + 16) = MapNameOverride?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __TakeGameplayAutomationScreenshot, __InBuffer);
			}
		}

		private static uint __TakeGameplayAutomationScreenshot = 0;
	}
}