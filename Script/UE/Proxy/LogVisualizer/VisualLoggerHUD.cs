using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.LogVisualizer
{
	[PathName("/Script/LogVisualizer.VisualLoggerHUD")]
	public partial class AVisualLoggerHUD : ADebugCameraHUD, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LogVisualizer.VisualLoggerHUD");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}