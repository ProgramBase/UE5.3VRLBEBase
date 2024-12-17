using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.NavigationSystem
{
	[PathName("/Script/NavigationSystem.NavMeshRenderingComponent")]
	public partial class UNavMeshRenderingComponent : UDebugDrawComponent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NavigationSystem.NavMeshRenderingComponent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}