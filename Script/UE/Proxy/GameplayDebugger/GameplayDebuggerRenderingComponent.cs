using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.GameplayDebugger
{
	[PathName("/Script/GameplayDebugger.GameplayDebuggerRenderingComponent")]
	public partial class UGameplayDebuggerRenderingComponent : UDebugDrawComponent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameplayDebugger.GameplayDebuggerRenderingComponent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}