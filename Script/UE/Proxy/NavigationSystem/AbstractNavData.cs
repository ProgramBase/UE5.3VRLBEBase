using Script.CoreUObject;
using Script.Library;

namespace Script.NavigationSystem
{
	[PathName("/Script/NavigationSystem.AbstractNavData")]
	public partial class AAbstractNavData : ANavigationData, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NavigationSystem.AbstractNavData");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}