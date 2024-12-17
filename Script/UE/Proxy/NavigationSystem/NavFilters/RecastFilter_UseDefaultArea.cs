using Script.CoreUObject;
using Script.Library;

namespace Script.NavigationSystem
{
	[PathName("/Script/NavigationSystem.RecastFilter_UseDefaultArea")]
	public partial class URecastFilter_UseDefaultArea : UNavigationQueryFilter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NavigationSystem.RecastFilter_UseDefaultArea");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}