using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.LogVisualizer
{
	[PathName("/Script/LogVisualizer.VisualLoggerRenderingActorBase")]
	public partial class AVisualLoggerRenderingActorBase : AActor, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LogVisualizer.VisualLoggerRenderingActorBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}