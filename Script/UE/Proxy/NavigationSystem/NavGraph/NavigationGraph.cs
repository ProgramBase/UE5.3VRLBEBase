using Script.CoreUObject;
using Script.Library;

namespace Script.NavigationSystem
{
	[PathName("/Script/NavigationSystem.NavigationGraph")]
	public partial class ANavigationGraph : ANavigationData, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NavigationSystem.NavigationGraph");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}