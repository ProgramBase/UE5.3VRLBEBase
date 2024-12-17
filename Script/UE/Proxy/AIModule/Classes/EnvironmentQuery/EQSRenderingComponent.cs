using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EQSRenderingComponent")]
	public partial class UEQSRenderingComponent : UDebugDrawComponent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.EQSRenderingComponent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}