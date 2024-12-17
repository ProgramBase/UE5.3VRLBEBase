using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AutomationUtilsEditor
{
	[PathName("/Script/AutomationUtilsEditor.ScreenshotComparisonCommandlet")]
	public partial class UScreenshotComparisonCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AutomationUtilsEditor.ScreenshotComparisonCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}