using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.NavigationSystem
{
	[PathName("/Script/NavigationSystem.NavTestRenderingComponent")]
	public partial class UNavTestRenderingComponent : UDebugDrawComponent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NavigationSystem.NavTestRenderingComponent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}