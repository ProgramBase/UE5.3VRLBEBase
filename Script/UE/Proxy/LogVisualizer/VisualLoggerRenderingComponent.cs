using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.LogVisualizer
{
	[PathName("/Script/LogVisualizer.VisualLoggerRenderingComponent")]
	public partial class UVisualLoggerRenderingComponent : UDebugDrawComponent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LogVisualizer.VisualLoggerRenderingComponent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}