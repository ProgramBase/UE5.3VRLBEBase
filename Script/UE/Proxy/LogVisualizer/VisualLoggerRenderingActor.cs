using Script.CoreUObject;
using Script.Library;

namespace Script.LogVisualizer
{
	[PathName("/Script/LogVisualizer.VisualLoggerRenderingActor")]
	public partial class AVisualLoggerRenderingActor : AVisualLoggerRenderingActorBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LogVisualizer.VisualLoggerRenderingActor");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}