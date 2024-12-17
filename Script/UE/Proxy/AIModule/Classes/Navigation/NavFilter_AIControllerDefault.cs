using Script.CoreUObject;
using Script.NavigationSystem;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.NavFilter_AIControllerDefault")]
	public partial class UNavFilter_AIControllerDefault : UNavigationQueryFilter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.NavFilter_AIControllerDefault");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}